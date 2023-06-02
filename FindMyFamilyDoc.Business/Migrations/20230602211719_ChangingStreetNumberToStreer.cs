using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FindMyFamilyDoc.Business.Migrations
{
    /// <inheritdoc />
    public partial class ChangingStreetNumberToStreer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.RenameColumn(
                name: "StreetNumber",
                table: "Doctors",
                newName: "Street");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "64b4df56-68a6-4912-9516-093e9c346694", null, "Patience", "PATIENCE" },
                    { "94579850-f967-4661-b76f-f3030442fe55", null, "Admin", "ADMIN" },
                    { "abe1e3a6-fe61-4bcd-b930-68da6a9e3cb8", null, "Doctor", "DOCTOR" },
                    { "ca35150f-90e4-4e43-a991-c20a3b8595e2", null, "DoctorUnderReview", "DOCTORUNDERREVIEW" },
                    { "fec368b4-abe0-4f76-9e0e-28238f1fd195", null, "AdministractiveAssistant", "ADMINISTRACTIVEASSISTANT" }
                });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 2, 17, 17, 19, 83, DateTimeKind.Local).AddTicks(5396));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 2, 17, 17, 19, 83, DateTimeKind.Local).AddTicks(5399));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 2, 17, 17, 19, 83, DateTimeKind.Local).AddTicks(5401));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 2, 17, 17, 19, 83, DateTimeKind.Local).AddTicks(5403));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 2, 17, 17, 19, 83, DateTimeKind.Local).AddTicks(5405));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 2, 17, 17, 19, 83, DateTimeKind.Local).AddTicks(5407));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 2, 17, 17, 19, 83, DateTimeKind.Local).AddTicks(5409));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 2, 17, 17, 19, 83, DateTimeKind.Local).AddTicks(5410));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 2, 17, 17, 19, 83, DateTimeKind.Local).AddTicks(5711));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 2, 17, 17, 19, 83, DateTimeKind.Local).AddTicks(5713));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 2, 17, 17, 19, 83, DateTimeKind.Local).AddTicks(5715));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 2, 17, 17, 19, 83, DateTimeKind.Local).AddTicks(5717));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 2, 17, 17, 19, 83, DateTimeKind.Local).AddTicks(5719));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 2, 17, 17, 19, 83, DateTimeKind.Local).AddTicks(5720));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 2, 17, 17, 19, 83, DateTimeKind.Local).AddTicks(5722));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 2, 17, 17, 19, 83, DateTimeKind.Local).AddTicks(5724));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 2, 17, 17, 19, 83, DateTimeKind.Local).AddTicks(5726));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 2, 17, 17, 19, 83, DateTimeKind.Local).AddTicks(5729));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 2, 17, 17, 19, 83, DateTimeKind.Local).AddTicks(5730));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 2, 17, 17, 19, 83, DateTimeKind.Local).AddTicks(5732));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 2, 17, 17, 19, 83, DateTimeKind.Local).AddTicks(5748));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 2, 17, 17, 19, 83, DateTimeKind.Local).AddTicks(5750));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 2, 17, 17, 19, 83, DateTimeKind.Local).AddTicks(5752));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 2, 17, 17, 19, 83, DateTimeKind.Local).AddTicks(5754));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 2, 17, 17, 19, 83, DateTimeKind.Local).AddTicks(5756));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 2, 17, 17, 19, 83, DateTimeKind.Local).AddTicks(5765));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 2, 17, 17, 19, 83, DateTimeKind.Local).AddTicks(5767));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 2, 17, 17, 19, 83, DateTimeKind.Local).AddTicks(5769));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 2, 17, 17, 19, 83, DateTimeKind.Local).AddTicks(5771));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 2, 17, 17, 19, 83, DateTimeKind.Local).AddTicks(5823));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 2, 17, 17, 19, 83, DateTimeKind.Local).AddTicks(5832));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 2, 17, 17, 19, 83, DateTimeKind.Local).AddTicks(5834));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 2, 17, 17, 19, 83, DateTimeKind.Local).AddTicks(5836));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 2, 17, 17, 19, 83, DateTimeKind.Local).AddTicks(5843));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 2, 17, 17, 19, 83, DateTimeKind.Local).AddTicks(5845));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 2, 17, 17, 19, 83, DateTimeKind.Local).AddTicks(5856));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 2, 17, 17, 19, 83, DateTimeKind.Local).AddTicks(5858));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 2, 17, 17, 19, 83, DateTimeKind.Local).AddTicks(5860));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 2, 17, 17, 19, 83, DateTimeKind.Local).AddTicks(5862));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 2, 17, 17, 19, 83, DateTimeKind.Local).AddTicks(5863));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 2, 17, 17, 19, 83, DateTimeKind.Local).AddTicks(5872));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 2, 17, 17, 19, 83, DateTimeKind.Local).AddTicks(5985));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 2, 17, 17, 19, 83, DateTimeKind.Local).AddTicks(5987));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 2, 17, 17, 19, 83, DateTimeKind.Local).AddTicks(5989));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 2, 17, 17, 19, 83, DateTimeKind.Local).AddTicks(5991));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 2, 17, 17, 19, 83, DateTimeKind.Local).AddTicks(6000));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 2, 17, 17, 19, 83, DateTimeKind.Local).AddTicks(6002));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 2, 17, 17, 19, 83, DateTimeKind.Local).AddTicks(6004));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 2, 17, 17, 19, 83, DateTimeKind.Local).AddTicks(6006));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 2, 17, 17, 19, 83, DateTimeKind.Local).AddTicks(6008));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 2, 17, 17, 19, 83, DateTimeKind.Local).AddTicks(6081));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 2, 17, 17, 19, 83, DateTimeKind.Local).AddTicks(6084));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 2, 17, 17, 19, 83, DateTimeKind.Local).AddTicks(6086));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 2, 17, 17, 19, 83, DateTimeKind.Local).AddTicks(6087));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 2, 17, 17, 19, 83, DateTimeKind.Local).AddTicks(6089));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 2, 17, 17, 19, 83, DateTimeKind.Local).AddTicks(6091));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 2, 17, 17, 19, 83, DateTimeKind.Local).AddTicks(6092));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 2, 17, 17, 19, 83, DateTimeKind.Local).AddTicks(6094));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 2, 17, 17, 19, 83, DateTimeKind.Local).AddTicks(6096));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 2, 17, 17, 19, 83, DateTimeKind.Local).AddTicks(6097));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 2, 17, 17, 19, 83, DateTimeKind.Local).AddTicks(6100));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 2, 17, 17, 19, 83, DateTimeKind.Local).AddTicks(6101));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 2, 17, 17, 19, 83, DateTimeKind.Local).AddTicks(6103));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 2, 17, 17, 19, 83, DateTimeKind.Local).AddTicks(6105));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 2, 17, 17, 19, 83, DateTimeKind.Local).AddTicks(6106));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 2, 17, 17, 19, 83, DateTimeKind.Local).AddTicks(6111));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 2, 17, 17, 19, 83, DateTimeKind.Local).AddTicks(6112));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 2, 17, 17, 19, 83, DateTimeKind.Local).AddTicks(6114));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 2, 17, 17, 19, 83, DateTimeKind.Local).AddTicks(6115));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 2, 17, 17, 19, 83, DateTimeKind.Local).AddTicks(6117));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 2, 17, 17, 19, 83, DateTimeKind.Local).AddTicks(6119));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 2, 17, 17, 19, 83, DateTimeKind.Local).AddTicks(6120));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 2, 17, 17, 19, 83, DateTimeKind.Local).AddTicks(6122));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 2, 17, 17, 19, 83, DateTimeKind.Local).AddTicks(6124));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 2, 17, 17, 19, 83, DateTimeKind.Local).AddTicks(6125));

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 2, 17, 17, 19, 83, DateTimeKind.Local).AddTicks(6027));

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 2, 17, 17, 19, 83, DateTimeKind.Local).AddTicks(6030));

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 2, 17, 17, 19, 83, DateTimeKind.Local).AddTicks(6032));

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 2, 17, 17, 19, 83, DateTimeKind.Local).AddTicks(6034));

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 2, 17, 17, 19, 83, DateTimeKind.Local).AddTicks(6036));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 2, 17, 17, 19, 83, DateTimeKind.Local).AddTicks(4977));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 2, 17, 17, 19, 83, DateTimeKind.Local).AddTicks(5031));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 2, 17, 17, 19, 83, DateTimeKind.Local).AddTicks(5033));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 2, 17, 17, 19, 83, DateTimeKind.Local).AddTicks(5035));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 2, 17, 17, 19, 83, DateTimeKind.Local).AddTicks(5037));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 2, 17, 17, 19, 83, DateTimeKind.Local).AddTicks(5039));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 2, 17, 17, 19, 83, DateTimeKind.Local).AddTicks(5040));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 2, 17, 17, 19, 83, DateTimeKind.Local).AddTicks(5042));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 2, 17, 17, 19, 83, DateTimeKind.Local).AddTicks(5044));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 2, 17, 17, 19, 83, DateTimeKind.Local).AddTicks(5045));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 2, 17, 17, 19, 83, DateTimeKind.Local).AddTicks(5048));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 2, 17, 17, 19, 83, DateTimeKind.Local).AddTicks(5050));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 2, 17, 17, 19, 83, DateTimeKind.Local).AddTicks(5051));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "64b4df56-68a6-4912-9516-093e9c346694");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "94579850-f967-4661-b76f-f3030442fe55");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "abe1e3a6-fe61-4bcd-b930-68da6a9e3cb8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ca35150f-90e4-4e43-a991-c20a3b8595e2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fec368b4-abe0-4f76-9e0e-28238f1fd195");

            migrationBuilder.RenameColumn(
                name: "Street",
                table: "Doctors",
                newName: "StreetNumber");

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
        }
    }
}
