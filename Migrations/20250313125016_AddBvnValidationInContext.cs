using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityProject.Migrations
{
    public partial class AddBvnValidationInContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "asset_capital_insurance_bvn_validation",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    BVN = table.Column<string>(nullable: true),
                    PHONENUMBER = table.Column<string>(nullable: true),
                    PHONENUMBER2 = table.Column<string>(nullable: true),
                    EMAIL = table.Column<string>(nullable: true),
                    GENDER = table.Column<string>(nullable: true),
                    LgaResidence = table.Column<string>(nullable: true),
                    LgaOrigin = table.Column<string>(nullable: true),
                    MARITALSTATUS = table.Column<string>(nullable: true),
                    NATIONALITY = table.Column<string>(nullable: true),
                    RESIDENTIALADDRESS = table.Column<string>(nullable: true),
                    STATEORIGIN = table.Column<string>(nullable: true),
                    StateResidence = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: true),
                    DOB = table.Column<DateTime>(nullable: true),
                    FIRSTNAME = table.Column<string>(nullable: true),
                    MIDDLENAME = table.Column<string>(nullable: true),
                    LASTNAME = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_asset_capital_insurance_bvn_validation", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "asset_capital_insurance_bvn_validation");
        }
    }
}
