using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d2fe392f-4f60-4963-ba3a-ea52b71fb53e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "05f74267-5815-47b0-8617-ce14e122ecea", "AQAAAAIAAYagAAAAEBG47cvoy7eUspsBPMpAgImXxbd7mo5GwqcoIdqP3Ghprhf13ILct9ufcYQTPSFfbQ==", "d7318832-4925-43a2-8bea-a92f5da01098" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d4757375-a497-496b-85dc-a510027bd9b1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "18e3c025-43e6-4cad-bdd0-90eee16f9a08", "AQAAAAIAAYagAAAAEIe28/bV5bg49vFfVBEfEEc28JLMYWqsYgFJK1A7ZUR6/EofpaZkRIhPUghBHzNjWQ==", "cc64d701-f746-4f8c-9a69-c859769ee5ba" });

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 905, DateTimeKind.Unspecified).AddTicks(8420), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 905, DateTimeKind.Unspecified).AddTicks(8420), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6460), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6460), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6460), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6460), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6470), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6460), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6470), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6470), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6470), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6470), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6470), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6470), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6470), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6470), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6470), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6470), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6470), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6470), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6470), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6470), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6470), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6470), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6470), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6470), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6470), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6480), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6480), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6480), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6480), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6480), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ProductId", "Quantity", "UnitPrice" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 905, DateTimeKind.Unspecified).AddTicks(8800), new TimeSpan(0, 0, 0, 0, 0)), 32, 4, 266m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "OrderId", "ProductId", "Quantity", "UnitPrice" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 905, DateTimeKind.Unspecified).AddTicks(8800), new TimeSpan(0, 0, 0, 0, 0)), 1, 30, 3, 469m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "OrderId", "ProductId", "Quantity", "UnitPrice" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 905, DateTimeKind.Unspecified).AddTicks(8800), new TimeSpan(0, 0, 0, 0, 0)), 1, 22, 4, 66m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "OrderId", "ProductId", "Quantity", "UnitPrice" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 905, DateTimeKind.Unspecified).AddTicks(8800), new TimeSpan(0, 0, 0, 0, 0)), 1, 22, 3, 362m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "OrderId", "ProductId", "Quantity", "UnitPrice" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 905, DateTimeKind.Unspecified).AddTicks(8810), new TimeSpan(0, 0, 0, 0, 0)), 2, 35, 3, 174m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "OrderId", "ProductId", "Quantity", "UnitPrice" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 905, DateTimeKind.Unspecified).AddTicks(8810), new TimeSpan(0, 0, 0, 0, 0)), 2, 39, 1, 133m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "OrderId", "ProductId", "UnitPrice" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 905, DateTimeKind.Unspecified).AddTicks(8820), new TimeSpan(0, 0, 0, 0, 0)), 3, 39, 298m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "OrderId", "ProductId", "Quantity", "UnitPrice" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 905, DateTimeKind.Unspecified).AddTicks(8820), new TimeSpan(0, 0, 0, 0, 0)), 3, 17, 4, 12m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "OrderId", "ProductId", "UnitPrice" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 905, DateTimeKind.Unspecified).AddTicks(8820), new TimeSpan(0, 0, 0, 0, 0)), 3, 37, 437m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "OrderId", "ProductId", "UnitPrice" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 905, DateTimeKind.Unspecified).AddTicks(8820), new TimeSpan(0, 0, 0, 0, 0)), 3, 36, 344m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "OrderId", "ProductId", "Quantity", "UnitPrice" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 905, DateTimeKind.Unspecified).AddTicks(8860), new TimeSpan(0, 0, 0, 0, 0)), 4, 27, 4, 270m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "OrderId", "ProductId", "Quantity", "UnitPrice" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 905, DateTimeKind.Unspecified).AddTicks(8860), new TimeSpan(0, 0, 0, 0, 0)), 4, 21, 4, 280m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "OrderId", "ProductId", "UnitPrice" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 905, DateTimeKind.Unspecified).AddTicks(8860), new TimeSpan(0, 0, 0, 0, 0)), 4, 40, 188m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "OrderId", "ProductId", "Quantity", "UnitPrice" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 905, DateTimeKind.Unspecified).AddTicks(8870), new TimeSpan(0, 0, 0, 0, 0)), 5, 38, 2, 495m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "OrderId", "ProductId", "Quantity", "UnitPrice" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 905, DateTimeKind.Unspecified).AddTicks(8870), new TimeSpan(0, 0, 0, 0, 0)), 6, 23, 3, 357m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "OrderId", "ProductId", "Quantity", "UnitPrice" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 905, DateTimeKind.Unspecified).AddTicks(8870), new TimeSpan(0, 0, 0, 0, 0)), 6, 31, 5, 481m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "OrderId", "ProductId", "UnitPrice" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 905, DateTimeKind.Unspecified).AddTicks(8870), new TimeSpan(0, 0, 0, 0, 0)), 6, 6, 154m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "OrderId", "ProductId", "UnitPrice" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 905, DateTimeKind.Unspecified).AddTicks(8880), new TimeSpan(0, 0, 0, 0, 0)), 6, 12, 237m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "OrderId", "Quantity", "UnitPrice" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 905, DateTimeKind.Unspecified).AddTicks(8880), new TimeSpan(0, 0, 0, 0, 0)), 7, 2, 278m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "OrderId", "ProductId", "Quantity", "UnitPrice" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 905, DateTimeKind.Unspecified).AddTicks(8880), new TimeSpan(0, 0, 0, 0, 0)), 7, 36, 1, 294m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "OrderId", "ProductId", "UnitPrice" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 905, DateTimeKind.Unspecified).AddTicks(8880), new TimeSpan(0, 0, 0, 0, 0)), 7, 13, 422m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "OrderId", "ProductId", "Quantity", "UnitPrice" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 905, DateTimeKind.Unspecified).AddTicks(8880), new TimeSpan(0, 0, 0, 0, 0)), 7, 15, 2, 115m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "OrderId", "ProductId", "UnitPrice" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 905, DateTimeKind.Unspecified).AddTicks(8880), new TimeSpan(0, 0, 0, 0, 0)), 7, 30, 145m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "OrderId", "ProductId", "Quantity", "UnitPrice" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 905, DateTimeKind.Unspecified).AddTicks(8890), new TimeSpan(0, 0, 0, 0, 0)), 8, 7, 2, 126m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "ProductId", "Quantity", "UnitPrice" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 905, DateTimeKind.Unspecified).AddTicks(8900), new TimeSpan(0, 0, 0, 0, 0)), 28, 5, 229m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "ProductId", "Quantity", "UnitPrice" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 905, DateTimeKind.Unspecified).AddTicks(8900), new TimeSpan(0, 0, 0, 0, 0)), 40, 4, 279m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "ProductId", "Quantity", "UnitPrice" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 905, DateTimeKind.Unspecified).AddTicks(8900), new TimeSpan(0, 0, 0, 0, 0)), 13, 2, 438m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "OrderId", "ProductId", "Quantity", "UnitPrice" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 905, DateTimeKind.Unspecified).AddTicks(8910), new TimeSpan(0, 0, 0, 0, 0)), 11, 19, 3, 322m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "OrderId", "ProductId", "Quantity", "UnitPrice" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 905, DateTimeKind.Unspecified).AddTicks(8910), new TimeSpan(0, 0, 0, 0, 0)), 11, 22, 2, 130m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "ProductId", "Quantity", "UnitPrice" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 905, DateTimeKind.Unspecified).AddTicks(8910), new TimeSpan(0, 0, 0, 0, 0)), 33, 1, 250m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "ProductId", "Quantity", "UnitPrice" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 905, DateTimeKind.Unspecified).AddTicks(8910), new TimeSpan(0, 0, 0, 0, 0)), 15, 3, 431m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "OrderId", "ProductId", "Quantity", "UnitPrice" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 905, DateTimeKind.Unspecified).AddTicks(8920), new TimeSpan(0, 0, 0, 0, 0)), 12, 18, 1, 122m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "OrderId", "ProductId", "Quantity", "UnitPrice" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 905, DateTimeKind.Unspecified).AddTicks(8930), new TimeSpan(0, 0, 0, 0, 0)), 13, 6, 1, 423m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "OrderId", "ProductId", "Quantity", "UnitPrice" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 905, DateTimeKind.Unspecified).AddTicks(8930), new TimeSpan(0, 0, 0, 0, 0)), 13, 24, 3, 85m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "OrderId", "ProductId", "UnitPrice" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 905, DateTimeKind.Unspecified).AddTicks(8930), new TimeSpan(0, 0, 0, 0, 0)), 13, 35, 38m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "OrderId", "ProductId", "Quantity", "UnitPrice" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 905, DateTimeKind.Unspecified).AddTicks(8930), new TimeSpan(0, 0, 0, 0, 0)), 13, 25, 5, 270m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "ProductId", "Quantity", "UnitPrice" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 905, DateTimeKind.Unspecified).AddTicks(8930), new TimeSpan(0, 0, 0, 0, 0)), 27, 5, 291m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "OrderId", "ProductId", "Quantity", "UnitPrice" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 905, DateTimeKind.Unspecified).AddTicks(8930), new TimeSpan(0, 0, 0, 0, 0)), 14, 31, 2, 278m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "OrderId", "ProductId", "Quantity", "UnitPrice" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 905, DateTimeKind.Unspecified).AddTicks(8940), new TimeSpan(0, 0, 0, 0, 0)), 15, 28, 2, 458m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "OrderId", "ProductId", "Quantity", "UnitPrice" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 905, DateTimeKind.Unspecified).AddTicks(8950), new TimeSpan(0, 0, 0, 0, 0)), 16, 9, 5, 411m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "OrderId", "ProductId", "UnitPrice" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 905, DateTimeKind.Unspecified).AddTicks(8950), new TimeSpan(0, 0, 0, 0, 0)), 16, 38, 250m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "OrderId", "ProductId", "Quantity", "UnitPrice" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 905, DateTimeKind.Unspecified).AddTicks(8950), new TimeSpan(0, 0, 0, 0, 0)), 16, 8, 4, 491m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "OrderId", "ProductId", "Quantity", "UnitPrice" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 905, DateTimeKind.Unspecified).AddTicks(8950), new TimeSpan(0, 0, 0, 0, 0)), 16, 24, 2, 304m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "OrderId", "ProductId", "Quantity", "UnitPrice" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 905, DateTimeKind.Unspecified).AddTicks(8960), new TimeSpan(0, 0, 0, 0, 0)), 17, 7, 5, 296m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "OrderId", "ProductId", "Quantity", "UnitPrice" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 905, DateTimeKind.Unspecified).AddTicks(8960), new TimeSpan(0, 0, 0, 0, 0)), 17, 8, 4, 184m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "OrderId", "ProductId", "Quantity", "UnitPrice" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 905, DateTimeKind.Unspecified).AddTicks(8960), new TimeSpan(0, 0, 0, 0, 0)), 17, 27, 3, 283m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "ProductId", "Quantity", "UnitPrice" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 905, DateTimeKind.Unspecified).AddTicks(8960), new TimeSpan(0, 0, 0, 0, 0)), 23, 5, 295m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "ProductId", "UnitPrice" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 905, DateTimeKind.Unspecified).AddTicks(8960), new TimeSpan(0, 0, 0, 0, 0)), 32, 375m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "ProductId", "Quantity", "UnitPrice" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 905, DateTimeKind.Unspecified).AddTicks(8960), new TimeSpan(0, 0, 0, 0, 0)), 35, 4, 286m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "OrderId", "ProductId", "Quantity", "UnitPrice" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 905, DateTimeKind.Unspecified).AddTicks(8970), new TimeSpan(0, 0, 0, 0, 0)), 19, 4, 4, 167m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "ProductId", "Quantity", "UnitPrice" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 905, DateTimeKind.Unspecified).AddTicks(8970), new TimeSpan(0, 0, 0, 0, 0)), 13, 1, 477m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "OrderId", "ProductId", "Quantity", "UnitPrice" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 905, DateTimeKind.Unspecified).AddTicks(8980), new TimeSpan(0, 0, 0, 0, 0)), 20, 22, 1, 170m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "OrderId", "ProductId", "Quantity", "UnitPrice" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 905, DateTimeKind.Unspecified).AddTicks(8980), new TimeSpan(0, 0, 0, 0, 0)), 20, 13, 3, 229m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "ProductId", "Quantity", "UnitPrice" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 905, DateTimeKind.Unspecified).AddTicks(8980), new TimeSpan(0, 0, 0, 0, 0)), 33, 5, 499m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ApplicationUserId", "CreatedAt" },
                values: new object[] { "d4757375-a497-496b-85dc-a510027bd9b1", new DateTimeOffset(new DateTime(2024, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ApplicationUserId", "CreatedAt" },
                values: new object[] { "d2fe392f-4f60-4963-ba3a-ea52b71fb53e", new DateTimeOffset(new DateTime(2024, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ApplicationUserId", "CreatedAt" },
                values: new object[] { "d2fe392f-4f60-4963-ba3a-ea52b71fb53e", new DateTimeOffset(new DateTime(2024, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2025, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ApplicationUserId", "CreatedAt" },
                values: new object[] { "d4757375-a497-496b-85dc-a510027bd9b1", new DateTimeOffset(new DateTime(2024, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ApplicationUserId", "CreatedAt" },
                values: new object[] { "d2fe392f-4f60-4963-ba3a-ea52b71fb53e", new DateTimeOffset(new DateTime(2024, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ApplicationUserId", "CreatedAt", "OrderStatus" },
                values: new object[] { "d4757375-a497-496b-85dc-a510027bd9b1", new DateTimeOffset(new DateTime(2024, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 0 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "OrderStatus" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 0 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "OrderStatus" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ApplicationUserId", "CreatedAt" },
                values: new object[] { "d2fe392f-4f60-4963-ba3a-ea52b71fb53e", new DateTimeOffset(new DateTime(2024, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ApplicationUserId", "CreatedAt" },
                values: new object[] { "d4757375-a497-496b-85dc-a510027bd9b1", new DateTimeOffset(new DateTime(2024, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ApplicationUserId", "CreatedAt" },
                values: new object[] { "d2fe392f-4f60-4963-ba3a-ea52b71fb53e", new DateTimeOffset(new DateTime(2024, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ApplicationUserId", "CreatedAt", "OrderStatus" },
                values: new object[] { "d2fe392f-4f60-4963-ba3a-ea52b71fb53e", new DateTimeOffset(new DateTime(2024, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "OrderStatus" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6880), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6890), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6890), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6890), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6890), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6890), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6890), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6890), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6890), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6890), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6890), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6890), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6890), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6890), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6890), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6890), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6890), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6890), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6900), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6900), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6900), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6900), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6900), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6900), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6900), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6900), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6900), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6900), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6900), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6900), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6900), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6900), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6900), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6900), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6900), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6900), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6910), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6910), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6910), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6910), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6910), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6910), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6910), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6910), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6910), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6910), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6910), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6910), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6910), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6910), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6910), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6920), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6920), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6920), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6920), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6920), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6920), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6920), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6920), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6920), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6920), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6920), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6920), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6920), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6920), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6920), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6920), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6920), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6920), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6920), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6930), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6920), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6930), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6930), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6930), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6930), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6930), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6930), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6930), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6930), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6930), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6930), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6930), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6930), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6930), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6930), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6930), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6930), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6930), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6930), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6930), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6940), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6940), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6940), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6940), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6940), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6940), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6940), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6940), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6940), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6940), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6940), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6940), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6940), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6940), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6940), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6940), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6940), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6940), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6940), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6950), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6950), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 7, 41, 57, 829, DateTimeKind.Unspecified).AddTicks(6950), new TimeSpan(0, 0, 0, 0, 0)) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d2fe392f-4f60-4963-ba3a-ea52b71fb53e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4f6566c3-c534-4fc7-83ce-c338e33ac2b7", "AQAAAAIAAYagAAAAEHyYBwm6OWNUSRzcfYV1AIm6tDoocBxjU0kjYW6PPgpUOa4ilEuflcqnxMSxrBogrA==", "76286efd-bb42-4e23-8874-82f20e4b3dc3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d4757375-a497-496b-85dc-a510027bd9b1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2cd4ff09-2dcf-4306-94cd-e4094598cca8", "AQAAAAIAAYagAAAAEB70QjBPZ7l7VTqOmXk4KeN6y8FUOxHgAxaSgUyUANzW6BIPoSwKRPZMfQ3/dpRPDg==", "0552693f-facc-4732-adb7-adadc0ff0536" });

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 262, DateTimeKind.Unspecified).AddTicks(1820), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 262, DateTimeKind.Unspecified).AddTicks(1820), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7280), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7280), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7280), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7280), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7280), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7280), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7280), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7280), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7280), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7280), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7280), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7280), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7280), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7290), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7290), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7290), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7290), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7290), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7290), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7290), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7290), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7290), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7290), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7290), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7290), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7290), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7290), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7290), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7290), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7290), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ProductId", "Quantity", "UnitPrice" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 262, DateTimeKind.Unspecified).AddTicks(2170), new TimeSpan(0, 0, 0, 0, 0)), 25, 5, 317m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "OrderId", "ProductId", "Quantity", "UnitPrice" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 262, DateTimeKind.Unspecified).AddTicks(2180), new TimeSpan(0, 0, 0, 0, 0)), 2, 18, 2, 72m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "OrderId", "ProductId", "Quantity", "UnitPrice" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 262, DateTimeKind.Unspecified).AddTicks(2180), new TimeSpan(0, 0, 0, 0, 0)), 2, 2, 1, 358m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "OrderId", "ProductId", "Quantity", "UnitPrice" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 262, DateTimeKind.Unspecified).AddTicks(2180), new TimeSpan(0, 0, 0, 0, 0)), 2, 1, 4, 454m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "OrderId", "ProductId", "Quantity", "UnitPrice" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 262, DateTimeKind.Unspecified).AddTicks(2190), new TimeSpan(0, 0, 0, 0, 0)), 3, 29, 1, 239m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "OrderId", "ProductId", "Quantity", "UnitPrice" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 262, DateTimeKind.Unspecified).AddTicks(2200), new TimeSpan(0, 0, 0, 0, 0)), 4, 35, 3, 395m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "OrderId", "ProductId", "UnitPrice" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 262, DateTimeKind.Unspecified).AddTicks(2200), new TimeSpan(0, 0, 0, 0, 0)), 5, 3, 336m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "OrderId", "ProductId", "Quantity", "UnitPrice" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 262, DateTimeKind.Unspecified).AddTicks(2200), new TimeSpan(0, 0, 0, 0, 0)), 5, 14, 2, 402m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "OrderId", "ProductId", "UnitPrice" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 262, DateTimeKind.Unspecified).AddTicks(2210), new TimeSpan(0, 0, 0, 0, 0)), 6, 23, 132m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "OrderId", "ProductId", "UnitPrice" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 262, DateTimeKind.Unspecified).AddTicks(2210), new TimeSpan(0, 0, 0, 0, 0)), 6, 2, 257m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "OrderId", "ProductId", "Quantity", "UnitPrice" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 262, DateTimeKind.Unspecified).AddTicks(2220), new TimeSpan(0, 0, 0, 0, 0)), 7, 6, 2, 195m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "OrderId", "ProductId", "Quantity", "UnitPrice" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 262, DateTimeKind.Unspecified).AddTicks(2220), new TimeSpan(0, 0, 0, 0, 0)), 7, 24, 5, 262m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "OrderId", "ProductId", "UnitPrice" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 262, DateTimeKind.Unspecified).AddTicks(2220), new TimeSpan(0, 0, 0, 0, 0)), 7, 34, 485m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "OrderId", "ProductId", "Quantity", "UnitPrice" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 262, DateTimeKind.Unspecified).AddTicks(2220), new TimeSpan(0, 0, 0, 0, 0)), 7, 33, 4, 309m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "OrderId", "ProductId", "Quantity", "UnitPrice" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 262, DateTimeKind.Unspecified).AddTicks(2220), new TimeSpan(0, 0, 0, 0, 0)), 7, 32, 4, 103m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "OrderId", "ProductId", "Quantity", "UnitPrice" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 262, DateTimeKind.Unspecified).AddTicks(2220), new TimeSpan(0, 0, 0, 0, 0)), 8, 21, 4, 43m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "OrderId", "ProductId", "UnitPrice" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 262, DateTimeKind.Unspecified).AddTicks(2220), new TimeSpan(0, 0, 0, 0, 0)), 8, 9, 56m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "OrderId", "ProductId", "UnitPrice" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 262, DateTimeKind.Unspecified).AddTicks(2220), new TimeSpan(0, 0, 0, 0, 0)), 8, 23, 372m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "OrderId", "Quantity", "UnitPrice" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 262, DateTimeKind.Unspecified).AddTicks(2220), new TimeSpan(0, 0, 0, 0, 0)), 8, 4, 348m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "OrderId", "ProductId", "Quantity", "UnitPrice" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 262, DateTimeKind.Unspecified).AddTicks(2230), new TimeSpan(0, 0, 0, 0, 0)), 8, 30, 4, 32m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "OrderId", "ProductId", "UnitPrice" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 262, DateTimeKind.Unspecified).AddTicks(2230), new TimeSpan(0, 0, 0, 0, 0)), 9, 10, 475m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "OrderId", "ProductId", "Quantity", "UnitPrice" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 262, DateTimeKind.Unspecified).AddTicks(2230), new TimeSpan(0, 0, 0, 0, 0)), 9, 30, 1, 393m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "OrderId", "ProductId", "UnitPrice" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 262, DateTimeKind.Unspecified).AddTicks(2230), new TimeSpan(0, 0, 0, 0, 0)), 9, 36, 45m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "OrderId", "ProductId", "Quantity", "UnitPrice" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 262, DateTimeKind.Unspecified).AddTicks(2230), new TimeSpan(0, 0, 0, 0, 0)), 9, 19, 5, 137m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "ProductId", "Quantity", "UnitPrice" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 262, DateTimeKind.Unspecified).AddTicks(2230), new TimeSpan(0, 0, 0, 0, 0)), 34, 3, 235m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "ProductId", "Quantity", "UnitPrice" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 262, DateTimeKind.Unspecified).AddTicks(2240), new TimeSpan(0, 0, 0, 0, 0)), 15, 2, 373m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "ProductId", "Quantity", "UnitPrice" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 262, DateTimeKind.Unspecified).AddTicks(2240), new TimeSpan(0, 0, 0, 0, 0)), 40, 5, 247m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "OrderId", "ProductId", "Quantity", "UnitPrice" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 262, DateTimeKind.Unspecified).AddTicks(2240), new TimeSpan(0, 0, 0, 0, 0)), 10, 40, 5, 408m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "OrderId", "ProductId", "Quantity", "UnitPrice" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 262, DateTimeKind.Unspecified).AddTicks(2240), new TimeSpan(0, 0, 0, 0, 0)), 10, 4, 3, 459m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "ProductId", "Quantity", "UnitPrice" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 262, DateTimeKind.Unspecified).AddTicks(2250), new TimeSpan(0, 0, 0, 0, 0)), 37, 5, 95m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "ProductId", "Quantity", "UnitPrice" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 262, DateTimeKind.Unspecified).AddTicks(2300), new TimeSpan(0, 0, 0, 0, 0)), 25, 5, 284m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "OrderId", "ProductId", "Quantity", "UnitPrice" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 262, DateTimeKind.Unspecified).AddTicks(2300), new TimeSpan(0, 0, 0, 0, 0)), 11, 31, 5, 27m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "OrderId", "ProductId", "Quantity", "UnitPrice" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 262, DateTimeKind.Unspecified).AddTicks(2300), new TimeSpan(0, 0, 0, 0, 0)), 11, 1, 2, 481m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "OrderId", "ProductId", "Quantity", "UnitPrice" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 262, DateTimeKind.Unspecified).AddTicks(2310), new TimeSpan(0, 0, 0, 0, 0)), 12, 25, 1, 485m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "OrderId", "ProductId", "UnitPrice" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 262, DateTimeKind.Unspecified).AddTicks(2310), new TimeSpan(0, 0, 0, 0, 0)), 12, 7, 86m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "OrderId", "ProductId", "Quantity", "UnitPrice" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 262, DateTimeKind.Unspecified).AddTicks(2310), new TimeSpan(0, 0, 0, 0, 0)), 12, 18, 4, 459m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "ProductId", "Quantity", "UnitPrice" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 262, DateTimeKind.Unspecified).AddTicks(2310), new TimeSpan(0, 0, 0, 0, 0)), 29, 2, 396m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "OrderId", "ProductId", "Quantity", "UnitPrice" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 262, DateTimeKind.Unspecified).AddTicks(2310), new TimeSpan(0, 0, 0, 0, 0)), 13, 13, 1, 411m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "OrderId", "ProductId", "Quantity", "UnitPrice" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 262, DateTimeKind.Unspecified).AddTicks(2310), new TimeSpan(0, 0, 0, 0, 0)), 13, 30, 3, 206m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "OrderId", "ProductId", "Quantity", "UnitPrice" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 262, DateTimeKind.Unspecified).AddTicks(2310), new TimeSpan(0, 0, 0, 0, 0)), 13, 28, 4, 458m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "OrderId", "ProductId", "UnitPrice" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 262, DateTimeKind.Unspecified).AddTicks(2310), new TimeSpan(0, 0, 0, 0, 0)), 13, 31, 139m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "OrderId", "ProductId", "Quantity", "UnitPrice" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 262, DateTimeKind.Unspecified).AddTicks(2320), new TimeSpan(0, 0, 0, 0, 0)), 14, 6, 5, 105m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "OrderId", "ProductId", "Quantity", "UnitPrice" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 262, DateTimeKind.Unspecified).AddTicks(2320), new TimeSpan(0, 0, 0, 0, 0)), 14, 2, 1, 66m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "OrderId", "ProductId", "Quantity", "UnitPrice" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 262, DateTimeKind.Unspecified).AddTicks(2330), new TimeSpan(0, 0, 0, 0, 0)), 15, 39, 3, 193m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "OrderId", "ProductId", "Quantity", "UnitPrice" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 262, DateTimeKind.Unspecified).AddTicks(2330), new TimeSpan(0, 0, 0, 0, 0)), 16, 22, 3, 498m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "OrderId", "ProductId", "Quantity", "UnitPrice" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 262, DateTimeKind.Unspecified).AddTicks(2330), new TimeSpan(0, 0, 0, 0, 0)), 16, 37, 2, 248m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "ProductId", "Quantity", "UnitPrice" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 262, DateTimeKind.Unspecified).AddTicks(2340), new TimeSpan(0, 0, 0, 0, 0)), 4, 2, 60m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "ProductId", "UnitPrice" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 262, DateTimeKind.Unspecified).AddTicks(2340), new TimeSpan(0, 0, 0, 0, 0)), 22, 341m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "ProductId", "Quantity", "UnitPrice" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 262, DateTimeKind.Unspecified).AddTicks(2340), new TimeSpan(0, 0, 0, 0, 0)), 18, 3, 80m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "OrderId", "ProductId", "Quantity", "UnitPrice" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 262, DateTimeKind.Unspecified).AddTicks(2340), new TimeSpan(0, 0, 0, 0, 0)), 18, 29, 2, 27m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "ProductId", "Quantity", "UnitPrice" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 262, DateTimeKind.Unspecified).AddTicks(2350), new TimeSpan(0, 0, 0, 0, 0)), 34, 3, 74m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "OrderId", "ProductId", "Quantity", "UnitPrice" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 262, DateTimeKind.Unspecified).AddTicks(2350), new TimeSpan(0, 0, 0, 0, 0)), 19, 12, 5, 196m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "OrderId", "ProductId", "Quantity", "UnitPrice" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 262, DateTimeKind.Unspecified).AddTicks(2350), new TimeSpan(0, 0, 0, 0, 0)), 19, 40, 4, 33m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "ProductId", "Quantity", "UnitPrice" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 262, DateTimeKind.Unspecified).AddTicks(2360), new TimeSpan(0, 0, 0, 0, 0)), 5, 1, 428m });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "IsActive", "IsDeleted", "OrderId", "ProductId", "Quantity", "UnitPrice", "UpdatedAt" },
                values: new object[,]
                {
                    { 55, new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 262, DateTimeKind.Unspecified).AddTicks(2360), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), true, false, 20, 36, 1, 65m, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 56, new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 262, DateTimeKind.Unspecified).AddTicks(2360), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), true, false, 20, 17, 4, 118m, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 57, new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 262, DateTimeKind.Unspecified).AddTicks(2360), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), true, false, 20, 30, 1, 249m, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) }
                });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ApplicationUserId", "CreatedAt" },
                values: new object[] { "d2fe392f-4f60-4963-ba3a-ea52b71fb53e", new DateTimeOffset(new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ApplicationUserId", "CreatedAt" },
                values: new object[] { "d4757375-a497-496b-85dc-a510027bd9b1", new DateTimeOffset(new DateTime(2025, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ApplicationUserId", "CreatedAt" },
                values: new object[] { "d4757375-a497-496b-85dc-a510027bd9b1", new DateTimeOffset(new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ApplicationUserId", "CreatedAt" },
                values: new object[] { "d2fe392f-4f60-4963-ba3a-ea52b71fb53e", new DateTimeOffset(new DateTime(2025, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ApplicationUserId", "CreatedAt" },
                values: new object[] { "d4757375-a497-496b-85dc-a510027bd9b1", new DateTimeOffset(new DateTime(2025, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ApplicationUserId", "CreatedAt", "OrderStatus" },
                values: new object[] { "d2fe392f-4f60-4963-ba3a-ea52b71fb53e", new DateTimeOffset(new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2025, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2025, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "OrderStatus" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "OrderStatus" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 0 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ApplicationUserId", "CreatedAt" },
                values: new object[] { "d4757375-a497-496b-85dc-a510027bd9b1", new DateTimeOffset(new DateTime(2024, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ApplicationUserId", "CreatedAt" },
                values: new object[] { "d2fe392f-4f60-4963-ba3a-ea52b71fb53e", new DateTimeOffset(new DateTime(2025, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ApplicationUserId", "CreatedAt" },
                values: new object[] { "d4757375-a497-496b-85dc-a510027bd9b1", new DateTimeOffset(new DateTime(2024, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ApplicationUserId", "CreatedAt", "OrderStatus" },
                values: new object[] { "d4757375-a497-496b-85dc-a510027bd9b1", new DateTimeOffset(new DateTime(2024, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "OrderStatus" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7670), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7670), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7670), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7670), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7670), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7670), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7670), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7670), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7670), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7670), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7680), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7670), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7680), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7680), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7680), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7680), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7680), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7680), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7680), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7680), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7680), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7680), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7680), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7680), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7680), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7680), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7680), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7680), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7680), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7680), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7690), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7690), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7690), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7690), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7690), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7690), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7690), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7690), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7690), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7690), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7690), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7690), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7690), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7690), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7690), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7690), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7690), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7690), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7690), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7690), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7690), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7700), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7700), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7700), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7700), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7700), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7700), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7700), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7700), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7700), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7700), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7700), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7700), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7700), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7700), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7700), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7700), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7700), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7700), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7700), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7710), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7710), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7710), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7710), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7710), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7710), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7710), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7710), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7710), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7710), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7710), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7710), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7710), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7710), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7710), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7710), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7710), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7710), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7720), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7720), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7720), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7720), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7720), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7720), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7720), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7720), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7720), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7720), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7720), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7720), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7720), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7720), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7720), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7720), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7720), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7720), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7720), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7720), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7730), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7730), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7730), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7730), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7730), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7730), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7730), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7730), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7730), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7730), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7730), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 16, 0, 41, 37, 189, DateTimeKind.Unspecified).AddTicks(7730), new TimeSpan(0, 0, 0, 0, 0)) });
        }
    }
}
