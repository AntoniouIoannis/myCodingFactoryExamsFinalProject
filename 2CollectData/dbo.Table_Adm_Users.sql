CREATE TABLE [dbo].[AdministratorIsUser]
(
	[Admin_Id] INT NOT NULL , 
    [User_Id] INT NOT NULL, 
    CONSTRAINT [FK_AdministratorIsUser_Admin] FOREIGN KEY ([Admin_Id]) REFERENCES [Administrators]([Admin_Id]), 
    CONSTRAINT [FK_AdministratorIsUser_User] FOREIGN KEY ([User_Id]) REFERENCES [Users]([UserID])
)
