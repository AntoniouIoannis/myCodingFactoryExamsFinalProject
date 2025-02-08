USE [CultureGR]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CATEGORIESMUSEUMS](
	[cat_id] [int] NOT NULL,
	[cat_name] [nvarchar](50) NULL,
 CONSTRAINT [PK_CATEGORIESMUSEUMS] PRIMARY KEY CLUSTERED 
(
	[cat_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


INSERT INTO CATEGORIESMUSEUMS(cat_id, cat_name) VALUES (1, N'�������� �������');
INSERT INTO CATEGORIESMUSEUMS(cat_id, cat_name) VALUES (2, N'���������� �������');
INSERT INTO CATEGORIESMUSEUMS(cat_id, cat_name) VALUES (3, N'������� ������');
INSERT INTO CATEGORIESMUSEUMS(cat_id, cat_name) VALUES (4, N'������� ������� ��������');
INSERT INTO CATEGORIESMUSEUMS(cat_id, cat_name) VALUES (5, N'������� �����������');
INSERT INTO CATEGORIESMUSEUMS(cat_id, cat_name) VALUES (6, N'�������� �������');
INSERT INTO CATEGORIESMUSEUMS(cat_id, cat_name) VALUES (7, N'������� ���������');
INSERT INTO CATEGORIESMUSEUMS(cat_id, cat_name) VALUES (8, N'����������� �������');
INSERT INTO CATEGORIESMUSEUMS(cat_id, cat_name) VALUES (9, N'���������� �������');


CREATE TABLE [dbo].[TIME_PERIODS](
	[per_id] [int] NOT NULL,
	[per_name] [ntext] NULL,
	[per_time_start] [ntext] NULL,
	[per_time_end] [ntext] NULL,
	[per_desc] [text] NULL,
 CONSTRAINT [PK_TIME_PERIODS] PRIMARY KEY CLUSTERED 
(
	[per_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


INSERT INTO TIME_PERIODS (per_id, per_name, per_time_start, per_time_end, per_desc) VALUES 
(1, '������������ ��������', '2.5 ��. ������ �.�.', '10,000 �.�.', '� ���������� ���� ��� �����������, ���� �� �������� ������ �� �������-��������������.'),
(2, '���������� ��������', '10,000 �.�.', '8,000 �.�.', '���������� �������� ���� ������������ ��������� �������� ��� �������� ������������.'),
(3, '��������� ��������', '8,000 �.�.', '3,200 �.�.', '�������� ���������� �������� �� ��� ��������� ��� �������� ��� ��� ������� ��������.'),
(4, '����� ��� ������', '3,200 �.�.', '1,200 �.�.', '�������� ��� �������������� ��� ��� ������ ����� ��� ������ ��� �������� ��� ����.'),
(5, '����� ��� �������', '1,200 �.�.', '800 �.�.', '� ����� ���� � ������� ������������� ��� ����� �� ����� ����� ��� ��������� ���������.'),
(6, '������� ��������', '800 �.�.', '480 �.�.', '� �������� ����������� ��� ��������� ������-������ ��� ��� ������ ������� �����������.'),
(7, '������� ��������', '480 �.�.', '323 �.�.', '� ����� ����� ��� ������� �������, �� ������ ���� ���� ������, �� ��������� ��� �� ����������.'),
(8, '����������� ��������', '323 �.�.', '30 �.�.', '�������� ��������� ��� ��������� ���������� ��� ��� ��������� ��� �������� ��� ������� ����������.'),
(9, '������� ��������', '30 �.�.', '330 �.�.', '�������� ���� ��� ����� � ������ ������� ��� ������� ���������.'),
(10, '��������� ��������', '330 �.�.', '1453 �.�.', '� �������� ��� ���������� �������� ������� �� ���� ��� ����������������.'),
(11, '��������� ��������', '1453 �.�.', '1821 �.�.', '�������� ���� ��� ����� � ������ ���� ����� ��� ���������� �������������.'),
(12, '������� �������� ��������', '1821 �.�.', '������', '� �������� ��� ��� �������� ���������� ��� �� �������� �����.');


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
	(1, '������, ��������, ��������'),
	(2, '���������, ���������, ��������, ���������'),
	(3, '���������, ���������'),
	(4, '��������, �����'),
	(5, '���������'),
	(6, '������, ��������, ��������, ������ ������'),
	(7, '���� ������, ����������, ���������'),
	(8, '���������'),
	(9, '������� ������'),
	(10, '����, ����������� ����, ��������'),
	(11,'����������� ����'),
	(12, '������ �������'),
	(13, '����� ��� ����������'),
	(14, '���������� ��� ��������');


GO


CREATE TABLE [dbo].[MUSEUMS](
	[mus_id] [int] NOT NULL,
	[mus_region] [nvarchar](150) NOT NULL,
	[mus_name] [nvarchar](150) NULL,
	[mus_desc] [text] NULL,
	[mus_address] [text] NULL,
	[mus_coordinate] [geography] NULL,
	[mus_phone] [nchar](60) NULL,
	[mus_open] [nvarchar](150) NULL,
	[category_id] [int] NOT NULL,
	[collection_id] [int] NOT NULL,
	[mus_avg_rate] [tinyint] NULL,
 CONSTRAINT [PK_MUSEUMS] PRIMARY KEY CLUSTERED 
(
	[mus_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


---SELECT geography::STPointFromText('POINT(25.8569979 40.8476801)', 4326);
---SELECT geography::STPointFromText('POINT(24.9537921 40.9810199)', 4326) AS GeoData;
/******************************************************************/
---������� ��� STPointFromText:

---�� longitude (���������� �����) ������ �� �������� �����.
---�� latitude (���������� ������) ������ �� �������� �������.
---���� ������:

---�� ���������� ����� (longitude) ���������� ��� ������� 19.5 ��� 28.5.
---�� ���������� ������ (latitude) ���������� ��� ������� 34.5 ��� 41.5.
/*******************************************************************/
DECLARE @g geography;
SET @g = geography::Point(37.9838, 23.7275, 4326);

INSERT INTO MUSEUMS (mus_id, mus_region, mus_name, mus_desc, mus_address, mus_coordinate, mus_phone, mus_open, category_id, collection_id, mus_avg_rate)
VALUES
	(1, '��������� ��������� ��� �����', '������������ ������� ���������������', '��� ������ ������ ��� �������������� �������� ��� ���������� ��� ������� ��� �������� ��� ���� ������������� ��� ��� ���� ��������� ������� ��� ����������� ��� �� ������� ����� ��� ������������� �������� �����.', '�������� ������ 44, �������������� 68131', geography::STPointFromText('POINT(40.8476801 25.8569979)', 4326), '(+30)2551026103', '��� 1/11 ��� 31/3 �������, �������, ������, ���������, ������� 08:30 � 15:30', 1, 1, 5),
	(2, '��������� ��������� ��� �����', '������������ ������� �������', 'To ������������ ������� ������� ����������� ��� ������� ��� ����� ��� ������� ��� ��� ������ ��� ��� 7� ��. �.�. ����� ��� 12� ��. �.�. �� �������� ��� ��������� ���� ��� ����� ���� ��� ��� ��������� ��� ������� ��������� ��� ��� ��� ���� ��� ������������ � ���� ���� ������� ��� ������ ���� ��� ���� ������ �������� �����.', '�. �������� 2, ������ 67061', geography::STPointFromText('POINT(40.9810199 24.9537921)', 4326),  '(+30) 2541051003', '���������� ����� ������� 08:30 � 15:30', 1, 1, 3),
	(3, '��������� ��������� ��� �����', '������������ ������� ������', '�� ������������ ������� ������ ��������� �� ������������ ��� ����������� ����������� ��� ��������� �������� ��� ������������� �������� ������ ����������, ����� ���� �������� ��� �������������� �������� ��� �� ���� ������������ ������� (50.000 ������ ��� ������) ��� ���� ��������� �������.', '���������� ��������� 2, ����� 66133', 	geography::STPointFromText('POINT(41.1479538 24.1433015)', 4326), '(+30) 2521031365)', '���������� ����� ������ 08:30 � 15:30', 1, 4, 4),
	(4, '��������� ��������� ��� �����', '������������ ������� �������', '���� ������ ��� ������������� � ������� ��� ������� ��� ��� ������ ��� ��� 7� �� �.�. (�������) ��� �� ����� ��� ���������� ������ (�����������), ����� ��� ��� ��������� �������� ���.', '������� ������� 17, ������ 65110', geography::STPointFromText('POINT(40.93570225 24.4037281081839)', 4326), '(+30) 2510222335', '���������� ����� ������ 08:30 � 15:30', 1, 2, 4),
	(5, '��������� ��������� ��� �����', '��������� ������� ������������', '�� ��������� ������� ������������ ����� ��� ��������� ��� ���������� ��� �������� �� ������ �����-�����������, �������������� ���� ��� ���������� ����������� ��� ���� ��� ������������� ���� ������� ��� ���������� �������������. ��������� � ������ ����������� ��� ��� ������������������� ��� ��������, ����������� ���� ����� ���� ��� ���� ��������� ��� �������� ��� ��� ���������� ���� ���� ��������� �������.', '�������������� ��� ����������, ����������� 68300', geography::STPointFromText('POINT(41.3474704 26.497726475)', 4326), '(+30) 2553023960', '��� 1/11 ��� 31/3 �������, ����� �������. �������, ������, ��������� & �������: 08:30 � 15:30. �������: 13:00 � 20:00.', 1, 2, 4),
	(6, '������', '������ ������������ �������', '�� ������ ������������ ������� �������� �� 1893 ��� ���������� �� ���������� ������ ��� ������������ ������ ��� ���� 1866 ��� 1889. ����� �� ���������� ������� ��� ������� ��� ��� ��� �� ������������� ���� �����. �� �������� �������� ���, �������� ����������� ��� 11.000 ��������, ����� ��� �������� ��� ������� ��������� ���������� ��� ��� ����� ��� ����������� ��� ��� ������ ����������.', '28�� ��������� (��������) 44, ����� 10682',  geography::STPointFromText('POINT(37.98899787540997 23.733011484146118)', 4326), '(+30) 2132144800', '���������� 09:00 - 15:00', 1, 2, 5),
	(7, '������', '������������ ������� ����������� ������', '������������ �������� ��� �������������� ��� ��� 3� �������� �.�. ��� ��� �� ������������� ������� �������������� ��� ������� ��� ���������, ���� ��������� ��������� �������� ��� �������.', '������� ����������� ������ ���������� ���������, �����, ������ 1900', geography::STPointFromText('POINT(23.9465284918041 37.93732705 )', 4326), '2103530000', '����������', 1, 4, 5),
	(8, '������', '������������ ������� �������', '�� ������������ ������� ������� ��������� �������� ��� ��� �������� ������� ��� ����������� (������, �������) ��� ��� �� ������������ - ������������� ����������, �������������� ������ ��� ���������� ���� ��� �������������� ���� ������� ��� �� 5000 �.�. ��� ��� 6� ��. �.�. ��������� ���� ��� ������� �������� �� ��������� ������ ��� �� ������ ��� ���� ��� ��������� ��� ������, ����� ��� ��������� ��� ����������� �������� ��� ���� �������� ������ ��� �����������.', '������ �������� 1, ������, ������ 19500', geography::STPointFromText('POINT( 37.7168338 24.05389062651)', 4326), '(+30) 2292022817', '��� 1/11 ��� 31/3 ���������� 08:30 � 15:30, ����� �������', 1, 4, 5),
	(9, '������', '��������� ��� ����������� �������', '�� ��������� ��� ����������� ������� �������� �� 1914 ��� ��� �� 1930 ���������� ��� Villa Ilissia, �������� ���������� ��� ���������� �� 1848 ��� ��� ����������� �������� ������� �� �������� ��� �������� Sophie de Marbois-Lebrun, ��������� ��� ����������. ����� ��� ��� �� ������������� ������� ������� ���������� ���� ����� ��� ��� ��������� ��� ���������� ��� �������������� ������. �������� ����������� ��� 25.000 �����������, ���������� �� ��������, �� ����� �������������� ��� ��� 3� ��� ��� 20� ����� �.�.', '�������� ���������� ������ 22, ����� 10675', geography::STPointFromText('POINT(37.974779813113656 23.74470055103302)', 4326), '(+30) 2132139500', '��� 1/11 ��� 31/3 ���������� 08:30 � 15:30, ����� �������', 1, 7, 5),
	(10, '������', '������� ���������', '� ���������� ��� ������� ��� ��� ��������� ��� �������������� ������� ��� ��� ��������� ���������� ��� �������� ������, ���� ��� �������� ����� ��� ��� ������, ������������� �� ��� ���������� ��� ������� ��� ��� ������� ��� ��������� ���� ������� �������', '��������� ����������� 15, ����� 11742', geography::STPointFromText('POINT(37.9685667 23.7284816413335)', 4326), '(+30) 2109000900', '���������� 09:00 - 21:00', 1, 6, 5),
	(11, '������', '������������ ������� �������', 'To ������������ ������� ������� ��������� ����� ��� ������ ��� ����. ��� ������ ������ ��� �������������� �������� ��� ����������� ������ ��� ��� �������� ������� ��� ������� ��� ��� �� ����� ��������� ������ ��� �������. ', '�������� �������� 31, �������� 18536', geography::STPointFromText('POINT(37.9371628 23.6441568843707)', 4326), '(+30) 2104590731', '��� 1/11 ��� 31/3 ���������� 08:30 � 15:30, ����� �������', 1, 1, 4),
	(12, '������ ������', '������������ ������� ������', '�� ������������ ������� ������ ���������� �� ������� ������ ��� 19�� ��., ��� ������ ����������� �� �������� �����������. o ����������� ����� ���� �� ����� ����� � ������ ������ ���� �������������� �������� ��� ���� ������������� ��������� ��� ������, ����� ��� ������ ��� ��������� ��������� ������ ��� �� �����, ��� ����� ��� ��� ������.', '�������� ������������, �������� ������, ������ 81400', geography::STPointFromText('POINT(39.8802573 25.0623226)', 4326), '(+30) 2254022990', '��� 1/11 ��� 31/3 ���������� 08:30 � 15:30, ����� �������', 1, 6, 4),
	(13, '������ ������', '������������ ������� ��������� (��� ������)', '�� ������������ ������� ��������� (��� ������) ������������� �� 1999 ��� � ������ ��� ����� ���������� ��� ����� ��� ������������ ��� �������� ��������, ���� �� �������� ��� ������ �� ���� ������� ��������� ��������. �������� ������, ������������ ��� ���� �������� ����������� ��� �������� ��������, ����� ��� �������� ��������� �������������� ���� �������� ���.', '8�� ���������-������, �������� 81100', geography::STPointFromText('POINT(39.106792 26.5615094393943)', 4326),  '(+30) 2251040223', '���������� 09:00 - 21:00', 1, 1, 4),
	(14, '������ ������', '������������ ������� �����', '�� ������������ ������� ����� ���������� �� ��� ������, �� ������, ������� ���������� ������ ��� ������������ �� 1912, ��� �� ���, ������ ��� ������������ �� 1984. ��� ������ ������ ���������� �������� ��� �� ����� ��� ����� (��������, ������, ���������� ��� �����, �������������, ���� �.��.), ��� �� ��� �������� �� ���������� ��� ��������, �� ��������� �������� �������� ��������.', '������� ����������, ���� 83100', geography::STPointFromText('POINT(37.7544313936541 26.978890299411916)', 4326), '(+30) 2273027469', '��� 1/11 ��� 31/3 ���������� 08:30 � 15:30, ����� �������', 1, 7, 5),
	(15, '������ ������', '������������ ������� ����', '�������������� �������� ����������� ��� ���� ������������� ��������� ��� ������, �������������� ���� ��� ��������� �������� ����������� ���������, ���������, ���������, ������� ������� �������, �������� ��� �� ������ ����, �������� ������ ��� ���������� ������.', '������� 10, ���� 82100', geography::STPointFromText('POINT(38.3651338 26.1390513)', 4326), '(+30) 2271044239', '��� 13-5-2024 �� ���������� ������� ����� ��������.', 1, 2, 4),
	(16, '������ ������', '������������ ������� ��������', '��������� �������� ��� ����������� ��� ���� ����������� �������������� ������ ��� ����������������, ������ ��� ������ �� ���� ��� ������� ��� �� ���� ��� ���������, ��� �������������� ��� ���� ������������� ������� ��� �� ������� ���������.', '�������� ��� ���������� 1, ������� 30131', 	geography::STPointFromText('POINT(38.63066225 21.4091457324419)', 4326), '(+30) 2641027377', '��� 1/11 ��� 31/3 ���������� 08:30 � 15:30, ����� �������', 1, 10, 4),
	(17, '������ ������', '������������ ������� ��������', '��������� ���� �������� ��� �� �������� ��� ���������� �� �� ���� ��� ��������, ���� ��� �� ���������� ��� ������������� ����������� ��� ���������� ������ ��� �����������. ������ ����� ��������������� ������ ���� ��� ������� ��������� ������, ���� � ����� ��� ���������, � ���� ��� �������� ���� ��� � ������� ��������� ��� ��� ��� ��� ����.', '������ ������� 27065', geography::STPointFromText('POINT(37.64351605 21.6294706408377)', 4326), '(+30) 2624022742', '���������� 09:00 - 21:00', 1, 11, 5),
	(18, '������ ������', '������������ ������� ������', '� ��������, � ����������, � ���������, �� ������� ��� �� �������������� ��������, �� ������ ����� ��� �������� ��� �������� ��� ��������� ������ �������������� ���� ��������� ���� ��� �������� ��� �������������� ��� ���� ������������� ��� ��� ���� ��������� �������.', '���������� 10, ������ 27131', geography::STPointFromText('POINT(37.67138285 21.4406156188737)', 4326), '(+30) 2621020475', '��� 1/11 ��� 31/3 ���������� 09:00 - 21:00', 1, 2, 5),
	(19, '������ ������', '����������� ������������ ������� ����� ������ �����������', '��� ������ ������ ��� �������������� ����������� ��� 1.200 ����������� ��� ��������� ����������� ��� ��������� ��� ���� ������������� ��� ��� ���� �������� ��������� ������� (100.000 �.�. � 3�� ��. �.�.) ��� ����������� ��� �� ������ ��� �.�. ����������������.', '��. ������ 2', geography::STPointFromText('POINT(38.37009276166383 21.427660882472995)', 4326), '(+30) 2631026068', '��� 1/11 ��� 31/3 ���������� 09:00 - 17:00', 1, 2, 5),
	(20, '������ ���������', '������������ ������� ��������� ���������', '� ������������ ������� ��������� ����� ���������� ���� ������� ��������� ������� ��� ��������� ���������. �� ����� �������������� ������ ��� ������� ���� �������� ��� �����, ���� ���������-���������� ��� ���� ��������� ��� ���������� �����������������.', '��������, �������� 52057', geography::STPointFromText('POINT(40.48481105 21.292550495852)', 4326), '(+30) 2467085765', '��� 1/11 ��� 31/3 ���������� 09:00 - 21:00', 1, 4, 3),
	(21, '������ ���������', '������������ ������� �������', '���� ������������ ������� ������� ���������� ������ ��� ��� ���������� ������ ��� ��������, ������������������� ��� ��������� ��� ������� �������� ��������� ��� ������������� �������� �������, ������������� ��� ������� ��� �������� ��� ���� ������������� ��� ��� ���� ��������� �������.', '����������� 8, ������ 50131', geography::STPointFromText('POINT(40.30228157225952 21.785558760166168)', 4326),  '(+30) 2461026210', '��� 1/11 ��� 31/3 ���������� 08:30 � 15:30, ����� �������', 1, 2, 4),
	(22, '������ ���������', '������������ ������� ��������', '�� ������������ ������� �������� ������������ ���������������� �������� ��������� ��� ������������� ������ ��� ������������� �������� ��������, ����������� ��� ����� ������� ��� ���� ����������� ��� ��� ���� ����������� �������.', '�������������� ������� 8, ������� 53100', geography::STPointFromText('POINT(40.78076515 21.4137781079334)', 4326), '(+30) 2385028206', '��� 1/11 ��� 31/3 ���������� 08:30 � 15:30, ����� �������', 1, 1, 4),
	(23, '�������', '������������ ������� �����', '� ������ ��� ������������� �������� ����� ����� ���������� ���� ������, ��� ���� ��� ��� ���������� ��� ���������, ��� ����������� �������� ��� ��������� ������� ���� ��� �� �������� ���� ��� �����. ����������� ��� ������� ��� ���� ��� �� ������� ��� �������� ��� ��� �����������, �� ����������� ��� �����, ���� ��� �� ������ ��� ��� ������� ������.', '������� �������� �����, ���� 47100', geography::STPointFromText('POINT(39.14952335 20.9793951319486)', 4326), '(+30) 2681021191', '��� 1/11 ��� 31/3 ���������� 09:00 - 21:00', 1, 2, 4),
	(24, '�������', '������������ ������� ������������', '� ������ ������ ��� ������������� �������� ������������ ������������ �������� ��� ���������, �����������, ��� ��������� ������ ������� ���������� ��������� ���� ���������� ����, ��� �� ���� ������������ ������� (100.000 ������ ���� ��� ������) ��� ���� ������� ��� ���������� ����������, �� �� ���������� �� �������������� ���� ����������� �����, ������� ������� ��� ��� ����������� ������.', '28�� ��������� 2, ����������� 46100', geography::STPointFromText('POINT(39.51143815 20.2587941260403)', 4326), '(+30) 2665028539', '���������� 09:00 - 16:00', 1, 10, 4),
	(25, '�������', '������������ ������� ���������', '������������ �������� ��� ��� ��� ������, ����������� ��� ������� ������� ��� ��� �������� ������������ ����� (250.000 ������ ����) ��� ���� �������� ��������� �������. ��������� ������ ������� ��� �������� ��� �� ���� ��� �������, ��� ��� �� ������������ ������� ��� ������� ��������� ������.', '������� 25�� ������� 6, �������� 45221', geography::STPointFromText('POINT(39.66666475 20.8560010015229)', 4326), '(+30) 2651001089', '��� 1/11 ��� 31/3 ���������� 08:30 � 15:30, ����� �������', 1, 11, 5),
	(26, '������ ������', '������� ��� �������� ��� ���������� ������', '�� ������� ��� �������� ��� ���������� ������ ��� ����������� ��������� ���� ��� 400 ������ ����, ��� ����������� ��� �� ���� ��� ���� ��� ��������, ���� ��� ��� ���� ������� ��� ��������� �����������. �� �������� ��������� ������ ����������� �����, ��� �� ������� �������� �.�. ��� ��� ��� 5� ��. �.�. �� ������ ����� ������� ���� ��������� �������� ��� ���� ��� ���� ������������� � ������������ ������� ��� ���������� ������, ��� ������������� ������ ��� �����������.', '', geography::STPointFromText('POINT(37.64105456051856 21.625544080459278)', 4326), '30 26240 29119', '���������� (������� - �������): 08:30 - 15.30', 1,  10, 5),
	(27, '������', '������� ������� �����o�', '���� 10 ������� �������� ��� ����� �������� ��������� ������� 1850 �.�. ������������� �� �������� ����� � ������� ������ ��� ���������� ���� ����� ������. ���� ����� ���������� � ������� ����������, �� ���� ��� �������������� ������������� ��� 19�� ��� 20�� ����� (����������-��������-����� �.�.). ��� �������� ������������� � ������� ������������� ��� ������� ���� ����������, ���� ����������, ��� ��������� ��� ������������� ������� �� �� ����� ��� 18�� �����, ����� ����������� �������� ��� ��� ��� � ��������� ������ ��� ��� ����� ���. ���������, ������� ������ ��� �������� ��� ��� ��������� �������� ���� ���������. �� ���������� ���������� �������� ������� ��� ������� ��� ������� ��� ��������� ��������.', '���� �������������, ��������, �.�. 185 37, �������� (����� �������)', geography::STPointFromText('POINT(37.92815220845 23.63789)', 4326), '+30 210 4516264, 4286959', '�������, ������� ��� ������ �������. ����� - �������: 09.00 - 14.00', 6, 10, 4),
	(28, '����� ������', '������� ������� �������', '��� �������� ��� �������� ��������������� ��������� ������ ��� ��� ���-������� ������� ����� ��� ����� ��� 20�� �����, �������� ���������� �������, ������ ��������� ��� ������, ������ �����������, ������� ������, ���������� ��� ��������, ����� ��� ��������� �� ������� ������ ��� ��� 5� ����� �.�..', '������� �������� 10, ������� (����� ��������)', geography::STPointFromText('POINT(37.44527903074 25.32839621717)', 4326), '+30 22890 22700 , 210 8125547', '��� 1� �������� ��� 30 ��������� ����� �� �������: 10:00-13:00 & 18:00 � 21:00', 6, 10, 4),
	(29, '������', '����������� �������', '�� ����������� ������� ����� ��� ��� �� ���������� ������� ������� ��� �������. ������������� �� 1834, ��� ���� ������ �� �� ������ ������������ �������. � ������������ ��� ������ ����������� �� ��� ��� ������ ��� � �������� ������ ��� ������������ ������� ������������ ��� �������� ��� ���������� ��� ������� ������������ �����������. ����, ��� ��� ����, � ������� ��� �������� ��������� ����� �� ��� ������� ��� ������������ �������, ��� ���������� �������� ��� ��� ������������ ������������ ��� ���� ������. ����������� ���� ���� ������ ��� ����, ������ ��� � ������������� ��� �������� ��� �� ���������.', '��. ��������� 12, ����� 106 71', geography::STPointFromText('POINT(37.97775645 23.735391134)', 4326), '+30 2103632057', '��� 1 ��������� 2024 ��� 31 ������� 2025 ������� � �������: 08.30 � 15.30<br>����� �������', 8, 5, 3),
	(30, '������������', '������� ��������� ��� ����������� ������������� ������', '�� ��� ���������� �� �� ���������� �������� ��� ��� ���������� ���� �� ����� ��� ���������� ���� �� ����������� ������ ���� ��� ������������ �����������. �� ����� �� ����� ��������� ��� ����������� ��� �������� ��� �������� ����������� ��� �����, ��������, ����������, ������������� �����������, �������� ��� ����������� �����, ������, ������ ��� ���� ����������� �����. �� ����� ��� ������� ���������� ������ ��� ������. ��� ��� ����������� ��� �������� �� ��� ����� �� ����� �� ������ �� ������ ������� �� ���������. ����� ������ ����� ���� ������ ��� �� ����� ��� ����� ���� ������ ���� ������� ����� � ��������� ��� ������ ��� �� ���������� ���� ���������� ��� ��������.', '����������������� ������ 265 04', geography::STPointFromText('POINT(38.28777600591 21.78474302675)', 4326), '', '������� - ��������� 9:00 - 14:00', 7, 14, 5),
	(31, '�������� ���������', '������ ��������� ��������� ��������� ������������', '�� ������ ������������ ������������� ���������� �� ������� ��� ��� �������, ���������, ����������� ��� ��������� ��� �������. ������ ���������-����������� �� ����� ��� �������� ��������� ��� ������� �������. ����� ������ ������ 300 ����������� ��� ������ ��� �������� 1880-1943, �� ������ ��� ��� ��� ��� ������� ��� ������������, ��� ����� ������� ��������, ���� ���������� ������� ���������� �����������, ������������ ����������, ������� �������� ���������� ��� ��������.', '���. ��������� 26, �.�. 54624, ����������� (����� ������������)', geography::STPointFromText('POINT(40.63450691337 22.94146102366860)', 4326), '+30 2310 2279063, 223231', '��� 1� ��������� ��� 31 ������� 2010  08:30-15:00 ', 1, 3, 5),
	(32, '�������� ���������', '������ ������: �������', '� ������ ������, �� ����������� ������� ��� ������������, ��������� ��� ��� 5 ����������� 2008 ������ ���������� ��� �����������, ��� ���� ��� ��� ����� ���� �� ����� ���� ��� ��������� �������� �������� ��� ��� ��� ���� ������� ��� ��������� �������� �� ����������� ��������, �������� ��� ���������. � ������ ��������� ��������� ��� �� ���������� ����� ��� ������� ��� ����� ��� ��� ������ ��� �� 316/15 �.�. ����� ��� ����� ���. � ������ ��� ��� ����� �� ������������� �� ���� ������� ��� �����, ���������, ��������� �� ��������� �� ����������� ������ ����� ��������� ��� ��� �� ��������� �� ���������� ���� ��� �������� �������� ���� ��� �� �������� ������� ��� �� ������� ���.', '������ ������� ������������, ����������� (����� ������������)', geography::STPointFromText('POINT(40.62636539360450  22.948334258804)', 4326), '2310267835', '��� 1� ��������� ��� 31 ������� 2010  08:30-15:00', 1, 3, 5),
	(33, '������', '������� ��� ������ ������� ��� ��������� �������', '���� �������� ��� ���������� �������� ��� ��������� ����, ������� ��������� ��� ������� �����������, �����������, �������, ��������� ����������� ���������� �������� ��� �������, ������ ��� �����������. � ���������� ������������ ���� ���� 25.000 ������ ��� �� ������ ��� ��� �������� ��� ���� ������������. �� �� �������� ������, ���������� ��� 18�� �����, ����������� ��� ������ ��� ������� ��� ��� 19� �����.', '��������� 50, �.�. 10679, ����� (����� �������)', geography::STPointFromText('POINT(37.98121474553 23.734932700022)', 4326), '+30 210 3629430, 3637453', '��� 1� ��������� ��� 31 ������� 2010: 08:30-15:00', 9, 13, 4),
	(34, '������������', '������� ��� ����� ��� ��� ��������� ������', '�� ������� ��� ����� ��� ��� ��������� ������ ��� ������ ���� �� ����� ����� �� ��������� ��� ��������� ��� ��� ���������� ��� ����� ��� ��� ��������������, ��� ��������� ������� �� ��� ��������, ��� ���������� �� ���������� ���������. ����� �������� ��� ����� ��� ���� ������ ��� ��������� ���� ������ ��� ��������, ���� ��� ��� ������ ��������������� �������� ��� ����� ���.', '������ - ������� 129, �.�. 23100, ������ (����� ��������)', geography::STPointFromText('POINT(37.07058133628 22.4262401929262)', 4326),	'+30 27310 89315, +30 210 3256922-3', '16 ���������-28 �����������: 10.00- 17.00 1� �������-15 ���������: 10:00-18:00', 4, 13, 3),
	(35, '����� ������', '������������ ������� �������������', '�� ������������ ������� ������������� ���������� ��� �� 1984 ��� "������" ��� �������� ����� ��� ����������� ������� ��� ��. ��������. ��������� ��� �������� "�����" ��� ��������� ��� ������� ������, ��� ������ �� ������� �������� ��� ������ ��� �������������, ��� � ������ �������� �������� ��� 19�� ��., ����� �������������.', '������� (����� �����������)', geography::STPointFromText('POINT(36.151557010643 29.593552924569)', 4326), '+30 22460 49283', '������� �� ��� ������� 08:30-15:30', 1, 1, 5),
	(36, '�����', '��������� ��� ������������� ������� ������', '�� ������� ������������ �����, �� ����� ���� ������������ ��� ��� ��������� ��� ��� ����� ������ ��������� � 13� ������� ���������� ����������� ��� ���� ������, ���� ��� ��� ������������ ��� ������, ��������� ��� ������� ���� ����� ������������ �� �������� � �������� ������ ��� ����������� ����� ��� ������ ��� �� ����������������� ������ ��� ��� ��� ������������. ���������������� �������� ����� ��� �������� ���������� ��� ��� ��� San Salvatore.', '������������� 78, �.�. 73131, ����� (����� ������)', geography::STPointFromText('POINT(35.5184569330556 24.015186969686)', 4326), '+30 28210 96046', '��� 1� ��������� 2024 ��� ��� 31� ������� 2025 08:30-15:30', 1, 10, 4),
	(37, '������', '������� ��������� ������� ��������', '�� ������� ��������� ������� �������� (�.�.�.�.) �������� �� 1964 ��� ��� ������ ��������� ��� �� ���� ���������, �������� �� ����� ������� ������� �������� ���� ������ ��� ��� ����� �������� ����� ��� ��������� ��� �������������� ����������.', '������� 13 ��� ������ 100, 145 62 �������', geography::STPointFromText('POINT(38.07437 23.81466)', 4326), '210 8015870', '���������� 09:00 - 16:00', 4, 12, 6),
	(38, '������', '������ ���������� - ������� ���������� �������', '�� ��� ��������������� �������� ���������� ��� ������� ����������� ���������� �� ��� ��������� ��� ����������� �������� ������� ����� ��� ��������� �����. �� ������� ��� ������������� ��� 20.760 �2: ���� ����������� ���������� �����, ��������� �������� ����� ������, ���������� 240 ������, ���������� �������� ��� ������ ����������� ���������� ����������.', '���. ������������ 50, 116 34, �����', geography::STPointFromText('POINT( 37.97559497406455 23.7493779939187)', 4326), '+30 214 40 86 201',  '���������� 09:00 � 16:00', 3, 13, 5),
	(39, '������������', '������������� ���������� ������', '', '������������ ����������� 123 & ���������� 23100, ������', geography::STPointFromText('POINT( 37.07695764737334 22.429012602272806)', 4326),  '+30 27310 81822', '���������� 10.00 � 15.00', 3, 7, 4),
	(40, '������������', '������ ���������� ��������', '����������� ���� ��� ��� �������� ��� �.�.�.�.�., �� �������� ����������� ��� ��� ����� ��� �21, ��� ������  ������� ����� ���� �������� ��������� ��� ������ ����������� ��� ��������� �������. �������� ��� ���� ���� ������������� ���������� ��������.', '������� ��������� 23 21100, �������', geography::STPointFromText('POINT(37.56615366257611 22.80446382054443)', 4326), '+30 27520 21915', '���������� 10.00 � 15.00', 3, 2, 5),
	(41, '������', '������ ����������', '� ������ ���������� ���������� �� ��� ������ ��� ����� ��������� �������, ��� ����� �������, �����. ���� ��� ����� ���������, �� ��� ������ ������� �����.',  '����� �������, ����� 115 25 �����', geography::STPointFromText('POINT(37.98700875 23.776904327299)', 4326), '+30 210 77 09 855', '���������� 09:00 � 16:00', 3, 6, 5);
GO


CREATE TABLE UserRoles (
    RoleID INT PRIMARY KEY IDENTITY(1,1), 
    RoleName NVARCHAR(50) NOT NULL UNIQUE);

CREATE TABLE Users (
    UserID INT PRIMARY KEY IDENTITY(1,1), 
    Username NVARCHAR(50) NOT NULL UNIQUE, 
    PasswordHash NVARCHAR(255) NOT NULL, 
    Email NVARCHAR(100) NOT NULL UNIQUE, 
    RoleID INT NOT NULL, 
    FOREIGN KEY (RoleID) REFERENCES UserRoles(RoleID));



INSERT INTO UserRoles (RoleName) VALUES ('CultureGRAdmin');   --- full access on the database
INSERT INTO UserRoles (RoleName) VALUES ('Viewer');					--- only reading
INSERT INTO UserRoles (RoleName) VALUES ('Subscriber');				--- reading and writing NOT deleted
INSERT INTO UserRoles (RoleName) VALUES ('Writer');					--- reading, writing, updated NOT deleted
INSERT INTO UserRoles (RoleName) VALUES ('Banned');					--- Banned User

select * from Users
select * from UserRoles

-- Insert users into Users
INSERT INTO Users (Username, PasswordHash, Email, RoleID)
VALUES ('CultureJohn', HASHBYTES('SHA2_256', 'std_admin_157733'), 'antoniou_ioannis@aueb.gr', 1); 

INSERT INTO Users (Username, PasswordHash, Email, RoleID)
VALUES ('WriterGiannis', HASHBYTES('SHA2_256', 'std157733'), 'std157733@ac.eap.gr', 4); 

INSERT INTO Users (Username, PasswordHash, Email, RoleID)
VALUES ('WriterAfentra', HASHBYTES('SHA2_256', 'ak24011971'), 'afentrak@gmail.com', 4);

INSERT INTO Users (Username, PasswordHash, Email, RoleID)
VALUES ('ReaderDimitris', HASHBYTES('SHA2_256', 'std_read_157733'), 'draranch@gmail.com', 2);

INSERT INTO Users (Username, PasswordHash, Email, RoleID)
VALUES ('SubGiannis', HASHBYTES('SHA2_256', 'std_sub_157733'), 'antoniouioannis10@gmail.ocm', 3); 

INSERT INTO Users (Username, PasswordHash, Email, RoleID)
VALUES ('ReaderGiannis', HASHBYTES('SHA2_256', 'std_read2_157733'), 'aj10051973@gmail.com', 2);

INSERT INTO Users (Username, PasswordHash, Email, RoleID)
VALUES ('SubGiorgos', HASHBYTES('SHA2_256', 'seniorGiorgos'), 'georgealvanos4@gmail.com', 3); 

INSERT INTO Users (Username, PasswordHash, Email, RoleID)
VALUES ('SubGanton', HASHBYTES('SHA2_256', 'Ganton'), 'ganton@gmail.com', 5); 

INSERT INTO Users (Username, PasswordHash, Email, RoleID)
VALUES ('WriterHistorical', HASHBYTES('SHA2_256', 'cult_arch'), 'arch@gmail.com', 4);  --- ���������� ��������� ��������

INSERT INTO Users (Username, PasswordHash, Email, RoleID)
VALUES ('WriterArts', HASHBYTES('SHA2_256', 'cult_art'), 'art@gmail.com', 4);   --- ���������� ������ & ����������

INSERT INTO Users (Username, PasswordHash, Email, RoleID)
VALUES ('WriterThematic', HASHBYTES('SHA2_256', 'cult_tema'), 'tema@gmail.com', 4);   --- ���������� ��������� (�������, ���������, ������� ��������)

select * from Users
order by UserID;

select * from UserRoles
order by RoleID;

