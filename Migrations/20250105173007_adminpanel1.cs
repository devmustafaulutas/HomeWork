using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _23210202037.Migrations
{
    /// <inheritdoc />
    public partial class adminpanel1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "dfe236b0-7d20-4069-9538-ff621dbed7af", "AQAAAAIAAYagAAAAEF0dkE85dZb0cIAoDtZPZBRHV83SHUk4OauU89VlM3E1r7Yh4nEX2nXHZ563mWTrVA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0801c8e4-4690-4ba4-b4c1-0e94388a80dc", "AQAAAAIAAYagAAAAEMSUk1kGlwuGcHV1tGzZpiA0YDfKvk0cgZiWhbjSzaRfuCoTQ/XCaTa16JcHZvznWA==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
