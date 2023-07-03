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

-- table LienPhieuSuDungDichVu
if exists (select *
		   from sys.tables
		   where SCHEMA_NAME(schema_id) like 'dbo' and name like 'LienPhieuSuDungDichVu')
	alter table LienPhieuSuDungDichVu
		drop constraint if exists fk_LP_DV
	alter table LienPhieuSuDungDichVu
		drop constraint if exists fk_LP_PDP

-- table HoaDon
if exists (select *
		   from sys.tables
		   where SCHEMA_NAME(schema_id) like 'dbo' and name like 'HoaDon')
	alter table HoaDon
		drop constraint if exists fk_HD_LP
	alter table HoaDon
		drop constraint if exists fk_HD_PDP
go

-- table TourDuLich
if exists (select *
		   from sys.tables
		   where SCHEMA_NAME(schema_id) like 'dbo' and name like 'TourDuLich')
	alter table TourDuLich
		drop constraint if exists fk_TDL_DVLH
go

-- table KhachHangTheoTour
if exists (select *
		   from sys.tables
		   where SCHEMA_NAME(schema_id) like 'dbo' and name like 'KhachHangTheoTour')
	alter table KhachHangTheoTour
		drop constraint if exists fk_KHTT_KH
	alter table KhachHangTheoTour
		drop constraint if exists fk_KHTT_TDL
go


----- create tables

drop table if exists dbo.NhanVien
create table NhanVien(
	MaNV char(6) not null,
	TenNV nvarchar(40) not null,
	LoaiNV nvarchar(30) not null,
	NgaySinh datetime,
	primary key (MaNV)
)

drop table if exists dbo.KhachHang
create table KhachHang(
	CMND char(11) not null,
	TenKH nvarchar(40) not null,
	SoDienThoai char(10),
	Email nvarchar(100) not null,
	primary key (CMND)
)

drop table if exists dbo.Phong
create table Phong(
	MaPhong int not null,
	MoTa nvarchar(40),
	TinhTrang nvarchar(20) not null,
	GiaPhong int not null,
	LoaiPhong char(10) not null,
	primary key (MaPhong)
)

drop table if exists dbo.PhieuDatPhong
create table PhieuDatPhong(
	MaPhong int not null,
	CMND char(11) not null,
	NgayDen datetime not null,
	SoDemLuuTru int not null,
	YeuCauDacBiet nvarchar(100),
	Gia int not null,
	primary key (MaPhong, CMND)
)

drop table if exists dbo.SanPhamDichVu
create table SanPhamDichVu(
	MaSPDV int not null,
	TenSPDV nvarchar(30) not null,
	Gia int not null,
	MoTa nvarchar(30),
	primary key (MaSPDV)
)

drop table if exists dbo.LienPhieuSuDungDichVu
create table LienPhieuSuDungDichVu(
	MaPhieu int identity(1,1) not null,
	CMND char(11) not null,
	MaPhong int not null, 
	MaDichVu int not null,
	SoLuong int not null, 
	Gia int not null,
	primary key (MaPhieu)
)

drop table if exists dbo.HoaDon
create table HoaDon(
	MaHoaDon int identity(1,1) not null,
	MaPhong int not null,
	CMND char(11) not null,
	MaPhieu int,
	TongGia int not null,
	primary key (MaHoaDon)
)

drop table if exists dbo.DonViLuHanh
create table DonViLuHanh(
	MaDonVi int not null,
	TenDonVi nvarchar(100) not null,
	primary key (MaDonVi)
)

drop table if exists dbo.TourDuLich
create table TourDuLich(
	MaTour int not null,
	TenTour nvarchar(100) not null,
	DiaDiem nvarchar(50) not null,
    ThoiDiemBatDau datetime not null,
    ThoiDiemKetThuc datetime not null,
    MaDonVi int not null,
    Gia int,
	primary key (MaTour)
)

drop table if exists dbo.KhachHangTheoTour
create table KhachHangTheoTour(
	CMND char(11) not null,
	MaTour int not null,
	primary key (CMND, MaTour)
)

