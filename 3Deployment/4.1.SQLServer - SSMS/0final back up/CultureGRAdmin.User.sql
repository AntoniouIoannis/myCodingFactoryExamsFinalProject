USE [CultureGR]
GO
/****** Object:  User [CultureGRAdmin]    Script Date: 21/1/2025 00:26:32 ******/
CREATE USER [CultureGRAdmin] FOR LOGIN [CultureGRAdmin] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [CultureGRAdmin]
GO
ALTER ROLE [db_securityadmin] ADD MEMBER [CultureGRAdmin]
GO
