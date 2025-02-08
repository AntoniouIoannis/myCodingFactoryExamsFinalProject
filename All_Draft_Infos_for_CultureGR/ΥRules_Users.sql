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
VALUES ('WriterArchaeological', HASHBYTES('SHA2_256', 'cult_arch'), 'arch@gmail.com', 4);  --- Αρχαιολογικα & Βυζαντινα

INSERT INTO Users (Username, PasswordHash, Email, RoleID)
VALUES ('WriterArts', HASHBYTES('SHA2_256', 'cult_art'), 'art@gmail.com', 4);   --- Τεχνης & Πολιτισμού

INSERT INTO Users (Username, PasswordHash, Email, RoleID)
VALUES ('WriterThematic', HASHBYTES('SHA2_256', 'cult_tema'), 'tema@gmail.com', 4);   --- Θεματικα (Πολεμου, Εποστημης, Φυσικης Ιστοριας)

select * from Users
order by UserID;

select * from UserRoles
order by RoleID;