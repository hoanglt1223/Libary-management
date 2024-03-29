USE [master]
GO

WHILE EXISTS(select NULL from sys.databases where name='QLTV')
BEGIN
    DECLARE @SQL varchar(max)
    SELECT @SQL = COALESCE(@SQL,'') + 'Kill ' + Convert(varchar, SPId) + ';'
    FROM MASTER..SysProcesses
    WHERE DBId = DB_ID(N'QLTV') AND SPId <> @@SPId
    EXEC(@SQL)
    DROP DATABASE [QLTV]
END
GO

/* Collation = SQL_Latin1_General_CP1_CI_AS */
CREATE DATABASE [QLTV]
GO
USE [QLTV]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DangNhap](
	[TenDangNhap] [nvarchar](20) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[MatKhau] [nvarchar](20) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[LoaiTaiKhoan] [int] NULL,
 CONSTRAINT [PK_DangNhap] PRIMARY KEY CLUSTERED 
(
	[TenDangNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DocGia](
	[MaDocGia] [varchar](10) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[TenDocGia] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[GioiTinh] [nvarchar](10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[NgaySinh] [date] NULL,
	[DiaChi] [nvarchar](100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[SoCMT] [varchar](10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[MaLoaiDocGia] [varchar](10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[MatKhau] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
 CONSTRAINT [PK_DocGia] PRIMARY KEY CLUSTERED 
(
	[MaDocGia] ASC
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
CREATE TABLE [dbo].[LoaiDocGia](
	[MaLoaiDocGia] [varchar](10) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[TenLoaiDocGia] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
 CONSTRAINT [PK_LoaiDocGia] PRIMARY KEY CLUSTERED 
(
	[MaLoaiDocGia] ASC
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
CREATE TABLE [dbo].[LoaiThe](
	[MaLoaiThe] [varchar](10) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[TenLoaiThe] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
 CONSTRAINT [PK_LoaiThe] PRIMARY KEY CLUSTERED 
(
	[MaLoaiThe] ASC
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
CREATE TABLE [dbo].[Nxb](
	[MaNXB] [varchar](10) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[TenNXB] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[GhiChu] [nvarchar](1500) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
 CONSTRAINT [PK_Nxb] PRIMARY KEY CLUSTERED 
(
	[MaNXB] ASC
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
CREATE TABLE [dbo].[PhieuMuon](
	[SoPhieu] [int] IDENTITY(1,1) NOT NULL,
	[MaThe] [varchar](10) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[MaSach] [varchar](10) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[NgayMuon] [date] NOT NULL,
	[NgayTra] [date] NOT NULL,
	[TinhTrang] [nvarchar](20) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[GhiChu] [nvarchar](500) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
 CONSTRAINT [PK_PhieuMuon_1] PRIMARY KEY CLUSTERED 
(
	[SoPhieu] ASC
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
CREATE TABLE [dbo].[Sach](
	[MaSach] [varchar](10) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[TenSach] [nvarchar](100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[MaTacGia] [varchar](10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[MaTheLoai] [varchar](10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[MaNXB] [varchar](10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[NamXuatBan] [int] NULL,
	[SoTrang] [int] NULL,
	[Gia] [int] NULL,
	[SoBan] [int] NULL,
	[SoBanTon] [int] NULL,
 CONSTRAINT [PK_Sach] PRIMARY KEY CLUSTERED 
(
	[MaSach] ASC
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
CREATE TABLE [dbo].[TacGia](
	[MaTacGia] [varchar](10) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[TenTacGia] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[GhiChu] [nvarchar](1500) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
 CONSTRAINT [PK_TacGia] PRIMARY KEY CLUSTERED 
(
	[MaTacGia] ASC
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
CREATE TABLE [dbo].[The](
	[MaThe] [varchar](10) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[MaDocGia] [varchar](10) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[MaLoaiThe] [varchar](10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[NgayCapThe] [date] NULL,
	[NgayHetHan] [date] NULL,
	[SoSachDuocMuon] [int] NULL,
	[SoSachDangMuon] [int] NULL,
 CONSTRAINT [PK_The] PRIMARY KEY CLUSTERED 
(
	[MaThe] ASC
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
CREATE TABLE [dbo].[TheLoai](
	[MaTheLoai] [varchar](10) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[TenTheLoai] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
 CONSTRAINT [PK_TheLoai] PRIMARY KEY CLUSTERED 
(
	[MaTheLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[DangNhap] ([TENDangNhap], [MatKhau], [LoaiTaiKhoan]) VALUES (N'17520514', N'1', 0)
INSERT [dbo].[DangNhap] ([TENDangNhap], [MatKhau], [LoaiTaiKhoan]) VALUES (N'17521199', N'1', 0)
INSERT [dbo].[DangNhap] ([TENDangNhap], [MatKhau], [LoaiTaiKhoan]) VALUES (N'17521150', N'1', 0)
INSERT [dbo].[DangNhap] ([TENDangNhap], [MatKhau], [LoaiTaiKhoan]) VALUES (N'17520251', N'1', 0)
INSERT [dbo].[DangNhap] ([TENDangNhap], [MatKhau], [LoaiTaiKhoan]) VALUES (N'17520056', N'1', 0)
INSERT [dbo].[DangNhap] ([TENDangNhap], [MatKhau], [LoaiTaiKhoan]) VALUES (N'17520067', N'1', 0)
INSERT [dbo].[DangNhap] ([TENDangNhap], [MatKhau], [LoaiTaiKhoan]) VALUES (N'17520077', N'1', 0)
INSERT [dbo].[DangNhap] ([TENDangNhap], [MatKhau], [LoaiTaiKhoan]) VALUES (N'17520088', N'1', 0)
INSERT [dbo].[DangNhap] ([TENDangNhap], [MatKhau], [LoaiTaiKhoan]) VALUES (N'17520099', N'1', 0)
INSERT [dbo].[DangNhap] ([TENDangNhap], [MatKhau], [LoaiTaiKhoan]) VALUES (N'17520100', N'1', 0)
INSERT [dbo].[DangNhap] ([TENDangNhap], [MatKhau], [LoaiTaiKhoan]) VALUES (N'22222222', N'1', 0)
INSERT [dbo].[DangNhap] ([TENDangNhap], [MatKhau], [LoaiTaiKhoan]) VALUES (N'33333333', N'1', 0)
INSERT [dbo].[DangNhap] ([TENDangNhap], [MatKhau], [LoaiTaiKhoan]) VALUES (N'44444444', N'1', 0)
INSERT [dbo].[DangNhap] ([TENDangNhap], [MatKhau], [LoaiTaiKhoan]) VALUES (N'55555555', N'1', 0)
INSERT [dbo].[DangNhap] ([TENDangNhap], [MatKhau], [LoaiTaiKhoan]) VALUES (N'admin', N'1', 1)
INSERT [dbo].[DangNhap] ([TENDangNhap], [MatKhau], [LoaiTaiKhoan]) VALUES (N'admin2', N'1', 1)
INSERT [dbo].[DangNhap] ([TENDangNhap], [MatKhau], [LoaiTaiKhoan]) VALUES (N'DG1', N'quamon', 0)
INSERT [dbo].[DangNhap] ([TENDangNhap], [MatKhau], [LoaiTaiKhoan]) VALUES (N'manager', N'1', 1)
INSERT [dbo].[DocGia] ([MaDocGia], [TENDocGia], [GioiTinh], [NgaySinh], [DiaChi], [SoCMT], [MaLoaiDocGia], [MatKhau]) VALUES (N'17520514', N'Nguyễn Thanh Hoàng', N'Nam', CAST(N'1999-07-31' AS Date), N'HCM', N'025916060', N'103', N'1')
INSERT [dbo].[DocGia] ([MaDocGia], [TENDocGia], [GioiTinh], [NgaySinh], [DiaChi], [SoCMT], [MaLoaiDocGia], [MatKhau]) VALUES (N'17521199', N'Nguyễn Đoàn Anh Tú', N'Nam', CAST(N'1999-05-18' AS Date), N'HCM', N'025868764', N'102', N'1')
INSERT [dbo].[DocGia] ([MaDocGia], [TENDocGia], [GioiTinh], [NgaySinh], [DiaChi], [SoCMT], [MaLoaiDocGia], [MatKhau]) VALUES (N'17521150', N'Trần Diệu Bảo Trân', N'Nữ', CAST(N'1999-09-10' AS Date), N'HCM', N'025565465', N'102', N'1')
INSERT [dbo].[DocGia] ([MaDocGia], [TENDocGia], [GioiTinh], [NgaySinh], [DiaChi], [SoCMT], [MaLoaiDocGia], [MatKhau]) VALUES (N'17520251', N'Tô Diệp Thiên Anh', N'Nam', CAST(N'1999-12-14' AS Date), N'HCM', N'025868902', N'102', N'1')
INSERT [dbo].[DocGia] ([MaDocGia], [TENDocGia], [GioiTinh], [NgaySinh], [DiaChi], [SoCMT], [MaLoaiDocGia], [MatKhau]) VALUES (N'17520056', N'Phạm Kinh Kha', N'Nam', CAST(N'1999-04-05' AS Date), N'HCM', N'548574837', N'102', N'1')
INSERT [dbo].[DocGia] ([MaDocGia], [TENDocGia], [GioiTinh], [NgaySinh], [DiaChi], [SoCMT], [MaLoaiDocGia], [MatKhau]) VALUES (N'17520067', N'Đỗ Mạnh Cường', N'Nam', CAST(N'1999-03-17' AS Date), N'HCM', N'127362322', N'103', N'1')
INSERT [dbo].[DocGia] ([MaDocGia], [TENDocGia], [GioiTinh], [NgaySinh], [DiaChi], [SoCMT], [MaLoaiDocGia], [MatKhau]) VALUES (N'17520077', N'Bill Gates', N'Nam', CAST(N'2000-01-01' AS Date), N'Microsoft Inc', N'245623754', N'103', N'1')
INSERT [dbo].[DocGia] ([MaDocGia], [TENDocGia], [GioiTinh], [NgaySinh], [DiaChi], [SoCMT], [MaLoaiDocGia], [MatKhau]) VALUES (N'17520088', N'Thor Odison', N'Nam', CAST(N'1952-08-01' AS Date), N'Asgard', N'190015701', N'101', N'1')
INSERT [dbo].[DocGia] ([MaDocGia], [TENDocGia], [GioiTinh], [NgaySinh], [DiaChi], [SoCMT], [MaLoaiDocGia], [MatKhau]) VALUES (N'17520099', N'Steve Rogers', N'Nam', CAST(N'1918-04-04' AS Date), N'Brooklyn, America', N'190015792', N'103', N'1')
INSERT [dbo].[DocGia] ([MaDocGia], [TENDocGia], [GioiTinh], [NgaySinh], [DiaChi], [SoCMT], [MaLoaiDocGia], [MatKhau]) VALUES (N'17520100', N'Beyoncé', N'Nữ', CAST(N'1981-09-4' AS Date), N'Texas, America', N'1276625344', N'101', N'1')
INSERT [dbo].[DocGia] ([MaDocGia], [TENDocGia], [GioiTinh], [NgaySinh], [DiaChi], [SoCMT], [MaLoaiDocGia], [MatKhau]) VALUES (N'22222222', N'Nguyễn Văn A', N'Nam', CAST(N'1984-06-18' AS Date), N'LegENDary Names', N'123433534', N'101', N'1')
INSERT [dbo].[DocGia] ([MaDocGia], [TENDocGia], [GioiTinh], [NgaySinh], [DiaChi], [SoCMT], [MaLoaiDocGia], [MatKhau]) VALUES (N'33333333', N'Phạm Thị B', N'Nữ', CAST(N'1994-02-08' AS Date), N'LegENDary Names', N'322112312', N'102', N'1')
INSERT [dbo].[DocGia] ([MaDocGia], [TENDocGia], [GioiTinh], [NgaySinh], [DiaChi], [SoCMT], [MaLoaiDocGia], [MatKhau]) VALUES (N'44444444', N'Tester', N'Nữ', CAST(N'2000-01-01' AS Date), N'Test City', N'7417233662', N'103', N'1')
INSERT [dbo].[DocGia] ([MaDocGia], [TENDocGia], [GioiTinh], [NgaySinh], [DiaChi], [SoCMT], [MaLoaiDocGia], [MatKhau]) VALUES (N'55555555', N'test', N'Nam', CAST(N'2000-01-01' AS Date), N'111111', N'111111', N'101', N'1')
INSERT [dbo].[DocGia] ([MaDocGia], [TENDocGia], [GioiTinh], [NgaySinh], [DiaChi], [SoCMT], [MaLoaiDocGia], [MatKhau]) VALUES (N'DG1', N'hoan', N'Nam', CAST(N'1990-07-12' AS Date), N'67', N'125', N'101', N'quamon')
INSERT [dbo].[LoaiDocGia] ([MaLoaiDocGia], [TenLoaiDocGia]) VALUES (N'101', N'Giảng Viên')
INSERT [dbo].[LoaiDocGia] ([MaLoaiDocGia], [TenLoaiDocGia]) VALUES (N'102', N'Sinh Viên')
INSERT [dbo].[LoaiDocGia] ([MaLoaiDocGia], [TenLoaiDocGia]) VALUES (N'103', N'Khách')
INSERT [dbo].[LoaiThe] ([MaLoaiThe], [TenLoaiThe]) VALUES (N'101', N'Giảng Viên')
INSERT [dbo].[LoaiThe] ([MaLoaiThe], [TenLoaiThe]) VALUES (N'102', N'Sinh Viên ')
INSERT [dbo].[LoaiThe] ([MaLoaiThe], [TenLoaiThe]) VALUES (N'103', N'Khách')
INSERT [dbo].[Nxb] ([MaNXB], [TenNXB], [GhiChu]) VALUES (N'1000', N'-----------------', N'Không rõ')
INSERT [dbo].[Nxb] ([MaNXB], [TenNXB], [GhiChu]) VALUES (N'1001', N'Khoa học kỹ thuật', N'')
INSERT [dbo].[Nxb] ([MaNXB], [TenNXB], [GhiChu]) VALUES (N'1002', N'Giáo dục', NULL)
INSERT [dbo].[Nxb] ([MaNXB], [TenNXB], [GhiChu]) VALUES (N'1003', N'Thống kê', N'')
INSERT [dbo].[Nxb] ([MaNXB], [TenNXB], [GhiChu]) VALUES (N'1004', N'Kim Đồng', NULL)
INSERT [dbo].[Nxb] ([MaNXB], [TenNXB], [GhiChu]) VALUES (N'1005', N'Trẻ', N'')
SET IDENTITY_INSERT [dbo].[PhieuMuon] ON 

INSERT [dbo].[PhieuMuon] ([SoPhieu], [MaThe], [MaSach], [NgayMuon], [NgayTra], [TinhTrang], [GhiChu]) VALUES (34, N'17521150', N'vv4096', CAST(N'2019-05-02' AS Date), CAST(N'2020-01-02' AS Date), N'Trễ hạn', N'')
INSERT [dbo].[PhieuMuon] ([SoPhieu], [MaThe], [MaSach], [NgayMuon], [NgayTra], [TinhTrang], [GhiChu]) VALUES (35, N'17521150', N'vv1982', CAST(N'2019-05-02' AS Date), CAST(N'2020-01-02' AS Date), N'Trễ hạn', N'')
INSERT [dbo].[PhieuMuon] ([SoPhieu], [MaThe], [MaSach], [NgayMuon], [NgayTra], [TinhTrang], [GhiChu]) VALUES (36, N'17521150', N'vn2001', CAST(N'2019-05-02' AS Date), CAST(N'2020-01-02' AS Date), N'Trễ hạn', N'')
INSERT [dbo].[PhieuMuon] ([SoPhieu], [MaThe], [MaSach], [NgayMuon], [NgayTra], [TinhTrang], [GhiChu]) VALUES (38, N'17521150', N'vn1001', CAST(N'2020-01-10' AS Date), CAST(N'2020-02-10' AS Date), N'Trễ hạn', N'')
INSERT [dbo].[PhieuMuon] ([SoPhieu], [MaThe], [MaSach], [NgayMuon], [NgayTra], [TinhTrang], [GhiChu]) VALUES (42, N'17521150', N'vn1021', CAST(N'2020-04-14' AS Date), CAST(N'2020-05-14' AS Date), N'Trễ hạn', N'')
INSERT [dbo].[PhieuMuon] ([SoPhieu], [MaThe], [MaSach], [NgayMuon], [NgayTra], [TinhTrang], [GhiChu]) VALUES (45, N'17520088', N'vn1187', CAST(N'2020-06-18' AS Date), CAST(N'2020-07-18' AS Date), N'Chưa trả', N'')
INSERT [dbo].[PhieuMuon] ([SoPhieu], [MaThe], [MaSach], [NgayMuon], [NgayTra], [TinhTrang], [GhiChu]) VALUES (46, N'17520088', N'vn2001', CAST(N'2020-06-18' AS Date), CAST(N'2020-07-18' AS Date), N'Chưa trả', N'')
INSERT [dbo].[PhieuMuon] ([SoPhieu], [MaThe], [MaSach], [NgayMuon], [NgayTra], [TinhTrang], [GhiChu]) VALUES (47, N'17520088', N'vn2317', CAST(N'2020-06-18' AS Date), CAST(N'2020-07-18' AS Date), N'Chưa trả', N'')
INSERT [dbo].[PhieuMuon] ([SoPhieu], [MaThe], [MaSach], [NgayMuon], [NgayTra], [TinhTrang], [GhiChu]) VALUES (48, N'17520077', N'vn1021', CAST(N'2020-06-18' AS Date), CAST(N'2020-07-18' AS Date), N'Chưa trả', N'')
INSERT [dbo].[PhieuMuon] ([SoPhieu], [MaThe], [MaSach], [NgayMuon], [NgayTra], [TinhTrang], [GhiChu]) VALUES (49, N'17520077', N'vn1187', CAST(N'2020-06-18' AS Date), CAST(N'2020-07-18' AS Date), N'Chưa trả', N'')
INSERT [dbo].[PhieuMuon] ([SoPhieu], [MaThe], [MaSach], [NgayMuon], [NgayTra], [TinhTrang], [GhiChu]) VALUES (50, N'17520514', N'vv1982', CAST(N'2020-06-18' AS Date), CAST(N'2020-07-18' AS Date), N'Đã trả', N'')
INSERT [dbo].[PhieuMuon] ([SoPhieu], [MaThe], [MaSach], [NgayMuon], [NgayTra], [TinhTrang], [GhiChu]) VALUES (53, N'17520514', N'vn1068', CAST(N'2020-06-28' AS Date), CAST(N'2020-07-28' AS Date), N'Chờ phê duyệt', N'')
INSERT [dbo].[PhieuMuon] ([SoPhieu], [MaThe], [MaSach], [NgayMuon], [NgayTra], [TinhTrang], [GhiChu]) VALUES (54, N'17520514', N'vn1187', CAST(N'2020-06-28' AS Date), CAST(N'2020-08-28' AS Date), N'Chờ phê duyệt', N'')
INSERT [dbo].[PhieuMuon] ([SoPhieu], [MaThe], [MaSach], [NgayMuon], [NgayTra], [TinhTrang], [GhiChu]) VALUES (55, N'17520514', N'vn2001', CAST(N'2020-06-28' AS Date), CAST(N'2020-08-28' AS Date), N'Chờ phê duyệt', N'')
SET IDENTITY_INSERT [dbo].[PhieuMuon] OFF
INSERT [dbo].[Sach] ([MaSach], [TenSach], [MaTacGia], [MaTheLoai], [MaNXB], [NamXuatBan], [SoTrang], [Gia], [SoBan], [SoBanTon]) VALUES (N'vn1001', N'Đường Các Mệnh', N'0070', N'102', N'1003', 1994, 200, 18000, 10, 9)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [MaTacGia], [MaTheLoai], [MaNXB], [NamXuatBan], [SoTrang], [Gia], [SoBan], [SoBanTon]) VALUES (N'vn1021', N'Cấu trúc dữ liệu & giải thuật', N'0010', N'104', N'1002', 2006, 320, 43000, 5, 3)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [MaTacGia], [MaTheLoai], [MaNXB], [NamXuatBan], [SoTrang], [Gia], [SoBan], [SoBanTon]) VALUES (N'vn1068', N'Tôi dại dột', N'0002', N'104', N'1005', 2015, 1, 1, 1, 1)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [MaTacGia], [MaTheLoai], [MaNXB], [NamXuatBan], [SoTrang], [Gia], [SoBan], [SoBanTon]) VALUES (N'vn1187', N'Thép đã tôi thế đấy', N'0012', N'101', N'1001', 2001, 478, 170000, 7, 5)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [MaTacGia], [MaTheLoai], [MaNXB], [NamXuatBan], [SoTrang], [Gia], [SoBan], [SoBanTon]) VALUES (N'vn2001', N'Số Đỏ', N'0069', N'107', N'1004', 1986, 232, 22000, 10, 8)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [MaTacGia], [MaTheLoai], [MaNXB], [NamXuatBan], [SoTrang], [Gia], [SoBan], [SoBanTon]) VALUES (N'vn2317', N'Nhật ký trong tù', N'0070', N'107', N'1004', 2007, 85, 42000, 12, 10)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [MaTacGia], [MaTheLoai], [MaNXB], [NamXuatBan], [SoTrang], [Gia], [SoBan], [SoBanTon]) VALUES (N'vn9821', N'Ruồi trâu', N'0005', N'101', N'1003', 1989, 215, 198000, 5, 5)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [MaTacGia], [MaTheLoai], [MaNXB], [NamXuatBan], [SoTrang], [Gia], [SoBan], [SoBanTon]) VALUES (N'vv1231', N'Đắc nhân tâm', N'0004', N'103', N'1005', 2015, 200, 86000, 10, 10)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [MaTacGia], [MaTheLoai], [MaNXB], [NamXuatBan], [SoTrang], [Gia], [SoBan], [SoBanTon]) VALUES (N'vv1982', N'Không gia đình', N'0068', N'101', N'1004', 2010, 440, 87000, 4, 3)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [MaTacGia], [MaTheLoai], [MaNXB], [NamXuatBan], [SoTrang], [Gia], [SoBan], [SoBanTon]) VALUES (N'vv4096', N'Thiên long bát bộ', N'0003', N'101', N'1005', 2002, 653, 120000, 2, 1)
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia], [GhiChu]) VALUES (N'0001', N'----------', N'không rõ')
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia], [GhiChu]) VALUES (N'0002', N'Dương Vũ', N'')
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia], [GhiChu]) VALUES (N'0003', N'Kim Dung', N'')
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia], [GhiChu]) VALUES (N'0004', N'Dale Carnegie', N'')
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia], [GhiChu]) VALUES (N'0005', N'Ethel Lilian Voynich', N'')
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia], [GhiChu]) VALUES (N'0010', N'Lê Minh Hoàng', N'')
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia], [GhiChu]) VALUES (N'0012', N'Nikolai Alekseyevich Ostrovsky', N'')
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia], [GhiChu]) VALUES (N'0066', N'Coding Horror', N'')
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia], [GhiChu]) VALUES (N'0067', N'Tô Hoài', N'')
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia], [GhiChu]) VALUES (N'0068', N'Hector Malott', N'')
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia], [GhiChu]) VALUES (N'0069', N'Vũ Trọng Phụng', N'')
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia], [GhiChu]) VALUES (N'0070', N'Nguyễn Ái Quốc', N'')
INSERT [dbo].[The] ([MaThe], [MaDocGia], [MaLoaiThe], [NgayCapThe], [NgayHetHan], [SoSachDuocMuon], [SoSachDangMuon]) VALUES (N'17520514', N'17520514', N'101', CAST(N'2020-04-28' AS Date), CAST(N'2021-05-28' AS Date), 8, 0)
INSERT [dbo].[The] ([MaThe], [MaDocGia], [MaLoaiThe], [NgayCapThe], [NgayHetHan], [SoSachDuocMuon], [SoSachDangMuon]) VALUES (N'17521199', N'17521199', N'102', CAST(N'2020-05-18' AS Date), CAST(N'2020-06-18' AS Date), 5, 0)
INSERT [dbo].[The] ([MaThe], [MaDocGia], [MaLoaiThe], [NgayCapThe], [NgayHetHan], [SoSachDuocMuon], [SoSachDangMuon]) VALUES (N'17521150', N'17521150', N'102', CAST(N'2019-11-02' AS Date), CAST(N'2020-11-02' AS Date), 5, 5)
INSERT [dbo].[The] ([MaThe], [MaDocGia], [MaLoaiThe], [NgayCapThe], [NgayHetHan], [SoSachDuocMuon], [SoSachDangMuon]) VALUES (N'17520251', N'17520251', N'102', CAST(N'2019-05-02' AS Date), CAST(N'2019-12-01' AS Date), 5, 1)
INSERT [dbo].[The] ([MaThe], [MaDocGia], [MaLoaiThe], [NgayCapThe], [NgayHetHan], [SoSachDuocMuon], [SoSachDangMuon]) VALUES (N'17520056', N'17520056', N'102', CAST(N'2020-04-28' AS Date), CAST(N'2020-05-28' AS Date), 5, 0)
INSERT [dbo].[The] ([MaThe], [MaDocGia], [MaLoaiThe], [NgayCapThe], [NgayHetHan], [SoSachDuocMuon], [SoSachDangMuon]) VALUES (N'17520067', N'17520067', N'103', CAST(N'2020-04-28' AS Date), CAST(N'2021-05-28' AS Date), 2, 0)
INSERT [dbo].[The] ([MaThe], [MaDocGia], [MaLoaiThe], [NgayCapThe], [NgayHetHan], [SoSachDuocMuon], [SoSachDangMuon]) VALUES (N'17520077', N'17520077', N'103', CAST(N'2020-04-28' AS Date), CAST(N'2021-05-28' AS Date), 2, 2)
INSERT [dbo].[The] ([MaThe], [MaDocGia], [MaLoaiThe], [NgayCapThe], [NgayHetHan], [SoSachDuocMuon], [SoSachDangMuon]) VALUES (N'17520088', N'17520088', N'101', CAST(N'2020-04-28' AS Date), CAST(N'2021-05-28' AS Date), 8, 3)
INSERT [dbo].[The] ([MaThe], [MaDocGia], [MaLoaiThe], [NgayCapThe], [NgayHetHan], [SoSachDuocMuon], [SoSachDangMuon]) VALUES (N'17520099', N'17520099', N'103', CAST(N'2020-04-28' AS Date), CAST(N'2021-05-28' AS Date), 2, 0)
INSERT [dbo].[The] ([MaThe], [MaDocGia], [MaLoaiThe], [NgayCapThe], [NgayHetHan], [SoSachDuocMuon], [SoSachDangMuon]) VALUES (N'17520100', N'17520100', N'101', CAST(N'2020-05-14' AS Date), CAST(N'2021-06-14' AS Date), 8, 0)
INSERT [dbo].[The] ([MaThe], [MaDocGia], [MaLoaiThe], [NgayCapThe], [NgayHetHan], [SoSachDuocMuon], [SoSachDangMuon]) VALUES (N'22222222', N'22222222', N'101', CAST(N'2019-11-02' AS Date), CAST(N'2020-12-01' AS Date), 8, 0)
INSERT [dbo].[The] ([MaThe], [MaDocGia], [MaLoaiThe], [NgayCapThe], [NgayHetHan], [SoSachDuocMuon], [SoSachDangMuon]) VALUES (N'33333333', N'33333333', N'102', CAST(N'2019-11-02' AS Date), CAST(N'2019-12-01' AS Date), 5, 0)
INSERT [dbo].[The] ([MaThe], [MaDocGia], [MaLoaiThe], [NgayCapThe], [NgayHetHan], [SoSachDuocMuon], [SoSachDangMuon]) VALUES (N'44444444', N'44444444', N'103', CAST(N'2020-01-08' AS Date), CAST(N'2021-01-08' AS Date), 2, 0)
INSERT [dbo].[The] ([MaThe], [MaDocGia], [MaLoaiThe], [NgayCapThe], [NgayHetHan], [SoSachDuocMuon], [SoSachDangMuon]) VALUES (N'DG1', N'DG1', N'101', CAST(N'2019-07-19' AS Date), CAST(N'2020-08-19' AS Date), 8, 0)
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai]) VALUES (N'100', N'----------')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai]) VALUES (N'101', N'Tiểu thuyết')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai]) VALUES (N'102', N'Giáo trình')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai]) VALUES (N'103', N'Sách tham khảo')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai]) VALUES (N'104', N'Công nghệ thông tin')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai]) VALUES (N'105', N'Điện')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai]) VALUES (N'106', N'Tài chính')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai]) VALUES (N'107', N'Truyện')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai]) VALUES (N'108', N'Tạp chí')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai]) VALUES (N'109', N'Vật lý')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai]) VALUES (N'110', N'Hóa học')
ALTER TABLE [dbo].[DocGia]  WITH CHECK ADD  CONSTRAINT [FK_DocGia_LoaiDocGia] FOREIGN KEY([MaLoaiDocGia])
REFERENCES [dbo].[LoaiDocGia] ([MaLoaiDocGia])
GO
ALTER TABLE [dbo].[DocGia] CHECK CONSTRAINT [FK_DocGia_LoaiDocGia]
GO
ALTER TABLE [dbo].[PhieuMuon]  WITH CHECK ADD  CONSTRAINT [FK_PhieuMuon_Sach] FOREIGN KEY([MaSach])
REFERENCES [dbo].[Sach] ([MaSach])
GO
ALTER TABLE [dbo].[PhieuMuon] CHECK CONSTRAINT [FK_PhieuMuon_Sach]
GO
ALTER TABLE [dbo].[PhieuMuon]  WITH CHECK ADD  CONSTRAINT [FK_PhieuMuon_The1] FOREIGN KEY([MaThe])
REFERENCES [dbo].[The] ([MaThe])
GO
ALTER TABLE [dbo].[PhieuMuon] CHECK CONSTRAINT [FK_PhieuMuon_The1]
GO
ALTER TABLE [dbo].[Sach]  WITH CHECK ADD  CONSTRAINT [FK_Sach_Nxb] FOREIGN KEY([MaNXB])
REFERENCES [dbo].[Nxb] ([MaNXB])
GO
ALTER TABLE [dbo].[Sach] CHECK CONSTRAINT [FK_Sach_Nxb]
GO
ALTER TABLE [dbo].[Sach]  WITH CHECK ADD  CONSTRAINT [FK_Sach_TacGia] FOREIGN KEY([MaTacGia])
REFERENCES [dbo].[TacGia] ([MaTacGia])
GO
ALTER TABLE [dbo].[Sach] CHECK CONSTRAINT [FK_Sach_TacGia]
GO
ALTER TABLE [dbo].[Sach]  WITH CHECK ADD  CONSTRAINT [FK_Sach_TheLoai] FOREIGN KEY([MaTheLoai])
REFERENCES [dbo].[TheLoai] ([MaTheLoai])
GO
ALTER TABLE [dbo].[Sach] CHECK CONSTRAINT [FK_Sach_TheLoai]
GO
ALTER TABLE [dbo].[The]  WITH CHECK ADD  CONSTRAINT [FK_The_DocGia] FOREIGN KEY([MaDocGia])
REFERENCES [dbo].[DocGia] ([MaDocGia])
GO
ALTER TABLE [dbo].[The] CHECK CONSTRAINT [FK_The_DocGia]
GO
ALTER TABLE [dbo].[The]  WITH CHECK ADD  CONSTRAINT [FK_The_LoaiThe] FOREIGN KEY([MaLoaiThe])
REFERENCES [dbo].[LoaiThe] ([MaLoaiThe])
GO
ALTER TABLE [dbo].[The] CHECK CONSTRAINT [FK_The_LoaiThe]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_demSoPhieuMuonChoDuyet]
AS
BEGIN
	select count (*) from PhieuMuon where (TinhTrang = N'Chờ phê duyệt' 
										or TinhTrang = N'Chờ duyệt trả'
										or TinhTrang = N'Chờ duyệt trả trễ')
