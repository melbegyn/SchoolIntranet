﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplicationMBegyn.Models;

namespace WebApplicationMBegyn.Pages.Teachers
{
    public class CRUDModel : PageModel
    {
        private readonly WebApplicationMBegyn.Data.WebApplicationMBegynContext _context;

        public CRUDModel(WebApplicationMBegyn.Data.WebApplicationMBegynContext context)
        {
            _context = context;
        }

        public IList<Teacher> Teacher { get; set; }

        public async Task OnGetAsync()
        {
            Teacher = await _context.Teacher.ToListAsync();
        }
    }
}