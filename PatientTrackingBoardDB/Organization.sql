CREATE TABLE [dbo].[Organization] (
    [Id]           UNIQUEIDENTIFIER NOT NULL,
    [DateCreated]  DATETIME         CONSTRAINT [DF__Organization__DateCreated] DEFAULT (getdate()) NOT NULL,
    [DateModified] DATETIME         NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


