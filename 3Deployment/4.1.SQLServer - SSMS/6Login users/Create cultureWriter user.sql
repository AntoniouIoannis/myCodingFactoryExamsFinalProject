USE [master]
GO

/* For security reasons the login is created disabled and with a random password. */
/****** Object:  Login [cultureWriter]    Script Date: 10/1/2025 23:24:17 ******/
CREATE LOGIN [cultureWriter] WITH PASSWORD=N'eKwtGGBlqRDqq/n2UWnxR5Nm6RdNvyQZbEXisYD1t2w=', DEFAULT_DATABASE=[CultureGR], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
GO

ALTER LOGIN [cultureWriter] DISABLE
GO

ALTER SERVER ROLE [##MS_DefinitionReader##] ADD MEMBER [cultureWriter]
GO

ALTER SERVER ROLE [##MS_LoginManager##] ADD MEMBER [cultureWriter]
GO

