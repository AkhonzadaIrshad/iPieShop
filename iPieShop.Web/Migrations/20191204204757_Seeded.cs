using Microsoft.EntityFrameworkCore.Migrations;

namespace iPieShop.Web.Migrations
{
    public partial class Seeded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Category 1" },
                    { 2, "Category 2" },
                    { 3, "Category 3" },
                    { 4, "Category 4" },
                    { 5, "Category 5" }
                });

            migrationBuilder.InsertData(
                table: "Pies",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 1, "SOME DESCRIPTION HERE", "SOME IMAGE HERE", "SOME NAME HERE", 1000.0 },
                    { 2, 2, "SOME DESCRIPTION HERE", "SOME IMAGE HERE", "SOME NAME HERE", 2000.0 },
                    { 3, 3, "SOME DESCRIPTION HERE", "SOME IMAGE HERE", "SOME NAME HERE", 3000.0 },
                    { 4, 4, "SOME DESCRIPTION HERE", "SOME IMAGE HERE", "SOME NAME HERE", 4000.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
