USE 教务系统 
GO
SELECT * FROM 课程 
WHERE 课程编号 NOT IN
(SELECT 课程编号 FROM 班级 WHERE 学号='S004')


















































