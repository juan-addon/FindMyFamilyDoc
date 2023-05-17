using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FindMyFamilyDoc.API.Migrations
{
    /// <inheritdoc />
    public partial class AddingRefreshTokenTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "UserRefreshTokens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRefreshTokens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserRefreshTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "172d198c-fb43-4ab5-83e9-262b69d4c349", null, "Doctor", "DOCTOR" },
                    { "53a25318-b682-4e24-adb2-620e287da33b", null, "Admin", "ADMIN" },
                    { "775c11fc-d913-45d6-ab1a-cea976305751", null, "Patience", "PATIENCE" },
                    { "ea5498fc-fa01-4005-b381-4c133b2d45b6", null, "AdministractiveAssistant", "ADMINISTRACTIVEASSISTANT" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserRefreshTokens_UserId",
                table: "UserRefreshTokens",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserRefreshTokens");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "172d198c-fb43-4ab5-83e9-262b69d4c349");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "53a25318-b682-4e24-adb2-620e287da33b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "775c11fc-d913-45d6-ab1a-cea976305751");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ea5498fc-fa01-4005-b381-4c133b2d45b6");

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
    }
}
