using Microsoft.EntityFrameworkCore.Migrations;

namespace Linkanized.Data.Migrations
{
    public partial class AddMainCategoryToSubCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_SubCategories_MainCategoryId",
                table: "SubCategories",
                column: "MainCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_SubCategories_MainCategories_MainCategoryId",
                table: "SubCategories",
                column: "MainCategoryId",
                principalTable: "MainCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubCategories_MainCategories_MainCategoryId",
                table: "SubCategories");

            migrationBuilder.DropIndex(
                name: "IX_SubCategories_MainCategoryId",
                table: "SubCategories");
        }
    }
}
