using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Yoceyder.WebUI.Migrations
{
    public partial class mig_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Parents",
                columns: table => new
                {
                    Vasi_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Vasi_Dosya = table.Column<string>(nullable: true),
                    Vasi_Tc = table.Column<string>(nullable: true),
                    Vasi_AdiSoyadi = table.Column<string>(nullable: true),
                    Vasi_Telefon = table.Column<string>(nullable: true),
                    Vasi_Il = table.Column<string>(nullable: true),
                    Vasi_Ilce = table.Column<string>(nullable: true),
                    Vasi_Adres = table.Column<string>(nullable: true),
                    Vasi_Iban = table.Column<string>(nullable: true),
                    Vasi_Evdurumu = table.Column<string>(nullable: true),
                    Vasi_Kiramiktari = table.Column<double>(nullable: false),
                    Vasi_Maas = table.Column<string>(nullable: true),
                    Vasi_Maasmiktari = table.Column<double>(nullable: false),
                    Vasi_Cocuksayisi = table.Column<int>(nullable: false),
                    Vasi_Kayittarihi = table.Column<DateTime>(nullable: false),
                    Vasi_Guncellemetarihi = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parents", x => x.Vasi_Id);
                });

            migrationBuilder.CreateTable(
                name: "Children",
                columns: table => new
                {
                    Cocuk_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cocuk_Tc = table.Column<string>(nullable: true),
                    Cocuk_AdiSoyadi = table.Column<string>(nullable: true),
                    Vasi_Id = table.Column<int>(nullable: false),
                    ParentVasi_Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Children", x => x.Cocuk_Id);
                    table.ForeignKey(
                        name: "FK_Children_Parents_ParentVasi_Id",
                        column: x => x.ParentVasi_Id,
                        principalTable: "Parents",
                        principalColumn: "Vasi_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Children_ParentVasi_Id",
                table: "Children",
                column: "ParentVasi_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Children");

            migrationBuilder.DropTable(
                name: "Parents");
        }
    }
}
