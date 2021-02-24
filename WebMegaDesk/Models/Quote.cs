using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebMegaDesk.Models
{
    public class Quote
    {
        /* to ADD: DeskArea, SurfaceAreaPrice, TotalDrawerPrice, SurfaceMaterialPrice
         * , RushPrice */


        /* Constants to avoid "Magic Numbers" */
        public const double BASECOST = 200.00;
        public const double MAX_AREA_FREE = 1000;
        public const double EXTRA_AREA_COST = 1.00;
        public const double DRAWER_COST = 50.00;

        public int ID { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        [StringLength(60)]
        [Required]
        public String CustomerFirstName { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        [StringLength(60)]
        [Required]
        public String CustomerLastName { get; set; }

        private String CustomerFullName { get; set; }

        [Range(24, 96)]
        [Required]
        public double DeskWidth { get; set; }

        [Range(12, 48)]
        [Required]
        public double DeskDepth { get; set; }

        private double DeskArea {get; set; }

        private decimal SurfaceAreaPrice { get; set; }

        [Range(0,7)]
        public int DeskDrawerNumber { get; set; }

        private decimal TotalDrawerPrice { get; set; }

        /* NOT SURE ABOUT THIS NEXT PART */
        public int DesktopMaterial { get; set; }

        private decimal SurfaceMaterialPrice { get; set; }

        [RegularExpression(@"[0357]{1}")]
        public int RushSpeed { get; set; }

        private decimal RushPrice { get; set; }

        private decimal QuotedPrice { get; set; }
    }
}
