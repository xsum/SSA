USE 教务系统 
GO
SELECT 学生.学号, 学生.姓名, 班级.课程编号, 班级.教授编号
FROM 学生 INNER JOIN 班级 
ON 学生.学号 = 班级.学号









































