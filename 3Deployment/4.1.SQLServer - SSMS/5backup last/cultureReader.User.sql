USE [CultureGR]
GO
/****** Object:  User [cultureReader]    Script Date: 11/1/2025 02:55:07 ******/
CREATE USER [cultureReader] FOR LOGIN [cultureReader] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_datareader] ADD MEMBER [cultureReader]
GO
ALTER ROLE [db_denydatareader] ADD MEMBER [cultureReader]
GO
