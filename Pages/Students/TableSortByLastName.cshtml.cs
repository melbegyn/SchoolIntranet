using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplicationMBegyn.Models;

namespace WebApplicationMBegyn.Pages.Students
{
    public class TableSortByLastNameModel : PageModel
    {
        private readonly WebApplicationMBegyn.Data.WebApplicationMBegynContext _context;

        public TableSortByLastNameModel(WebApplicationMBegyn.Data.WebApplicationMBegynContext context)
        {
            _context = context;
        }

        public IList<Student> Student { get; set; }
        public async Task OnGetAsync(string sortOrder)
        {
            IQueryable<Student> studentsIQ = from s in _context.Student select s;
            studentsIQ = studentsIQ.OrderBy(s => s.LastName);
            Student = await studentsIQ.AsNoTracking().ToListAsync();
        }
    }
}