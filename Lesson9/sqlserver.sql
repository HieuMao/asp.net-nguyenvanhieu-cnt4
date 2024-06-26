USE [master]
GO
/****** Object:  Database [qlsinhvien]    Script Date: 6/26/2024 4:10:33 PM ******/
CREATE DATABASE [qlsinhvien]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'qlsinhvien', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\qlsinhvien.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'qlsinhvien_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\qlsinhvien_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [qlsinhvien] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [qlsinhvien].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [qlsinhvien] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [qlsinhvien] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [qlsinhvien] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [qlsinhvien] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [qlsinhvien] SET ARITHABORT OFF 
GO
ALTER DATABASE [qlsinhvien] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [qlsinhvien] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [qlsinhvien] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [qlsinhvien] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [qlsinhvien] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [qlsinhvien] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [qlsinhvien] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [qlsinhvien] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [qlsinhvien] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [qlsinhvien] SET  DISABLE_BROKER 
GO
ALTER DATABASE [qlsinhvien] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [qlsinhvien] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [qlsinhvien] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [qlsinhvien] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [qlsinhvien] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [qlsinhvien] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [qlsinhvien] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [qlsinhvien] SET RECOVERY FULL 
GO
ALTER DATABASE [qlsinhvien] SET  MULTI_USER 
GO
ALTER DATABASE [qlsinhvien] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [qlsinhvien] SET DB_CHAINING OFF 
GO
ALTER DATABASE [qlsinhvien] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [qlsinhvien] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [qlsinhvien] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [qlsinhvien] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'qlsinhvien', N'ON'
GO
ALTER DATABASE [qlsinhvien] SET QUERY_STORE = ON
GO
ALTER DATABASE [qlsinhvien] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [qlsinhvien]
GO
/****** Object:  Table [dbo].[KetQua]    Script Date: 6/26/2024 4:10:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KetQua](
	[MaSV] [nchar](10) NOT NULL,
	[MaMH] [nchar](10) NOT NULL,
	[Diem] [nchar](10) NULL,
 CONSTRAINT [PK_MonHoc] PRIMARY KEY CLUSTERED 
(
	[MaSV] ASC,
	[MaMH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Khoa]    Script Date: 6/26/2024 4:10:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Khoa](
	[MaKH] [nchar](10) NOT NULL,
	[TenKH] [nvarchar](50) NULL,
 CONSTRAINT [PK_Khoa] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MonHoc]    Script Date: 6/26/2024 4:10:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MonHoc](
	[MaMH] [nchar](10) NOT NULL,
	[TenMH] [nvarchar](50) NULL,
	[SoTiet] [nchar](10) NULL,
 CONSTRAINT [PK_MonHoc_1] PRIMARY KEY CLUSTERED 
(
	[MaMH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SinhVien]    Script Date: 6/26/2024 4:10:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SinhVien](
	[MaSV] [nchar](10) NOT NULL,
	[HoSV] [nvarchar](50) NULL,
	[TenSV] [nvarchar](50) NULL,
	[Phai] [bit] NULL,
	[NgaySinh] [date] NULL,
	[NoiSinh] [nvarchar](50) NULL,
	[MaKH] [nchar](10) NULL,
	[HocBong] [nvarchar](50) NULL,
	[DiemTrungBinh] [numeric](18, 2) NULL,
 CONSTRAINT [PK_SinhVien] PRIMARY KEY CLUSTERED 
(
	[MaSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[KetQua]  WITH CHECK ADD  CONSTRAINT [FK_KetQua_MonHoc1] FOREIGN KEY([MaMH])
REFERENCES [dbo].[MonHoc] ([MaMH])
GO
ALTER TABLE [dbo].[KetQua] CHECK CONSTRAINT [FK_KetQua_MonHoc1]
GO
ALTER TABLE [dbo].[KetQua]  WITH CHECK ADD  CONSTRAINT [FK_KetQua_SinhVien1] FOREIGN KEY([MaSV])
REFERENCES [dbo].[SinhVien] ([MaSV])
GO
ALTER TABLE [dbo].[KetQua] CHECK CONSTRAINT [FK_KetQua_SinhVien1]
GO
ALTER TABLE [dbo].[SinhVien]  WITH CHECK ADD  CONSTRAINT [FK_SinhVien_Khoa1] FOREIGN KEY([MaKH])
REFERENCES [dbo].[Khoa] ([MaKH])
GO
ALTER TABLE [dbo].[SinhVien] CHECK CONSTRAINT [FK_SinhVien_Khoa1]
GO
USE [master]
GO
ALTER DATABASE [qlsinhvien] SET  READ_WRITE 
GO
