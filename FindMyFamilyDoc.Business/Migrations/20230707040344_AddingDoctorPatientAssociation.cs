using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FindMyFamilyDoc.Business.Migrations
{
    /// <inheritdoc />
    public partial class AddingDoctorPatientAssociation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Patients_UserId",
                table: "Patients");

            migrationBuilder.AddUniqueConstraint(
                name: "AlternateKey_PatientUserId",
                table: "Patients",
                column: "UserId");

            migrationBuilder.AddUniqueConstraint(
                name: "AlternateKey_DoctorUserId",
                table: "Doctors",
                column: "UserId");

            migrationBuilder.CreateTable(
                name: "DoctorPatientAssociations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DoctorUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PatientUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Timestamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    ResultMessage = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoctorPatientAssociations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DoctorPatientAssociations_Doctors_DoctorUserId",
                        column: x => x.DoctorUserId,
                        principalTable: "Doctors",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_DoctorPatientAssociations_Patients_PatientUserId",
                        column: x => x.PatientUserId,
                        principalTable: "Patients",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_DoctorPatientAssociations_DoctorUserId",
                table: "DoctorPatientAssociations",
                column: "DoctorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_DoctorPatientAssociations_PatientUserId",
                table: "DoctorPatientAssociations",
                column: "PatientUserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DoctorPatientAssociations");

            migrationBuilder.DropUniqueConstraint(
                name: "AlternateKey_PatientUserId",
                table: "Patients");

            migrationBuilder.DropUniqueConstraint(
                name: "AlternateKey_DoctorUserId",
                table: "Doctors");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_UserId",
                table: "Patients",
                column: "UserId",
                unique: true);
        }
    }
}