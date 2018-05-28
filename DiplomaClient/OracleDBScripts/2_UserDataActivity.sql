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
create or replace PROCEDURE REGISTERCLIENT
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
idbuf NUMBER(10);
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
idbuf :=ClientIDSeq.CURRVAL;
INSERT INTO CLIENTAPPUSERACTIVITY (USERID,DESCRIPTION,ACTIVITYTIME)
VALUES (idbuf,'User has registered', CURRENT_DATE);
INSERT INTO CLIENTMODULEACCESS(USERID,M1,M2,M3,M4,M5,M6)
VALUES(idbuf,'F','F','F','F','F','F');
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

--Login Monitor Procedure
create or replace PROCEDURE LOGINLOG
(v_id in ClientAppUsers.USERID%TYPE)
IS
BEGIN
INSERT INTO CLIENTAPPUSERACTIVITY (USERID,DESCRIPTION,ACTIVITYTIME)
VALUES (v_id,'User has logged in', CURRENT_DATE);
END LOGINLOG;
--Log out Monitor Procedure
create or replace PROCEDURE LOGOUTLOG
(v_id in ClientAppUsers.USERID%TYPE)
IS
BEGIN
INSERT INTO CLIENTAPPUSERACTIVITY (USERID,DESCRIPTION,ACTIVITYTIME)
VALUES (v_id,'User has logged out', CURRENT_DATE);
END LOGOUTLOG;
--Log out Monitor Procedure
create or replace PROCEDURE SHUTDOWNLOG
(v_id in ClientAppUsers.USERID%TYPE)
IS
BEGIN
INSERT INTO CLIENTAPPUSERACTIVITY (USERID,DESCRIPTION,ACTIVITYTIME)
VALUES (v_id,'User account has been shut down', CURRENT_DATE);
END SHUTDOWNLOG;
--Log out Monitor Procedure
create or replace PROCEDURE CLOSELOG
(v_id in ClientAppUsers.USERID%TYPE)
IS
BEGIN
INSERT INTO CLIENTAPPUSERACTIVITY (USERID,DESCRIPTION,ACTIVITYTIME)
VALUES (v_id,'User has closed application', CURRENT_DATE);
END CLOSELOG;
--UpdateProfileFields Procedure
create or replace PROCEDURE UPDATEPROFILE
(
v_userid in ClientAppUsers.USERID%TYPE,
v_login in ClientAppUsers.LOGIN%TYPE,
v_fname in CLIENTAPPUSERS.FNAME%TYPE,
v_lname in CLIENTAPPUSERS.LNAME%TYPE,
v_mname in CLIENTAPPUSERS.MNAME%TYPE,
v_gender in CLIENTAPPUSERS.GENDER%TYPE,
v_email in CLIENTAPPUSERS.EMAIL%TYPE,
v_phone in CLIENTAPPUSERS.PHONE%TYPE,
v_adress in CLIENTAPPUSERS.ADRESS%TYPE
)
IS
BEGIN
UPDATE CLIENTAPPUSERS 
SET 
LOGIN = v_login,
FNAME = v_fname,
MNAME = v_mname,
LNAME = v_lname,
GENDER = v_gender,
EMAIL = v_email,
PHONE = v_phone,
ADRESS = v_adress
WHERE USERID = v_userid;
END UPDATEPROFILE;
--Monitor Account Update
create or replace PROCEDURE UPDATEACCOUNTLOG
(v_id in ClientAppUsers.USERID%TYPE)
IS
BEGIN
INSERT INTO CLIENTAPPUSERACTIVITY (USERID,DESCRIPTION,ACTIVITYTIME)
VALUES (v_id,'User Data have been updated', CURRENT_DATE);
END UPDATEACCOUNTLOG;
--UpdateProfilePassword Procedure
create or replace PROCEDURE UPDATEPASS
(
v_userid in ClientAppUsers.USERID%TYPE,
v_pass in ClientAppUsers.PASS%TYPE,
v_passhash in CLIENTAPPUSERS.PASSHASH%TYPE
)
IS
BEGIN
UPDATE CLIENTAPPUSERS 
SET 
PASS = v_pass,
PASSHASH = v_passhash
WHERE USERID = v_userid;
END UPDATEPASS;
--Monitor Account Pass Update
create or replace PROCEDURE UPDATEPASSLOG
(v_id in ClientAppUsers.USERID%TYPE)
IS
BEGIN
INSERT INTO CLIENTAPPUSERACTIVITY (USERID,DESCRIPTION,ACTIVITYTIME)
VALUES (v_id,'User has updated password', CURRENT_DATE);
END UPDATEPASSLOG;
--UpdateAvatarProcedure
create or replace PROCEDURE UPDATEAVATAR
(
v_userid in ClientAppUsers.USERID%TYPE,
v_avatar in CLIENTAPPUSERS.AVATAR%TYPE
)
IS
BEGIN
UPDATE CLIENTAPPUSERS 
SET 
AVATAR = v_avatar
WHERE USERID = v_userid;
END UPDATEAVATAR;
--Monitor Account Pass Update
create or replace PROCEDURE PASSRESETLOG
(v_id in ClientAppUsers.USERID%TYPE)
IS
BEGIN
INSERT INTO CLIENTAPPUSERACTIVITY (USERID,DESCRIPTION,ACTIVITYTIME)
VALUES (v_id,'User has reset his password', CURRENT_DATE);
END PASSRESETLOG;
--GRAND ACCESS TO REPORTS FOR USERS
create or replace PROCEDURE EDITMODELACCESS
(v_id in CLIENTMODULEACCESS.USERID%TYPE,
v_m1 in CLIENTMODULEACCESS.M1%TYPE,
v_m2 in CLIENTMODULEACCESS.M2%TYPE,
v_m3 in CLIENTMODULEACCESS.M3%TYPE,
v_m4 in CLIENTMODULEACCESS.M4%TYPE,
v_m5 in CLIENTMODULEACCESS.M5%TYPE,
v_m6 in CLIENTMODULEACCESS.M6%TYPE
)
IS
BEGIN
UPDATE CLIENTMODULEACCESS
SET
M1 = v_m1,
M2 = v_m2,
M3 = v_m3,
M4 = v_m4,
M5 = v_m5,
M6 = v_m6
WHERE USERID = v_id;
END EDITMODELACCESS;