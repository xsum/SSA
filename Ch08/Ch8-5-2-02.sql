USE 教务系统 
GO
SELECT COUNT(*) AS 课程总数, 
        AVG(学分) AS 学分平均值 
FROM 课程 WHERE 课程编号 LIKE '%1%'

























