using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FindMyFamilyDoc.Business.Migrations
{
    /// <inheritdoc />
    public partial class AddingUniqueIndexToDoctor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Doctors_UserId",
                table: "Doctors");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0c2889a7-a25b-4e2f-ab02-2f7424f483c9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1575f5c9-240e-4db0-ac27-26ea2b68696a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3b6abcf8-f593-47ec-965b-b2695a895518");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b9c8ea55-015a-45c2-add4-4ef7195740a6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ea647c1f-52d0-4066-8da8-fd5c69d3804f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "09eff739-8337-4b75-8afb-697bc8e47f91", null, "Patience", "PATIENCE" },
                    { "6fc5f3ab-533f-4e52-b89e-6caa93b537de", null, "AdministractiveAssistant", "ADMINISTRACTIVEASSISTANT" },
                    { "72da2172-34d3-43ec-9977-3bbb8a1491e7", null, "Admin", "ADMIN" },
                    { "c33079ec-6978-422d-bab8-a6f3b4118fe6", null, "DoctorUnderReview", "DOCTORUNDERREVIEW" },
                    { "fe939799-a6d8-4fb3-b959-0429747005fd", null, "Doctor", "DOCTOR" }
                });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 22, 57, 48, 672, DateTimeKind.Local).AddTicks(863));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 22, 57, 48, 672, DateTimeKind.Local).AddTicks(865));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 22, 57, 48, 672, DateTimeKind.Local).AddTicks(867));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 22, 57, 48, 672, DateTimeKind.Local).AddTicks(868));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 22, 57, 48, 672, DateTimeKind.Local).AddTicks(870));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 22, 57, 48, 672, DateTimeKind.Local).AddTicks(872));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 22, 57, 48, 672, DateTimeKind.Local).AddTicks(873));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 22, 57, 48, 672, DateTimeKind.Local).AddTicks(875));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 22, 57, 48, 672, DateTimeKind.Local).AddTicks(877));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 22, 57, 48, 672, DateTimeKind.Local).AddTicks(878));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 22, 57, 48, 672, DateTimeKind.Local).AddTicks(881));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 22, 57, 48, 672, DateTimeKind.Local).AddTicks(883));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 22, 57, 48, 672, DateTimeKind.Local).AddTicks(884));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 22, 57, 48, 672, DateTimeKind.Local).AddTicks(886));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 22, 57, 48, 672, DateTimeKind.Local).AddTicks(887));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 22, 57, 48, 672, DateTimeKind.Local).AddTicks(918));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 22, 57, 48, 672, DateTimeKind.Local).AddTicks(920));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 22, 57, 48, 672, DateTimeKind.Local).AddTicks(922));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 22, 57, 48, 672, DateTimeKind.Local).AddTicks(924));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 22, 57, 48, 672, DateTimeKind.Local).AddTicks(925));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 22, 57, 48, 672, DateTimeKind.Local).AddTicks(942));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 22, 57, 48, 672, DateTimeKind.Local).AddTicks(944));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 22, 57, 48, 672, DateTimeKind.Local).AddTicks(946));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 22, 57, 48, 672, DateTimeKind.Local).AddTicks(947));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 22, 57, 48, 672, DateTimeKind.Local).AddTicks(949));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 22, 57, 48, 672, DateTimeKind.Local).AddTicks(957));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 22, 57, 48, 672, DateTimeKind.Local).AddTicks(959));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 22, 57, 48, 672, DateTimeKind.Local).AddTicks(961));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 22, 57, 48, 672, DateTimeKind.Local).AddTicks(964));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 22, 57, 48, 672, DateTimeKind.Local).AddTicks(966));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 22, 57, 48, 672, DateTimeKind.Local).AddTicks(973));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 22, 57, 48, 672, DateTimeKind.Local).AddTicks(975));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 22, 57, 48, 672, DateTimeKind.Local).AddTicks(977));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 22, 57, 48, 672, DateTimeKind.Local).AddTicks(979));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 22, 57, 48, 672, DateTimeKind.Local).AddTicks(980));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 22, 57, 48, 672, DateTimeKind.Local).AddTicks(989));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 22, 57, 48, 672, DateTimeKind.Local).AddTicks(991));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 22, 57, 48, 672, DateTimeKind.Local).AddTicks(993));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 22, 57, 48, 672, DateTimeKind.Local).AddTicks(994));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 22, 57, 48, 672, DateTimeKind.Local).AddTicks(996));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 22, 57, 48, 672, DateTimeKind.Local).AddTicks(1003));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 22, 57, 48, 672, DateTimeKind.Local).AddTicks(1006));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 22, 57, 48, 672, DateTimeKind.Local).AddTicks(1007));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 22, 57, 48, 672, DateTimeKind.Local).AddTicks(1009));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 22, 57, 48, 672, DateTimeKind.Local).AddTicks(1011));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 22, 57, 48, 672, DateTimeKind.Local).AddTicks(1019));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 22, 57, 48, 672, DateTimeKind.Local).AddTicks(1069));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 22, 57, 48, 672, DateTimeKind.Local).AddTicks(1070));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 22, 57, 48, 672, DateTimeKind.Local).AddTicks(1072));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 22, 57, 48, 672, DateTimeKind.Local).AddTicks(1074));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 22, 57, 48, 672, DateTimeKind.Local).AddTicks(1272));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 22, 57, 48, 672, DateTimeKind.Local).AddTicks(1274));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 22, 57, 48, 672, DateTimeKind.Local).AddTicks(1275));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 22, 57, 48, 672, DateTimeKind.Local).AddTicks(1277));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 22, 57, 48, 672, DateTimeKind.Local).AddTicks(1308));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 22, 57, 48, 672, DateTimeKind.Local).AddTicks(1310));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 22, 57, 48, 672, DateTimeKind.Local).AddTicks(1313));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 22, 57, 48, 672, DateTimeKind.Local).AddTicks(1315));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 22, 57, 48, 672, DateTimeKind.Local).AddTicks(1317));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 22, 57, 48, 672, DateTimeKind.Local).AddTicks(1318));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 22, 57, 48, 672, DateTimeKind.Local).AddTicks(1320));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 22, 57, 48, 672, DateTimeKind.Local).AddTicks(1321));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 22, 57, 48, 672, DateTimeKind.Local).AddTicks(1323));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 22, 57, 48, 672, DateTimeKind.Local).AddTicks(1325));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 22, 57, 48, 672, DateTimeKind.Local).AddTicks(1327));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 22, 57, 48, 672, DateTimeKind.Local).AddTicks(1331));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 22, 57, 48, 672, DateTimeKind.Local).AddTicks(1333));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 22, 57, 48, 672, DateTimeKind.Local).AddTicks(1335));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 22, 57, 48, 672, DateTimeKind.Local).AddTicks(1336));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 22, 57, 48, 672, DateTimeKind.Local).AddTicks(1338));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 22, 57, 48, 672, DateTimeKind.Local).AddTicks(1339));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 22, 57, 48, 672, DateTimeKind.Local).AddTicks(1341));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 22, 57, 48, 672, DateTimeKind.Local).AddTicks(1343));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 22, 57, 48, 672, DateTimeKind.Local).AddTicks(1344));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 22, 57, 48, 672, DateTimeKind.Local).AddTicks(1346));

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 22, 57, 48, 672, DateTimeKind.Local).AddTicks(1243));

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 22, 57, 48, 672, DateTimeKind.Local).AddTicks(1246));

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 22, 57, 48, 672, DateTimeKind.Local).AddTicks(1248));

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 22, 57, 48, 672, DateTimeKind.Local).AddTicks(1249));

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 22, 57, 48, 672, DateTimeKind.Local).AddTicks(1251));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 22, 57, 48, 672, DateTimeKind.Local).AddTicks(762));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 22, 57, 48, 672, DateTimeKind.Local).AddTicks(817));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 22, 57, 48, 672, DateTimeKind.Local).AddTicks(820));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 22, 57, 48, 672, DateTimeKind.Local).AddTicks(821));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 22, 57, 48, 672, DateTimeKind.Local).AddTicks(823));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 22, 57, 48, 672, DateTimeKind.Local).AddTicks(825));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 22, 57, 48, 672, DateTimeKind.Local).AddTicks(826));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 22, 57, 48, 672, DateTimeKind.Local).AddTicks(828));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 22, 57, 48, 672, DateTimeKind.Local).AddTicks(830));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 22, 57, 48, 672, DateTimeKind.Local).AddTicks(831));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 22, 57, 48, 672, DateTimeKind.Local).AddTicks(833));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 22, 57, 48, 672, DateTimeKind.Local).AddTicks(835));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 22, 57, 48, 672, DateTimeKind.Local).AddTicks(837));

            migrationBuilder.CreateIndex(
                name: "Unique_UserId_Doctor",
                table: "Doctors",
                column: "UserId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "Unique_UserId_Doctor",
                table: "Doctors");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "09eff739-8337-4b75-8afb-697bc8e47f91");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6fc5f3ab-533f-4e52-b89e-6caa93b537de");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "72da2172-34d3-43ec-9977-3bbb8a1491e7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c33079ec-6978-422d-bab8-a6f3b4118fe6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe939799-a6d8-4fb3-b959-0429747005fd");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0c2889a7-a25b-4e2f-ab02-2f7424f483c9", null, "Admin", "ADMIN" },
                    { "1575f5c9-240e-4db0-ac27-26ea2b68696a", null, "Patience", "PATIENCE" },
                    { "3b6abcf8-f593-47ec-965b-b2695a895518", null, "AdministractiveAssistant", "ADMINISTRACTIVEASSISTANT" },
                    { "b9c8ea55-015a-45c2-add4-4ef7195740a6", null, "DoctorUnderReview", "DOCTORUNDERREVIEW" },
                    { "ea647c1f-52d0-4066-8da8-fd5c69d3804f", null, "Doctor", "DOCTOR" }
                });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 21, 41, 46, 400, DateTimeKind.Local).AddTicks(7998));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 21, 41, 46, 400, DateTimeKind.Local).AddTicks(8000));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 21, 41, 46, 400, DateTimeKind.Local).AddTicks(8002));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 21, 41, 46, 400, DateTimeKind.Local).AddTicks(8004));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 21, 41, 46, 400, DateTimeKind.Local).AddTicks(8006));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 21, 41, 46, 400, DateTimeKind.Local).AddTicks(8007));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 21, 41, 46, 400, DateTimeKind.Local).AddTicks(8009));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 21, 41, 46, 400, DateTimeKind.Local).AddTicks(8011));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 21, 41, 46, 400, DateTimeKind.Local).AddTicks(8013));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 21, 41, 46, 400, DateTimeKind.Local).AddTicks(8015));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 21, 41, 46, 400, DateTimeKind.Local).AddTicks(8016));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 21, 41, 46, 400, DateTimeKind.Local).AddTicks(8018));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 21, 41, 46, 400, DateTimeKind.Local).AddTicks(8020));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 21, 41, 46, 400, DateTimeKind.Local).AddTicks(8022));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 21, 41, 46, 400, DateTimeKind.Local).AddTicks(8023));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 21, 41, 46, 400, DateTimeKind.Local).AddTicks(8026));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 21, 41, 46, 400, DateTimeKind.Local).AddTicks(8027));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 21, 41, 46, 400, DateTimeKind.Local).AddTicks(8029));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 21, 41, 46, 400, DateTimeKind.Local).AddTicks(8031));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 21, 41, 46, 400, DateTimeKind.Local).AddTicks(8033));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 21, 41, 46, 400, DateTimeKind.Local).AddTicks(8077));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 21, 41, 46, 400, DateTimeKind.Local).AddTicks(8079));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 21, 41, 46, 400, DateTimeKind.Local).AddTicks(8081));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 21, 41, 46, 400, DateTimeKind.Local).AddTicks(8083));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 21, 41, 46, 400, DateTimeKind.Local).AddTicks(8084));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 21, 41, 46, 400, DateTimeKind.Local).AddTicks(8093));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 21, 41, 46, 400, DateTimeKind.Local).AddTicks(8095));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 21, 41, 46, 400, DateTimeKind.Local).AddTicks(8109));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 21, 41, 46, 400, DateTimeKind.Local).AddTicks(8112));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 21, 41, 46, 400, DateTimeKind.Local).AddTicks(8114));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 21, 41, 46, 400, DateTimeKind.Local).AddTicks(8122));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 21, 41, 46, 400, DateTimeKind.Local).AddTicks(8124));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 21, 41, 46, 400, DateTimeKind.Local).AddTicks(8126));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 21, 41, 46, 400, DateTimeKind.Local).AddTicks(8128));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 21, 41, 46, 400, DateTimeKind.Local).AddTicks(8130));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 21, 41, 46, 400, DateTimeKind.Local).AddTicks(8287));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 21, 41, 46, 400, DateTimeKind.Local).AddTicks(8289));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 21, 41, 46, 400, DateTimeKind.Local).AddTicks(8291));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 21, 41, 46, 400, DateTimeKind.Local).AddTicks(8293));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 21, 41, 46, 400, DateTimeKind.Local).AddTicks(8295));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 21, 41, 46, 400, DateTimeKind.Local).AddTicks(8303));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 21, 41, 46, 400, DateTimeKind.Local).AddTicks(8305));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 21, 41, 46, 400, DateTimeKind.Local).AddTicks(8307));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 21, 41, 46, 400, DateTimeKind.Local).AddTicks(8309));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 21, 41, 46, 400, DateTimeKind.Local).AddTicks(8311));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 21, 41, 46, 400, DateTimeKind.Local).AddTicks(8319));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 21, 41, 46, 400, DateTimeKind.Local).AddTicks(8322));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 21, 41, 46, 400, DateTimeKind.Local).AddTicks(8324));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 21, 41, 46, 400, DateTimeKind.Local).AddTicks(8325));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 21, 41, 46, 400, DateTimeKind.Local).AddTicks(8327));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 21, 41, 46, 400, DateTimeKind.Local).AddTicks(8377));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 21, 41, 46, 400, DateTimeKind.Local).AddTicks(8379));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 21, 41, 46, 400, DateTimeKind.Local).AddTicks(8381));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 21, 41, 46, 400, DateTimeKind.Local).AddTicks(8383));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 21, 41, 46, 400, DateTimeKind.Local).AddTicks(8384));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 21, 41, 46, 400, DateTimeKind.Local).AddTicks(8386));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 21, 41, 46, 400, DateTimeKind.Local).AddTicks(8388));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 21, 41, 46, 400, DateTimeKind.Local).AddTicks(8389));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 21, 41, 46, 400, DateTimeKind.Local).AddTicks(8391));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 21, 41, 46, 400, DateTimeKind.Local).AddTicks(8393));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 21, 41, 46, 400, DateTimeKind.Local).AddTicks(8395));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 21, 41, 46, 400, DateTimeKind.Local).AddTicks(8425));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 21, 41, 46, 400, DateTimeKind.Local).AddTicks(8429));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 21, 41, 46, 400, DateTimeKind.Local).AddTicks(8431));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 21, 41, 46, 400, DateTimeKind.Local).AddTicks(8432));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 21, 41, 46, 400, DateTimeKind.Local).AddTicks(8434));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 21, 41, 46, 400, DateTimeKind.Local).AddTicks(8436));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 21, 41, 46, 400, DateTimeKind.Local).AddTicks(8441));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 21, 41, 46, 400, DateTimeKind.Local).AddTicks(8442));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 21, 41, 46, 400, DateTimeKind.Local).AddTicks(8444));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 21, 41, 46, 400, DateTimeKind.Local).AddTicks(8446));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 21, 41, 46, 400, DateTimeKind.Local).AddTicks(8448));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 21, 41, 46, 400, DateTimeKind.Local).AddTicks(8449));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 21, 41, 46, 400, DateTimeKind.Local).AddTicks(8451));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 21, 41, 46, 400, DateTimeKind.Local).AddTicks(8453));

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 21, 41, 46, 400, DateTimeKind.Local).AddTicks(8345));

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 21, 41, 46, 400, DateTimeKind.Local).AddTicks(8347));

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 21, 41, 46, 400, DateTimeKind.Local).AddTicks(8349));

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 21, 41, 46, 400, DateTimeKind.Local).AddTicks(8351));

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 21, 41, 46, 400, DateTimeKind.Local).AddTicks(8354));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 21, 41, 46, 400, DateTimeKind.Local).AddTicks(7895));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 21, 41, 46, 400, DateTimeKind.Local).AddTicks(7950));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 21, 41, 46, 400, DateTimeKind.Local).AddTicks(7952));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 21, 41, 46, 400, DateTimeKind.Local).AddTicks(7954));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 21, 41, 46, 400, DateTimeKind.Local).AddTicks(7956));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 21, 41, 46, 400, DateTimeKind.Local).AddTicks(7957));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 21, 41, 46, 400, DateTimeKind.Local).AddTicks(7959));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 21, 41, 46, 400, DateTimeKind.Local).AddTicks(7961));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 21, 41, 46, 400, DateTimeKind.Local).AddTicks(7962));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 21, 41, 46, 400, DateTimeKind.Local).AddTicks(7964));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 21, 41, 46, 400, DateTimeKind.Local).AddTicks(7966));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 21, 41, 46, 400, DateTimeKind.Local).AddTicks(7967));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 1, 21, 41, 46, 400, DateTimeKind.Local).AddTicks(7969));

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_UserId",
                table: "Doctors",
                column: "UserId");
        }
    }
}
