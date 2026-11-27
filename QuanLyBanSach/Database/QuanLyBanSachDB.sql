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
        CHECK (VaiTro IN (N'Quản lý', N'Nhân viên')),
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
    (N'admin', N'Admin@123', N'Quản lý cửa hàng', N'Quản lý');
GO

INSERT INTO TaiKhoan
    (TenDangNhap, MatKhau, HoTen, VaiTro, TrangThai)
VALUES
    ('nhanvien01', '123456', N'Nguyễn Phương Trang', N'Nhân viên bán sách', 1),
    ('nhanvien02', '123456', N'Bùi Hương Thảo', N'Nhân viên bán sách', 1),
    ('nhanvien03', '123456', N'Phạm Trang Linh', N'Nhân viên bán sách', 1),
    ('nhanvien04', '123456', N'Lê Thị Phương Thanh', N'Nhân viên bán sách', 1);
GO

-- 6. DU LIEU SACH BAN DAU

INSERT INTO Sach
    (TenSach, TacGia, NhaXuatBan, TheLoai, DonGia, SoLuongTon)
VALUES
(N'Dế Mèn Phiêu Lưu Ký', N'Tô Hoài', N'Kim Đồng', N'Truyện thiếu nhi', 55000, 30),
(N'Cho Tôi Xin Một Vé Đi Tuổi Thơ', N'Nguyễn Nhật Ánh', N'Trẻ', N'Truyện dài', 80000, 25),
(N'Mắt Biếc', N'Nguyễn Nhật Ánh', N'Trẻ', N'Tiểu thuyết', 110000, 20),
(N'Tôi Thấy Hoa Vàng Trên Cỏ Xanh', N'Nguyễn Nhật Ánh', N'Trẻ', N'Tiểu thuyết', 95000, 18),
(N'Đắc Nhân Tâm', N'Dale Carnegie', N'Tổng hợp TP.HCM', N'Kỹ năng sống', 86000, 15),
(N'Nhà Giả Kim', N'Paulo Coelho', N'Văn học', N'Tiểu thuyết', 79000, 22),
(N'Tuổi Trẻ Đáng Giá Bao Nhiêu', N'Rosie Nguyễn', N'Hội Nhà Văn', N'Kỹ năng sống', 75000, 20),
(N'Lập Trình C Cơ Bản', N'Nguyễn Văn A', N'Giáo dục', N'Tin học', 120000, 12),
(N'Tin Học Đại Cương', N'Nguyễn Thanh Bình', N'Giáo dục', N'Tin học', 95000, 16),
(N'Giáo Trình Cơ Sở Dữ Liệu', N'Nguyễn Tuấn', N'Giáo dục', N'Giáo trình', 105000, 14);
GO

-- 7. KIEM TRA DU LIEU

SELECT * FROM TaiKhoan;
SELECT * FROM Sach;
GO