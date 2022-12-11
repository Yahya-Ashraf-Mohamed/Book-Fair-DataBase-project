using System;
using System.Windows.Forms;

namespace Book_Fair
{
    public partial class ViewSchedual : Form
    {

        public ViewSchedual()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Adminstrator newForm = new Adminstrator();
            newForm.Show();
            this.Hide();
        }

        private void schedule_button_Click(object sender, EventArgs e)
        {

        }

        private void date_comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
