using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationMBegyn.Models;

namespace WebApplicationMBegyn.Data
{
    public static class DbInitializer
    {
        public static void Initialize(WebApplicationMBegynContext context)
        {
            context.Database.EnsureCreated();

            /*// Look for any students.
            if (context.Student.Any())
            {
                return;   // DB has been seeded
            }

            var students = new Student[]
            {
               new Student
                   {
                       StudentID = 1,
                       FirstName = "John",
                       LastName = "Doe",
                       Age = 21,
                       Address = "807th Flower Street, 90017 Los Angeles",
                       PhoneNumber = "332358797744",
                       NbOfCourses = 8,
                       AverageGrade = "B+"
                   },
                    new Student
                    {
                        StudentID = 2,
                        FirstName = "Susie",
                        LastName = "Dos Santos",
                        Age = 24,
                        Address = "1400 Malcolm AVE, 90025 Los Angeles",
                        PhoneNumber = "4875329921",
                        NbOfCourses = 5,
                        AverageGrade = "B"
                    }
            };

            context.Student.AddRange(students);
            context.SaveChanges();*/
        }
    }
}
