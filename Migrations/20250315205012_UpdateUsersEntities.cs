using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityProject.Migrations
{
    public partial class UpdateUsersEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "customerid",
                table: "asset_capital_insurance_user",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "customerid",
                table: "asset_capital_insurance_user");
        }
    }
}
