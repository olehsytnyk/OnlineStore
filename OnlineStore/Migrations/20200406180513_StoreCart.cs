using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineStore.Migrations
{
    public partial class StoreCart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StoreBookItem");

            migrationBuilder.CreateTable(
                name: "StoreCartItem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    bookid = table.Column<int>(nullable: true),
                    price = table.Column<int>(nullable: false),
                    StoreCartId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoreCartItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StoreCartItem_Book_bookid",
                        column: x => x.bookid,
                        principalTable: "Book",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StoreCartItem_bookid",
                table: "StoreCartItem",
                column: "bookid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StoreCartItem");

            migrationBuilder.CreateTable(
                name: "StoreBookItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StoreCartId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bookid = table.Column<int>(type: "int", nullable: true),
                    price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoreBookItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StoreBookItem_Book_bookid",
                        column: x => x.bookid,
                        principalTable: "Book",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StoreBookItem_bookid",
                table: "StoreBookItem",
                column: "bookid");
        }
    }
}
