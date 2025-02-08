CREATE TABLE [dbo].[Member]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Mem_Id] INT NOT NULL, 
    [Mem_Username] NVARCHAR(50) NOT NULL, 
    [Role_Id] INT NOT NULL
)

GO

CREATE INDEX [IX_Member_Username] ON [dbo].[Member] [(Mem_Username)]
GO