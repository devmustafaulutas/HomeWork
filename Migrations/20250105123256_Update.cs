using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace _23210202037.Migrations
{
    /// <inheritdoc />
    public partial class Update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "districts",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Img",
                table: "districts",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "Population",
                table: "districts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Türkiye" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "Id", "CountryId", "Name" },
                values: new object[] { 1, 1, "Çanakkale" });

            migrationBuilder.InsertData(
                table: "districts",
                columns: new[] { "Id", "CityId", "Description", "Img", "Name", "Population" },
                values: new object[,]
                {
                    { 1, 1, "Ayvacık, tarihi ve doğal güzellikleriyle ünlüdür.", "ayvacik.jpeg", "Ayvacık", 30000 },
                    { 2, 1, "Bayramiç, Kazdağları'nın eteklerinde yer alır.", "bayramic.jpeg", "Bayramiç", 20000 },
                    { 3, 1, "Biga, Çanakkale'nin en büyük ilçelerinden biridir.", "biga.jpg", "Biga", 90000 },
                    { 4, 1, "Bozcaada, Türkiye'nin üçüncü büyük adasıdır.", "bozcaada.jpeg", "Bozcaada", 2500 },
                    { 5, 1, "Çan, seramik ve çini üretimi ile ünlüdür.", "can.jpeg", "Çan", 50000 },
                    { 6, 1, "Eceabat, Gelibolu Yarımadası'nda yer alır.", "eceabat.jpeg", "Eceabat", 5000 },
                    { 7, 1, "Ezine, peyniri ile ünlüdür.", "ezine.jpeg", "Ezine", 40000 },
                    { 8, 1, "Gelibolu, tarihi savaş alanları ile bilinir.", "gelibolu.jpeg", "Gelibolu", 45000 },
                    { 9, 1, "Gökçeada, Türkiye'nin en büyük adasıdır.", "gokceada.jpeg", "Gökçeada", 8000 },
                    { 10, 1, "Lapseki, kirazı ile ünlüdür.", "lapseki.jpeg", "Lapseki", 25000 },
                    { 11, 1, "Yenice, ormanları ve doğal güzellikleri ile bilinir.", "yenice.jpeg", "Yenice", 15000 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "districts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "districts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "districts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "districts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "districts",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "districts",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "districts",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "districts",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "districts",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "districts",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "districts",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "Description",
                table: "districts");

            migrationBuilder.DropColumn(
                name: "Img",
                table: "districts");

            migrationBuilder.DropColumn(
                name: "Population",
                table: "districts");
        }
    }
}
