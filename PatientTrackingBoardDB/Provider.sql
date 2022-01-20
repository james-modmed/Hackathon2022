CREATE TABLE [dbo].[Provider]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [FirstName] VARCHAR(128) NOT NULL, 
    [LastName] VARCHAR(128) NOT NULL, 
    [DisplayName] VARCHAR(128) NOT NULL
)
