SELECT          城市, SUM(薪水) AS 薪水总额
FROM              员工
GROUP BY   城市
ORDER BY   城市
