USE 教务系统 
GO
SELECT 学生.学号, 学生.姓名, 课程.*, 班级.教授编号 
FROM 课程 RIGHT JOIN 
(学生 INNER JOIN 班级 ON 学生.学号 = 班级.学号) 
ON 班级.课程编号 = 课程.课程编号


























































