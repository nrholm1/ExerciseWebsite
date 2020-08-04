using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ExerciseWebsite.Migrations
{
    public partial class UpdateSetAndSetListSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateAdded",
                table: "SetLists");

            migrationBuilder.DropColumn(
                name: "OrderNo",
                table: "SetLists");

            migrationBuilder.DropColumn(
                name: "SetId",
                table: "SetLists");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateAdded",
                table: "Sets",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "OrderNo",
                table: "Sets",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateAdded",
                table: "Sets");

            migrationBuilder.DropColumn(
                name: "OrderNo",
                table: "Sets");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateAdded",
                table: "SetLists",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "OrderNo",
                table: "SetLists",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SetId",
                table: "SetLists",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }
    }
}
