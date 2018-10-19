using Microsoft.EntityFrameworkCore.Migrations;

namespace JAMCarRental.Data.Migrations
{
    public partial class addedIsterunerd2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsReturned",
                table: "Bookings");

            migrationBuilder.AddColumn<bool>(
                name: "IsReturned",
                table: "Cars",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsReturned",
                table: "Cars");

            migrationBuilder.AddColumn<bool>(
                name: "IsReturned",
                table: "Bookings",
                nullable: false,
                defaultValue: false);
        }
    }
}
