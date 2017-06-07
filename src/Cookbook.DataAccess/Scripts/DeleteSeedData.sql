-- Delete Data Only from All tables
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
DELETE [dbo].[Branch]
DELETE [dbo].[TeamMember]
DELETE [dbo].[Team]
DELETE [dbo].[User]

ROLLBACK TRAN