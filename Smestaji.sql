USE [Smeštaji]
GO
/****** Object:  Table [dbo].[Administrator]    Script Date: 07.02.2024. 15:02:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Administrator](
	[AdministratorID] [int] NOT NULL,
	[Ime] [varchar](30) NOT NULL,
	[Prezime] [varchar](30) NOT NULL,
	[Username] [varchar](30) NOT NULL,
	[Password] [varchar](30) NOT NULL,
 CONSTRAINT [PK__Administ__ACDEFE339FFFE6BA] PRIMARY KEY CLUSTERED 
(
	[AdministratorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Klijent]    Script Date: 07.02.2024. 15:02:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Klijent](
	[KlijentID] [int] NOT NULL,
	[ImeKlijenta] [varchar](30) NOT NULL,
	[PrezimeKlijenta] [varchar](30) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[Telefon] [varchar](50) NOT NULL,
 CONSTRAINT [PK__Klijent__5F05D84E8FF4849E] PRIMARY KEY CLUSTERED 
(
	[KlijentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rezervacija]    Script Date: 07.02.2024. 15:02:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rezervacija](
	[RezervacijaID] [int] NOT NULL,
	[DatumPocetka] [date] NOT NULL,
	[DatumKraja] [date] NOT NULL,
	[BrojDana] [int] NOT NULL,
	[UkupnaCena] [decimal](10, 2) NOT NULL,
	[TipRezervacijeID] [int] NOT NULL,
	[KlijentID] [int] NOT NULL,
	[AdministratorID] [int] NOT NULL,
 CONSTRAINT [PK__Rezervac__CABA44FD48BF73E8] PRIMARY KEY CLUSTERED 
(
	[RezervacijaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StavkaRezervacije]    Script Date: 07.02.2024. 15:02:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StavkaRezervacije](
	[RezervacijaID] [int] NOT NULL,
	[RbStavke] [int] NOT NULL,
	[UslugaID] [int] NOT NULL,
 CONSTRAINT [PK__StavkaRe__2F6CC350A92A7317] PRIMARY KEY CLUSTERED 
(
	[RezervacijaID] ASC,
	[RbStavke] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipRezervacije]    Script Date: 07.02.2024. 15:02:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipRezervacije](
	[TipRezervacijeID] [int] NOT NULL,
	[NazivTipaRezervacije] [varchar](50) NOT NULL,
	[CenaPoDanu] [decimal](10, 2) NULL,
 CONSTRAINT [PK__TipRezer__99EAB13D6FED3562] PRIMARY KEY CLUSTERED 
(
	[TipRezervacijeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usluga]    Script Date: 07.02.2024. 15:02:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usluga](
	[UslugaID] [int] NOT NULL,
	[NazivUsluge] [varchar](50) NOT NULL,
	[Opis] [varchar](200) NOT NULL,
	[CenaUslugePoDanu] [decimal](10, 2) NOT NULL,
 CONSTRAINT [PK__Usluga__0BE5E7CF62D432C4] PRIMARY KEY CLUSTERED 
(
	[UslugaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Administrator] ([AdministratorID], [Ime], [Prezime], [Username], [Password]) VALUES (1, N'Marko', N'Petrovic', N'marko', N'marko123')
INSERT [dbo].[Administrator] ([AdministratorID], [Ime], [Prezime], [Username], [Password]) VALUES (2, N'Andjela', N'Cosic', N'andjela', N'andjela123')
GO
INSERT [dbo].[Klijent] ([KlijentID], [ImeKlijenta], [PrezimeKlijenta], [Email], [Telefon]) VALUES (1, N'Marko', N'Savicevic', N'marko@gmail.com', N'062123123')
INSERT [dbo].[Klijent] ([KlijentID], [ImeKlijenta], [PrezimeKlijenta], [Email], [Telefon]) VALUES (2, N'Milica', N'Simic', N'mica@gmail.com', N'060123123')
INSERT [dbo].[Klijent] ([KlijentID], [ImeKlijenta], [PrezimeKlijenta], [Email], [Telefon]) VALUES (3, N'Lazar', N'Savic', N'laki@gmail.com', N'06556267734')
INSERT [dbo].[Klijent] ([KlijentID], [ImeKlijenta], [PrezimeKlijenta], [Email], [Telefon]) VALUES (4, N'Uros', N'Marenovic', N'marenda@gmail.com', N'064324324')
GO
INSERT [dbo].[Rezervacija] ([RezervacijaID], [DatumPocetka], [DatumKraja], [BrojDana], [UkupnaCena], [TipRezervacijeID], [KlijentID], [AdministratorID]) VALUES (4, CAST(N'2023-08-31' AS Date), CAST(N'2023-09-05' AS Date), 5, CAST(450.00 AS Decimal(10, 2)), 2, 4, 1)
INSERT [dbo].[Rezervacija] ([RezervacijaID], [DatumPocetka], [DatumKraja], [BrojDana], [UkupnaCena], [TipRezervacijeID], [KlijentID], [AdministratorID]) VALUES (5, CAST(N'2023-08-31' AS Date), CAST(N'2023-09-06' AS Date), 6, CAST(450.00 AS Decimal(10, 2)), 2, 4, 1)
GO
INSERT [dbo].[StavkaRezervacije] ([RezervacijaID], [RbStavke], [UslugaID]) VALUES (4, 1, 1)
INSERT [dbo].[StavkaRezervacije] ([RezervacijaID], [RbStavke], [UslugaID]) VALUES (4, 2, 3)
INSERT [dbo].[StavkaRezervacije] ([RezervacijaID], [RbStavke], [UslugaID]) VALUES (5, 1, 1)
INSERT [dbo].[StavkaRezervacije] ([RezervacijaID], [RbStavke], [UslugaID]) VALUES (5, 2, 3)
GO
INSERT [dbo].[TipRezervacije] ([TipRezervacijeID], [NazivTipaRezervacije], [CenaPoDanu]) VALUES (1, N'Polu-pansion', CAST(40.00 AS Decimal(10, 2)))
INSERT [dbo].[TipRezervacije] ([TipRezervacijeID], [NazivTipaRezervacije], [CenaPoDanu]) VALUES (2, N'Pansion', CAST(60.00 AS Decimal(10, 2)))
INSERT [dbo].[TipRezervacije] ([TipRezervacijeID], [NazivTipaRezervacije], [CenaPoDanu]) VALUES (3, N'All inclusive', CAST(100.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[Usluga] ([UslugaID], [NazivUsluge], [Opis], [CenaUslugePoDanu]) VALUES (1, N'Wi-Fi', N'Internet konekcija', CAST(0.00 AS Decimal(10, 2)))
INSERT [dbo].[Usluga] ([UslugaID], [NazivUsluge], [Opis], [CenaUslugePoDanu]) VALUES (2, N'Mini bar', N'Pristup mini baru', CAST(20.00 AS Decimal(10, 2)))
INSERT [dbo].[Usluga] ([UslugaID], [NazivUsluge], [Opis], [CenaUslugePoDanu]) VALUES (3, N'SPA', N'Sauna, parno kupatilo, masaze.', CAST(30.00 AS Decimal(10, 2)))
INSERT [dbo].[Usluga] ([UslugaID], [NazivUsluge], [Opis], [CenaUslugePoDanu]) VALUES (4, N'Teretana', N'20 masina i 100m2 na vasem raspolaganju.', CAST(10.00 AS Decimal(10, 2)))
INSERT [dbo].[Usluga] ([UslugaID], [NazivUsluge], [Opis], [CenaUslugePoDanu]) VALUES (5, N'Bazen', N'Spoljasni i unutrasnji.', CAST(10.00 AS Decimal(10, 2)))
GO
ALTER TABLE [dbo].[Rezervacija]  WITH CHECK ADD  CONSTRAINT [fk_admin_id] FOREIGN KEY([AdministratorID])
REFERENCES [dbo].[Administrator] ([AdministratorID])
GO
ALTER TABLE [dbo].[Rezervacija] CHECK CONSTRAINT [fk_admin_id]
GO
ALTER TABLE [dbo].[Rezervacija]  WITH CHECK ADD  CONSTRAINT [fk_klijent_id] FOREIGN KEY([KlijentID])
REFERENCES [dbo].[Klijent] ([KlijentID])
GO
ALTER TABLE [dbo].[Rezervacija] CHECK CONSTRAINT [fk_klijent_id]
GO
ALTER TABLE [dbo].[Rezervacija]  WITH CHECK ADD  CONSTRAINT [fk_tipRezervacije_id] FOREIGN KEY([TipRezervacijeID])
REFERENCES [dbo].[TipRezervacije] ([TipRezervacijeID])
GO
ALTER TABLE [dbo].[Rezervacija] CHECK CONSTRAINT [fk_tipRezervacije_id]
GO
ALTER TABLE [dbo].[StavkaRezervacije]  WITH CHECK ADD  CONSTRAINT [fk_rezervacija_id] FOREIGN KEY([RezervacijaID])
REFERENCES [dbo].[Rezervacija] ([RezervacijaID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[StavkaRezervacije] CHECK CONSTRAINT [fk_rezervacija_id]
GO
ALTER TABLE [dbo].[StavkaRezervacije]  WITH CHECK ADD  CONSTRAINT [fk_usluga_id] FOREIGN KEY([UslugaID])
REFERENCES [dbo].[Usluga] ([UslugaID])
GO
ALTER TABLE [dbo].[StavkaRezervacije] CHECK CONSTRAINT [fk_usluga_id]
GO
