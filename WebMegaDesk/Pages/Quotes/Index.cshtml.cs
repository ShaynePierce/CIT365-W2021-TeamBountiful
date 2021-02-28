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

        public IList<Quote> Quote { get; set; }
        
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        
        [BindProperty(SupportsGet = true)]
        public string CustomerFirstNameSort { get; set; }
        
        [BindProperty(SupportsGet = true)]
        public string CustomerLastNameSort { get; set; }
        
        [BindProperty(SupportsGet = true)]
        public string MaterialSort { get; set; }
        
        [BindProperty(SupportsGet = true)]
        public string QuoteDateSort { get; set; }
        
        //Sort states desc/asc
        public string FirstNameSortState { get; set; }
        public string LastNameSortState { get; set; }
        public string MaterialSortState { get; set; }
        public string DateSortState { get; set; }

        public async Task OnGetAsync(string sortOrder, string searchString)
        {
            CustomerFirstNameSort = sortOrder == "first_name" ? "first_name_desc" : "first_name";
            CustomerLastNameSort = sortOrder == "last_name" ? "last_name_desc" : "last_name";
            MaterialSort = sortOrder == "material" ? "material_desc" : "material";
            QuoteDateSort = String.IsNullOrEmpty(sortOrder) ? "date" : "";// default desc
            SearchString = searchString;

            IQueryable<Quote> quotes = from s in _context.Quote
                                           select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                quotes = quotes.Where(
                    s => s.CustomerFirstName.Contains(searchString) 
                    || s.CustomerLastName.Contains(searchString)
                    //|| s.DesktopMaterial.Contains(searchString)
                );
            }

            //CustomerFirstName
            //CustomerLastName
            //QuoteDate
            //DesktopMaterial

            switch (sortOrder)
            {
                 case "first_name":
                    quotes = quotes.OrderBy(s => s.CustomerFirstName);
                    FirstNameSortState = "asc";
                    break;
                case "first_name_desc":
                    quotes = quotes.OrderByDescending(s => s.CustomerFirstName);
                    FirstNameSortState = "desc";
                    break;
                
                case "last_name":
                    quotes = quotes.OrderBy(s => s.CustomerLastName);
                    LastNameSortState = "asc";
                    break;
                case "last_name_desc":
                    quotes = quotes.OrderByDescending(s => s.CustomerLastName);
                    LastNameSortState = "desc";
                    break;

                case "material":
                    quotes = quotes.OrderBy(s => s.DesktopMaterial);
                    MaterialSortState = "asc";
                    break;
                case "material_desc":
                    quotes = quotes.OrderByDescending(s => s.DesktopMaterial);
                    MaterialSortState = "desc";
                    break;

                case "date":
                    quotes = quotes.OrderBy(s => s.QuoteDate);
                    DateSortState = "asc";
                    break;
                case "date_desc":
                    quotes = quotes.OrderByDescending(s => s.QuoteDate);
                    DateSortState = "desc";
                    break;
                default:
                    quotes = quotes.OrderByDescending(s => s.QuoteDate);
                    DateSortState = "desc";
                    break;
            }

            Quote = await quotes.AsNoTracking().ToListAsync();
            /*            var names = from n in _context.Quote
                                    select n;
            *//*            if (!string.IsNullOrEmpty(SearchString))
                        {
                            names = names.Where(s => s.CustomerFullName.Contains(SearchString));
                        }
            
            Quote = await _context.Quote.ToListAsync();
            */
        }
    }
}
