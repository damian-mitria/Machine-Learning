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

CREATE TABLE [dbo].[Images](
	[IdImages] [int] IDENTITY(1,1) PRIMARY KEY CLUSTERED NOT NULL,
	[Nombre] [nvarchar](100) NOT NULL,
	[Path] [nvarchar](max) NULL
)
GO

INSERT [dbo].[Categoria] ([IdCategoria], [Nombre], [Descripcion]) VALUES (N'Lapiceras', N'Utensilio para escribir que consiste en un tubo hueco, de plástico o de metal, con un depósito cilíndrico de una tinta viscosa en su interior y una bolita metálica en la punta que gira libremente y hace salir la tinta de forma uniforme.')
INSERT [dbo].[Categoria] ([IdCategoria], [Nombre], [Descripcion]) VALUES (N'Silla', N'Asiento individual con patas y respaldo.')
INSERT [dbo].[Categoria] ([IdCategoria], [Nombre], [Descripcion]) VALUES (N'Liquid Paper', N'Corrector líquido opaco que se utiliza para ocultar los errores de escritura en un papel, evitando escribir de nuevo una hoja entera.')