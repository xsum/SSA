USE 教务系统 
GO
SELECT DISTINCT 课程.* FROM 课程, 班级
WHERE (班级.教室='221-S' OR 班级.教室='100-M') 
   AND 课程.课程编号=班级.课程编号

















































