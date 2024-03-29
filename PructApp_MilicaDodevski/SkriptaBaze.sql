USE [Proizvodi]
GO
/****** Object:  Table [dbo].[Proizvod]    Script Date: 12/13/2019 2:04:17 PM ******/
DROP TABLE [dbo].[Proizvod]
GO
/****** Object:  Table [dbo].[Proizvod]    Script Date: 12/13/2019 2:04:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proizvod](
	[ProizvodID] [int] IDENTITY(1,1) NOT NULL,
	[Naziv] [nvarchar](50) NOT NULL,
	[Opis] [nvarchar](max) NOT NULL,
	[Kategorija] [nvarchar](50) NOT NULL,
	[Proizvodjac] [nvarchar](50) NOT NULL,
	[Dobavljac] [nvarchar](50) NOT NULL,
	[Cena] [float] NOT NULL,
 CONSTRAINT [PK_Proizvod] PRIMARY KEY CLUSTERED 
(
	[ProizvodID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Proizvod] ON 

INSERT [dbo].[Proizvod] ([ProizvodID], [Naziv], [Opis], [Kategorija], [Proizvodjac], [Dobavljac], [Cena]) VALUES (12, N'Laptop', N'i5, RAM 8gb, graficka intel', N'IT', N'Lenovo', N'Tehnomanija', 72.999)
INSERT [dbo].[Proizvod] ([ProizvodID], [Naziv], [Opis], [Kategorija], [Proizvodjac], [Dobavljac], [Cena]) VALUES (13, N'Mikser', N'crni, kabl 2m', N'Mali kucni aparati', N'Gorenje', N'Win win', 4.5)
INSERT [dbo].[Proizvod] ([ProizvodID], [Naziv], [Opis], [Kategorija], [Proizvodjac], [Dobavljac], [Cena]) VALUES (14, N'TV', N'32", SMART', N'TV, Audio, Video', N'LG', N'Tehnomanija', 25)
INSERT [dbo].[Proizvod] ([ProizvodID], [Naziv], [Opis], [Kategorija], [Proizvodjac], [Dobavljac], [Cena]) VALUES (15, N'Vaga', N'mala', N'Mali kucni aparati', N'Gorenje', N'Win win', 1.5)
INSERT [dbo].[Proizvod] ([ProizvodID], [Naziv], [Opis], [Kategorija], [Proizvodjac], [Dobavljac], [Cena]) VALUES (16, N'Usisivac', N'za sve', N'Mali kucni aparati', N'Gorenje', N'Win win', 8.999)
SET IDENTITY_INSERT [dbo].[Proizvod] OFF
