-- Scripts have to be deployed at SH SHEMA ON PDBORTW

-- Table for capture Users Activity in Application
CREATE TABLE ClientAppUserActivity
(
	ActivityID	  NUMBER(10)  NOT NULL ,
    UserID		  NUMBER(10)  NULL, 
	Description	  VARCHAR2(200 CHAR)  NULL ,
	ActivityTime  DATE  NULL 	
);



CREATE UNIQUE INDEX XPKClientAppUserActivity ON ClientAppUserActivity
(ActivityID  ASC);



ALTER TABLE ClientAppUserActivity
	ADD CONSTRAINT  XPKClientAppUserActivity PRIMARY KEY (ActivityID);


-- Table contains User Accounts Data
CREATE TABLE ClientAppUsers
(
	UserID		  NUMBER(10)  NOT NULL ,
	Login		  VARCHAR2(40 CHAR)  NULL ,
	Pass		  VARCHAR2(20 CHAR)  NULL ,
	PassHash	  VARCHAR2(200 CHAR)  NULL ,
	IsBlock		  CHAR(1 CHAR)  NULL ,
	IsAdmin		  CHAR(1 CHAR)  NULL ,
	FName		  VARCHAR2(60 CHAR)  NULL ,
	LName		  VARCHAR2(60 CHAR)  NULL ,
	MName		  VARCHAR2(60 CHAR)  NULL ,
	Email		  VARCHAR2(150 CHAR)  NULL ,
	Phone		  VARCHAR2(20 CHAR)   SORT ,
	Adress		  VARCHAR2(150 CHAR)  NULL ,
	Gender		  VARCHAR2(15 CHAR)  NULL ,
	Avatar		  BLOB  NULL 
);



CREATE UNIQUE INDEX XPKClientAppUsers ON ClientAppUsers
(UserID  ASC);



ALTER TABLE ClientAppUsers
	ADD CONSTRAINT  XPKClientAppUsers PRIMARY KEY (UserID);

-- Sequence for AutoID via Trigger for ClientAppUsers Table
CREATE SEQUENCE ClientIDSeq
INCREMENT BY 1
START WITH 1
MAXVALUE 999999999
MINVALUE 1
NOCYCLE;
-- Sequence for AutoID via Trigger for ClientAppUserActivity Table
CREATE SEQUENCE ActivityIDSeq
INCREMENT BY 1
START WITH 1
MAXVALUE 999999999
MINVALUE 1
NOCYCLE;
-- Trigger for AutoID for ClientAppUsers Table
CREATE OR REPLACE TRIGGER NewAppClientID
BEFORE INSERT ON ClientAppUsers
FOR EACH ROW
DECLARE

BEGIN
:new.UserID := ClientIDSeq.NEXTVAL;
INSERT INTO ClientModuleAccess(UserID) VALUES(ClientIDSeq.CURRVAL);
END NewAppClientID;
-- Trigger for AutoID for ClientAppUserActivity Table
CREATE OR REPLACE TRIGGER NewUserActivityId
BEFORE INSERT ON ClientAppUserActivity
FOR EACH ROW
DECLARE

BEGIN
:new.ActivityID := ActivityIDSeq.NEXTVAL;
END NewUserActivityId;

--Add Colum PassSalt in ClientAppUsers Table
ALTER TABLE ClientAppUsers ADD PassSalt VARCHAR2(200 CHAR);

--Table Contains Info About Access To Modules
CREATE TABLE ClientModuleAccess
(
	UserID		  NUMBER(10)  NOT NULL 
);

CREATE UNIQUE INDEX XPKClientModuleAccess ON ClientModuleAccess
(UserID  ASC);

ALTER TABLE ClientModuleAccess
	ADD CONSTRAINT  XPKClientModuleAccess PRIMARY KEY (UserID);

-- Trigger AutoDelete ClientModuleAccess record before delete ClientAppUsers record
CREATE OR REPLACE TRIGGER DeleteAppClientID
BEFORE DELETE ON ClientAppUsers
FOR EACH ROW
DECLARE

BEGIN
DELETE FROM ClientModuleAccess WHERE UserID = :old.UserID;
END DeleteAppClientID;
