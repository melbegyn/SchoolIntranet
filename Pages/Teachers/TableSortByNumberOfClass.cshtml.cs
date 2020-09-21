using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplicationMBegyn.Models;

namespace WebApplicationMBegyn.Pages.Teachers
{
    public class TableSortByNumberOfClassModel : PageModel
    {
        private readonly WebApplicationMBegyn.Data.WebApplicationMBegynContext _context;

        public TableSortByNumberOfClassModel(WebApplicationMBegyn.Data.WebApplicationMBegynContext context)
        {
            _context = context;
        }

        public IList<Teacher> Teacher { get; set; }
        public async Task OnGetAsync(string sortOrder)
        {
            IQueryable<Teacher> teachersIQ = from s in _context.Teacher select s;
            teachersIQ = teachersIQ.OrderBy(s => s.NbOfClasses);
            Teacher = await teachersIQ.AsNoTracking().ToListAsync();
        }
    }
}