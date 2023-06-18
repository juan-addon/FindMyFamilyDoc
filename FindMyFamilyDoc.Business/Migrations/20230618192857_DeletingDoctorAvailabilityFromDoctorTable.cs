using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FindMyFamilyDoc.Business.Migrations
{
    /// <inheritdoc />
    public partial class DeletingDoctorAvailabilityFromDoctorTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0c7fa81e-3211-4619-8053-01ce3d5202b5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "269254de-1b3c-4d25-86e3-c1ae2863b93c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5cd7a858-6409-42b9-bd12-81a44f2a9c70");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cf3b99ae-fd11-478f-bd56-520fc99491d9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ede39295-f384-481f-a357-0f4310b594b7");

            migrationBuilder.DropColumn(
                name: "Availability",
                table: "Doctors");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "9fe99b2a-f910-46fe-b245-6721a4f84770", null, "AdministrativeAssistant", "ADMINISTRATIVEASSISTANT" },
                    { "a0e483ab-4a68-42f5-ab87-6ac47580be55", null, "DoctorUnderReview", "DOCTORUNDERREVIEW" },
                    { "c4c3991b-6790-47ac-8a47-436048e670fd", null, "Patient", "PATIENT" },
                    { "da142746-1e3c-4b3a-a269-786e5954f8a9", null, "Admin", "ADMIN" },
                    { "da878656-14a9-4213-a216-b331880b8eae", null, "Doctor", "DOCTOR" }
                });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 28, 57, 590, DateTimeKind.Local).AddTicks(638));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 28, 57, 590, DateTimeKind.Local).AddTicks(643));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 28, 57, 590, DateTimeKind.Local).AddTicks(648));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 28, 57, 590, DateTimeKind.Local).AddTicks(653));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 28, 57, 590, DateTimeKind.Local).AddTicks(657));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 28, 57, 590, DateTimeKind.Local).AddTicks(663));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 28, 57, 590, DateTimeKind.Local).AddTicks(668));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 28, 57, 590, DateTimeKind.Local).AddTicks(672));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 28, 57, 590, DateTimeKind.Local).AddTicks(676));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 28, 57, 590, DateTimeKind.Local).AddTicks(680));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 28, 57, 590, DateTimeKind.Local).AddTicks(801));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 28, 57, 590, DateTimeKind.Local).AddTicks(806));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 28, 57, 590, DateTimeKind.Local).AddTicks(810));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 28, 57, 590, DateTimeKind.Local).AddTicks(814));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 28, 57, 590, DateTimeKind.Local).AddTicks(818));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 28, 57, 590, DateTimeKind.Local).AddTicks(822));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 28, 57, 590, DateTimeKind.Local).AddTicks(826));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 28, 57, 590, DateTimeKind.Local).AddTicks(830));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 28, 57, 590, DateTimeKind.Local).AddTicks(834));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 28, 57, 590, DateTimeKind.Local).AddTicks(838));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 28, 57, 590, DateTimeKind.Local).AddTicks(861));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 28, 57, 590, DateTimeKind.Local).AddTicks(866));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 28, 57, 590, DateTimeKind.Local).AddTicks(870));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 28, 57, 590, DateTimeKind.Local).AddTicks(874));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 28, 57, 590, DateTimeKind.Local).AddTicks(883));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 28, 57, 590, DateTimeKind.Local).AddTicks(897));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 28, 57, 590, DateTimeKind.Local).AddTicks(901));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 28, 57, 590, DateTimeKind.Local).AddTicks(905));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 28, 57, 590, DateTimeKind.Local).AddTicks(909));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 28, 57, 590, DateTimeKind.Local).AddTicks(914));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 28, 57, 590, DateTimeKind.Local).AddTicks(927));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 28, 57, 590, DateTimeKind.Local).AddTicks(932));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 28, 57, 590, DateTimeKind.Local).AddTicks(936));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 28, 57, 590, DateTimeKind.Local).AddTicks(940));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 28, 57, 590, DateTimeKind.Local).AddTicks(943));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 28, 57, 590, DateTimeKind.Local).AddTicks(960));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 28, 57, 590, DateTimeKind.Local).AddTicks(964));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 28, 57, 590, DateTimeKind.Local).AddTicks(968));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 28, 57, 590, DateTimeKind.Local).AddTicks(972));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 28, 57, 590, DateTimeKind.Local).AddTicks(1030));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 28, 57, 590, DateTimeKind.Local).AddTicks(1046));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 28, 57, 590, DateTimeKind.Local).AddTicks(1051));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 28, 57, 590, DateTimeKind.Local).AddTicks(1056));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 28, 57, 590, DateTimeKind.Local).AddTicks(1060));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 28, 57, 590, DateTimeKind.Local).AddTicks(1064));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 28, 57, 590, DateTimeKind.Local).AddTicks(1078));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 28, 57, 590, DateTimeKind.Local).AddTicks(1082));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 28, 57, 590, DateTimeKind.Local).AddTicks(1086));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 28, 57, 590, DateTimeKind.Local).AddTicks(1090));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 28, 57, 590, DateTimeKind.Local).AddTicks(1094));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 28, 57, 590, DateTimeKind.Local).AddTicks(1246));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 28, 57, 590, DateTimeKind.Local).AddTicks(1250));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 28, 57, 590, DateTimeKind.Local).AddTicks(1254));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 28, 57, 590, DateTimeKind.Local).AddTicks(1258));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 28, 57, 590, DateTimeKind.Local).AddTicks(1262));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 28, 57, 590, DateTimeKind.Local).AddTicks(1266));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 28, 57, 590, DateTimeKind.Local).AddTicks(1270));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 28, 57, 590, DateTimeKind.Local).AddTicks(1274));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 28, 57, 590, DateTimeKind.Local).AddTicks(1278));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 28, 57, 590, DateTimeKind.Local).AddTicks(1281));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 28, 57, 590, DateTimeKind.Local).AddTicks(1285));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 28, 57, 590, DateTimeKind.Local).AddTicks(1290));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 28, 57, 590, DateTimeKind.Local).AddTicks(1294));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 28, 57, 590, DateTimeKind.Local).AddTicks(1298));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 28, 57, 590, DateTimeKind.Local).AddTicks(1302));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 28, 57, 590, DateTimeKind.Local).AddTicks(1305));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 28, 57, 590, DateTimeKind.Local).AddTicks(1309));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 28, 57, 590, DateTimeKind.Local).AddTicks(1313));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 28, 57, 590, DateTimeKind.Local).AddTicks(1317));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 28, 57, 590, DateTimeKind.Local).AddTicks(1320));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 28, 57, 590, DateTimeKind.Local).AddTicks(1324));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 28, 57, 590, DateTimeKind.Local).AddTicks(1328));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 28, 57, 590, DateTimeKind.Local).AddTicks(1331));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 28, 57, 590, DateTimeKind.Local).AddTicks(1335));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 28, 57, 590, DateTimeKind.Local).AddTicks(1339));

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 28, 57, 590, DateTimeKind.Local).AddTicks(1122));

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 28, 57, 590, DateTimeKind.Local).AddTicks(1126));

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 28, 57, 590, DateTimeKind.Local).AddTicks(1130));

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 28, 57, 590, DateTimeKind.Local).AddTicks(1134));

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 28, 57, 590, DateTimeKind.Local).AddTicks(1138));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 28, 57, 589, DateTimeKind.Local).AddTicks(8297));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 28, 57, 589, DateTimeKind.Local).AddTicks(8303));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 28, 57, 589, DateTimeKind.Local).AddTicks(8308));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 28, 57, 589, DateTimeKind.Local).AddTicks(8312));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 28, 57, 590, DateTimeKind.Local).AddTicks(515));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 28, 57, 590, DateTimeKind.Local).AddTicks(521));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 28, 57, 590, DateTimeKind.Local).AddTicks(525));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 28, 57, 590, DateTimeKind.Local).AddTicks(529));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 28, 57, 590, DateTimeKind.Local).AddTicks(534));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 28, 57, 590, DateTimeKind.Local).AddTicks(538));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 28, 57, 590, DateTimeKind.Local).AddTicks(542));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 28, 57, 590, DateTimeKind.Local).AddTicks(546));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 28, 57, 590, DateTimeKind.Local).AddTicks(550));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9fe99b2a-f910-46fe-b245-6721a4f84770");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a0e483ab-4a68-42f5-ab87-6ac47580be55");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c4c3991b-6790-47ac-8a47-436048e670fd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "da142746-1e3c-4b3a-a269-786e5954f8a9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "da878656-14a9-4213-a216-b331880b8eae");

            migrationBuilder.AddColumn<string>(
                name: "Availability",
                table: "Doctors",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0c7fa81e-3211-4619-8053-01ce3d5202b5", null, "Doctor", "DOCTOR" },
                    { "269254de-1b3c-4d25-86e3-c1ae2863b93c", null, "Admin", "ADMIN" },
                    { "5cd7a858-6409-42b9-bd12-81a44f2a9c70", null, "Patient", "PATIENT" },
                    { "cf3b99ae-fd11-478f-bd56-520fc99491d9", null, "AdministrativeAssistant", "ADMINISTRATIVEASSISTANT" },
                    { "ede39295-f384-481f-a357-0f4310b594b7", null, "DoctorUnderReview", "DOCTORUNDERREVIEW" }
                });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 13, 20, 173, DateTimeKind.Local).AddTicks(2445));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 13, 20, 173, DateTimeKind.Local).AddTicks(2448));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 13, 20, 173, DateTimeKind.Local).AddTicks(2450));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 13, 20, 173, DateTimeKind.Local).AddTicks(2453));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 13, 20, 173, DateTimeKind.Local).AddTicks(2456));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 13, 20, 173, DateTimeKind.Local).AddTicks(2460));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 13, 20, 173, DateTimeKind.Local).AddTicks(2462));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 13, 20, 173, DateTimeKind.Local).AddTicks(2465));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 13, 20, 173, DateTimeKind.Local).AddTicks(2468));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 13, 20, 173, DateTimeKind.Local).AddTicks(2470));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 13, 20, 173, DateTimeKind.Local).AddTicks(2473));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 13, 20, 173, DateTimeKind.Local).AddTicks(2475));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 13, 20, 173, DateTimeKind.Local).AddTicks(2478));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 13, 20, 173, DateTimeKind.Local).AddTicks(2481));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 13, 20, 173, DateTimeKind.Local).AddTicks(2522));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 13, 20, 173, DateTimeKind.Local).AddTicks(2525));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 13, 20, 173, DateTimeKind.Local).AddTicks(2528));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 13, 20, 173, DateTimeKind.Local).AddTicks(2531));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 13, 20, 173, DateTimeKind.Local).AddTicks(2534));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 13, 20, 173, DateTimeKind.Local).AddTicks(2537));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 13, 20, 173, DateTimeKind.Local).AddTicks(2553));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 13, 20, 173, DateTimeKind.Local).AddTicks(2556));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 13, 20, 173, DateTimeKind.Local).AddTicks(2559));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 13, 20, 173, DateTimeKind.Local).AddTicks(2562));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 13, 20, 173, DateTimeKind.Local).AddTicks(2565));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 13, 20, 173, DateTimeKind.Local).AddTicks(2576));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 13, 20, 173, DateTimeKind.Local).AddTicks(2579));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 13, 20, 173, DateTimeKind.Local).AddTicks(2582));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 13, 20, 173, DateTimeKind.Local).AddTicks(2584));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 13, 20, 173, DateTimeKind.Local).AddTicks(2587));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 13, 20, 173, DateTimeKind.Local).AddTicks(2596));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 13, 20, 173, DateTimeKind.Local).AddTicks(2599));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 13, 20, 173, DateTimeKind.Local).AddTicks(2602));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 13, 20, 173, DateTimeKind.Local).AddTicks(2604));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 13, 20, 173, DateTimeKind.Local).AddTicks(2607));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 13, 20, 173, DateTimeKind.Local).AddTicks(2617));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 13, 20, 173, DateTimeKind.Local).AddTicks(2620));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 13, 20, 173, DateTimeKind.Local).AddTicks(2622));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 13, 20, 173, DateTimeKind.Local).AddTicks(2625));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 13, 20, 173, DateTimeKind.Local).AddTicks(2628));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 13, 20, 173, DateTimeKind.Local).AddTicks(2637));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 13, 20, 173, DateTimeKind.Local).AddTicks(2644));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 13, 20, 173, DateTimeKind.Local).AddTicks(2647));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 13, 20, 173, DateTimeKind.Local).AddTicks(2650));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 13, 20, 173, DateTimeKind.Local).AddTicks(2652));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 13, 20, 173, DateTimeKind.Local).AddTicks(2661));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 13, 20, 173, DateTimeKind.Local).AddTicks(2664));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 13, 20, 173, DateTimeKind.Local).AddTicks(2666));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 13, 20, 173, DateTimeKind.Local).AddTicks(2669));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 13, 20, 173, DateTimeKind.Local).AddTicks(2672));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 13, 20, 173, DateTimeKind.Local).AddTicks(2719));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 13, 20, 173, DateTimeKind.Local).AddTicks(2722));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 13, 20, 173, DateTimeKind.Local).AddTicks(2725));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 13, 20, 173, DateTimeKind.Local).AddTicks(2752));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 13, 20, 173, DateTimeKind.Local).AddTicks(2754));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 13, 20, 173, DateTimeKind.Local).AddTicks(2757));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 13, 20, 173, DateTimeKind.Local).AddTicks(2760));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 13, 20, 173, DateTimeKind.Local).AddTicks(2762));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 13, 20, 173, DateTimeKind.Local).AddTicks(2765));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 13, 20, 173, DateTimeKind.Local).AddTicks(2767));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 13, 20, 173, DateTimeKind.Local).AddTicks(2770));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 13, 20, 173, DateTimeKind.Local).AddTicks(2773));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 13, 20, 173, DateTimeKind.Local).AddTicks(2776));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 13, 20, 173, DateTimeKind.Local).AddTicks(2779));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 13, 20, 173, DateTimeKind.Local).AddTicks(2782));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 13, 20, 173, DateTimeKind.Local).AddTicks(2784));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 13, 20, 173, DateTimeKind.Local).AddTicks(2787));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 13, 20, 173, DateTimeKind.Local).AddTicks(2789));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 13, 20, 173, DateTimeKind.Local).AddTicks(2791));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 13, 20, 173, DateTimeKind.Local).AddTicks(2794));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 13, 20, 173, DateTimeKind.Local).AddTicks(2796));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 13, 20, 173, DateTimeKind.Local).AddTicks(2799));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 13, 20, 173, DateTimeKind.Local).AddTicks(2802));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 13, 20, 173, DateTimeKind.Local).AddTicks(2805));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 13, 20, 173, DateTimeKind.Local).AddTicks(2807));

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 13, 20, 173, DateTimeKind.Local).AddTicks(2688));

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 13, 20, 173, DateTimeKind.Local).AddTicks(2691));

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 13, 20, 173, DateTimeKind.Local).AddTicks(2694));

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 13, 20, 173, DateTimeKind.Local).AddTicks(2696));

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 13, 20, 173, DateTimeKind.Local).AddTicks(2699));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 13, 20, 173, DateTimeKind.Local).AddTicks(2378));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 13, 20, 173, DateTimeKind.Local).AddTicks(2383));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 13, 20, 173, DateTimeKind.Local).AddTicks(2387));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 13, 20, 173, DateTimeKind.Local).AddTicks(2390));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 13, 20, 173, DateTimeKind.Local).AddTicks(2393));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 13, 20, 173, DateTimeKind.Local).AddTicks(2396));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 13, 20, 173, DateTimeKind.Local).AddTicks(2399));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 13, 20, 173, DateTimeKind.Local).AddTicks(2402));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 13, 20, 173, DateTimeKind.Local).AddTicks(2405));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 13, 20, 173, DateTimeKind.Local).AddTicks(2407));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 13, 20, 173, DateTimeKind.Local).AddTicks(2410));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 13, 20, 173, DateTimeKind.Local).AddTicks(2412));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 13, 20, 173, DateTimeKind.Local).AddTicks(2415));
        }
    }
}