END

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_demSoPhieuMuonTheoMaThe]
	@mathe varchar(10)
AS
BEGIN
	select count (*) from PhieuMuon where MaThe = @mathe and TinhTrang = N'Chờ phê duyệt'
END

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_demSoPhieuMuonTheoMaTheVaMaSach]
	@mathe varchar(10),
	@masach varchar(10)
AS
BEGIN
	select count (*) from PhieuMuon where MaThe = @mathe and MaSach = @masach and TinhTrang != N'Đã trả' and TinhTrang != N'Trả trễ'
END

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_demSoPhieuMuonTreHan]
AS
BEGIN
	select count (*) from PhieuMuon where (TinhTrang = N'Trễ hạn')
END

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-------------------------------------------------------
CREATE PROCEDURE [dbo].[sp_demSoTheTheoTen]
	@madocgia varchar(10)
AS
BEGIN
	select count (*) from The where MaDocGia = @madocgia
END

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_doiMK]
	@tendangnhap nvarchar(20),
	@matkhau nvarchar(20)
AS
BEGIN
	update DangNhap
	set MatKhau = @matkhau
	where TenDangNhap = @tendangnhap
END

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_duyetPhieuMuon]
	@sophieu int,
	@mathe varchar(10),
	@masach varchar(10)
AS
BEGIN
	update PhieuMuon
	set TinhTrang = N'Chưa trả'
	where SoPhieu = @sophieu

	update Sach
	set SoBanTon = SoBanTon - 1
	where MaSach = @masach

	update The
	set SoSachDangMuon = SoSachDangMuon + 1
	where MaThe = @mathe
