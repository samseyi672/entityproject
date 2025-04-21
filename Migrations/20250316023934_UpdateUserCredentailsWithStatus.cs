using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityProject.Migrations
{
    public partial class UpdateUserCredentailsWithStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "status",
                table: "asset_capital_insurance_user_credentials",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "temporarypin",
                table: "asset_capital_insurance_user_credentials",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "status",
                table: "asset_capital_insurance_user_credentials");

            migrationBuilder.DropColumn(
                name: "temporarypin",
                table: "asset_capital_insurance_user_credentials");
        }
    }
}
