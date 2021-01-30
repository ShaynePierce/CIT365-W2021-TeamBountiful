using System;
using System.Windows.Forms;

namespace MegaDesk_TeamBountiful
{
    public class DeskQuote
    {
        public const double BASECOST = 200.00;
        public const double MAX_AREA_FREE = 1000;
        public const double EXTRA_AREA_COST = 1.00;
        public const double DRAWER_COST = 50.00;

        public Desk TheDesk { get; set; }

        private string _rushOrder;
        public string RushOrder
        {
            get => _rushOrder;
            set
            {
                _rushOrder = value;
                int sizeIndex;
                if (TheDesk.Area < 1000)
                {
                    sizeIndex = 0; //small
                } else if (TheDesk.Area < 2000)
                {
                    sizeIndex = 1; //medium
                } else
                {
                    sizeIndex = 2; //large
                }

                switch (_rushOrder)
                {
                    case "7 Days":
                        RushPrice = DeskQuote.RushPrices[2, sizeIndex];
                        break;
                    case "5 Days":
                        RushPrice = DeskQuote.RushPrices[1, sizeIndex];
                        break;
                    case "3 Days":
                        RushPrice = DeskQuote.RushPrices[0, sizeIndex];
                        break;
                    default:
                        RushPrice = 0;
                        break;
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

        public static readonly double[,] RushPrices = new double[3,3];

        private double GetTotalPrice()
        {
            return BasePrice + DrawersPrice + SurfaceAreaPrice + SurfaceMaterialPrice + RushPrice;
        }

        static DeskQuote()
        {
            GetRushOrder();
        }

        static void GetRushOrder()
        {
            string[] prices = { "" };
            try
            {
                prices = System.IO.File.ReadAllLines(@"rushOrderPrices.txt");
            }
            catch (Exception)
            {
                MessageBox.Show("Could not load Rush Prices. Please check files and restart program.");
            }
            
            if (prices.Length == 9) //if fails the prices will all be 0
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        RushPrices[i,j] = double.Parse(prices[i * 3 + j]);
                    }
                }
            }
        }

    }
}
