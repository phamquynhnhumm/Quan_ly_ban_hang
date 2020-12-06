Create table NHA_CUNG_CAP(
 MaNCC nvarchar(50)  not null primary key ,
 TenNCC nvarchar(100) ,
 DiaChi nvarchar(100) ,
 DienThoai nvarchar(50),
 );

 create table SAN_PHAM(
 MaSP nvarchar(50) not null primary key,
 TenSP nvarchar(100),
 MaNCC nvarchar(50)foreign key (MaNCC) references NHA_CUNG_CAP(MaNCC),
 SoLuong int ,
 GiaSP float,
 );

 create table NHAN_VIEN(
 MaNV nvarchar(50) not null primary key,
 TenNV nvarchar(100) ,
 GioiTinh nvarchar(50) ,
 DienThoai nvarchar (50) ,
 NgaySinh date ,
 DiaChi nvarchar(100) ,
 );

 create table KHACH_HANG(
 MaKH nvarchar(50) not null primary key ,
 TenKH nvarchar(100),
 DiaChi nvarchar(100) ,
 DienThoai nvarchar(50) ,
 );

 create table DON_HANG(
 MaDH nvarchar(50) not null primary key,
 NgayBan date ,
 MaNV nvarchar(50) foreign key (MaNV) references NHAN_VIEN(MaNV),
 MaKH nvarchar(50) foreign key (MaKH) references KHACH_HANG(MaKH),

 );

 create table CT_DON_HANG(
 MaDH nvarchar(50) not null foreign key (MaDH) references DON_HANG(MaDH),
 MaSP nvarchar(50) not null foreign key (MaSP) references SAN_PHAM(MaSP),
 primary key(MaDH, MaSP),
 SoLuong int ,
 GiaSP float,
 );

 create table TAI_KHOAN(
 TenDangNhap nvarchar(50) not null primary key,
 TenTaiKhoan nvarchar(50),
 MatKhau nvarchar(50),
 Quyen nvarchar(50),
 );
  insert into TAI_KHOAN values ('PhamThiQuynhNhu','QuynhNhu','28092000','Chu');
 insert into TAI_KHOAN values ('NguyenThiNga','NguyenNga','02062000','NhanVien');