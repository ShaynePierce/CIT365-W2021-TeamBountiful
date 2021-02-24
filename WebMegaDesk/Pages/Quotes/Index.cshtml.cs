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
    public class IndexModel : PageModel
    {
        private readonly WebMegaDesk.Data.WebMegaDeskContext _context;

        public IndexModel(WebMegaDesk.Data.WebMegaDeskContext context)
        {
            _context = context;
        }

        public IList<Quote> Quote { get;set; }

        public async Task OnGetAsync()
        {
            Quote = await _context.Quote.ToListAsync();
        }
    }
}
