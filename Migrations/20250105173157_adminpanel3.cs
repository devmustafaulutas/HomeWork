using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _23210202037.Migrations
{
    /// <inheritdoc />
    public partial class adminpanel3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
