USE 教务系统 
GO
SELECT * FROM 课程
WHERE 课程编号 LIKE '%2%'
  AND 名称 LIKE '%程序%'
  OR  学分>=4



















