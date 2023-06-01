using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FindMyFamilyDoc.Business.Migrations
{
    /// <inheritdoc />
    public partial class DoctorProfileAdjusments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "05db3c49-7fbd-475a-9cc9-45c969d9c0c7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "215c7543-fc5a-4c28-9791-5b1e0b39774a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1959f18-aa2d-4183-824c-b6cfc7323304");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a767556d-fd18-45b8-b7e3-6f1f99fa42f0");

            migrationBuilder.AddColumn<int>(
                name: "CityId",
                table: "Doctors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "PostalCode",
                table: "Doctors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "StreetNumber",
                table: "Doctors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_CityId",
                table: "Doctors",
                column: "CityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_Cities_CityId",
                table: "Doctors",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_Cities_CityId",
                table: "Doctors");

            migrationBuilder.DropIndex(
                name: "IX_Doctors_CityId",
                table: "Doctors");

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

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "PostalCode",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "StreetNumber",
                table: "Doctors");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "05db3c49-7fbd-475a-9cc9-45c969d9c0c7", null, "AdministractiveAssistant", "ADMINISTRACTIVEASSISTANT" },
                    { "215c7543-fc5a-4c28-9791-5b1e0b39774a", null, "Doctor", "DOCTOR" },
                    { "a1959f18-aa2d-4183-824c-b6cfc7323304", null, "Admin", "ADMIN" },
                    { "a767556d-fd18-45b8-b7e3-6f1f99fa42f0", null, "Patience", "PATIENCE" }
                });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 37, 16, 10, DateTimeKind.Local).AddTicks(9205));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 37, 16, 10, DateTimeKind.Local).AddTicks(9208));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 37, 16, 10, DateTimeKind.Local).AddTicks(9209));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 37, 16, 10, DateTimeKind.Local).AddTicks(9211));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 37, 16, 10, DateTimeKind.Local).AddTicks(9213));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 37, 16, 10, DateTimeKind.Local).AddTicks(9214));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 37, 16, 10, DateTimeKind.Local).AddTicks(9216));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 37, 16, 10, DateTimeKind.Local).AddTicks(9218));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 37, 16, 10, DateTimeKind.Local).AddTicks(9219));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 37, 16, 10, DateTimeKind.Local).AddTicks(9221));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 37, 16, 10, DateTimeKind.Local).AddTicks(9223));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 37, 16, 10, DateTimeKind.Local).AddTicks(9225));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 37, 16, 10, DateTimeKind.Local).AddTicks(9226));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 37, 16, 10, DateTimeKind.Local).AddTicks(9228));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 37, 16, 10, DateTimeKind.Local).AddTicks(9230));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 37, 16, 10, DateTimeKind.Local).AddTicks(9232));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 37, 16, 10, DateTimeKind.Local).AddTicks(9234));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 37, 16, 10, DateTimeKind.Local).AddTicks(9235));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 37, 16, 10, DateTimeKind.Local).AddTicks(9237));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 37, 16, 10, DateTimeKind.Local).AddTicks(9239));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 37, 16, 10, DateTimeKind.Local).AddTicks(9258));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 37, 16, 10, DateTimeKind.Local).AddTicks(9260));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 37, 16, 10, DateTimeKind.Local).AddTicks(9262));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 37, 16, 10, DateTimeKind.Local).AddTicks(9263));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 37, 16, 10, DateTimeKind.Local).AddTicks(9265));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 37, 16, 10, DateTimeKind.Local).AddTicks(9275));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 37, 16, 10, DateTimeKind.Local).AddTicks(9277));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 37, 16, 10, DateTimeKind.Local).AddTicks(9279));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 37, 16, 10, DateTimeKind.Local).AddTicks(9281));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 37, 16, 10, DateTimeKind.Local).AddTicks(9282));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 37, 16, 10, DateTimeKind.Local).AddTicks(9291));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 37, 16, 10, DateTimeKind.Local).AddTicks(9293));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 37, 16, 10, DateTimeKind.Local).AddTicks(9296));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 37, 16, 10, DateTimeKind.Local).AddTicks(9298));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 37, 16, 10, DateTimeKind.Local).AddTicks(9299));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 37, 16, 10, DateTimeKind.Local).AddTicks(9309));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 37, 16, 10, DateTimeKind.Local).AddTicks(9311));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 37, 16, 10, DateTimeKind.Local).AddTicks(9313));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 37, 16, 10, DateTimeKind.Local).AddTicks(9315));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 37, 16, 10, DateTimeKind.Local).AddTicks(9317));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 37, 16, 10, DateTimeKind.Local).AddTicks(9325));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 37, 16, 10, DateTimeKind.Local).AddTicks(9327));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 37, 16, 10, DateTimeKind.Local).AddTicks(9329));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 37, 16, 10, DateTimeKind.Local).AddTicks(9331));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 37, 16, 10, DateTimeKind.Local).AddTicks(9332));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 37, 16, 10, DateTimeKind.Local).AddTicks(9341));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 37, 16, 10, DateTimeKind.Local).AddTicks(9343));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 37, 16, 10, DateTimeKind.Local).AddTicks(9345));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 37, 16, 10, DateTimeKind.Local).AddTicks(9347));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 37, 16, 10, DateTimeKind.Local).AddTicks(9348));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 37, 16, 10, DateTimeKind.Local).AddTicks(9397));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 37, 16, 10, DateTimeKind.Local).AddTicks(9424));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 37, 16, 10, DateTimeKind.Local).AddTicks(9426));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 37, 16, 10, DateTimeKind.Local).AddTicks(9427));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 37, 16, 10, DateTimeKind.Local).AddTicks(9429));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 37, 16, 10, DateTimeKind.Local).AddTicks(9431));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 37, 16, 10, DateTimeKind.Local).AddTicks(9432));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 37, 16, 10, DateTimeKind.Local).AddTicks(9434));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 37, 16, 10, DateTimeKind.Local).AddTicks(9437));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 37, 16, 10, DateTimeKind.Local).AddTicks(9438));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 37, 16, 10, DateTimeKind.Local).AddTicks(9440));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 37, 16, 10, DateTimeKind.Local).AddTicks(9442));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 37, 16, 10, DateTimeKind.Local).AddTicks(9443));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 37, 16, 10, DateTimeKind.Local).AddTicks(9445));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 37, 16, 10, DateTimeKind.Local).AddTicks(9446));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 37, 16, 10, DateTimeKind.Local).AddTicks(9448));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 37, 16, 10, DateTimeKind.Local).AddTicks(9450));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 37, 16, 10, DateTimeKind.Local).AddTicks(9452));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 37, 16, 10, DateTimeKind.Local).AddTicks(9453));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 37, 16, 10, DateTimeKind.Local).AddTicks(9455));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 37, 16, 10, DateTimeKind.Local).AddTicks(9456));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 37, 16, 10, DateTimeKind.Local).AddTicks(9459));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 37, 16, 10, DateTimeKind.Local).AddTicks(9461));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 37, 16, 10, DateTimeKind.Local).AddTicks(9462));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 37, 16, 10, DateTimeKind.Local).AddTicks(9464));

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 37, 16, 10, DateTimeKind.Local).AddTicks(9368));

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 37, 16, 10, DateTimeKind.Local).AddTicks(9370));

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 37, 16, 10, DateTimeKind.Local).AddTicks(9372));

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 37, 16, 10, DateTimeKind.Local).AddTicks(9373));

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 37, 16, 10, DateTimeKind.Local).AddTicks(9375));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 37, 16, 10, DateTimeKind.Local).AddTicks(9060));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 37, 16, 10, DateTimeKind.Local).AddTicks(9117));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 37, 16, 10, DateTimeKind.Local).AddTicks(9120));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 37, 16, 10, DateTimeKind.Local).AddTicks(9122));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 37, 16, 10, DateTimeKind.Local).AddTicks(9123));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 37, 16, 10, DateTimeKind.Local).AddTicks(9125));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 37, 16, 10, DateTimeKind.Local).AddTicks(9126));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 37, 16, 10, DateTimeKind.Local).AddTicks(9128));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 37, 16, 10, DateTimeKind.Local).AddTicks(9131));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 37, 16, 10, DateTimeKind.Local).AddTicks(9132));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 37, 16, 10, DateTimeKind.Local).AddTicks(9134));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 37, 16, 10, DateTimeKind.Local).AddTicks(9135));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 37, 16, 10, DateTimeKind.Local).AddTicks(9137));
        }
    }
}
