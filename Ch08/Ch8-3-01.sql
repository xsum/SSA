USE 教务系统 
GO
CREATE TABLE ##课程 (
   课程编号  char(5) ,
   名称      varchar(30) ,
   学分      int
)
GO
INSERT INTO ##课程 
VALUES ('CS101','计算机概论',4)
GO
INSERT INTO ##课程 
VALUES ('CS121','离散数学',4)
GO




