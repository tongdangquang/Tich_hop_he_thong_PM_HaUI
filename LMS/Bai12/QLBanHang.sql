USE master;
GO

-- Tạo cơ sở dữ liệu
CREATE DATABASE QLBanHang;
GO

-- Sử dụng cơ sở dữ liệu vừa tạo
USE QLBanHang;
GO

-- Tạo bảng DanhMuc
CREATE TABLE DanhMuc (
    MaDanhMuc INT PRIMARY KEY,
    TenDanhMuc NVARCHAR(100)
);

-- Tạo bảng SanPham
CREATE TABLE SanPham (
    Ma INT PRIMARY KEY,
    Ten NVARCHAR(100),
    DonGia DECIMAL(18, 2),
    MaDanhMuc INT,
    FOREIGN KEY (MaDanhMuc) REFERENCES DanhMuc(MaDanhMuc)
);

-- Chèn dữ liệu vào bảng DanhMuc
INSERT INTO DanhMuc (MaDanhMuc, TenDanhMuc) VALUES
(1, N'Điện tử'),
(2, N'Gia dụng'),
(3, N'Thời trang');

-- Chèn dữ liệu vào bảng SanPham (6 bản ghi)
INSERT INTO SanPham (Ma, Ten, DonGia, MaDanhMuc) VALUES
(101, N'Tivi Samsung', 12000000, 1),
(102, N'Tủ lạnh Toshiba', 8500000, 2),
(103, N'Áo thun nam', 250000, 3),
(104, N'Điện thoại iPhone', 20000000, 1),
(105, N'Bếp điện', 1500000, 2),
(106, N'Váy nữ', 350000, 3);
