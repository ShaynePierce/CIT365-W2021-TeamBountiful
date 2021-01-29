using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MegaDesk_TeamBountiful
{
    public partial class SearchQuotes : Form
    {
        private List<DeskQuote> deskQuotes = new List<DeskQuote>();
        public SearchQuotes()
        {
            InitializeComponent();

            // Populate Combo from Enum list
            foreach (DesktopMaterial surfaceMaterial in Enum.GetValues(typeof(DesktopMaterial)))
                comboBox1.Items.Add(surfaceMaterial);

        }

        private void ButtonMainMenu_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Show();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > -1)
            {
                MainMenu.DataFiler.Search((DesktopMaterial)comboBox1.SelectedItem, ref deskQuotes);
                MessageBox.Show(@"Quotes returned: " + deskQuotes.Count);
            }
        }
    }
}
