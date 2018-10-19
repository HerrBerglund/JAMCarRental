using Microsoft.EntityFrameworkCore.Migrations;

namespace JAMCarRental.Data.Migrations
{
    public partial class addedReturnBool : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsReturned",
                table: "Bookings",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsReturned",
                table: "Bookings");
        }
    }
}
