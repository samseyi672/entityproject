using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityProject.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "asset_capital_insurance_custdatanotfrombvn",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    channelId = table.Column<int>(nullable: false),
                    user_id = table.Column<string>(nullable: true),
                    phonenumber = table.Column<string>(nullable: true),
                    address = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    phonenumberfrombvn = table.Column<string>(nullable: true),
                    user_type = table.Column<string>(nullable: true),
                    created_at = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_asset_capital_insurance_custdatanotfrombvn", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "asset_capital_insurance_customerdevice",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    login_status = table.Column<string>(nullable: true),
                    username = table.Column<string>(nullable: true),
                    device = table.Column<string>(nullable: true),
                    track_device = table.Column<string>(nullable: true),
                    session = table.Column<string>(nullable: true),
                    user_type = table.Column<string>(nullable: true),
                    channelId = table.Column<int>(nullable: false),
                    created_at = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_asset_capital_insurance_customerdevice", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "asset_capital_insurance_mobile_device",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    device_token = table.Column<string>(nullable: true),
                    channelId = table.Column<int>(nullable: false),
                    device_id = table.Column<string>(nullable: true),
                    device_name = table.Column<string>(nullable: true),
                    user_id = table.Column<string>(nullable: true),
                    user_type = table.Column<string>(nullable: true),
                    created_at = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_asset_capital_insurance_mobile_device", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "asset_capital_insurance_otp_session",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    user_id = table.Column<string>(nullable: true),
                    created_at = table.Column<DateTime>(nullable: false),
                    user_type = table.Column<string>(nullable: true),
                    session = table.Column<string>(nullable: true),
                    otp = table.Column<string>(nullable: true),
                    otp_type = table.Column<int>(nullable: false),
                    status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_asset_capital_insurance_otp_session", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "asset_capital_insurance_reg_session",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    user_id = table.Column<string>(nullable: true),
                    session = table.Column<string>(nullable: true),
                    created_on = table.Column<DateTime>(nullable: false),
                    status = table.Column<int>(nullable: false),
                    channelId = table.Column<int>(nullable: false),
                    reg_id = table.Column<int>(nullable: false),
                    user_type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_asset_capital_insurance_reg_session", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "asset_capital_insurance_registration",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    username = table.Column<string>(nullable: true),
                    user_type = table.Column<string>(nullable: true),
                    first_name = table.Column<string>(nullable: true),
                    bvn = table.Column<string>(nullable: true),
                    nin = table.Column<string>(nullable: true),
                    last_name = table.Column<string>(nullable: true),
                    address = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    phonenumber = table.Column<string>(nullable: true),
                    othernames = table.Column<string>(nullable: true),
                    birth_date = table.Column<DateTime>(nullable: false),
                    idCountry = table.Column<string>(nullable: true),
                    idState = table.Column<string>(nullable: true),
                    idLga = table.Column<string>(nullable: true),
                    title = table.Column<string>(nullable: true),
                    gender = table.Column<string>(nullable: true),
                    marital_status = table.Column<string>(nullable: true),
                    maiden_name = table.Column<string>(nullable: true),
                    idreligion = table.Column<int>(nullable: false),
                    occupationId = table.Column<int>(nullable: false),
                    sourceOfFund = table.Column<string>(nullable: true),
                    employerCode = table.Column<string>(nullable: true),
                    created_at = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_asset_capital_insurance_registration", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "asset_capital_insurance_user",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    channelId = table.Column<int>(nullable: false),
                    first_name = table.Column<string>(nullable: true),
                    last_name = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    password = table.Column<string>(nullable: true),
                    picture = table.Column<string>(nullable: true),
                    status = table.Column<int>(nullable: false),
                    bvn = table.Column<string>(nullable: true),
                    nin = table.Column<string>(nullable: true),
                    address = table.Column<string>(nullable: true),
                    created_at = table.Column<DateTime>(nullable: false),
                    user_type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_asset_capital_insurance_user", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "asset_capital_insurance_user_credentials",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    user_id = table.Column<string>(nullable: true),
                    retries = table.Column<int>(nullable: false),
                    credential = table.Column<string>(nullable: true),
                    credential_type = table.Column<string>(nullable: true),
                    created_at = table.Column<DateTime>(nullable: false),
                    user_type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_asset_capital_insurance_user_credentials", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "asset_capital_insurance_user_session",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    user_id = table.Column<string>(nullable: true),
                    session = table.Column<string>(nullable: true),
                    created_on = table.Column<DateTime>(nullable: false),
                    status = table.Column<int>(nullable: false),
                    user_type = table.Column<string>(nullable: true),
                    channelId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_asset_capital_insurance_user_session", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "asset_capital_insurance_custdatanotfrombvn");

            migrationBuilder.DropTable(
                name: "asset_capital_insurance_customerdevice");

            migrationBuilder.DropTable(
                name: "asset_capital_insurance_mobile_device");

            migrationBuilder.DropTable(
                name: "asset_capital_insurance_otp_session");

            migrationBuilder.DropTable(
                name: "asset_capital_insurance_reg_session");

            migrationBuilder.DropTable(
                name: "asset_capital_insurance_registration");

            migrationBuilder.DropTable(
                name: "asset_capital_insurance_user");

            migrationBuilder.DropTable(
                name: "asset_capital_insurance_user_credentials");

            migrationBuilder.DropTable(
                name: "asset_capital_insurance_user_session");
        }
    }
}
