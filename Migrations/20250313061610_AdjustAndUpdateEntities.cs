using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityProject.Migrations
{
    public partial class AdjustAndUpdateEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "created_at",
                table: "asset_capital_insurance_mobile_device",
                newName: "createdon");

            migrationBuilder.RenameColumn(
                name: "device_id",
                table: "asset_capital_insurance_mobile_device",
                newName: "device");

            migrationBuilder.AlterColumn<long>(
                name: "user_id",
                table: "asset_capital_insurance_user_session",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "id",
                table: "asset_capital_insurance_user_session",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<DateTime>(
                name: "last_activity",
                table: "asset_capital_insurance_user_session",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "ucid",
                table: "asset_capital_insurance_user_session",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AlterColumn<long>(
                name: "id",
                table: "asset_capital_insurance_user_credentials",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<int>(
                name: "ucid",
                table: "asset_capital_insurance_user_credentials",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<long>(
                name: "id",
                table: "asset_capital_insurance_user",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<long>(
                name: "client_unique_ref",
                table: "asset_capital_insurance_user",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AlterColumn<string>(
                name: "birth_date",
                table: "asset_capital_insurance_registration",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AlterColumn<long>(
                name: "id",
                table: "asset_capital_insurance_registration",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<int>(
                name: "AccountOpened",
                table: "asset_capital_insurance_registration",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "customerId",
                table: "asset_capital_insurance_registration",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "deviceId",
                table: "asset_capital_insurance_registration",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "devicename",
                table: "asset_capital_insurance_registration",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "password",
                table: "asset_capital_insurance_registration",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProfiledOpened",
                table: "asset_capital_insurance_registration",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "RequestReference",
                table: "asset_capital_insurance_registration",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "validbvn",
                table: "asset_capital_insurance_registration",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "transpin",
                table: "asset_capital_insurance_registration",
                nullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "user_id",
                table: "asset_capital_insurance_reg_session",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ucid",
                table: "asset_capital_insurance_otp_session",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<long>(
                name: "user_id",
                table: "asset_capital_insurance_mobile_device",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "status",
                table: "asset_capital_insurance_mobile_device",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "last_activity",
                table: "asset_capital_insurance_user_session");

            migrationBuilder.DropColumn(
                name: "ucid",
                table: "asset_capital_insurance_user_session");

            migrationBuilder.DropColumn(
                name: "ucid",
                table: "asset_capital_insurance_user_credentials");

            migrationBuilder.DropColumn(
                name: "client_unique_ref",
                table: "asset_capital_insurance_user");

            migrationBuilder.DropColumn(
                name: "AccountOpened",
                table: "asset_capital_insurance_registration");

            migrationBuilder.DropColumn(
                name: "customerId",
                table: "asset_capital_insurance_registration");

            migrationBuilder.DropColumn(
                name: "deviceId",
                table: "asset_capital_insurance_registration");

            migrationBuilder.DropColumn(
                name: "devicename",
                table: "asset_capital_insurance_registration");

            migrationBuilder.DropColumn(
                name: "password",
                table: "asset_capital_insurance_registration");

            migrationBuilder.DropColumn(
                name: "ProfiledOpened",
                table: "asset_capital_insurance_registration");

            migrationBuilder.DropColumn(
                name: "RequestReference",
                table: "asset_capital_insurance_registration");

            migrationBuilder.DropColumn(
                name: "validbvn",
                table: "asset_capital_insurance_registration");

            migrationBuilder.DropColumn(
                name: "transpin",
                table: "asset_capital_insurance_registration");

            migrationBuilder.DropColumn(
                name: "ucid",
                table: "asset_capital_insurance_otp_session");

            migrationBuilder.DropColumn(
                name: "status",
                table: "asset_capital_insurance_mobile_device");

            migrationBuilder.RenameColumn(
                name: "createdon",
                table: "asset_capital_insurance_mobile_device",
                newName: "created_at");

            migrationBuilder.RenameColumn(
                name: "device",
                table: "asset_capital_insurance_mobile_device",
                newName: "device_id");

            migrationBuilder.AlterColumn<string>(
                name: "user_id",
                table: "asset_capital_insurance_user_session",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(long));

            migrationBuilder.AlterColumn<int>(
                name: "id",
                table: "asset_capital_insurance_user_session",
                type: "int",
                nullable: false,
                oldClrType: typeof(long))
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<int>(
                name: "id",
                table: "asset_capital_insurance_user_credentials",
                type: "int",
                nullable: false,
                oldClrType: typeof(long))
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<int>(
                name: "id",
                table: "asset_capital_insurance_user",
                type: "int",
                nullable: false,
                oldClrType: typeof(long))
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "birth_date",
                table: "asset_capital_insurance_registration",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "id",
                table: "asset_capital_insurance_registration",
                type: "int",
                nullable: false,
                oldClrType: typeof(long))
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<string>(
                name: "user_id",
                table: "asset_capital_insurance_reg_session",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(long));

            migrationBuilder.AlterColumn<string>(
                name: "user_id",
                table: "asset_capital_insurance_mobile_device",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(long));
        }
    }
}
