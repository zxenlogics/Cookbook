-- Drop all tables 
BEGIN TRAN

DROP TABLE [dbo].[Database]
DROP TABLE [dbo].[DBInstance]
DROP TABLE  [dbo].[ServerRoleServer]
DROP TABLE [dbo].[ServerRole]
DROP TABLE [dbo].[Server]
DROP TABLE [dbo].[Domain]
DROP TABLE [dbo].[ProjectEnvironment]
DROP TABLE [dbo].[Environment]
DROP TABLE [dbo].[EnvironmentType]
DROP TABLE [dbo].[Client]
DROP TABLE [dbo].[TeamProject]
DROP TABLE [dbo].[Project]
DROP TABLE [dbo].[Branch]
DROP TABLE [dbo].[TeamMember]
DROP TABLE [dbo].[Team]
DROP TABLE [dbo].[User]
DROP TABLE [dbo].[__MigrationHistory]

ROLLBACK TRAN