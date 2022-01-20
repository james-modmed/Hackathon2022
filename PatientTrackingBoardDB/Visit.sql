CREATE TABLE [dbo].[Visit] (
    [Id]           UNIQUEIDENTIFIER NOT NULL,
    [PatientId]    UNIQUEIDENTIFIER NOT NULL,
    [ProviderId]   UNIQUEIDENTIFIER NOT NULL,
    [Procedure]    VARCHAR (128)    NULL,
    [VisitDate]    DATE             NOT NULL,
    [DateCreated]  DATETIME         CONSTRAINT [DF__Visit__DateCreated] DEFAULT (getdate()) NOT NULL,
    [DateModified] DATETIME         NOT NULL,
    CONSTRAINT [PK__Visit] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Visit_PatientId] FOREIGN KEY ([PatientId]) REFERENCES [dbo].[Patient] ([Id]),
    CONSTRAINT [FK_Visit_ProviderId] FOREIGN KEY ([ProviderId]) REFERENCES [dbo].[Provider] ([Id])
);








