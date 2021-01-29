using System;

namespace MegaDesk_TeamBountiful
{
    public class DeskQuote
    {
        public const double BASECOST = 200.00;
        public const double MAX_AREA_FREE = 1000;
        public const double EXTRA_AREA_COST = 1.00;
        public const double DRAWER_COST = 50.00;

        public const double RUSH_3_SMALL = 60.00;
        public const double RUSH_3_MED = 70.00;
        public const double RUSH_3_LARGE = 80.00;

        public const double RUSH_5_SMALL = 40.00;
        public const double RUSH_5_MED = 50.00;
        public const double RUSH_5_LARGE = 60.00;

        public const double RUSH_7_SMALL = 30.00;
        public const double RUSH_7_MED = 35.00;
        public const double RUSH_7_LARGE = 40.00;

        public Desk TheDesk { get; set; }

        private string _rushOrder;
        public string RushOrder
        {
            get => _rushOrder;
            set
            {
                _rushOrder = value;
                if (TheDesk.Area < 1000)
                {
                    switch (_rushOrder)
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
                    switch (_rushOrder)
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
                    switch (_rushOrder)
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

        public string CustomerName { get; set; }

        public DateTime QuoteDate { get; set; }

        public DeskQuote(Desk theDesk, string rushOrder, string customerName, DateTime quoteDate)
        {
            TheDesk = theDesk ?? throw new ArgumentNullException(nameof(theDesk));
            RushOrder = rushOrder ?? throw new ArgumentNullException(nameof(rushOrder));
            CustomerName = customerName ?? throw new ArgumentNullException(nameof(customerName));
            QuoteDate = quoteDate;

            BasePrice = BASECOST;
            SurfaceAreaPrice = Math.Max(TheDesk.Area - MAX_AREA_FREE, 0) * EXTRA_AREA_COST;
            DrawersPrice = TheDesk.Drawers * DRAWER_COST;
            SurfaceMaterialPrice = (int) TheDesk.SurfaceMaterial; // CAST to get dollar value
            TotalPrice = GetTotalPrice();
        }

        public double BasePrice { get; set; }

        public double SurfaceAreaPrice { get; set; }

        public double DrawersPrice { get; set; }

        public double SurfaceMaterialPrice { get; set; }

        public double RushPrice { get; set; }

        public double TotalPrice { get; set; }

        private double GetTotalPrice()
        {
            return BasePrice + DrawersPrice + SurfaceAreaPrice + SurfaceMaterialPrice + RushPrice;
        }

    }
}
