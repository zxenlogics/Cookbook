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