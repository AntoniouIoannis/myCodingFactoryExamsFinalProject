select mus_name from MUSEUMS where mus_avg_rate between 1 and 4;

select mus_name, mus_avg_rate from MUSEUMS where mus_avg_rate between 2 and 4
order by mus_avg_rate asc;

select mus_name, cat_name from MUSEUMS, CATEGORIESMUSEUMS where categoty_id=1
order by mus_name;

checkpoint 
dbcc dropcleanbuffers

select distinct mus_name, cat_name
	from MUSEUMS, CATEGORIESMUSEUMS 
where cat_name = 'Εθνολογικά μουσεία';

select * from MUSEUMS
where  category_id=12;

select * from MUSEUMS
where  mus_name like 'Α%';

select * from MUSEUMS
where  mus_name like '%Συλλογή%';

select distinct mus_name , mus_address, cat_name
	from MUSEUMS, CATEGORIESMUSEUMS
where  mus_address like '%Καβάλα%';

SELECT DISTINCT mus_name, mus_address, cat_name
FROM MUSEUMS
INNER JOIN CATEGORIESMUSEUMS
    ON MUSEUMS.category_id = CATEGORIESMUSEUMS.cat_id
WHERE mus_address LIKE '%Αθήν%';



checkpoint 
dbcc dropcleanbuffers

SELECT CATEGORIESMUSEUMS.cat_name, AVG(MUSEUMS.mus_avg_rate) AS avg_rating
FROM CATEGORIESMUSEUMS
INNER JOIN MUSEUMS
    ON CATEGORIESMUSEUMS.cat_id = MUSEUMS.category_id
INNER JOIN TIME_PERIODS
    ON TIME_PERIODS.p_id = MUSEUMS.period_id
WHERE TIME_PERIODS.p_id = 12
GROUP BY CATEGORIESMUSEUMS.cat_name;
