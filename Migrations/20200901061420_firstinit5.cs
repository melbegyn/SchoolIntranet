using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplicationMBegyn.Migrations
{
    public partial class firstinit5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentID", "Address", "Age", "AverageGrade", "FirstName", "LastName", "NbOfCourses", "PhoneNumber" },
                values: new object[] { 1, "807th Flower Street, 90017 Los Angeles", 21, "B+", "John", "Doe", 8, "332358797744" });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentID", "Address", "Age", "AverageGrade", "FirstName", "LastName", "NbOfCourses", "PhoneNumber" },
                values: new object[] { 2, "1400 Malcolm AVE, 90025 Los Angeles", 24, "B", "Susie", "Dos Santos", 5, "4875329921" });

            migrationBuilder.InsertData(
                table: "Teacher",
                columns: new[] { "TeacherID", "Address", "Age", "FirstName", "LastName", "NbOfClasses", "NbOfTeachingExperience", "PhoneNumber" },
                values: new object[] { 1, "1250 W 50th Street, 90014 Los Angeles", 43, "Brendon", "Waner", 5, 8, "6325874488" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Teacher",
                keyColumn: "TeacherID",
                keyValue: 1);
        }
    }
}