END

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_duyetYeuCauTraSach]
	@sophieu int,
	@mathe varchar(10),
	@masach varchar(10)
AS
BEGIN
	update PhieuMuon
	set TinhTrang = N'Đã trả'
	where SoPhieu = @sophieu and TinhTrang = N'Chờ duyệt trả'

	update PhieuMuon
	set TinhTrang = N'Trả trễ'
	where SoPhieu = @sophieu and TinhTrang = N'Chờ duyệt trả trễ'

	update Sach
	set SoBanTon = SoBanTon + 1
	where MaSach = @masach

	update The
	set SoSachDangMuon = SoSachDangMuon - 1
	where MaThe = @mathe
END

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_kiemTraHanPhieuMuon]
	@ngaykiemtra date
AS
BEGIN
	update PhieuMuon
	set TinhTrang = N'Trễ hạn'
	where TinhTrang = N'Chưa trả' and NgayTra < @ngaykiemtra
END

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_layMaDocGiaTheoTenDocGia]
	@tendocgia nvarchar(50)
AS
BEGIN
	Select MaDocGia from DocGia  where (CHARINDEX(@tendocgia,TenDocGia,0) != 0)
END

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_layMaSachTheoTenSach]
	@tensach nvarchar(100)
AS
BEGIN
	Select MaSach from Sach  where (CHARINDEX(@tensach,TenSach,0) != 0)
