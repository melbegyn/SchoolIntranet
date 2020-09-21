using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplicationMBegyn.Models;

namespace WebApplicationMBegyn.Data
{
    public class WebApplicationMBegynContext : DbContext
    {
        public WebApplicationMBegynContext (DbContextOptions<WebApplicationMBegynContext> options)
            : base(options)
        {
        }

        public DbSet<WebApplicationMBegyn.Models.Student> Student { get; set; }

        public DbSet<WebApplicationMBegyn.Models.Teacher> Teacher { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Student>().HasData(
                 new Student
                 {
                     StudentID = 1,
                     FirstName = "John",
                     LastName = "Doe",
                     Age = 21,
                     Address = "807th Flower Street, 90017 Los Angeles",
                     PhoneNumber = "332-358-7744",
                     NbOfCourses = 8,
                     AverageGrade = "B"
                 },
                 new Student
                 {
                     StudentID = 2,
                     FirstName = "Susie",
                     LastName = "Dos Santos",
                     Age = 24,
                     Address = "1400 Malcolm AVE, 90025 Los Angeles",
                     PhoneNumber = "487-532-9921",
                     NbOfCourses = 5,
                     AverageGrade = "B"
                 },
                new Student
                {
                    StudentID = 3,
                    FirstName = "Yacine",
                    LastName = "Rhazadi",
                    Age = 27,
                    Address = "15 E Figuoera Str, 90014 Los Angeles",
                    PhoneNumber = "332-846-9922",
                    NbOfCourses = 6,
                    AverageGrade = "A"
                },
                new Student
                {
                    StudentID = 4,
                    FirstName = "Samantha",
                    LastName = "Lima",
                    Age = 22,
                    Address = "1502 Malcolm AVE, 90025 Los Angeles",
                    PhoneNumber = "415-352-9553",
                    NbOfCourses = 8,
                    AverageGrade = "C"
                },
                new Student
                {
                    StudentID = 5,
                    FirstName = "Tyron",
                    LastName = "Hank",
                    Age = 19,
                    Address = "1700 Hollywood Hills, 90013 Los Angeles",
                    PhoneNumber = "584-522-9861",
                    NbOfCourses = 4,
                    AverageGrade = "B"
                }
            );

            modelBuilder.Entity<Teacher>().HasData(
                new Teacher
                {
                    TeacherID = 1,
                    FirstName = "Brendon",
                    LastName = "Waner",
                    Age = 43,
                    Address = "1250 W 50th Street, 90014 Los Angeles",
                    PhoneNumber = "632-587-4488",
                    NbOfClasses = 5,
                    NbOfTeachingExperience = 8
                },
                new Teacher
                {
                    TeacherID = 2,
                    FirstName = "Carlos",
                    LastName = "Warrell",
                    Age = 36,
                    Address = "80 Wildshire Blvd, 90020 Los Angeles",
                    PhoneNumber = "365-998-7410",
                    NbOfClasses = 3,
                    NbOfTeachingExperience = 12
                },
                new Teacher
                {
                    TeacherID = 3,
                    FirstName = "Laura",
                    LastName = "Perez",
                    Age = 33,
                    Address = "3600 W 74 Str, 90014 Los Angeles",
                    PhoneNumber = "639-845-2213",
                    NbOfClasses = 4,
                    NbOfTeachingExperience = 5
                },
                new Teacher
                {
                    TeacherID = 4,
                    FirstName = "Juan",
                    LastName = "Harrisson",
                    Age = 52,
                    Address = "6 Pico W Blvd, 90030 Los Angeles",
                    PhoneNumber = "320-998-7455",
                    NbOfClasses = 5,
                    NbOfTeachingExperience = 18
                },
                new Teacher
                {
                    TeacherID = 5,
                    FirstName = "Philip",
                    LastName = "Collins",
                    Age = 48,
                    Address = "800 W Flower Str, 90017 Los Angeles",
                    PhoneNumber = "323-910-7732",
                    NbOfClasses = 6,
                    NbOfTeachingExperience = 10
                }
            );
        }
    }
}
