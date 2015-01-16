USE 教务系统 
GO
WITH 主管_递回
AS (
SELECT 员工号码, 姓名, 1 AS 阶层
FROM 主管 WHERE 主管号码 IS NULL
UNION ALL
SELECT 主管.员工号码, 主管.姓名, 阶层 + 1
FROM 主管 JOIN 主管_递回
ON 主管.主管号码 = 主管_递回.员工号码
)
SELECT * FROM 主管_递回
ORDER BY 阶层, 员工号码
 





 































