END

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_layMaTheTheoMaDG]
	@madocgia varchar(10)
AS
BEGIN
	Select MaThe from The where MaDocGia = @madocgia
END

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_layNgayHetHan]
	@mathe varchar(10)
AS
BEGIN
	Select NgayHetHan from The where MaThe = @mathe
END

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_laySoSachDangMuon]
	@mathe varchar(10)
AS
BEGIN
	Select SoSachDangMuon from The where MaThe = @mathe
END

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_laySoSachDuocMuon]
	@mathe varchar(10)
AS
BEGIN
	Select SoSachDuocMuon from The where MaThe = @mathe
END

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_layTenDocGia]
	@madocgia varchar(10)
AS
BEGIN
	select TenDocGia from DocGia where MaDocGia = @madocgia
END

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_layTenNXB] 
	@maNXB varchar(10)
AS	
BEGIN
	Select TenNXB from Nxb where MaNXB = @maNXB
END

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_layTenSach]
	@masach varchar(10)
AS
BEGIN
	select TenSach from Sach where MaSach = @masach
END

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_layTenTacGia]
	@matacgia varchar(10)
AS
BEGIN
	Select TenTacGia from TacGia where MaTacGia = @matacgia
END

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_layTenTheLoai]
	@matheloai varchar(10)
