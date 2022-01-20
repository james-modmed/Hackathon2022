CREATE TABLE [dbo].[Visit]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [PatientId] VARCHAR(128) NOT NULL, 
    [ProviderId] VARCHAR(128) NOT NULL, 
    [VisitDate] VARCHAR(128) NOT NULL, 
    [VisitStatusId] VARCHAR(128) NOT NULL
)
