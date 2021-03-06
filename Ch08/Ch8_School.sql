USE master 
GO
IF  EXISTS (SELECT name FROM sys.databases WHERE name='教务系统')
DROP DATABASE [教务系统]
GO

CREATE DATABASE [教务系统]
GO

USE [教务系统]
GO

CREATE TABLE [学生] (
	[学号] char(4) NOT NULL,
	[姓名] varchar(12) NOT NULL,
	[性别] char(2) NULL,
	[电话] varchar(15) NULL,
	[生日] datetime NULL,
  PRIMARY KEY ([学号])
) 
GO

CREATE TABLE [课程] (
	[课程编号] char(5) NOT NULL,
	[名称] varchar(30) NULL,
	[学分] int NULL,
  PRIMARY KEY ([课程编号])
) 
GO

CREATE TABLE [教授] (
	[教授编号] char(4) NOT NULL,
	[职称] varchar(10) NULL,
	[科系] varchar(5) NULL,
	[身份证号码] char(18) NOT NULL,
  PRIMARY KEY ([教授编号])
) 
GO

CREATE TABLE [班级] (
	[教授编号] char(4) NOT NULL,
	[学号] char(4) NOT NULL,
	[课程编号] char(5) NOT NULL,	
	[上课时间] datetime NULL,
	[教室] varchar(8) NULL,
  PRIMARY KEY ([教授编号],[课程编号],[学号])
) 
GO

CREATE TABLE [员工] (
	[身份证号码] CHAR(18) NOT NULL,
	[姓名] varchar(12) NULL,
	[城市] char(5) NULL,
	[街道] varchar(30) NULL,
	[电话] char(15) NULL,
	[薪水] money NULL,
	[保险] money NULL,
	[扣税] money NULL,
  PRIMARY KEY ([身份证号码])
) 
GO

ALTER TABLE [班级]
  ADD FOREIGN KEY([学号]) REFERENCES [学生] ([学号])
GO
ALTER TABLE [班级] 
  ADD FOREIGN KEY([课程编号]) REFERENCES [课程] ([课程编号])  
GO
ALTER TABLE [班级] 
  ADD FOREIGN KEY([教授编号]) REFERENCES [教授] ([教授编号])   
GO
ALTER TABLE [教授] 
  ADD FOREIGN KEY([身份证号码]) REFERENCES [员工] ([身份证号码])   
GO

INSERT INTO [学生] 
VALUES ('S001','陈会安','男','020-22222222','1992/09/03')
GO
INSERT INTO [学生] 
VALUES ('S002','江小鱼','女','021-33333333','1993/02/02')
GO
INSERT INTO [学生] 
VALUES ('S003','张无忌','男','022-44444444','1991/05/03')
GO
INSERT INTO [学生] 
VALUES ('S004','陈小安','男','023-55555555','1991/06/13')
GO
INSERT INTO [学生] 
VALUES ('S005','孙燕之','女','024-66666666',NULL)
GO
INSERT INTO [学生] 
VALUES ('S006','周杰轮','男','025-33333333','1990/12/23')
GO
INSERT INTO [学生] 
VALUES ('S007','蔡一零','女','026-66666666','1990/11/23')
GO
INSERT INTO [学生] 
VALUES ('S008','刘得华','男','027-11111122','1990/02/23')
GO

INSERT INTO [课程] 
VALUES ('CS101','计算机概论',4)
GO
INSERT INTO [课程] 
VALUES ('CS121','离散数学',4)
GO
INSERT INTO [课程] 
VALUES ('CS111','线性代数',4)
GO
INSERT INTO [课程] 
VALUES ('CS203','程序语言',3)
GO
INSERT INTO [课程] 
VALUES ('CS213','面向对象程序设计',2)
GO
INSERT INTO [课程] 
VALUES ('CS222','数据库管理系统',3)
GO
INSERT INTO [课程] 
VALUES ('CS205','网页程序设计',3)
GO
INSERT INTO [课程] 
VALUES ('CS349','面向对象分析',3)
GO

