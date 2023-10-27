using Microsoft.EntityFrameworkCore.Migrations;

namespace Yoceyder.WebUI.Migrations
{
    public partial class resimekle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Vasi_Resimyolu",
                table: "Parents",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Vasi_Resimyolu",
                table: "Parents");
        }
    }
}
