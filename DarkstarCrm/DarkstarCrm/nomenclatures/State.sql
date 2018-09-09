CREATE TABLE [nomenclatures].[State]
(
	[StateId] INT NOT NULL PRIMARY KEY IDENTITY, 
	[CountryId] INT NOT NULL, 
	[Name] NVARCHAR(50) NOT NULL, 
	[Code] NVARCHAR(2) NOT NULL, 
	CONSTRAINT [FK_State_Country] FOREIGN KEY ([CountryId]) REFERENCES [nomenclatures].[Country]([CountryId])
)
