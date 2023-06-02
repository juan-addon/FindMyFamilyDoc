using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FindMyFamilyDoc.Business.Migrations
{
    /// <inheritdoc />
    public partial class RolesUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5622866b-22d2-4ebd-baf1-1c1eac3d9224");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7478db40-0a8c-4090-8559-235434cb9d59");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b114801d-0a25-46f1-9125-73d70e8e0ffd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c928f576-caaf-4bfb-9816-316e63971463");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                    { "5622866b-22d2-4ebd-baf1-1c1eac3d9224", null, "Admin", "ADMIN" },
                    { "7478db40-0a8c-4090-8559-235434cb9d59", null, "Patience", "PATIENCE" },
                    { "b114801d-0a25-46f1-9125-73d70e8e0ffd", null, "Doctor", "DOCTOR" },
                    { "c928f576-caaf-4bfb-9816-316e63971463", null, "AdministractiveAssistant", "ADMINISTRACTIVEASSISTANT" }
                });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 31, 23, 3, 20, 814, DateTimeKind.Local).AddTicks(9544));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 31, 23, 3, 20, 814, DateTimeKind.Local).AddTicks(9547));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 31, 23, 3, 20, 814, DateTimeKind.Local).AddTicks(9549));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 31, 23, 3, 20, 814, DateTimeKind.Local).AddTicks(9551));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 31, 23, 3, 20, 814, DateTimeKind.Local).AddTicks(9552));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 31, 23, 3, 20, 814, DateTimeKind.Local).AddTicks(9554));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 31, 23, 3, 20, 814, DateTimeKind.Local).AddTicks(9556));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 31, 23, 3, 20, 814, DateTimeKind.Local).AddTicks(9557));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 31, 23, 3, 20, 814, DateTimeKind.Local).AddTicks(9559));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 31, 23, 3, 20, 814, DateTimeKind.Local).AddTicks(9561));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 31, 23, 3, 20, 814, DateTimeKind.Local).AddTicks(9562));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 31, 23, 3, 20, 814, DateTimeKind.Local).AddTicks(9588));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 31, 23, 3, 20, 814, DateTimeKind.Local).AddTicks(9590));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 31, 23, 3, 20, 814, DateTimeKind.Local).AddTicks(9592));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 31, 23, 3, 20, 814, DateTimeKind.Local).AddTicks(9594));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 31, 23, 3, 20, 814, DateTimeKind.Local).AddTicks(9597));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 31, 23, 3, 20, 814, DateTimeKind.Local).AddTicks(9598));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 31, 23, 3, 20, 814, DateTimeKind.Local).AddTicks(9600));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 31, 23, 3, 20, 814, DateTimeKind.Local).AddTicks(9602));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 31, 23, 3, 20, 814, DateTimeKind.Local).AddTicks(9604));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 31, 23, 3, 20, 814, DateTimeKind.Local).AddTicks(9619));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 31, 23, 3, 20, 814, DateTimeKind.Local).AddTicks(9621));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 31, 23, 3, 20, 814, DateTimeKind.Local).AddTicks(9623));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 31, 23, 3, 20, 814, DateTimeKind.Local).AddTicks(9624));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 31, 23, 3, 20, 814, DateTimeKind.Local).AddTicks(9626));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 31, 23, 3, 20, 814, DateTimeKind.Local).AddTicks(9634));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 31, 23, 3, 20, 814, DateTimeKind.Local).AddTicks(9636));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 31, 23, 3, 20, 814, DateTimeKind.Local).AddTicks(9638));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 31, 23, 3, 20, 814, DateTimeKind.Local).AddTicks(9640));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 31, 23, 3, 20, 814, DateTimeKind.Local).AddTicks(9641));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 31, 23, 3, 20, 814, DateTimeKind.Local).AddTicks(9649));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 31, 23, 3, 20, 814, DateTimeKind.Local).AddTicks(9651));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 31, 23, 3, 20, 814, DateTimeKind.Local).AddTicks(9654));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 31, 23, 3, 20, 814, DateTimeKind.Local).AddTicks(9655));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 31, 23, 3, 20, 814, DateTimeKind.Local).AddTicks(9657));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 31, 23, 3, 20, 814, DateTimeKind.Local).AddTicks(9666));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 31, 23, 3, 20, 814, DateTimeKind.Local).AddTicks(9668));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 31, 23, 3, 20, 814, DateTimeKind.Local).AddTicks(9670));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 31, 23, 3, 20, 814, DateTimeKind.Local).AddTicks(9672));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 31, 23, 3, 20, 814, DateTimeKind.Local).AddTicks(9673));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 31, 23, 3, 20, 814, DateTimeKind.Local).AddTicks(9681));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 31, 23, 3, 20, 814, DateTimeKind.Local).AddTicks(9683));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 31, 23, 3, 20, 814, DateTimeKind.Local).AddTicks(9685));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 31, 23, 3, 20, 814, DateTimeKind.Local).AddTicks(9687));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 31, 23, 3, 20, 814, DateTimeKind.Local).AddTicks(9688));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 31, 23, 3, 20, 814, DateTimeKind.Local).AddTicks(9696));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 31, 23, 3, 20, 814, DateTimeKind.Local).AddTicks(9698));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 31, 23, 3, 20, 814, DateTimeKind.Local).AddTicks(9700));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 31, 23, 3, 20, 814, DateTimeKind.Local).AddTicks(9702));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 31, 23, 3, 20, 814, DateTimeKind.Local).AddTicks(9704));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 31, 23, 3, 20, 814, DateTimeKind.Local).AddTicks(9782));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 31, 23, 3, 20, 814, DateTimeKind.Local).AddTicks(9784));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 31, 23, 3, 20, 814, DateTimeKind.Local).AddTicks(9786));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 31, 23, 3, 20, 814, DateTimeKind.Local).AddTicks(9788));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 31, 23, 3, 20, 814, DateTimeKind.Local).AddTicks(9789));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 31, 23, 3, 20, 814, DateTimeKind.Local).AddTicks(9791));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 31, 23, 3, 20, 814, DateTimeKind.Local).AddTicks(9792));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 31, 23, 3, 20, 814, DateTimeKind.Local).AddTicks(9794));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 31, 23, 3, 20, 814, DateTimeKind.Local).AddTicks(9796));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 31, 23, 3, 20, 814, DateTimeKind.Local).AddTicks(9797));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 31, 23, 3, 20, 814, DateTimeKind.Local).AddTicks(9799));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 31, 23, 3, 20, 814, DateTimeKind.Local).AddTicks(9801));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 31, 23, 3, 20, 814, DateTimeKind.Local).AddTicks(9802));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 31, 23, 3, 20, 814, DateTimeKind.Local).AddTicks(9804));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 31, 23, 3, 20, 814, DateTimeKind.Local).AddTicks(9805));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 31, 23, 3, 20, 814, DateTimeKind.Local).AddTicks(9807));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 31, 23, 3, 20, 814, DateTimeKind.Local).AddTicks(9808));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 31, 23, 3, 20, 814, DateTimeKind.Local).AddTicks(9810));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 31, 23, 3, 20, 814, DateTimeKind.Local).AddTicks(9812));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 31, 23, 3, 20, 814, DateTimeKind.Local).AddTicks(9813));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 31, 23, 3, 20, 814, DateTimeKind.Local).AddTicks(9815));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 31, 23, 3, 20, 814, DateTimeKind.Local).AddTicks(9817));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 31, 23, 3, 20, 814, DateTimeKind.Local).AddTicks(9818));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 31, 23, 3, 20, 814, DateTimeKind.Local).AddTicks(9820));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 31, 23, 3, 20, 814, DateTimeKind.Local).AddTicks(9821));

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 31, 23, 3, 20, 814, DateTimeKind.Local).AddTicks(9718));

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 31, 23, 3, 20, 814, DateTimeKind.Local).AddTicks(9721));

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 31, 23, 3, 20, 814, DateTimeKind.Local).AddTicks(9722));

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 31, 23, 3, 20, 814, DateTimeKind.Local).AddTicks(9724));

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 31, 23, 3, 20, 814, DateTimeKind.Local).AddTicks(9725));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 31, 23, 3, 20, 814, DateTimeKind.Local).AddTicks(9440));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 31, 23, 3, 20, 814, DateTimeKind.Local).AddTicks(9498));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 31, 23, 3, 20, 814, DateTimeKind.Local).AddTicks(9500));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 31, 23, 3, 20, 814, DateTimeKind.Local).AddTicks(9503));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 31, 23, 3, 20, 814, DateTimeKind.Local).AddTicks(9504));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 31, 23, 3, 20, 814, DateTimeKind.Local).AddTicks(9506));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 31, 23, 3, 20, 814, DateTimeKind.Local).AddTicks(9508));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 31, 23, 3, 20, 814, DateTimeKind.Local).AddTicks(9509));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 31, 23, 3, 20, 814, DateTimeKind.Local).AddTicks(9512));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 31, 23, 3, 20, 814, DateTimeKind.Local).AddTicks(9514));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 31, 23, 3, 20, 814, DateTimeKind.Local).AddTicks(9515));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 31, 23, 3, 20, 814, DateTimeKind.Local).AddTicks(9517));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 31, 23, 3, 20, 814, DateTimeKind.Local).AddTicks(9518));
        }
    }
}
