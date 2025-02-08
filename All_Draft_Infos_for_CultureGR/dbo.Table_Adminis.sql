CREATE TABLE [dbo].[Administrators]
(
	[Admin_Id] INT NOT NULL PRIMARY KEY, 
    [Username] NVARCHAR(50) NOT NULL, 
    [Role_Id] INT NOT NULL 
)
