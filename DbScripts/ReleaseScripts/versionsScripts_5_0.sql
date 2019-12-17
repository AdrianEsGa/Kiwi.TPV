-- DB CHANGES VERSION 5.0 --
----------------------------

IF NOT EXISTS(SELECT 1
			  FROM sys.objects AS o
				   INNER JOIN sys.columns AS c
					   ON o.object_id = c.object_id
			  WHERE o.name = 'AppGeneralConfig'
					AND c.name = 'ServerStationId')
BEGIN

BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION

ALTER TABLE dbo.AppGeneralConfig ADD
	ServerStationId int NULL,
	DbBackupFilePath varchar(500) NULL


ALTER TABLE dbo.AppGeneralConfig SET (LOCK_ESCALATION = TABLE)

COMMIT

END