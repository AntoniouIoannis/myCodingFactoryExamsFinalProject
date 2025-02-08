USE [CultureGR]
GO
/****** Object:  StoredProcedure [dbo].[GetMuseumsByLocation]    Script Date: 21/1/2025 00:26:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetMuseumsByLocation]
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
