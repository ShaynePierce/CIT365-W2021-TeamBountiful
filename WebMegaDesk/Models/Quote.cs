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
   
        /* Constants to avoid "Magic Numbers" */
        private const decimal BASECOST = 200.00M;
        private const double MAX_AREA_FREE = 1000;
        private const decimal EXTRA_AREA_COST = 1.00M;
        private const decimal DRAWER_COST = 50.00M;

        public int ID { get; set; }

        
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        [StringLength(60)]
        [Required]
        public String CustomerFirstName { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        [StringLength(60)]
        [Required]
        public String CustomerLastName { get; set; }

        [Display(Name = "Customer's Name")]
        public String CustomerFullName
        {
            set
            {
                this.CustomerFullName = CustomerFirstName
                    + " " + CustomerLastName;
            }

            get
            {
                return this.CustomerFullName;
            }
        }

        [Display(Name = "Desk Width")]
        [Range(24, 96)]
        [Required]
        public double DeskWidth { get; set; }

        [Display(Name = "Desk Depth")]
        [Range(12, 48)]
        [Required]
        public double DeskDepth { get; set; }

        private double DeskArea 
        {
            get
            {
                return this.DeskArea;
            }
            
            set
            {
                this.DeskArea = DeskDepth * DeskWidth;
            }
        }

        private decimal SurfaceAreaPrice { get; set; }
        
        [Display(Name = "# of Drawers")]
        [Range(0,7)]
        public int DeskDrawerNumber { get; set; }

        private decimal TotalDrawerPrice 
        {
            set
            {
                decimal deskDrawerNumber = (decimal)DeskDrawerNumber;
                this.TotalDrawerPrice = deskDrawerNumber * DRAWER_COST;
            }

            get
            {
                return TotalDrawerPrice;
            }
        }

        /* NOT SURE ABOUT THIS NEXT PART */
        [Display(Name = "Desktop Material")]
        public int DesktopMaterial { get; set; }

        private decimal SurfaceMaterialPrice { get; set; }

        [Display(Name = "Rush Speed")]
        [RegularExpression(@"[0357]{1}")]
        public int RushSpeed { get; set; }


        private decimal RushPrice { get; set; }

        [Display(Name = "Total Price")]
        [Column(TypeName = "decimal(18, 2)")]
        private decimal QuotedPrice { get; set; }
    }
}
