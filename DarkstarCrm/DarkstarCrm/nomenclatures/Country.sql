﻿CREATE TABLE [nomenclatures].[Country]
(
	[CountryId] INT NOT NULL PRIMARY KEY IDENTITY, 
	[Name] NVARCHAR(50) NOT NULL, 
	[Code] NVARCHAR(2) NOT NULL
)
