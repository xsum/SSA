USE 教务系统 
GO
SELECT 学号, 课程编号 FROM 班级 
GROUP BY 课程编号, 学号
HAVING 学号 = 'S002'

































