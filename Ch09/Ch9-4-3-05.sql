USE 教务系统 
GO
SELECT * FROM 教授 
WHERE 教授编号 IN
(SELECT 教授编号 FROM 班级 
 WHERE 学号=(SELECT 学号 FROM 学生
             WHERE 姓名='江小鱼'))



















































