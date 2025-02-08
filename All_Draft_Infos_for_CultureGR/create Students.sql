USE Students6DB_RazorPages;
GO

CREATE TABLE Students (
	std_id INT NOT NULL PRIMARY KEY IDENTITY(1, 1),
	std_Firstname NVARCHAR(50) NOT NULL ,
	std_Lastname NVARCHAR(50) NOT NULL ,
	std_Address NVARCHAR(80) NOT NULL 
) 
GO

INSERT INTO Students (std_Firstname, std_Lastname, std_Address)
VALUES
	('Ιωάννης', 'Αντωνίου', 'Πλαπούτα 1, Ξηρόβρυση'),
	('Αφέντρα', 'Κοροβέση', 'Πλαπούτα 1, Ξηρόβρυση'),
	('Ιωάννα', 'Αντωνίου', 'Αντιγόνου 2, Μπαταριάς'),
	('Δημήτρης - Ραφαήλ', 'Αντωνίου', 'Καλυψούς 73, Καλλιθέα'),
	('Θεόδωρος', 'Μίχος', 'Αγία Μαρίνα, Εργατικές Κατοικίες'
	);