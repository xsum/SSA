USE 教务系统 
GO
SELECT DISTINCT 员工.姓名, 员工.城市, 员工.街道
FROM 员工 INNER JOIN 员工 AS 员工1 
ON ( 员工.城市 = 员工1.城市 AND
     员工.身份证号码 <> 员工1.身份证号码 )
ORDER BY 员工.城市























































