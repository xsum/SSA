USE 教务系统 
GO
SELECT 身份证号码, 姓名, 电话, 薪水 FROM 员工 
WHERE 薪水 >= 
(SELECT AVG(薪水) FROM 员工)














































