using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_TeamBountiful
{
    public partial class DisplayQuote : Form
    {
        private DeskQuote myDeskQuote;
        public DeskQuote MyDeskQuote { get => myDeskQuote; set => myDeskQuote = value; }

        public DisplayQuote()
        {
            InitializeComponent();
        }

        private void ButtonMainMenu_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Show();
            Close();
        }

        private void DisplayQuote_Load(object sender, EventArgs e)
        {
            try
            { 
                LabelWidth.Text = MyDeskQuote.TheDesk.Width.ToString();
                LabelDepth.Text = MyDeskQuote.TheDesk.Depth.ToString();
                LabelArea.Text = MyDeskQuote.TheDesk.Area.ToString();
                LabelDrawers.Text = MyDeskQuote.TheDesk.Drawers.ToString();
                LabelSurface.Text = MyDeskQuote.TheDesk.SurfaceMaterial.ToString();
                LabelRush.Text = MyDeskQuote.RushOrder;
                LabelOrderDate.Text = MyDeskQuote.QuoteDate.ToString("d");
                LabelCustomerName.Text = MyDeskQuote.CustomerName;
                LabelBaseCost.Text = MyDeskQuote.BasePrice.ToString("C", CultureInfo.CurrentCulture);
                LabelAreaSircharge.Text = MyDeskQuote.SurfaceAreaPrice.ToString("C", CultureInfo.CurrentCulture);
                LabelDrawersCharge.Text = MyDeskQuote.DrawersPrice.ToString("C", CultureInfo.CurrentCulture);
                LabelMaterialCharge.Text = MyDeskQuote.SurfaceMaterialPrice.ToString("C", CultureInfo.CurrentCulture);
                LabelRushFee.Text = MyDeskQuote.RushPrice.ToString("C", CultureInfo.CurrentCulture);
                LabelTotalPrice.Text = MyDeskQuote.TotalPrice.ToString("C", CultureInfo.CurrentCulture); ;
            }
            catch (Exception)
            {
                MessageBox.Show("Error loading DESK information");
            }
        }

    }
}
