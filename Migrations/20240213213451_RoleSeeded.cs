using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IdentityTest.Migrations
{
    /// <inheritdoc />
    public partial class RoleSeeded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4682a738-0470-4a2f-8027-728240114bb0", "2", "Patient", "Patient" },
                    { "853a5b92-1481-4752-b78e-667f1cc626b9", "3", "Doctor", "Doctor" },
                    { "a9eb75dc-94a7-420e-9153-9d1e4e3351b9", "1", "Admin", "Admin" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4682a738-0470-4a2f-8027-728240114bb0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "853a5b92-1481-4752-b78e-667f1cc626b9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a9eb75dc-94a7-420e-9153-9d1e4e3351b9");
        }
    }
}
