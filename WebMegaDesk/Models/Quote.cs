using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebMegaDesk.Models
{
    public enum DesktopMaterials
    {
        Laminate = 100,
        Oak = 200,
        Rosewood = 300,
        Veneer = 125,
        Pine = 50
    }

    public class Quote
    {
        /* Constants to avoid "Magic Numbers" */
        private const double BASECOST = 200.00;
        private const double MAX_AREA_FREE = 1000;
        private const double MID_AREA = 2000;

        private const double EXTRA_AREA_COST = 1.00;
        private const double DRAWER_COST = 50.00;

        public const int MAXWIDTH = 96;
        public const int MINWIDTH = 24;
        public const int MINDEPTH = 12;
        public const int MAXDEPTH = 48;
        public const int MINDRAWERS = 0;
        public const int MAXDRAWERS = 7;

        public static int SearchEnum(string FindIt)
        {
            foreach (var enumName in Enum.GetNames(typeof(DesktopMaterials)))
                if (enumName.ToLower().Contains(FindIt.ToLower()))
                    return (int)Enum.Parse(typeof(DesktopMaterials), enumName);

            return -1;
        }

        private readonly int[,] RUSHPRICES = new int[3, 3]
        {
                { 60, 70, 80 },
                { 40, 50, 60 },
                { 30, 35, 40 }
        };

        public int ID { get; set; }

        [Display(Name = "First Name"), StringLength(60, MinimumLength = 2), RegularExpression(@"^[A-Z]+[a-zA-Z]*$"), Required]
        public String CustomerFirstName { get; set; }

        [Display(Name = "Last Name"), StringLength(60, MinimumLength = 2), RegularExpression(@"^[A-Z]+[a-zA-Z]*$"), Required]
        public String CustomerLastName { get; set; }

        [Display(Name = "Desk Width"), Range(MINWIDTH, MAXWIDTH), Required]
        public double DeskWidth { get; set; }

        [Display(Name = "Desk Depth"), Range(MINDEPTH, MAXDEPTH), Required]
        public double DeskDepth { get; set; }

        [Display(Name = "# of Drawers"), Range(MINDRAWERS, MAXDRAWERS), Required]
        public int DeskDrawerNumber { get; set; }

        [Display(Name = "Desktop Material"), Required]
        public DesktopMaterials DesktopMaterial { get; set; }

        [Display(Name = "Rush Speed"), RegularExpression(@"[0357]{1}"), Required]
        public int RushSpeed { get; set; }

        [Display(Name = "Quote Date"), DataType(DataType.Date), Required]
        public DateTime QuoteDate { get; set; }


        /*
         * 
         * Real time stuff
         * 
         */

        [Display(Name = "Customer's Name")]
        public string CustomerFullName
        {
            get
            {
                return CustomerFirstName + " " + CustomerLastName;
            }
        }

        [Display(Name = "Base Price"), DisplayFormat(DataFormatString = "{0:N}")]
        public double BasePrice
        {
            get
            {
                return BASECOST;
            }
        }

        [Display(Name = "Area Surcharge"), DisplayFormat(DataFormatString = "{0:N}")]
        public double SurfaceAreaPrice 
        {
            get {
                double temp = Math.Max(DeskArea - MAX_AREA_FREE, 0) * EXTRA_AREA_COST;
                return temp;
            }
        }

        [Display(Name = "Desk Area")]
        public double DeskArea
        {
            get
            {
                return DeskWidth * DeskDepth;
            }
        }

        [Display(Name = "Drawer Charge"), DisplayFormat(DataFormatString = "{0:N}")]
        public double TotalDrawerPrice
        {
            get
            {
                return DeskDrawerNumber * DRAWER_COST;
            }
        }

        [Display(Name = "Material Charge"), DisplayFormat(DataFormatString = "{0:N}")]
        public double SurfaceMaterialPrice 
        { 
            get
            {
                return (int)DesktopMaterial;
            }

        }

        private int RushIndex(int value)
        {
            switch (value)
            {
                case 3: return 0;
                case 5: return 1;
                case 7: return 2;
            }
            return 0; // shouldn't get here
        }

        [Display(Name = "Rush Fee"), DisplayFormat(DataFormatString = "{0:N}")]
        public double RushPrice { 
            get
            {
                int materialIndex = 0; // default to bottom shipping fee
                double total = 0;

                // figure out our range
                if (DeskArea >= MAX_AREA_FREE && DeskArea <= MID_AREA)
                    materialIndex = 1;
                else
                if (DeskArea > MID_AREA)
                    materialIndex = 2;

                // Only calculate if valuue in 3,5,7 range
                if (RushSpeed > 0)
                    total = RUSHPRICES[RushIndex(RushSpeed), materialIndex];

                return total;
            }
        }

        [Display(Name = "Total"), Column(TypeName = "decimal(18, 2)"), DisplayFormat(DataFormatString = "{0:N}")]
        public double QuotedPrice {
            get
            {
                return BasePrice + TotalDrawerPrice + SurfaceAreaPrice + SurfaceMaterialPrice + RushPrice;
            }
        
        }


    }
}
