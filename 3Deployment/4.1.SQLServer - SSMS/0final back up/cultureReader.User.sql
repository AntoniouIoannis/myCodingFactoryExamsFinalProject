USE [CultureGR]
GO
/****** Object:  User [cultureReader]    Script Date: 21/1/2025 00:26:32 ******/
CREATE USER [cultureReader] FOR LOGIN [cultureReader] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_datareader] ADD MEMBER [cultureReader]
GO
ALTER ROLE [db_denydatareader] ADD MEMBER [cultureReader]
GO
