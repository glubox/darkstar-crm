CREATE TABLE [dbo].[Client]
(
	[ClientId] INT NOT NULL PRIMARY KEY IDENTITY, 
	[Email] NVARCHAR(200) NOT NULL, 
	[FirstName] NVARCHAR(50) NOT NULL, 
	[LastName] NVARCHAR(50) NOT NULL, 
	[JobTitle] NVARCHAR(100) NULL 
)
GO

CREATE UNIQUE INDEX [IX_Client_Email_Unique] ON [dbo].[Client] ([Email])
