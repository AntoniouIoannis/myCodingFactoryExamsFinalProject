USE [CultureGR]
GO
/****** Object:  View [dbo].[View_MuseumsWithCoordinates]    Script Date: 11/1/2025 02:55:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_MuseumsWithCoordinates] AS
SELECT 
    mus_id,
    mus_name,
    mus_address,
    mus_coordinations
FROM MUSEUMS;
GO
