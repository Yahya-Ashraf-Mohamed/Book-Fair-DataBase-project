using System;
using System.Windows.Forms;

namespace Book_Fair
{
    public partial class BookInfo : Form
    {
        Controller controllerObj = new Controller();
        public BookInfo()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BookSearch newForm = new BookSearch();
            newForm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void sell_button1_Click(object sender, EventArgs e)
        {
            controllerObj.Selling_Book(title_textBox.Text);
            MessageBox.Show("Book Sold");
            //Reciet newReport = new Reciet();
            //newReport.Show();
            this.Hide();

            //Reciet cryRpt = new Reciet();

            //cryRpt.Show();

            //crystalReportViewer1.ReportSource = cryRpt;

            //crystalReportViewer1.Refresh();
        }

        private void title_textBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void author_textBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