AS
BEGIN
	Select TenTheLoai from TheLoai where MaTheLoai = @matheloai
END

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_loadDSSachDangMuonTheoMaThe]
	@mathe varchar(10)
AS
BEGIN
	Select * from PhieuMuon, Sach where MaThe = @mathe and ( TinhTrang = N'Chưa trả' or TinhTrang = N'Trễ hạn' ) and PhieuMuon.MaSach = Sach.MaSach
END

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_loadPhieuMuonChoDuyetTra]
AS
BEGIN
	Select * from PhieuMuon where TinhTrang = N'Chờ duyệt trả' or TinhTrang = N'Chờ duyệt trả trễ'
END

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_loadTatCaDocGia]
AS
BEGIN
	select * from DocGia
END

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_loadTatCaLoaiDocGia]
AS
BEGIN
	select * from LoaiDocGia
END

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_loadTatCaLoaiThe]
AS
BEGIN
	select * from LoaiThe
END

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_loadTatCaNXB]
AS
BEGIN
	select * from Nxb
END

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_loadTatCaPhieuMuon]
AS
BEGIN
	select * from PhieuMuon
END

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_loadTatCaPhieuMuonChuaTra]
AS
BEGIN
	select * from PhieuMuon where TinhTrang = N'Chưa trả' or TinhTrang = N'Trễ hạn'
