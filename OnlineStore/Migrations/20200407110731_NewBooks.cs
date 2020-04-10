using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineStore.Migrations
{
    public partial class NewBooks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "id", "avalible", "categoryID", "img", "isFavorite", "longDesc", "name", "price", "shortDesc" },
                values: new object[,]
                {
                    { 4, true, 3, "/img/ASPNETinAction.jpg", false, "This book is about the ASP.NET Core framework, what it is, and how you can use it to build web applications.", "ASP NET Core in Action", 1020, "Andrew Lock" },
                    { 5, true, 3, "/img/aspnetcoreaz.jpg", false, "This book is a phenomenal achievement, and it’s been really exciting to have been along for the ridefrom the beginning.", "ASP NET Core A-Z", 1400, "Shahed Chowdhuri" },
                    { 6, true, 1, "/img/C8.0and.NETCore3.0.jpg", true, "Build applications with C#, .NET Core, EntityFramework Core, ASP.NET Core, using Visual Studio Code", "C# 8.0 and .NET Core 3.0", 1800, "Mark J. Price" },
                    { 7, true, 3, "/img/Front‐endDevelopment.jpg", true, "There was a time when “backend” and “front‐end” developers were doing pretty different work.", "Front‐end Development with ASP.NET Core, Angular, and Bootstrap", 1500, "Simone Chiaretta" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "id",
                keyValue: 7);
        }
    }
}
