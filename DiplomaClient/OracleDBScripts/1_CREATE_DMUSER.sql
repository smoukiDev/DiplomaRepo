--Run this scripts in SQL Worksheet of PDB SYS user

--To work with PDB Database - use CDB SYS user in order to run the script, which opens PDB:
--ALTER PLUGGABLE DATABASE PDBORTW OPEN;

--TABLESPACE for DMUSER
--Attention Datafile Route can be different
CREATE TABLESPACE datamining
DATAFILE 
'/ORACUL12/app/ORUVGE/oradata/ORTW/pdbortw/datamimig.dbf'
SIZE 500M AUTOEXTEND ON;

--User to store all DataMining Content
CREATE USER dmuser IDENTIFIED BY dmuser
DEFAULT TABLESPACE datamining
TEMPORARY TABLESPACE temp
QUOTA UNLIMITED ON datamining;
--DMUSER Priveleges
GRANT CONNECT, RESOURCE to dmuser;

/*
It's required to create Data Mining Repository in order to use Data Mining Features
It's exist 2 ways: 
1 - automatic with SQL Developer Enviroment
2 - using script stored in SQL Developer Directory

Schema for Data Mining should have all necessary privileges
To give privileges there are 3 ways: 
1  - create ODM Repo with desirable schema at the start
2  - use script stored in SQL Developer Directory
3  - custom setting via SQL Developer Enviroment in User Properties

SQL Developer Directory with scripts route:
sqldeveloper\dataminer\scripts
*/



