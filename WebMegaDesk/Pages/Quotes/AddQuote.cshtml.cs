using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebMegaDesk.Models;

namespace WebMegaDesk.Pages.Quotes
{
    public class CreateModel : PageModel
    {
        private readonly WebMegaDesk.Data.WebMegaDeskContext _context;

        public CreateModel(WebMegaDesk.Data.WebMegaDeskContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Quote Quote { get; set; }

        public string[] MaterialNames = Enum.GetNames(typeof(DesktopMaterials));
        public int[] MaterialValues = (int[])Enum.GetValues(typeof(DesktopMaterials));

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Quote.Add(Quote);
            await _context.SaveChangesAsync();

            return RedirectToPage("./DisplayQuote", new { id = Quote.ID } );
        }
    }
}
