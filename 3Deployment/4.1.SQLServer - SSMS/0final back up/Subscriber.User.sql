USE [CultureGR]
GO
/****** Object:  User [Subscriber]    Script Date: 21/1/2025 00:26:32 ******/
CREATE USER [Subscriber] FOR LOGIN [Subscriber] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_datareader] ADD MEMBER [Subscriber]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [Subscriber]
GO
