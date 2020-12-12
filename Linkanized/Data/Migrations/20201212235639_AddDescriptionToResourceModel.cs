using Microsoft.EntityFrameworkCore.Migrations;

namespace Linkanized.Data.Migrations
{
    public partial class AddDescriptionToResourceModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Resources",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Resources");
        }
    }
}
