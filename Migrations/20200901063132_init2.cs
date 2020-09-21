using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplicationMBegyn.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "StudentID",
                keyValue: 1,
                columns: new[] { "AverageGrade", "PhoneNumber" },
                values: new object[] { "B", "332-358-7744" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "StudentID",
                keyValue: 2,
                column: "PhoneNumber",
                value: "487-532-9921");

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentID", "Address", "Age", "AverageGrade", "FirstName", "LastName", "NbOfCourses", "PhoneNumber" },
                values: new object[,]
                {
                    { 3, "15 E Figuoera Str, 90014 Los Angeles", 27, "A", "Yacine", "Rhazadi", 6, "332-846-9922" },
                    { 4, "1502 Malcolm AVE, 90025 Los Angeles", 22, "C", "Samantha", "Lima", 8, "415-352-9553" },
                    { 5, "1700 Hollywood Hills, 90013 Los Angeles", 19, "B", "Tyron", "Hank", 4, "584-522-9861" }
                });

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "TeacherID",
                keyValue: 1,
                column: "PhoneNumber",
                value: "632-587-4488");

            migrationBuilder.InsertData(
                table: "Teacher",
                columns: new[] { "TeacherID", "Address", "Age", "FirstName", "LastName", "NbOfClasses", "NbOfTeachingExperience", "PhoneNumber" },
                values: new object[,]
                {
                    { 2, "80 Wildshire Blvd, 90020 Los Angeles", 36, "Carlos", "Warrell", 3, 12, "365-998-7410" },
                    { 3, "3600 W 74 Str, 90014 Los Angeles", 33, "Laura", "Perez", 4, 5, "639-845-2213" },
                    { 4, "6 Pico W Blvd, 90030 Los Angeles", 52, "Juan", "Harrisson", 5, 18, "320-998-7455" },
                    { 5, "800 W Flower Str, 90017 Los Angeles", 48, "Philip", "Collins", 6, 10, "323-910-7732" }
                });
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

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Teacher",
                keyColumn: "TeacherID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Teacher",
                keyColumn: "TeacherID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Teacher",
                keyColumn: "TeacherID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Teacher",
                keyColumn: "TeacherID",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "StudentID",
                keyValue: 1,
                columns: new[] { "AverageGrade", "PhoneNumber" },
                values: new object[] { "B+", "332358797744" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "StudentID",
                keyValue: 2,
                column: "PhoneNumber",
                value: "4875329921");

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "TeacherID",
                keyValue: 1,
                column: "PhoneNumber",
                value: "6325874488");
        }
    }
}
