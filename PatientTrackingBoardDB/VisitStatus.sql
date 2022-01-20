CREATE TABLE [dbo].[VisitStatus] (
    [Id]           UNIQUEIDENTIFIER NOT NULL,
    [VisitId]      UNIQUEIDENTIFIER NOT NULL,
    [VisitCodeId]  UNIQUEIDENTIFIER NOT NULL,
    [DateCreated]  DATETIME         CONSTRAINT [DF__VisitStatus__DateCreated] DEFAULT (getdate()) NOT NULL,
    [DateModified] DATETIME         NOT NULL,
    CONSTRAINT [PK__VisitStatus] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_VisitStatus_VisitCodeId] FOREIGN KEY ([VisitCodeId]) REFERENCES [dbo].[VisitCode] ([Id]),
    CONSTRAINT [FK_VisitStatus_VisitId] FOREIGN KEY ([VisitId]) REFERENCES [dbo].[Visit] ([Id])
);






