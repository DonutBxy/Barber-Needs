using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorTool.Models;
using RazorTools.Data;

namespace RazorBarber.Pages.Tools
{
    public class IndexModel : PageModel
    {
        private readonly RazorTools.Data.RazorToolContext _context;

        public IndexModel(RazorTools.Data.RazorToolContext context)
        {
            _context = context;
        }

        public IList<Tool> Tool { get;set; }

        public async Task OnGetAsync()
        {
            Tool = await _context.Tool.ToListAsync();
        }
    }
}
