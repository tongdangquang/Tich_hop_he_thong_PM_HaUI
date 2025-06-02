USE master;
GO

-- Tạo cơ sở dữ liệu
CREATE DATABASE QLLuong;
GO

-- Sử dụng cơ sở dữ liệu
USE QLLuong;
GO

-- Tạo bảng DonVi
CREATE TABLE DonVi (
    MaDonVi INT PRIMARY KEY,
    TenDonVi NVARCHAR(100)
);
GO

-- Tạo bảng NhanVien
CREATE TABLE NhanVien (
    Ma INT PRIMARY KEY,
    HoTen NVARCHAR(100),
    NgaySinh DATE,
    GioiTinh NVARCHAR(10),
    Hsluong FLOAT,
    MaDonVi INT,
    FOREIGN KEY (MaDonVi) REFERENCES DonVi(MaDonVi)
);
GO

-- Chèn dữ liệu vào bảng DonVi
INSERT INTO DonVi (MaDonVi, TenDonVi)
VALUES
(1, N'Phòng Kế Toán'),
(2, N'Phòng Nhân Sự'),
(3, N'Phòng Kỹ Thuật');
GO

-- Chèn dữ liệu vào bảng NhanVien
INSERT INTO NhanVien (Ma, HoTen, NgaySinh, GioiTinh, Hsluong, MaDonVi)
VALUES
(101, N'Nguyễn Văn A', '1990-01-01', N'Nam', 3.2, 1),
(102, N'Trần Thị B',   '1992-05-10', N'Nữ',  2.9, 1),
(103, N'Lê Văn C',     '1988-09-15', N'Nam', 3.5, 1),

(201, N'Phạm Thị D',   '1991-03-20', N'Nữ',  3.0, 2),
(202, N'Hoàng Văn E',  '1993-07-12', N'Nam', 3.1, 2),
(203, N'Đỗ Thị F',     '1989-11-30', N'Nữ',  3.3, 2),

(301, N'Ngô Văn G',    '1990-04-18', N'Nam', 3.6, 3),
(302, N'Tống Thị H',   '1994-08-25', N'Nữ',  3.4, 3),
(303, N'Cao Văn I',    '1987-12-05', N'Nam', 3.7, 3);
GO
