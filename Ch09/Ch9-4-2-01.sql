USE 教务系统 
GO
SELECT COUNT(*) AS 选课数 FROM 班级 
WHERE 学号 = 
(SELECT 学号 FROM 学生 WHERE 姓名='陈会安')












































