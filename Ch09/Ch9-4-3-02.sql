USE 教务系统 
GO
SELECT * FROM 课程 
WHERE EXISTS
(SELECT * FROM 班级 
WHERE (教室='221-S' OR 教室='100-M')
    AND 课程.课程编号=班级.课程编号)
















































