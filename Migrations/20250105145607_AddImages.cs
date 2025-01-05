using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace _23210202037.Migrations
{
    /// <inheritdoc />
    public partial class AddImages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "images",
                columns: new[] { "Id", "Url" },
                values: new object[,]
                {
                    { 1, "canakkale-manzara/manzara-1.jpeg" },
                    { 2, "canakkale-manzara/manzara-4.jpeg" },
                    { 3, "canakkale-manzara/manzara-5.jpeg" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "images",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
