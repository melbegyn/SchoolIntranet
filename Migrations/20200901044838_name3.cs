using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplicationMBegyn.Migrations
{
    public partial class name3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "phoneNumber",
                table: "Teacher",
                newName: "PhoneNumber");

            migrationBuilder.RenameColumn(
                name: "nbOfTeachingExperience",
                table: "Teacher",
                newName: "NbOfTeachingExperience");

            migrationBuilder.RenameColumn(
                name: "nbOfClasses",
                table: "Teacher",
                newName: "NbOfClasses");

            migrationBuilder.RenameColumn(
                name: "lastName",
                table: "Teacher",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "firstName",
                table: "Teacher",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "age",
                table: "Teacher",
                newName: "Age");

            migrationBuilder.RenameColumn(
                name: "address",
                table: "Teacher",
                newName: "Address");

            migrationBuilder.RenameColumn(
                name: "teacherID",
                table: "Teacher",
                newName: "TeacherID");

            migrationBuilder.RenameColumn(
                name: "phoneNumber",
                table: "Student",
                newName: "PhoneNumber");

            migrationBuilder.RenameColumn(
                name: "nbOfCourses",
                table: "Student",
                newName: "NbOfCourses");

            migrationBuilder.RenameColumn(
                name: "lastName",
                table: "Student",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "firstName",
                table: "Student",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "averageGrade",
                table: "Student",
                newName: "AverageGrade");

            migrationBuilder.RenameColumn(
                name: "age",
                table: "Student",
                newName: "Age");

            migrationBuilder.RenameColumn(
                name: "address",
                table: "Student",
                newName: "Address");

            migrationBuilder.RenameColumn(
                name: "studentID",
                table: "Student",
                newName: "StudentID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "Teacher",
                newName: "phoneNumber");

            migrationBuilder.RenameColumn(
                name: "NbOfTeachingExperience",
                table: "Teacher",
                newName: "nbOfTeachingExperience");

            migrationBuilder.RenameColumn(
                name: "NbOfClasses",
                table: "Teacher",
                newName: "nbOfClasses");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Teacher",
                newName: "lastName");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Teacher",
                newName: "firstName");

            migrationBuilder.RenameColumn(
                name: "Age",
                table: "Teacher",
                newName: "age");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Teacher",
                newName: "address");

            migrationBuilder.RenameColumn(
                name: "TeacherID",
                table: "Teacher",
                newName: "teacherID");

            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "Student",
                newName: "phoneNumber");

            migrationBuilder.RenameColumn(
                name: "NbOfCourses",
                table: "Student",
                newName: "nbOfCourses");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Student",
                newName: "lastName");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Student",
                newName: "firstName");

            migrationBuilder.RenameColumn(
                name: "AverageGrade",
                table: "Student",
                newName: "averageGrade");

            migrationBuilder.RenameColumn(
                name: "Age",
                table: "Student",
                newName: "age");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Student",
                newName: "address");

            migrationBuilder.RenameColumn(
                name: "StudentID",
                table: "Student",
                newName: "studentID");
        }
    }
}
