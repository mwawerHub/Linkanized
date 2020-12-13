using Microsoft.EntityFrameworkCore.Migrations;

namespace Linkanized.Data.Migrations
{
    public partial class AddParentCategoriesToResourceModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Resources_MainCategoryId",
                table: "Resources",
                column: "MainCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Resources_SubCategoryId",
                table: "Resources",
                column: "SubCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Resources_MainCategories_MainCategoryId",
                table: "Resources",
                column: "MainCategoryId",
                principalTable: "MainCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Resources_SubCategories_SubCategoryId",
                table: "Resources",
                column: "SubCategoryId",
                principalTable: "SubCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Resources_MainCategories_MainCategoryId",
                table: "Resources");

            migrationBuilder.DropForeignKey(
                name: "FK_Resources_SubCategories_SubCategoryId",
                table: "Resources");

            migrationBuilder.DropIndex(
                name: "IX_Resources_MainCategoryId",
                table: "Resources");

            migrationBuilder.DropIndex(
                name: "IX_Resources_SubCategoryId",
                table: "Resources");
        }
    }
}
