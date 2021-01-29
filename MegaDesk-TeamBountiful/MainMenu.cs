using System;
using System.Windows.Forms;

namespace MegaDesk_TeamBountiful
{
    public partial class MainMenu : Form
    {
        public static Filer DataFiler = new Filer();

        public MainMenu()
        {
            InitializeComponent();
        }

        private void ButtonAddQuote_Click(object sender, EventArgs e)
        {
            AddQuote addQuoteForm = new AddQuote();
            addQuoteForm.Show();
            this.Hide();
        }

        private void ButtonSearchQuotes_Click(object sender, EventArgs e)
        {
            SearchQuotes searchQuotesForm = new SearchQuotes();
            searchQuotesForm.Show();
            this.Hide();
        }

        private void ButtonViewQuotes_Click(object sender, EventArgs e)
        {
            ViewAllQuotes viewAllQuotesForm = new ViewAllQuotes();
            viewAllQuotesForm.Show();
            this.Hide();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            DataFiler.SaveToJson();

            this.Close();
        }

    }
}
