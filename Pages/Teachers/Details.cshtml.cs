using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplicationMBegyn.Data;
using WebApplicationMBegyn.Models;

namespace WebApplicationMBegyn.Pages.Teachers
{
    public class DetailsModel : PageModel
    {
        private readonly WebApplicationMBegyn.Data.WebApplicationMBegynContext _context;

        public DetailsModel(WebApplicationMBegyn.Data.WebApplicationMBegynContext context)
        {
            _context = context;
        }

        public Teacher Teacher { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Teacher = await _context.Teacher.FirstOrDefaultAsync(m => m.TeacherID == id);

            if (Teacher == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
