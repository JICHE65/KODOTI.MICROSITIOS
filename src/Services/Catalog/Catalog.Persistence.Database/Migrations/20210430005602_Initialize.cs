using Microsoft.EntityFrameworkCore.Migrations;

namespace Catalog.Persistence.Database.Migrations
{
    public partial class Initialize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Catalog");

            migrationBuilder.CreateTable(
                name: "Products",
                schema: "Catalog",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Stocks",
                schema: "Catalog",
                columns: table => new
                {
                    ProductInStockId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stocks", x => x.ProductInStockId);
                    table.ForeignKey(
                        name: "FK_Stocks_Products_ProductId",
                        column: x => x.ProductId,
                        principalSchema: "Catalog",
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Products",
                columns: new[] { "ProductId", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Description for product 1", "Product 1", 432m },
                    { 73, "Description for product 73", "Product 73", 910m },
                    { 72, "Description for product 72", "Product 72", 441m },
                    { 71, "Description for product 71", "Product 71", 315m },
                    { 70, "Description for product 70", "Product 70", 188m },
                    { 69, "Description for product 69", "Product 69", 486m },
                    { 68, "Description for product 68", "Product 68", 792m },
                    { 67, "Description for product 67", "Product 67", 126m },
                    { 66, "Description for product 66", "Product 66", 837m },
                    { 65, "Description for product 65", "Product 65", 712m },
                    { 64, "Description for product 64", "Product 64", 930m },
                    { 63, "Description for product 63", "Product 63", 377m },
                    { 62, "Description for product 62", "Product 62", 229m },
                    { 61, "Description for product 61", "Product 61", 579m },
                    { 60, "Description for product 60", "Product 60", 816m },
                    { 59, "Description for product 59", "Product 59", 669m },
                    { 58, "Description for product 58", "Product 58", 758m },
                    { 57, "Description for product 57", "Product 57", 129m },
                    { 56, "Description for product 56", "Product 56", 367m },
                    { 55, "Description for product 55", "Product 55", 471m },
                    { 54, "Description for product 54", "Product 54", 627m },
                    { 53, "Description for product 53", "Product 53", 452m },
                    { 74, "Description for product 74", "Product 74", 214m },
                    { 52, "Description for product 52", "Product 52", 497m },
                    { 75, "Description for product 75", "Product 75", 941m },
                    { 77, "Description for product 77", "Product 77", 864m },
                    { 98, "Description for product 98", "Product 98", 370m },
                    { 97, "Description for product 97", "Product 97", 600m },
                    { 96, "Description for product 96", "Product 96", 630m },
                    { 95, "Description for product 95", "Product 95", 233m },
                    { 94, "Description for product 94", "Product 94", 178m },
                    { 93, "Description for product 93", "Product 93", 844m },
                    { 92, "Description for product 92", "Product 92", 710m },
                    { 91, "Description for product 91", "Product 91", 805m },
                    { 90, "Description for product 90", "Product 90", 112m },
                    { 89, "Description for product 89", "Product 89", 119m },
                    { 88, "Description for product 88", "Product 88", 912m },
                    { 87, "Description for product 87", "Product 87", 786m },
                    { 86, "Description for product 86", "Product 86", 285m },
                    { 85, "Description for product 85", "Product 85", 518m },
                    { 84, "Description for product 84", "Product 84", 391m },
                    { 83, "Description for product 83", "Product 83", 312m }
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Products",
                columns: new[] { "ProductId", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 82, "Description for product 82", "Product 82", 245m },
                    { 81, "Description for product 81", "Product 81", 339m },
                    { 80, "Description for product 80", "Product 80", 735m },
                    { 79, "Description for product 79", "Product 79", 867m },
                    { 78, "Description for product 78", "Product 78", 671m },
                    { 76, "Description for product 76", "Product 76", 765m },
                    { 51, "Description for product 51", "Product 51", 966m },
                    { 50, "Description for product 50", "Product 50", 851m },
                    { 49, "Description for product 49", "Product 49", 244m },
                    { 22, "Description for product 22", "Product 22", 164m },
                    { 21, "Description for product 21", "Product 21", 642m },
                    { 20, "Description for product 20", "Product 20", 701m },
                    { 19, "Description for product 19", "Product 19", 827m },
                    { 18, "Description for product 18", "Product 18", 806m },
                    { 17, "Description for product 17", "Product 17", 855m },
                    { 16, "Description for product 16", "Product 16", 683m },
                    { 15, "Description for product 15", "Product 15", 922m },
                    { 14, "Description for product 14", "Product 14", 766m },
                    { 13, "Description for product 13", "Product 13", 284m },
                    { 12, "Description for product 12", "Product 12", 567m },
                    { 11, "Description for product 11", "Product 11", 976m },
                    { 10, "Description for product 10", "Product 10", 394m },
                    { 9, "Description for product 9", "Product 9", 415m },
                    { 8, "Description for product 8", "Product 8", 520m },
                    { 7, "Description for product 7", "Product 7", 587m },
                    { 6, "Description for product 6", "Product 6", 502m },
                    { 5, "Description for product 5", "Product 5", 684m },
                    { 4, "Description for product 4", "Product 4", 308m },
                    { 3, "Description for product 3", "Product 3", 909m },
                    { 2, "Description for product 2", "Product 2", 907m },
                    { 23, "Description for product 23", "Product 23", 877m },
                    { 24, "Description for product 24", "Product 24", 251m },
                    { 25, "Description for product 25", "Product 25", 638m },
                    { 26, "Description for product 26", "Product 26", 868m },
                    { 48, "Description for product 48", "Product 48", 777m },
                    { 47, "Description for product 47", "Product 47", 629m },
                    { 46, "Description for product 46", "Product 46", 902m },
                    { 45, "Description for product 45", "Product 45", 383m },
                    { 44, "Description for product 44", "Product 44", 305m },
                    { 43, "Description for product 43", "Product 43", 300m },
                    { 42, "Description for product 42", "Product 42", 877m },
                    { 41, "Description for product 41", "Product 41", 759m }
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Products",
                columns: new[] { "ProductId", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 40, "Description for product 40", "Product 40", 713m },
                    { 39, "Description for product 39", "Product 39", 895m },
                    { 99, "Description for product 99", "Product 99", 593m },
                    { 38, "Description for product 38", "Product 38", 514m },
                    { 36, "Description for product 36", "Product 36", 834m },
                    { 35, "Description for product 35", "Product 35", 380m },
                    { 34, "Description for product 34", "Product 34", 491m },
                    { 33, "Description for product 33", "Product 33", 540m },
                    { 32, "Description for product 32", "Product 32", 239m },
                    { 31, "Description for product 31", "Product 31", 682m },
                    { 30, "Description for product 30", "Product 30", 485m },
                    { 29, "Description for product 29", "Product 29", 242m },
                    { 28, "Description for product 28", "Product 28", 457m },
                    { 27, "Description for product 27", "Product 27", 922m },
                    { 37, "Description for product 37", "Product 37", 468m },
                    { 100, "Description for product 100", "Product 100", 545m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductId",
                schema: "Catalog",
                table: "Products",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_ProductId",
                schema: "Catalog",
                table: "Stocks",
                column: "ProductId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stocks",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "Products",
                schema: "Catalog");
        }
    }
}
