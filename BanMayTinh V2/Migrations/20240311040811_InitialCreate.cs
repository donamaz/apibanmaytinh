using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BanMayTinh_V2.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DanhMuc",
                columns: table => new
                {
                    MaDanhMuc = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaDanhMucCha = table.Column<int>(type: "int", nullable: true),
                    TenDanhMuc = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    STT = table.Column<int>(type: "int", nullable: true),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhMuc", x => x.MaDanhMuc);
                });

            migrationBuilder.CreateTable(
                name: "DonHang",
                columns: table => new
                {
                    MaDonHang = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaKhachHang = table.Column<int>(type: "int", nullable: true),
                    NgayDat = table.Column<DateTime>(type: "datetime", nullable: true),
                    TrangThaiDonHang = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DonHang", x => x.MaDonHang);
                });

            migrationBuilder.CreateTable(
                name: "DonViTinh",
                columns: table => new
                {
                    MaDonViTinh = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenDonViTinh = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DonViTinh", x => x.MaDonViTinh);
                });

            migrationBuilder.CreateTable(
                name: "GiaSanPham",
                columns: table => new
                {
                    MaGiaSanPham = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaSanPham = table.Column<int>(type: "int", nullable: false),
                    NgayBatDau = table.Column<DateTime>(type: "datetime", nullable: false),
                    NgayKetThuc = table.Column<DateTime>(type: "datetime", nullable: true),
                    Gia = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GiaSanPham_1", x => x.MaGiaSanPham);
                });

            migrationBuilder.CreateTable(
                name: "KhachHang",
                columns: table => new
                {
                    MaKhachHang = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenKhachHang = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(1500)", maxLength: 1500, nullable: true),
                    SoDienThoai = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHang", x => x.MaKhachHang);
                });

            migrationBuilder.CreateTable(
                name: "Kho",
                columns: table => new
                {
                    MaKho = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenKho = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kho", x => x.MaKho);
                });

            migrationBuilder.CreateTable(
                name: "KhuyenMai",
                columns: table => new
                {
                    MaKhuyenMai = table.Column<int>(type: "int", nullable: false),
                    TenKhuyenMai = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    MoTa = table.Column<string>(type: "ntext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhuyenMai", x => x.MaKhuyenMai);
                });

            migrationBuilder.CreateTable(
                name: "Menu",
                columns: table => new
                {
                    MaMenu = table.Column<int>(type: "int", nullable: false),
                    TenMenu = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menu", x => x.MaMenu);
                });

            migrationBuilder.CreateTable(
                name: "NguoiDung",
                columns: table => new
                {
                    MaNguoiDung = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HoTen = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    NgaySinh = table.Column<DateTime>(type: "datetime", nullable: true),
                    GioiTinh = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    AnhDaiDien = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(1500)", maxLength: 1500, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DienThoai = table.Column<string>(type: "char(20)", unicode: false, fixedLength: true, maxLength: 20, nullable: true),
                    TrangThai = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NguoiDung", x => x.MaNguoiDung);
                });

            migrationBuilder.CreateTable(
                name: "NhaCungCap",
                columns: table => new
                {
                    MaNhaCungCap = table.Column<int>(type: "int", nullable: false),
                    TenNhaCungCap = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    SoDienThoai = table.Column<string>(type: "char(20)", unicode: false, fixedLength: true, maxLength: 20, nullable: true),
                    Email = table.Column<string>(type: "char(50)", unicode: false, fixedLength: true, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhaCungCap", x => x.MaNhaCungCap);
                });

            migrationBuilder.CreateTable(
                name: "NhaSanXuat",
                columns: table => new
                {
                    MaNhaSanXuat = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenNhaSanXuat = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    MoTa = table.Column<string>(type: "ntext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhaSanXuat", x => x.MaNhaSanXuat);
                });

            migrationBuilder.CreateTable(
                name: "NhomSanPham",
                columns: table => new
                {
                    MaNhomSanPham = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenNhom = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    TrangThai = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhomSanPham", x => x.MaNhomSanPham);
                });

            migrationBuilder.CreateTable(
                name: "SanPham",
                columns: table => new
                {
                    MaSanPham = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaDanhMuc = table.Column<int>(type: "int", nullable: false),
                    TenSanPham = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    MoTaSanPham = table.Column<string>(type: "ntext", nullable: false),
                    AnhDaiDien = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: false),
                    MaNhaSanXuat = table.Column<int>(type: "int", nullable: false),
                    MaDonViTinh = table.Column<int>(type: "int", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPham", x => x.MaSanPham);
                });

            migrationBuilder.CreateTable(
                name: "Silde",
                columns: table => new
                {
                    MaSilde = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Anh = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    Link = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Silde", x => x.MaSilde);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietDonHang",
                columns: table => new
                {
                    MaChiTietDonHang = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaDonHang = table.Column<int>(type: "int", nullable: false),
                    MaSanPham = table.Column<int>(type: "int", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    GiaMua = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietDonHang", x => x.MaChiTietDonHang);
                    table.ForeignKey(
                        name: "FK_ChiTietDonHang_DonHang",
                        column: x => x.MaDonHang,
                        principalTable: "DonHang",
                        principalColumn: "MaDonHang");
                });

            migrationBuilder.CreateTable(
                name: "HoaDonXuat",
                columns: table => new
                {
                    MaHoaDonXuat = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SoHoaDon = table.Column<string>(type: "nchar(50)", fixedLength: true, maxLength: 50, nullable: true),
                    NgayXuat = table.Column<DateTime>(type: "datetime", nullable: true),
                    MaKhachHang = table.Column<int>(type: "int", nullable: true),
                    MaNguoiDung = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDonXuat", x => x.MaHoaDonXuat);
                    table.ForeignKey(
                        name: "FK_HoaDonXuat_KhachHang",
                        column: x => x.MaKhachHang,
                        principalTable: "KhachHang",
                        principalColumn: "MaKhachHang");
                });

            migrationBuilder.CreateTable(
                name: "KiemKho",
                columns: table => new
                {
                    MaKiemKho = table.Column<int>(type: "int", nullable: false),
                    MaNguoiDung = table.Column<int>(type: "int", nullable: true),
                    ThoiGianBatDau = table.Column<DateTime>(type: "datetime", nullable: true),
                    ThoiGianKetThuc = table.Column<DateTime>(type: "datetime", nullable: true),
                    TrangThaiKho = table.Column<int>(type: "int", nullable: true),
                    MaKho = table.Column<int>(type: "int", nullable: true),
                    MoTa = table.Column<string>(type: "ntext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KiemKho", x => x.MaKiemKho);
                    table.ForeignKey(
                        name: "FK_KiemKho_Kho",
                        column: x => x.MaKho,
                        principalTable: "Kho",
                        principalColumn: "MaKho");
                });

            migrationBuilder.CreateTable(
                name: "TaiKhoan",
                columns: table => new
                {
                    MaTaiKhoan = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaNguoiDung = table.Column<int>(type: "int", nullable: true),
                    TaiKhoan = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    MatKhau = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    NgayBatDau = table.Column<DateTime>(type: "datetime", nullable: true),
                    NgayKetThuc = table.Column<DateTime>(type: "datetime", nullable: true),
                    TrangThai = table.Column<bool>(type: "bit", nullable: true),
                    LoaiQuyet = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaiKhoan", x => x.MaTaiKhoan);
                    table.ForeignKey(
                        name: "FK_TaiKhoan_NguoiDung",
                        column: x => x.MaNguoiDung,
                        principalTable: "NguoiDung",
                        principalColumn: "MaNguoiDung");
                });

            migrationBuilder.CreateTable(
                name: "HoaDonNhap",
                columns: table => new
                {
                    MaHoaDonNhap = table.Column<int>(type: "int", nullable: false),
                    SoHoaDon = table.Column<string>(type: "nchar(50)", fixedLength: true, maxLength: 50, nullable: false),
                    NgayNhap = table.Column<DateTime>(type: "datetime", nullable: false),
                    MaNguoiDung = table.Column<int>(type: "int", nullable: false),
                    MaNhaCungCap = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDonNhap", x => x.MaHoaDonNhap);
                    table.ForeignKey(
                        name: "FK_HoaDonNhap_NguoiDung",
                        column: x => x.MaNguoiDung,
                        principalTable: "NguoiDung",
                        principalColumn: "MaNguoiDung");
                    table.ForeignKey(
                        name: "FK_HoaDonNhap_NhaCungCap",
                        column: x => x.MaNhaCungCap,
                        principalTable: "NhaCungCap",
                        principalColumn: "MaNhaCungCap");
                });

            migrationBuilder.CreateTable(
                name: "ChiTietAnhSanPham",
                columns: table => new
                {
                    MaAnhChitiet = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaSanPham = table.Column<int>(type: "int", nullable: true),
                    Anh = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietAnhSanPham", x => x.MaAnhChitiet);
                    table.ForeignKey(
                        name: "FK_ChiTietAnhSanPham_SanPham",
                        column: x => x.MaSanPham,
                        principalTable: "SanPham",
                        principalColumn: "MaSanPham");
                });

            migrationBuilder.CreateTable(
                name: "ChiTietKho",
                columns: table => new
                {
                    MaChiTietKho = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaKho = table.Column<int>(type: "int", nullable: true),
                    MaSanPham = table.Column<int>(type: "int", nullable: true),
                    SoLuong = table.Column<int>(type: "int", nullable: true),
                    KhayKhe = table.Column<string>(type: "nvarchar(1500)", maxLength: 1500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietKho", x => x.MaChiTietKho);
                    table.ForeignKey(
                        name: "FK_ChiTietKho_Kho",
                        column: x => x.MaKho,
                        principalTable: "Kho",
                        principalColumn: "MaKho");
                    table.ForeignKey(
                        name: "FK_ChiTietKho_SanPham",
                        column: x => x.MaSanPham,
                        principalTable: "SanPham",
                        principalColumn: "MaSanPham");
                });

            migrationBuilder.CreateTable(
                name: "ChiTietKhuyenMai",
                columns: table => new
                {
                    MaChiTietKhuyenMai = table.Column<int>(type: "int", nullable: false),
                    MaSanPham = table.Column<int>(type: "int", nullable: false),
                    NgayBatDau = table.Column<DateTime>(type: "datetime", nullable: false),
                    NgayKetThuc = table.Column<DateTime>(type: "datetime", nullable: false),
                    MaKhuyenMai = table.Column<int>(type: "int", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietKhuyenMai", x => x.MaChiTietKhuyenMai);
                    table.ForeignKey(
                        name: "FK_ChiTietKhuyenMai_KhuyenMai",
                        column: x => x.MaKhuyenMai,
                        principalTable: "KhuyenMai",
                        principalColumn: "MaKhuyenMai");
                    table.ForeignKey(
                        name: "FK_ChiTietKhuyenMai_SanPham",
                        column: x => x.MaSanPham,
                        principalTable: "SanPham",
                        principalColumn: "MaSanPham");
                });

            migrationBuilder.CreateTable(
                name: "ChiTietNhom",
                columns: table => new
                {
                    MaChiTietNhom = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaNhomSanPham = table.Column<int>(type: "int", nullable: false),
                    MaSanPham = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietNhom", x => x.MaChiTietNhom);
                    table.ForeignKey(
                        name: "FK_ChiTietNhom_NhomSanPham",
                        column: x => x.MaNhomSanPham,
                        principalTable: "NhomSanPham",
                        principalColumn: "MaNhomSanPham");
                    table.ForeignKey(
                        name: "FK_ChiTietNhom_SanPham",
                        column: x => x.MaSanPham,
                        principalTable: "SanPham",
                        principalColumn: "MaSanPham");
                });

            migrationBuilder.CreateTable(
                name: "GiamGia",
                columns: table => new
                {
                    MaGiamGia = table.Column<int>(type: "int", nullable: false),
                    MaSanPham = table.Column<int>(type: "int", nullable: true),
                    PhanTram = table.Column<double>(type: "float", nullable: true),
                    ThoiGianBatDau = table.Column<DateTime>(type: "datetime", nullable: true),
                    ThoiGianKetThuc = table.Column<DateTime>(type: "datetime", nullable: true),
                    TrangThai = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GiamGia", x => x.MaGiamGia);
                    table.ForeignKey(
                        name: "FK_GiamGia_SanPham",
                        column: x => x.MaSanPham,
                        principalTable: "SanPham",
                        principalColumn: "MaSanPham");
                });

            migrationBuilder.CreateTable(
                name: "LichSuGiaBan",
                columns: table => new
                {
                    MaGiaBan = table.Column<int>(type: "int", nullable: false),
                    MaSanPham = table.Column<int>(type: "int", nullable: true),
                    NgayBatDau = table.Column<DateTime>(type: "datetime", nullable: true),
                    NgayKetThuc = table.Column<DateTime>(type: "datetime", nullable: true),
                    Gia = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LichSuGiaBan", x => x.MaGiaBan);
                    table.ForeignKey(
                        name: "FK_LichSuGiaBan_SanPham",
                        column: x => x.MaSanPham,
                        principalTable: "SanPham",
                        principalColumn: "MaSanPham");
                });

            migrationBuilder.CreateTable(
                name: "ThongSoKyThuat",
                columns: table => new
                {
                    MaThongSo = table.Column<int>(type: "int", nullable: false),
                    MaSanPham = table.Column<int>(type: "int", nullable: true),
                    TenThongSo = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    MoTa = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThongSoKyThuat", x => x.MaThongSo);
                    table.ForeignKey(
                        name: "FK_ThongSoKyThuat_SanPham",
                        column: x => x.MaSanPham,
                        principalTable: "SanPham",
                        principalColumn: "MaSanPham");
                });

            migrationBuilder.CreateTable(
                name: "ChiTietHoaDonXuat",
                columns: table => new
                {
                    MaChiTietHoaDonXuat = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaHoaDonXuat = table.Column<int>(type: "int", nullable: false),
                    MaSanPham = table.Column<int>(type: "int", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    GiaBan = table.Column<double>(type: "float", nullable: false),
                    ChietKhau = table.Column<double>(type: "float", nullable: true),
                    TraLai = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietHoaDonXuat", x => x.MaChiTietHoaDonXuat);
                    table.ForeignKey(
                        name: "FK_ChiTietHoaDonXuat_HoaDonXuat",
                        column: x => x.MaHoaDonXuat,
                        principalTable: "HoaDonXuat",
                        principalColumn: "MaHoaDonXuat");
                    table.ForeignKey(
                        name: "FK_ChiTietHoaDonXuat_SanPham",
                        column: x => x.MaSanPham,
                        principalTable: "SanPham",
                        principalColumn: "MaSanPham");
                });

            migrationBuilder.CreateTable(
                name: "ChiTietKiemKho",
                columns: table => new
                {
                    MaChiTietKiemKho = table.Column<int>(type: "int", nullable: false),
                    MaSanPham = table.Column<int>(type: "int", nullable: false),
                    MaKiemKho = table.Column<int>(type: "int", nullable: false),
                    SoLuongDemDuoc = table.Column<int>(type: "int", nullable: true),
                    SoLuongTinhToan = table.Column<int>(type: "int", nullable: true),
                    SoLuongThayDoi = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietKiemKho", x => x.MaChiTietKiemKho);
                    table.ForeignKey(
                        name: "FK_ChiTietKiemKho_KiemKho",
                        column: x => x.MaKiemKho,
                        principalTable: "KiemKho",
                        principalColumn: "MaKiemKho");
                    table.ForeignKey(
                        name: "FK_ChiTietKiemKho_SanPham",
                        column: x => x.MaSanPham,
                        principalTable: "SanPham",
                        principalColumn: "MaSanPham");
                });

            migrationBuilder.CreateTable(
                name: "ChiTietHoaDonNhap",
                columns: table => new
                {
                    MaChiTiet = table.Column<int>(type: "int", nullable: false),
                    MaSanPham = table.Column<int>(type: "int", nullable: true),
                    MaHoaDonNhap = table.Column<int>(type: "int", nullable: true),
                    SoLuong = table.Column<int>(type: "int", nullable: true),
                    DonGiaNhap = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietHoaDonNhap", x => x.MaChiTiet);
                    table.ForeignKey(
                        name: "FK_ChiTietHoaDonNhap_HoaDonNhap",
                        column: x => x.MaHoaDonNhap,
                        principalTable: "HoaDonNhap",
                        principalColumn: "MaHoaDonNhap");
                    table.ForeignKey(
                        name: "FK_ChiTietHoaDonNhap_SanPham",
                        column: x => x.MaSanPham,
                        principalTable: "SanPham",
                        principalColumn: "MaSanPham");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietAnhSanPham_MaSanPham",
                table: "ChiTietAnhSanPham",
                column: "MaSanPham");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietDonHang_MaDonHang",
                table: "ChiTietDonHang",
                column: "MaDonHang");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietHoaDonNhap_MaHoaDonNhap",
                table: "ChiTietHoaDonNhap",
                column: "MaHoaDonNhap");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietHoaDonNhap_MaSanPham",
                table: "ChiTietHoaDonNhap",
                column: "MaSanPham");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietHoaDonXuat_MaHoaDonXuat",
                table: "ChiTietHoaDonXuat",
                column: "MaHoaDonXuat");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietHoaDonXuat_MaSanPham",
                table: "ChiTietHoaDonXuat",
                column: "MaSanPham");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietKho_MaKho",
                table: "ChiTietKho",
                column: "MaKho");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietKho_MaSanPham",
                table: "ChiTietKho",
                column: "MaSanPham");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietKhuyenMai_MaKhuyenMai",
                table: "ChiTietKhuyenMai",
                column: "MaKhuyenMai");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietKhuyenMai_MaSanPham",
                table: "ChiTietKhuyenMai",
                column: "MaSanPham");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietKiemKho_MaKiemKho",
                table: "ChiTietKiemKho",
                column: "MaKiemKho");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietKiemKho_MaSanPham",
                table: "ChiTietKiemKho",
                column: "MaSanPham");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietNhom_MaNhomSanPham",
                table: "ChiTietNhom",
                column: "MaNhomSanPham");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietNhom_MaSanPham",
                table: "ChiTietNhom",
                column: "MaSanPham");

            migrationBuilder.CreateIndex(
                name: "IX_GiamGia_MaSanPham",
                table: "GiamGia",
                column: "MaSanPham");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonNhap_MaNguoiDung",
                table: "HoaDonNhap",
                column: "MaNguoiDung");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonNhap_MaNhaCungCap",
                table: "HoaDonNhap",
                column: "MaNhaCungCap");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonXuat_MaKhachHang",
                table: "HoaDonXuat",
                column: "MaKhachHang");

            migrationBuilder.CreateIndex(
                name: "IX_KiemKho_MaKho",
                table: "KiemKho",
                column: "MaKho");

            migrationBuilder.CreateIndex(
                name: "IX_LichSuGiaBan_MaSanPham",
                table: "LichSuGiaBan",
                column: "MaSanPham");

            migrationBuilder.CreateIndex(
                name: "IX_TaiKhoan_MaNguoiDung",
                table: "TaiKhoan",
                column: "MaNguoiDung");

            migrationBuilder.CreateIndex(
                name: "IX_ThongSoKyThuat_MaSanPham",
                table: "ThongSoKyThuat",
                column: "MaSanPham");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChiTietAnhSanPham");

            migrationBuilder.DropTable(
                name: "ChiTietDonHang");

            migrationBuilder.DropTable(
                name: "ChiTietHoaDonNhap");

            migrationBuilder.DropTable(
                name: "ChiTietHoaDonXuat");

            migrationBuilder.DropTable(
                name: "ChiTietKho");

            migrationBuilder.DropTable(
                name: "ChiTietKhuyenMai");

            migrationBuilder.DropTable(
                name: "ChiTietKiemKho");

            migrationBuilder.DropTable(
                name: "ChiTietNhom");

            migrationBuilder.DropTable(
                name: "DanhMuc");

            migrationBuilder.DropTable(
                name: "DonViTinh");

            migrationBuilder.DropTable(
                name: "GiamGia");

            migrationBuilder.DropTable(
                name: "GiaSanPham");

            migrationBuilder.DropTable(
                name: "LichSuGiaBan");

            migrationBuilder.DropTable(
                name: "Menu");

            migrationBuilder.DropTable(
                name: "NhaSanXuat");

            migrationBuilder.DropTable(
                name: "Silde");

            migrationBuilder.DropTable(
                name: "TaiKhoan");

            migrationBuilder.DropTable(
                name: "ThongSoKyThuat");

            migrationBuilder.DropTable(
                name: "DonHang");

            migrationBuilder.DropTable(
                name: "HoaDonNhap");

            migrationBuilder.DropTable(
                name: "HoaDonXuat");

            migrationBuilder.DropTable(
                name: "KhuyenMai");

            migrationBuilder.DropTable(
                name: "KiemKho");

            migrationBuilder.DropTable(
                name: "NhomSanPham");

            migrationBuilder.DropTable(
                name: "SanPham");

            migrationBuilder.DropTable(
                name: "NguoiDung");

            migrationBuilder.DropTable(
                name: "NhaCungCap");

            migrationBuilder.DropTable(
                name: "KhachHang");

            migrationBuilder.DropTable(
                name: "Kho");
        }
    }
}
