using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FindMyFamilyDoc.API.Migrations
{
    /// <inheritdoc />
    public partial class AddingRequireEmailtotheIdentityTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "32465078-3967-4158-a072-7c5b22c5cae7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6fa675e1-c142-4cdd-a195-31dedb3c46a9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8d2a49e0-fd50-4195-b194-6b21473f4d24");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b3746db7-cd67-4e33-b688-147b70c88782");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4c267229-9a25-41d4-9fbd-4ed3b2380a0a", null, "AdministractiveAssistant", "ADMINISTRACTIVEASSISTANT" },
                    { "4c84f586-ae5a-48e7-9bde-d65ab12fb12d", null, "Doctor", "DOCTOR" },
                    { "683e9c4d-732b-4900-bd96-f4e6e4fe4d30", null, "Admin", "ADMIN" },
                    { "afab5d04-8309-46fe-81bb-3c468352a367", null, "Patience", "PATIENCE" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4c267229-9a25-41d4-9fbd-4ed3b2380a0a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4c84f586-ae5a-48e7-9bde-d65ab12fb12d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "683e9c4d-732b-4900-bd96-f4e6e4fe4d30");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "afab5d04-8309-46fe-81bb-3c468352a367");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "32465078-3967-4158-a072-7c5b22c5cae7", null, "Admin", "ADMIN" },
                    { "6fa675e1-c142-4cdd-a195-31dedb3c46a9", null, "AdministractiveAssistant", "ADMINISTRACTIVEASSISTANT" },
                    { "8d2a49e0-fd50-4195-b194-6b21473f4d24", null, "Patience", "PATIENCE" },
                    { "b3746db7-cd67-4e33-b688-147b70c88782", null, "Doctor", "DOCTOR" }
                });
        }
    }
}
