USE [CultureGR]
GO

/****** Object:  Table [dbo].[EXHIBITS]    Script Date: 4/1/2025 01:52:05 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[COLLECTIONS](
	[exh_id] [int] NOT NULL,
	[name_collection] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_COLLECTIONS] PRIMARY KEY CLUSTERED 
(
	[exh_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

INSERT INTO dbo.EXHIBITS (exh_id, name_collection)
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
	(10, '���������'),
	(11, '������� ������'),
	(12, '����'),
	(13, '�����'),
	(14, '����������� ����'),
	(15, '�����');
GO

SELECT * FROM EXHIBITS
GO


