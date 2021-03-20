using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogManagement.Infrastructure.EFCore.Migrations
{
    public partial class Articles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Picturetitle",
                table: "ArticleCategories",
                newName: "PictureTitle");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PictureTitle",
                table: "ArticleCategories",
                newName: "Picturetitle");
        }
    }
}
