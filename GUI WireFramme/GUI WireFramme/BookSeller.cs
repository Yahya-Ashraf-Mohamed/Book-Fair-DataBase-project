using System;
using System.Windows.Forms;

namespace Book_Fair
{
    public partial class BookSeller : Form
    {
        public BookSeller()
        {
            InitializeComponent();
        }

        private void BookSeller_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //if clicked go to log in page
        }

        private void bookREV_button_Click(object sender, EventArgs e)
        {
            BookAdd newForm = new BookAdd();
            newForm.Show();
            this.Hide();
        }

        private void BookSearch_button_Click(object sender, EventArgs e)
        {
            BookSearch newForm = new BookSearch();
            newForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Report newReport = new Report();
            //newReport.Show();
            this.Hide();
        }

    }
}
