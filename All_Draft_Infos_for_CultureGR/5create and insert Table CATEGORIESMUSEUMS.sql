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
	(1, 'Αρχαιολογικά μουσεία'),
	(2, 'Βυζαντινά μουσεία'),
	(3, 'Λαογραφικά μουσεία'),
	(4, 'Ιστορικά μουσεία'),
	(5, 'Μουσεία τέχνης'),
	(6, 'Μουσεία φυσικής ιστορίας'),
	(7, 'Μουσεία τεχνολογίας'),
	(8, 'Πολεμικά μουσεία'),
	(9, 'Θεματικά μουσεία'),
	(10, 'Μουσεία Επιστημών'),
	(11, 'Νομισματικά μουσεία'),
	(12, 'Εθνολογικά μουσεία');
GO

