BEGIN TRAN

DELETE [dbo].[Database]
DELETE [dbo].[DBInstance]
DELETE [dbo].[Server]
DELETE [dbo].[ServerRole]
DELETE [dbo].[Domain]
DELETE [dbo].[Environment]
DELETE [dbo].[EnvironmentType]
DELETE [dbo].[Client]
DELETE [dbo].[Project]
DELETE [dbo].[TeamMember]
DELETE [dbo].[Team]
DELETE [dbo].[User]
ROLLBACK TRAN

BEGIN TRAN

DROP TABLE [dbo].[Database]
DROP TABLE [dbo].[DBInstance]
DROP TABLE [dbo].[Server]
DROP TABLE [dbo].[ServerRole]
DROP TABLE [dbo].[Domain]
DROP TABLE [dbo].[Environment]
DROP TABLE [dbo].[EnvironmentType]
DROP TABLE [dbo].[Client]
DROP TABLE [dbo].[Project]
DROP TABLE [dbo].[TeamMember]
DROP TABLE [dbo].[Team]
DROP TABLE [dbo].[User]
ROLLBACK TRAN