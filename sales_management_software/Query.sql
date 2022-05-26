/****** =================================== Script Date: 25/5/2022 4:16:36 PM =================================== ******/

-- Mốt muốn bổ sung thì copy cái dòng comment phía trên, sửa ngày giờ lại, ghi thêm vào chỗ bổ sung để phân biệt
-- Phân biệt để mn tự biết nó ở đâu mà tải về

-- master
USE [master]
CREATE DATABASE [Sale_Management]

-- Sale_Management 
GO
USE [Sale_Management]
GO
/****** Object:  Table [dbo].[DON_HANG]    Script Date: 25/5/2022 4:16:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DON_HANG](
	[madh] [char](5) NOT NULL,
	[mahd] [char](5) NULL,
	[makh] [char](5) NOT NULL,
	[manv] [char](5) NOT NULL,
	[mashiper] [char](5) NOT NULL,
	[ngaydat] [date] NULL,
	[ngaygiao] [date] NULL,
	[diachigiao] [nvarchar](50) NULL,
	[deleted] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[madh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HOA_DON]    Script Date: 25/5/2022 4:16:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOA_DON](
	[mahd] [char](5) NOT NULL,
	[masp] [char](5) NOT NULL,
	[tensp] [nvarchar](30) NULL,
	[dongia] [int] NULL,
	[giamgia] [int] NULL,
	[soluong] [int] NULL,
	[tongtien] [int] NULL,
	[deleted] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[mahd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KHACH_HANG]    Script Date: 25/5/2022 4:16:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHACH_HANG](
	[makh] [char](5) NOT NULL,
	[tenkh] [nvarchar](30) NOT NULL,
	[sdt] [char](10) NULL,
	[diachi] [nvarchar](50) NULL,
	[deleted] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[makh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KHO_HANG]    Script Date: 25/5/2022 4:16:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHO_HANG](
	[makho] [char](5) NOT NULL,
	[tenkho] [nvarchar](30) NULL,
	[masp] [char](5) NOT NULL,
	[soluongtonkho] [int] NULL,
	[deleted] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[makho] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LOAI_SAN_PHAM]    Script Date: 25/5/2022 4:16:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAI_SAN_PHAM](
	[maloai] [char](5) NOT NULL,
	[tenloai] [nvarchar](30) NULL,
	[deleted] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[maloai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHA_CUNG_CAP]    Script Date: 25/5/2022 4:16:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHA_CUNG_CAP](
	[maNCC] [char](10) NOT NULL,
	[tencty] [nvarchar](30) NULL,
	[diachi] [nvarchar](50) NULL,
	[sdt] [char](10) NULL,
	[deleted] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[maNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHAN_VIEN]    Script Date: 25/5/2022 4:16:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHAN_VIEN](
	[manv] [char](5) NOT NULL,
	[matkhau] [varchar](15) NULL,
	[hotennv] [nvarchar](30) NOT NULL,
	[sdt] [char](10) NULL,
	[diachi] [nvarchar](50) NULL,
	[deleted] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[manv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SAN_PHAM]    Script Date: 25/5/2022 4:16:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SAN_PHAM](
	[masp] [char](5) NOT NULL,
	[tensp] [nvarchar](30) NOT NULL,
	[dongia] [int] NULL,
	[soluong] [int] NULL,
	[maNCC] [char](10) NULL,
	[maloai] [char](5) NULL,
	[deleted] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[masp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SHIPPER]    Script Date: 25/5/2022 4:16:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SHIPPER](
	[mashiper] [char](5) NOT NULL,
	[tenshipper] [nvarchar](30) NOT NULL,
	[madh] [char](5) NOT NULL,
	[sdt] [char](10) NULL,
	[deleted] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[mashiper] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[THONG_SO_KY_THUAT]    Script Date: 25/5/2022 4:16:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THONG_SO_KY_THUAT](
	[mats] [char](5) NOT NULL,
	[tents] [nvarchar](30) NULL,
	[masp] [char](5) NULL,
	[giatri] [varchar](10) NULL,
	[deleted] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[mats] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[LOAI_SAN_PHAM] ([maloai], [tenloai], [deleted]) VALUES (N'DTH  ', N'Điện thoại', 0)
INSERT [dbo].[LOAI_SAN_PHAM] ([maloai], [tenloai], [deleted]) VALUES (N'LAP  ', N'Laptop', 0)
GO
INSERT [dbo].[NHA_CUNG_CAP] ([maNCC], [tencty], [diachi], [sdt], [deleted]) VALUES (N'HP        ', N'HP Company', N'New York', N'0969696960', 0)
INSERT [dbo].[NHA_CUNG_CAP] ([maNCC], [tencty], [diachi], [sdt], [deleted]) VALUES (N'OPPO      ', N'Oppo Company', N'Xiang Chiao', N'0690966969', 0)
GO
INSERT [dbo].[SAN_PHAM] ([masp], [tensp], [dongia], [soluong], [maNCC], [maloai], [deleted]) VALUES (N'SP001', N'Oppo Reno 7', 7990000, 20, N'OPPO      ', N'DTH  ', 0)
INSERT [dbo].[SAN_PHAM] ([masp], [tensp], [dongia], [soluong], [maNCC], [maloai], [deleted]) VALUES (N'SP002', N'HP Envy 13', 23990000, 8, N'HP        ', N'LAP  ', 0)
GO
ALTER TABLE [dbo].[DON_HANG]  WITH CHECK ADD  CONSTRAINT [FK_DON_HANG_HOA_DON] FOREIGN KEY([mahd])
REFERENCES [dbo].[HOA_DON] ([mahd])
GO
ALTER TABLE [dbo].[DON_HANG] CHECK CONSTRAINT [FK_DON_HANG_HOA_DON]
GO
ALTER TABLE [dbo].[DON_HANG]  WITH CHECK ADD  CONSTRAINT [FK_makh] FOREIGN KEY([makh])
REFERENCES [dbo].[KHACH_HANG] ([makh])
GO
ALTER TABLE [dbo].[DON_HANG] CHECK CONSTRAINT [FK_makh]
GO
ALTER TABLE [dbo].[DON_HANG]  WITH CHECK ADD  CONSTRAINT [FK_manv] FOREIGN KEY([manv])
REFERENCES [dbo].[NHAN_VIEN] ([manv])
GO
ALTER TABLE [dbo].[DON_HANG] CHECK CONSTRAINT [FK_manv]
GO
ALTER TABLE [dbo].[KHO_HANG]  WITH CHECK ADD  CONSTRAINT [FK_masp_KhoHang] FOREIGN KEY([masp])
REFERENCES [dbo].[SAN_PHAM] ([masp])
GO
ALTER TABLE [dbo].[KHO_HANG] CHECK CONSTRAINT [FK_masp_KhoHang]
GO
ALTER TABLE [dbo].[SAN_PHAM]  WITH CHECK ADD  CONSTRAINT [FK_SAN_PHAM_LOAI_SAN_PHAM] FOREIGN KEY([maloai])
REFERENCES [dbo].[LOAI_SAN_PHAM] ([maloai])
GO
ALTER TABLE [dbo].[SAN_PHAM] CHECK CONSTRAINT [FK_SAN_PHAM_LOAI_SAN_PHAM]
GO
ALTER TABLE [dbo].[SAN_PHAM]  WITH CHECK ADD  CONSTRAINT [FK_SAN_PHAM_NHA_CUNG_CAP] FOREIGN KEY([maNCC])
REFERENCES [dbo].[NHA_CUNG_CAP] ([maNCC])
GO
ALTER TABLE [dbo].[SAN_PHAM] CHECK CONSTRAINT [FK_SAN_PHAM_NHA_CUNG_CAP]
GO
ALTER TABLE [dbo].[SHIPPER]  WITH CHECK ADD  CONSTRAINT [FK_madh] FOREIGN KEY([madh])
REFERENCES [dbo].[DON_HANG] ([madh])
GO
ALTER TABLE [dbo].[SHIPPER] CHECK CONSTRAINT [FK_madh]
GO
ALTER TABLE [dbo].[THONG_SO_KY_THUAT]  WITH CHECK ADD  CONSTRAINT [FK_masp_ThongSoKyThuat] FOREIGN KEY([masp])
REFERENCES [dbo].[SAN_PHAM] ([masp])
GO
ALTER TABLE [dbo].[THONG_SO_KY_THUAT] CHECK CONSTRAINT [FK_masp_ThongSoKyThuat]
GO
/****** Object:  StoredProcedure [dbo].[Insert_sp]    Script Date: 25/5/2022 4:16:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--HAM INSERT
CREATE PROC [dbo].[Insert_sp]
(
@masp CHAR(5), 
@tensp NVARCHAR(30), 
@dongia INT,
@soluong INT,
@maNCC CHAR(10),
@maloai CHAR(5),
@deleted BIT
)
as
begin 
insert into SAN_PHAM
values (@masp, @tensp, @dongia, @soluong, @maNCC, @maloai, @deleted);
end

 

GO
/****** Object:  StoredProcedure [dbo].[Select_kho]    Script Date: 25/5/2022 4:16:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[Select_kho]
as
begin
select* from KHO_HANG
end
GO
/****** Object:  StoredProcedure [dbo].[Select_lsp]    Script Date: 25/5/2022 4:16:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--LOAISANPHAM
CREATE PROC [dbo].[Select_lsp]
as
begin
select*from LOAI_SAN_PHAM;
end
GO
/****** Object:  StoredProcedure [dbo].[Select_ncc]    Script Date: 25/5/2022 4:16:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--KHO
CREATE PROC [dbo].[Select_ncc]
as
begin
select *from NHA_CUNG_CAP
end

GO
/****** Object:  StoredProcedure [dbo].[Select_sp]    Script Date: 25/5/2022 4:16:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--HAM SELECT
CREATE PROC [dbo].[Select_sp]
as
begin
select*from SAN_PHAM;
end
GO
/****** Object:  StoredProcedure [dbo].[Update_sp]    Script Date: 25/5/2022 4:16:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--HAM UPDATE
CREATE PROC [dbo].[Update_sp]
(
@masp CHAR(5), 
@tensp NVARCHAR(30), 
@dongia INT,
@soluong INT,
@maNCC CHAR(10),
@maloai CHAR(5),
@deleted BIT
)
as
begin 
UPDATE  SAN_PHAM
SET tensp = @tensp, dongia = @dongia, soluong = @soluong, maNCC = @maNCC, maloai = @maloai, deleted = @deleted
WHERE masp = @masp
end
GO
USE [master]
GO
ALTER DATABASE [Sale_Management] SET  READ_WRITE 
GO

/****** =================================== Script Date: 25/5/2022 9:25:36 PM =================================== ******/
CREATE PROC select_Dangnhap
as
begin
select*from NHAN_VIEN
end

