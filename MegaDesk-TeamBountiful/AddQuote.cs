using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_TeamBountiful
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
            ComboBoxDesktopMaterial.Items.AddRange(Enum.GetNames(typeof(DesktopMaterial)));
            ComboBoxRushOrder.Items.Add("Normal (14 Days)");
            ComboBoxRushOrder.Items.Add("7 Days");
            ComboBoxRushOrder.Items.Add("5 Days");
            ComboBoxRushOrder.Items.Add("3 Days");
        }

        private void TextBoxDeskWidth_Validating(object sender, CancelEventArgs e)
        {
            int TempWidth = 0;
            bool IntValue = int.TryParse(TextBoxDeskWidth.Text, out TempWidth);
            if ((TextBoxDeskWidth.Text == string.Empty) || !IntValue || (TempWidth < Desk.MINWIDTH) || (TempWidth > Desk.MAXWIDTH))
            {
                e.Cancel = true;
                ErrorProvider1.SetError(TextBoxDeskWidth, "Please enter width between " + Desk.MINWIDTH.ToString() + " and " + Desk.MAXWIDTH.ToString() + " inches.");
            }
            else
            {
                ErrorProvider1.SetError(TextBoxDeskWidth, "");
            }
        }

        private void TextBoxDeskDepth_KeyPress(object sender, KeyPressEventArgs e)
        {
            ErrorProvider1.SetError(TextBoxDeskDepth, "");
            if (!Char.IsControl(e.KeyChar))
            {
                if (!Char.IsDigit(e.KeyChar))
                {
                    ErrorProvider1.SetError(TextBoxDeskDepth, "Please enter depth between " + Desk.MINDEPTH.ToString() + " and " + Desk.MAXDEPTH.ToString() + " inches.");
                }
            } 
            else 
            {
                int TempDepth = 0;
                bool IntValue = int.TryParse(TextBoxDeskDepth.Text, out TempDepth);
                if ((TextBoxDeskDepth.Text == string.Empty) || !IntValue || (TempDepth < Desk.MINDEPTH) || (TempDepth > Desk.MAXDEPTH))
                {
                    ErrorProvider1.SetError(TextBoxDeskDepth, "Please enter depth between " + Desk.MINDEPTH.ToString() + " and " + Desk.MAXDEPTH.ToString() + " inches.");
                }
            }
        }

        private void TextBoxNumberOfDrawers_Validating(object sender, CancelEventArgs e)
        {
            int TempWidth = 0;
            bool IntValue = int.TryParse(TextBoxNumberOfDrawers.Text, out TempWidth);
            if ((TextBoxNumberOfDrawers.Text == string.Empty) || !IntValue || (TempWidth < Desk.MINDRAWERS) || (TempWidth > Desk.MAXDRAWERS))
            {
                e.Cancel = true;
                ErrorProvider1.SetError(TextBoxNumberOfDrawers, "Please enter number of drawers between " + Desk.MINDRAWERS.ToString() + " and " + Desk.MAXDRAWERS.ToString() + ".");
            }
            else
            {
                ErrorProvider1.SetError(TextBoxNumberOfDrawers, "");
            }
        }

        private void AddQuote_Load(object sender, EventArgs e)
        {

        }

        private void ButtonMainMenu_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Show();
            Close();
        }

        private void ButtonDisplayQuote_Click(object sender, EventArgs e)
        {
            
            if (ValidateChildren(ValidationConstraints.None)) {
                try
                {
                    DisplayQuote displayQuote = new DisplayQuote();
                    Desk myDesk = new Desk(int.Parse(TextBoxDeskWidth.Text), int.Parse(TextBoxDeskDepth.Text), int.Parse(TextBoxNumberOfDrawers.Text), ComboBoxDesktopMaterial.Text);
                    DeskQuote myQuote = new DeskQuote(myDesk, ComboBoxRushOrder.Text, TextBoxCustomerName.Text, DateTimePickerOrderDate.Value);
                    displayQuote.MyDeskQuote = myQuote;
                    displayQuote.Show();
                    Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error creating DisplayQuote. Check values and try again.");
                }
            }
        }

        private void ComboBoxDesktopMaterial_Validating(object sender, CancelEventArgs e)
        {
            if (ComboBoxDesktopMaterial.Text == string.Empty )
            {
                e.Cancel = true;
                ErrorProvider1.SetError(ComboBoxDesktopMaterial, "Please select the desk surface material.");
            } 
            else
            {
                ErrorProvider1.SetError(ComboBoxDesktopMaterial, null);
            }
        }

        private void TextBoxDeskDepth_Validating(object sender, CancelEventArgs e)
        {
            int TempDepth = 0;
            bool IntValue = int.TryParse(TextBoxDeskDepth.Text, out TempDepth);
            if ((TextBoxDeskDepth.Text == string.Empty) || !IntValue || (TempDepth < Desk.MINDEPTH) || (TempDepth > Desk.MAXDEPTH))
            {
                e.Cancel = true;
                ErrorProvider1.SetError(TextBoxDeskDepth, "Please depth width between " + Desk.MINDEPTH.ToString() + " and " + Desk.MAXDEPTH.ToString() + " inches.");
            }
            else
            {
                ErrorProvider1.SetError(TextBoxDeskDepth, "");
            }

        }

        private void ComboBoxRushOrder_Validating(object sender, CancelEventArgs e)
        {
            if (ComboBoxRushOrder.Text == string.Empty)
            {
                e.Cancel = true;
                ErrorProvider1.SetError(ComboBoxRushOrder, "Please select the order rush speed.");
            }
            else
            {
                ErrorProvider1.SetError(ComboBoxRushOrder, "");
            }

        }

        private void DateTimePickerOrderDate_Validating(object sender, CancelEventArgs e)
        {
            if (DateTimePickerOrderDate.Value > DateTime.Now)
            {
                e.Cancel = true;
                ErrorProvider1.SetError(DateTimePickerOrderDate, "Please do not select a future date.");
            }
            else
            {
                ErrorProvider1.SetError(DateTimePickerOrderDate, "");
            }
        }

        private void TextBoxCustomerName_Validating(object sender, CancelEventArgs e)
        {
            if (TextBoxCustomerName.Text == string.Empty)
            {
                e.Cancel = true;
                ErrorProvider1.SetError(TextBoxCustomerName, "Please enter a valid name.");
            }
            else
            {
                ErrorProvider1.SetError(TextBoxCustomerName, "");
            }
        }
    }
}
