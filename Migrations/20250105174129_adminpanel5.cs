using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _23210202037.Migrations
{
    /// <inheritdoc />
    public partial class adminpanel5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7c096109-79e1-4240-8327-996318589c32", "AQAAAAIAAYagAAAAEBrPAB3NSTkEAnUygYaLY8/Bk+hlTGSR9O593VbrO5PklJFNWIWkCf6PTcUULOQSqg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b26d6cce-6a14-453b-9c78-fc381cf8b22f", "AQAAAAIAAYagAAAAEG/QEKMiT9858u9WI1YWFjgROcaM6a2EdvT3CXrkcXXiphm5t4BUajfg9L8wTr09xw==" });
        }
    }
}
