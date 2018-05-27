-- Scripts have to be deployed at SH SHEMA ON PDBORTW
-- Acceptable erros because some columns created later - be careful

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
-- Also AutoAdd ISBLOCK, ISADMIN, ISEMAILCONFIRM DEFAULT VALUES
CREATE OR REPLACE TRIGGER NewAppClientID
BEFORE INSERT ON ClientAppUsers
FOR EACH ROW
DECLARE

BEGIN
:new.UserID := ClientIDSeq.NEXTVAL;
INSERT INTO ClientModuleAccess(UserID) VALUES(ClientIDSeq.CURRVAL);
:new.ISBLOCK := 'T';
:new.ISADMIN :='F';
:new.ISEMAILCONFIRM := 'F';
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
DELETE FROM ClientAppUserActivity WHERE USERID = :old.UserID;
END DeleteAppClientID;
--Add Columns for Confirm Email Feature
ALTER TABLE ClientAppUsers ADD EmailActivationCode VARCHAR2(10 CHAR);
ALTER TABLE ClientAppUsers ADD EmailActivationHash VARCHAR2(200 CHAR);
ALTER TABLE ClientAppUsers ADD EmailActivationSalt VARCHAR2(200 CHAR);
ALTER TABLE ClientAppUsers ADD IsEmailConfirm CHAR(1 CHAR);
--Create account procedure
CREATE OR REPLACE PROCEDURE REGISTERCLIENT
(
v_login in ClientAppUsers.LOGIN%TYPE,
v_pass in CLIENTAPPUSERS.PASS%TYPE,
v_passhash in CLIENTAPPUSERS.PASSHASH%TYPE,
v_passsalt in CLIENTAPPUSERS.PASSSALT%TYPE,
v_fname in CLIENTAPPUSERS.FNAME%TYPE,
v_lname in CLIENTAPPUSERS.LNAME%TYPE,
v_mname in CLIENTAPPUSERS.MNAME%TYPE,
v_email in CLIENTAPPUSERS.EMAIL%TYPE,
v_phone in CLIENTAPPUSERS.PHONE%TYPE,
v_adress in CLIENTAPPUSERS.ADRESS%TYPE,
v_gender in CLIENTAPPUSERS.GENDER%TYPE,
v_avatar in CLIENTAPPUSERS.AVATAR%TYPE,
v_eccode in CLIENTAPPUSERS.EMAILACTIVATIONCODE%TYPE,
v_echash in CLIENTAPPUSERS.EMAILACTIVATIONHASH%TYPE,
v_ecsalt in CLIENTAPPUSERS.EMAILACTIVATIONSALT%TYPE
)
IS
BEGIN
INSERT INTO CLIENTAPPUSERS
(
LOGIN,PASS,PASSHASH,PASSSALT,FNAME,LNAME,MNAME,EMAIL,PHONE,ADRESS,GENDER,AVATAR,
EMAILACTIVATIONCODE,EMAILACTIVATIONHASH,EMAILACTIVATIONSALT
) 
VALUES
(
v_login,v_pass,v_passhash,v_passsalt,v_fname,v_lname,v_mname,v_email,v_phone,v_adress,v_gender,v_avatar,
v_eccode,v_echash,v_ecsalt
);
INSERT INTO CLIENTAPPUSERACTIVITY (USERID,DESCRIPTION,ACTIVITYTIME)
VALUES (ClientIDSeq.CURRVAL,'User has registered', CURRENT_DATE);
INSERT INTO CLIENTMODULEACCESS(USERID,M1,M2,M3,M4,M5,M6)
VALUES(ClientIDSeq.CURRVAL,'F','F','F','F','F','F');
--Required to Add Script of locking access to modules which will be added soon
END REGISTERCLIENT;

--Session Date Format
ALTER SESSION SET nls_date_format='yyyy-mm-dd hh24:mi:ss';

--M1 - it's Explore Model Access
ALTER TABLE CLIENTMODULEACCESS ADD M1 CHAR(1 CHAR);
--M2 - it's Association Model Access
ALTER TABLE CLIENTMODULEACCESS ADD M2 CHAR(1 CHAR);
--M3 - it's Classification Model Access
ALTER TABLE CLIENTMODULEACCESS ADD M3 CHAR(1 CHAR);
--M4 - it's Clustering Model Access
ALTER TABLE CLIENTMODULEACCESS ADD M4 CHAR(1 CHAR);
--M5 - it's Regression Model Access
ALTER TABLE CLIENTMODULEACCESS ADD M5 CHAR(1 CHAR);
--M1 - it's Anomaly Detection Model Access
ALTER TABLE CLIENTMODULEACCESS ADD M6 CHAR(1 CHAR);

