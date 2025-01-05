using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _23210202037.Migrations
{
    /// <inheritdoc />
    public partial class adminpanel4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "20eef8c3-a350-42b1-941f-b5c069598438", "AQAAAAIAAYagAAAAEFzulxsGU6RRA6hiTY89pfcNuiKMy8RVGp4qYExyAPLtbc9+Dy1hU9/5U39ZnaAqDg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f7d58781-6089-474a-90ca-44a71847dd6b", "AQAAAAIAAYagAAAAEHtZ1JlQF+ySD2m+lrVcys0y+FM4u4HvZsXxaY3Dpr/w/N3qj8ABVeBFDdZ/wjYZug==" });
        }
    }
}
