USE 教务系统 
GO
SELECT 学号, 姓名, 
       GETDATE() AS 今天,
       DATEDIFF(year, 生日, GETDATE()) AS 年龄
FROM 学生



