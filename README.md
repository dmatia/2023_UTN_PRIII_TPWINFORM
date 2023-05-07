# TP Winform - Grupo 25
## **Materia**: Programaci�n III
### **Universidad Tecnol�gica Nacional - Facultad Regional Pacheco**
### **Carrera:** Tecnicatura Universitaria en Programaci�n
### **Profesor:** Maximiliano Sar Fernandez
### **Profesora adjunta:** Regina Laurentino Goncalves
### **Integrantes**
- [x]  1.  **Diego Mat�as Villalba** -  [Github](https://github.com/dmatia)
- [x]  2.  **Alejandro Mart�n Gomez Nieto** -  [Github](https://github.com/alefigure8)
- [x]  3.  **Federico Manuel Merayo** -  [Github](https://github.com/FmmerayoUTN)

#### **A�o:** 2023
---
## Requerimientos
- [x] 1.  **Visual Studio 2019** -  [Descargar](https://visualstudio.microsoft.com/es/vs/)
- [x] 2.  **SQL Server 2019** -  [Descargar](https://www.microsoft.com/es-es/sql-server/sql-server-downloads)
- [x] 3.  **SQL Server Management Studio** -  [Descargar](https://docs.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver15)
- [x] 4.  **.NET Framework 4.7.2** -  [Descargar](https://dotnet.microsoft.com/download/dotnet-framework/net472)
---
## Descripci�n
Se necesita una aplicaci�n para la gesti�n de art�culos de un cat�logo de un comercio. La aplicaci�n debe ser gen�rica, es decir, aplicar para cualquier tipo de comercio; y la informaci�n que en ella se cargue ser� consumida luego desde distintos servicios para ser mostradas ya sea en webs, e-commerces, apps mobile, revistas, etc. Esto no es parte del desarrollo, pero s� del contexto en el cual se utilizar� la aplicaci�n a desarrollar.

Deber� ser un programa de escritorio que contemple la administraci�n de art�culos. Las funcionalidades que deber� tener la aplicaci�n ser�n:

- Listado de art�culos.
- B�squeda de art�culos por distintos criterios.
- Agregar art�culos.
- Modificar art�culos.
- Eliminar art�culos.
- Ver detalle de un art�culo.
Toda �sta informaci�n deber� ser persistida en una base de datos ya existente (la cual se adjunta).

Los datos m�nimos con los que deber� contar el art�culo son los siguientes:

- C�digo de art�culo.
- Nombre.
- Descripci�n.
- Marca (seleccionable de una lista desplegable).
- Categor�a (seleccionable de una lista desplegable.
- Imagen.
- Precio.

El programa debe permitir administrar las Marcas y Categor�as disponibles en el programa. Adem�s, un producto podr�a llegar a tener una o m�s im�genes, sin un l�mite establecido. Esto debe estar contemplado en la gesti�n del art�culo.
## Soluci�n
```csharp
pr3grupo25.sln
```

## String de conexi�n
```csharp
"server={COLOCAR EL NOMBRE DE SU SERVIDOR}; database=CATALOGO_P3_DB; integrated security=true; TrustServerCertificate=True"
```

## Estructura de la base de datos
```sql
USE MASTER
GO

CREATE DATABASE CATALOGO_P3_DB
GO

USE CATALOGO_P3_DB
GO

USE CATALOGO_P3_DB
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[MARCAS](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NULL,
 CONSTRAINT [PK_MARCAS] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

SET ANSI_PADDING OFF
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[CATEGORIAS](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NULL,
 CONSTRAINT [PK_CATEGORIAS] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

SET ANSI_PADDING OFF
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[ARTICULOS](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Codigo] [varchar](50) NULL,
	[Nombre] [varchar](50) NULL,
	[Descripcion] [varchar](150) NULL,
	[IdMarca] [int] NULL,
	[IdCategoria] [int] NULL,
	[Precio] [money] NULL,
 CONSTRAINT [PK_ARTICULOS] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

SET ANSI_PADDING OFF
GO

create table IMAGENES(
	Id int IDENTITY(1,1) not null,
	IdArticulo int not null,
	ImagenUrl varchar(1000) not null
)
GO

INSERT INTO MARCAS VALUES ('Samsung'), ('Apple'), ('Sony'), ('Huawei'), ('Motorola')
INSERT INTO CATEGORIAS VALUES ('Celulares'),('Televisores'), ('Media'), ('Audio')
INSERT INTO ARTICULOS VALUES ('S01', 'Galaxy S10', 'Una canoa cara', 1, 1, 69.999),
('M03', 'Moto G Play 7ma Gen', 'Ya siete de estos?', 1, 5, 15699),
('S99', 'Play 4', 'Ya no se cuantas versiones hay', 3, 3, 35000),
('S56', 'Bravia 55', 'Alta tele', 3, 2, 49500),
('A23', 'Apple TV', 'lindo loro', 2, 3, 7850)

INSERT INTO imagenes VALUES
(1,'https://images.samsung.com/is/image/samsung/co-galaxy-s10-sm-g970-sm-g970fzyjcoo-frontcanaryyellow-thumb-149016542'),
(2, 'https://www.motorola.cl/arquivos/moto-g7-play-img-product.png?v=636862863804700000'),
(2, 'https://i.blogs.es/9da288/moto-g7-/1366_2000.jpg'),
(3, 'https://www.euronics.cz/image/product/800x800/532620.jpg'),
(4, 'https://intercompras.com/product_thumb_keepratio_2.php?img=images/product/SONY_KDL-55W950A.jpg&w=650&h=450'),
(5, 'https://cnnespanol2.files.wordpress.com/2015/12/gadgets-mc3a1s-populares-apple-tv-2015-18.jpg?quality=100&strip=info&w=460&h=260&crop=1')
GO
```	
## Diagrama de la base de datos

![Diagrama de la base de datos](https://i.imgur.com/Qv7luKm.jpg)

## Capturas de pantalla
![Captura 1](https://i.imgur.com/jXTkPQQ.jpg)
![Captura 2](https://i.imgur.com/Xfa8rSd.jpg)
![Captura 3](https://i.imgur.com/W0xXvXO.jpg)