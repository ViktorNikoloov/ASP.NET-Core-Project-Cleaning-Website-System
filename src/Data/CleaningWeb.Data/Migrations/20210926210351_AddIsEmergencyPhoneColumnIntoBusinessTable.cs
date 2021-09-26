using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CleaningWeb.Data.Migrations
{
    public partial class AddIsEmergencyPhoneColumnIntoBusinessTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EmergencyPhone",
                table: "Businesses",
                newName: "Phone");

            migrationBuilder.AddColumn<bool>(
                name: "IsEmergencyPhone",
                table: "Businesses",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<int>(
                name: "ServiceId",
                table: "Appointments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Appointments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsEmergencyPhone",
                table: "Businesses");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Appointments");

            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "Businesses",
                newName: "EmergencyPhone");

            migrationBuilder.AlterColumn<int>(
                name: "ServiceId",
                table: "Appointments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }
    }
}
