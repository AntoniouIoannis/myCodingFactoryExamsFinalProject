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
	(1, 'Αγγεία'),
	(2, 'Ενδυμασία'),
	(3, 'Επιγραφές'),
	(4, 'Εργαλεία'),
	(5, 'Νομίσματα'),
	(6, 'Αγάλματα'),
	(7, 'Έργα Τέχνης'),
	(8, 'Κατασκευές'),
	(9, 'Ψηφιδωτά'),
	(10,'Κοσμήματα'),
	(11,'Μουσικά Όργανα'),
	(12,'Όπλα'),
	(13,'Σκεύη'),
	(14,'Θρησκευτικά Είδη'),
	(15,'Τάφοι');
GO




