USE 教务系统 
GO
WITH 教授_员工
AS (
SELECT 教授.*, 员工.姓名
FROM 教授 INNER JOIN 员工
ON 教授.身份证号码 = 员工.身份证号码
)
SELECT 学生.学号, 学生.姓名, 课程.*, 教授_员工.*
FROM 教授_员工 INNER JOIN
(课程 INNER JOIN 
(学生 INNER JOIN 班级 ON 学生.学号 = 班级.学号) 
ON 班级.课程编号 = 课程.课程编号) 
ON 班级.教授编号 = 教授_员工.教授编号



















 































































