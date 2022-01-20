CREATE TABLE [dbo].[Patient] (
    [Id]           UNIQUEIDENTIFIER NOT NULL,
    [FirstName]    VARCHAR (128)    NOT NULL,
    [LastName]     VARCHAR (128)    NOT NULL,
    [DOB]          DATE             NOT NULL,
    [SourceId]     VARCHAR (128)    NULL,
    [DateCreated]  DATETIME         CONSTRAINT [DF__Patient__DateCreated] DEFAULT (getdate()) NOT NULL,
    [DateModified] DATETIME         NOT NULL,
    CONSTRAINT [PK__Patient] PRIMARY KEY CLUSTERED ([Id] ASC)
);




