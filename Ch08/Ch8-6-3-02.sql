USE 教务系统 
GO
SELECT 教授编号, 课程编号, COUNT(学号) AS 总数
FROM 班级 
WHERE 教授编号 IN ('I001', 'I003')
GROUP BY 教授编号, 课程编号 WITH ROLLUP








































