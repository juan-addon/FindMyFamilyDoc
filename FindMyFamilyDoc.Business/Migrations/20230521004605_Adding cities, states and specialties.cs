using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FindMyFamilyDoc.Business.Migrations
{
    /// <inheritdoc />
    public partial class Addingcitiesstatesandspecialties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bce8319-b570-4734-9479-34add612a294");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7cbe88c2-f558-4f09-9bc8-4e870d3e9d07");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "90bbbb02-097b-42a8-bec4-adedc41f420d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e51037fc-4ac9-4175-b35f-84243cbe711b");

            migrationBuilder.CreateTable(
                name: "Doctor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Specialties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specialties", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "States",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_States", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DoctorSpecialty",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DoctorId = table.Column<int>(type: "int", nullable: false),
                    SpecialtyId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoctorSpecialty", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DoctorSpecialty_Doctor_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DoctorSpecialty_Specialties_SpecialtyId",
                        column: x => x.SpecialtyId,
                        principalTable: "Specialties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StateId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cities_States_StateId",
                        column: x => x.StateId,
                        principalTable: "States",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5f2f854d-6651-4826-8815-5009e2f7f292", null, "AdministractiveAssistant", "ADMINISTRACTIVEASSISTANT" },
                    { "96eb9abc-26e1-4919-9682-7f827c656049", null, "Doctor", "DOCTOR" },
                    { "f51dcd0d-83fb-462f-90a1-29e47b55441e", null, "Patience", "PATIENCE" },
                    { "f985f829-afc5-4ded-af99-be2dc53ec823", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Specialties",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Name", "Status", "UpdateAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 20, 20, 46, 5, 396, DateTimeKind.Local).AddTicks(8593), "System", "Allergists/Immunologists", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2023, 5, 20, 20, 46, 5, 396, DateTimeKind.Local).AddTicks(8598), "System", "Anesthesiologists", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(2023, 5, 20, 20, 46, 5, 396, DateTimeKind.Local).AddTicks(8607), "System", "Cardiologists", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(2023, 5, 20, 20, 46, 5, 396, DateTimeKind.Local).AddTicks(8611), "System", "Family and General Practitioners", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(2023, 5, 20, 20, 46, 5, 396, DateTimeKind.Local).AddTicks(8615), "System", "Neurologists", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "States",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Name", "UpdateAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 20, 20, 46, 5, 396, DateTimeKind.Local).AddTicks(7595), "System", "Alberta", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2023, 5, 20, 20, 46, 5, 396, DateTimeKind.Local).AddTicks(7679), "System", "British Columbia", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(2023, 5, 20, 20, 46, 5, 396, DateTimeKind.Local).AddTicks(7685), "System", "Manitoba", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(2023, 5, 20, 20, 46, 5, 396, DateTimeKind.Local).AddTicks(7689), "System", "New Brunswick", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(2023, 5, 20, 20, 46, 5, 396, DateTimeKind.Local).AddTicks(7693), "System", "Newfoundland and Labrador", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, new DateTime(2023, 5, 20, 20, 46, 5, 396, DateTimeKind.Local).AddTicks(7697), "System", "Nova Scotia", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, new DateTime(2023, 5, 20, 20, 46, 5, 396, DateTimeKind.Local).AddTicks(7701), "System", "Ontario", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, new DateTime(2023, 5, 20, 20, 46, 5, 396, DateTimeKind.Local).AddTicks(7704), "System", "Prince Edward Island", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, new DateTime(2023, 5, 20, 20, 46, 5, 396, DateTimeKind.Local).AddTicks(7708), "System", "Quebec", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, new DateTime(2023, 5, 20, 20, 46, 5, 396, DateTimeKind.Local).AddTicks(7711), "System", "Saskatchewan", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, new DateTime(2023, 5, 20, 20, 46, 5, 396, DateTimeKind.Local).AddTicks(7717), "System", "Northwest Territories", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, new DateTime(2023, 5, 20, 20, 46, 5, 396, DateTimeKind.Local).AddTicks(7720), "System", "Nunavut", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, new DateTime(2023, 5, 20, 20, 46, 5, 396, DateTimeKind.Local).AddTicks(7773), "System", "Yukon", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Name", "StateId", "UpdateAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 20, 20, 46, 5, 396, DateTimeKind.Local).AddTicks(7836), "System", "Toronto", 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2023, 5, 20, 20, 46, 5, 396, DateTimeKind.Local).AddTicks(7841), "System", "Ottawa", 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(2023, 5, 20, 20, 46, 5, 396, DateTimeKind.Local).AddTicks(7845), "System", "Mississauga", 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(2023, 5, 20, 20, 46, 5, 396, DateTimeKind.Local).AddTicks(7849), "System", "Brampton", 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(2023, 5, 20, 20, 46, 5, 396, DateTimeKind.Local).AddTicks(7853), "System", "Hamilton", 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, new DateTime(2023, 5, 20, 20, 46, 5, 396, DateTimeKind.Local).AddTicks(7857), "System", "London", 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, new DateTime(2023, 5, 20, 20, 46, 5, 396, DateTimeKind.Local).AddTicks(7861), "System", "Markham", 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, new DateTime(2023, 5, 20, 20, 46, 5, 396, DateTimeKind.Local).AddTicks(7864), "System", "Vaughan", 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, new DateTime(2023, 5, 20, 20, 46, 5, 396, DateTimeKind.Local).AddTicks(7868), "System", "Kitchener", 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, new DateTime(2023, 5, 20, 20, 46, 5, 396, DateTimeKind.Local).AddTicks(7872), "System", "Windsor", 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, new DateTime(2023, 5, 20, 20, 46, 5, 396, DateTimeKind.Local).AddTicks(7876), "System", "Richmond Hill", 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, new DateTime(2023, 5, 20, 20, 46, 5, 396, DateTimeKind.Local).AddTicks(7879), "System", "Oakville", 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, new DateTime(2023, 5, 20, 20, 46, 5, 396, DateTimeKind.Local).AddTicks(7883), "System", "Burlington", 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, new DateTime(2023, 5, 20, 20, 46, 5, 396, DateTimeKind.Local).AddTicks(7887), "System", "Greater Sudbury", 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, new DateTime(2023, 5, 20, 20, 46, 5, 396, DateTimeKind.Local).AddTicks(7891), "System", "Waterloo", 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, new DateTime(2023, 5, 20, 20, 46, 5, 396, DateTimeKind.Local).AddTicks(7894), "System", "Oshawa", 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, new DateTime(2023, 5, 20, 20, 46, 5, 396, DateTimeKind.Local).AddTicks(7899), "System", "Barrie", 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, new DateTime(2023, 5, 20, 20, 46, 5, 396, DateTimeKind.Local).AddTicks(7903), "System", "Kingston", 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19, new DateTime(2023, 5, 20, 20, 46, 5, 396, DateTimeKind.Local).AddTicks(7906), "System", "Guelph", 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 20, new DateTime(2023, 5, 20, 20, 46, 5, 396, DateTimeKind.Local).AddTicks(7910), "System", "Thunder Bay", 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 21, new DateTime(2023, 5, 20, 20, 46, 5, 396, DateTimeKind.Local).AddTicks(7951), "System", "Calgary", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 22, new DateTime(2023, 5, 20, 20, 46, 5, 396, DateTimeKind.Local).AddTicks(7958), "System", "Edmonton", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 23, new DateTime(2023, 5, 20, 20, 46, 5, 396, DateTimeKind.Local).AddTicks(7963), "System", "Red Deer", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 24, new DateTime(2023, 5, 20, 20, 46, 5, 396, DateTimeKind.Local).AddTicks(7968), "System", "Lethbridge", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 25, new DateTime(2023, 5, 20, 20, 46, 5, 396, DateTimeKind.Local).AddTicks(7975), "System", "St. Albert", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 26, new DateTime(2023, 5, 20, 20, 46, 5, 396, DateTimeKind.Local).AddTicks(8010), "System", "Montreal", 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 27, new DateTime(2023, 5, 20, 20, 46, 5, 396, DateTimeKind.Local).AddTicks(8017), "System", "Quebec City", 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 28, new DateTime(2023, 5, 20, 20, 46, 5, 396, DateTimeKind.Local).AddTicks(8022), "System", "Laval", 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 29, new DateTime(2023, 5, 20, 20, 46, 5, 396, DateTimeKind.Local).AddTicks(8028), "System", "Gatineau", 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 30, new DateTime(2023, 5, 20, 20, 46, 5, 396, DateTimeKind.Local).AddTicks(8034), "System", "Longueuil", 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 31, new DateTime(2023, 5, 20, 20, 46, 5, 396, DateTimeKind.Local).AddTicks(8066), "System", "Moncton", 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 32, new DateTime(2023, 5, 20, 20, 46, 5, 396, DateTimeKind.Local).AddTicks(8072), "System", "Saint John", 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 33, new DateTime(2023, 5, 20, 20, 46, 5, 396, DateTimeKind.Local).AddTicks(8078), "System", "Fredericton", 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 34, new DateTime(2023, 5, 20, 20, 46, 5, 396, DateTimeKind.Local).AddTicks(8084), "System", "Dieppe", 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 35, new DateTime(2023, 5, 20, 20, 46, 5, 396, DateTimeKind.Local).AddTicks(8092), "System", "Riverview", 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 36, new DateTime(2023, 5, 20, 20, 46, 5, 396, DateTimeKind.Local).AddTicks(8129), "System", "Winnipeg", 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 37, new DateTime(2023, 5, 20, 20, 46, 5, 396, DateTimeKind.Local).AddTicks(8135), "System", "Brandon", 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 38, new DateTime(2023, 5, 20, 20, 46, 5, 396, DateTimeKind.Local).AddTicks(8141), "System", "Steinbach", 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 39, new DateTime(2023, 5, 20, 20, 46, 5, 396, DateTimeKind.Local).AddTicks(8147), "System", "Thompson", 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 40, new DateTime(2023, 5, 20, 20, 46, 5, 396, DateTimeKind.Local).AddTicks(8152), "System", "Portage la Prairie", 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 41, new DateTime(2023, 5, 20, 20, 46, 5, 396, DateTimeKind.Local).AddTicks(8189), "System", "St. John's", 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 42, new DateTime(2023, 5, 20, 20, 46, 5, 396, DateTimeKind.Local).AddTicks(8196), "System", "Mount Pearl", 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 43, new DateTime(2023, 5, 20, 20, 46, 5, 396, DateTimeKind.Local).AddTicks(8201), "System", "Conception Bay South", 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 44, new DateTime(2023, 5, 20, 20, 46, 5, 396, DateTimeKind.Local).AddTicks(8208), "System", "Paradise", 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 45, new DateTime(2023, 5, 20, 20, 46, 5, 396, DateTimeKind.Local).AddTicks(8213), "System", "Corner Brook", 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 46, new DateTime(2023, 5, 20, 20, 46, 5, 396, DateTimeKind.Local).AddTicks(8248), "System", "Halifax", 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 47, new DateTime(2023, 5, 20, 20, 46, 5, 396, DateTimeKind.Local).AddTicks(8255), "System", "Sydney", 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 48, new DateTime(2023, 5, 20, 20, 46, 5, 396, DateTimeKind.Local).AddTicks(8260), "System", "Truro", 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 49, new DateTime(2023, 5, 20, 20, 46, 5, 396, DateTimeKind.Local).AddTicks(8416), "System", "New Glasgow", 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 50, new DateTime(2023, 5, 20, 20, 46, 5, 396, DateTimeKind.Local).AddTicks(8422), "System", "Glace Bay", 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cities_StateId",
                table: "Cities",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_DoctorSpecialty_DoctorId",
                table: "DoctorSpecialty",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_DoctorSpecialty_SpecialtyId",
                table: "DoctorSpecialty",
                column: "SpecialtyId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "DoctorSpecialty");

            migrationBuilder.DropTable(
                name: "States");

            migrationBuilder.DropTable(
                name: "Doctor");

            migrationBuilder.DropTable(
                name: "Specialties");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5f2f854d-6651-4826-8815-5009e2f7f292");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "96eb9abc-26e1-4919-9682-7f827c656049");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f51dcd0d-83fb-462f-90a1-29e47b55441e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f985f829-afc5-4ded-af99-be2dc53ec823");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6bce8319-b570-4734-9479-34add612a294", null, "AdministractiveAssistant", "ADMINISTRACTIVEASSISTANT" },
                    { "7cbe88c2-f558-4f09-9bc8-4e870d3e9d07", null, "Doctor", "DOCTOR" },
                    { "90bbbb02-097b-42a8-bec4-adedc41f420d", null, "Admin", "ADMIN" },
                    { "e51037fc-4ac9-4175-b35f-84243cbe711b", null, "Patience", "PATIENCE" }
                });
        }
    }
}
