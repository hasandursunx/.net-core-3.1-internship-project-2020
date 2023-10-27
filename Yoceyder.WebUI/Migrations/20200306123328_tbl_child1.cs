using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Yoceyder.WebUI.Migrations
{
    public partial class tbl_child1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tbl_Child",
                columns: table => new
                {
                    Cocuk_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cocuk_Tc = table.Column<string>(nullable: true),
                    Cocuk_AdiSoyadi = table.Column<string>(nullable: true),
                    Cocuk_Cinsiyet = table.Column<string>(nullable: true),
                    Cockuk_DogumTarihi = table.Column<DateTime>(nullable: false),
                    Cocuk_OgrenimDurumu = table.Column<string>(nullable: true),
                    Cocuk_OkulAdi = table.Column<string>(nullable: true),
                    Cocuk_Sinif = table.Column<string>(nullable: true),
                    Cocuk_VasiYakinlik = table.Column<string>(nullable: true),
                    Cocuk_KaldigiYer = table.Column<string>(nullable: true),
                    Cocuk_AnneAdi = table.Column<string>(nullable: true),
                    Cocuk_BabaAdi = table.Column<string>(nullable: true),
                    Cocuk_AnneDurum = table.Column<string>(nullable: true),
                    Cocuk_BabaDurum = table.Column<string>(nullable: true),
                    Vasi_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Child", x => x.Cocuk_Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tbl_Child");
        }
    }
}
