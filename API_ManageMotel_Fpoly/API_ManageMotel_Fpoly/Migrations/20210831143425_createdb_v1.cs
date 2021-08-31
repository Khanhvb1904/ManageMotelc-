using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API_ManageMotel_Fpoly.Migrations
{
    public partial class createdb_v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KhachHang",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(nullable: true),
                    cmnd = table.Column<string>(nullable: true),
                    ngayCap = table.Column<string>(nullable: true),
                    noiCap = table.Column<string>(nullable: true),
                    HKTT = table.Column<string>(nullable: true),
                    gioiTinh = table.Column<bool>(nullable: false),
                    SDT = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    trangThai = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHang", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LoaiDichVu",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ten = table.Column<string>(nullable: true),
                    trangThai = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiDichVu", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LoaiPhong",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tenGoi = table.Column<string>(nullable: true),
                    sucChua = table.Column<int>(nullable: false),
                    trangThai = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiPhong", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LoaiThietBi",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ten = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiThietBi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NhaTro",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(nullable: true),
                    diaChi = table.Column<string>(nullable: true),
                    SDT = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhaTro", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TaiKhoan",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userName = table.Column<string>(nullable: true),
                    passWord = table.Column<string>(nullable: true),
                    displayName = table.Column<string>(nullable: true),
                    trangThai = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaiKhoan", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HopDong",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    maKhachHang = table.Column<int>(nullable: false),
                    ngayTao = table.Column<DateTime>(nullable: false),
                    ngayKiKet = table.Column<DateTime>(nullable: false),
                    ngayHetHan = table.Column<DateTime>(nullable: false),
                    KhachHangId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HopDong", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HopDong_KhachHang_KhachHangId",
                        column: x => x.KhachHangId,
                        principalTable: "KhachHang",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DichVu",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    maLoaiDichVu = table.Column<int>(nullable: false),
                    ten = table.Column<string>(nullable: true),
                    gia = table.Column<decimal>(nullable: false),
                    trangThai = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DichVu", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DichVu_LoaiDichVu_maLoaiDichVu",
                        column: x => x.maLoaiDichVu,
                        principalTable: "LoaiDichVu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TrangThietBi",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    maLoaiThietBi = table.Column<int>(nullable: false),
                    ten = table.Column<string>(nullable: true),
                    gia = table.Column<decimal>(nullable: false),
                    soLuong = table.Column<int>(nullable: false),
                    trangThai = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrangThietBi", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrangThietBi_LoaiThietBi_maLoaiThietBi",
                        column: x => x.maLoaiThietBi,
                        principalTable: "LoaiThietBi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Phong",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    maNhaTro = table.Column<int>(nullable: false),
                    maLoaiPhong = table.Column<int>(nullable: false),
                    soPhong = table.Column<int>(nullable: false),
                    giaPhong = table.Column<decimal>(nullable: false),
                    moTa = table.Column<string>(nullable: true),
                    trangThai = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phong", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Phong_LoaiPhong_maLoaiPhong",
                        column: x => x.maLoaiPhong,
                        principalTable: "LoaiPhong",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Phong_NhaTro_maNhaTro",
                        column: x => x.maNhaTro,
                        principalTable: "NhaTro",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietHopDong_DichVu",
                columns: table => new
                {
                    maHopDong = table.Column<int>(nullable: false),
                    maPhong = table.Column<int>(nullable: false),
                    maDichVu = table.Column<int>(nullable: false),
                    soLuong = table.Column<int>(nullable: false),
                    donGia = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietHopDong_DichVu", x => new { x.maHopDong, x.maPhong, x.maDichVu });
                    table.ForeignKey(
                        name: "FK_ChiTietHopDong_DichVu_DichVu_maDichVu",
                        column: x => x.maDichVu,
                        principalTable: "DichVu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietHopDong_DichVu_HopDong_maHopDong",
                        column: x => x.maHopDong,
                        principalTable: "HopDong",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietHopDong_DichVu_Phong_maPhong",
                        column: x => x.maPhong,
                        principalTable: "Phong",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietHopDong_TrangThietBi",
                columns: table => new
                {
                    maHopDong = table.Column<int>(nullable: false),
                    maPhong = table.Column<int>(nullable: false),
                    maTrangThietBi = table.Column<int>(nullable: false),
                    soLuong = table.Column<int>(nullable: false),
                    donGia = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietHopDong_TrangThietBi", x => new { x.maPhong, x.maHopDong, x.maTrangThietBi });
                    table.ForeignKey(
                        name: "FK_ChiTietHopDong_TrangThietBi_HopDong_maHopDong",
                        column: x => x.maHopDong,
                        principalTable: "HopDong",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietHopDong_TrangThietBi_Phong_maPhong",
                        column: x => x.maPhong,
                        principalTable: "Phong",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietHopDong_TrangThietBi_TrangThietBi_maTrangThietBi",
                        column: x => x.maTrangThietBi,
                        principalTable: "TrangThietBi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Phong_TrangThietBi",
                columns: table => new
                {
                    maPhong = table.Column<int>(nullable: false),
                    maTrangThietBi = table.Column<int>(nullable: false),
                    soLuong = table.Column<int>(nullable: false),
                    trangThai = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phong_TrangThietBi", x => new { x.maPhong, x.maTrangThietBi });
                    table.ForeignKey(
                        name: "FK_Phong_TrangThietBi_Phong_maPhong",
                        column: x => x.maPhong,
                        principalTable: "Phong",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Phong_TrangThietBi_TrangThietBi_maTrangThietBi",
                        column: x => x.maTrangThietBi,
                        principalTable: "TrangThietBi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietHopDong_DichVu_maDichVu",
                table: "ChiTietHopDong_DichVu",
                column: "maDichVu");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietHopDong_DichVu_maPhong",
                table: "ChiTietHopDong_DichVu",
                column: "maPhong");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietHopDong_TrangThietBi_maHopDong",
                table: "ChiTietHopDong_TrangThietBi",
                column: "maHopDong");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietHopDong_TrangThietBi_maTrangThietBi",
                table: "ChiTietHopDong_TrangThietBi",
                column: "maTrangThietBi");

            migrationBuilder.CreateIndex(
                name: "IX_DichVu_maLoaiDichVu",
                table: "DichVu",
                column: "maLoaiDichVu");

            migrationBuilder.CreateIndex(
                name: "IX_HopDong_KhachHangId",
                table: "HopDong",
                column: "KhachHangId");

            migrationBuilder.CreateIndex(
                name: "IX_Phong_maLoaiPhong",
                table: "Phong",
                column: "maLoaiPhong");

            migrationBuilder.CreateIndex(
                name: "IX_Phong_maNhaTro",
                table: "Phong",
                column: "maNhaTro");

            migrationBuilder.CreateIndex(
                name: "IX_Phong_TrangThietBi_maTrangThietBi",
                table: "Phong_TrangThietBi",
                column: "maTrangThietBi");

            migrationBuilder.CreateIndex(
                name: "IX_TrangThietBi_maLoaiThietBi",
                table: "TrangThietBi",
                column: "maLoaiThietBi");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChiTietHopDong_DichVu");

            migrationBuilder.DropTable(
                name: "ChiTietHopDong_TrangThietBi");

            migrationBuilder.DropTable(
                name: "Phong_TrangThietBi");

            migrationBuilder.DropTable(
                name: "TaiKhoan");

            migrationBuilder.DropTable(
                name: "DichVu");

            migrationBuilder.DropTable(
                name: "HopDong");

            migrationBuilder.DropTable(
                name: "Phong");

            migrationBuilder.DropTable(
                name: "TrangThietBi");

            migrationBuilder.DropTable(
                name: "LoaiDichVu");

            migrationBuilder.DropTable(
                name: "KhachHang");

            migrationBuilder.DropTable(
                name: "LoaiPhong");

            migrationBuilder.DropTable(
                name: "NhaTro");

            migrationBuilder.DropTable(
                name: "LoaiThietBi");
        }
    }
}
