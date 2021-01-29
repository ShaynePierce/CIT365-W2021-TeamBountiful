using System;
using System.Windows.Forms;

namespace MegaDesk_TeamBountiful
{
    public partial class ViewAllQuotes : Form
    {
        public ViewAllQuotes()
        {
            InitializeComponent();
        }

        private void ButtonMainMenu_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Show();
            Close();
        }

        /*
         
        To view all.. iterate through Filer.DeskQuotes. Something like:

        foreach (var quote in MainMenu.DataFiler.DeskQuotes)
            {
                Do something with 'quote';            
            }         
         
         */
    }
}
