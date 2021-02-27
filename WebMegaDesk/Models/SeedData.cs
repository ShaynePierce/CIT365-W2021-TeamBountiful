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

                context.Quote.AddRange(

                    new Quote
                    {
                        CustomerFirstName = "Shayne",
                        CustomerLastName = "Pierce",
                        DeskWidth = 46,
                        DeskDepth = 32,
                        DeskDrawerNumber = 4,
                        DesktopMaterial = DesktopMaterials.Rosewood,
                        RushSpeed = 3
                    },

                    new Quote
                    {
                        CustomerFirstName = "Kevin",
                        CustomerLastName = "Neilsen",
                        DeskWidth = 52,
                        DeskDepth = 24,
                        DeskDrawerNumber = 7,
                        DesktopMaterial = DesktopMaterials.Pine,
                        RushSpeed = 0
                    }

                );
                context.SaveChanges();
            }
        }
    }
}
