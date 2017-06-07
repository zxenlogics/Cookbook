SET IDENTITY_INSERT dbo.[User] ON;
GO
INSERT INTO [dbo].[User] (Id, FirstName, LastName) Values (1, 'Denzil', 'Brown')
INSERT INTO [dbo].[User] (Id, FirstName, LastName) Values (2, 'Will', 'Collins')
INSERT INTO [dbo].[User] (Id, FirstName, LastName) Values (3, 'Alaa', 'Tadmori')
INSERT INTO [dbo].[User] (Id, FirstName, LastName) Values (4, 'Mattew', 'Foshee')
INSERT INTO [dbo].[User] (Id, FirstName, LastName) Values (5, 'Mark', 'Jeffries')
SET IDENTITY_INSERT dbo.[User] OFF;
GO

SET IDENTITY_INSERT dbo.[Team] ON;
GO
INSERT INTO [dbo].[Team] (Id, [Name]) Values (1, 'Team A')
INSERT INTO [dbo].[Team] (Id, [Name]) Values (2, 'Team B')
INSERT INTO [dbo].[Team] (Id, [Name]) Values (3, 'Team C')
INSERT INTO [dbo].[Team] (Id, [Name]) Values (4, 'Team D')
INSERT INTO [dbo].[Team] (Id, [Name]) Values (5, 'Team E')
SET IDENTITY_INSERT dbo.[Team] OFF;
GO

SET IDENTITY_INSERT dbo.[TeamMember] ON;
GO
INSERT INTO [dbo].[TeamMember] (Id, TeamId, UserId, IsActive) Values (1, '1', '1', 1)
INSERT INTO [dbo].[TeamMember] (Id, TeamId, UserId, IsActive) Values (2, '1', '2', 1)
INSERT INTO [dbo].[TeamMember] (Id, TeamId, UserId, IsActive) Values (3, '2', '3', 1)
INSERT INTO [dbo].[TeamMember] (Id, TeamId, UserId, IsActive) Values (4, '2', '4', 1)
INSERT INTO [dbo].[TeamMember] (Id, TeamId, UserId, IsActive) Values (5, '3', '5', 0)
SET IDENTITY_INSERT dbo.[TeamMember] OFF;
GO

SET IDENTITY_INSERT dbo.[Branch] ON;
GO
INSERT INTO [dbo].[Branch] (Id, [Name]) Values (1, 'Branch A')
INSERT INTO [dbo].[Branch] (Id, [Name]) Values (2, 'Branch B')
INSERT INTO [dbo].[Branch] (Id, [Name]) Values (3, 'Branch C')
INSERT INTO [dbo].[Branch] (Id, [Name]) Values (4, 'Branch D')
INSERT INTO [dbo].[Branch] (Id, [Name]) Values (5, 'Branch E')
SET IDENTITY_INSERT dbo.[Branch] OFF;
GO

SET IDENTITY_INSERT dbo.[Project] ON;
GO
INSERT INTO [dbo].[Project] (Id, [Name], IsActive, ProjectType, BranchId) Values (1, 'Proj A', 1, 'Feature', 1)
INSERT INTO [dbo].[Project] (Id, [Name], IsActive, ProjectType, BranchId) Values (2, 'Proj B', 1, 'Feature', 2)
INSERT INTO [dbo].[Project] (Id, [Name], IsActive, ProjectType, BranchId) Values (3, 'Proj C', 1, 'Enhancement', 3)
INSERT INTO [dbo].[Project] (Id, [Name], IsActive, ProjectType, BranchId) Values (4, 'Proj D', 1, 'Bug Fix', 4)
INSERT INTO [dbo].[Project] (Id, [Name], IsActive, ProjectType, BranchId) Values (5, 'Proj E', 1, 'Enhancement', 5)
SET IDENTITY_INSERT dbo.[Project] OFF;
GO

SET IDENTITY_INSERT dbo.[Client] ON;
GO
INSERT INTO [dbo].[Client] (Id, [Name], Abbreviation) Values (1, 'Morgan Stanley', 'MSSB')
INSERT INTO [dbo].[Client] (Id, [Name], Abbreviation) Values (2, 'Century Twenty One', 'C21')
INSERT INTO [dbo].[Client] (Id, [Name], Abbreviation) Values (3, 'Citibank', 'Citi')
SET IDENTITY_INSERT dbo.[Client] OFF;
GO 

