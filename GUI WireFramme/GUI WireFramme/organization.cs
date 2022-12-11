using System;
using System.Windows.Forms;

namespace Book_Fair
{
    public partial class Organization : Form
    {
        public Organization()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Booths form = new Booths();
            form.ShowDialog();
        }

        private void events_Click(object sender, EventArgs e)
        {
            Events form = new Events();
            form.ShowDialog();
        }

        private void workers_Click(object sender, EventArgs e)
        {
            Workers form = new Workers();
            form.ShowDialog();
        }

        private void report_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
