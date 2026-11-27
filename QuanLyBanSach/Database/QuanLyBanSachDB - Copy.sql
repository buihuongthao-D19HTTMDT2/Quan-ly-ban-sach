CREATE DATABASE QuanLyBanSachDB;
GO

USE QuanLyBanSachDB;
GO

-- 1. BANG TAI KHOAN
CREATE TABLE TaiKhoan
(
    MaTK INT IDENTITY(1,1) PRIMARY KEY,
    TenDangNhap NVARCHAR(50) NOT NULL UNIQUE,
    MatKhau NVARCHAR(255) NOT NULL,
    HoTen NVARCHAR(100) NOT NULL,
    VaiTro NVARCHAR(30) NOT NULL
        CHECK (VaiTro IN (N'Qu?n lý', N'Nhân viên')),
    TrangThai BIT NOT NULL DEFAULT 1
);
GO

-- 2. BANG SACH
CREATE TABLE Sach
(
    MaSach INT IDENTITY(1,1) PRIMARY KEY,
    TenSach NVARCHAR(200) NOT NULL,
    TacGia NVARCHAR(100),
    NhaXuatBan NVARCHAR(100),
    TheLoai NVARCHAR(100),
    DonGia DECIMAL(18,2) NOT NULL CHECK (DonGia >= 0),
    SoLuongTon INT NOT NULL DEFAULT 0 CHECK (SoLuongTon >= 0)
);
GO

-- 3. BANG HOA DON
CREATE TABLE HoaDon
(
    MaHD INT IDENTITY(1,1) PRIMARY KEY,
    NgayBan DATETIME NOT NULL DEFAULT GETDATE(),
    MaTK INT NOT NULL,
    TongTien DECIMAL(18,2) NOT NULL DEFAULT 0,
    FOREIGN KEY (MaTK) REFERENCES TaiKhoan(MaTK)
);
GO

-- 4. BANG CHI TIET HOA DON
CREATE TABLE ChiTietHoaDon
(
    MaCT INT IDENTITY(1,1) PRIMARY KEY,
    MaHD INT NOT NULL,
    MaSach INT NOT NULL,
    SoLuong INT NOT NULL CHECK (SoLuong > 0),
    DonGia DECIMAL(18,2) NOT NULL CHECK (DonGia >= 0),
    ThanhTien AS (SoLuong * DonGia) PERSISTED,
    FOREIGN KEY (MaHD) REFERENCES HoaDon(MaHD),
    FOREIGN KEY (MaSach) REFERENCES Sach(MaSach)
);
GO

-- 5. TAO TAI KHOAN QUAN LY BAN DAU VA TAI KHOAN NHAN VIEN
INSERT INTO TaiKhoan
    (TenDangNhap, MatKhau, HoTen, VaiTro)
VALUES
    (N'admin', N'Admin@123', N'Qu?n lý c?a hàng', N'Qu?n lý');
GO

INSERT INTO TaiKhoan (TenDangNhap, MatKhau, HoTen, VaiTro, TrangThai)
VALUES 
 ('nhanvien01', '123456', N'Nguy?n Ph??ng Trang', N'Nhân viên', 1);
 ('nhanvien02', '123456', N'Bùi H??ng Th?o', N'Nhân viên', 1);
 ('nhanvien03', '123456', N'Ph?m Trang Linh', N'Nhân viên', 1);
 ('nhanvien04', '123456', N'Lê Th? Ph??ng Thanh', N'Nhân viên', 1);
GO
-- 6. DU LIEU SACH BAN DAU
INSERT INTO Sach
    (TenSach, TacGia, NhaXuatBan, TheLoai, DonGia, SoLuongTon)
VALUES
(N'D? Mèn Phiêu L?u Ký', N'Tô Hoài', N'Kim ??ng', N'Truy?n thi?u nhi', 55000, 30),
(N'Cho Tôi Xin M?t Vé ?i Tu?i Th?', N'Nguy?n Nh?t Ánh', N'Tr?', N'Truy?n dài', 80000, 25),
(N'M?t Bi?c', N'Nguy?n Nh?t Ánh', N'Tr?', N'Ti?u thuy?t', 110000, 20),
(N'Tôi Th?y Hoa Vàng Trên C? Xanh', N'Nguy?n Nh?t Ánh', N'Tr?', N'Ti?u thuy?t', 95000, 18),
(N'??c Nhân Tâm', N'Dale Carnegie', N'T?ng h?p TP.HCM', N'K? n?ng s?ng', 86000, 15),
(N'Nhà Gi? Kim', N'Paulo Coelho', N'V?n h?c', N'Ti?u thuy?t', 79000, 22),
(N'Tu?i Tr? ?áng Giá Bao Nhiêu', N'Rosie Nguy?n', N'H?i Nhà V?n', N'K? n?ng s?ng', 75000, 20),
(N'L?p Trình C C? B?n', N'Nguy?n V?n A', N'Giáo d?c', N'Tin h?c', 120000, 12),
(N'Tin H?c ??i C??ng', N'Nguy?n Thanh Bình', N'Giáo d?c', N'Tin h?c', 95000, 16),
(N'Giáo Trình C? S? D? Li?u', N'Nguy?n Tu?', N'Giáo d?c', N'Giáo trình', 105000, 14);
GO

-- 7. KIEM TRA DU LIEU
SELECT * FROM TaiKhoan;
SELECT * FROM Sach;
GO