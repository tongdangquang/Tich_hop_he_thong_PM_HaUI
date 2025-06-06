USE master;
GO

-- Tạo cơ sở dữ liệu
CREATE DATABASE DBTT;
GO

-- Sử dụng cơ sở dữ liệu
USE DBTT;
GO

-- Tạo bảng ThoiTietTrongNgay
CREATE TABLE ThoiTietTrongNgay (
    Gio DATETIME,
    MaKhuVuc VARCHAR(10),
    NhietDo DECIMAL(18, 1),
    DoAm DECIMAL(18, 1),
    CONSTRAINT PK_ThoiTiet PRIMARY KEY (Gio, MaKhuVuc)
);
GO

INSERT INTO ThoiTietTrongNgay (Gio, MaKhuVuc, NhietDo, DoAm)
VALUES 
('2025-06-06 06:00:00', 'KV001', 26.5, 80.0),
('2025-06-06 09:00:00', 'KV001', 29.2, 75.5),
('2025-06-06 12:00:00', 'KV001', 33.0, 60.0),
('2025-06-06 15:00:00', 'KV001', 35.1, 55.0),
('2025-06-06 18:00:00', 'KV001', 31.8, 65.2),
('2025-06-06 06:00:00', 'KV002', 25.0, 85.0),
('2025-06-06 12:00:00', 'KV002', 32.5, 70.0);
GO