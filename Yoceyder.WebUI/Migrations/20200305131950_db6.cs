using Microsoft.EntityFrameworkCore.Migrations;

namespace Yoceyder.WebUI.Migrations
{
    public partial class db6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ParentVasi_Id",
                table: "Donation",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Donation_ParentVasi_Id",
                table: "Donation",
                column: "ParentVasi_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Donation_Parents_ParentVasi_Id",
                table: "Donation",
                column: "ParentVasi_Id",
                principalTable: "Parents",
                principalColumn: "Vasi_Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Donation_Parents_ParentVasi_Id",
                table: "Donation");

            migrationBuilder.DropIndex(
                name: "IX_Donation_ParentVasi_Id",
                table: "Donation");

            migrationBuilder.DropColumn(
                name: "ParentVasi_Id",
                table: "Donation");
        }
    }
}