END

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_loadTatCaPhieuMuonDaTra]
AS
BEGIN
	Select * from PhieuMuon  where (TinhTrang = N'Đã trả' or TinhTrang = N'Trả trễ')
END

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_loadTatCaSach]
AS
BEGIN
	select * from Sach
END

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_loadTatCaTacGia]
AS
BEGIN
	select * from TacGia
END

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_loadTatCaThe]
AS
BEGIN
	select * from The
END

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_loadTatCaTheLoai]
AS
BEGIN
	select * from TheLoai
END

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_loadTTPhieuMuonTheoMaTheVaMaSach]
	@mathe varchar(10),
	@masach varchar(10)
AS
BEGIN
	Select * from PhieuMuon, Sach where MaThe = @mathe and Sach.MaSach = @masach and ( TinhTrang = N'Chưa trả' or TinhTrang = N'Trễ hạn' ) and PhieuMuon.MaSach = Sach.MaSach
END

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_loaiTaiKhoan]
	@tendn nvarchar(20),
	@mk nvarchar(20)
AS
BEGIN
	select LoaiTaiKhoan from DangNhap where TenDangNhap = @tendn and MatKhau = @mk
END

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_suaDocGia]
	@madocgia varchar(10),
	@tendocgia nvarchar(50),
	@gioitinh nvarchar(10),
	@ngaysinh date,
	@diachi nvarchar(100),
	@socmt varchar(10),
	@loaidocgia varchar(10),
	@matkhau nvarchar(50)
