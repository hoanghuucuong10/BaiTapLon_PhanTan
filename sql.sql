USE [master]
GO
/****** Object:  Database [BanDiaPhanTan]    Script Date: 11/1/2019 1:06:54 PM ******/
CREATE DATABASE [BanDiaPhanTan]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BanDiaPhanTan', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\BanDiaPhanTan.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'BanDiaPhanTan_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\BanDiaPhanTan_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [BanDiaPhanTan] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BanDiaPhanTan].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BanDiaPhanTan] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BanDiaPhanTan] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BanDiaPhanTan] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BanDiaPhanTan] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BanDiaPhanTan] SET ARITHABORT OFF 
GO
ALTER DATABASE [BanDiaPhanTan] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BanDiaPhanTan] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BanDiaPhanTan] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BanDiaPhanTan] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BanDiaPhanTan] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BanDiaPhanTan] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BanDiaPhanTan] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BanDiaPhanTan] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BanDiaPhanTan] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BanDiaPhanTan] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BanDiaPhanTan] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BanDiaPhanTan] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BanDiaPhanTan] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BanDiaPhanTan] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BanDiaPhanTan] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BanDiaPhanTan] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BanDiaPhanTan] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BanDiaPhanTan] SET RECOVERY FULL 
GO
ALTER DATABASE [BanDiaPhanTan] SET  MULTI_USER 
GO
ALTER DATABASE [BanDiaPhanTan] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BanDiaPhanTan] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BanDiaPhanTan] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BanDiaPhanTan] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [BanDiaPhanTan] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'BanDiaPhanTan', N'ON'
GO
USE [BanDiaPhanTan]
GO
/****** Object:  Table [dbo].[ChiTietHoaDon]    Script Date: 11/1/2019 1:06:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDon](
	[MaChiTietHD] [int] NOT NULL,
	[MaHoaDon] [int] NULL,
	[MaDia] [int] NULL,
	[SoLuong] [int] NULL,
	[ThanhTien] [float] NULL,
 CONSTRAINT [PK_ChiTietHoaDon] PRIMARY KEY CLUSTERED 
(
	[MaChiTietHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Dia]    Script Date: 11/1/2019 1:06:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dia](
	[MaDia] [int] NOT NULL,
	[TenDia] [nvarchar](50) NULL,
	[MaTheLoai] [int] NULL,
	[SoLuong] [int] NULL,
	[DonGia] [float] NULL,
	[HinhAnh] [image] NULL,
 CONSTRAINT [PK_Dia] PRIMARY KEY CLUSTERED 
(
	[MaDia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 11/1/2019 1:06:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHoaDon] [int] NOT NULL,
	[NgayLapHoaDon] [date] NULL,
	[MaNhanVien] [int] NULL,
	[TongTien] [float] NULL,
	[LoaiHoaDon] [nchar](10) NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 11/1/2019 1:06:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNhanVien] [int] NOT NULL,
	[HoTen] [nvarchar](50) NULL,
	[SDT] [nvarchar](12) NULL,
	[Mail] [nvarchar](50) NULL,
	[TenTaiKhoan] [char](20) NULL,
	[MatKhau] [char](20) NULL,
	[ChucVu] [nchar](10) NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TheLoai]    Script Date: 11/1/2019 1:06:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TheLoai](
	[MaTheLoai] [int] NOT NULL,
	[TenTheLoai] [nvarchar](50) NULL,
 CONSTRAINT [PK_TheLoai] PRIMARY KEY CLUSTERED 
(
	[MaTheLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[Dia] ([MaDia], [TenDia], [MaTheLoai], [SoLuong], [DonGia], [HinhAnh]) VALUES (1, N'Avenger 1', 5, 20, 10000, NULL)
INSERT [dbo].[Dia] ([MaDia], [TenDia], [MaTheLoai], [SoLuong], [DonGia], [HinhAnh]) VALUES (2, N'Dragon Ball', 2, 20, 20000, NULL)
INSERT [dbo].[Dia] ([MaDia], [TenDia], [MaTheLoai], [SoLuong], [DonGia], [HinhAnh]) VALUES (3, N'3h Sáng', 4, 30, 20000, NULL)
INSERT [dbo].[Dia] ([MaDia], [TenDia], [MaTheLoai], [SoLuong], [DonGia], [HinhAnh]) VALUES (4, N'Doraemon', 2, 100, 20000, NULL)
INSERT [dbo].[Dia] ([MaDia], [TenDia], [MaTheLoai], [SoLuong], [DonGia], [HinhAnh]) VALUES (5, N'Naruto', 2, 100, 10000, NULL)
INSERT [dbo].[Dia] ([MaDia], [TenDia], [MaTheLoai], [SoLuong], [DonGia], [HinhAnh]) VALUES (6, N'Ở nhà một mình 1', 7, 10, 10000, NULL)
INSERT [dbo].[Dia] ([MaDia], [TenDia], [MaTheLoai], [SoLuong], [DonGia], [HinhAnh]) VALUES (7, N'Ở nhà một mình 2', 7, 15, 10000, NULL)
INSERT [dbo].[Dia] ([MaDia], [TenDia], [MaTheLoai], [SoLuong], [DonGia], [HinhAnh]) VALUES (8, N'Ở nhà một mình 3', 7, 25, 20000, NULL)
INSERT [dbo].[Dia] ([MaDia], [TenDia], [MaTheLoai], [SoLuong], [DonGia], [HinhAnh]) VALUES (9, N'Ở nhà một mình 4', 7, 12, 20000, NULL)
INSERT [dbo].[Dia] ([MaDia], [TenDia], [MaTheLoai], [SoLuong], [DonGia], [HinhAnh]) VALUES (10, N'The ring', 4, 11, 25000, NULL)
INSERT [dbo].[NhanVien] ([MaNhanVien], [HoTen], [SDT], [Mail], [TenTaiKhoan], [MatKhau], [ChucVu]) VALUES (1, N'Hoàng Hữu Cương', N'0375439190', N'cuonghoang1305@gmail.com', N'hoanghuucuong       ', N'12345678            ', N'M         ')
INSERT [dbo].[NhanVien] ([MaNhanVien], [HoTen], [SDT], [Mail], [TenTaiKhoan], [MatKhau], [ChucVu]) VALUES (2, N'Phan Hữu Quý', N'0375439190', N'huuquy@gmail.com', N'phanhuuquy          ', N'12345678            ', N'E         ')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai]) VALUES (1, N'Hành Động')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai]) VALUES (2, N'Hoạt Hình')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai]) VALUES (3, N'Ngôn Tình')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai]) VALUES (4, N'Kinh Dị')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai]) VALUES (5, N'Siêu Anh Hùng')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai]) VALUES (6, N'Trinh Thám')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai]) VALUES (7, N'Hài')
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDon_Dia] FOREIGN KEY([MaDia])
REFERENCES [dbo].[Dia] ([MaDia])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_ChiTietHoaDon_Dia]
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDon_HoaDon] FOREIGN KEY([MaChiTietHD])
REFERENCES [dbo].[HoaDon] ([MaHoaDon])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_ChiTietHoaDon_HoaDon]
GO
ALTER TABLE [dbo].[Dia]  WITH CHECK ADD  CONSTRAINT [FK_Dia_TheLoai] FOREIGN KEY([MaTheLoai])
REFERENCES [dbo].[TheLoai] ([MaTheLoai])
GO
ALTER TABLE [dbo].[Dia] CHECK CONSTRAINT [FK_Dia_TheLoai]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_NhanVien] FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_NhanVien]
GO
USE [master]
GO
ALTER DATABASE [BanDiaPhanTan] SET  READ_WRITE 
GO
