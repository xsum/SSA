USE 教务系统 
GO
SELECT 教授.教授编号, 员工.姓名, 教授.职称, 员工.薪水
FROM 教授 LEFT JOIN 员工 
ON 教授.身份证号码 = 员工.身份证号码
























