AS
BEGIN
	update DocGia
	set
		TenDocGia = @tendocgia,
		GioiTinh = @gioitinh,
		NgaySinh = @ngaysinh,
		DiaChi = @diachi,
		SoCMT = @socmt,
		MaLoaiDocGia = @loaidocgia,
		MatKhau = @matkhau
	where MaDocGia = @madocgia
END

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_suaNXB]
	@manxb varchar(10),
	@tennxb nvarchar(50),
	@ghichu nvarchar(1500)
AS
BEGIN
	update Nxb
	set 
		TenNXB = @tennxb,
		GhiChu = @ghichu
	where MaNXB = @manxb	
END

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_suaPhieuMuonDangCho]
	@sophieu int,
	@ngaymuon date,
	@ngaytra date,
	@ghichu nvarchar(500)
AS
BEGIN
	update PhieuMuon
	set
		NgayMuon = @ngaymuon,
		NgayTra = @ngaytra,
		GhiChu = @ghichu
	where SoPhieu = @sophieu
END

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_suaSach]
	@masach varchar(10),
	@tensach nvarchar(100),
	@matacgia varchar(10),
	@matheloai varchar(10),
	@manhaxuatban varchar(10),
	@namxuatban int,
	@sotrang int,
	@gia int,
	@soban int,
	@sobanton int
AS
BEGIN
	update Sach
	set 
		TenSach = @tensach,
		MaTacGia = @matacgia,
		MaTheLoai = @matheloai,
		MaNXB = @manhaxuatban,
		NamXuatBan = @namxuatban,
		SoTrang = @sotrang,
		Gia = @gia,
		SoBan = @soban,
		SoBanTon = @sobanton
	where MaSach = @masach
END

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_suaTG]
	@matacgia varchar(10),
	@tentacgia nvarchar(50),
	@ghichu nvarchar(1500)
AS
BEGIN
	update TacGia
	set
		TenTacGia = @tentacgia,
		GhiChu = @ghichu
	where MaTacGia = @matacgia

END

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-------------------------------------------------------
CREATE PROCEDURE [dbo].[sp_suaThe]
	@mathe varchar(10),
	@madocgia varchar(10),
	@maloaithe varchar(10),
	@ngaycapthe date,
	@ngayhethan date,
	@sosachduocmuon int,
	@sosachdangmuon int
AS
BEGIN
	update The
	set
		MaDocGia = @madocgia,
		MaLoaiThe = @maloaithe,
		NgayCapThe = @ngaycapthe,
		NgayHetHan = @ngayhethan,
		SoSachDuocMuon = @sosachduocmuon,
		SoSachDangMuon = @sosachdangmuon
	where MaThe = @mathe
END

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_suaTheLoai]
	@matheloai varchar(10),
	@tentheloai nvarchar(50)
AS
BEGIN
	update TheLoai
	set 
		TenTheLoai = @tentheloai
	where MaTheLoai = @matheloai	
END

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-------------------------------------------------------
CREATE PROCEDURE [dbo].[sp_suaUser]
	@uid nvarchar(20),
	@pwd nvarchar(50),
	@type int
AS
BEGIN
	update DangNhap
	set
		MatKhau = @pwd,
		LoaiTaiKhoan = @type
	where TenDangNhap = @uid
END

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_taoMoiTK]
	@tendangnhap nvarchar(20),
	@matkhau nvarchar(20)
AS
BEGIN
	insert into DangNhap values(@tendangnhap, @matkhau, 1)
END

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_themDocGia]
	@madocgia varchar(10),
	@tendocgia nvarchar(50),
	@gioitinh nvarchar(10),
	@ngaysinh date,
	@diachi nvarchar(100),
	@socmt varchar(10),
	@loaidocgia varchar(10),
	@matkhau nvarchar(50)
AS
BEGIN
	insert into DocGia values(@madocgia,@tendocgia,@gioitinh,@ngaysinh,@diachi,@socmt,@loaidocgia,@matkhau)
END

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_themNXB]
	@manxb varchar(10),
	@tennxb nvarchar(50),
	@ghichu nvarchar(1500)
AS
BEGIN
	insert into Nxb values(@manxb,@tennxb,@ghichu)
END

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_themPhieuMuon]
	@mathe varchar(10),
	@masach varchar(10),
	@ngaymuon date,
	@ngaytra date,
	@tinhtrang nvarchar(20),
	@ghichu nvarchar(500)
AS
BEGIN
	insert into PhieuMuon values(@mathe,@masach,@ngaymuon,@ngaytra,@tinhtrang,@ghichu)
END

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-------------------------------------------------------
CREATE PROCEDURE [dbo].[sp_themSach]
	@masach varchar(10),
	@tensach nvarchar(100),
	@matacgia varchar(10),
	@matheloai varchar(10),
	@manhaxuatban varchar(10),
	@namxuatban int,
	@sotrang int,
	@gia int,
	@soban int,
	@sobanton int
AS
BEGIN
	insert into Sach values(@masach,@tensach,@matacgia,@matheloai,@manhaxuatban,@namxuatban,@sotrang,@gia,@soban,@sobanton)
