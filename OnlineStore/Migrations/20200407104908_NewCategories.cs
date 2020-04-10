using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineStore.Migrations
{
    public partial class NewCategories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "id", "categoryName", "desc" },
                values: new object[] { 3, "ASP", "Books about ASP.NET" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "id", "categoryName", "desc" },
                values: new object[] { 3, "ASP", "Books about ASP.NET" });
        }
    }
}
