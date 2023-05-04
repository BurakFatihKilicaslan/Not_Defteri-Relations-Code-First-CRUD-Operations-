using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NotDefteri.Migrations
{
    public partial class Versiyon2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2023, 5, 2, 16, 54, 29, 647, DateTimeKind.Local).AddTicks(640));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2023, 5, 2, 14, 17, 28, 26, DateTimeKind.Local).AddTicks(5006));
        }
    }
}
