USE [CultureGR]
GO
/****** Object:  View [dbo].[View_MuseumDetails]    Script Date: 11/1/2025 02:55:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_MuseumDetails] AS
SELECT 
    mus_id,
    mus_name,
    mus_desc,
    mus_address,
    mus_phone,
    mus_coordinations
FROM MUSEUMS;
GO
