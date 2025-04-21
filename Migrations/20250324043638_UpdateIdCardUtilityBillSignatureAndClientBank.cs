using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityProject.Migrations
{
    public partial class UpdateIdCardUtilityBillSignatureAndClientBank : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "createdon",
                table: "asset_capital_insurance_utilitybill",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "createdon",
                table: "asset_capital_insurance_signature",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "createdon",
                table: "asset_capital_insurance_idcard",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "createdon",
                table: "asset_capital_insurance_clientbank",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "createdon",
                table: "asset_capital_insurance_utilitybill");

            migrationBuilder.DropColumn(
                name: "createdon",
                table: "asset_capital_insurance_signature");

            migrationBuilder.DropColumn(
                name: "createdon",
                table: "asset_capital_insurance_idcard");

            migrationBuilder.DropColumn(
                name: "createdon",
                table: "asset_capital_insurance_clientbank");
        }
    }
}
