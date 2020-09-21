using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplicationMBegyn.Migrations
{
    public partial class firstinit6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentID",
                keyValue: 2);

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentID", "Address", "Age", "AverageGrade", "FirstName", "LastName", "NbOfCourses", "PhoneNumber" },
                values: new object[] { 3, "807th Flower Street, 90017 Los Angeles", 21, "B+", "John", "Doe", 8, "332358797744" });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentID", "Address", "Age", "AverageGrade", "FirstName", "LastName", "NbOfCourses", "PhoneNumber" },
                values: new object[] { 4, "1400 Malcolm AVE, 90025 Los Angeles", 24, "B", "Susie", "Dos Santos", 5, "4875329921" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentID",
                keyValue: 4);

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentID", "Address", "Age", "AverageGrade", "FirstName", "LastName", "NbOfCourses", "PhoneNumber" },
                values: new object[] { 1, "807th Flower Street, 90017 Los Angeles", 21, "B+", "John", "Doe", 8, "332358797744" });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentID", "Address", "Age", "AverageGrade", "FirstName", "LastName", "NbOfCourses", "PhoneNumber" },
                values: new object[] { 2, "1400 Malcolm AVE, 90025 Los Angeles", 24, "B", "Susie", "Dos Santos", 5, "4875329921" });
        }
    }
}
