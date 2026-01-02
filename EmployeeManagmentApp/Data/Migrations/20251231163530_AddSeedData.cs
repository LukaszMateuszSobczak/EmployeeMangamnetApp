using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EmployeeManagmentApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ApartamentNumber", "City", "HouseNumber", "PostalCode", "StreetName" },
                values: new object[] { "3", "Warszawa", "12", "00-001", "Polna" });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ApartamentNumber", "City", "HouseNumber", "PostalCode", "StreetName" },
                values: new object[] { "2", "Łódź", "8", "91-005", "Kwiatowa" });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ApartamentNumber", "City", "HouseNumber", "PostalCode", "StreetName" },
                values: new object[] { "10", "Gdańsk", "5", "80-111", "Morska" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Email", "FirstName", "HireDate", "LastName", "Pesel", "Phone", "Position", "Salary", "UserId" },
                values: new object[] { new DateTime(2025, 12, 31, 16, 35, 30, 419, DateTimeKind.Utc).AddTicks(4267), "jan.kowalski@example.com", "Jan", new DateTime(2025, 12, 31, 16, 35, 30, 419, DateTimeKind.Utc).AddTicks(4267), "Kowalski", "90010112345", "500600700", "Programista", 8000m, "13313a98-eeaa-4500-9f61-7ecb7953a12e" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Email", "FirstName", "HireDate", "LastName", "Pesel", "Phone", "Position", "Salary", "UserId" },
                values: new object[] { new DateTime(2025, 12, 31, 16, 35, 30, 419, DateTimeKind.Utc).AddTicks(4269), "marek.zielinski@example.com", "Marek", new DateTime(2025, 12, 31, 16, 35, 30, 419, DateTimeKind.Utc).AddTicks(4269), "Zieliński", "88050565432", "505404303", "Tester", 6500m, "13313a98-eeaa-4500-9f61-7ecb7953a12e" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Email", "FirstName", "HireDate", "LastName", "Pesel", "Phone", "Position", "Salary", "UserId" },
                values: new object[] { new DateTime(2025, 12, 31, 16, 35, 30, 419, DateTimeKind.Utc).AddTicks(4271), "karolina.lis@example.com", "Karolina", new DateTime(2025, 12, 31, 16, 35, 30, 419, DateTimeKind.Utc).AddTicks(4271), "Lis", "95021287654", "777888999", "Project Manager", 11000m, "13313a98-eeaa-4500-9f61-7ecb7953a12e" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "CreatedAt", "Email", "FirstName", "HireDate", "LastName", "Pesel", "Phone", "Position", "Salary", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 7, new DateTime(2025, 12, 31, 16, 35, 30, 419, DateTimeKind.Utc).AddTicks(4273), "anna.nowak@example.com", "Anna", new DateTime(2025, 12, 31, 16, 35, 30, 419, DateTimeKind.Utc).AddTicks(4272), "Nowak", "92030554321", "501501501", "HR Manager", 9500m, null, "31c35515-0af5-4351-8061-cf16f84a9162" },
                    { 8, new DateTime(2025, 12, 31, 16, 35, 30, 419, DateTimeKind.Utc).AddTicks(4274), "tomasz.mazur@example.com", "Tomasz", new DateTime(2025, 12, 31, 16, 35, 30, 419, DateTimeKind.Utc).AddTicks(4274), "Mazur", "87092311223", "600700800", "DevOps Engineer", 12000m, null, "31c35515-0af5-4351-8061-cf16f84a9162" },
                    { 9, new DateTime(2025, 12, 31, 16, 35, 30, 419, DateTimeKind.Utc).AddTicks(4327), "natalia.bak@example.com", "Natalia", new DateTime(2025, 12, 31, 16, 35, 30, 419, DateTimeKind.Utc).AddTicks(4326), "Bąk", "98010199887", "733444222", "UX Designer", 9000m, null, "31c35515-0af5-4351-8061-cf16f84a9162" }
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "ApartamentNumber", "City", "EmployeeId", "HouseNumber", "PostalCode", "StreetName" },
                values: new object[,]
                {
                    { 7, "7", "Kraków", 7, "5A", "31-002", "Długa" },
                    { 8, "1", "Poznań", 8, "15", "60-101", "Lechicka" },
                    { 9, "6", "Wrocław", 9, "22", "50-500", "Słoneczna" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ApartamentNumber", "City", "HouseNumber", "PostalCode", "StreetName" },
                values: new object[] { "7", "Kraków", "5A", "31-002", "Długa" });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ApartamentNumber", "City", "HouseNumber", "PostalCode", "StreetName" },
                values: new object[] { "1", "Poznań", "15", "60-101", "Lechicka" });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ApartamentNumber", "City", "HouseNumber", "PostalCode", "StreetName" },
                values: new object[] { "6", "Wrocław", "22", "50-500", "Słoneczna" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Email", "FirstName", "HireDate", "LastName", "Pesel", "Phone", "Position", "Salary", "UserId" },
                values: new object[] { new DateTime(2025, 12, 31, 16, 33, 18, 982, DateTimeKind.Utc).AddTicks(6654), "anna.nowak@example.com", "Anna", new DateTime(2025, 12, 31, 16, 33, 18, 982, DateTimeKind.Utc).AddTicks(6654), "Nowak", "92030554321", "501501501", "HR Manager", 9500m, "31c35515-0af5-4351-8061-cf16f84a9162" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Email", "FirstName", "HireDate", "LastName", "Pesel", "Phone", "Position", "Salary", "UserId" },
                values: new object[] { new DateTime(2025, 12, 31, 16, 33, 18, 982, DateTimeKind.Utc).AddTicks(6656), "tomasz.mazur@example.com", "Tomasz", new DateTime(2025, 12, 31, 16, 33, 18, 982, DateTimeKind.Utc).AddTicks(6655), "Mazur", "87092311223", "600700800", "DevOps Engineer", 12000m, "31c35515-0af5-4351-8061-cf16f84a9162" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Email", "FirstName", "HireDate", "LastName", "Pesel", "Phone", "Position", "Salary", "UserId" },
                values: new object[] { new DateTime(2025, 12, 31, 16, 33, 18, 982, DateTimeKind.Utc).AddTicks(6657), "natalia.bak@example.com", "Natalia", new DateTime(2025, 12, 31, 16, 33, 18, 982, DateTimeKind.Utc).AddTicks(6657), "Bąk", "98010199887", "733444222", "UX Designer", 9000m, "31c35515-0af5-4351-8061-cf16f84a9162" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "CreatedAt", "Email", "FirstName", "HireDate", "LastName", "Pesel", "Phone", "Position", "Salary", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 12, 31, 16, 33, 18, 982, DateTimeKind.Utc).AddTicks(6649), "jan.kowalski@example.com", "Jan", new DateTime(2025, 12, 31, 16, 33, 18, 982, DateTimeKind.Utc).AddTicks(6648), "Kowalski", "90010112345", "500600700", "Programista", 8000m, null, "13313a98-eeaa-4500-9f61-7ecb7953a12e" },
                    { 2, new DateTime(2025, 12, 31, 16, 33, 18, 982, DateTimeKind.Utc).AddTicks(6651), "marek.zielinski@example.com", "Marek", new DateTime(2025, 12, 31, 16, 33, 18, 982, DateTimeKind.Utc).AddTicks(6650), "Zieliński", "88050565432", "505404303", "Tester", 6500m, null, "13313a98-eeaa-4500-9f61-7ecb7953a12e" },
                    { 3, new DateTime(2025, 12, 31, 16, 33, 18, 982, DateTimeKind.Utc).AddTicks(6652), "karolina.lis@example.com", "Karolina", new DateTime(2025, 12, 31, 16, 33, 18, 982, DateTimeKind.Utc).AddTicks(6652), "Lis", "95021287654", "777888999", "Project Manager", 11000m, null, "13313a98-eeaa-4500-9f61-7ecb7953a12e" }
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "ApartamentNumber", "City", "EmployeeId", "HouseNumber", "PostalCode", "StreetName" },
                values: new object[,]
                {
                    { 1, "3", "Warszawa", 1, "12", "00-001", "Polna" },
                    { 2, "2", "Łódź", 2, "8", "91-005", "Kwiatowa" },
                    { 3, "10", "Gdańsk", 3, "5", "80-111", "Morska" }
                });
        }
    }
}
