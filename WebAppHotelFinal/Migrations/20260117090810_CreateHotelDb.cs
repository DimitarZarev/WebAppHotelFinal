using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppHotelFinal.Migrations
{
    /// <inheritdoc />
    public partial class CreateHotelDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ROLE_ADMIN",
                column: "OnCreated",
                value: new DateTime(2026, 1, 17, 9, 8, 9, 559, DateTimeKind.Utc).AddTicks(7385));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ROLE_EMPLOYEE",
                column: "OnCreated",
                value: new DateTime(2026, 1, 17, 9, 8, 9, 559, DateTimeKind.Utc).AddTicks(7447));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ROLE_ADMIN",
                column: "OnCreated",
                value: new DateTime(2026, 1, 17, 8, 57, 32, 537, DateTimeKind.Utc).AddTicks(5756));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ROLE_EMPLOYEE",
                column: "OnCreated",
                value: new DateTime(2026, 1, 17, 8, 57, 32, 537, DateTimeKind.Utc).AddTicks(5813));
        }
    }
}
