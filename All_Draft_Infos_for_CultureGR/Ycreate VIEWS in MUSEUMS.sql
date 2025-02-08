CREATE VIEW View_MuseumsWithCoordinates AS
SELECT 
    mus_region,
    mus_name,
    mus_address,
    mus_coordinations
FROM MUSEUMS;
GO

SELECT * FROM View_MuseumsWithCoordinates;
GO

CREATE VIEW View_MuseumDetails AS
SELECT 
    mus_region,
    mus_name,
    mus_desc,
    mus_address,
    mus_phone,
    mus_coordinations
FROM MUSEUMS;
GO

SELECT * FROM View_MuseumDetails;
GO
