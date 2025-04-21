using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityProject.Migrations
{
    public partial class AddPaymentOutsideOfFlutterwave : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "paymentnotificationoutsideofflutterwave",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserType = table.Column<string>(nullable: true),
                    BankName = table.Column<string>(nullable: true),
                    Session = table.Column<string>(nullable: true),
                    PaymentReference = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    Amount = table.Column<decimal>(nullable: false),
                    AccountNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_paymentnotificationoutsideofflutterwave", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "paymentnotificationoutsideofflutterwave");
        }
    }
}
