use master
go

if not exists (select * from sys.databases where name = 'QLKS')
begin
	create database QLKS
end
go

use QLKS
go
------------------------------------------------------------------

----- drop constraints
-- table PhieuDatPhong
if exists (select *
		   from sys.tables
		   where SCHEMA_NAME(schema_id) like 'dbo' and name like 'PhieuDatPhong')
	alter table PhieuDatPhong 
		drop constraint if exists fk_PDP_Phong
	alter table PhieuDatPhong 
		drop constraint if exists fk_PDP_KH
go

-- table LienPhieu_DichVu
if exists (select *
		   from sys.tables
		   where SCHEMA_NAME(schema_id) like 'dbo' and name like 'LienPhieu_DichVu')
	alter table LienPhieu_DichVu
		drop constraint if exists fk_LP_DV_LP
	alter table LienPhieu_DichVu
		drop constraint if exists fk_LP_DV_DV
go

-- table HoaDon
if exists (select *
		   from sys.tables
		   where SCHEMA_NAME(schema_id) like 'dbo' and name like 'HoaDon')
	alter table HoaDon
		drop constraint if exists fk_HD_KH
	alter table HoaDon
		drop constraint if exists fk_HD_LP
	alter table HoaDon
		drop constraint if exists fk_HD_Phong
go

-- table KhachHangTheoTour
if exists (select *
		   from sys.tables
		   where SCHEMA_NAME(schema_id) like 'dbo' and name like 'KhachHangTheoTour')
	alter table KhachHangTheoTour
		drop constraint if exists fk_KHTT_KH
	alter table KhachHangTheoTour
		drop constraint if exists fk_KHTT_TC
go

-- table ToChucTour
if exists (select *
		   from sys.tables
		   where SCHEMA_NAME(schema_id) like 'dbo' and name like 'ToChucTour')
	alter table ToChucTour
		drop constraint if exists fk_TCT_TDL
	alter table ToChucTour
		drop constraint if exists fk_TCT_DVLH
go



----- create tables

drop table if exists dbo.NhanVien
create table NhanVien(
	MaNV char(3) not null,
	TenNV nvarchar(40) not null,
	LoaiNV nvarchar(30) not null,
	NgaySinh datetime not null,
	primary key (MaNV)
)

drop table if exists dbo.KhachHang
create table KhachHang(
	CMND char(9) not null,
	TenKH nvarchar(40) not null,
	SoDienThoai char(10),
	Email nvarchar(30) not null,
	primary key (CMND)
)

drop table if exists dbo.Phong
create table Phong(
	MaPhong char(3) not null,
	MoTa nvarchar(40),
	TinhTrang nvarchar(20) not null,
	GiaPhong int not null,
	LoaiPhong char(10) not null,
	primary key (MaPhong)
)

drop table if exists dbo.PhieuDatPhong
create table PhieuDatPhong(
	MaPhong char(3) not null,
	CMND char(9) not null,
	NgayDen datetime not null,
	SoDemLuuTru int not null,
	YeuCauDacBiet nvarchar(100),
	primary key (MaPhong, CMND)
)

drop table if exists dbo.SanPhamDichVu
create table SanPhamDichVu(
	MaSPDV char(3) not null,
	TenSPDV nvarchar(30) not null,
	Gia int not null,
	MoTa nvarchar(30),
	primary key (MaSPDV)
)

drop table if exists dbo.LienPhieuSuDungDichVu
create table LienPhieuSuDungDichVu(
	MaPhieu char(3) not null,
	CMND char(9) not null,
	primary key (MaPhieu)
)

drop table if exists dbo.LienPhieu_DichVu
create table LienPhieu_DichVu(
	MaPhieu char(3) not null,
	MaSPDV char(3) not null,
	primary key (MaPhieu, MaSPDV)
)

drop table if exists dbo.HoaDon
create table HoaDon(
	MaHoaDon char(3) not null,
	CMND char(9) not null,
	MaPhong char(3) not null,
	MaPhieu char(3),
	TongGia int not null,
	primary key (MaHoaDon)
)

drop table if exists dbo.TourDuLich
create table TourDuLich(
	MaTour char(3) not null,
	TenTour nvarchar(20) not null,
	MoTa nvarchar(40),
	primary key (MaTour)
)

drop table if exists dbo.DonViLuHanh
create table DonViLuHanh(
	MaDonVi char(3) not null,
	TenDonVi nvarchar(20) not null,
	primary key (MaDonVi)
)

drop table if exists dbo.ToChucTour
create table ToChucTour(
	MaToChuc char(3) not null,
	MaDonVi char(3) not null,
	MaTour char(3) not null,
	ThoiDiemBatDau datetime not null,
	ThoiDiemKetThuc datetime not null,
	Gia int not null,
	primary key (MaToChuc)
)

drop table if exists dbo.KhachHangTheoTour
create table KhachHangTheoTour(
	CMND char(9) not null,
	TenKH nvarchar(40) not null,
	SoDienThoai char(10),
	Email nvarchar(30) not null,
	MaToChuc char(3) not null,
	primary key (CMND, MaToChuc)
)

drop table if exists dbo.XeDuLich
create table XeDuLich(
	MaXe char(3) not null,
	MoTa nvarchar(30) not null,
	SoDienThoai char(10) not null,
	Gia int not null,
	primary key (MaXe)
)

drop table if exists dbo.QuyDinhKhachSan
create table QuyDinhKhachSan(
	MaQuyDinh char(3) not null,
	Ten nvarchar(20) not null,
	MoTa nvarchar(100) not null,
	primary key (MaQuyDinh)
)



----- foreign keys
alter table PhieuDatPhong
	add constraint fk_PDP_Phong foreign key (MaPhong)	references Phong(MaPhong),
		constraint fk_PDP_KH	foreign key (CMND)		references KhachHang(CMND)

alter table LienPhieu_DichVu
	add constraint fk_LP_DV_LP	foreign key (MaPhieu)	references LienPhieuSuDungDichVu(MaPhieu),
		constraint fk_LP_DV_DV	foreign key (MaSPDV)	references SanPhamDichVu(MaSPDV)

alter table HoaDon
	add constraint fk_HD_KH		foreign key (CMND)		references KhachHang(CMND),
		constraint fk_HD_LP		foreign key	(MaPhieu)	references LienPhieuSuDungDichVu(MaPhieu),
		constraint fk_HD_Phong	foreign key	(MaPhong)	references Phong(MaPhong)

alter table ToChucTour
	add constraint fk_TCT_TDL	foreign key (MaTour)	references TourDuLich(MaTour),
		constraint fk_TCT_DVLH	foreign key (MaDonVi)	references DonViLuHanh(MaDonVi)

alter table KhachHangTheoTour
	add constraint fk_KHTT_KH	foreign key (CMND)		references KhachHang(CMND),
		constraint fk_KHTT_TC	foreign key (MaToChuc)	references ToChucTour(MaToChuc)




