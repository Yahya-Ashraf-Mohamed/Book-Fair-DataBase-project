using System;
using System.Windows.Forms;

namespace Book_Fair
{
    public partial class Media : Form
    {
        public Media()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Media form = new Media();
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Guests form = new Guests();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Events form = new Events();
            form.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Facebook Account \n User: \t Pass: \n Instagram Account \n user: \t pass: ");
        }

        
    }
}
