USE 教务系统 
GO
SELECT 学生.学号, 学生.姓名, 课程.*, 教授.*
FROM 教授 INNER JOIN
(课程 INNER JOIN 
(学生 INNER JOIN 班级 ON 学生.学号 = 班级.学号) 
ON 班级.课程编号 = 课程.课程编号) 
ON 班级.教授编号 = 教授.教授编号









































