using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebMegaDesk.Data;
using WebMegaDesk.Models;

namespace WebMegaDesk.Pages.Quotes
{
    public class DetailsModel : PageModel
    {
        private readonly WebMegaDesk.Data.WebMegaDeskContext _context;

        public DetailsModel(WebMegaDesk.Data.WebMegaDeskContext context)
        {
            _context = context;
        }

        public Quote Quote { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Quote = await _context.Quote.FirstOrDefaultAsync(m => m.ID == id);

            if (Quote == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
