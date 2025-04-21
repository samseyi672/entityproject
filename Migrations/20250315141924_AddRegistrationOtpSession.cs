using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityProject.Migrations
{
    public partial class AddRegistrationOtpSession : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "asset_capital_insurance_registration_otp_session",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    created_at = table.Column<DateTime>(nullable: false),
                    createdon = table.Column<DateTime>(nullable: false),
                    user_type = table.Column<string>(nullable: true),
                    session = table.Column<string>(nullable: true),
                    otp = table.Column<string>(nullable: true),
                    otp_type = table.Column<int>(nullable: false),
                    status = table.Column<int>(nullable: false),
                    bvn = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_asset_capital_insurance_registration_otp_session", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "asset_capital_insurance_registration_otp_session");
        }
    }
}
