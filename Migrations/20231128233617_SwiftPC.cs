using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CAPSTONE_Swift_Server.Migrations
{
    /// <inheritdoc />
    public partial class SwiftPC : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "orders",
                keyColumn: "id",
                keyValue: 1,
                column: "date_time",
                value: new DateTime(2023, 11, 28, 17, 36, 16, 861, DateTimeKind.Local).AddTicks(8339));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "orders",
                keyColumn: "id",
                keyValue: 1,
                column: "date_time",
                value: new DateTime(2023, 11, 28, 11, 28, 7, 439, DateTimeKind.Local).AddTicks(2480));
        }
    }
}
