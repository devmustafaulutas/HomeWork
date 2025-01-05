using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _23210202037.Migrations
{
    /// <inheritdoc />
    public partial class adminpanel2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "986bced8-5e8e-4729-b017-e7a336baacee", "AQAAAAIAAYagAAAAEB4CLxhDdhYhThpc+XoZy8KmKPdS7K8IgIYhwz1h3GPHybbBfASxXaLXETh/lb0tfg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f83af531-1503-4bcd-a772-8e51e5382443", "AQAAAAIAAYagAAAAEACEwtw6QbStvX3ZnL+wZp9Yr3UAqsAixn6CIC1aj8VyZqRBUSgoRD1qR49VXmjRUQ==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
