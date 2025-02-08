CREATE TABLE CATEGORIESMUSEUMS(
	[cat_id] [int] NOT NULL,
	[cat_name] [nvarchar](50) NULL,
 CONSTRAINT [PK_CATEGORIESMUSEUMS] PRIMARY KEY CLUSTERED 
(
	[cat_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

SELECT * FROM CATEGORIESMUSEUMS
ORDER BY cat_id
GO

SET LANGUAGE Greek;
GO

INSERT INTO CATEGORIESMUSEUMS(cat_id, cat_name)
VALUES
	(1, '������������ �������'),
	(2, '��������� �������'),
	(3, '���������� �������'),
	(4, '�������� �������'),
	(5, '������� ������'),
	(6, '������� ������� ��������'),
	(7, '������� �����������'),
	(8, '�������� �������'),
	(9, '�������� �������'),
	(10, '������� ���������'),
	(11, '����������� �������'),
	(12, '���������� �������');
GO

