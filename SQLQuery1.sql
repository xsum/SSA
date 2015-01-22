SELECT 回数,
(SELECT 成绩 FROM 成绩 AS t1 WHERE 课程编号='101' AND t1.学号=t2.学号 AND t1.课程编号=t2.课程编号 AND t1.回数=t2.回数) AS 语文,
(SELECT 成绩 FROM 成绩 AS t1 WHERE 课程编号='102' AND t1.学号=t2.学号 AND t1.课程编号=t2.课程编号 AND t1.回数=t2.回数) AS 数学,
(SELECT 成绩 FROM 成绩 AS t1 WHERE 课程编号='103' AND t1.学号=t2.学号 AND t1.课程编号=t2.课程编号 AND t1.回数=t2.回数) AS 英语
FROM 成绩 AS t2