using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab.Migrations
{
    public partial class v13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patients_Nationalites_NationalityID",
                table: "Patients");

            migrationBuilder.RenameColumn(
                name: "NationalityID",
                table: "Patients",
                newName: "NationalityId");

            migrationBuilder.RenameIndex(
                name: "IX_Patients_NationalityID",
                table: "Patients",
                newName: "IX_Patients_NationalityId");

            migrationBuilder.RenameColumn(
                name: "DOB",
                table: "Employees",
                newName: "DateOfBirth");

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_Nationalites_NationalityId",
                table: "Patients",
                column: "NationalityId",
                principalTable: "Nationalites",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patients_Nationalites_NationalityId",
                table: "Patients");

            migrationBuilder.RenameColumn(
                name: "NationalityId",
                table: "Patients",
                newName: "NationalityID");

            migrationBuilder.RenameIndex(
                name: "IX_Patients_NationalityId",
                table: "Patients",
                newName: "IX_Patients_NationalityID");

            migrationBuilder.RenameColumn(
                name: "DateOfBirth",
                table: "Employees",
                newName: "DOB");

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_Nationalites_NationalityID",
                table: "Patients",
                column: "NationalityID",
                principalTable: "Nationalites",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
