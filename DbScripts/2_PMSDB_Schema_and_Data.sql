USE [ProjektManagementSystemDB]
GO
/****** Object:  Table [dbo].[Aktivitaet]    Script Date: 15.03.2021 16:12:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Aktivitaet](
	[AktivitaetId] [int] IDENTITY(1,1) NOT NULL,
	[PhaseId] [int] NOT NULL,
	[VerantwortlicherMitarbeiterId] [int] NOT NULL,
	[Beschreibung] [varchar](100) NULL,
	[StartdatumEffektiv] [date] NOT NULL,
	[StartdatumGeplant] [date] NULL,
	[EnddatumEffektiv] [date] NOT NULL,
	[EnddatumGeplant] [date] NULL,
	[Budget] [int] NOT NULL,
	[Fortschritt] [int] NOT NULL,
 CONSTRAINT [PK_Aktivitaet] PRIMARY KEY CLUSTERED 
(
	[AktivitaetId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Dokument]    Script Date: 15.03.2021 16:12:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dokument](
	[DokumentId] [int] IDENTITY(1,1) NOT NULL,
	[MeilensteinId] [int] NULL,
	[ProjektId] [int] NULL,
	[AktivitaetId] [int] NULL,
	[PhaseId] [int] NULL,
	[Name] [varchar](50) NOT NULL,
	[Dokumentpfad] [varchar](max) NOT NULL,
 CONSTRAINT [PK_Dokument] PRIMARY KEY CLUSTERED 
(
	[DokumentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ExterneKosten]    Script Date: 15.03.2021 16:12:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ExterneKosten](
	[ExterneKostenId] [int] IDENTITY(1,1) NOT NULL,
	[AktivitaetId] [int] NOT NULL,
	[KostenartId] [int] NOT NULL,
	[EffektiveKosten] [decimal](18, 0) NULL,
	[GeplannteKosten] [decimal](18, 0) NULL,
	[Abweichungsbegruendung] [varchar](200) NULL,
 CONSTRAINT [PK_ExterneKosten] PRIMARY KEY CLUSTERED 
(
	[ExterneKostenId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kostenart]    Script Date: 15.03.2021 16:12:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kostenart](
	[KostenartId] [int] IDENTITY(1,1) NOT NULL,
	[Bezeichnung] [varchar](20) NOT NULL,
 CONSTRAINT [PK_Kostenart] PRIMARY KEY CLUSTERED 
(
	[KostenartId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Meilenstein]    Script Date: 15.03.2021 16:12:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Meilenstein](
	[MeilensteinId] [int] IDENTITY(1,1) NOT NULL,
	[PhasenId] [int] NULL,
	[Bezeichnung] [varchar](20) NOT NULL,
	[Abschlussdatum] [date] NOT NULL,
 CONSTRAINT [PK_Meilenstein$] PRIMARY KEY CLUSTERED 
(
	[MeilensteinId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mitarbeiter]    Script Date: 15.03.2021 16:12:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mitarbeiter](
	[MitarbeiterId] [int] IDENTITY(1,1) NOT NULL,
	[Vorname] [varchar](20) NOT NULL,
	[Nachname] [varchar](20) NOT NULL,
	[Abteilung] [varchar](20) NOT NULL,
	[Arbeitspensum] [int] NOT NULL,
	[Funktionsbeschreibung] [varchar](100) NULL,
 CONSTRAINT [PK_Mitarbeiter] PRIMARY KEY CLUSTERED 
(
	[MitarbeiterId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Phase]    Script Date: 15.03.2021 16:12:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Phase](
	[PhaseId] [int] IDENTITY(1,1) NOT NULL,
	[Bezeichnung] [varchar](20) NOT NULL,
	[Phasenfortschritt] [int] NOT NULL,
	[Phasenstatus] [varchar](20) NOT NULL,
	[StartdatumEffektiv] [date] NULL,
	[StartdatumGeplant] [date] NOT NULL,
	[ReviewdatumEffektiv] [date] NULL,
	[ReviewdatumGeplant] [date] NOT NULL,
	[EnddatumEffektiv] [date] NULL,
	[EnddatumGeplant] [date] NOT NULL,
	[FreigabeDatum] [date] NULL,
 CONSTRAINT [PK_Phase] PRIMARY KEY CLUSTERED 
(
	[PhaseId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Projekt]    Script Date: 15.03.2021 16:12:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Projekt](
	[ProjektId] [int] IDENTITY(1,1) NOT NULL,
	[VorgehensmodelId] [int] NOT NULL,
	[Projekttitel] [varchar](50) NOT NULL,
	[Beschreibung] [varchar](100) NULL,
	[Bewilligungsdatum] [date] NOT NULL,
	[Priorität] [int] NOT NULL,
	[Status] [varchar](20) NOT NULL,
	[StartdatumEffektiv] [date] NULL,
	[StartdatumGeplant] [date] NOT NULL,
	[EnddatumEffektiv] [date] NULL,
	[EnddatumGeplant] [date] NOT NULL,
	[ProjektleiterMitarberiterId] [int] NOT NULL,
	[Projektfortschritt] [int] NOT NULL,
 CONSTRAINT [PK_Projekt] PRIMARY KEY CLUSTERED 
(
	[ProjektId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ressource]    Script Date: 15.03.2021 16:12:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ressource](
	[RessourceId] [int] IDENTITY(1,1) NOT NULL,
	[MitarbeiterRessourceId] [int] NOT NULL,
	[AktivitaetId] [int] NULL,
	[Pensum] [int] NOT NULL,
	[Funktion] [varchar](50) NOT NULL,
	[GeplanteZeit] [decimal](18, 0) NULL,
	[EffektiveZeit] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK_Ressource] PRIMARY KEY CLUSTERED 
(
	[RessourceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vorgehensmodel]    Script Date: 15.03.2021 16:12:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vorgehensmodel](
	[VorgehensmodelId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Beschreibung] [varchar](200) NULL,
 CONSTRAINT [PK_Vorgehensmodel] PRIMARY KEY CLUSTERED 
(
	[VorgehensmodelId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vorgehensmodel_Phase]    Script Date: 15.03.2021 16:12:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vorgehensmodel_Phase](
	[Vorgehensmodel_PhaseId] [int] IDENTITY(1,1) NOT NULL,
	[VorgehensmodelId] [int] NOT NULL,
	[PhaseId] [int] NOT NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Aktivitaet] ON 

INSERT [dbo].[Aktivitaet] ([AktivitaetId], [PhaseId], [VerantwortlicherMitarbeiterId], [Beschreibung], [StartdatumEffektiv], [StartdatumGeplant], [EnddatumEffektiv], [EnddatumGeplant], [Budget], [Fortschritt]) VALUES (8, 1, 7, N'Hallo', CAST(N'2021-03-15' AS Date), CAST(N'2021-03-12' AS Date), CAST(N'2021-03-15' AS Date), CAST(N'2021-03-12' AS Date), 200, 12)
INSERT [dbo].[Aktivitaet] ([AktivitaetId], [PhaseId], [VerantwortlicherMitarbeiterId], [Beschreibung], [StartdatumEffektiv], [StartdatumGeplant], [EnddatumEffektiv], [EnddatumGeplant], [Budget], [Fortschritt]) VALUES (9, 1, 8, N'safd', CAST(N'2021-03-09' AS Date), CAST(N'2021-03-09' AS Date), CAST(N'2021-03-09' AS Date), CAST(N'2021-03-09' AS Date), 120, 12)
INSERT [dbo].[Aktivitaet] ([AktivitaetId], [PhaseId], [VerantwortlicherMitarbeiterId], [Beschreibung], [StartdatumEffektiv], [StartdatumGeplant], [EnddatumEffektiv], [EnddatumGeplant], [Budget], [Fortschritt]) VALUES (10, 5, 7, N'Der Beschreib', CAST(N'2021-03-02' AS Date), CAST(N'2021-03-02' AS Date), CAST(N'2021-03-02' AS Date), CAST(N'2021-03-02' AS Date), 222, 20)
INSERT [dbo].[Aktivitaet] ([AktivitaetId], [PhaseId], [VerantwortlicherMitarbeiterId], [Beschreibung], [StartdatumEffektiv], [StartdatumGeplant], [EnddatumEffektiv], [EnddatumGeplant], [Budget], [Fortschritt]) VALUES (11, 5, 7, N'Patrick sis zeug', CAST(N'2021-03-02' AS Date), CAST(N'2021-02-22' AS Date), CAST(N'2021-03-02' AS Date), CAST(N'2021-02-22' AS Date), 2000, 60)
INSERT [dbo].[Aktivitaet] ([AktivitaetId], [PhaseId], [VerantwortlicherMitarbeiterId], [Beschreibung], [StartdatumEffektiv], [StartdatumGeplant], [EnddatumEffektiv], [EnddatumGeplant], [Budget], [Fortschritt]) VALUES (14, 8, 6, N'Hallo', CAST(N'2021-03-10' AS Date), CAST(N'2021-03-12' AS Date), CAST(N'2021-03-10' AS Date), CAST(N'2021-03-12' AS Date), 120, 50)
INSERT [dbo].[Aktivitaet] ([AktivitaetId], [PhaseId], [VerantwortlicherMitarbeiterId], [Beschreibung], [StartdatumEffektiv], [StartdatumGeplant], [EnddatumEffektiv], [EnddatumGeplant], [Budget], [Fortschritt]) VALUES (15, 8, 9, N'Tschüss', CAST(N'2021-03-03' AS Date), CAST(N'2021-01-01' AS Date), CAST(N'2021-03-03' AS Date), CAST(N'2021-01-01' AS Date), 321, 2)
INSERT [dbo].[Aktivitaet] ([AktivitaetId], [PhaseId], [VerantwortlicherMitarbeiterId], [Beschreibung], [StartdatumEffektiv], [StartdatumGeplant], [EnddatumEffektiv], [EnddatumGeplant], [Budget], [Fortschritt]) VALUES (20, 12, 8, N'noch nciht fertig', CAST(N'2021-03-12' AS Date), CAST(N'2021-03-12' AS Date), CAST(N'2021-03-12' AS Date), CAST(N'2021-03-12' AS Date), 2000, 20)
INSERT [dbo].[Aktivitaet] ([AktivitaetId], [PhaseId], [VerantwortlicherMitarbeiterId], [Beschreibung], [StartdatumEffektiv], [StartdatumGeplant], [EnddatumEffektiv], [EnddatumGeplant], [Budget], [Fortschritt]) VALUES (21, 7, 8, N'sdafsdfsd', CAST(N'2021-03-12' AS Date), CAST(N'2021-03-12' AS Date), CAST(N'2021-03-12' AS Date), CAST(N'2021-03-12' AS Date), 222, 11)
INSERT [dbo].[Aktivitaet] ([AktivitaetId], [PhaseId], [VerantwortlicherMitarbeiterId], [Beschreibung], [StartdatumEffektiv], [StartdatumGeplant], [EnddatumEffektiv], [EnddatumGeplant], [Budget], [Fortschritt]) VALUES (22, 2, 7, N'asfasdfasdf', CAST(N'2021-03-14' AS Date), CAST(N'2021-03-14' AS Date), CAST(N'2021-03-14' AS Date), CAST(N'2021-03-14' AS Date), 222, 50)
SET IDENTITY_INSERT [dbo].[Aktivitaet] OFF
GO
SET IDENTITY_INSERT [dbo].[Dokument] ON 

INSERT [dbo].[Dokument] ([DokumentId], [MeilensteinId], [ProjektId], [AktivitaetId], [PhaseId], [Name], [Dokumentpfad]) VALUES (7, NULL, NULL, NULL, 1, N'nico_nr42069_character_1.pdf', N'C:\PMS\nico_nr42069_character_1.pdf')
INSERT [dbo].[Dokument] ([DokumentId], [MeilensteinId], [ProjektId], [AktivitaetId], [PhaseId], [Name], [Dokumentpfad]) VALUES (8, NULL, NULL, NULL, 1, N'jojo character_2.pdf', N'C:\PMS\jojo character_2.pdf')
INSERT [dbo].[Dokument] ([DokumentId], [MeilensteinId], [ProjektId], [AktivitaetId], [PhaseId], [Name], [Dokumentpfad]) VALUES (9, 7, NULL, NULL, NULL, N'jojo character_2.pdf', N'C:\PMS\jojo character_2.pdf')
SET IDENTITY_INSERT [dbo].[Dokument] OFF
GO
SET IDENTITY_INSERT [dbo].[ExterneKosten] ON 

INSERT [dbo].[ExterneKosten] ([ExterneKostenId], [AktivitaetId], [KostenartId], [EffektiveKosten], [GeplannteKosten], [Abweichungsbegruendung]) VALUES (1, 8, 5, CAST(60 AS Decimal(18, 0)), CAST(60 AS Decimal(18, 0)), N'1234')
SET IDENTITY_INSERT [dbo].[ExterneKosten] OFF
GO
SET IDENTITY_INSERT [dbo].[Kostenart] ON 

INSERT [dbo].[Kostenart] ([KostenartId], [Bezeichnung]) VALUES (5, N'Spesenzahlung')
INSERT [dbo].[Kostenart] ([KostenartId], [Bezeichnung]) VALUES (6, N'Personalkosten')
INSERT [dbo].[Kostenart] ([KostenartId], [Bezeichnung]) VALUES (7, N'Betriebsmittelkosten')
INSERT [dbo].[Kostenart] ([KostenartId], [Bezeichnung]) VALUES (8, N'Werkstoffkosten')
SET IDENTITY_INSERT [dbo].[Kostenart] OFF
GO
SET IDENTITY_INSERT [dbo].[Meilenstein] ON 

INSERT [dbo].[Meilenstein] ([MeilensteinId], [PhasenId], [Bezeichnung], [Abschlussdatum]) VALUES (1, 11, N'Abschluss', CAST(N'2021-03-15' AS Date))
INSERT [dbo].[Meilenstein] ([MeilensteinId], [PhasenId], [Bezeichnung], [Abschlussdatum]) VALUES (2, 11, N'Beginn', CAST(N'2021-03-11' AS Date))
INSERT [dbo].[Meilenstein] ([MeilensteinId], [PhasenId], [Bezeichnung], [Abschlussdatum]) VALUES (4, 12, N'asdf', CAST(N'2021-03-11' AS Date))
INSERT [dbo].[Meilenstein] ([MeilensteinId], [PhasenId], [Bezeichnung], [Abschlussdatum]) VALUES (5, 12, N'cisiis meilenstein', CAST(N'2021-03-14' AS Date))
INSERT [dbo].[Meilenstein] ([MeilensteinId], [PhasenId], [Bezeichnung], [Abschlussdatum]) VALUES (7, 1, N'ashfbasdf', CAST(N'2021-03-15' AS Date))
SET IDENTITY_INSERT [dbo].[Meilenstein] OFF
GO
SET IDENTITY_INSERT [dbo].[Mitarbeiter] ON 

INSERT [dbo].[Mitarbeiter] ([MitarbeiterId], [Vorname], [Nachname], [Abteilung], [Arbeitspensum], [Funktionsbeschreibung]) VALUES (6, N'Janosh', N'Suter', N'INformatik', 100, N'Ist der It Chef')
INSERT [dbo].[Mitarbeiter] ([MitarbeiterId], [Vorname], [Nachname], [Abteilung], [Arbeitspensum], [Funktionsbeschreibung]) VALUES (7, N'Patrick', N'Insilber', N'Montage', 80, N'Ist für Montage zuständig')
INSERT [dbo].[Mitarbeiter] ([MitarbeiterId], [Vorname], [Nachname], [Abteilung], [Arbeitspensum], [Funktionsbeschreibung]) VALUES (8, N'Cosi', N'Assis', N'Informatik', 60, N'Ist der Lehrling ')
INSERT [dbo].[Mitarbeiter] ([MitarbeiterId], [Vorname], [Nachname], [Abteilung], [Arbeitspensum], [Funktionsbeschreibung]) VALUES (9, N'MIchu', N'Friede', N'Schreiner', 100, N'ist der schreiner im haus')
INSERT [dbo].[Mitarbeiter] ([MitarbeiterId], [Vorname], [Nachname], [Abteilung], [Arbeitspensum], [Funktionsbeschreibung]) VALUES (10, N'Jani', N'Boy', N'Montage', 40, N'der Junge für alles')
SET IDENTITY_INSERT [dbo].[Mitarbeiter] OFF
GO
SET IDENTITY_INSERT [dbo].[Phase] ON 

INSERT [dbo].[Phase] ([PhaseId], [Bezeichnung], [Phasenfortschritt], [Phasenstatus], [StartdatumEffektiv], [StartdatumGeplant], [ReviewdatumEffektiv], [ReviewdatumGeplant], [EnddatumEffektiv], [EnddatumGeplant], [FreigabeDatum]) VALUES (1, N'Konzeptphase', 342, N'offen', CAST(N'2021-03-06' AS Date), CAST(N'2021-03-06' AS Date), CAST(N'2021-08-22' AS Date), CAST(N'2021-08-22' AS Date), CAST(N'2021-04-12' AS Date), CAST(N'2021-04-12' AS Date), CAST(N'2021-05-07' AS Date))
INSERT [dbo].[Phase] ([PhaseId], [Bezeichnung], [Phasenfortschritt], [Phasenstatus], [StartdatumEffektiv], [StartdatumGeplant], [ReviewdatumEffektiv], [ReviewdatumGeplant], [EnddatumEffektiv], [EnddatumGeplant], [FreigabeDatum]) VALUES (2, N'realisierung', 0, N'abgeschlossen', CAST(N'2021-12-12' AS Date), CAST(N'2021-12-12' AS Date), CAST(N'2021-12-17' AS Date), CAST(N'2021-03-09' AS Date), CAST(N'2021-12-14' AS Date), CAST(N'2021-12-15' AS Date), CAST(N'2021-12-18' AS Date))
INSERT [dbo].[Phase] ([PhaseId], [Bezeichnung], [Phasenfortschritt], [Phasenstatus], [StartdatumEffektiv], [StartdatumGeplant], [ReviewdatumEffektiv], [ReviewdatumGeplant], [EnddatumEffektiv], [EnddatumGeplant], [FreigabeDatum]) VALUES (4, N'Test', 0, N'offen', CAST(N'2022-01-02' AS Date), CAST(N'2022-01-01' AS Date), CAST(N'2022-01-10' AS Date), CAST(N'2022-01-09' AS Date), CAST(N'2022-01-03' AS Date), CAST(N'2022-01-03' AS Date), CAST(N'2022-01-12' AS Date))
INSERT [dbo].[Phase] ([PhaseId], [Bezeichnung], [Phasenfortschritt], [Phasenstatus], [StartdatumEffektiv], [StartdatumGeplant], [ReviewdatumEffektiv], [ReviewdatumGeplant], [EnddatumEffektiv], [EnddatumGeplant], [FreigabeDatum]) VALUES (5, N'Abschluss', 60, N'offen', CAST(N'2021-03-10' AS Date), CAST(N'2021-03-10' AS Date), CAST(N'2021-03-10' AS Date), CAST(N'2021-03-10' AS Date), CAST(N'2021-03-10' AS Date), CAST(N'2021-03-10' AS Date), CAST(N'2021-03-10' AS Date))
INSERT [dbo].[Phase] ([PhaseId], [Bezeichnung], [Phasenfortschritt], [Phasenstatus], [StartdatumEffektiv], [StartdatumGeplant], [ReviewdatumEffektiv], [ReviewdatumGeplant], [EnddatumEffektiv], [EnddatumGeplant], [FreigabeDatum]) VALUES (6, N'Meine Phase', 50, N'offen', CAST(N'2021-11-11' AS Date), CAST(N'2021-11-10' AS Date), CAST(N'2021-11-15' AS Date), CAST(N'2021-11-14' AS Date), CAST(N'2021-11-13' AS Date), CAST(N'2021-11-12' AS Date), CAST(N'2021-11-16' AS Date))
INSERT [dbo].[Phase] ([PhaseId], [Bezeichnung], [Phasenfortschritt], [Phasenstatus], [StartdatumEffektiv], [StartdatumGeplant], [ReviewdatumEffektiv], [ReviewdatumGeplant], [EnddatumEffektiv], [EnddatumGeplant], [FreigabeDatum]) VALUES (7, N'meine Phase', 10, N'offen', CAST(N'2021-03-10' AS Date), CAST(N'2021-03-10' AS Date), CAST(N'2021-03-10' AS Date), CAST(N'2021-03-20' AS Date), CAST(N'2021-03-10' AS Date), CAST(N'2021-03-14' AS Date), CAST(N'2021-05-04' AS Date))
INSERT [dbo].[Phase] ([PhaseId], [Bezeichnung], [Phasenfortschritt], [Phasenstatus], [StartdatumEffektiv], [StartdatumGeplant], [ReviewdatumEffektiv], [ReviewdatumGeplant], [EnddatumEffektiv], [EnddatumGeplant], [FreigabeDatum]) VALUES (8, N'zweite Phase', 50, N'offen', CAST(N'2021-03-11' AS Date), CAST(N'2021-03-12' AS Date), CAST(N'2021-03-11' AS Date), CAST(N'2021-03-22' AS Date), CAST(N'2021-03-11' AS Date), CAST(N'2021-03-16' AS Date), CAST(N'2021-03-28' AS Date))
INSERT [dbo].[Phase] ([PhaseId], [Bezeichnung], [Phasenfortschritt], [Phasenstatus], [StartdatumEffektiv], [StartdatumGeplant], [ReviewdatumEffektiv], [ReviewdatumGeplant], [EnddatumEffektiv], [EnddatumGeplant], [FreigabeDatum]) VALUES (10, N'Phase', 0, N'offen', NULL, CAST(N'2021-03-11' AS Date), NULL, CAST(N'2021-03-11' AS Date), NULL, CAST(N'2021-03-11' AS Date), CAST(N'2021-03-11' AS Date))
INSERT [dbo].[Phase] ([PhaseId], [Bezeichnung], [Phasenfortschritt], [Phasenstatus], [StartdatumEffektiv], [StartdatumGeplant], [ReviewdatumEffektiv], [ReviewdatumGeplant], [EnddatumEffektiv], [EnddatumGeplant], [FreigabeDatum]) VALUES (11, N'Konzeptphase', 100, N'offen', NULL, CAST(N'2021-03-11' AS Date), NULL, CAST(N'2021-03-12' AS Date), NULL, CAST(N'2021-03-15' AS Date), CAST(N'2021-03-12' AS Date))
INSERT [dbo].[Phase] ([PhaseId], [Bezeichnung], [Phasenfortschritt], [Phasenstatus], [StartdatumEffektiv], [StartdatumGeplant], [ReviewdatumEffektiv], [ReviewdatumGeplant], [EnddatumEffektiv], [EnddatumGeplant], [FreigabeDatum]) VALUES (12, N'Cosiphase', 44, N'plannung', CAST(N'2021-03-12' AS Date), CAST(N'2021-03-11' AS Date), CAST(N'2021-03-12' AS Date), CAST(N'2021-03-23' AS Date), CAST(N'2021-03-12' AS Date), CAST(N'2021-03-22' AS Date), CAST(N'2021-03-25' AS Date))
SET IDENTITY_INSERT [dbo].[Phase] OFF
GO
SET IDENTITY_INSERT [dbo].[Projekt] ON 

INSERT [dbo].[Projekt] ([ProjektId], [VorgehensmodelId], [Projekttitel], [Beschreibung], [Bewilligungsdatum], [Priorität], [Status], [StartdatumEffektiv], [StartdatumGeplant], [EnddatumEffektiv], [EnddatumGeplant], [ProjektleiterMitarberiterId], [Projektfortschritt]) VALUES (8, 1006, N'MeinProjekt', N'test', CAST(N'2021-03-03' AS Date), 2, N'offen', CAST(N'2021-03-11' AS Date), CAST(N'2021-03-04' AS Date), CAST(N'2021-03-11' AS Date), CAST(N'2021-03-12' AS Date), 7, 0)
INSERT [dbo].[Projekt] ([ProjektId], [VorgehensmodelId], [Projekttitel], [Beschreibung], [Bewilligungsdatum], [Priorität], [Status], [StartdatumEffektiv], [StartdatumGeplant], [EnddatumEffektiv], [EnddatumGeplant], [ProjektleiterMitarberiterId], [Projektfortschritt]) VALUES (1004, 2006, N'Test', N'test', CAST(N'2021-03-11' AS Date), 0, N'offen', NULL, CAST(N'2021-03-18' AS Date), NULL, CAST(N'2021-03-25' AS Date), 7, 0)
SET IDENTITY_INSERT [dbo].[Projekt] OFF
GO
SET IDENTITY_INSERT [dbo].[Ressource] ON 

INSERT [dbo].[Ressource] ([RessourceId], [MitarbeiterRessourceId], [AktivitaetId], [Pensum], [Funktion], [GeplanteZeit], [EffektiveZeit]) VALUES (1, 6, 8, 25, N'lehrer', CAST(2 AS Decimal(18, 0)), CAST(3 AS Decimal(18, 0)))
INSERT [dbo].[Ressource] ([RessourceId], [MitarbeiterRessourceId], [AktivitaetId], [Pensum], [Funktion], [GeplanteZeit], [EffektiveZeit]) VALUES (2, 9, 8, 50, N'leiter', CAST(4 AS Decimal(18, 0)), CAST(2 AS Decimal(18, 0)))
INSERT [dbo].[Ressource] ([RessourceId], [MitarbeiterRessourceId], [AktivitaetId], [Pensum], [Funktion], [GeplanteZeit], [EffektiveZeit]) VALUES (6, 8, 8, 20, N'Hauswart2', CAST(2 AS Decimal(18, 0)), CAST(2 AS Decimal(18, 0)))
SET IDENTITY_INSERT [dbo].[Ressource] OFF
GO
SET IDENTITY_INSERT [dbo].[Vorgehensmodel] ON 

INSERT [dbo].[Vorgehensmodel] ([VorgehensmodelId], [Name], [Beschreibung]) VALUES (1006, N'Hermes', N'ist ein offener Standard zur Führung und Abwicklung von IT-Projekten. 2')
INSERT [dbo].[Vorgehensmodel] ([VorgehensmodelId], [Name], [Beschreibung]) VALUES (1008, N'Wasserfall', N'Das Wasserfallmodel ist sehr beliebt und ohl das einfachste Vorgehensmodel das es gibt')
INSERT [dbo].[Vorgehensmodel] ([VorgehensmodelId], [Name], [Beschreibung]) VALUES (2006, N'V-Model', N'Eine beschreibung zum schönen softwaremodel')
INSERT [dbo].[Vorgehensmodel] ([VorgehensmodelId], [Name], [Beschreibung]) VALUES (2010, N'Das Model', N'Mein Model')
SET IDENTITY_INSERT [dbo].[Vorgehensmodel] OFF
GO
SET IDENTITY_INSERT [dbo].[Vorgehensmodel_Phase] ON 

INSERT [dbo].[Vorgehensmodel_Phase] ([Vorgehensmodel_PhaseId], [VorgehensmodelId], [PhaseId]) VALUES (1, 1006, 1)
INSERT [dbo].[Vorgehensmodel_Phase] ([Vorgehensmodel_PhaseId], [VorgehensmodelId], [PhaseId]) VALUES (2, 1006, 2)
INSERT [dbo].[Vorgehensmodel_Phase] ([Vorgehensmodel_PhaseId], [VorgehensmodelId], [PhaseId]) VALUES (3, 1006, 4)
INSERT [dbo].[Vorgehensmodel_Phase] ([Vorgehensmodel_PhaseId], [VorgehensmodelId], [PhaseId]) VALUES (4, 1006, 5)
INSERT [dbo].[Vorgehensmodel_Phase] ([Vorgehensmodel_PhaseId], [VorgehensmodelId], [PhaseId]) VALUES (5, 1006, 6)
INSERT [dbo].[Vorgehensmodel_Phase] ([Vorgehensmodel_PhaseId], [VorgehensmodelId], [PhaseId]) VALUES (6, 2006, 7)
INSERT [dbo].[Vorgehensmodel_Phase] ([Vorgehensmodel_PhaseId], [VorgehensmodelId], [PhaseId]) VALUES (10, 1008, 11)
INSERT [dbo].[Vorgehensmodel_Phase] ([Vorgehensmodel_PhaseId], [VorgehensmodelId], [PhaseId]) VALUES (11, 2010, 12)
INSERT [dbo].[Vorgehensmodel_Phase] ([Vorgehensmodel_PhaseId], [VorgehensmodelId], [PhaseId]) VALUES (7, 2006, 8)
SET IDENTITY_INSERT [dbo].[Vorgehensmodel_Phase] OFF
GO
ALTER TABLE [dbo].[Aktivitaet]  WITH CHECK ADD  CONSTRAINT [FK_Aktivitaet_Phase] FOREIGN KEY([PhaseId])
REFERENCES [dbo].[Phase] ([PhaseId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Aktivitaet] CHECK CONSTRAINT [FK_Aktivitaet_Phase]
GO
ALTER TABLE [dbo].[Dokument]  WITH NOCHECK ADD  CONSTRAINT [FK_Dokument_Aktivitaet] FOREIGN KEY([AktivitaetId])
REFERENCES [dbo].[Aktivitaet] ([AktivitaetId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Dokument] NOCHECK CONSTRAINT [FK_Dokument_Aktivitaet]
GO
ALTER TABLE [dbo].[Dokument]  WITH NOCHECK ADD  CONSTRAINT [FK_Dokument_Meilenstein] FOREIGN KEY([MeilensteinId])
REFERENCES [dbo].[Meilenstein] ([MeilensteinId])
GO
ALTER TABLE [dbo].[Dokument] NOCHECK CONSTRAINT [FK_Dokument_Meilenstein]
GO
ALTER TABLE [dbo].[Dokument]  WITH NOCHECK ADD  CONSTRAINT [FK_Dokument_Phase] FOREIGN KEY([PhaseId])
REFERENCES [dbo].[Phase] ([PhaseId])
GO
ALTER TABLE [dbo].[Dokument] NOCHECK CONSTRAINT [FK_Dokument_Phase]
GO
ALTER TABLE [dbo].[Dokument]  WITH CHECK ADD  CONSTRAINT [FK_Dokument_Projekt] FOREIGN KEY([ProjektId])
REFERENCES [dbo].[Projekt] ([ProjektId])
GO
ALTER TABLE [dbo].[Dokument] CHECK CONSTRAINT [FK_Dokument_Projekt]
GO
ALTER TABLE [dbo].[ExterneKosten]  WITH CHECK ADD  CONSTRAINT [FK_EffektiveKosten_Aktivitaet] FOREIGN KEY([AktivitaetId])
REFERENCES [dbo].[Aktivitaet] ([AktivitaetId])
GO
ALTER TABLE [dbo].[ExterneKosten] CHECK CONSTRAINT [FK_EffektiveKosten_Aktivitaet]
GO
ALTER TABLE [dbo].[ExterneKosten]  WITH CHECK ADD  CONSTRAINT [FK_EffektiveKosten_Kostenart] FOREIGN KEY([KostenartId])
REFERENCES [dbo].[Kostenart] ([KostenartId])
GO
ALTER TABLE [dbo].[ExterneKosten] CHECK CONSTRAINT [FK_EffektiveKosten_Kostenart]
GO
ALTER TABLE [dbo].[Meilenstein]  WITH CHECK ADD  CONSTRAINT [FK_Meilenstein_Phase] FOREIGN KEY([PhasenId])
REFERENCES [dbo].[Phase] ([PhaseId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Meilenstein] CHECK CONSTRAINT [FK_Meilenstein_Phase]
GO
ALTER TABLE [dbo].[Projekt]  WITH CHECK ADD  CONSTRAINT [FK_Projekt_Vorgehensmodel] FOREIGN KEY([VorgehensmodelId])
REFERENCES [dbo].[Vorgehensmodel] ([VorgehensmodelId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Projekt] CHECK CONSTRAINT [FK_Projekt_Vorgehensmodel]
GO
ALTER TABLE [dbo].[Ressource]  WITH CHECK ADD  CONSTRAINT [FK_Ressource_Aktivitaet] FOREIGN KEY([AktivitaetId])
REFERENCES [dbo].[Aktivitaet] ([AktivitaetId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Ressource] CHECK CONSTRAINT [FK_Ressource_Aktivitaet]
GO
ALTER TABLE [dbo].[Ressource]  WITH CHECK ADD  CONSTRAINT [FK_Ressource_Mitarbeiter] FOREIGN KEY([MitarbeiterRessourceId])
REFERENCES [dbo].[Mitarbeiter] ([MitarbeiterId])
GO
ALTER TABLE [dbo].[Ressource] CHECK CONSTRAINT [FK_Ressource_Mitarbeiter]
GO
ALTER TABLE [dbo].[Vorgehensmodel_Phase]  WITH CHECK ADD  CONSTRAINT [FK_Vorgehensmodel_Phase_Phase] FOREIGN KEY([PhaseId])
REFERENCES [dbo].[Phase] ([PhaseId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Vorgehensmodel_Phase] CHECK CONSTRAINT [FK_Vorgehensmodel_Phase_Phase]
GO
ALTER TABLE [dbo].[Vorgehensmodel_Phase]  WITH CHECK ADD  CONSTRAINT [FK_Vorgehensmodel_Phase_Vorgehensmodel] FOREIGN KEY([VorgehensmodelId])
REFERENCES [dbo].[Vorgehensmodel] ([VorgehensmodelId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Vorgehensmodel_Phase] CHECK CONSTRAINT [FK_Vorgehensmodel_Phase_Vorgehensmodel]
GO
