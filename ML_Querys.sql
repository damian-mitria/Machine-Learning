CREATE DATABASE ML ON PRIMARY
( NAME = 'ML',
FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\ML.mdf' ,
SIZE = 10000KB ,
MAXSIZE = 20480KB ,
FILEGROWTH = 1024KB
)
 LOG ON
( NAME = 'ML_log',
FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\ML_log.ldf' ,
SIZE = 6000KB ,
MAXSIZE = 10240KB ,
FILEGROWTH = 10%
)
GO

USE ML
GO



-------- TABLA -----------
CREATE TABLE [dbo].[Categoria](
	[IdCategoria] [int] IDENTITY(1,1) PRIMARY KEY CLUSTERED NOT NULL,
	[Nombre] [nvarchar](20) NOT NULL,
	[Descripcion] [nvarchar](max) NULL
)
GO