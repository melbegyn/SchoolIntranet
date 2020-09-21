using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationMBegyn.Models
{
    public class Teacher: Person
    {
        public int TeacherID { get; set; }

        [Display(Name = "NB of classes")]
        public int NbOfClasses { get; set; }

        [Display(Name = "Years of experience")]
        public int NbOfTeachingExperience { get; set; }
    }
}
