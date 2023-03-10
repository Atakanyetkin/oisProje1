USE [master]
GO
/****** Object:  Database [OkulDb]    Script Date: 9.12.2022 00:31:43 ******/
CREATE DATABASE [OkulDb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'OkulDb', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\OkulDb.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'OkulDb_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\OkulDb_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [OkulDb] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [OkulDb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [OkulDb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [OkulDb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [OkulDb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [OkulDb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [OkulDb] SET ARITHABORT OFF 
GO
ALTER DATABASE [OkulDb] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [OkulDb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [OkulDb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [OkulDb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [OkulDb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [OkulDb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [OkulDb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [OkulDb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [OkulDb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [OkulDb] SET  DISABLE_BROKER 
GO
ALTER DATABASE [OkulDb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [OkulDb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [OkulDb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [OkulDb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [OkulDb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [OkulDb] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [OkulDb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [OkulDb] SET RECOVERY FULL 
GO
ALTER DATABASE [OkulDb] SET  MULTI_USER 
GO
ALTER DATABASE [OkulDb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [OkulDb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [OkulDb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [OkulDb] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [OkulDb] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [OkulDb] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'OkulDb', N'ON'
GO
ALTER DATABASE [OkulDb] SET QUERY_STORE = OFF
GO
USE [OkulDb]
GO
/****** Object:  Table [dbo].[tbl_ders]    Script Date: 9.12.2022 00:31:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_ders](
	[ders_id] [smallint] IDENTITY(1,1) NOT NULL,
	[ders_ad] [varchar](30) NULL,
	[ders_kredi] [varchar](30) NULL,
	[ders_okulyonetimid] [smallint] NULL,
 CONSTRAINT [PK_tbl_ders] PRIMARY KEY CLUSTERED 
(
	[ders_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_ogrenciders]    Script Date: 9.12.2022 00:31:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_ogrenciders](
	[ogrenciders_id] [smallint] IDENTITY(1,1) NOT NULL,
	[ogrenciders_dersid] [smallint] NULL,
	[ogrenciders_ogrenciid] [smallint] NULL,
 CONSTRAINT [PK_tbl_ogrenciders] PRIMARY KEY CLUSTERED 
(
	[ogrenciders_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_ogrenciler]    Script Date: 9.12.2022 00:31:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_ogrenciler](
	[ogrenci_id] [smallint] IDENTITY(1,1) NOT NULL,
	[ogrenci_fullname] [varchar](50) NULL,
	[ogrenci_recorddate] [datetime] NULL,
	[ogrenci_birthdate] [datetime] NULL,
	[ogrenci_bolum] [varchar](50) NULL,
	[ogrenci_no] [varchar](11) NULL,
 CONSTRAINT [PK_tbl_ogrenciler] PRIMARY KEY CLUSTERED 
(
	[ogrenci_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_okulyonetim]    Script Date: 9.12.2022 00:31:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_okulyonetim](
	[yonetim_id] [smallint] IDENTITY(1,1) NOT NULL,
	[yonetim_adsoyad] [varchar](30) NULL,
	[yonetim_gorev] [varchar](30) NULL,
	[yonetim_tip] [nchar](10) NULL,
 CONSTRAINT [PK_tbl_okulyonetim] PRIMARY KEY CLUSTERED 
(
	[yonetim_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tbl_ders] ON 

INSERT [dbo].[tbl_ders] ([ders_id], [ders_ad], [ders_kredi], [ders_okulyonetimid]) VALUES (1, N'Elektronik', N'10', 1)
INSERT [dbo].[tbl_ders] ([ders_id], [ders_ad], [ders_kredi], [ders_okulyonetimid]) VALUES (2, N'Mühendislik', N'10', 6)
INSERT [dbo].[tbl_ders] ([ders_id], [ders_ad], [ders_kredi], [ders_okulyonetimid]) VALUES (3, N'İklim Mühendisliği', N'6', 3)
INSERT [dbo].[tbl_ders] ([ders_id], [ders_ad], [ders_kredi], [ders_okulyonetimid]) VALUES (4, N'Askerlik', N'8', 2)
SET IDENTITY_INSERT [dbo].[tbl_ders] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_ogrenciders] ON 

INSERT [dbo].[tbl_ogrenciders] ([ogrenciders_id], [ogrenciders_dersid], [ogrenciders_ogrenciid]) VALUES (1, 1, 3)
INSERT [dbo].[tbl_ogrenciders] ([ogrenciders_id], [ogrenciders_dersid], [ogrenciders_ogrenciid]) VALUES (2, 2, 1)
INSERT [dbo].[tbl_ogrenciders] ([ogrenciders_id], [ogrenciders_dersid], [ogrenciders_ogrenciid]) VALUES (3, 3, 8)
SET IDENTITY_INSERT [dbo].[tbl_ogrenciders] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_ogrenciler] ON 

INSERT [dbo].[tbl_ogrenciler] ([ogrenci_id], [ogrenci_fullname], [ogrenci_recorddate], [ogrenci_birthdate], [ogrenci_bolum], [ogrenci_no]) VALUES (1, N'Ali Güneş Oğlu', CAST(N'2022-11-25T00:00:00.000' AS DateTime), CAST(N'2000-02-24T00:00:00.000' AS DateTime), N'Mühendislik', N'350')
INSERT [dbo].[tbl_ogrenciler] ([ogrenci_id], [ogrenci_fullname], [ogrenci_recorddate], [ogrenci_birthdate], [ogrenci_bolum], [ogrenci_no]) VALUES (3, N'Sedat Peker', CAST(N'2022-11-25T00:00:00.000' AS DateTime), CAST(N'2000-02-10T00:00:00.000' AS DateTime), N'Siyaset', N'120')
INSERT [dbo].[tbl_ogrenciler] ([ogrenci_id], [ogrenci_fullname], [ogrenci_recorddate], [ogrenci_birthdate], [ogrenci_bolum], [ogrenci_no]) VALUES (8, N'Josef Stalin', CAST(N'2022-11-26T00:18:28.073' AS DateTime), CAST(N'2002-08-14T00:17:50.000' AS DateTime), N'Siyaset', N'130')
SET IDENTITY_INSERT [dbo].[tbl_ogrenciler] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_okulyonetim] ON 

INSERT [dbo].[tbl_okulyonetim] ([yonetim_id], [yonetim_adsoyad], [yonetim_gorev], [yonetim_tip]) VALUES (1, N'İbrahim Tatlıses', N'Matematik', N'12        ')
INSERT [dbo].[tbl_okulyonetim] ([yonetim_id], [yonetim_adsoyad], [yonetim_gorev], [yonetim_tip]) VALUES (2, N'Okan Bayülgen', N'Yazılım', N'12        ')
INSERT [dbo].[tbl_okulyonetim] ([yonetim_id], [yonetim_adsoyad], [yonetim_gorev], [yonetim_tip]) VALUES (3, N'Bakan Nebati', N'İşletme', N'12        ')
INSERT [dbo].[tbl_okulyonetim] ([yonetim_id], [yonetim_adsoyad], [yonetim_gorev], [yonetim_tip]) VALUES (4, N'Süleyman Onurlu', N'Müdür Yardımcısı', N'11        ')
INSERT [dbo].[tbl_okulyonetim] ([yonetim_id], [yonetim_adsoyad], [yonetim_gorev], [yonetim_tip]) VALUES (5, N'Faruk Mahmut Kalaylı', N'Müdür', N'11        ')
INSERT [dbo].[tbl_okulyonetim] ([yonetim_id], [yonetim_adsoyad], [yonetim_gorev], [yonetim_tip]) VALUES (6, N'Dean ACKLESS', N'Sosyal Bilgiler', N'12        ')
SET IDENTITY_INSERT [dbo].[tbl_okulyonetim] OFF
GO
ALTER TABLE [dbo].[tbl_ders]  WITH CHECK ADD  CONSTRAINT [FK_tbl_ders_tbl_okulyonetim] FOREIGN KEY([ders_okulyonetimid])
REFERENCES [dbo].[tbl_okulyonetim] ([yonetim_id])
GO
ALTER TABLE [dbo].[tbl_ders] CHECK CONSTRAINT [FK_tbl_ders_tbl_okulyonetim]
GO
ALTER TABLE [dbo].[tbl_ogrenciders]  WITH CHECK ADD  CONSTRAINT [FK_tbl_ogrenciders_tbl_ders] FOREIGN KEY([ogrenciders_dersid])
REFERENCES [dbo].[tbl_ders] ([ders_id])
GO
ALTER TABLE [dbo].[tbl_ogrenciders] CHECK CONSTRAINT [FK_tbl_ogrenciders_tbl_ders]
GO
ALTER TABLE [dbo].[tbl_ogrenciders]  WITH CHECK ADD  CONSTRAINT [FK_tbl_ogrenciders_tbl_ogrenciler1] FOREIGN KEY([ogrenciders_ogrenciid])
REFERENCES [dbo].[tbl_ogrenciler] ([ogrenci_id])
GO
ALTER TABLE [dbo].[tbl_ogrenciders] CHECK CONSTRAINT [FK_tbl_ogrenciders_tbl_ogrenciler1]
GO
USE [master]
GO
ALTER DATABASE [OkulDb] SET  READ_WRITE 
GO
