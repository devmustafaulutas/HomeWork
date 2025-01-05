using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _23210202037.Migrations
{
    /// <inheritdoc />
    public partial class adminpanel7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5e36bdcb-6595-4279-a832-ee3d4e0409c4", "AQAAAAIAAYagAAAAEETDDWZegw8c761DXif6/MqGZH0ZTwaYnREbsTTROz5QtBZ+gS/GS5v6Hct6khXcUw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fea3d4e1-50cf-4fa6-8dbc-eefd6bffce6c", "AQAAAAIAAYagAAAAEEZahqrVWyY7OCIv+n5QWu7T+wKjiiZTAw5szk/8vTz6WYTIzeAAmfpWStEuSZ7SWQ==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