drop table if exists dbo.XeDuLich
create table XeDuLich(
	MaXe int not null,
	MoTa nvarchar(30),
	SoDienThoai char(10) not null,
	Gia int not null,
	primary key (MaXe)
)

----- foreign keys
alter table PhieuDatPhong
	add constraint fk_PDP_Phong foreign key (MaPhong)	references Phong(MaPhong),
		constraint fk_PDP_KH	foreign key (CMND)		references KhachHang(CMND)

alter table LienPhieuSuDungDichVu
	add constraint fk_LP_PDP	foreign key (MaPhong, CMND)	references PhieuDatPhong(MaPhong, CMND),
		constraint fk_LP_DV		foreign key (MaDichVu)	references SanPhamDichVu(MaSPDV)

alter table HoaDon
	add	constraint fk_HD_PDP	foreign key	(MaPhong, CMND)	references PhieuDatPhong(MaPhong, CMND),
		constraint fk_HD_LP		foreign key	(MaPhieu)	references LienPhieuSuDungDichVu(MaPhieu)

alter table TourDuLich
    add constraint fk_TDL_DVLH	foreign key (MaDonVi)	references DonViLuHanh(MaDonVi)

alter table KhachHangTheoTour
	add constraint fk_KHTT_KH	foreign key (CMND)		references KhachHang(CMND),
		constraint fk_KHTT_TDL	foreign key (MaTour)	references TourDuLich(MaTour)




----- insert values

insert into NhanVien (MaNV, TenNV, LoaiNV, NgaySinh) values ('EMP408', 'Yankee', 'Ke toan', '05/29/1996');
insert into NhanVien (MaNV, TenNV, LoaiNV, NgaySinh) values ('EMP149', 'Quentin', 'Ke toan', '05/17/1997');
insert into NhanVien (MaNV, TenNV, LoaiNV, NgaySinh) values ('EMP666', 'Vivian', 'Dich vu', '03/29/1998');
insert into NhanVien (MaNV, TenNV, LoaiNV, NgaySinh) values ('EMP528', 'Saloma', 'Buong phong', '12/08/1996');
insert into NhanVien (MaNV, TenNV, LoaiNV, NgaySinh) values ('EMP991', 'Ebeneser', 'Le tan', '12/24/1995');
insert into NhanVien (MaNV, TenNV, LoaiNV, NgaySinh) values ('EMP823', 'Barr', 'Le tan', '04/18/1995');
insert into NhanVien (MaNV, TenNV, LoaiNV, NgaySinh) values ('EMP135', 'Konstance', 'Buong phong', '06/09/1995');
insert into NhanVien (MaNV, TenNV, LoaiNV, NgaySinh) values ('EMP441', 'Jimmy', 'Buong phong', '07/25/1995');
insert into NhanVien (MaNV, TenNV, LoaiNV, NgaySinh) values ('EMP708', 'Cathrin', 'Dich vu', '02/18/1999');
select * from NhanVien

