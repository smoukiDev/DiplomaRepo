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