INSERT INTO [员工] 
VALUES ('460025195602013765','陈庆新','海口','信义路',
        '021-11111111', 20000, 400, 500)
GO
INSERT INTO [员工] 
VALUES ('460025197803027891','杨金机','三亚','万寿路',
        '023-11111111', 20000, 400, 500)
GO
INSERT INTO [员工] 
VALUES ('460025196704016734','李鸿章','定安','信四路',
        '022-33111111', 10000, 200, 300)
GO
INSERT INTO [员工] 
VALUES ('460025196704126725','陈小安','琼海','四维路',
        NULL, 9000, 200, 100)
GO
INSERT INTO [员工] 
VALUES ('460025198005162385','郭富城','海口','忠孝路',
        '022-55555555', 7000, 150, 80)
GO
INSERT INTO [员工] 
VALUES ('460025197707234536','张无忌','海口','仁爱路',
        '021-55555555', 9000, 200, 100)
GO
INSERT INTO [员工] 
VALUES ('460025196604021637','王心零','定安','博爱路',
        NULL, 9000, 200, 100)
GO
INSERT INTO [员工] 
VALUES ('460025198809237824','刘得华','万宁','文心路',
        '041-55555555', 6000, 100, 50)
GO
INSERT INTO [员工] 
VALUES ('460025197907031324','小龙女','万宁','龙华路',
        '041-55555555', 6000, 100, 50)
GO

INSERT INTO [教授] 
VALUES ('I001','教授',  'CS', '460025195602013765')
GO
INSERT INTO [教授] 
VALUES ('I002','教授',  'CS', '460025198809237824')
GO
INSERT INTO [教授] 
VALUES ('I003','副教授','CIS','460025197907031324')
GO
INSERT INTO [教授] 
VALUES ('I004','讲师','MATH', '460025197707234536')
GO

INSERT INTO [班级] 
VALUES ('I001','S001','CS101','12:00:00','180-M')
GO
INSERT INTO [班级] 
VALUES ('I001','S005','CS101','12:00:00','180-M')
GO
INSERT INTO [班级] 
VALUES ('I001','S006','CS101','12:00:00','180-M')
GO
INSERT INTO [班级] 
VALUES ('I002','S003','CS121','08:00:00','221-S')
GO
INSERT INTO [班级] 
VALUES ('I002','S008','CS121','08:00:00','221-S')
GO

INSERT INTO [班级] 
VALUES ('I004','S003','CS111','15:00:00','321-M')
GO
INSERT INTO [班级] 
VALUES ('I004','S002','CS111','15:00:00','321-M')
GO
INSERT INTO [班级] 
VALUES ('I004','S005','CS111','15:00:00','321-M')
GO
INSERT INTO [班级] 
VALUES ('I001','S003','CS213','09:00:00','622-G')
GO
INSERT INTO [班级] 
VALUES ('I001','S005','CS213','09:00:00','622-G')
GO
INSERT INTO [班级] 
VALUES ('I003','S001','CS213','12:00:00','500-K')
GO
INSERT INTO [班级] 
VALUES ('I003','S006','CS213','12:00:00','500-K')
GO
INSERT INTO [班级] 
VALUES ('I002','S001','CS222','13:00:00','100-M')
GO
INSERT INTO [班级] 
VALUES ('I002','S002','CS222','13:00:00','100-M')
GO
INSERT INTO [班级] 
VALUES ('I002','S004','CS222','13:00:00','100-M')
GO
INSERT INTO [班级] 
VALUES ('I003','S001','CS203','10:00:00','221-S')
GO
INSERT INTO [班级] 
VALUES ('I003','S006','CS203','10:00:00','221-S')
GO
INSERT INTO [班级] 
VALUES ('I003','S008','CS203','10:00:00','221-S')
GO
INSERT INTO [班级] 
VALUES ('I003','S002','CS203','14:00:00','327-S')
GO
INSERT INTO [班级] 
VALUES ('I001','S001','CS349','15:00:00','380-L')
GO
INSERT INTO [班级] 
VALUES ('I001','S003','CS349','15:00:00','380-L')
GO
