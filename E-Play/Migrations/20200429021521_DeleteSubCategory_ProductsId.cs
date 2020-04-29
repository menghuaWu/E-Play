using Microsoft.EntityFrameworkCore.Migrations;

namespace E_Play.Migrations
{
    public partial class DeleteSubCategory_ProductsId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "SubCategories");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "SubCategories",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
