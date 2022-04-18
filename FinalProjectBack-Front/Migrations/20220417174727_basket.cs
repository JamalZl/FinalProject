using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProjectBack_Front.Migrations
{
    public partial class basket : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "BasketItems",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Size",
                table: "BasketItems",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Color",
                table: "BasketItems");

            migrationBuilder.DropColumn(
                name: "Size",
                table: "BasketItems");
        }
    }
}
