USE [PatientTrackingBoardDB]
GO

SET NOCOUNT ON

IF EXISTS (SELECT [name] FROM sys.tables WHERE [name] = 'VisitStatus')
DELETE FROM [VisitStatus]

IF EXISTS (SELECT [name] FROM sys.tables WHERE [name] = 'Account')
DELETE FROM [Account]

IF EXISTS (SELECT [name] FROM sys.tables WHERE [name] = 'Location')
DELETE FROM [Location]

IF EXISTS (SELECT [name] FROM sys.tables WHERE [name] = 'Organization')
DELETE FROM [Organization]

IF EXISTS (SELECT [name] FROM sys.tables WHERE [name] = 'Visit')
DELETE FROM [Visit]

IF EXISTS (SELECT [name] FROM sys.tables WHERE [name] = 'VisitCode')
DELETE FROM [VisitCode]

IF EXISTS (SELECT [name] FROM sys.tables WHERE [name] = 'Patient')
DELETE FROM [Patient]

IF EXISTS (SELECT [name] FROM sys.tables WHERE [name] = 'Provider')
DELETE FROM [Provider]



INSERT INTO [dbo].[Patient]
           ([Id]
           ,[FirstName]
           ,[LastName]
           ,[DOB]
           ,[SourceId]
           ,[DateCreated]
           ,[DateModified])


SELECT NEWID()
     , 'John'
	 , 'Doe'
	 , '1965/01/20'
	 , NULL
	 , GETDATE()
	 , GETDATE()


UNION

SELECT NEWID()
     , 'Nancy'
	 , 'Smith'
	 , '1957/06/03'
	 , NULL
	 , GETDATE()
	 , GETDATE()

UNION

SELECT NEWID()
     , 'Otis'
	 , 'Johnson'
	 , '1972/08/15'
	 , NULL
	 , GETDATE()
	 , GETDATE()

UNION

SELECT NEWID()
     , 'Samantha'
	 , 'Parker'
	 , '1980/02/14'
	 , NULL
	 , GETDATE()
	 , GETDATE()
UNION

SELECT NEWID()
     , 'Geoff'
	 , 'Nguyen'
	 , '1980/02/14'
	 , NULL
	 , GETDATE()
	 , GETDATE()
GO


USE [PatientTrackingBoardDB]
GO

INSERT INTO [dbo].[Provider]
           ([Id]
           ,[FirstName]
           ,[LastName]
           ,[DisplayName]
           ,[DateCreated]
           ,[DateModified])

SELECT NEWID()
     , 'Spencer'
	 , 'Reading'
	 , 'Dr. Spencer Reading, M.D.'
	 , GETDATE()
	 , GETDATE()


UNION

SELECT NEWID()
     , 'Marcela'
	 , 'Jones'
	 , 'Dr. Marcela Jones, M.D.'
	 , GETDATE()
	 , GETDATE()


UNION

SELECT NEWID()
     , 'Rodrigo'
	 , 'Juarez'
	 , 'Dr. Rodrigo Juarez, M.D.'
	 , GETDATE()
	 , GETDATE()



GO


USE [PatientTrackingBoardDB]
GO

INSERT INTO [dbo].[VisitCode]
           ([Id]
           ,[name]
           ,[ColorCode]
           ,[DateCreated]
           ,[DateModified])
 
SELECT NEWID(),
      'Intake', 
	  '#CCCC00',
	   GETDATE(),
	   GETDATE()

UNION

SELECT NEWID(),
      'PreOp', 
	  '#00CCCC',
	   GETDATE(),
	   GETDATE()

UNION

SELECT NEWID(),
      'InOR', 
	  '#000000',
	   GETDATE(),
	   GETDATE()

UNION

SELECT NEWID(),
      'Recovery', 
	  '#009900',
	   GETDATE(),
	   GETDATE()

UNION

SELECT NEWID(),
      'Ready for Family', 
	  '#00FF00',
	   GETDATE(),
	   GETDATE()
GO

USE [PatientTrackingBoardDB]
GO


DECLARE @PatientIds TABLE (Id int identity(1,1), PatientId uniqueidentifier)
INSERT @PatientIds (PatientId)
SELECT Id From Patient

DECLARE @ProviderIds TABLE (Id int identity(1,1), ProviderId uniqueidentifier)
INSERT @ProviderIds (ProviderId)
SELECT Id From Provider




INSERT INTO [dbo].[Visit]
           ([Id]
           ,[PatientId]
           ,[ProviderId]
		   ,[Procedure]
           ,[VisitDate]
           ,[DateCreated]
           ,[DateModified])

