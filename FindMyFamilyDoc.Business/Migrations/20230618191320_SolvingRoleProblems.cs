using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FindMyFamilyDoc.Business.Migrations
{
    /// <inheritdoc />
    public partial class SolvingRoleProblems : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
