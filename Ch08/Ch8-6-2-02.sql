USE 教务系统 
GO
SELECT 课程编号, COUNT(*) AS 学生数
FROM 班级 
WHERE 教授编号 = 'I003'
GROUP BY 课程编号
HAVING COUNT(*) >= 2



































