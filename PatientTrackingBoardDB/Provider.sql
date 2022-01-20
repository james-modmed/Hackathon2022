CREATE TABLE [dbo].[Provider] (
    [Id]           UNIQUEIDENTIFIER NOT NULL,
    [FirstName]    VARCHAR (128)    NOT NULL,
    [LastName]     VARCHAR (128)    NOT NULL,
    [DisplayName]  VARCHAR (128)    NOT NULL,
    [DateCreated]  DATETIME         CONSTRAINT [DF__Provider__DateCreated] DEFAULT (getdate()) NOT NULL,
    [DateModified] DATETIME         NOT NULL,
    CONSTRAINT [PK__Provider] PRIMARY KEY CLUSTERED ([Id] ASC)
);




