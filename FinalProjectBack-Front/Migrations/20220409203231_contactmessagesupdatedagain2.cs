using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProjectBack_Front.Migrations
{
    public partial class contactmessagesupdatedagain2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "ContactMessages");

            migrationBuilder.AddColumn<string>(
                name: "Fullname",
                table: "ContactMessages",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Fullname",
                table: "ContactMessages");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "ContactMessages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
