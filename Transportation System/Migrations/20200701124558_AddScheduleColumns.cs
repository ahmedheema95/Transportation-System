using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Transportation_System.Migrations
{
    public partial class AddScheduleColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "ArrivalTime",
                table: "Schedules",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DepartureTime",
                table: "Schedules",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Destination",
                table: "Schedules",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EndPoint",
                table: "Schedules",
                nullable: true);

            migrationBuilder.AddColumn<TimeSpan>(
                name: "ExpectedTime",
                table: "Schedules",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.AddColumn<string>(
                name: "Startpoint",
                table: "Schedules",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ArrivalTime",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "DepartureTime",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "Destination",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "EndPoint",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "ExpectedTime",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "Startpoint",
                table: "Schedules");
        }
    }
}