insert into KhachHang (CMND, TenKH, SoDienThoai, Email) values ('581-34-1412', 'Eleonore Boles', '5582441705', 'eboles0@posterous.com');
insert into KhachHang (CMND, TenKH, SoDienThoai, Email) values ('778-28-7578', 'Rorie Astupenas', '4027509349', 'rastupenas1@tmall.com');
insert into KhachHang (CMND, TenKH, SoDienThoai, Email) values ('136-46-3992', 'Wendeline Rubertis', '3475814226', 'wrubertis2@rambler.ru');
insert into KhachHang (CMND, TenKH, SoDienThoai, Email) values ('182-21-0338', 'Ebba Brockest', '6938914802', 'ebrockest3@diigo.com');
insert into KhachHang (CMND, TenKH, SoDienThoai, Email) values ('218-12-2464', 'Lilias Warke', '4437747537', 'lwarke4@merriam-webster.com');
insert into KhachHang (CMND, TenKH, SoDienThoai, Email) values ('748-11-2480', 'Ike Fontin', '2097451621', 'ifontin5@surveymonkey.com');
insert into KhachHang (CMND, TenKH, SoDienThoai, Email) values ('252-96-3175', 'Hendrik Urridge', '9754834361', 'hurridge6@gravatar.com');
insert into KhachHang (CMND, TenKH, SoDienThoai, Email) values ('485-62-2276', 'Danna Trulock', '4585894028', 'dtrulock7@un.org');
insert into KhachHang (CMND, TenKH, SoDienThoai, Email) values ('858-11-5779', 'Foss Kinze', '9639338687', 'fkinze8@google.ca');
insert into KhachHang (CMND, TenKH, SoDienThoai, Email) values ('614-12-3522', 'Putnem Marshalleck', '8689520333', 'pmarshalleck9@mit.edu');
insert into KhachHang (CMND, TenKH, SoDienThoai, Email) values ('716-90-1632', 'Matti Kleinmann', '3684145787', 'mkleinmanna@ovh.net');
insert into KhachHang (CMND, TenKH, SoDienThoai, Email) values ('497-77-9936', 'Guendolen Soonhouse', '9873508651', 'gsoonhouseb@princeton.edu');
insert into KhachHang (CMND, TenKH, SoDienThoai, Email) values ('484-23-1922', 'Nicolais Burgan', '8506194932', 'nburganc@state.tx.us');
insert into KhachHang (CMND, TenKH, SoDienThoai, Email) values ('626-95-5927', 'Sebastian Reitenbach', '5264829707', 'sreitenbachd@rakuten.co.jp');
insert into KhachHang (CMND, TenKH, SoDienThoai, Email) values ('757-33-7853', 'Jdavie Matic', '9286725695', 'jmatice@gravatar.com');
insert into KhachHang (CMND, TenKH, SoDienThoai, Email) values ('532-80-4459', 'Kipper Grigori', '1746029674', 'kgrigorif@youtube.com');
insert into KhachHang (CMND, TenKH, SoDienThoai, Email) values ('288-69-9120', 'Barb Cowndley', '2699297097', 'bcowndleyg@ehow.com');
insert into KhachHang (CMND, TenKH, SoDienThoai, Email) values ('762-53-3151', 'Hildegarde Radsdale', '8375701877', 'hradsdaleh@ning.com');
insert into KhachHang (CMND, TenKH, SoDienThoai, Email) values ('557-12-0839', 'Persis Simonetti', '2925336312', 'psimonettii@nps.gov');
insert into KhachHang (CMND, TenKH, SoDienThoai, Email) values ('250-82-4182', 'Curtis Seton', '5177611436', 'csetonj@opensource.org');
insert into KhachHang (CMND, TenKH, SoDienThoai, Email) values ('146-80-5706', 'Ulric Grassot', '2869775723', 'ugrassotk@goo.gl');
insert into KhachHang (CMND, TenKH, SoDienThoai, Email) values ('885-04-4706', 'Dion Mollene', '1388466874', 'dmollenel@unesco.org');
insert into KhachHang (CMND, TenKH, SoDienThoai, Email) values ('194-05-5253', 'Valene Storks', '6464605902', 'vstorksm@globo.com');
insert into KhachHang (CMND, TenKH, SoDienThoai, Email) values ('502-32-7061', 'Rollie Ivanikhin', '1614194965', 'rivanikhinn@typepad.com');
insert into KhachHang (CMND, TenKH, SoDienThoai, Email) values ('473-30-9567', 'Hamlen Pembry', '4651492490', 'hpembryo@miibeian.gov.cn');
insert into KhachHang (CMND, TenKH, SoDienThoai, Email) values ('873-38-4487', 'Tammi Brimilcome', '5052279098', 'tbrimilcomep@geocities.jp');
insert into KhachHang (CMND, TenKH, SoDienThoai, Email) values ('287-17-7253', 'Larina Sponton', '5991030039', 'lspontonq@hostgator.com');
insert into KhachHang (CMND, TenKH, SoDienThoai, Email) values ('608-22-7291', 'Dougy Grabbam', '5842246718', 'dgrabbamr@rediff.com');
insert into KhachHang (CMND, TenKH, SoDienThoai, Email) values ('191-95-9690', 'Atlante Edmand', '9897296999', 'aedmands@posterous.com');
insert into KhachHang (CMND, TenKH, SoDienThoai, Email) values ('389-87-4898', 'Bella Snowball', '6073922058', 'bsnowballt@reverbnation.com');
insert into KhachHang (CMND, TenKH, SoDienThoai, Email) values ('416-01-5794', 'Ines Thinn', '6499206833', 'ithinnu@eventbrite.com');
insert into KhachHang (CMND, TenKH, SoDienThoai, Email) values ('292-18-0044', 'Ofelia Seldon', '1604391645', 'oseldonv@istockphoto.com');
insert into KhachHang (CMND, TenKH, SoDienThoai, Email) values ('197-51-9888', 'Abby Beecraft', '7602529734', 'abeecraftw@cbsnews.com');
insert into KhachHang (CMND, TenKH, SoDienThoai, Email) values ('470-38-7714', 'Scarface Pollett', '1756176839', 'spollettx@shutterfly.com');
insert into KhachHang (CMND, TenKH, SoDienThoai, Email) values ('655-09-6124', 'Abey Grouvel', '6759676141', 'agrouvely@geocities.com');
insert into KhachHang (CMND, TenKH, SoDienThoai, Email) values ('151-36-6399', 'Cairistiona Stopper', '1015528593', 'cstopperz@ox.ac.uk');
insert into KhachHang (CMND, TenKH, SoDienThoai, Email) values ('663-70-7325', 'Abbe Puden', '1888352242', 'apuden10@apache.org');
insert into KhachHang (CMND, TenKH, SoDienThoai, Email) values ('122-42-1603', 'Wash Daintith', '7485922847', 'wdaintith11@harvard.edu');
insert into KhachHang (CMND, TenKH, SoDienThoai, Email) values ('856-24-5742', 'Clarinda Pau', '9095742935', 'cpau12@blogger.com');
insert into KhachHang (CMND, TenKH, SoDienThoai, Email) values ('847-36-7475', 'Trumaine Offill', '1074184698', 'toffill13@livejournal.com');
insert into KhachHang (CMND, TenKH, SoDienThoai, Email) values ('813-86-3575', 'Eugine Gaines', '7972154190', 'egaines14@last.fm');
insert into KhachHang (CMND, TenKH, SoDienThoai, Email) values ('207-78-4367', 'Charmain Cyster', '4211233863', 'ccyster15@pinterest.com');
insert into KhachHang (CMND, TenKH, SoDienThoai, Email) values ('107-76-0247', 'Andie Lorraway', '3493525432', 'alorraway16@ox.ac.uk');
insert into KhachHang (CMND, TenKH, SoDienThoai, Email) values ('380-41-8490', 'Bel Borit', '3301356011', 'bborit17@epa.gov');
insert into KhachHang (CMND, TenKH, SoDienThoai, Email) values ('267-67-0645', 'Peirce Pearmain', '6576821791', 'ppearmain18@fema.gov');
insert into KhachHang (CMND, TenKH, SoDienThoai, Email) values ('766-91-4137', 'Shell Mees', '9782588858', 'smees19@tripod.com');
insert into KhachHang (CMND, TenKH, SoDienThoai, Email) values ('687-81-4540', 'Erminia MacMaykin', '2544311935', 'emacmaykin1a@oaic.gov.au');
insert into KhachHang (CMND, TenKH, SoDienThoai, Email) values ('671-13-2822', 'Barbette Fell', '8314619164', 'bfell1b@seattletimes.com');
insert into KhachHang (CMND, TenKH, SoDienThoai, Email) values ('582-88-6068', 'Clementius Gosling', '3431059516', 'cgosling1c@wsj.com');
insert into KhachHang (CMND, TenKH, SoDienThoai, Email) values ('358-69-7854', 'Langsdon Seint', '6719928760', 'lseint1d@xing.com');
insert into KhachHang (CMND, TenKH, SoDienThoai, Email) values ('193-17-3710', 'Benny Giamitti', '8486931466', 'bgiamitti1e@zimbio.com');
insert into KhachHang (CMND, TenKH, SoDienThoai, Email) values ('443-71-7312', 'Antonella Du Hamel', '5936482908', 'adu1f@house.gov');
insert into KhachHang (CMND, TenKH, SoDienThoai, Email) values ('161-57-1813', 'Janis Reightley', '8063509258', 'jreightley1g@fotki.com');
insert into KhachHang (CMND, TenKH, SoDienThoai, Email) values ('631-28-3971', 'Nerty Keysel', '7822485651', 'nkeysel1h@theatlantic.com');
insert into KhachHang (CMND, TenKH, SoDienThoai, Email) values ('447-61-5406', 'Care Ives', '1651380335', 'cives1i@si.edu');
insert into KhachHang (CMND, TenKH, SoDienThoai, Email) values ('899-62-1339', 'Tiffanie Dominighi', '9239608165', 'tdominighi1j@cocolog-nifty.com');
insert into KhachHang (CMND, TenKH, SoDienThoai, Email) values ('587-34-9180', 'Randal Ellesworthe', '1884533164', 'rellesworthe1k@printfriendly.com');
insert into KhachHang (CMND, TenKH, SoDienThoai, Email) values ('381-13-7062', 'Rochette Burch', '8592588073', 'rburch1l@artisteer.com');
insert into KhachHang (CMND, TenKH, SoDienThoai, Email) values ('500-55-6147', 'Tiler Hyndley', '1443050502', 'thyndley1m@elegantthemes.com');
insert into KhachHang (CMND, TenKH, SoDienThoai, Email) values ('690-63-5554', 'Ignatius Worling', '7855343360', 'iworling1n@toplist.cz');
insert into KhachHang (CMND, TenKH, SoDienThoai, Email) values ('314-55-4466', 'Consuela Tretter', '3351247505', 'ctretter1o@sitemeter.com');
insert into KhachHang (CMND, TenKH, SoDienThoai, Email) values ('834-65-9379', 'Nerta Goggins', '8083106278', 'ngoggins1p@shareasale.com');
insert into KhachHang (CMND, TenKH, SoDienThoai, Email) values ('349-34-1345', 'Bobby Svanetti', '9406452216', 'bsvanetti1q@clickbank.net');
insert into KhachHang (CMND, TenKH, SoDienThoai, Email) values ('817-70-4326', 'Gerry Barnard', '5861407989', 'gbarnard1r@cmu.edu');
insert into KhachHang (CMND, TenKH, SoDienThoai, Email) values ('847-52-6936', 'Meredeth Humphery', '2603265361', 'mhumphery1s@mozilla.org');
insert into KhachHang (CMND, TenKH, SoDienThoai, Email) values ('703-30-0841', 'Susanetta Farnan', '9178075564', 'sfarnan1t@furl.net');
insert into KhachHang (CMND, TenKH, SoDienThoai, Email) values ('569-32-2942', 'Enrica Robshaw', '8232144943', 'erobshaw1u@google.co.jp');
insert into KhachHang (CMND, TenKH, SoDienThoai, Email) values ('135-91-7080', 'Vanna Adame', '2995014665', 'vadame1v@google.ca');
insert into KhachHang (CMND, TenKH, SoDienThoai, Email) values ('760-26-3162', 'Jeff Tassell', '1259975535', 'jtassell1w@techcrunch.com');
insert into KhachHang (CMND, TenKH, SoDienThoai, Email) values ('579-38-3446', 'Wallie Coster', '6344212219', 'wcoster1x@yolasite.com');
insert into KhachHang (CMND, TenKH, SoDienThoai, Email) values ('618-34-4498', 'Moshe Penhall', '7357769698', 'mpenhall1y@ow.ly');
insert into KhachHang (CMND, TenKH, SoDienThoai, Email) values ('538-06-9966', 'Silvain MacMeanma', '9361778172', 'smacmeanma1z@myspace.com');
insert into KhachHang (CMND, TenKH, SoDienThoai, Email) values ('791-24-2359', 'Harriet Vause', '9728773879', 'hvause20@mysql.com');
insert into KhachHang (CMND, TenKH, SoDienThoai, Email) values ('370-52-6054', 'Caesar Dadswell', '6178890295', 'cdadswell21@opensource.org');
insert into KhachHang (CMND, TenKH, SoDienThoai, Email) values ('597-06-1651', 'Mandel Stovine', '8144915964', 'mstovine22@marketwatch.com');
insert into KhachHang (CMND, TenKH, SoDienThoai, Email) values ('656-33-8158', 'Barret Northrop', '3277279430', 'bnorthrop23@tuttocitta.it');
insert into KhachHang (CMND, TenKH, SoDienThoai, Email) values ('711-07-2595', 'Cully Broseman', '2824282148', 'cbroseman24@amazon.com');
insert into KhachHang (CMND, TenKH, SoDienThoai, Email) values ('780-12-7617', 'Patsy Mustoe', '9796581137', 'pmustoe25@lycos.com');
insert into KhachHang (CMND, TenKH, SoDienThoai, Email) values ('201-85-8088', 'Madella Carneck', '9706611385', 'mcarneck26@macromedia.com');
insert into KhachHang (CMND, TenKH, SoDienThoai, Email) values ('682-36-9857', 'Gilligan Barense', '5398101642', 'gbarense27@flavors.me');
insert into KhachHang (CMND, TenKH, SoDienThoai, Email) values ('407-27-0307', 'Bradly Hayter', '2771982160', 'bhayter28@hud.gov');
insert into KhachHang (CMND, TenKH, SoDienThoai, Email) values ('302-80-8777', 'Anson Togher', '2883856547', 'atogher29@weather.com');
insert into KhachHang (CMND, TenKH, SoDienThoai, Email) values ('196-26-2189', 'Selena Cockarill', '7202270114', 'scockarill2a@xinhuanet.com');
insert into KhachHang (CMND, TenKH, SoDienThoai, Email) values ('319-79-4476', 'Julina Divina', '4316349323', 'jdivina2b@latimes.com');
insert into KhachHang (CMND, TenKH, SoDienThoai, Email) values ('576-43-0090', 'Lorna Gimblet', '6368186573', 'lgimblet2c@ezinearticles.com');
insert into KhachHang (CMND, TenKH, SoDienThoai, Email) values ('335-53-3200', 'Hank Salvadori', '4098523229', 'hsalvadori2d@independent.co.uk');
insert into KhachHang (CMND, TenKH, SoDienThoai, Email) values ('863-10-9803', 'Flora Fynes', '4303460956', 'ffynes2e@java.com');
insert into KhachHang (CMND, TenKH, SoDienThoai, Email) values ('146-22-8974', 'Jermaine Bedson', '7846975753', 'jbedson2f@tumblr.com');
insert into KhachHang (CMND, TenKH, SoDienThoai, Email) values ('483-58-8715', 'Tannie Eyden', '5508664609', 'teyden2g@shutterfly.com');
insert into KhachHang (CMND, TenKH, SoDienThoai, Email) values ('639-27-6743', 'Annemarie Hunt', '6753071508', 'ahunt2h@weebly.com');
insert into KhachHang (CMND, TenKH, SoDienThoai, Email) values ('584-49-6550', 'Cinda Riglesford', '5881976420', 'criglesford2i@usatoday.com');
insert into KhachHang (CMND, TenKH, SoDienThoai, Email) values ('865-61-8447', 'Gavin Dell''Abbate', '7345519491', 'gdellabbate2j@blogtalkradio.com');
insert into KhachHang (CMND, TenKH, SoDienThoai, Email) values ('384-08-1757', 'Ephrayim Cissen', '4996888583', 'ecissen2k@barnesandnoble.com');
insert into KhachHang (CMND, TenKH, SoDienThoai, Email) values ('847-57-3559', 'Cordelia Ebbing', '1624314895', 'cebbing2l@slideshare.net');
insert into KhachHang (CMND, TenKH, SoDienThoai, Email) values ('594-93-4784', 'Whitman McCambrois', '5275931109', 'wmccambrois2m@dagondesign.com');
insert into KhachHang (CMND, TenKH, SoDienThoai, Email) values ('608-49-9849', 'Gardener Brightwell', '1135654542', 'gbrightwell2n@nationalgeographic.com');
insert into KhachHang (CMND, TenKH, SoDienThoai, Email) values ('390-34-8526', 'Delmor Rodda', '5534185231', 'drodda2o@hc360.com');
insert into KhachHang (CMND, TenKH, SoDienThoai, Email) values ('435-73-5457', 'Bernette Topling', '2801173457', 'btopling2p@google.co.jp');
insert into KhachHang (CMND, TenKH, SoDienThoai, Email) values ('768-27-8952', 'Nowell Danielsen', '4111556156', 'ndanielsen2q@behance.net');
insert into KhachHang (CMND, TenKH, SoDienThoai, Email) values ('778-17-5466', 'Joycelin Eaves', '1456725312', 'jeaves2r@ezinearticles.com');
select * from KhachHang

