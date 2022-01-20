CREATE TABLE [dbo].[Account] (
    [Id]             UNIQUEIDENTIFIER NOT NULL,
    [OrganizationId] UNIQUEIDENTIFIER NOT NULL,
    [DateCreated]    DATETIME         CONSTRAINT [DF__Account__DateCreated] DEFAULT (getdate()) NOT NULL,
    [DateModified]   DATETIME         NOT NULL,
    [IsActive]       BIT              CONSTRAINT [DF__Account__IsActive] DEFAULT ((1)) NOT NULL,
    CONSTRAINT [PK__Account] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Account_OrganizationId] FOREIGN KEY ([OrganizationId]) REFERENCES [dbo].[Organization] ([Id])
);






