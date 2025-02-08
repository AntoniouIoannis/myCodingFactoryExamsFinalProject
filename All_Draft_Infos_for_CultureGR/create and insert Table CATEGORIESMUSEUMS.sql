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
	(1, 'Αρχαιολογικά μουσεία'),
	(2, 'Βυζαντινά μουσεία'),
	(3, 'Λαογραφικά μουσεία'),
	(4, 'Ιστορικά μουσεία'),
	(5, 'Μουσεία τέχνης'),
	(6, 'Μουσεία φυσικής ιστορίας'),
	(7, 'Μουσεία τεχνολογίας'),
	(8, 'Πολεμικά και ναυτικά μουσεία'),
	(9, 'Τέχνης'),
	(10, 'Ιστορικά'),
	(11, 'Θεματικά'),
	(12, 'Επιστημών'),
	(13, 'Νομισματικά'),
	(14, 'Εθνολογικά');
GO

SELECT * FROM CATEGORIESMUSEUMS
GO