insert into Phong (MaPhong, MoTa, TinhTrang, GiaPhong, LoaiPhong) values (1, null, 'da dat', 4624, 'phong don');
insert into Phong (MaPhong, MoTa, TinhTrang, GiaPhong, LoaiPhong) values (2, null, 'da dat', 2153, 'phong don');
insert into Phong (MaPhong, MoTa, TinhTrang, GiaPhong, LoaiPhong) values (3, null, 'da dat', 2988, 'phong don');
insert into Phong (MaPhong, MoTa, TinhTrang, GiaPhong, LoaiPhong) values (4, null, 'trong', 3944, 'phong tu');
insert into Phong (MaPhong, MoTa, TinhTrang, GiaPhong, LoaiPhong) values (5, null, 'trong', 3540, 'phong don');
insert into Phong (MaPhong, MoTa, TinhTrang, GiaPhong, LoaiPhong) values (6, null, 'trong', 4596, 'phong don');
insert into Phong (MaPhong, MoTa, TinhTrang, GiaPhong, LoaiPhong) values (7, null, 'trong', 4223, 'phong don');
insert into Phong (MaPhong, MoTa, TinhTrang, GiaPhong, LoaiPhong) values (8, null, 'trong', 2180, 'phong doi');
insert into Phong (MaPhong, MoTa, TinhTrang, GiaPhong, LoaiPhong) values (9, null, 'tam ngung', 2007, 'phong don');
insert into Phong (MaPhong, MoTa, TinhTrang, GiaPhong, LoaiPhong) values (10, null, 'tam ngung', 4803, 'phong don');
select * from Phong

