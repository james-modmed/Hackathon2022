CREATE TABLE [dbo].[Location] (
    [Id]             UNIQUEIDENTIFIER NOT NULL,
    [OrganizationId] UNIQUEIDENTIFIER NOT NULL,
    [Name]           VARCHAR (128)    NOT NULL,
    [DateCreated]    DATETIME         CONSTRAINT [DF__Location__DateCreated] DEFAULT (getdate()) NOT NULL,
    [DateModified]   DATETIME         NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Location_OrganizationId] FOREIGN KEY ([OrganizationId]) REFERENCES [dbo].[Organization] ([Id])
);




