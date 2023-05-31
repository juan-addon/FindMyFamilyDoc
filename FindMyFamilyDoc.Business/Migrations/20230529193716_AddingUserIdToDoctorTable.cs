using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FindMyFamilyDoc.Business.Migrations
{
    /// <inheritdoc />
    public partial class AddingUserIdToDoctorTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "25ced7e7-94a0-4cfc-867a-1d3fe83c9d6f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "52916cf0-49ed-4c49-847e-1907beb5dae1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8dd97105-2fb9-4272-8052-58bf066d48a3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bb49e567-2958-4233-9880-b8237e8069d2");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Doctors",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

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

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_UserId",
                table: "Doctors",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_AspNetUsers_UserId",
                table: "Doctors",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_AspNetUsers_UserId",
                table: "Doctors");

            migrationBuilder.DropIndex(
                name: "IX_Doctors_UserId",
                table: "Doctors");

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

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Doctors");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "25ced7e7-94a0-4cfc-867a-1d3fe83c9d6f", null, "Patience", "PATIENCE" },
                    { "52916cf0-49ed-4c49-847e-1907beb5dae1", null, "AdministractiveAssistant", "ADMINISTRACTIVEASSISTANT" },
                    { "8dd97105-2fb9-4272-8052-58bf066d48a3", null, "Doctor", "DOCTOR" },
                    { "bb49e567-2958-4233-9880-b8237e8069d2", null, "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 31, 7, 420, DateTimeKind.Local).AddTicks(8534));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 31, 7, 420, DateTimeKind.Local).AddTicks(8537));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 31, 7, 420, DateTimeKind.Local).AddTicks(8538));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 31, 7, 420, DateTimeKind.Local).AddTicks(8540));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 31, 7, 420, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 31, 7, 420, DateTimeKind.Local).AddTicks(8544));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 31, 7, 420, DateTimeKind.Local).AddTicks(8546));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 31, 7, 420, DateTimeKind.Local).AddTicks(8547));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 31, 7, 420, DateTimeKind.Local).AddTicks(8549));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 31, 7, 420, DateTimeKind.Local).AddTicks(8551));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 31, 7, 420, DateTimeKind.Local).AddTicks(8553));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 31, 7, 420, DateTimeKind.Local).AddTicks(8554));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 31, 7, 420, DateTimeKind.Local).AddTicks(8556));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 31, 7, 420, DateTimeKind.Local).AddTicks(8558));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 31, 7, 420, DateTimeKind.Local).AddTicks(8560));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 31, 7, 420, DateTimeKind.Local).AddTicks(8561));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 31, 7, 420, DateTimeKind.Local).AddTicks(8564));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 31, 7, 420, DateTimeKind.Local).AddTicks(8566));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 31, 7, 420, DateTimeKind.Local).AddTicks(8622));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 31, 7, 420, DateTimeKind.Local).AddTicks(8625));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 31, 7, 420, DateTimeKind.Local).AddTicks(8644));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 31, 7, 420, DateTimeKind.Local).AddTicks(8646));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 31, 7, 420, DateTimeKind.Local).AddTicks(8648));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 31, 7, 420, DateTimeKind.Local).AddTicks(8649));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 31, 7, 420, DateTimeKind.Local).AddTicks(8651));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 31, 7, 420, DateTimeKind.Local).AddTicks(8661));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 31, 7, 420, DateTimeKind.Local).AddTicks(8663));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 31, 7, 420, DateTimeKind.Local).AddTicks(8665));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 31, 7, 420, DateTimeKind.Local).AddTicks(8667));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 31, 7, 420, DateTimeKind.Local).AddTicks(8669));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 31, 7, 420, DateTimeKind.Local).AddTicks(8679));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 31, 7, 420, DateTimeKind.Local).AddTicks(8681));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 31, 7, 420, DateTimeKind.Local).AddTicks(8682));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 31, 7, 420, DateTimeKind.Local).AddTicks(8685));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 31, 7, 420, DateTimeKind.Local).AddTicks(8687));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 31, 7, 420, DateTimeKind.Local).AddTicks(8698));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 31, 7, 420, DateTimeKind.Local).AddTicks(8700));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 31, 7, 420, DateTimeKind.Local).AddTicks(8702));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 31, 7, 420, DateTimeKind.Local).AddTicks(8704));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 31, 7, 420, DateTimeKind.Local).AddTicks(8706));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 31, 7, 420, DateTimeKind.Local).AddTicks(8714));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 31, 7, 420, DateTimeKind.Local).AddTicks(8716));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 31, 7, 420, DateTimeKind.Local).AddTicks(8718));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 31, 7, 420, DateTimeKind.Local).AddTicks(8720));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 31, 7, 420, DateTimeKind.Local).AddTicks(8722));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 31, 7, 420, DateTimeKind.Local).AddTicks(8732));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 31, 7, 420, DateTimeKind.Local).AddTicks(8734));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 31, 7, 420, DateTimeKind.Local).AddTicks(8735));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 31, 7, 420, DateTimeKind.Local).AddTicks(8737));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 31, 7, 420, DateTimeKind.Local).AddTicks(8739));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 31, 7, 420, DateTimeKind.Local).AddTicks(8790));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 31, 7, 420, DateTimeKind.Local).AddTicks(8792));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 31, 7, 420, DateTimeKind.Local).AddTicks(8794));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 31, 7, 420, DateTimeKind.Local).AddTicks(8796));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 31, 7, 420, DateTimeKind.Local).AddTicks(8797));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 31, 7, 420, DateTimeKind.Local).AddTicks(8799));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 31, 7, 420, DateTimeKind.Local).AddTicks(8801));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 31, 7, 420, DateTimeKind.Local).AddTicks(8803));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 31, 7, 420, DateTimeKind.Local).AddTicks(8804));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 31, 7, 420, DateTimeKind.Local).AddTicks(8806));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 31, 7, 420, DateTimeKind.Local).AddTicks(8808));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 31, 7, 420, DateTimeKind.Local).AddTicks(8810));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 31, 7, 420, DateTimeKind.Local).AddTicks(8812));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 31, 7, 420, DateTimeKind.Local).AddTicks(8813));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 31, 7, 420, DateTimeKind.Local).AddTicks(8815));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 31, 7, 420, DateTimeKind.Local).AddTicks(8816));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 31, 7, 420, DateTimeKind.Local).AddTicks(8818));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 31, 7, 420, DateTimeKind.Local).AddTicks(8820));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 31, 7, 420, DateTimeKind.Local).AddTicks(8822));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 31, 7, 420, DateTimeKind.Local).AddTicks(8823));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 31, 7, 420, DateTimeKind.Local).AddTicks(9615));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 31, 7, 420, DateTimeKind.Local).AddTicks(9620));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 31, 7, 420, DateTimeKind.Local).AddTicks(9622));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 31, 7, 420, DateTimeKind.Local).AddTicks(9624));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 31, 7, 420, DateTimeKind.Local).AddTicks(9626));

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 31, 7, 420, DateTimeKind.Local).AddTicks(8764));

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 31, 7, 420, DateTimeKind.Local).AddTicks(8768));

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 31, 7, 420, DateTimeKind.Local).AddTicks(8769));

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 31, 7, 420, DateTimeKind.Local).AddTicks(8771));

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 31, 7, 420, DateTimeKind.Local).AddTicks(8773));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 31, 7, 420, DateTimeKind.Local).AddTicks(8403));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 31, 7, 420, DateTimeKind.Local).AddTicks(8462));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 31, 7, 420, DateTimeKind.Local).AddTicks(8464));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 31, 7, 420, DateTimeKind.Local).AddTicks(8466));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 31, 7, 420, DateTimeKind.Local).AddTicks(8468));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 31, 7, 420, DateTimeKind.Local).AddTicks(8470));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 31, 7, 420, DateTimeKind.Local).AddTicks(8471));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 31, 7, 420, DateTimeKind.Local).AddTicks(8473));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 31, 7, 420, DateTimeKind.Local).AddTicks(8475));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 31, 7, 420, DateTimeKind.Local).AddTicks(8478));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 31, 7, 420, DateTimeKind.Local).AddTicks(8479));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 31, 7, 420, DateTimeKind.Local).AddTicks(8481));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 29, 15, 31, 7, 420, DateTimeKind.Local).AddTicks(8483));
        }
    }
}