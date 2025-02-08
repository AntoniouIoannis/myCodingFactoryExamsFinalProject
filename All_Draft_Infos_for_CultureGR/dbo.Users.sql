CREATE TABLE [dbo].[Users] (
    [UserID]       INT            IDENTITY (1, 1) NOT NULL,
    [Username]     NVARCHAR (50)  NOT NULL,
    [PasswordHash] NVARCHAR (255) NOT NULL,
    [Email]        NVARCHAR (100) NOT NULL,
    [RoleID]       INT            NOT NULL,
    PRIMARY KEY CLUSTERED ([UserID] ASC),
    UNIQUE NONCLUSTERED ([Email] ASC),
    UNIQUE NONCLUSTERED ([Username] ASC),
    FOREIGN KEY ([RoleID]) REFERENCES [dbo].[UserRoles] ([RoleID])
);


GO

CREATE INDEX [IX_Users_Username] ON [dbo].[Users] (Username)