insert into PhieuDatPhong (MaPhong, CMND, NgayDen, SoDemLuuTru, YeuCauDacBiet, Gia) values (1, '136-46-3992', '04/17/2023', 17, null, 88500);
insert into PhieuDatPhong (MaPhong, CMND, NgayDen, SoDemLuuTru, YeuCauDacBiet, Gia) values (2, '500-55-6147', '07/15/2022', 13, null, 27500);
insert into PhieuDatPhong (MaPhong, CMND, NgayDen, SoDemLuuTru, YeuCauDacBiet, Gia) values (3, '863-10-9803', '02/21/2023', 7, null, 22350);
select * from PhieuDatPhong

insert into SanPhamDichVu values (1, 'Giat ui', 100, null)
insert into SanPhamDichVu values (2, 'Goi xe', 50, null)
insert into SanPhamDichVu values (3, 'Nha hang', 300, null)
insert into SanPhamDichVu values (4, 'Quay bar', 300, null)
insert into SanPhamDichVu values (5, 'Dich vu spa', 500, null)
insert into SanPhamDichVu values (6, 'Fitness center', 500, null)
select * from SanPhamDichVu

insert into LienPhieuSuDungDichVu (MaPhong, CMND, MaDichVu, SoLuong, Gia) values (1, '136-46-3992', 1, 2, 200);
insert into LienPhieuSuDungDichVu (MaPhong, CMND, MaDichVu, SoLuong, Gia) values (2, '500-55-6147', 3, 1, 300);
select * from LienPhieuSuDungDichVu

