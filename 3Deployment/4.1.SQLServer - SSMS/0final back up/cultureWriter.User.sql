USE [CultureGR]
GO
/****** Object:  User [cultureWriter]    Script Date: 21/1/2025 00:26:32 ******/
CREATE USER [cultureWriter] FOR LOGIN [cultureWriter] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [cultureWriter]
GO
ALTER ROLE [db_datareader] ADD MEMBER [cultureWriter]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [cultureWriter]
GO
ALTER ROLE [db_denydatareader] ADD MEMBER [cultureWriter]
GO
ALTER ROLE [db_denydatawriter] ADD MEMBER [cultureWriter]
GO
