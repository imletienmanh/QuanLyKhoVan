USE [master]
GO
/****** Object:  Database [QuanLyKhoVan]    Script Date: 01/06/2024 7:49:32 SA ******/
CREATE DATABASE [QuanLyKhoVan]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyKhoVan', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\QuanLyKhoVan.mdf' , SIZE = 73728KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QuanLyKhoVan_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\QuanLyKhoVan_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyKhoVan].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyKhoVan] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyKhoVan] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyKhoVan] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyKhoVan] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyKhoVan] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyKhoVan] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QuanLyKhoVan] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyKhoVan] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyKhoVan] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyKhoVan] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyKhoVan] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyKhoVan] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyKhoVan] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyKhoVan] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyKhoVan] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QuanLyKhoVan] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyKhoVan] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyKhoVan] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyKhoVan] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyKhoVan] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyKhoVan] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyKhoVan] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyKhoVan] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QuanLyKhoVan] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyKhoVan] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyKhoVan] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyKhoVan] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyKhoVan] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QuanLyKhoVan] SET DELAYED_DURABILITY = DISABLED 
GO
USE [QuanLyKhoVan]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 01/06/2024 7:49:32 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[TenTaiKhoan] [nvarchar](50) NOT NULL,
	[MatKhau] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
 CONSTRAINT [PK_Account] PRIMARY KEY CLUSTERED 
