CREATE TABLE CALENDAR(
	cal_id int PRIMARY KEY,
	cmonth DATE,
	cyear DATE);
GO

SET LANGUAGE Greek;
GO

SELECT * FROM CALENDAR
GO

DELETE FROM CALENDAR
GO

INSERT INTO CALENDAR (cal_id, cmonth, cyear)
VALUES
(1, '2020-01-01', '2020-01-01'),
(2, '2020-02-01', '2020-02-01'),
(3, '2020-03-01', '2020-03-01'),
(4, '2020-04-01', '2020-04-01'),
(5, '2020-05-01', '2020-05-01'),
(6, '2020-06-01', '2020-06-01'),
(7, '2020-07-01', '2020-07-01'),
(8, '2020-08-01', '2020-08-01'),
(9, '2020-09-01', '2020-09-01'),
(10, '2020-10-01', '2020-10-01'),
(11, '2020-11-01', '2020-11-01'),
(12, '2020-12-01', '2020-12-01'),
(13, '2021-01-01', '2021-01-01'),
(14, '2021-02-01', '2021-02-01'),
(15, '2021-03-01', '2021-03-01'),
(16, '2021-04-01', '2021-04-01'),
(17, '2021-05-01', '2021-05-01'),
(18, '2021-06-01', '2021-06-01'),
(19, '2021-07-01', '2021-07-01'),
(20, '2021-08-01', '2021-08-01'),
(21, '2021-09-01', '2021-09-01'),
(22, '2021-10-01', '2021-10-01'),
(23, '2021-11-01', '2021-11-01'),
(24, '2021-12-01', '2021-12-01'),
(25, '2022-01-01', '2022-01-01'),
(26, '2022-02-01', '2022-02-01'),
(27, '2022-03-01', '2022-03-01'),
(28, '2022-04-01', '2022-04-01'),
(29, '2022-05-01', '2022-05-01'),
(30, '2022-06-01', '2022-06-01'),
(31, '2022-07-01', '2022-07-01'),
(32, '2022-08-01', '2022-08-01'),
(33, '2022-09-01', '2022-09-01'),
(34, '2022-10-01', '2022-10-01'),
(35, '2022-11-01', '2022-11-01'),
(36, '2022-12-01', '2022-12-01'),
(37, '2023-01-01', '2023-01-01'),
(38, '2023-02-01', '2023-02-01'),
(39, '2023-03-01', '2023-03-01'),
(40, '2023-04-01', '2023-04-01'),
(41, '2023-05-01', '2023-05-01'),
(42, '2023-06-01', '2023-06-01'),
(43, '2023-07-01', '2023-07-01'),
(44, '2023-08-01', '2023-08-01'),
(45, '2023-09-01', '2023-09-01'),
(46, '2023-10-01', '2023-10-01'),
(47, '2023-11-01', '2023-11-01'),
(48, '2023-12-01', '2023-12-01');
GO

SELECT 
    cal_id,
    FORMAT(cmonth, 'MMM', 'el-GR') AS GreekMonth,
    FORMAT(cyear, 'yyyy') AS Year
FROM CALENDAR;
GO
