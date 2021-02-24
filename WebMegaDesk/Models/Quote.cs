using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMegaDesk.Models
{
    public class Quote
    {
        /* Constants to avoid "Magic Numbers" */
        public const double BASECOST = 200.00;
        public const double MAX_AREA_FREE = 1000;
        public const double EXTRA_AREA_COST = 1.00;
        public const double DRAWER_COST = 50.00;

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