SELECT NEWID()
     , (SELECT PatientId FROM @PatientIds WHERE Id = 1)
	 , (SELECT ProviderId FROM @ProviderIds WHERE Id = 1)
	 , 'Colonoscopy'
	 , (SELECT CAST(GETDATE() AS date))
	 , GETDATE()
	 , GETDATE()

UNION


SELECT NEWID()
     , (SELECT PatientId FROM @PatientIds WHERE Id = 2)
	 , (SELECT ProviderId FROM @ProviderIds WHERE Id = 2)
	 , 'Ultrasound'
	 , (SELECT CAST(GETDATE() AS date))
	 , GETDATE()
	 , GETDATE()

UNION


SELECT NEWID()
     , (SELECT PatientId FROM @PatientIds WHERE Id = 3)
	 , (SELECT ProviderId FROM @ProviderIds WHERE Id = 2)
	 , 'Colonoscopy'
	 , (SELECT CAST(GETDATE() AS date))
	 , GETDATE()
	 , GETDATE()

UNION


SELECT NEWID()
     , (SELECT PatientId FROM @PatientIds WHERE Id = 4)
	 , (SELECT ProviderId FROM @ProviderIds WHERE Id = 3)
	 , 'Ultrasound'
	 , (SELECT CAST(GETDATE() AS date))
	 , GETDATE()
	 , GETDATE()

UNION


SELECT NEWID()
     , (SELECT PatientId FROM @PatientIds WHERE Id = 5)
	 , (SELECT ProviderId FROM @ProviderIds WHERE Id = 3)
	 , 'Colonoscopy'
	 , (SELECT CAST(GETDATE() AS date))
	 , GETDATE()
	 , GETDATE()
GO


USE [PatientTrackingBoardDB]
GO

INSERT INTO [dbo].[Organization]
           ([Id]
		   ,[Name]
           ,[DateCreated]
           ,[DateModified])
SELECT NEWID()
     , 'Modernizing Medicine'
     , GETDATE()
	 , GETDATE()
GO



USE [PatientTrackingBoardDB]
GO

INSERT INTO [dbo].[Location]
           ([Id]
           ,[OrganizationId]
           ,[Name]
           ,[DateCreated]
           ,[DateModified])
SELECT NEWID()
     , (SELECT Id FROM Organization WHERE [name] = 'Modernizing Medicine')
	 , ('Boca HQ')
	 , GETDATE()
     , GETDATE()
GO


USE [PatientTrackingBoardDB]
GO

INSERT INTO [dbo].[Account]
           ([Id]
           ,[OrganizationId]
           ,[DateCreated]
           ,[DateModified]
           ,[IsActive])
SELECT NEWID()
     , (SELECT Id FROM Organization WHERE [name] = 'Modernizing Medicine')
	 , GETDATE()
	 , GETDATE()
	 , 1

GO



USE [PatientTrackingBoardDB]
GO



DECLARE @VisitIds TABLE (Id int identity(1,1), VisitId uniqueidentifier)
INSERT @VisitIds (VisitId)
SELECT Id From Visit


DECLARE @VisitCodeIds TABLE (Id int identity(1,1), VisitCodeId uniqueidentifier)
INSERT @VisitCodeIds (VisitCodeId)
SELECT Id From VisitCode



INSERT INTO [dbo].[VisitStatus]
           ([Id]
           ,[VisitId]
           ,[VisitCodeId]
           ,[DateCreated]
           ,[DateModified])


SELECT NEWID()
     , (SELECT VisitId FROM @VisitIds WHERE Id = 1)
	 , (SELECT VisitCodeId FROM @VisitCodeIds WHERE Id = 1)
	 , GETDATE()
	 , GETDATE()

UNION

SELECT NEWID()
     , (SELECT VisitId FROM @VisitIds WHERE Id = 2)
	 , (SELECT VisitCodeId FROM @VisitCodeIds WHERE Id = 2)
	 , GETDATE()
	 , GETDATE()

UNION

SELECT NEWID()
     , (SELECT VisitId FROM @VisitIds WHERE Id = 3)
	 , (SELECT VisitCodeId FROM @VisitCodeIds WHERE Id = 3)
	 , GETDATE()
	 , GETDATE()

UNION


SELECT NEWID()
     , (SELECT VisitId FROM @VisitIds WHERE Id = 4)
	 , (SELECT VisitCodeId FROM @VisitCodeIds WHERE Id = 4)
	 , GETDATE()
	 , GETDATE()

UNION


SELECT NEWID()
     , (SELECT VisitId FROM @VisitIds WHERE Id = 5)
	 , (SELECT VisitCodeId FROM @VisitCodeIds WHERE Id = 5)
	 , GETDATE()
	 , GETDATE()



GO


