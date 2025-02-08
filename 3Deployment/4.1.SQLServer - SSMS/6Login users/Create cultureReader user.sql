USE [master]
GO

/* For security reasons the login is created disabled and with a random password. */
/****** Object:  Login [cultureReader]    Script Date: 10/1/2025 23:23:13 ******/
CREATE LOGIN [cultureReader] WITH PASSWORD=N'YgxpWxJExUqxigYrbg+CZj61hdtoGVPViPzsIAP3CFY=', DEFAULT_DATABASE=[CultureGR], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
GO

ALTER LOGIN [cultureReader] DISABLE
GO

ALTER SERVER ROLE [##MS_ServerStateReader##] ADD MEMBER [cultureReader]
GO


