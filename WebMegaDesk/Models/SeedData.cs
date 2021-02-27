using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using WebMegaDesk.Data;

namespace WebMegaDesk.Models
{

    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new WebMegaDeskContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<WebMegaDeskContext>>()))
            {
                // Look for any movies.
                if (context.Quote.Any())
                {
                    return;   // DB has been seeded
                }
                
                Random rand = new Random();

                context.Quote.AddRange(

                    new Quote
                    {
                        CustomerFirstName = "Shayne",
                        CustomerLastName = "Pierce",
                        DeskWidth = 46,
                        DeskDepth = 32,
                        DeskDrawerNumber = 4,
                        DesktopMaterial = DesktopMaterials.Rosewood,
                        RushSpeed = 3,
                        QuoteDate = DateTime.Now.AddDays(-rand.Next(1, 100))

                    },

                    new Quote
                    {
                        CustomerFirstName = "Kevin",
                        CustomerLastName = "Neilsen",
                        DeskWidth = 52,
                        DeskDepth = 24,
                        DeskDrawerNumber = 7,
                        DesktopMaterial = DesktopMaterials.Pine,
                        RushSpeed = 0,
                        QuoteDate = DateTime.Now.AddDays(-rand.Next(1, 100))
                    },

                    new Quote
                    {
                        CustomerFirstName = "Kyle",
                        CustomerLastName = "Johnson",
                        DeskWidth = 50,
                        DeskDepth = 30,
                        DeskDrawerNumber = 1,
                        DesktopMaterial = DesktopMaterials.Veneer,
                        RushSpeed = 7,
                        QuoteDate = DateTime.Now.AddDays(-rand.Next(1, 100))
                    },

                    new Quote
                    {
                        CustomerFirstName = "Tommy",
                        CustomerLastName = "Knorr",
                        DeskWidth = 65,
                        DeskDepth = 40,
                        DeskDrawerNumber = 5,
                        DesktopMaterial = DesktopMaterials.Oak,
                        RushSpeed = 3,
                        QuoteDate = DateTime.Now.AddDays(-rand.Next(1, 100))
                    },

                    new Quote
                    {
                        CustomerFirstName = "David",
                        CustomerLastName = "Smith",
                        DeskWidth = rand.Next(Quote.MINWIDTH, Quote.MAXWIDTH + 1),
                        DeskDepth = rand.Next(Quote.MINDEPTH, Quote.MAXDEPTH + 1),
                        DeskDrawerNumber = rand.Next(0, Quote.MAXDRAWERS + 1),
                        DesktopMaterial = DesktopMaterials.Veneer,
                        RushSpeed = 7,
                        QuoteDate = DateTime.Now.AddDays(-rand.Next(1, 100))
                    },

                    new Quote
                    {
                        CustomerFirstName = "Mary",
                        CustomerLastName = "Jones",
                        DeskWidth = rand.Next(Quote.MINWIDTH, Quote.MAXWIDTH + 1),
                        DeskDepth = rand.Next(Quote.MINDEPTH, Quote.MAXDEPTH + 1),
                        DeskDrawerNumber = rand.Next(0, Quote.MAXDRAWERS + 1),
                        DesktopMaterial = DesktopMaterials.Pine,
                        RushSpeed = 7,
                        QuoteDate = DateTime.Now.AddDays(-rand.Next(1, 100))
                    },

                    new Quote
                    {
                        CustomerFirstName = "Susan",
                        CustomerLastName = "White",
                        DeskWidth = rand.Next(Quote.MINWIDTH, Quote.MAXWIDTH + 1),
                        DeskDepth = rand.Next(Quote.MINDEPTH, Quote.MAXDEPTH + 1),
                        DeskDrawerNumber = rand.Next(0, Quote.MAXDRAWERS + 1),
                        DesktopMaterial = DesktopMaterials.Laminate,
                        RushSpeed = 5,
                        QuoteDate = DateTime.Now.AddDays(-rand.Next(1, 100))
                    },

                    new Quote
                    {
                        CustomerFirstName = "Greg",
                        CustomerLastName = "Allen",
                        DeskWidth = rand.Next(Quote.MINWIDTH, Quote.MAXWIDTH + 1),
                        DeskDepth = rand.Next(Quote.MINDEPTH, Quote.MAXDEPTH + 1),
                        DeskDrawerNumber = rand.Next(0, Quote.MAXDRAWERS + 1),
                        DesktopMaterial = DesktopMaterials.Oak,
                        RushSpeed = 3,
                        QuoteDate = DateTime.Now.AddDays(-rand.Next(1, 100))
                    },

                    new Quote
                    {
                        CustomerFirstName = "Samantha",
                        CustomerLastName = "Howard",
                        DeskWidth = rand.Next(Quote.MINWIDTH, Quote.MAXWIDTH + 1),
                        DeskDepth = rand.Next(Quote.MINDEPTH, Quote.MAXDEPTH + 1),
                        DeskDrawerNumber = rand.Next(0, Quote.MAXDRAWERS + 1),
                        DesktopMaterial = DesktopMaterials.Rosewood,
                        RushSpeed = 0,
                        QuoteDate = DateTime.Now.AddDays(-rand.Next(1, 100))
                    },

                    new Quote
                    {
                        CustomerFirstName = "Blake",
                        CustomerLastName = "Nash",
                        DeskWidth = rand.Next(Quote.MINWIDTH, Quote.MAXWIDTH + 1),
                        DeskDepth = rand.Next(Quote.MINDEPTH, Quote.MAXDEPTH + 1),
                        DeskDrawerNumber = rand.Next(0, Quote.MAXDRAWERS + 1),
                        DesktopMaterial = DesktopMaterials.Veneer,
                        RushSpeed = 5,
                        QuoteDate = DateTime.Now.AddDays(-rand.Next(1, 100))
                    },

                    new Quote
                    {
                        CustomerFirstName = "Joel",
                        CustomerLastName = "Jenson",
                        DeskWidth = rand.Next(Quote.MINWIDTH, Quote.MAXWIDTH + 1),
                        DeskDepth = rand.Next(Quote.MINDEPTH, Quote.MAXDEPTH + 1),
                        DeskDrawerNumber = rand.Next(0, Quote.MAXDRAWERS + 1),
                        DesktopMaterial = DesktopMaterials.Laminate,
                        RushSpeed = 7,
                        QuoteDate = DateTime.Now.AddDays(-rand.Next(1, 100))
                    }

                );
                context.SaveChanges();
            }
        }
    }
}
