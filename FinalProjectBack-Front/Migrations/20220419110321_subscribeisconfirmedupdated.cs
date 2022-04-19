using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProjectBack_Front.Migrations
{
    public partial class subscribeisconfirmedupdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsConfirmed",
                table: "Subscribers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsConfirmed",
                table: "Subscribers",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
