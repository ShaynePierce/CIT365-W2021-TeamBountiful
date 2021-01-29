using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_TeamBountiful
{
    public class DeskQuote
    {
        public const double BASECOST = 200.00;
        public const double MAX_AREA_FREE = 1000;
        public const double EXTRA_AREA_COST = 1.00;
        public const double DRAWER_COST = 50.00;

        public const double SURFACE_OAK = 200.00;
        public const double SURFACE_LAMINATE = 100.00;
        public const double SURFACE_PINE = 50.00;
        public const double SURFACE_ROSEWOOD = 300.00;
        public const double SURFACE_VENEER = 125.00;

        public const double RUSH_3_SMALL = 60.00;
        public const double RUSH_3_MED = 70.00;
        public const double RUSH_3_LARGE = 80.00;

        public const double RUSH_5_SMALL = 40.00;
        public const double RUSH_5_MED = 50.00;
        public const double RUSH_5_LARGE = 60.00;

        public const double RUSH_7_SMALL = 30.00;
        public const double RUSH_7_MED = 35.00;
        public const double RUSH_7_LARGE = 40.00;

        private Desk theDesk;
        public Desk TheDesk
        {
            get { return theDesk; }
            set { theDesk = value; }
        }

        private string rushOrder;
        public string RushOrder
        {
            get { return rushOrder; }
            set
            {
                rushOrder = value;
                if (TheDesk.Area < 1000)
                {
                    switch (rushOrder)
                    {
                        case "7 Days":
                            RushPrice = RUSH_7_SMALL;
                            break;
                        case "5 Days":
                            RushPrice = RUSH_5_SMALL;
                            break;
                        case "3 Days":
                            RushPrice = RUSH_3_SMALL;
                            break;
                        default:
                            RushPrice = 0;
                            break;
                    }
                }
                else if (TheDesk.Area > 2000)
                {
                    switch (rushOrder)
                    {
                        case "7 Days":
                            RushPrice = RUSH_7_LARGE;
                            break;
                        case "5 Days":
                            RushPrice = RUSH_5_LARGE;
                            break;
                        case "3 Days":
                            RushPrice = RUSH_3_LARGE;
                            break;
                        default:
                            RushPrice = 0;
                            break;
                    }
                }
                else
                {
                    switch (rushOrder)
                    {
                        case "7 Days":
                            RushPrice = RUSH_7_MED;
                            break;
                        case "5 Days":
                            RushPrice = RUSH_5_MED;
                            break;
                        case "3 Days":
                            RushPrice = RUSH_3_MED;
                            break;
                        default:
                            RushPrice = 0;
                            break;
                    }
                }
            }
        }

        private string customerName;
        public string CustomerName { get => customerName; set => customerName = value; }

        private DateTime quoteDate;
        public DateTime QuoteDate { get => quoteDate; set => quoteDate = value; }

        public DeskQuote(Desk theDesk, string rushOrder, string customerName, DateTime quoteDate)
        {
            TheDesk = theDesk ?? throw new ArgumentNullException(nameof(theDesk));
            RushOrder = rushOrder ?? throw new ArgumentNullException(nameof(rushOrder));
            CustomerName = customerName ?? throw new ArgumentNullException(nameof(customerName));
            QuoteDate = quoteDate;

            BasePrice = BASECOST;
            SurfaceAreaPrice = Math.Max(TheDesk.Area - MAX_AREA_FREE, 0) * EXTRA_AREA_COST;
            DrawersPrice = TheDesk.Drawers * DRAWER_COST;
            SurfaceMaterialPrice = GetSurfaceMaterialPrice();
            TotalPrice = GetTotalPrice();
        }

        private double basePrice;
        public double BasePrice { get => basePrice; set => basePrice = value; }

        private double surfaceAreaPrice;
        public double SurfaceAreaPrice { get => surfaceAreaPrice; set => surfaceAreaPrice = value; }

        private double drawersPrice;
        public double DrawersPrice { get => drawersPrice; set => drawersPrice = value; }

        private double surfaceMaterialPrice;
        public double SurfaceMaterialPrice { get => surfaceMaterialPrice; set => surfaceMaterialPrice = value; }

        private double rushPrice;
        public double RushPrice { get => rushPrice; set => rushPrice = value; }

        private double totalPrice;
        public double TotalPrice { get => totalPrice; set => totalPrice = value; }

        private double GetTotalPrice()
        {
            return BasePrice + DrawersPrice + SurfaceAreaPrice + SurfaceMaterialPrice + RushPrice;
        }


        private double GetSurfaceMaterialPrice()
        {
            switch (TheDesk.SurfaceMaterial)
            {
                case "Laminate":
                    return SURFACE_LAMINATE;
                case "Oak":
                    return SURFACE_OAK;
                case "Rosewood":
                    return SURFACE_ROSEWOOD;
                case "Veneer":
                    return SURFACE_VENEER;
                case "Pine":
                    return SURFACE_PINE;
                default:
                    return 0;
            }
        }
    }
}