(
	[TenTaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 01/06/2024 7:49:32 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[Category_ID] [int] NOT NULL,
	[TenDanhMuc] [nvarchar](50) NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[Category_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 01/06/2024 7:49:32 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[Customer_ID] [int] NOT NULL,
	[TenKhachHang] [nvarchar](50) NULL,
	[SDT] [varchar](10) NULL,
	[DiaChi] [nvarchar](50) NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[Customer_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 01/06/2024 7:49:32 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[Employee_ID] [int] NOT NULL,
	[TenNhanVien] [nvarchar](50) NULL,
	[SDT] [varchar](10) NULL,
 CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED 
(
	[Employee_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Incoming_Shipment_Detail]    Script Date: 01/06/2024 7:49:32 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Incoming_Shipment_Detail](
	[Detail_ID] [int] NOT NULL,
	[Shipment_ID] [int] NULL,
	[Product_ID] [int] NULL,
	[SoLuong] [int] NULL,
	[ThanhTien] [int] NULL,
 CONSTRAINT [PK_Incoming_Shipment_Detail] PRIMARY KEY CLUSTERED 
(
	[Detail_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Incoming_Shipments]    Script Date: 01/06/2024 7:49:32 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Incoming_Shipments](
	[Shipment_ID] [int] NOT NULL,
	[Warehouse_ID] [int] NULL,
	[Supplier_ID] [int] NULL,
	[NgayNhapHang] [datetime] NULL,
	[SoMatHangNhap] [int] NULL,
	[TongTienHang] [int] NULL,
 CONSTRAINT [PK_Incoming_Shipments] PRIMARY KEY CLUSTERED 
(
	[Shipment_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Inventory_Checks]    Script Date: 01/06/2024 7:49:32 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inventory_Checks](
	[Check_ID] [int] NOT NULL,
	[Warehouse_ID] [int] NULL,
	[NgayKiemKe] [datetime] NULL,
	[Employee_ID] [int] NULL,
	[status] [nvarchar](50) NULL,
 CONSTRAINT [PK_Inventory_Checks] PRIMARY KEY CLUSTERED 
(
	[Check_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order]    Script Date: 01/06/2024 7:49:32 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[Order_ID] [int] NOT NULL,
	[Customer_ID] [int] NULL,
	[NgayDatHang] [datetime] NULL,
	[TongSoTienGiaoHang] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
 CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED 
(
	[Order_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order_Details]    Script Date: 01/06/2024 7:49:32 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order_Details](
	[Order_Detail_ID] [int] NOT NULL,
	[Order_ID] [int] NULL,
	[Product_ID] [int] NULL,
	[SoLuongSanPham] [int] NULL,
	[Gia] [int] NULL,
 CONSTRAINT [PK_Order_Details] PRIMARY KEY CLUSTERED 
(
	[Order_Detail_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Outgoing_Shipments]    Script Date: 01/06/2024 7:49:32 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Outgoing_Shipments](
	[Shipment_ID] [int] NOT NULL,
	[Warehouse_ID] [int] NULL,
	[Supplier_ID] [int] NULL,
	[NgayXuatHang] [datetime] NULL,
	[status] [nvarchar](50) NULL,
 CONSTRAINT [PK_Outgoing_Shipments] PRIMARY KEY CLUSTERED 
(
	[Shipment_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 01/06/2024 7:49:32 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[Product_ID] [int] NOT NULL,
	[TenSanPham] [nvarchar](50) NULL,
	[MoTa] [nvarchar](50) NULL,
	[Gia] [int] NULL,
	[SoLuong] [int] NULL,
	[Category_ID] [int] NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[Product_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Shipments]    Script Date: 01/06/2024 7:49:32 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Shipments](
	[Shipment_ID] [int] NOT NULL,
	[Order_ID] [int] NULL,
	[Employee_ID] [int] NULL,
	[NgayGiao] [datetime] NULL,
	[status] [nvarchar](50) NULL,
 CONSTRAINT [PK_Shipments] PRIMARY KEY CLUSTERED 
(
	[Shipment_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Suppliers]    Script Date: 01/06/2024 7:49:32 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Suppliers](
	[Supplier_ID] [int] NOT NULL,
	[TenNhaCungCap] [nvarchar](50) NULL,
	[ThongTinLienHe] [nvarchar](200) NULL,
 CONSTRAINT [PK_Suppliers] PRIMARY KEY CLUSTERED 
(
	[Supplier_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Warehouses]    Script Date: 01/06/2024 7:49:32 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Warehouses](
	[Warehouse_ID] [int] NOT NULL,
	[DiaDiem] [nvarchar](50) NULL,
	[TenKho] [nvarchar](50) NULL,
 CONSTRAINT [PK_Warehouses] PRIMARY KEY CLUSTERED 
(
	[Warehouse_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Account] ([TenTaiKhoan], [MatKhau], [Email]) VALUES (N'admin1', N'admin1', N'admin@gmail.com')
INSERT [dbo].[Account] ([TenTaiKhoan], [MatKhau], [Email]) VALUES (N'DuongHoang', N'DuongHoang2', N'DuongHoang2@gmail.com')
INSERT [dbo].[Account] ([TenTaiKhoan], [MatKhau], [Email]) VALUES (N'Minh03', N'Minh03', N'Minh03@gmail.com')
INSERT [dbo].[Account] ([TenTaiKhoan], [MatKhau], [Email]) VALUES (N'minh04', N'minh04', N'minh04@gmail.com')
GO
INSERT [dbo].[Categories] ([Category_ID], [TenDanhMuc]) VALUES (1002, N'Áo thun')
INSERT [dbo].[Categories] ([Category_ID], [TenDanhMuc]) VALUES (2002, N'Áo phông ')
INSERT [dbo].[Categories] ([Category_ID], [TenDanhMuc]) VALUES (3002, N'Quần dài ')
INSERT [dbo].[Categories] ([Category_ID], [TenDanhMuc]) VALUES (4002, N' kính')
INSERT [dbo].[Categories] ([Category_ID], [TenDanhMuc]) VALUES (5002, N'bàn học')
INSERT [dbo].[Categories] ([Category_ID], [TenDanhMuc]) VALUES (6002, N'ghế')
GO
INSERT [dbo].[Customers] ([Customer_ID], [TenKhachHang], [SDT], [DiaChi]) VALUES (1004, N'Nguyen Van A ', N'0332290622', N' 123 Đường ABC, Quận XYZ, Thành phố Hà Nội ')
INSERT [dbo].[Customers] ([Customer_ID], [TenKhachHang], [SDT], [DiaChi]) VALUES (2004, N' Le Thi B', N'0434043666', N'Thành phố Hà Nội ')
INSERT [dbo].[Customers] ([Customer_ID], [TenKhachHang], [SDT], [DiaChi]) VALUES (3004, N' Le Thi C ', N'0434043666', N'Thành phố Hà Nội ')
INSERT [dbo].[Customers] ([Customer_ID], [TenKhachHang], [SDT], [DiaChi]) VALUES (4004, N' Hoàng Thị  K', N'0434043677', N'Thành phố Hà Nội ')
GO
INSERT [dbo].[Employees] ([Employee_ID], [TenNhanVien], [SDT]) VALUES (1006, N'Trần thị C', N'0334405904')
INSERT [dbo].[Employees] ([Employee_ID], [TenNhanVien], [SDT]) VALUES (2006, N'Le Tron Minh', N'2324324234')
INSERT [dbo].[Employees] ([Employee_ID], [TenNhanVien], [SDT]) VALUES (3006, N'Hoang Dinh Duong', N'0332290626')
INSERT [dbo].[Employees] ([Employee_ID], [TenNhanVien], [SDT]) VALUES (4006, N'Lê Quang Thọ', N'080066655')
GO
INSERT [dbo].[Incoming_Shipment_Detail] ([Detail_ID], [Shipment_ID], [Product_ID], [SoLuong], [ThanhTien]) VALUES (10091, 1009, 3001, 20, 600000)
INSERT [dbo].[Incoming_Shipment_Detail] ([Detail_ID], [Shipment_ID], [Product_ID], [SoLuong], [ThanhTien]) VALUES (10092, 1009, 2001, 20, 600000)
INSERT [dbo].[Incoming_Shipment_Detail] ([Detail_ID], [Shipment_ID], [Product_ID], [SoLuong], [ThanhTien]) VALUES (20091, 2009, 3001, 10, 300000)
INSERT [dbo].[Incoming_Shipment_Detail] ([Detail_ID], [Shipment_ID], [Product_ID], [SoLuong], [ThanhTien]) VALUES (20092, 2009, 5001, 10, 3000000)
INSERT [dbo].[Incoming_Shipment_Detail] ([Detail_ID], [Shipment_ID], [Product_ID], [SoLuong], [ThanhTien]) VALUES (30091, 3009, 4001, 20, 6000000)
INSERT [dbo].[Incoming_Shipment_Detail] ([Detail_ID], [Shipment_ID], [Product_ID], [SoLuong], [ThanhTien]) VALUES (30092, 3009, 2001, 30, 900000)
INSERT [dbo].[Incoming_Shipment_Detail] ([Detail_ID], [Shipment_ID], [Product_ID], [SoLuong], [ThanhTien]) VALUES (30093, 3009, 2001, 32, 960000)
INSERT [dbo].[Incoming_Shipment_Detail] ([Detail_ID], [Shipment_ID], [Product_ID], [SoLuong], [ThanhTien]) VALUES (40091, 4009, 1001, 10, 1500000)
INSERT [dbo].[Incoming_Shipment_Detail] ([Detail_ID], [Shipment_ID], [Product_ID], [SoLuong], [ThanhTien]) VALUES (40092, 4009, 2001, 10, 300000)
GO
INSERT [dbo].[Incoming_Shipments] ([Shipment_ID], [Warehouse_ID], [Supplier_ID], [NgayNhapHang], [SoMatHangNhap], [TongTienHang]) VALUES (1009, 1008, 1010, CAST(N'2024-06-01T06:11:40.837' AS DateTime), 2, 1200000)
INSERT [dbo].[Incoming_Shipments] ([Shipment_ID], [Warehouse_ID], [Supplier_ID], [NgayNhapHang], [SoMatHangNhap], [TongTienHang]) VALUES (2009, 1008, 1010, CAST(N'2024-06-01T07:32:51.990' AS DateTime), 2, 3300000)
INSERT [dbo].[Incoming_Shipments] ([Shipment_ID], [Warehouse_ID], [Supplier_ID], [NgayNhapHang], [SoMatHangNhap], [TongTienHang]) VALUES (3009, 1008, 1010, CAST(N'2024-06-01T06:28:13.217' AS DateTime), 2, 7860000)
INSERT [dbo].[Incoming_Shipments] ([Shipment_ID], [Warehouse_ID], [Supplier_ID], [NgayNhapHang], [SoMatHangNhap], [TongTienHang]) VALUES (4009, 1008, 1010, CAST(N'2024-06-01T07:30:31.717' AS DateTime), 2, 1800000)
GO
INSERT [dbo].[Inventory_Checks] ([Check_ID], [Warehouse_ID], [NgayKiemKe], [Employee_ID], [status]) VALUES (1012, 1008, CAST(N'2024-05-07T00:00:00.000' AS DateTime), 1006, N'Đã hoàn thành')
GO
INSERT [dbo].[Order] ([Order_ID], [Customer_ID], [NgayDatHang], [TongSoTienGiaoHang], [DiaChi]) VALUES (1003, 1004, CAST(N'2024-05-04T00:00:00.000' AS DateTime), N'300000', N' 123 Đường ABC, Quận XYZ, Thành phố HCM')
INSERT [dbo].[Order] ([Order_ID], [Customer_ID], [NgayDatHang], [TongSoTienGiaoHang], [DiaChi]) VALUES (2003, 2004, CAST(N'2024-05-05T00:00:00.000' AS DateTime), N'300000', N'AAAAAAA')
INSERT [dbo].[Order] ([Order_ID], [Customer_ID], [NgayDatHang], [TongSoTienGiaoHang], [DiaChi]) VALUES (3003, 2004, CAST(N'2024-05-06T00:00:00.000' AS DateTime), N'300000', N'fsadasdas')
GO
INSERT [dbo].[Order_Details] ([Order_Detail_ID], [Order_ID], [Product_ID], [SoLuongSanPham], [Gia]) VALUES (1005, 1003, 1001, 2, 150000)
INSERT [dbo].[Order_Details] ([Order_Detail_ID], [Order_ID], [Product_ID], [SoLuongSanPham], [Gia]) VALUES (2005, 2003, 3001, 40, 100000)
INSERT [dbo].[Order_Details] ([Order_Detail_ID], [Order_ID], [Product_ID], [SoLuongSanPham], [Gia]) VALUES (3005, 3003, 2001, 2, 100000)
GO
INSERT [dbo].[Outgoing_Shipments] ([Shipment_ID], [Warehouse_ID], [Supplier_ID], [NgayXuatHang], [status]) VALUES (1011, 1008, 1010, CAST(N'2024-05-05T00:00:00.000' AS DateTime), N'Đã gửi hàng')
GO
INSERT [dbo].[Products] ([Product_ID], [TenSanPham], [MoTa], [Gia], [SoLuong], [Category_ID]) VALUES (1001, N'áo thun nam', N'áo thun dành cho nam ', 150000, 320, 1002)
INSERT [dbo].[Products] ([Product_ID], [TenSanPham], [MoTa], [Gia], [SoLuong], [Category_ID]) VALUES (2001, N'áo thun nữ', N'áo thun dành cho nữ ', 30000, 275, 2002)
INSERT [dbo].[Products] ([Product_ID], [TenSanPham], [MoTa], [Gia], [SoLuong], [Category_ID]) VALUES (3001, N'Quần dài', N'Quần đùi dành cho mọi người', 30000, 180, 3002)
INSERT [dbo].[Products] ([Product_ID], [TenSanPham], [MoTa], [Gia], [SoLuong], [Category_ID]) VALUES (4001, N'kính cận', N'Kính cận dành cho nam và nữ ', 300000, 364, 4002)
INSERT [dbo].[Products] ([Product_ID], [TenSanPham], [MoTa], [Gia], [SoLuong], [Category_ID]) VALUES (5001, N'bàn học', N'bàn học ', 300000, 360, 5002)
INSERT [dbo].[Products] ([Product_ID], [TenSanPham], [MoTa], [Gia], [SoLuong], [Category_ID]) VALUES (6001, N'ghế gỗ', N'ghế gỗ trang trí', 500000, 20, 6002)
GO
INSERT [dbo].[Shipments] ([Shipment_ID], [Order_ID], [Employee_ID], [NgayGiao], [status]) VALUES (1007, 1003, 1006, CAST(N'2024-05-05T00:00:00.000' AS DateTime), N'Đã giao hàng ')
INSERT [dbo].[Shipments] ([Shipment_ID], [Order_ID], [Employee_ID], [NgayGiao], [status]) VALUES (2007, 2003, 1006, CAST(N'2024-05-05T00:00:00.000' AS DateTime), N'Đã giao hàng ')
INSERT [dbo].[Shipments] ([Shipment_ID], [Order_ID], [Employee_ID], [NgayGiao], [status]) VALUES (3007, 3003, 1006, CAST(N'2024-05-05T00:00:00.000' AS DateTime), N'Đã giao hàng ')
GO
INSERT [dbo].[Suppliers] ([Supplier_ID], [TenNhaCungCap], [ThongTinLienHe]) VALUES (1010, N' Công ty TNHH X', N'0722399320')
INSERT [dbo].[Suppliers] ([Supplier_ID], [TenNhaCungCap], [ThongTinLienHe]) VALUES (2010, N' Công ty TNHH Y', N'0359272121')
GO
INSERT [dbo].[Warehouses] ([Warehouse_ID], [DiaDiem], [TenKho]) VALUES (1008, N'Bắc Từ Liêm ,Thành phố Hà Nội ', N'Kho 1')
INSERT [dbo].[Warehouses] ([Warehouse_ID], [DiaDiem], [TenKho]) VALUES (2008, N'Đông Anh , Thành phố Hà  Nội', N'Kho 2')
GO
ALTER TABLE [dbo].[Incoming_Shipment_Detail]  WITH CHECK ADD  CONSTRAINT [FK_Incoming_Shipment_Detail_Incoming_Shipments] FOREIGN KEY([Shipment_ID])
REFERENCES [dbo].[Incoming_Shipments] ([Shipment_ID])
GO
ALTER TABLE [dbo].[Incoming_Shipment_Detail] CHECK CONSTRAINT [FK_Incoming_Shipment_Detail_Incoming_Shipments]
GO
ALTER TABLE [dbo].[Incoming_Shipments]  WITH CHECK ADD  CONSTRAINT [FK_Incoming_Shipments_Suppliers] FOREIGN KEY([Supplier_ID])
REFERENCES [dbo].[Suppliers] ([Supplier_ID])
GO
ALTER TABLE [dbo].[Incoming_Shipments] CHECK CONSTRAINT [FK_Incoming_Shipments_Suppliers]
GO
ALTER TABLE [dbo].[Incoming_Shipments]  WITH CHECK ADD  CONSTRAINT [FK_Incoming_Shipments_Warehouses] FOREIGN KEY([Warehouse_ID])
REFERENCES [dbo].[Warehouses] ([Warehouse_ID])
GO
ALTER TABLE [dbo].[Incoming_Shipments] CHECK CONSTRAINT [FK_Incoming_Shipments_Warehouses]
GO
ALTER TABLE [dbo].[Inventory_Checks]  WITH CHECK ADD  CONSTRAINT [FK_Inventory_Checks_Employees] FOREIGN KEY([Employee_ID])
REFERENCES [dbo].[Employees] ([Employee_ID])
GO
ALTER TABLE [dbo].[Inventory_Checks] CHECK CONSTRAINT [FK_Inventory_Checks_Employees]
GO
ALTER TABLE [dbo].[Inventory_Checks]  WITH CHECK ADD  CONSTRAINT [FK_Inventory_Checks_Warehouses] FOREIGN KEY([Warehouse_ID])
REFERENCES [dbo].[Warehouses] ([Warehouse_ID])
GO
ALTER TABLE [dbo].[Inventory_Checks] CHECK CONSTRAINT [FK_Inventory_Checks_Warehouses]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_Customers] FOREIGN KEY([Customer_ID])
REFERENCES [dbo].[Customers] ([Customer_ID])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_Customers]
GO
ALTER TABLE [dbo].[Order_Details]  WITH CHECK ADD  CONSTRAINT [FK_Order_Details_Order] FOREIGN KEY([Order_ID])
REFERENCES [dbo].[Order] ([Order_ID])
GO
ALTER TABLE [dbo].[Order_Details] CHECK CONSTRAINT [FK_Order_Details_Order]
GO
ALTER TABLE [dbo].[Order_Details]  WITH CHECK ADD  CONSTRAINT [FK_Order_Details_Products] FOREIGN KEY([Product_ID])
REFERENCES [dbo].[Products] ([Product_ID])
GO
ALTER TABLE [dbo].[Order_Details] CHECK CONSTRAINT [FK_Order_Details_Products]
GO
ALTER TABLE [dbo].[Outgoing_Shipments]  WITH CHECK ADD  CONSTRAINT [FK_Outgoing_Shipments_Suppliers] FOREIGN KEY([Supplier_ID])
REFERENCES [dbo].[Suppliers] ([Supplier_ID])
GO
ALTER TABLE [dbo].[Outgoing_Shipments] CHECK CONSTRAINT [FK_Outgoing_Shipments_Suppliers]
GO
ALTER TABLE [dbo].[Outgoing_Shipments]  WITH CHECK ADD  CONSTRAINT [FK_Outgoing_Shipments_Warehouses] FOREIGN KEY([Warehouse_ID])
REFERENCES [dbo].[Warehouses] ([Warehouse_ID])
GO
ALTER TABLE [dbo].[Outgoing_Shipments] CHECK CONSTRAINT [FK_Outgoing_Shipments_Warehouses]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Categories] FOREIGN KEY([Category_ID])
REFERENCES [dbo].[Categories] ([Category_ID])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Categories]
GO
ALTER TABLE [dbo].[Shipments]  WITH CHECK ADD  CONSTRAINT [FK_Shipments_Employees] FOREIGN KEY([Employee_ID])
REFERENCES [dbo].[Employees] ([Employee_ID])
GO
ALTER TABLE [dbo].[Shipments] CHECK CONSTRAINT [FK_Shipments_Employees]
GO
ALTER TABLE [dbo].[Shipments]  WITH CHECK ADD  CONSTRAINT [FK_Shipments_Order] FOREIGN KEY([Order_ID])
REFERENCES [dbo].[Order] ([Order_ID])
GO
ALTER TABLE [dbo].[Shipments] CHECK CONSTRAINT [FK_Shipments_Order]
GO
USE [master]
GO
ALTER DATABASE [QuanLyKhoVan] SET  READ_WRITE 
GO
