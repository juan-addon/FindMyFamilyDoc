using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FindMyFamilyDoc.Business.Migrations
{
    /// <inheritdoc />
    public partial class Sprint2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "48365f29-fda0-4183-b084-69ffa35dafff");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "827f70ea-446b-4b66-b5bc-2debb30346ef");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9233ec97-7b3b-4b91-a6c4-065930abc6ee");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a2244d3c-9555-4051-a046-1301d90a38ba");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ce811bc8-eaa4-4434-abed-35a3b2b80d8e");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "Doctors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Gender",
                table: "Doctors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsPasswordChangeRequired",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "DoctorAvailability",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DayOfWeek = table.Column<int>(type: "int", nullable: false),
                    FromTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    ToTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    AppointmentLength = table.Column<TimeSpan>(type: "time", nullable: false),
                    DoctorId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoctorAvailability", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DoctorAvailability_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DoctorStaffs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DoctorId = table.Column<int>(type: "int", nullable: false),
                    DateOfHire = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmergencyContact = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MiddleName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ContactInformation = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ProfilePicture = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoctorStaffs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DoctorStaffs_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DoctorStaffs_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DoctorStaffs_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Patient",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmergencyContact = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CurrentMedications = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaritalStatus = table.Column<int>(type: "int", nullable: false),
                    Occupation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MiddleName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ContactInformation = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ProfilePicture = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patient", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Patient_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Patient_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3c1080c9-d7e8-471c-af11-1f9c568c7a99", null, "DoctorUnderReview", "Doctor Under Review" },
                    { "5d670dd9-2f9d-41a7-9d52-4319ad167a42", null, "Admin", "Administrator" },
                    { "620164a8-ee1e-4839-9e85-e51252fee062", null, "Doctor", "Medical Practitioner" },
                    { "66b870e2-7e02-496d-b4d6-43289f927a94", null, "AdministrativeAssistant", "Administrative Assistant" },
                    { "7d698ab0-c5b6-4d29-87a8-96af7a184937", null, "Patient", "Patient" }
                });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 1, 57, 609, DateTimeKind.Local).AddTicks(4568));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 1, 57, 609, DateTimeKind.Local).AddTicks(4571));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 1, 57, 609, DateTimeKind.Local).AddTicks(4574));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 1, 57, 609, DateTimeKind.Local).AddTicks(4577));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 1, 57, 609, DateTimeKind.Local).AddTicks(4581));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 1, 57, 609, DateTimeKind.Local).AddTicks(4583));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 1, 57, 609, DateTimeKind.Local).AddTicks(4586));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 1, 57, 609, DateTimeKind.Local).AddTicks(4589));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 1, 57, 609, DateTimeKind.Local).AddTicks(4592));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 1, 57, 609, DateTimeKind.Local).AddTicks(4594));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 1, 57, 609, DateTimeKind.Local).AddTicks(4597));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 1, 57, 609, DateTimeKind.Local).AddTicks(4600));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 1, 57, 609, DateTimeKind.Local).AddTicks(4603));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 1, 57, 609, DateTimeKind.Local).AddTicks(4605));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 1, 57, 609, DateTimeKind.Local).AddTicks(4608));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 1, 57, 609, DateTimeKind.Local).AddTicks(4611));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 1, 57, 609, DateTimeKind.Local).AddTicks(4613));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 1, 57, 609, DateTimeKind.Local).AddTicks(4616));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 1, 57, 609, DateTimeKind.Local).AddTicks(4619));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 1, 57, 609, DateTimeKind.Local).AddTicks(4621));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 1, 57, 609, DateTimeKind.Local).AddTicks(4642));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 1, 57, 609, DateTimeKind.Local).AddTicks(4645));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 1, 57, 609, DateTimeKind.Local).AddTicks(4648));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 1, 57, 609, DateTimeKind.Local).AddTicks(4651));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 1, 57, 609, DateTimeKind.Local).AddTicks(4654));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 1, 57, 609, DateTimeKind.Local).AddTicks(4665));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 1, 57, 609, DateTimeKind.Local).AddTicks(4668));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 1, 57, 609, DateTimeKind.Local).AddTicks(4671));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 1, 57, 609, DateTimeKind.Local).AddTicks(4673));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 1, 57, 609, DateTimeKind.Local).AddTicks(4676));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 1, 57, 609, DateTimeKind.Local).AddTicks(4685));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 1, 57, 609, DateTimeKind.Local).AddTicks(4688));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 1, 57, 609, DateTimeKind.Local).AddTicks(4691));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 1, 57, 609, DateTimeKind.Local).AddTicks(4693));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 1, 57, 609, DateTimeKind.Local).AddTicks(4696));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 1, 57, 609, DateTimeKind.Local).AddTicks(4706));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 1, 57, 609, DateTimeKind.Local).AddTicks(4709));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 1, 57, 609, DateTimeKind.Local).AddTicks(4712));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 1, 57, 609, DateTimeKind.Local).AddTicks(4714));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 1, 57, 609, DateTimeKind.Local).AddTicks(4742));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 1, 57, 609, DateTimeKind.Local).AddTicks(4754));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 1, 57, 609, DateTimeKind.Local).AddTicks(4757));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 1, 57, 609, DateTimeKind.Local).AddTicks(4759));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 1, 57, 609, DateTimeKind.Local).AddTicks(4762));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 1, 57, 609, DateTimeKind.Local).AddTicks(4765));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 1, 57, 609, DateTimeKind.Local).AddTicks(4773));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 1, 57, 609, DateTimeKind.Local).AddTicks(4776));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 1, 57, 609, DateTimeKind.Local).AddTicks(4779));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 1, 57, 609, DateTimeKind.Local).AddTicks(4782));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 1, 57, 609, DateTimeKind.Local).AddTicks(4784));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 1, 57, 609, DateTimeKind.Local).AddTicks(4838));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 1, 57, 609, DateTimeKind.Local).AddTicks(4841));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 1, 57, 609, DateTimeKind.Local).AddTicks(4843));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 1, 57, 609, DateTimeKind.Local).AddTicks(4847));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 1, 57, 609, DateTimeKind.Local).AddTicks(4849));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 1, 57, 609, DateTimeKind.Local).AddTicks(4852));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 1, 57, 609, DateTimeKind.Local).AddTicks(4855));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 1, 57, 609, DateTimeKind.Local).AddTicks(4857));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 1, 57, 609, DateTimeKind.Local).AddTicks(4860));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 1, 57, 609, DateTimeKind.Local).AddTicks(4862));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 1, 57, 609, DateTimeKind.Local).AddTicks(4865));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 1, 57, 609, DateTimeKind.Local).AddTicks(4867));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 1, 57, 609, DateTimeKind.Local).AddTicks(4870));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 1, 57, 609, DateTimeKind.Local).AddTicks(4875));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 1, 57, 609, DateTimeKind.Local).AddTicks(4878));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 1, 57, 609, DateTimeKind.Local).AddTicks(4881));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 1, 57, 609, DateTimeKind.Local).AddTicks(4883));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 1, 57, 609, DateTimeKind.Local).AddTicks(4886));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 1, 57, 609, DateTimeKind.Local).AddTicks(4888));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 1, 57, 609, DateTimeKind.Local).AddTicks(4891));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 1, 57, 609, DateTimeKind.Local).AddTicks(4894));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 1, 57, 609, DateTimeKind.Local).AddTicks(4896));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 1, 57, 609, DateTimeKind.Local).AddTicks(4899));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 1, 57, 609, DateTimeKind.Local).AddTicks(4902));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 1, 57, 609, DateTimeKind.Local).AddTicks(4904));

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 1, 57, 609, DateTimeKind.Local).AddTicks(4806));

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 1, 57, 609, DateTimeKind.Local).AddTicks(4809));

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 1, 57, 609, DateTimeKind.Local).AddTicks(4811));

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 1, 57, 609, DateTimeKind.Local).AddTicks(4814));

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 1, 57, 609, DateTimeKind.Local).AddTicks(4817));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 1, 57, 609, DateTimeKind.Local).AddTicks(4480));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 1, 57, 609, DateTimeKind.Local).AddTicks(4485));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 1, 57, 609, DateTimeKind.Local).AddTicks(4488));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 1, 57, 609, DateTimeKind.Local).AddTicks(4490));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 1, 57, 609, DateTimeKind.Local).AddTicks(4515));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 1, 57, 609, DateTimeKind.Local).AddTicks(4518));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 1, 57, 609, DateTimeKind.Local).AddTicks(4520));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 1, 57, 609, DateTimeKind.Local).AddTicks(4523));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 1, 57, 609, DateTimeKind.Local).AddTicks(4526));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 1, 57, 609, DateTimeKind.Local).AddTicks(4528));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 1, 57, 609, DateTimeKind.Local).AddTicks(4531));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 1, 57, 609, DateTimeKind.Local).AddTicks(4534));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 18, 15, 1, 57, 609, DateTimeKind.Local).AddTicks(4537));

            migrationBuilder.CreateIndex(
                name: "IX_DoctorAvailability_DoctorId",
                table: "DoctorAvailability",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_DoctorStaffs_CityId",
                table: "DoctorStaffs",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_DoctorStaffs_DoctorId",
                table: "DoctorStaffs",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_DoctorStaffs_UserId",
                table: "DoctorStaffs",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Patient_CityId",
                table: "Patient",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_UserId",
                table: "Patient",
                column: "UserId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DoctorAvailability");

            migrationBuilder.DropTable(
                name: "DoctorStaffs");

            migrationBuilder.DropTable(
                name: "Patient");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3c1080c9-d7e8-471c-af11-1f9c568c7a99");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5d670dd9-2f9d-41a7-9d52-4319ad167a42");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "620164a8-ee1e-4839-9e85-e51252fee062");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "66b870e2-7e02-496d-b4d6-43289f927a94");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7d698ab0-c5b6-4d29-87a8-96af7a184937");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "IsPasswordChangeRequired",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "48365f29-fda0-4183-b084-69ffa35dafff", null, "Doctor", "DOCTOR" },
                    { "827f70ea-446b-4b66-b5bc-2debb30346ef", null, "AdministractiveAssistant", "ADMINISTRACTIVEASSISTANT" },
                    { "9233ec97-7b3b-4b91-a6c4-065930abc6ee", null, "Patience", "PATIENCE" },
                    { "a2244d3c-9555-4051-a046-1301d90a38ba", null, "Admin", "ADMIN" },
                    { "ce811bc8-eaa4-4434-abed-35a3b2b80d8e", null, "DoctorUnderReview", "DOCTORUNDERREVIEW" }
                });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 56, 13, 158, DateTimeKind.Local).AddTicks(138));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 56, 13, 158, DateTimeKind.Local).AddTicks(141));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 56, 13, 158, DateTimeKind.Local).AddTicks(144));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 56, 13, 158, DateTimeKind.Local).AddTicks(147));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 56, 13, 158, DateTimeKind.Local).AddTicks(150));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 56, 13, 158, DateTimeKind.Local).AddTicks(152));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 56, 13, 158, DateTimeKind.Local).AddTicks(155));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 56, 13, 158, DateTimeKind.Local).AddTicks(158));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 56, 13, 158, DateTimeKind.Local).AddTicks(160));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 56, 13, 158, DateTimeKind.Local).AddTicks(163));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 56, 13, 158, DateTimeKind.Local).AddTicks(165));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 56, 13, 158, DateTimeKind.Local).AddTicks(168));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 56, 13, 158, DateTimeKind.Local).AddTicks(171));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 56, 13, 158, DateTimeKind.Local).AddTicks(173));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 56, 13, 158, DateTimeKind.Local).AddTicks(176));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 56, 13, 158, DateTimeKind.Local).AddTicks(178));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 56, 13, 158, DateTimeKind.Local).AddTicks(181));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 56, 13, 158, DateTimeKind.Local).AddTicks(184));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 56, 13, 158, DateTimeKind.Local).AddTicks(186));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 56, 13, 158, DateTimeKind.Local).AddTicks(190));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 56, 13, 158, DateTimeKind.Local).AddTicks(207));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 56, 13, 158, DateTimeKind.Local).AddTicks(210));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 56, 13, 158, DateTimeKind.Local).AddTicks(212));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 56, 13, 158, DateTimeKind.Local).AddTicks(215));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 56, 13, 158, DateTimeKind.Local).AddTicks(218));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 56, 13, 158, DateTimeKind.Local).AddTicks(228));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 56, 13, 158, DateTimeKind.Local).AddTicks(231));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 56, 13, 158, DateTimeKind.Local).AddTicks(523));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 56, 13, 158, DateTimeKind.Local).AddTicks(526));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 56, 13, 158, DateTimeKind.Local).AddTicks(529));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 56, 13, 158, DateTimeKind.Local).AddTicks(572));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 56, 13, 158, DateTimeKind.Local).AddTicks(575));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 56, 13, 158, DateTimeKind.Local).AddTicks(697));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 56, 13, 158, DateTimeKind.Local).AddTicks(699));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 56, 13, 158, DateTimeKind.Local).AddTicks(702));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 56, 13, 158, DateTimeKind.Local).AddTicks(713));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 56, 13, 158, DateTimeKind.Local).AddTicks(716));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 56, 13, 158, DateTimeKind.Local).AddTicks(718));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 56, 13, 158, DateTimeKind.Local).AddTicks(722));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 56, 13, 158, DateTimeKind.Local).AddTicks(725));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 56, 13, 158, DateTimeKind.Local).AddTicks(734));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 56, 13, 158, DateTimeKind.Local).AddTicks(737));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 56, 13, 158, DateTimeKind.Local).AddTicks(740));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 56, 13, 158, DateTimeKind.Local).AddTicks(743));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 56, 13, 158, DateTimeKind.Local).AddTicks(746));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 56, 13, 158, DateTimeKind.Local).AddTicks(755));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 56, 13, 158, DateTimeKind.Local).AddTicks(757));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 56, 13, 158, DateTimeKind.Local).AddTicks(760));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 56, 13, 158, DateTimeKind.Local).AddTicks(763));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 56, 13, 158, DateTimeKind.Local).AddTicks(765));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 56, 13, 158, DateTimeKind.Local).AddTicks(813));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 56, 13, 158, DateTimeKind.Local).AddTicks(816));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 56, 13, 158, DateTimeKind.Local).AddTicks(819));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 56, 13, 158, DateTimeKind.Local).AddTicks(821));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 56, 13, 158, DateTimeKind.Local).AddTicks(824));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 56, 13, 158, DateTimeKind.Local).AddTicks(826));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 56, 13, 158, DateTimeKind.Local).AddTicks(829));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 56, 13, 158, DateTimeKind.Local).AddTicks(833));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 56, 13, 158, DateTimeKind.Local).AddTicks(835));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 56, 13, 158, DateTimeKind.Local).AddTicks(838));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 56, 13, 158, DateTimeKind.Local).AddTicks(840));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 56, 13, 158, DateTimeKind.Local).AddTicks(843));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 56, 13, 158, DateTimeKind.Local).AddTicks(845));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 56, 13, 158, DateTimeKind.Local).AddTicks(851));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 56, 13, 158, DateTimeKind.Local).AddTicks(854));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 56, 13, 158, DateTimeKind.Local).AddTicks(856));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 56, 13, 158, DateTimeKind.Local).AddTicks(859));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 56, 13, 158, DateTimeKind.Local).AddTicks(861));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 56, 13, 158, DateTimeKind.Local).AddTicks(864));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 56, 13, 158, DateTimeKind.Local).AddTicks(866));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 56, 13, 158, DateTimeKind.Local).AddTicks(869));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 56, 13, 158, DateTimeKind.Local).AddTicks(871));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 56, 13, 158, DateTimeKind.Local).AddTicks(874));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 56, 13, 158, DateTimeKind.Local).AddTicks(876));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 56, 13, 158, DateTimeKind.Local).AddTicks(879));

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 56, 13, 158, DateTimeKind.Local).AddTicks(785));

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 56, 13, 158, DateTimeKind.Local).AddTicks(788));

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 56, 13, 158, DateTimeKind.Local).AddTicks(790));

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 56, 13, 158, DateTimeKind.Local).AddTicks(793));

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 56, 13, 158, DateTimeKind.Local).AddTicks(796));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 56, 13, 158, DateTimeKind.Local).AddTicks(75));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 56, 13, 158, DateTimeKind.Local).AddTicks(80));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 56, 13, 158, DateTimeKind.Local).AddTicks(83));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 56, 13, 158, DateTimeKind.Local).AddTicks(85));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 56, 13, 158, DateTimeKind.Local).AddTicks(88));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 56, 13, 158, DateTimeKind.Local).AddTicks(91));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 56, 13, 158, DateTimeKind.Local).AddTicks(93));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 56, 13, 158, DateTimeKind.Local).AddTicks(96));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 56, 13, 158, DateTimeKind.Local).AddTicks(99));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 56, 13, 158, DateTimeKind.Local).AddTicks(101));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 56, 13, 158, DateTimeKind.Local).AddTicks(104));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 56, 13, 158, DateTimeKind.Local).AddTicks(107));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 56, 13, 158, DateTimeKind.Local).AddTicks(110));
        }
    }
}
