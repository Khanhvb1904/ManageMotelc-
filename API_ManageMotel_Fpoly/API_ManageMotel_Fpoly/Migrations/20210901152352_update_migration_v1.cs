using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API_ManageMotel_Fpoly.Migrations
{
    public partial class update_migration_v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "dienTich",
                table: "Phong",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "moTa",
                table: "NhaTro",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ngayChotSo",
                table: "NhaTro",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "soPhong",
                table: "NhaTro",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "soTang",
                table: "NhaTro",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "LoaiXe",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ten = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiXe", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Xe",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    maLoaiXe = table.Column<int>(nullable: false),
                    maKhachHang = table.Column<int>(nullable: false),
                    ten = table.Column<string>(nullable: true),
                    bienSo = table.Column<string>(nullable: true),
                    KhachHangId = table.Column<int>(nullable: true),
                    LoaiXeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Xe", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Xe_KhachHang_KhachHangId",
                        column: x => x.KhachHangId,
                        principalTable: "KhachHang",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Xe_LoaiXe_LoaiXeId",
                        column: x => x.LoaiXeId,
                        principalTable: "LoaiXe",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Xe_KhachHangId",
                table: "Xe",
                column: "KhachHangId");

            migrationBuilder.CreateIndex(
                name: "IX_Xe_LoaiXeId",
                table: "Xe",
                column: "LoaiXeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Xe");

            migrationBuilder.DropTable(
                name: "LoaiXe");

            migrationBuilder.DropColumn(
                name: "dienTich",
                table: "Phong");

            migrationBuilder.DropColumn(
                name: "moTa",
                table: "NhaTro");

            migrationBuilder.DropColumn(
                name: "ngayChotSo",
                table: "NhaTro");

            migrationBuilder.DropColumn(
                name: "soPhong",
                table: "NhaTro");

            migrationBuilder.DropColumn(
                name: "soTang",
                table: "NhaTro");
        }
    }
}