insert into HoaDon values (1, '136-46-3992', 1, 90000);
insert into HoaDon values (2, '500-55-6147', 2, 27800);
select * from HoaDon

insert into DonViLuHanh (MaDonVi, TenDonVi) values (1, 'Wintheiser and Kertzmann');
insert into DonViLuHanh (MaDonVi, TenDonVi) values (2, 'Dicki Gorczany');
insert into DonViLuHanh (MaDonVi, TenDonVi) values (3, 'McKenzie Spinka and Bernhard');
insert into DonViLuHanh (MaDonVi, TenDonVi) values (4, 'Stiedemann Inc');
insert into DonViLuHanh (MaDonVi, TenDonVi) values (5, 'Jaskolski Grant');
select * from DonViLuHanh

insert into TourDuLich (MaTour, TenTour, DiaDiem, ThoiDiemBatDau, ThoiDiemKetThuc, MaDonVi, Gia) values (1, 'Vung Tau trip', 'Vung Tau', '02/05/2023', '02/10/2023', 1, 100);
insert into TourDuLich (MaTour, TenTour, DiaDiem, ThoiDiemBatDau, ThoiDiemKetThuc, MaDonVi, Gia) values (2, 'Ocean trip', 'Vung Tau', '12/05/2023', '12/07/2023', 5, 120);
insert into TourDuLich (MaTour, TenTour, DiaDiem, ThoiDiemBatDau, ThoiDiemKetThuc, MaDonVi, Gia) values (3, 'Da Nang trip', 'Da Nang', '02/06/2023', '02/12/2023', 1, 200);
insert into TourDuLich (MaTour, TenTour, DiaDiem, ThoiDiemBatDau, ThoiDiemKetThuc, MaDonVi, Gia) values (4, 'Ca Mau trip', 'Ca Mau', '01/07/2023', '01/09/2023', 2, 150);
insert into TourDuLich (MaTour, TenTour, DiaDiem, ThoiDiemBatDau, ThoiDiemKetThuc, MaDonVi, Gia) values (5, 'Hai Duong trip', 'Hai Duong', '10/07/2023', '10/12/2023', 4, 100);
select * from TourDuLich

