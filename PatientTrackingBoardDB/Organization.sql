CREATE TABLE [dbo].[Organization] (
    [Id]           UNIQUEIDENTIFIER NOT NULL,
    [name]         VARCHAR (128)    NOT NULL,
    [DateCreated]  DATETIME         CONSTRAINT [DF__Organization__DateCreated] DEFAULT (getdate()) NOT NULL,
    [DateModified] DATETIME         NOT NULL,
    CONSTRAINT [PK__Organization] PRIMARY KEY CLUSTERED ([Id] ASC)
);




