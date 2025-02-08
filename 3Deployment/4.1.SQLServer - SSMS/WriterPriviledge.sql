CREATE TABLE WriterCategory (
    UserID INT NOT NULL,
    cat_id INT NOT NULL,
    FOREIGN KEY (UserID) REFERENCES Users(UserID),
    FOREIGN KEY (cat_id) REFERENCES CATEGORIESMUSEUMS(cat_id),
    PRIMARY KEY (UserID, cat_id)
);

DECLARE @UserID INT;
SELECT @UserID = UserID FROM Users WHERE Username = 'WriterArchaeological';
SET @WriterID = 8;

INSERT INTO UserCategory (UserID, cat_id)
VALUES
    (@UserID, 1),
    (@UserID, 2),
	(@UserID, 3),
    (@UserID, 4);
    

DECLARE @UserID INT;
SELECT @UserID = UserID FROM Users WHERE Username = 'WriterThematic';
SET @WriterID = 10;

INSERT INTO UserCategory (UserID, cat_id)
VALUES
    (10, 11),
    (10, 12),
	(10, 13);

	DECLARE @UserID INT;
SELECT @UserID = UserID FROM Users WHERE Username = 'WriterArts';
SET @WriterID = 9;

INSERT INTO UserCategory (UserID, cat_id)
VALUES
    (9, 5),
    (9, 6),
	(9, 7),
    (9, 8),
	(9, 9);
