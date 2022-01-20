﻿CREATE TABLE [dbo].[VisitCode] (
    [Id]           UNIQUEIDENTIFIER NOT NULL,
    [name]         VARCHAR (128)    NOT NULL,
    [ColorCode]    VARCHAR (128)    NOT NULL,
    [DateCreated]  DATETIME         CONSTRAINT [DF__VisitCode__DateCreated] DEFAULT (getdate()) NOT NULL,
    [DateModified] DATETIME         NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


