USE [CultureGR]
GO
/****** Object:  User [CultureGRAdmin]    Script Date: 11/1/2025 02:55:07 ******/
CREATE USER [CultureGRAdmin] FOR LOGIN [CultureGRAdmin] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [CultureGRAdmin]
GO
ALTER ROLE [db_securityadmin] ADD MEMBER [CultureGRAdmin]
GO