END

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_themTG]
	@matacgia varchar(10),
	@tentacgia nvarchar(50),
	@ghichu nvarchar(1500)
AS
BEGIN
	insert into TacGia values(@matacgia,@tentacgia,@ghichu)
END

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_themThe]
	@mathe varchar(10),
	@madocgia varchar(10),
	@maloaithe varchar(10),
	@ngaycapthe date,
	@ngayhethan date,
	@sosachduocmuon int,
	@sosachdangmuon int
AS
BEGIN
	insert into The values(@mathe,@madocgia,@maloaithe,@ngaycapthe,@ngayhethan,@sosachduocmuon,@sosachdangmuon)
END

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_themTheLoai]
	@matheloai varchar(10),
	@tentheloai nvarchar(50)
AS
BEGIN
	insert into TheLoai values(@matheloai,@tentheloai)
END

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_themUser]
	@uid nvarchar(20),
	@pwd nvarchar(50),
	@type int
AS
BEGIN
	insert into DangNhap values(@uid,@pwd,@type)
END

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_timKiemPhieuMuonDaTraTheoMaSach]
	@masach	varchar(10)
AS
BEGIN
	Select * from PhieuMuon  where ((CHARINDEX(@masach,MaSach,0) != 0) and (TinhTrang = N'Đã trả' or TinhTrang = N'Trả trễ'))
END

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_timKiemPhieuMuonDaTraTheoMaThe]
	@mathe varchar(10)
AS
BEGIN
	Select * from PhieuMuon  where ((CHARINDEX(@mathe,MaThe,0) != 0) and (TinhTrang = N'Đã trả' or TinhTrang = N'Trả trễ'))
END

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_timKiemPhieuMuonDaTraTheoSoPhieu]
	@sophieu int
AS
BEGIN
	Select * from PhieuMuon  where (SoPhieu = @sophieu and (TinhTrang = N'Đã trả' or TinhTrang = N'Trả trễ'))
END

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_timKiemPhieuMuonTheoMaSach]
	@masach	varchar(10)
AS
BEGIN
	Select * from PhieuMuon  where (CHARINDEX(@masach,MaSach,0) != 0)
END

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_timKiemPhieuMuonTheoMaThe]
	@mathe varchar(10)
AS
BEGIN
	Select * from PhieuMuon  where (CHARINDEX(@mathe,MaThe,0) != 0)
END

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_timKiemPhieuMuonTheoSoPhieu]
	@sophieu int
AS
BEGIN
	Select * from PhieuMuon  where SoPhieu = @sophieu
END

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_timKiemPhieuMuonTheoTinhTrang]
	@tinhtrang  nvarchar(20)
AS
BEGIN
	Select * from PhieuMuon  where (CHARINDEX(@tinhtrang,TinhTrang,0) != 0)
END

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_timKiemTheoMaSach]
	@masach varchar(10)
AS
BEGIN
	Select * from Sach  where (CHARINDEX(@masach,MaSach,0) != 0)
END

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_timKiemTheoNamXB]
	@namxb int
AS
BEGIN
	select * from sach where NamXuatBan = @namxb
END

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_timKiemTheoNXB]
	@tennxb nvarchar(50)
AS
BEGIN
	Select * from Sach where MaNXB = (Select TOP 1 (MaNXB) from Nxb where (CHARINDEX(@tennxb,TenNXB,0) != 0))
END

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_timKiemTheoTenSach]
	@tensach nvarchar(100)
AS
BEGIN
	Select * from Sach  where (CHARINDEX(@tensach,TenSach,0) != 0)
END

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_timKiemTheoTenTG]
	@tentacgia nvarchar(50)
AS
BEGIN
	Select * from Sach where MaTacGia = (Select TOP 1 (MaTacGia) from TacGia where (CHARINDEX(@tenTacGia,TenTacGia,0) != 0))
END

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_timKiemTheoTheLoai]
	@tentheloai nvarchar(50)
AS
BEGIN
	Select * from Sach where MaTheLoai = (Select TOP 1 (MaTheLoai) from TheLoai where (CHARINDEX(@tentheloai,TenTheLoai,0) != 0))
END

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_tuChoiPhieuMuon]
	@sophieu int
AS
BEGIN
	delete from PhieuMuon where SoPhieu = @sophieu
END

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_tuChoiTraSach]
	@sophieu int
AS
BEGIN
	update PhieuMuon
	set TinhTrang = N'Chưa trả'
	where SoPhieu = @sophieu and TinhTrang = N'Chờ duyệt trả'

	update PhieuMuon
	set TinhTrang = N'Trễ hạn'
	where SoPhieu = @sophieu and TinhTrang = N'Chờ duyệt trả trễ'
END

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_xoaDocGia]
	@madocgia varchar(10)
AS
BEGIN
	delete from DocGia where MaDocGia = @madocgia
END

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_xoaNXB]
	@manxb varchar(10)
AS
BEGIN
	delete from Nxb where MaNXB = @manxb
END

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_xoaPhieuMuon]
	@sophieu int
AS
BEGIN
	delete from PhieuMuon where SoPhieu = @sophieu
END

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_xoaSach]
	@masach varchar(10)
AS
BEGIN
	delete from sach where MaSach = @masach
END

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_xoaTG]
	@matacgia varchar(10)
AS
BEGIN
	delete from TacGia where MaTacGia = @matacgia
END

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-------------------------------------------------------
CREATE PROCEDURE [dbo].[sp_xoaThe]
	@madocgia varchar(10)
AS
BEGIN
	delete from The where MaDocGia = @madocgia
END

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-------------------------------------------------------
CREATE PROCEDURE [dbo].[sp_xoaThe1]
	@mathe varchar(10)
AS
BEGIN
	delete from The where MaThe = @mathe
END

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_xoaTheLoai]
	@matheloai varchar(10)
AS
BEGIN
	delete from TheLoai where MaTheLoai = @matheloai
END

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_xoaUser]
	@uid nvarchar(20)
AS
BEGIN
	delete from DangNhap where TenDangNhap = @uid
END

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_yeuCauTraSach]
	@sophieu int
AS
BEGIN
	update PhieuMuon
	set TinhTrang = N'Chờ duyệt trả'
	where SoPhieu = @sophieu and TinhTrang = N'Chưa trả'

	update PhieuMuon
	set TinhTrang = N'Chờ duyệt trả trễ'
	where SoPhieu = @sophieu and TinhTrang = N'Trễ hạn'
END

GO
