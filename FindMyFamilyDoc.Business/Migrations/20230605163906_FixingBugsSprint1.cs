using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FindMyFamilyDoc.Business.Migrations
{
    /// <inheritdoc />
    public partial class FixingBugsSprint1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Doctors",
                newName: "MiddleName");

            migrationBuilder.AlterColumn<string>(
                name: "WaitingTime",
                table: "Doctors",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Doctors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Doctors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1c9af916-b267-4105-8b38-c2b00db0162f", null, "AdministractiveAssistant", "ADMINISTRACTIVEASSISTANT" },
                    { "92b80963-25ad-4f15-8542-0decfb1462c9", null, "Patience", "PATIENCE" },
                    { "9b965f50-8fd3-45c1-b01e-a4cc462a895a", null, "Admin", "ADMIN" },
                    { "e1d6fdfe-b944-45dc-9799-2ec79e131211", null, "Doctor", "DOCTOR" },
                    { "f2e2f507-5504-4feb-955a-0198e9b2519e", null, "DoctorUnderReview", "DOCTORUNDERREVIEW" }
                });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 39, 6, 82, DateTimeKind.Local).AddTicks(3662));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 39, 6, 82, DateTimeKind.Local).AddTicks(3664));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 39, 6, 82, DateTimeKind.Local).AddTicks(3666));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 39, 6, 82, DateTimeKind.Local).AddTicks(3668));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 39, 6, 82, DateTimeKind.Local).AddTicks(3669));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 39, 6, 82, DateTimeKind.Local).AddTicks(3671));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 39, 6, 82, DateTimeKind.Local).AddTicks(3673));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 39, 6, 82, DateTimeKind.Local).AddTicks(3674));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 39, 6, 82, DateTimeKind.Local).AddTicks(3676));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 39, 6, 82, DateTimeKind.Local).AddTicks(3678));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 39, 6, 82, DateTimeKind.Local).AddTicks(3679));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 39, 6, 82, DateTimeKind.Local).AddTicks(3704));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 39, 6, 82, DateTimeKind.Local).AddTicks(3706));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 39, 6, 82, DateTimeKind.Local).AddTicks(3708));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 39, 6, 82, DateTimeKind.Local).AddTicks(3710));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 39, 6, 82, DateTimeKind.Local).AddTicks(3712));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 39, 6, 82, DateTimeKind.Local).AddTicks(3713));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 39, 6, 82, DateTimeKind.Local).AddTicks(3715));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 39, 6, 82, DateTimeKind.Local).AddTicks(3716));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 39, 6, 82, DateTimeKind.Local).AddTicks(3718));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 39, 6, 82, DateTimeKind.Local).AddTicks(3734));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 39, 6, 82, DateTimeKind.Local).AddTicks(3737));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 39, 6, 82, DateTimeKind.Local).AddTicks(3738));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 39, 6, 82, DateTimeKind.Local).AddTicks(3740));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 39, 6, 82, DateTimeKind.Local).AddTicks(3742));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 39, 6, 82, DateTimeKind.Local).AddTicks(3749));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 39, 6, 82, DateTimeKind.Local).AddTicks(3751));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 39, 6, 82, DateTimeKind.Local).AddTicks(3753));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 39, 6, 82, DateTimeKind.Local).AddTicks(3755));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 39, 6, 82, DateTimeKind.Local).AddTicks(3756));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 39, 6, 82, DateTimeKind.Local).AddTicks(3764));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 39, 6, 82, DateTimeKind.Local).AddTicks(3766));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 39, 6, 82, DateTimeKind.Local).AddTicks(3768));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 39, 6, 82, DateTimeKind.Local).AddTicks(3770));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 39, 6, 82, DateTimeKind.Local).AddTicks(3771));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 39, 6, 82, DateTimeKind.Local).AddTicks(3780));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 39, 6, 82, DateTimeKind.Local).AddTicks(3782));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 39, 6, 82, DateTimeKind.Local).AddTicks(3784));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 39, 6, 82, DateTimeKind.Local).AddTicks(3785));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 39, 6, 82, DateTimeKind.Local).AddTicks(3787));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 39, 6, 82, DateTimeKind.Local).AddTicks(3797));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 39, 6, 82, DateTimeKind.Local).AddTicks(3799));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 39, 6, 82, DateTimeKind.Local).AddTicks(3800));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 39, 6, 82, DateTimeKind.Local).AddTicks(3802));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 39, 6, 82, DateTimeKind.Local).AddTicks(3803));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 39, 6, 82, DateTimeKind.Local).AddTicks(3811));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 39, 6, 82, DateTimeKind.Local).AddTicks(3813));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 39, 6, 82, DateTimeKind.Local).AddTicks(3814));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 39, 6, 82, DateTimeKind.Local).AddTicks(3816));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 39, 6, 82, DateTimeKind.Local).AddTicks(3818));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 39, 6, 82, DateTimeKind.Local).AddTicks(3876));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 39, 6, 82, DateTimeKind.Local).AddTicks(3879));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 39, 6, 82, DateTimeKind.Local).AddTicks(3880));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 39, 6, 82, DateTimeKind.Local).AddTicks(3882));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 39, 6, 82, DateTimeKind.Local).AddTicks(3883));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 39, 6, 82, DateTimeKind.Local).AddTicks(3885));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 39, 6, 82, DateTimeKind.Local).AddTicks(3886));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 39, 6, 82, DateTimeKind.Local).AddTicks(3888));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 39, 6, 82, DateTimeKind.Local).AddTicks(3889));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 39, 6, 82, DateTimeKind.Local).AddTicks(3891));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 39, 6, 82, DateTimeKind.Local).AddTicks(3892));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 39, 6, 82, DateTimeKind.Local).AddTicks(3894));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 39, 6, 82, DateTimeKind.Local).AddTicks(3895));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 39, 6, 82, DateTimeKind.Local).AddTicks(3900));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 39, 6, 82, DateTimeKind.Local).AddTicks(3901));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 39, 6, 82, DateTimeKind.Local).AddTicks(3902));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 39, 6, 82, DateTimeKind.Local).AddTicks(3904));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 39, 6, 82, DateTimeKind.Local).AddTicks(3905));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 39, 6, 82, DateTimeKind.Local).AddTicks(3907));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 39, 6, 82, DateTimeKind.Local).AddTicks(3908));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 39, 6, 82, DateTimeKind.Local).AddTicks(3910));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 39, 6, 82, DateTimeKind.Local).AddTicks(3911));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 39, 6, 82, DateTimeKind.Local).AddTicks(3913));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 39, 6, 82, DateTimeKind.Local).AddTicks(3914));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 39, 6, 82, DateTimeKind.Local).AddTicks(3916));

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 39, 6, 82, DateTimeKind.Local).AddTicks(3833));

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 39, 6, 82, DateTimeKind.Local).AddTicks(3835));

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 39, 6, 82, DateTimeKind.Local).AddTicks(3837));

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 39, 6, 82, DateTimeKind.Local).AddTicks(3839));

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 39, 6, 82, DateTimeKind.Local).AddTicks(3840));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 39, 6, 82, DateTimeKind.Local).AddTicks(3567));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 39, 6, 82, DateTimeKind.Local).AddTicks(3617));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 39, 6, 82, DateTimeKind.Local).AddTicks(3619));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 39, 6, 82, DateTimeKind.Local).AddTicks(3620));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 39, 6, 82, DateTimeKind.Local).AddTicks(3622));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 39, 6, 82, DateTimeKind.Local).AddTicks(3623));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 39, 6, 82, DateTimeKind.Local).AddTicks(3625));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 39, 6, 82, DateTimeKind.Local).AddTicks(3626));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 39, 6, 82, DateTimeKind.Local).AddTicks(3628));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 39, 6, 82, DateTimeKind.Local).AddTicks(3630));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 39, 6, 82, DateTimeKind.Local).AddTicks(3632));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 39, 6, 82, DateTimeKind.Local).AddTicks(3633));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 5, 12, 39, 6, 82, DateTimeKind.Local).AddTicks(3635));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1c9af916-b267-4105-8b38-c2b00db0162f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "92b80963-25ad-4f15-8542-0decfb1462c9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b965f50-8fd3-45c1-b01e-a4cc462a895a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e1d6fdfe-b944-45dc-9799-2ec79e131211");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f2e2f507-5504-4feb-955a-0198e9b2519e");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Doctors");

            migrationBuilder.RenameColumn(
                name: "MiddleName",
                table: "Doctors",
                newName: "Name");

            migrationBuilder.AlterColumn<int>(
                name: "WaitingTime",
                table: "Doctors",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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
    }
}
