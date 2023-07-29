using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FindMyFamilyDoc.Business.Migrations
{
    /// <inheritdoc />
    public partial class AddingPatientMedicalHistory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PatientMedicalHistories_Patients_PatientId1",
                table: "PatientMedicalHistories");

            migrationBuilder.DropIndex(
                name: "IX_PatientMedicalHistories_PatientId1",
                table: "PatientMedicalHistories");

            migrationBuilder.DropColumn(
                name: "PatientId1",
                table: "PatientMedicalHistories");

            migrationBuilder.AlterColumn<string>(
                name: "PatientId",
                table: "PatientMedicalHistories",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Notes",
                table: "PatientMedicalHistories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "DoctorId",
                table: "PatientMedicalHistories",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_PatientMedicalHistories_DoctorId",
                table: "PatientMedicalHistories",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientMedicalHistories_PatientId",
                table: "PatientMedicalHistories",
                column: "PatientId");

            migrationBuilder.AddForeignKey(
                name: "FK_PatientMedicalHistories_Doctors_DoctorId",
                table: "PatientMedicalHistories",
                column: "DoctorId",
                principalTable: "Doctors",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_PatientMedicalHistories_Patients_PatientId",
                table: "PatientMedicalHistories",
                column: "PatientId",
                principalTable: "Patients",
                principalColumn: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PatientMedicalHistories_Doctors_DoctorId",
                table: "PatientMedicalHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientMedicalHistories_Patients_PatientId",
                table: "PatientMedicalHistories");

            migrationBuilder.DropIndex(
                name: "IX_PatientMedicalHistories_DoctorId",
                table: "PatientMedicalHistories");

            migrationBuilder.DropIndex(
                name: "IX_PatientMedicalHistories_PatientId",
                table: "PatientMedicalHistories");

            migrationBuilder.DropColumn(
                name: "DoctorId",
                table: "PatientMedicalHistories");

            migrationBuilder.AlterColumn<string>(
                name: "PatientId",
                table: "PatientMedicalHistories",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Notes",
                table: "PatientMedicalHistories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PatientId1",
                table: "PatientMedicalHistories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_PatientMedicalHistories_PatientId1",
                table: "PatientMedicalHistories",
                column: "PatientId1");

            migrationBuilder.AddForeignKey(
                name: "FK_PatientMedicalHistories_Patients_PatientId1",
                table: "PatientMedicalHistories",
                column: "PatientId1",
                principalTable: "Patients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
