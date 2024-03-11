﻿// <auto-generated />
using System;
using BanMayTinh_V2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BanMayTinh_V2.Migrations
{
    [DbContext(typeof(BanMayTinhContext))]
    [Migration("20240311040811_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BanMayTinh_V2.Models.ChiTietAnhSanPham", b =>
                {
                    b.Property<int>("MaAnhChitiet")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaAnhChitiet"), 1L, 1);

                    b.Property<string>("Anh")
                        .HasMaxLength(500)
                        .IsUnicode(false)
                        .HasColumnType("varchar(500)");

                    b.Property<int?>("MaSanPham")
                        .HasColumnType("int");

                    b.HasKey("MaAnhChitiet");

                    b.HasIndex("MaSanPham");

                    b.ToTable("ChiTietAnhSanPham", (string)null);
                });

            modelBuilder.Entity("BanMayTinh_V2.Models.ChiTietDonHang", b =>
                {
                    b.Property<int>("MaChiTietDonHang")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaChiTietDonHang"), 1L, 1);

                    b.Property<double>("GiaMua")
                        .HasColumnType("float");

                    b.Property<int>("MaDonHang")
                        .HasColumnType("int");

                    b.Property<int>("MaSanPham")
                        .HasColumnType("int");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.HasKey("MaChiTietDonHang");

                    b.HasIndex("MaDonHang");

                    b.ToTable("ChiTietDonHang", (string)null);
                });

            modelBuilder.Entity("BanMayTinh_V2.Models.ChiTietHoaDonNhap", b =>
                {
                    b.Property<int>("MaChiTiet")
                        .HasColumnType("int");

                    b.Property<double?>("DonGiaNhap")
                        .HasColumnType("float");

                    b.Property<int?>("MaHoaDonNhap")
                        .HasColumnType("int");

                    b.Property<int?>("MaSanPham")
                        .HasColumnType("int");

                    b.Property<int?>("SoLuong")
                        .HasColumnType("int");

                    b.HasKey("MaChiTiet");

                    b.HasIndex("MaHoaDonNhap");

                    b.HasIndex("MaSanPham");

                    b.ToTable("ChiTietHoaDonNhap", (string)null);
                });

            modelBuilder.Entity("BanMayTinh_V2.Models.ChiTietHoaDonXuat", b =>
                {
                    b.Property<int>("MaChiTietHoaDonXuat")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaChiTietHoaDonXuat"), 1L, 1);

                    b.Property<double?>("ChietKhau")
                        .HasColumnType("float");

                    b.Property<double>("GiaBan")
                        .HasColumnType("float");

                    b.Property<int>("MaHoaDonXuat")
                        .HasColumnType("int");

                    b.Property<int>("MaSanPham")
                        .HasColumnType("int");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.Property<int?>("TraLai")
                        .HasColumnType("int");

                    b.HasKey("MaChiTietHoaDonXuat");

                    b.HasIndex("MaHoaDonXuat");

                    b.HasIndex("MaSanPham");

                    b.ToTable("ChiTietHoaDonXuat", (string)null);
                });

            modelBuilder.Entity("BanMayTinh_V2.Models.ChiTietKho", b =>
                {
                    b.Property<int>("MaChiTietKho")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaChiTietKho"), 1L, 1);

                    b.Property<string>("KhayKhe")
                        .HasMaxLength(1500)
                        .HasColumnType("nvarchar(1500)");

                    b.Property<int?>("MaKho")
                        .HasColumnType("int");

                    b.Property<int?>("MaSanPham")
                        .HasColumnType("int");

                    b.Property<int?>("SoLuong")
                        .HasColumnType("int");

                    b.HasKey("MaChiTietKho");

                    b.HasIndex("MaKho");

                    b.HasIndex("MaSanPham");

                    b.ToTable("ChiTietKho", (string)null);
                });

            modelBuilder.Entity("BanMayTinh_V2.Models.ChiTietKhuyenMai", b =>
                {
                    b.Property<int>("MaChiTietKhuyenMai")
                        .HasColumnType("int");

                    b.Property<int>("MaKhuyenMai")
                        .HasColumnType("int");

                    b.Property<int>("MaSanPham")
                        .HasColumnType("int");

                    b.Property<DateTime>("NgayBatDau")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("NgayKetThuc")
                        .HasColumnType("datetime");

                    b.Property<bool>("TrangThai")
                        .HasColumnType("bit");

                    b.HasKey("MaChiTietKhuyenMai");

                    b.HasIndex("MaKhuyenMai");

                    b.HasIndex("MaSanPham");

                    b.ToTable("ChiTietKhuyenMai", (string)null);
                });

            modelBuilder.Entity("BanMayTinh_V2.Models.ChiTietKiemKho", b =>
                {
                    b.Property<int>("MaChiTietKiemKho")
                        .HasColumnType("int");

                    b.Property<int>("MaKiemKho")
                        .HasColumnType("int");

                    b.Property<int>("MaSanPham")
                        .HasColumnType("int");

                    b.Property<int?>("SoLuongDemDuoc")
                        .HasColumnType("int");

                    b.Property<int?>("SoLuongThayDoi")
                        .HasColumnType("int");

                    b.Property<int?>("SoLuongTinhToan")
                        .HasColumnType("int");

                    b.HasKey("MaChiTietKiemKho");

                    b.HasIndex("MaKiemKho");

                    b.HasIndex("MaSanPham");

                    b.ToTable("ChiTietKiemKho", (string)null);
                });

            modelBuilder.Entity("BanMayTinh_V2.Models.ChiTietNhom", b =>
                {
                    b.Property<int>("MaChiTietNhom")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaChiTietNhom"), 1L, 1);

                    b.Property<int>("MaNhomSanPham")
                        .HasColumnType("int");

                    b.Property<int>("MaSanPham")
                        .HasColumnType("int");

                    b.HasKey("MaChiTietNhom");

                    b.HasIndex("MaNhomSanPham");

                    b.HasIndex("MaSanPham");

                    b.ToTable("ChiTietNhom", (string)null);
                });

            modelBuilder.Entity("BanMayTinh_V2.Models.DanhMuc", b =>
                {
                    b.Property<int>("MaDanhMuc")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaDanhMuc"), 1L, 1);

                    b.Property<int?>("MaDanhMucCha")
                        .HasColumnType("int");

                    b.Property<int?>("Stt")
                        .HasColumnType("int")
                        .HasColumnName("STT");

                    b.Property<string>("TenDanhMuc")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<bool>("TrangThai")
                        .HasColumnType("bit");

                    b.HasKey("MaDanhMuc");

                    b.ToTable("DanhMuc", (string)null);
                });

            modelBuilder.Entity("BanMayTinh_V2.Models.DonHang", b =>
                {
                    b.Property<int>("MaDonHang")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaDonHang"), 1L, 1);

                    b.Property<int?>("MaKhachHang")
                        .HasColumnType("int");

                    b.Property<DateTime?>("NgayDat")
                        .HasColumnType("datetime");

                    b.Property<int?>("TrangThaiDonHang")
                        .HasColumnType("int");

                    b.HasKey("MaDonHang");

                    b.ToTable("DonHang", (string)null);
                });

            modelBuilder.Entity("BanMayTinh_V2.Models.DonViTinh", b =>
                {
                    b.Property<int>("MaDonViTinh")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaDonViTinh"), 1L, 1);

                    b.Property<string>("TenDonViTinh")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("MaDonViTinh");

                    b.ToTable("DonViTinh", (string)null);
                });

            modelBuilder.Entity("BanMayTinh_V2.Models.GiamGium", b =>
                {
                    b.Property<int>("MaGiamGia")
                        .HasColumnType("int");

                    b.Property<int?>("MaSanPham")
                        .HasColumnType("int");

                    b.Property<double?>("PhanTram")
                        .HasColumnType("float");

                    b.Property<DateTime?>("ThoiGianBatDau")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("ThoiGianKetThuc")
                        .HasColumnType("datetime");

                    b.Property<bool?>("TrangThai")
                        .HasColumnType("bit");

                    b.HasKey("MaGiamGia");

                    b.HasIndex("MaSanPham");

                    b.ToTable("GiamGia");
                });

            modelBuilder.Entity("BanMayTinh_V2.Models.GiaSanPham", b =>
                {
                    b.Property<int>("MaGiaSanPham")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaGiaSanPham"), 1L, 1);

                    b.Property<double?>("Gia")
                        .HasColumnType("float");

                    b.Property<int>("MaSanPham")
                        .HasColumnType("int");

                    b.Property<DateTime>("NgayBatDau")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("NgayKetThuc")
                        .HasColumnType("datetime");

                    b.HasKey("MaGiaSanPham")
                        .HasName("PK_GiaSanPham_1");

                    b.ToTable("GiaSanPham", (string)null);
                });

            modelBuilder.Entity("BanMayTinh_V2.Models.HoaDonNhap", b =>
                {
                    b.Property<int>("MaHoaDonNhap")
                        .HasColumnType("int");

                    b.Property<int>("MaNguoiDung")
                        .HasColumnType("int");

                    b.Property<int>("MaNhaCungCap")
                        .HasColumnType("int");

                    b.Property<DateTime>("NgayNhap")
                        .HasColumnType("datetime");

                    b.Property<string>("SoHoaDon")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nchar(50)")
                        .IsFixedLength();

                    b.HasKey("MaHoaDonNhap");

                    b.HasIndex("MaNguoiDung");

                    b.HasIndex("MaNhaCungCap");

                    b.ToTable("HoaDonNhap", (string)null);
                });

            modelBuilder.Entity("BanMayTinh_V2.Models.HoaDonXuat", b =>
                {
                    b.Property<int>("MaHoaDonXuat")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaHoaDonXuat"), 1L, 1);

                    b.Property<int?>("MaKhachHang")
                        .HasColumnType("int");

                    b.Property<int?>("MaNguoiDung")
                        .HasColumnType("int");

                    b.Property<DateTime?>("NgayXuat")
                        .HasColumnType("datetime");

                    b.Property<string>("SoHoaDon")
                        .HasMaxLength(50)
                        .HasColumnType("nchar(50)")
                        .IsFixedLength();

                    b.HasKey("MaHoaDonXuat");

                    b.HasIndex("MaKhachHang");

                    b.ToTable("HoaDonXuat", (string)null);
                });

            modelBuilder.Entity("BanMayTinh_V2.Models.KhachHang", b =>
                {
                    b.Property<int>("MaKhachHang")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaKhachHang"), 1L, 1);

                    b.Property<string>("DiaChi")
                        .HasMaxLength(1500)
                        .HasColumnType("nvarchar(1500)");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("SoDienThoai")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("TenKhachHang")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("MaKhachHang");

                    b.ToTable("KhachHang", (string)null);
                });

            modelBuilder.Entity("BanMayTinh_V2.Models.Kho", b =>
                {
                    b.Property<int>("MaKho")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaKho"), 1L, 1);

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("TenKho")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("MaKho");

                    b.ToTable("Kho", (string)null);
                });

            modelBuilder.Entity("BanMayTinh_V2.Models.KhuyenMai", b =>
                {
                    b.Property<int>("MaKhuyenMai")
                        .HasColumnType("int");

                    b.Property<string>("MoTa")
                        .HasColumnType("ntext");

                    b.Property<string>("TenKhuyenMai")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("MaKhuyenMai");

                    b.ToTable("KhuyenMai", (string)null);
                });

            modelBuilder.Entity("BanMayTinh_V2.Models.KiemKho", b =>
                {
                    b.Property<int>("MaKiemKho")
                        .HasColumnType("int");

                    b.Property<int?>("MaKho")
                        .HasColumnType("int");

                    b.Property<int?>("MaNguoiDung")
                        .HasColumnType("int");

                    b.Property<string>("MoTa")
                        .HasColumnType("ntext");

                    b.Property<DateTime?>("ThoiGianBatDau")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("ThoiGianKetThuc")
                        .HasColumnType("datetime");

                    b.Property<int?>("TrangThaiKho")
                        .HasColumnType("int");

                    b.HasKey("MaKiemKho");

                    b.HasIndex("MaKho");

                    b.ToTable("KiemKho", (string)null);
                });

            modelBuilder.Entity("BanMayTinh_V2.Models.LichSuGiaBan", b =>
                {
                    b.Property<int>("MaGiaBan")
                        .HasColumnType("int");

                    b.Property<double?>("Gia")
                        .HasColumnType("float");

                    b.Property<int?>("MaSanPham")
                        .HasColumnType("int");

                    b.Property<DateTime?>("NgayBatDau")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("NgayKetThuc")
                        .HasColumnType("datetime");

                    b.HasKey("MaGiaBan");

                    b.HasIndex("MaSanPham");

                    b.ToTable("LichSuGiaBan", (string)null);
                });

            modelBuilder.Entity("BanMayTinh_V2.Models.Menu", b =>
                {
                    b.Property<int>("MaMenu")
                        .HasColumnType("int");

                    b.Property<string>("TenMenu")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<bool>("TrangThai")
                        .HasColumnType("bit");

                    b.HasKey("MaMenu");

                    b.ToTable("Menu", (string)null);
                });

            modelBuilder.Entity("BanMayTinh_V2.Models.NguoiDung", b =>
                {
                    b.Property<int>("MaNguoiDung")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaNguoiDung"), 1L, 1);

                    b.Property<string>("AnhDaiDien")
                        .HasMaxLength(500)
                        .IsUnicode(false)
                        .HasColumnType("varchar(500)");

                    b.Property<string>("DiaChi")
                        .HasMaxLength(1500)
                        .HasColumnType("nvarchar(1500)");

                    b.Property<string>("DienThoai")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("char(20)")
                        .IsFixedLength();

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("GioiTinh")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("HoTen")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<DateTime?>("NgaySinh")
                        .HasColumnType("datetime");

                    b.Property<bool?>("TrangThai")
                        .HasColumnType("bit");

                    b.HasKey("MaNguoiDung");

                    b.ToTable("NguoiDung", (string)null);
                });

            modelBuilder.Entity("BanMayTinh_V2.Models.NhaCungCap", b =>
                {
                    b.Property<int>("MaNhaCungCap")
                        .HasColumnType("int");

                    b.Property<string>("DiaChi")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("char(50)")
                        .IsFixedLength();

                    b.Property<string>("SoDienThoai")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("char(20)")
                        .IsFixedLength();

                    b.Property<string>("TenNhaCungCap")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("MaNhaCungCap");

                    b.ToTable("NhaCungCap", (string)null);
                });

            modelBuilder.Entity("BanMayTinh_V2.Models.NhaSanXuat", b =>
                {
                    b.Property<int>("MaNhaSanXuat")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaNhaSanXuat"), 1L, 1);

                    b.Property<string>("MoTa")
                        .HasColumnType("ntext");

                    b.Property<string>("TenNhaSanXuat")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("MaNhaSanXuat");

                    b.ToTable("NhaSanXuat", (string)null);
                });

            modelBuilder.Entity("BanMayTinh_V2.Models.NhomSanPham", b =>
                {
                    b.Property<int>("MaNhomSanPham")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaNhomSanPham"), 1L, 1);

                    b.Property<string>("TenNhom")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<bool?>("TrangThai")
                        .HasColumnType("bit");

                    b.HasKey("MaNhomSanPham");

                    b.ToTable("NhomSanPham", (string)null);
                });

            modelBuilder.Entity("BanMayTinh_V2.Models.SanPham", b =>
                {
                    b.Property<int>("MaSanPham")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaSanPham"), 1L, 1);

                    b.Property<string>("AnhDaiDien")
                        .IsRequired()
                        .HasMaxLength(500)
                        .IsUnicode(false)
                        .HasColumnType("varchar(500)");

                    b.Property<int>("MaDanhMuc")
                        .HasColumnType("int");

                    b.Property<int>("MaDonViTinh")
                        .HasColumnType("int");

                    b.Property<int>("MaNhaSanXuat")
                        .HasColumnType("int");

                    b.Property<string>("MoTaSanPham")
                        .IsRequired()
                        .HasColumnType("ntext");

                    b.Property<DateTime>("NgayTao")
                        .HasColumnType("datetime");

                    b.Property<string>("TenSanPham")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("MaSanPham");

                    b.ToTable("SanPham", (string)null);
                });

            modelBuilder.Entity("BanMayTinh_V2.Models.Silde", b =>
                {
                    b.Property<int>("MaSilde")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaSilde"), 1L, 1);

                    b.Property<string>("Anh")
                        .HasMaxLength(250)
                        .IsUnicode(false)
                        .HasColumnType("varchar(250)");

                    b.Property<string>("Link")
                        .HasMaxLength(250)
                        .IsUnicode(false)
                        .HasColumnType("varchar(250)");

                    b.HasKey("MaSilde");

                    b.ToTable("Silde", (string)null);
                });

            modelBuilder.Entity("BanMayTinh_V2.Models.TaiKhoan", b =>
                {
                    b.Property<int>("MaTaiKhoan")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaTaiKhoan"), 1L, 1);

                    b.Property<string>("LoaiQuyet")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<int?>("MaNguoiDung")
                        .HasColumnType("int");

                    b.Property<string>("MatKhau")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime?>("NgayBatDau")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("NgayKetThuc")
                        .HasColumnType("datetime");

                    b.Property<string>("TaiKhoan1")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("TaiKhoan");

                    b.Property<bool?>("TrangThai")
                        .HasColumnType("bit");

                    b.HasKey("MaTaiKhoan");

                    b.HasIndex("MaNguoiDung");

                    b.ToTable("TaiKhoan", (string)null);
                });

            modelBuilder.Entity("BanMayTinh_V2.Models.ThongSoKyThuat", b =>
                {
                    b.Property<int>("MaThongSo")
                        .HasColumnType("int");

                    b.Property<int?>("MaSanPham")
                        .HasColumnType("int");

                    b.Property<string>("MoTa")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("TenThongSo")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("MaThongSo");

                    b.HasIndex("MaSanPham");

                    b.ToTable("ThongSoKyThuat", (string)null);
                });

            modelBuilder.Entity("BanMayTinh_V2.Models.ChiTietAnhSanPham", b =>
                {
                    b.HasOne("BanMayTinh_V2.Models.SanPham", "MaSanPhamNavigation")
                        .WithMany("ChiTietAnhSanPhams")
                        .HasForeignKey("MaSanPham")
                        .HasConstraintName("FK_ChiTietAnhSanPham_SanPham");

                    b.Navigation("MaSanPhamNavigation");
                });

            modelBuilder.Entity("BanMayTinh_V2.Models.ChiTietDonHang", b =>
                {
                    b.HasOne("BanMayTinh_V2.Models.DonHang", "MaDonHangNavigation")
                        .WithMany("ChiTietDonHangs")
                        .HasForeignKey("MaDonHang")
                        .IsRequired()
                        .HasConstraintName("FK_ChiTietDonHang_DonHang");

                    b.Navigation("MaDonHangNavigation");
                });

            modelBuilder.Entity("BanMayTinh_V2.Models.ChiTietHoaDonNhap", b =>
                {
                    b.HasOne("BanMayTinh_V2.Models.HoaDonNhap", "MaHoaDonNhapNavigation")
                        .WithMany("ChiTietHoaDonNhaps")
                        .HasForeignKey("MaHoaDonNhap")
                        .HasConstraintName("FK_ChiTietHoaDonNhap_HoaDonNhap");

                    b.HasOne("BanMayTinh_V2.Models.SanPham", "MaSanPhamNavigation")
                        .WithMany("ChiTietHoaDonNhaps")
                        .HasForeignKey("MaSanPham")
                        .HasConstraintName("FK_ChiTietHoaDonNhap_SanPham");

                    b.Navigation("MaHoaDonNhapNavigation");

                    b.Navigation("MaSanPhamNavigation");
                });

            modelBuilder.Entity("BanMayTinh_V2.Models.ChiTietHoaDonXuat", b =>
                {
                    b.HasOne("BanMayTinh_V2.Models.HoaDonXuat", "MaHoaDonXuatNavigation")
                        .WithMany("ChiTietHoaDonXuats")
                        .HasForeignKey("MaHoaDonXuat")
                        .IsRequired()
                        .HasConstraintName("FK_ChiTietHoaDonXuat_HoaDonXuat");

                    b.HasOne("BanMayTinh_V2.Models.SanPham", "MaSanPhamNavigation")
                        .WithMany("ChiTietHoaDonXuats")
                        .HasForeignKey("MaSanPham")
                        .IsRequired()
                        .HasConstraintName("FK_ChiTietHoaDonXuat_SanPham");

                    b.Navigation("MaHoaDonXuatNavigation");

                    b.Navigation("MaSanPhamNavigation");
                });

            modelBuilder.Entity("BanMayTinh_V2.Models.ChiTietKho", b =>
                {
                    b.HasOne("BanMayTinh_V2.Models.Kho", "MaKhoNavigation")
                        .WithMany("ChiTietKhos")
                        .HasForeignKey("MaKho")
                        .HasConstraintName("FK_ChiTietKho_Kho");

                    b.HasOne("BanMayTinh_V2.Models.SanPham", "MaSanPhamNavigation")
                        .WithMany("ChiTietKhos")
                        .HasForeignKey("MaSanPham")
                        .HasConstraintName("FK_ChiTietKho_SanPham");

                    b.Navigation("MaKhoNavigation");

                    b.Navigation("MaSanPhamNavigation");
                });

            modelBuilder.Entity("BanMayTinh_V2.Models.ChiTietKhuyenMai", b =>
                {
                    b.HasOne("BanMayTinh_V2.Models.KhuyenMai", "MaKhuyenMaiNavigation")
                        .WithMany("ChiTietKhuyenMais")
                        .HasForeignKey("MaKhuyenMai")
                        .IsRequired()
                        .HasConstraintName("FK_ChiTietKhuyenMai_KhuyenMai");

                    b.HasOne("BanMayTinh_V2.Models.SanPham", "MaSanPhamNavigation")
                        .WithMany("ChiTietKhuyenMais")
                        .HasForeignKey("MaSanPham")
                        .IsRequired()
                        .HasConstraintName("FK_ChiTietKhuyenMai_SanPham");

                    b.Navigation("MaKhuyenMaiNavigation");

                    b.Navigation("MaSanPhamNavigation");
                });

            modelBuilder.Entity("BanMayTinh_V2.Models.ChiTietKiemKho", b =>
                {
                    b.HasOne("BanMayTinh_V2.Models.KiemKho", "MaKiemKhoNavigation")
                        .WithMany("ChiTietKiemKhos")
                        .HasForeignKey("MaKiemKho")
                        .IsRequired()
                        .HasConstraintName("FK_ChiTietKiemKho_KiemKho");

                    b.HasOne("BanMayTinh_V2.Models.SanPham", "MaSanPhamNavigation")
                        .WithMany("ChiTietKiemKhos")
                        .HasForeignKey("MaSanPham")
                        .IsRequired()
                        .HasConstraintName("FK_ChiTietKiemKho_SanPham");

                    b.Navigation("MaKiemKhoNavigation");

                    b.Navigation("MaSanPhamNavigation");
                });

            modelBuilder.Entity("BanMayTinh_V2.Models.ChiTietNhom", b =>
                {
                    b.HasOne("BanMayTinh_V2.Models.NhomSanPham", "MaNhomSanPhamNavigation")
                        .WithMany("ChiTietNhoms")
                        .HasForeignKey("MaNhomSanPham")
                        .IsRequired()
                        .HasConstraintName("FK_ChiTietNhom_NhomSanPham");

                    b.HasOne("BanMayTinh_V2.Models.SanPham", "MaSanPhamNavigation")
                        .WithMany("ChiTietNhoms")
                        .HasForeignKey("MaSanPham")
                        .IsRequired()
                        .HasConstraintName("FK_ChiTietNhom_SanPham");

                    b.Navigation("MaNhomSanPhamNavigation");

                    b.Navigation("MaSanPhamNavigation");
                });

            modelBuilder.Entity("BanMayTinh_V2.Models.GiamGium", b =>
                {
                    b.HasOne("BanMayTinh_V2.Models.SanPham", "MaSanPhamNavigation")
                        .WithMany("GiamGia")
                        .HasForeignKey("MaSanPham")
                        .HasConstraintName("FK_GiamGia_SanPham");

                    b.Navigation("MaSanPhamNavigation");
                });

            modelBuilder.Entity("BanMayTinh_V2.Models.HoaDonNhap", b =>
                {
                    b.HasOne("BanMayTinh_V2.Models.NguoiDung", "MaNguoiDungNavigation")
                        .WithMany("HoaDonNhaps")
                        .HasForeignKey("MaNguoiDung")
                        .IsRequired()
                        .HasConstraintName("FK_HoaDonNhap_NguoiDung");

                    b.HasOne("BanMayTinh_V2.Models.NhaCungCap", "MaNhaCungCapNavigation")
                        .WithMany("HoaDonNhaps")
                        .HasForeignKey("MaNhaCungCap")
                        .IsRequired()
                        .HasConstraintName("FK_HoaDonNhap_NhaCungCap");

                    b.Navigation("MaNguoiDungNavigation");

                    b.Navigation("MaNhaCungCapNavigation");
                });

            modelBuilder.Entity("BanMayTinh_V2.Models.HoaDonXuat", b =>
                {
                    b.HasOne("BanMayTinh_V2.Models.KhachHang", "MaKhachHangNavigation")
                        .WithMany("HoaDonXuats")
                        .HasForeignKey("MaKhachHang")
                        .HasConstraintName("FK_HoaDonXuat_KhachHang");

                    b.Navigation("MaKhachHangNavigation");
                });

            modelBuilder.Entity("BanMayTinh_V2.Models.KiemKho", b =>
                {
                    b.HasOne("BanMayTinh_V2.Models.Kho", "MaKhoNavigation")
                        .WithMany("KiemKhos")
                        .HasForeignKey("MaKho")
                        .HasConstraintName("FK_KiemKho_Kho");

                    b.Navigation("MaKhoNavigation");
                });

            modelBuilder.Entity("BanMayTinh_V2.Models.LichSuGiaBan", b =>
                {
                    b.HasOne("BanMayTinh_V2.Models.SanPham", "MaSanPhamNavigation")
                        .WithMany("LichSuGiaBans")
                        .HasForeignKey("MaSanPham")
                        .HasConstraintName("FK_LichSuGiaBan_SanPham");

                    b.Navigation("MaSanPhamNavigation");
                });

            modelBuilder.Entity("BanMayTinh_V2.Models.TaiKhoan", b =>
                {
                    b.HasOne("BanMayTinh_V2.Models.NguoiDung", "MaNguoiDungNavigation")
                        .WithMany("TaiKhoans")
                        .HasForeignKey("MaNguoiDung")
                        .HasConstraintName("FK_TaiKhoan_NguoiDung");

                    b.Navigation("MaNguoiDungNavigation");
                });

            modelBuilder.Entity("BanMayTinh_V2.Models.ThongSoKyThuat", b =>
                {
                    b.HasOne("BanMayTinh_V2.Models.SanPham", "MaSanPhamNavigation")
                        .WithMany("ThongSoKyThuats")
                        .HasForeignKey("MaSanPham")
                        .HasConstraintName("FK_ThongSoKyThuat_SanPham");

                    b.Navigation("MaSanPhamNavigation");
                });

            modelBuilder.Entity("BanMayTinh_V2.Models.DonHang", b =>
                {
                    b.Navigation("ChiTietDonHangs");
                });

            modelBuilder.Entity("BanMayTinh_V2.Models.HoaDonNhap", b =>
                {
                    b.Navigation("ChiTietHoaDonNhaps");
                });

            modelBuilder.Entity("BanMayTinh_V2.Models.HoaDonXuat", b =>
                {
                    b.Navigation("ChiTietHoaDonXuats");
                });

            modelBuilder.Entity("BanMayTinh_V2.Models.KhachHang", b =>
                {
                    b.Navigation("HoaDonXuats");
                });

            modelBuilder.Entity("BanMayTinh_V2.Models.Kho", b =>
                {
                    b.Navigation("ChiTietKhos");

                    b.Navigation("KiemKhos");
                });

            modelBuilder.Entity("BanMayTinh_V2.Models.KhuyenMai", b =>
                {
                    b.Navigation("ChiTietKhuyenMais");
                });

            modelBuilder.Entity("BanMayTinh_V2.Models.KiemKho", b =>
                {
                    b.Navigation("ChiTietKiemKhos");
                });

            modelBuilder.Entity("BanMayTinh_V2.Models.NguoiDung", b =>
                {
                    b.Navigation("HoaDonNhaps");

                    b.Navigation("TaiKhoans");
                });

            modelBuilder.Entity("BanMayTinh_V2.Models.NhaCungCap", b =>
                {
                    b.Navigation("HoaDonNhaps");
                });

            modelBuilder.Entity("BanMayTinh_V2.Models.NhomSanPham", b =>
                {
                    b.Navigation("ChiTietNhoms");
                });

            modelBuilder.Entity("BanMayTinh_V2.Models.SanPham", b =>
                {
                    b.Navigation("ChiTietAnhSanPhams");

                    b.Navigation("ChiTietHoaDonNhaps");

                    b.Navigation("ChiTietHoaDonXuats");

                    b.Navigation("ChiTietKhos");

                    b.Navigation("ChiTietKhuyenMais");

                    b.Navigation("ChiTietKiemKhos");

                    b.Navigation("ChiTietNhoms");

                    b.Navigation("GiamGia");

                    b.Navigation("LichSuGiaBans");

                    b.Navigation("ThongSoKyThuats");
                });
#pragma warning restore 612, 618
        }
    }
}
