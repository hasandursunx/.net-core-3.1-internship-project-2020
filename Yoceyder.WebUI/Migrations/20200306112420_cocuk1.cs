using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Yoceyder.WebUI.Migrations
{
    public partial class cocuk1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Cocuk_AnneAdi",
                table: "Children",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Cocuk_AnneDurum",
                table: "Children",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Cocuk_BabaAdi",
                table: "Children",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Cocuk_BabaDurum",
                table: "Children",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Cocuk_Cinsiyet",
                table: "Children",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Cocuk_KaldigiYer",
                table: "Children",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Cocuk_OgrenimDurumu",
                table: "Children",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Cocuk_OkulAdi",
                table: "Children",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Cocuk_Sinif",
                table: "Children",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Cocuk_VasiYakinlik",
                table: "Children",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DogumTarihi",
                table: "Children",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cocuk_AnneAdi",
                table: "Children");

            migrationBuilder.DropColumn(
                name: "Cocuk_AnneDurum",
                table: "Children");

            migrationBuilder.DropColumn(
                name: "Cocuk_BabaAdi",
                table: "Children");

            migrationBuilder.DropColumn(
                name: "Cocuk_BabaDurum",
                table: "Children");

            migrationBuilder.DropColumn(
                name: "Cocuk_Cinsiyet",
                table: "Children");

            migrationBuilder.DropColumn(
                name: "Cocuk_KaldigiYer",
                table: "Children");

            migrationBuilder.DropColumn(
                name: "Cocuk_OgrenimDurumu",
                table: "Children");

            migrationBuilder.DropColumn(
                name: "Cocuk_OkulAdi",
                table: "Children");

            migrationBuilder.DropColumn(
                name: "Cocuk_Sinif",
                table: "Children");

            migrationBuilder.DropColumn(
                name: "Cocuk_VasiYakinlik",
                table: "Children");

            migrationBuilder.DropColumn(
                name: "DogumTarihi",
                table: "Children");
        }
    }
}
