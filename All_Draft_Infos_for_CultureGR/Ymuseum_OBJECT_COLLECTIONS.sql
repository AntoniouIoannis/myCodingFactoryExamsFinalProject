CREATE TABLE [dbo].[COLLECTIONS](
	[coll_id] [int] NOT NULL,
	[collection_name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_COLLECTIONS] PRIMARY KEY CLUSTERED 
(
	[coll_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

INSERT INTO dbo.COLLECTIONS (coll_id, collection_name)
VALUES
	(1, '������'),
	(2, '���������'),
	(3, '���������'),
	(4, '��������'),
	(5, '���������'),
	(6, '��������'),
	(7, '���� ������'),
	(8, '����������'),
	(9, '��������'),
	(10,'���������'),
	(11,'������� ������'),
	(12,'����'),
	(13,'�����'),
	(14,'����������� ����'),
	(15,'�����');
GO




