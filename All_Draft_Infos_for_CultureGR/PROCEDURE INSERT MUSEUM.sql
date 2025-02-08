USE [CultureGR]
GO
/****** Object:  Table [dbo].[MUSEUMS]    Script Date: 20/1/2025 23:33:24 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE new_museum
@mus_id int, @mus_name nvarchar(150), @mus_desc text, @mus_address text, @mus_phone nchar(60), @category_id int, @period_id int,  @exhibit_id int, @mus_avg_rate tinyint, @mus_open nvarchar(150), @mus_coordinate geography
AS
DECLARE @count int
SELECT @count=0
SELECT @count=COUNT(*)
	FROM MUSEUMS
	WHERE mus_name=@mus_name AND mus_address=@mus_address
	IF (@count=0)
	BEGIN
	INSERT INTO MUSEUMS VALUES (@mus_id, @mus_name, @mus_desc, @mus_address, @mus_phone, @category_id, @period_id,  @exhibit_id, @mus_avg_rate, @mus_open, @mus_coordinate)
		PRINT 'A NEW MUSEUM ADDED IN THE LIST.'
	END
	ELSE
		PRINT 'THIS MUSEUM IS ALREADY EXIST IN THE LIST.'
GO


EXECUTE new_museum
@mus_id=38, @mus_name='Αρχαιολογικό Μουσείο Χαλκίδας «Αρέθουσα»', @mus_desc='Το νέο Αρχαιολογικό Μουσείο Χαλκίδας «Αρέθουσα» εγκαινιάστηκε το Μάιο του 2021 και στεγάζεται στο βιομηχανικό κτήριο του ποτοποιείου «Αρέθουσα» -μνημείο των αρχών του 20ου αι. Μία θεματική έκθεση ζωντανεύει, εκτός από την ιστορία του κτηρίου, εξέχουσες πτυχές της ιστορίας της Εύβοιας, από το ηρώο στο Λευκαντί, τον αποικισμό και την εξάπλωση του ευβοϊκού αλφάβητου, το ιερό της Αρτέμιδας στην Αυλίδα και τον μύθο της Ιφιγένειας, έως τη βυζαντινή και οθωμανική Χαλκίδα.', @mus_address='Αρεθούσης 146 & Ι. Κιαπέκου, Χαλκίδα 34133', @mus_phone='(+30) 2221022402', @category_id=1, @period_id=7,  @exhibit_id=1, @mus_avg_rate=5, @mus_open='από 1/11 έως 31/3 Κκαθημερινά 08:30 – 15:30, Τρίτη κλειστό', @mus_coordinate='38.45776693934675 23.610656058221426'

geography::STPointFromText('POINT(38.45776693934675 23.610656058221426)', 4326)










