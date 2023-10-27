using Microsoft.EntityFrameworkCore.Migrations;

namespace Yoceyder.WebUI.Migrations
{
    public partial class db4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Donation",
                columns: table => new
                {
                    Yardim_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Yardim_Tur = table.Column<string>(nullable: true),
                    Yardim_Urun = table.Column<string>(nullable: true),
                    Yardim_Miktar = table.Column<string>(nullable: true),
                    Yardim_Aciklama = table.Column<string>(nullable: true),
                    Yardim_Tarih = table.Column<string>(nullable: true),
                    Yardim_Ysvr_Adisoyadi = table.Column<string>(nullable: true),
                    Yardim_Ysvr_Telno = table.Column<string>(nullable: true),
                    Yardim_Vasi_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Donation", x => x.Yardim_Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Donation");
        }
    }
}
