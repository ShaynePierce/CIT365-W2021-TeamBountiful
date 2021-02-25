using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
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
        
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }


        public async Task OnGetAsync()
        {
/*            var names = from n in _context.Quote
                        select n;
*//*            if (!string.IsNullOrEmpty(SearchString))
            {
                names = names.Where(s => s.CustomerFullName.Contains(SearchString));
            }
*/
                Quote = await _context.Quote.ToListAsync();
        }
    }
}
