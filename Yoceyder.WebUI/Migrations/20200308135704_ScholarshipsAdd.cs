using Microsoft.EntityFrameworkCore.Migrations;

namespace Yoceyder.WebUI.Migrations
{
    public partial class ScholarshipsAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Scholarships",
                columns: table => new
                {
                    Burs_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Burs_Iban = table.Column<string>(nullable: true),
                    Burs_IbanSahibi = table.Column<string>(nullable: true),
                    Burs_BankaAdi = table.Column<string>(nullable: true),
                    Burs_Miktar = table.Column<double>(nullable: false),
                    Burs_Sure = table.Column<string>(nullable: true),
                    Burs_BsvrAdiSoyadi = table.Column<string>(nullable: true),
                    Burs_BsvrTelefon = table.Column<string>(nullable: true),
                    Burs_Vasi_Id = table.Column<int>(nullable: false),
                    Burs_Cocuk_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Scholarships", x => x.Burs_Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Scholarships");
        }
    }
}
