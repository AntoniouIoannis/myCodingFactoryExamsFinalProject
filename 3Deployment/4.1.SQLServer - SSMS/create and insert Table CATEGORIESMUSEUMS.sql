USE [CultureGR]
GO

/****** Object:  Table [dbo].[CATEGORIESMUSEUMS]    Script Date: 14/1/2025 15:29:22 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[CATEGORIESMUSEUMS](
	[cat_id] [int] ,
	[cat_name] [nvarchar](100) NULL,
 CONSTRAINT [PK_CATEGORIESMUSEUMS] PRIMARY KEY CLUSTERED 
(
	[cat_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
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
	(8, '�������� ��� ������� �������'),
	(9, '������'),
	(10, '��������'),
	(11, '��������'),
	(12, '���������'),
	(13, '�����������'),
	(14, '����������');
GO

SELECT * FROM CATEGORIESMUSEUMS
GO