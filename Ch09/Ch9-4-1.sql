USE 教务系统 
GO
SELECT 高薪员工.姓名, 高薪员工.电话, 高薪员工.薪水
FROM (SELECT 身份证号码, 姓名, 电话, 薪水
      FROM 员工
      WHERE 薪水>9000) AS 高薪员工 

























































