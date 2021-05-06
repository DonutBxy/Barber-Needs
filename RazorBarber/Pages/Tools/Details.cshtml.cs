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
    public class DetailsModel : PageModel
    {
        private readonly RazorTools.Data.RazorToolContext _context;

        public DetailsModel(RazorTools.Data.RazorToolContext context)
        {
            _context = context;
        }

        public Tool Tool { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Tool = await _context.Tool.FirstOrDefaultAsync(m => m.ID == id);

            if (Tool == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
