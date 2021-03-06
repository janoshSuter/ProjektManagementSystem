USE [ProjektManagementSystemDB]
GO
/****** Object:  Table [dbo].[Aktivitaet]    Script Date: 16.03.2021 16:29:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Aktivitaet](
	[AktivitaetId] [int] IDENTITY(1,1) NOT NULL,
	[PhaseId] [int] NOT NULL,
	[VerantwortlicherMitarbeiterId] [int] NOT NULL,
	[Beschreibung] [varchar](100) NULL,
	[StartdatumEffektiv] [date] NULL,
	[StartdatumGeplant] [date] NOT NULL,
	[EnddatumEffektiv] [date] NULL,
	[EnddatumGeplant] [date] NOT NULL,
	[Budget] [int] NOT NULL,
	[Fortschritt] [int] NOT NULL,
 CONSTRAINT [PK_Aktivitaet] PRIMARY KEY CLUSTERED 
(
	[AktivitaetId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Dokument]    Script Date: 16.03.2021 16:29:31 ******/
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
/****** Object:  Table [dbo].[ExterneKosten]    Script Date: 16.03.2021 16:29:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ExterneKosten](
	[ExterneKostenId] [int] IDENTITY(1,1) NOT NULL,
	[AktivitaetId] [int] NOT NULL,
	[KostenartId] [int] NOT NULL,
	[EffektiveKosten] [decimal](18, 0) NULL,
	[GeplannteKosten] [decimal](18, 0) NOT NULL,
	[Abweichungsbegruendung] [varchar](200) NULL,
 CONSTRAINT [PK_ExterneKosten] PRIMARY KEY CLUSTERED 
(
	[ExterneKostenId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kostenart]    Script Date: 16.03.2021 16:29:31 ******/
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
/****** Object:  Table [dbo].[Meilenstein]    Script Date: 16.03.2021 16:29:31 ******/
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
/****** Object:  Table [dbo].[Mitarbeiter]    Script Date: 16.03.2021 16:29:31 ******/
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
/****** Object:  Table [dbo].[Phase]    Script Date: 16.03.2021 16:29:31 ******/
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
/****** Object:  Table [dbo].[Projekt]    Script Date: 16.03.2021 16:29:31 ******/
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
/****** Object:  Table [dbo].[Ressource]    Script Date: 16.03.2021 16:29:31 ******/
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
/****** Object:  Table [dbo].[Vorgehensmodel]    Script Date: 16.03.2021 16:29:31 ******/
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
/****** Object:  Table [dbo].[Vorgehensmodel_Phase]    Script Date: 16.03.2021 16:29:31 ******/
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
ALTER TABLE [dbo].[Aktivitaet]  WITH CHECK ADD  CONSTRAINT [FK_Aktivitaet_Mitarbeiter] FOREIGN KEY([VerantwortlicherMitarbeiterId])
REFERENCES [dbo].[Mitarbeiter] ([MitarbeiterId])
GO
ALTER TABLE [dbo].[Aktivitaet] CHECK CONSTRAINT [FK_Aktivitaet_Mitarbeiter]
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
ALTER TABLE [dbo].[Projekt]  WITH CHECK ADD  CONSTRAINT [FK_Projekt_Mitarbeiter] FOREIGN KEY([ProjektleiterMitarberiterId])
REFERENCES [dbo].[Mitarbeiter] ([MitarbeiterId])
GO
ALTER TABLE [dbo].[Projekt] CHECK CONSTRAINT [FK_Projekt_Mitarbeiter]
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
