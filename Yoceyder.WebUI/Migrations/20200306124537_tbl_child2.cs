using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Yoceyder.WebUI.Migrations
{
    public partial class tbl_child2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tbl_Child");

            migrationBuilder.DropColumn(
                name: "Cocuk_not1",
                table: "Children");

            migrationBuilder.AddColumn<DateTime>(
                name: "Cocuk_DogumTarihi",
                table: "Children",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cocuk_DogumTarihi",
                table: "Children");

            migrationBuilder.AddColumn<string>(
                name: "Cocuk_not1",
                table: "Children",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Tbl_Child",
                columns: table => new
                {
                    Cocuk_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cockuk_DogumTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Cocuk_AdiSoyadi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cocuk_AnneAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cocuk_AnneDurum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cocuk_BabaAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cocuk_BabaDurum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cocuk_Cinsiyet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cocuk_KaldigiYer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cocuk_OgrenimDurumu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cocuk_OkulAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cocuk_Sinif = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cocuk_Tc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cocuk_VasiYakinlik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vasi_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Child", x => x.Cocuk_Id);
                });
        }
    }
}
