USE 教务系统 
GO
SELECT * FROM 学生 
WHERE EXISTS
(SELECT * FROM 班级 
WHERE 课程编号 = 'CS222' AND 学生.学号 = 班级.学号)















































