﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplicationMBegyn.Data;

namespace WebApplicationMBegyn.Migrations
{
    [DbContext(typeof(WebApplicationMBegynContext))]
    partial class WebApplicationMBegynContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplicationMBegyn.Models.Student", b =>
                {
                    b.Property<int>("StudentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("AverageGrade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NbOfCourses")
                        .HasColumnType("int");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentID");

                    b.ToTable("Student");

                    b.HasData(
                        new
                        {
                            StudentID = 1,
                            Address = "807th Flower Street, 90017 Los Angeles",
                            Age = 21,
                            AverageGrade = "B",
                            FirstName = "John",
                            LastName = "Doe",
                            NbOfCourses = 8,
                            PhoneNumber = "332-358-7744"
                        },
                        new
                        {
                            StudentID = 2,
                            Address = "1400 Malcolm AVE, 90025 Los Angeles",
                            Age = 24,
                            AverageGrade = "B",
                            FirstName = "Susie",
                            LastName = "Dos Santos",
                            NbOfCourses = 5,
                            PhoneNumber = "487-532-9921"
                        },
                        new
                        {
                            StudentID = 3,
                            Address = "15 E Figuoera Str, 90014 Los Angeles",
                            Age = 27,
                            AverageGrade = "A",
                            FirstName = "Yacine",
                            LastName = "Rhazadi",
                            NbOfCourses = 6,
                            PhoneNumber = "332-846-9922"
                        },
                        new
                        {
                            StudentID = 4,
                            Address = "1502 Malcolm AVE, 90025 Los Angeles",
                            Age = 22,
                            AverageGrade = "C",
                            FirstName = "Samantha",
                            LastName = "Lima",
                            NbOfCourses = 8,
                            PhoneNumber = "415-352-9553"
                        },
                        new
                        {
                            StudentID = 5,
                            Address = "1700 Hollywood Hills, 90013 Los Angeles",
                            Age = 19,
                            AverageGrade = "B",
                            FirstName = "Tyron",
                            LastName = "Hank",
                            NbOfCourses = 4,
                            PhoneNumber = "584-522-9861"
                        });
                });

            modelBuilder.Entity("WebApplicationMBegyn.Models.Teacher", b =>
                {
                    b.Property<int>("TeacherID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NbOfClasses")
                        .HasColumnType("int");

                    b.Property<int>("NbOfTeachingExperience")
                        .HasColumnType("int");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TeacherID");

                    b.ToTable("Teacher");

                    b.HasData(
                        new
                        {
                            TeacherID = 1,
                            Address = "1250 W 50th Street, 90014 Los Angeles",
                            Age = 43,
                            FirstName = "Brendon",
                            LastName = "Waner",
                            NbOfClasses = 5,
                            NbOfTeachingExperience = 8,
                            PhoneNumber = "632-587-4488"
                        },
                        new
                        {
                            TeacherID = 2,
                            Address = "80 Wildshire Blvd, 90020 Los Angeles",
                            Age = 36,
                            FirstName = "Carlos",
                            LastName = "Warrell",
                            NbOfClasses = 3,
                            NbOfTeachingExperience = 12,
                            PhoneNumber = "365-998-7410"
                        },
                        new
                        {
                            TeacherID = 3,
                            Address = "3600 W 74 Str, 90014 Los Angeles",
                            Age = 33,
                            FirstName = "Laura",
                            LastName = "Perez",
                            NbOfClasses = 4,
                            NbOfTeachingExperience = 5,
                            PhoneNumber = "639-845-2213"
                        },
                        new
                        {
                            TeacherID = 4,
                            Address = "6 Pico W Blvd, 90030 Los Angeles",
                            Age = 52,
                            FirstName = "Juan",
                            LastName = "Harrisson",
                            NbOfClasses = 5,
                            NbOfTeachingExperience = 18,
                            PhoneNumber = "320-998-7455"
                        },
                        new
                        {
                            TeacherID = 5,
                            Address = "800 W Flower Str, 90017 Los Angeles",
                            Age = 48,
                            FirstName = "Philip",
                            LastName = "Collins",
                            NbOfClasses = 6,
                            NbOfTeachingExperience = 10,
                            PhoneNumber = "323-910-7732"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
