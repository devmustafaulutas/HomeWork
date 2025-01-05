using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace _23210202037.Migrations
{
    /// <inheritdoc />
    public partial class Login : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DropColumn(
                name: "Password",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ee08031d-18cb-4ea9-b183-b712bbb0cfcd", "AQAAAAIAAYagAAAAEJ8P//ZvU5Z3AyqatN/J5Kkb6ixazlXG5fqWa7ukyS+kCd4zTvrr26sFKQqZpck8KA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "df8008a6-2b92-4b02-a5ff-b0efeb3ce02c", "AQAAAAIAAYagAAAAEFVBEshlntwftFFpH2WkikZxj1PHC5PyUCcvay6YDtYCfqqXkGcd1ROlvrX2y7u8/w==" });

            migrationBuilder.UpdateData(
                table: "districts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Img", "Name", "Population" },
                values: new object[] { "Bozcaada, Türkiye'nin üçüncü büyük adasıdır.", "bozcaada.jpeg", "Bozcaada", 2500 });

            migrationBuilder.UpdateData(
                table: "districts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "Img", "Name", "Population" },
                values: new object[] { "Ezine, peyniri ile ünlüdür.", "ezine.jpeg", "Ezine", 40000 });

            migrationBuilder.UpdateData(
                table: "districts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "Img", "Name", "Population" },
                values: new object[] { "Gelibolu, tarihi savaş alanları ile bilinir.", "gelibolu.jpeg", "Gelibolu", 45000 });

            migrationBuilder.UpdateData(
                table: "districts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "Img", "Name", "Population" },
                values: new object[] { "Gökçeada, Türkiye'nin en büyük adasıdır.", "gokceada.jpeg", "Gökçeada", 8000 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "AspNetUsers",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "Password", "PasswordHash" },
                values: new object[] { "5c38b655-3a8d-4042-9d11-4be26381000a", "", "AQAAAAIAAYagAAAAEHKI+PLP3e3rh4sG2uFdQ7Zix4AOHI6McrhGzypwjZsOMqBXv8r6xfMFOkBSS7AiRg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "Password", "PasswordHash" },
                values: new object[] { "985f7475-f76c-4be7-a6f3-30d871bcf31f", "", "AQAAAAIAAYagAAAAEN8YYC00UHyc0TK0NQsFZUnfA/TZG7WB9S1s0XoZcDBkBt1ligJwMt9lM5BEKJIR6A==" });

            migrationBuilder.UpdateData(
                table: "districts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Img", "Name", "Population" },
                values: new object[] { "Biga, Çanakkale'nin en büyük ilçelerinden biridir.", "biga.jpg", "Biga", 90000 });

            migrationBuilder.UpdateData(
                table: "districts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "Img", "Name", "Population" },
                values: new object[] { "Bozcaada, Türkiye'nin üçüncü büyük adasıdır.", "bozcaada.jpeg", "Bozcaada", 2500 });

            migrationBuilder.UpdateData(
                table: "districts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "Img", "Name", "Population" },
                values: new object[] { "Çan, seramik ve çini üretimi ile ünlüdür.", "can.jpeg", "Çan", 50000 });

            migrationBuilder.UpdateData(
                table: "districts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "Img", "Name", "Population" },
                values: new object[] { "Eceabat, Gelibolu Yarımadası'nda yer alır.", "eceabat.jpeg", "Eceabat", 5000 });

            migrationBuilder.InsertData(
                table: "districts",
                columns: new[] { "Id", "CityId", "Description", "Img", "Name", "Population" },
                values: new object[,]
                {
                    { 7, 1, "Ezine, peyniri ile ünlüdür.", "ezine.jpeg", "Ezine", 40000 },
                    { 8, 1, "Gelibolu, tarihi savaş alanları ile bilinir.", "gelibolu.jpeg", "Gelibolu", 45000 },
                    { 9, 1, "Gökçeada, Türkiye'nin en büyük adasıdır.", "gokceada.jpeg", "Gökçeada", 8000 },
                    { 10, 1, "Lapseki, kirazı ile ünlüdür.", "lapseki.jpeg", "Lapseki", 25000 },
                    { 11, 1, "Yenice, ormanları ve doğal güzellikleri ile bilinir.", "yenice.jpeg", "Yenice", 15000 }
                });
        }
    }
}
