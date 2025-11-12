using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InnoClinic.Services.Patients.Migrations
{
    /// <inheritdoc />
    public partial class SeedPatientsToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "AccountId", "DateOfBirth", "FirstName", "IsLinkedToAccount", "LastName", "MiddleName" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(1900, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Van", true, "Holm", "Dark" },
                    { 2, 2, new DateTime(1985, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "John", true, "Smith", "Doe" },
                    { 3, 3, new DateTime(1992, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jane", false, "Doe", "A" },
                    { 4, 4, new DateTime(1978, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alice", true, "Johnson", "B" },
                    { 5, 5, new DateTime(1982, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bob", true, "Williams", "C" },
                    { 6, 6, new DateTime(1990, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Charlie", false, "Brown", "D" },
                    { 7, 7, new DateTime(1995, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "David", true, "Miller", "E" },
                    { 8, 8, new DateTime(1988, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eva", false, "Davis", "F" },
                    { 9, 9, new DateTime(1993, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Frank", true, "Martinez", "G" },
                    { 10, 10, new DateTime(1980, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grace", true, "Garcia", "H" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
