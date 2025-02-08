USE [master]
GO

/* For security reasons the login is created disabled and with a random password. */
/****** Object:  Login [CultureGRAdmin]    Script Date: 10/1/2025 23:21:07 ******/
CREATE LOGIN [CultureGRAdmin] WITH PASSWORD=N'co4TC1jfUy9gK2lq7J89iIAj01a9+s0w+6N4Bf8Ejq8=', DEFAULT_DATABASE=[CultureGR], DEFAULT_LANGUAGE=[ελληνικά], CHECK_EXPIRATION=ON, CHECK_POLICY=ON
GO

ALTER LOGIN [CultureGRAdmin] DISABLE
GO


