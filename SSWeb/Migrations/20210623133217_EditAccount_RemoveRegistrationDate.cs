using Microsoft.EntityFrameworkCore.Migrations;

namespace SSWeb.Migrations
{
    public partial class EditAccount_RemoveRegistrationDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SKU",
                table: "Products");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SKU",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