ALTER TABLE NHAN_VIEN DROP COLUMN soluong
ALTER TABLE NHAN_VIEN DROP COLUMN maNCC
ALTER TABLE NHAN_VIEN DROP COLUMN maloai
ALTER TABLE NHAN_VIEN DROP COLUMN dongia

-- Tạo info nhân viên
GO
INSERT [dbo].[NHAN_VIEN] ([manv], [matkhau], [hotennv], [sdt], [diachi], [deleted]) VALUES (N'NV001', N'trung123', N'Nguyễn Như Trung', N'0386435145', N'Nguyễn Tri Phương', 0)

GO
CREATE PROC Insert_ncc
 (
 @maNCC CHAR(10),
 @tencty NVARCHAR(30),
 @diachi nvarchar(50),
 @sdt char(10),
 @deleted BIT
 )
 as
 begin 
insert into NHA_CUNG_CAP
values (@maNCC, @tencty, @diachi, @sdt, @deleted);
end

-- Tìm kiếm sản phẩm
GO
CREATE PROC Search_SanPham
@tukhoa nvarchar(50)
as
select tensp, maloai, maNCC
from SAN_PHAM
where 
	lower(tensp) like '%' + lower(trim(@tukhoa)) + '%'
	or lower(maNCC) like '%' + lower(trim(@tukhoa)) + '%'
	or lower(maloai) like '%' + lower(trim(@tukhoa)) + '%'
order by tensp, maloai, maNCC

--insert loại sản phẩm lúc 13h ngày 26-5

GO
CREATE PROC Insert_lsp
 (
 @maloai CHAR(10),
 @tenloai NVARCHAR(30),
 @deleted BIT
 )
 as
 begin 
insert into LOAI_SAN_PHAM
values (@maloai, @tenloai, @deleted);
end