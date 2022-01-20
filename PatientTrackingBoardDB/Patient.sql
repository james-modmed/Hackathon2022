﻿CREATE TABLE [dbo].[Patient]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [FirstName] VARCHAR(128) NOT NULL, 
    [LastName] VARCHAR(128) NOT NULL, 
    [DOB] DATE NOT NULL, 
    [SourceId] VARCHAR(128) NULL

)
