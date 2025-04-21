using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityProject.Migrations
{
    public partial class UpdateEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "username",
                table: "asset_capital_insurance_user",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "regid",
                table: "asset_capital_insurance_custdatanotfrombvn",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "username",
                table: "asset_capital_insurance_custdatanotfrombvn",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "username",
                table: "asset_capital_insurance_user");

            migrationBuilder.DropColumn(
                name: "regid",
                table: "asset_capital_insurance_custdatanotfrombvn");

            migrationBuilder.DropColumn(
                name: "username",
                table: "asset_capital_insurance_custdatanotfrombvn");
        }
    }
}
