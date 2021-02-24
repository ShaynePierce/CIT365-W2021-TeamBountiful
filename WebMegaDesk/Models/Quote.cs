using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMegaDesk.Models
{
    public class Quote
    {


        public int ID { get; set; }

        public String CustomerFirstName { get; set; }

        public String CustomerLastName { get; set; }

        private String CustomerFullName { get; set; }

        public double DeskWidth { get; set; }

        public double DeskDepth { get; set; }

        public int DeskDrawerNumber { get; set; }

        /* NOT SURE ABOUT THIS NEXT PART */
        public int DesktopMaterial { get; set; }

        public int RushSpeed { get; set; }

        private decimal QuotedPrice { get; set; }
    }
}
