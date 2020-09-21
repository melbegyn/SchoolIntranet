using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationMBegyn.Models
{
    public class Student: Person
    {
        public int StudentID { get; set; }

        [Display(Name = "AVG Grade")]
        public string AverageGrade { get; set; }

        [Display(Name = "NB of courses")]
        public int NbOfCourses { get; set; }
    }
}
