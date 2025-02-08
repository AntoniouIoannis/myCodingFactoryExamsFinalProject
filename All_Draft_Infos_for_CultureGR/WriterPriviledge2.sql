-- Create the WriterCategory table
CREATE TABLE WriterCategory (
    UserID INT NOT NULL,
    cat_id INT NOT NULL,
    FOREIGN KEY (UserID) REFERENCES Users(UserID),
    FOREIGN KEY (cat_id) REFERENCES CATEGORIESMUSEUMS(cat_id),
    PRIMARY KEY (UserID, cat_id)
);

-- Declare the variable @UserID once
DECLARE @UserID INT;

-- Insert data for 'WriterArchaeological'
SELECT @UserID = UserID FROM Users WHERE Username = 'WriterArchaeological';
INSERT INTO WriterCategory (UserID, cat_id)
VALUES
    (@UserID, 1),
    (@UserID, 2),
    (@UserID, 3),
    (@UserID, 4);
    

-- Insert data for 'WriterThematic'
SELECT @UserID = UserID FROM Users WHERE Username = 'WriterThematic';
INSERT INTO WriterCategory (UserID, cat_id)
VALUES
	(@UserID, 6),
    (@UserID, 9),
    (@UserID, 11),
    (@UserID, 12);

-- Insert data for 'WriterArts'
SELECT @UserID = UserID FROM Users WHERE Username = 'WriterArts';
INSERT INTO WriterCategory (UserID, cat_id)
VALUES
    (@UserID, 5),
	(@UserID, 10),
    (@UserID, 7),
    (@UserID, 8);
    