insert into XeDuLich (MaXe, MoTa, SoDienThoai, Gia) values (1, null, '9249773797', 227);
insert into XeDuLich (MaXe, MoTa, SoDienThoai, Gia) values (2, null, '4012531427', 137);
insert into XeDuLich (MaXe, MoTa, SoDienThoai, Gia) values (3, null, '9974319017', 110);
insert into XeDuLich (MaXe, MoTa, SoDienThoai, Gia) values (4, null, '9495154105', 142);
insert into XeDuLich (MaXe, MoTa, SoDienThoai, Gia) values (5, null, '8582111056', 131);
insert into XeDuLich (MaXe, MoTa, SoDienThoai, Gia) values (6, null, '9329172193', 174);
insert into XeDuLich (MaXe, MoTa, SoDienThoai, Gia) values (7, null, '8296011803', 247);
insert into XeDuLich (MaXe, MoTa, SoDienThoai, Gia) values (8, null, '5129491875', 122);
insert into XeDuLich (MaXe, MoTa, SoDienThoai, Gia) values (9, null, '7655545144', 109);
insert into XeDuLich (MaXe, MoTa, SoDienThoai, Gia) values (10, null, '8691923693', 190);
insert into XeDuLich (MaXe, MoTa, SoDienThoai, Gia) values (11, null, '7762817593', 148);
insert into XeDuLich (MaXe, MoTa, SoDienThoai, Gia) values (12, null, '3817331785', 140);
insert into XeDuLich (MaXe, MoTa, SoDienThoai, Gia) values (13, null, '9607090722', 228);
insert into XeDuLich (MaXe, MoTa, SoDienThoai, Gia) values (14, null, '6371079002', 204);
insert into XeDuLich (MaXe, MoTa, SoDienThoai, Gia) values (15, null, '5499176936', 104);
select * from XeDuLich

