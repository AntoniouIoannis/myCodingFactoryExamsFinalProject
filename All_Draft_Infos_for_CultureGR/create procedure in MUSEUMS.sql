CREATE PROCEDURE GetMuseumsByLocation
    @Location NVARCHAR(100)
AS
BEGIN
    SELECT 
        mus_id,
        mus_name,
        mus_desc,
        mus_address,
        mus_phone,
        mus_coordinations
    FROM MUSEUMS
    WHERE mus_address LIKE '%' + @Location + '%'
       OR mus_coordinations LIKE '%' + @Location + '%';
END;
GO

EXEC GetMuseumsByLocation @Location = 'Αθήνα';
GO

EXEC GetMuseumsByLocation @Location = '37.';
GO


