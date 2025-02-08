CREATE TABLE [dbo].[AdministratorIsUser] (
    [Admin_Id] INT NOT NULL,
    [User_Id]  INT NOT NULL, 
    CONSTRAINT [PK_AdministratorIsUser] PRIMARY KEY ([Admin_Id], [User_Id])
);

