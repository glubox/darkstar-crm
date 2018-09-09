CREATE TABLE [dbo].[Contact]
(
	[ContactId] INT NOT NULL PRIMARY KEY IDENTITY, 
	[Email] NVARCHAR(200) NOT NULL, 
	[Address] NVARCHAR(100) NULL, 
	[Phone] NVARCHAR(50) NULL, 
	[ClientId] INT NULL, 
	[AccountId] INT NULL, 
	[IsDefault] BIT NOT NULL DEFAULT 0, 
	[CountryId] INT NULL, 
	[StateId] INT NULL, 
	CONSTRAINT [FK_Contact_Client] FOREIGN KEY ([ClientId]) REFERENCES [Client]([ClientId]), 
	CONSTRAINT [FK_Contact_Account] FOREIGN KEY ([AccountId]) REFERENCES [Account]([AccountId]), 
	CONSTRAINT [FK_Contact_Country] FOREIGN KEY ([CountryId]) REFERENCES [nomenclatures].[Country]([CountryId]), 
	CONSTRAINT [FK_Contact_State] FOREIGN KEY ([StateId]) REFERENCES [nomenclatures].[State]([StateId])
)
