using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _23210202037.Migrations
{
    /// <inheritdoc />
    public partial class adminpanel6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "edbe38eb-2195-4839-8d05-e480e4db29c0", "AQAAAAIAAYagAAAAEMkXs1xDkgcp59BqwbxNv5TNEKlT/V4S8DsxuRrXhuNbnjIzxcBygfpEld9DsoU9Pg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ec5ad7e5-cfc0-4425-b393-355e10a5a991", "AQAAAAIAAYagAAAAEFoVXZqv5VbfrB7OLLli8V53rvrEHGS4MsOe1p/zVdXg3XsAoiMePBqAjz/02CvArw==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "33dbd89a-58c6-497b-8bbe-b2c47a316d5a", "AQAAAAIAAYagAAAAEKOyOm6RdO/fuhbbhU18PnMSBGhlSRfU41FTKSc2A3JwIZZ//OafPfd7Nl/zbyBF7Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bd9cbf6a-d489-4b68-b7a0-b05d0b7e1d53", "AQAAAAIAAYagAAAAEC1c8kI0e3n0k0Yf0JqcwJsHQwbrTXlKKNTFGeQyo2ptjkqEYS6GJU2Bfwx6956mPw==" });
        }
    }
}
