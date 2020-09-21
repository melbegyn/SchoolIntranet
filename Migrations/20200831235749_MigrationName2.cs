using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplicationMBegyn.Migrations
{
    public partial class MigrationName2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "address",
                table: "Teacher",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "age",
                table: "Teacher",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "firstName",
                table: "Teacher",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "lastName",
                table: "Teacher",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "phoneNumber",
                table: "Teacher",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "address",
                table: "Teacher");

            migrationBuilder.DropColumn(
                name: "age",
                table: "Teacher");

            migrationBuilder.DropColumn(
                name: "firstName",
                table: "Teacher");

            migrationBuilder.DropColumn(
                name: "lastName",
                table: "Teacher");

            migrationBuilder.DropColumn(
                name: "phoneNumber",
                table: "Teacher");
        }
    }
}
