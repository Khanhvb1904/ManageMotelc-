﻿// <auto-generated />
using System;
using API_ManageMotel_Fpoly.EF.ManageMotelDbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace API_ManageMotel_Fpoly.Migrations
{
    [DbContext(typeof(ManageMotelDbContext))]
    [Migration("20210831143425_createdb_v1")]
    partial class createdb_v1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("API_ManageMotel_Fpoly.EF.Entities.ChiTietHopDong_DichVu", b =>
                {
                    b.Property<int>("maHopDong")
                        .HasColumnType("int");

                    b.Property<int>("maPhong")
                        .HasColumnType("int");

                    b.Property<int>("maDichVu")
                        .HasColumnType("int");

                    b.Property<decimal>("donGia")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("soLuong")
                        .HasColumnType("int");

                    b.HasKey("maHopDong", "maPhong", "maDichVu");

                    b.HasIndex("maDichVu");

                    b.HasIndex("maPhong");

                    b.ToTable("ChiTietHopDong_DichVu");
                });

            modelBuilder.Entity("API_ManageMotel_Fpoly.EF.Entities.ChiTietHopDong_TrangThietBi", b =>
                {
                    b.Property<int>("maPhong")
                        .HasColumnType("int");

                    b.Property<int>("maHopDong")
                        .HasColumnType("int");

                    b.Property<int>("maTrangThietBi")
                        .HasColumnType("int");

                    b.Property<decimal>("donGia")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("soLuong")
                        .HasColumnType("int");

                    b.HasKey("maPhong", "maHopDong", "maTrangThietBi");

                    b.HasIndex("maHopDong");

                    b.HasIndex("maTrangThietBi");

                    b.ToTable("ChiTietHopDong_TrangThietBi");
                });

            modelBuilder.Entity("API_ManageMotel_Fpoly.EF.Entities.DichVu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("gia")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("maLoaiDichVu")
                        .HasColumnType("int");

                    b.Property<string>("ten")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("trangThai")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("maLoaiDichVu");

                    b.ToTable("DichVu");
                });

            modelBuilder.Entity("API_ManageMotel_Fpoly.EF.Entities.HopDong", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("KhachHangId")
                        .HasColumnType("int");

                    b.Property<int>("maKhachHang")
                        .HasColumnType("int");

                    b.Property<DateTime>("ngayHetHan")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ngayKiKet")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ngayTao")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("KhachHangId");

                    b.ToTable("HopDong");
                });

            modelBuilder.Entity("API_ManageMotel_Fpoly.EF.Entities.KhachHang", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("HKTT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SDT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cmnd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("gioiTinh")
                        .HasColumnType("bit");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ngayCap")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("noiCap")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("trangThai")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("KhachHang");
                });

            modelBuilder.Entity("API_ManageMotel_Fpoly.EF.Entities.LoaiDichVu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ten")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("trangThai")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("LoaiDichVu");
                });

            modelBuilder.Entity("API_ManageMotel_Fpoly.EF.Entities.LoaiPhong", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("sucChua")
                        .HasColumnType("int");

                    b.Property<string>("tenGoi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("trangThai")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("LoaiPhong");
                });

            modelBuilder.Entity("API_ManageMotel_Fpoly.EF.Entities.LoaiThietBi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ten")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("LoaiThietBi");
                });

            modelBuilder.Entity("API_ManageMotel_Fpoly.EF.Entities.NhaTro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SDT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("diaChi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("NhaTro");
                });

            modelBuilder.Entity("API_ManageMotel_Fpoly.EF.Entities.Phong", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("giaPhong")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("maLoaiPhong")
                        .HasColumnType("int");

                    b.Property<int>("maNhaTro")
                        .HasColumnType("int");

                    b.Property<string>("moTa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("soPhong")
                        .HasColumnType("int");

                    b.Property<bool>("trangThai")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("maLoaiPhong");

                    b.HasIndex("maNhaTro");

                    b.ToTable("Phong");
                });

            modelBuilder.Entity("API_ManageMotel_Fpoly.EF.Entities.Phong_TrangThietBi", b =>
                {
                    b.Property<int>("maPhong")
                        .HasColumnType("int");

                    b.Property<int>("maTrangThietBi")
                        .HasColumnType("int");

                    b.Property<int>("soLuong")
                        .HasColumnType("int");

                    b.Property<bool>("trangThai")
                        .HasColumnType("bit");

                    b.HasKey("maPhong", "maTrangThietBi");

                    b.HasIndex("maTrangThietBi");

                    b.ToTable("Phong_TrangThietBi");
                });

            modelBuilder.Entity("API_ManageMotel_Fpoly.EF.Entities.TaiKhoan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("displayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("passWord")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("trangThai")
                        .HasColumnType("bit");

                    b.Property<string>("userName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TaiKhoan");
                });

            modelBuilder.Entity("API_ManageMotel_Fpoly.EF.Entities.TrangThietBi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("gia")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("maLoaiThietBi")
                        .HasColumnType("int");

                    b.Property<int>("soLuong")
                        .HasColumnType("int");

                    b.Property<string>("ten")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("trangThai")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("maLoaiThietBi");

                    b.ToTable("TrangThietBi");
                });

            modelBuilder.Entity("API_ManageMotel_Fpoly.EF.Entities.ChiTietHopDong_DichVu", b =>
                {
                    b.HasOne("API_ManageMotel_Fpoly.EF.Entities.DichVu", "DichVu")
                        .WithMany("ChiTietHopDong_DichVu")
                        .HasForeignKey("maDichVu")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("API_ManageMotel_Fpoly.EF.Entities.HopDong", "HopDong")
                        .WithMany("ChiTietHopDong_DichVu")
                        .HasForeignKey("maHopDong")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("API_ManageMotel_Fpoly.EF.Entities.Phong", "Phong")
                        .WithMany("ChiTietHopDong_DichVu")
                        .HasForeignKey("maPhong")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("API_ManageMotel_Fpoly.EF.Entities.ChiTietHopDong_TrangThietBi", b =>
                {
                    b.HasOne("API_ManageMotel_Fpoly.EF.Entities.HopDong", "HopDong")
                        .WithMany("ChiTietHopDong_TrangThietBi")
                        .HasForeignKey("maHopDong")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("API_ManageMotel_Fpoly.EF.Entities.Phong", "Phong")
                        .WithMany("ChiTietHopDong_TrangThietBi")
                        .HasForeignKey("maPhong")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("API_ManageMotel_Fpoly.EF.Entities.TrangThietBi", "TrangThietBi")
                        .WithMany("ChiTietHopDong_TrangThietBi")
                        .HasForeignKey("maTrangThietBi")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("API_ManageMotel_Fpoly.EF.Entities.DichVu", b =>
                {
                    b.HasOne("API_ManageMotel_Fpoly.EF.Entities.LoaiDichVu", "LoaiDichVu")
                        .WithMany("DichVu")
                        .HasForeignKey("maLoaiDichVu")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("API_ManageMotel_Fpoly.EF.Entities.HopDong", b =>
                {
                    b.HasOne("API_ManageMotel_Fpoly.EF.Entities.KhachHang", null)
                        .WithMany("HopDong")
                        .HasForeignKey("KhachHangId");
                });

            modelBuilder.Entity("API_ManageMotel_Fpoly.EF.Entities.Phong", b =>
                {
                    b.HasOne("API_ManageMotel_Fpoly.EF.Entities.LoaiPhong", "LoaiPhong")
                        .WithMany("Phong")
                        .HasForeignKey("maLoaiPhong")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("API_ManageMotel_Fpoly.EF.Entities.NhaTro", "NhaTro")
                        .WithMany("Phong")
                        .HasForeignKey("maNhaTro")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("API_ManageMotel_Fpoly.EF.Entities.Phong_TrangThietBi", b =>
                {
                    b.HasOne("API_ManageMotel_Fpoly.EF.Entities.Phong", "Phong")
                        .WithMany("Phong_TrangThietBi")
                        .HasForeignKey("maPhong")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("API_ManageMotel_Fpoly.EF.Entities.TrangThietBi", "TrangThietBi")
                        .WithMany("Phong_TrangThietBi")
                        .HasForeignKey("maTrangThietBi")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("API_ManageMotel_Fpoly.EF.Entities.TrangThietBi", b =>
                {
                    b.HasOne("API_ManageMotel_Fpoly.EF.Entities.LoaiThietBi", "LoaiThietBi")
                        .WithMany("TrangThietBi")
                        .HasForeignKey("maLoaiThietBi")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