SET IDENTITY_INSERT dbo.[EnvironmentType] ON;
GO
INSERT INTO [dbo].[EnvironmentType] (Id, [Name]) Values (1, 'ELC QA Environment')
INSERT INTO [dbo].[EnvironmentType] (Id, [Name]) Values (2, 'DC QA Environment')
SET IDENTITY_INSERT dbo.[EnvironmentType] OFF;
GO

SET IDENTITY_INSERT dbo.[Environment] ON;
GO
INSERT INTO [dbo].[Environment] (Id, [Name], IsCluster, ClientId, EnvironmentTypeId, State, CurrentVersion, TargetVersion, NOtes, LastUpdated) Values (1, 'MCEnv01', 1, 1, 1, 'Ready', '8.2.600.999', '9.0.0.111', 'Notes are here', GetDate())
INSERT INTO [dbo].[Environment] (Id, [Name], IsCluster, ClientId, EnvironmentTypeId, State, CurrentVersion, TargetVersion, NOtes, LastUpdated) Values (2, 'MCEnv02', 1, 2, 2, 'Ready', '8.2.600.999', '9.0.0.111', 'Notes are here', GetDate())
INSERT INTO [dbo].[Environment] (Id, [Name], IsCluster, ClientId, EnvironmentTypeId, State, CurrentVersion, TargetVersion, NOtes, LastUpdated) Values (3, 'MCEnv03', 1, 3, 2, 'Ready', '8.2.600.999', '9.0.0.111', 'Notes are here', GetDate())
INSERT INTO [dbo].[Environment] (Id, [Name], IsCluster, ClientId, EnvironmentTypeId, State, CurrentVersion, TargetVersion, NOtes, LastUpdated) Values (4, 'MCEnv04', 1, 1, 1, 'Ready', '8.2.600.999', '9.0.0.111', 'Notes are here', GetDate())
INSERT INTO [dbo].[Environment] (Id, [Name], IsCluster, ClientId, EnvironmentTypeId, State, CurrentVersion, TargetVersion, NOtes, LastUpdated) Values (5, 'MCEnv05', 1, 2, 2, 'Ready', '8.2.600.999', '9.0.0.111', 'Notes are here', GetDate())
SET IDENTITY_INSERT dbo.[Environment] OFF;
GO

SET IDENTITY_INSERT dbo.[Domain] ON;
GO
INSERT INTO [dbo].[Domain] (Id, [Name], DomainAbbreviation) Values (1, 'Mortgage Cadence', 'MC')
INSERT INTO [dbo].[Domain] (Id, [Name], DomainAbbreviation) Values (2, 'Accenture', 'Acc')
SET IDENTITY_INSERT dbo.[Domain] OFF;
GO

SET IDENTITY_INSERT dbo.[ServerRole] ON;
GO
INSERT INTO [dbo].[ServerRole] (Id, [Name], Description) Values (1, 'ELC Web Svr', 'ELC Web Server')
INSERT INTO [dbo].[ServerRole] (Id, [Name], Description) Values (2, 'ELC DB', 'ELC Database Server')
INSERT INTO [dbo].[ServerRole] (Id, [Name], Description) Values (3, 'ELC BOS Svr', 'ELC Business Ojects Server')
INSERT INTO [dbo].[ServerRole] (Id, [Name], Description) Values (4, 'ELC Client Svr', 'ELC Client Server')
SET IDENTITY_INSERT dbo.[ServerRole] OFF;
GO

SET IDENTITY_INSERT [dbo].[Server] ON;
GO
INSERT INTO [dbo].[Server] (Id, Hostname, IP, DomainId, EnvironmentId) Values (1, 'QAPPEL C11', '10.0.5.82', 1, 1)
INSERT INTO [dbo].[Server] (Id, Hostname, IP, DomainId, EnvironmentId) Values (2, 'DWEBELCAPI1', '10.7.6.16', 1, 2)
INSERT INTO [dbo].[Server] (Id, Hostname, IP, DomainId, EnvironmentId) Values (3, 'MCQA2008R2VER3', '10.0.2.68', 2, 3)
INSERT INTO [dbo].[Server] (Id, Hostname, IP, DomainId, EnvironmentId) Values (4, 'DBOSELC1', '10.0.5.150', 1, 4)
INSERT INTO [dbo].[Server] (Id, Hostname, IP, DomainId, EnvironmentId) Values (5, 'QWEBELC3', '10.0.5.37', 2, 5)
SET IDENTITY_INSERT [dbo].[Server] OFF;
GO


