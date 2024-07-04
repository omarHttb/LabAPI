using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab.Migrations
{
    public partial class v12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "AddDate",
                table: "Employees",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AddedById",
                table: "Employees",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "Employees",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedById",
                table: "Employees",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_AddedById",
                table: "Employees",
                column: "AddedById");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_UpdatedById",
                table: "Employees",
                column: "UpdatedById");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Employees_AddedById",
                table: "Employees",
                column: "AddedById",
                principalTable: "Employees",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Employees_UpdatedById",
                table: "Employees",
                column: "UpdatedById",
                principalTable: "Employees",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Employees_AddedById",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Employees_UpdatedById",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_AddedById",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_UpdatedById",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "AddDate",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "AddedById",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "UpdatedById",
                table: "Employees");
        }
    }
}
