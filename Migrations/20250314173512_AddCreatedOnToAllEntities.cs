using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityProject.Migrations
{
    public partial class AddCreatedOnToAllEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "created_on",
                table: "asset_capital_insurance_reg_session",
                newName: "createdon");

            migrationBuilder.AddColumn<DateTime>(
                name: "createdon",
                table: "asset_capital_insurance_user_credentials",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "createdon",
                table: "asset_capital_insurance_registration",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "createdon",
                table: "asset_capital_insurance_otp_session",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "createdon",
                table: "asset_capital_insurance_customerdevice",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "createdon",
                table: "asset_capital_insurance_custdatanotfrombvn",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "createdon",
                table: "asset_capital_insurance_user_credentials");

            migrationBuilder.DropColumn(
                name: "createdon",
                table: "asset_capital_insurance_registration");

            migrationBuilder.DropColumn(
                name: "createdon",
                table: "asset_capital_insurance_otp_session");

            migrationBuilder.DropColumn(
                name: "createdon",
                table: "asset_capital_insurance_customerdevice");

            migrationBuilder.DropColumn(
                name: "createdon",
                table: "asset_capital_insurance_custdatanotfrombvn");

            migrationBuilder.RenameColumn(
                name: "createdon",
                table: "asset_capital_insurance_reg_session",
                newName: "created_on");
        }
    }
}