SET IDENTITY_INSERT [dbo].[DBInstance] ON;
GO
INSERT INTO [dbo].[DBInstance] (Id, [Name], DBEngineId, DBEngine, ServerId) Values (1, 'MCSQL01V\Dev', 0, 'SQL Server', 1)
INSERT INTO [dbo].[DBInstance] (Id, [Name], DBEngineId, DBEngine, ServerId) Values (2, 'QSQLELC2', 0, 'SQL Server', 2)
INSERT INTO [dbo].[DBInstance] (Id, [Name], DBEngineId, DBEngine, ServerId) Values (3, 'QSQLELC2', 0, 'SQL Server', 3)
INSERT INTO [dbo].[DBInstance] (Id, [Name], DBEngineId, DBEngine, ServerId) Values (4, 'DSQLELC1', 0, 'SQL Server', 4)
INSERT INTO [dbo].[DBInstance] (Id, [Name], DBEngineId, DBEngine, ServerId) Values (5, 'DSQLELC1', 0, 'SQL Server', 5)
SET IDENTITY_INSERT [dbo].[DBInstance] OFF;
GO

SET IDENTITY_INSERT [dbo].[Database] ON;
GO
INSERT INTO [dbo].[Database] (Id, [Name], DBInstanceId) Values (1, 'BV8XDev6', 1)
INSERT INTO [dbo].[Database] (Id, [Name], DBInstanceId) Values (2, 'BCTestELCAPI', 2)
INSERT INTO [dbo].[Database] (Id, [Name], DBInstanceId) Values (3, 'AutoTest', 3)
INSERT INTO [dbo].[Database] (Id, [Name], DBInstanceId) Values (4, 'CoreConfig', 4)
INSERT INTO [dbo].[Database] (Id, [Name], DBInstanceId) Values (5, 'LoadTestCadence', 5)
SET IDENTITY_INSERT [dbo].[Database] OFF;
GO

-- Update EnvironmentType Name
Update [dbo].EnvironmentType SET [Name] = 'ELC QA Environment' WHERE Id = 1
Update [dbo].EnvironmentType SET [Name] = 'DC QA Environment' WHERE Id = 2

-- Update Server State Field
Update [dbo].[Server] SET [State] = 'Ready' WHERE Id IN (1, 3, 5)
Update [dbo].[Server] SET [State] = 'Failed' WHERE Id IN (2, 4)

-- Update ServerRoles
Update [dbo].[ServerRole] SET Name = 'ELC Web Svr', Description = 'ELC Web Server' WHERE Id = 1
Update [dbo].[ServerRole] SET Name = 'ELC DB', Description = 'ELC Database Server' WHERE Id = 2
Update [dbo].[ServerRole] SET Name = 'ELC BOS Svr', Description = 'ELC Business Ojects Server' WHERE Id = 3

IF NOT EXISTS(SELECT 1 FROM ServerRole WHERE Id = 4)
BEGIN
       SET IDENTITY_INSERT dbo.[ServerRole] ON
       INSERT INTO [dbo].[ServerRole] (Id, [Name], Description) Values (4, 'ELC Client Svr', 'ELC Client Server')
       SET IDENTITY_INSERT dbo.[ServerRole] OFF
END


-- Test Query to pull generated data
--SELECT p.[Name] as Project, 
--	   p.Branch, 
--	   s.Hostname + ' (' +  s.IP +' )' As Host, 
--	   e.TargetVersion, 
--	   e.[State], 
--	   '[' + dbi.[Name] + ']' + '.[' + db.Name + ']' As [Database], 
--	   e.LastUpdated, 
--	   c.[Name] As Client, 
--	   e.Notes 
--FROM [dbo].[Environment] e
--	INNER JOIN dbo.Client c on c.Id = e.Id
--	INNER JOIN dbo.Project p on p.Id = e.Id
--	INNER JOIN dbo.Server s on s.Id = e.Id
--	INNER JOIN dbo.DBInstance dbi on dbi.Id = s.Id
--	INNER JOIN dbo.[Database] db on db.Id = dbi.Id
