using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API_ManageMotel_Fpoly.Migrations
{
    public partial class update_database_V2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "ngayPhongSeTrong",
                table: "Phong",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "sucChua",
                table: "Phong",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ngayPhongSeTrong",
                table: "Phong");

            migrationBuilder.DropColumn(
                name: "sucChua",
                table: "Phong");
        }
    }
}
