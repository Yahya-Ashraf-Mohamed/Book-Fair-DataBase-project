using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_Fair
{
    public partial class Adminstrator : Form
    {
        public Adminstrator()
        {
            InitializeComponent();
        }



        private void Regestration_button_Click(object sender, EventArgs e)
        {
            Registration newForm = new Registration();
            newForm.Show();
            this.Hide();
        }

        private void schedule_button_Click(object sender, EventArgs e)
        {
            Events newForm = new Events();
            newForm.Show();
            this.Hide();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            //log in form if this button clicked

        }

        private void Vreport_button_Click(object sender, EventArgs e)
        {

        }

        private void Adminstrator_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void Back_label_Click(object sender, EventArgs e)
        {
            Login_form Login_form = new Login_form();
            Login_form.Show();
            this.Hide();
        }

        private void Log_out_label_Click(object sender, EventArgs e)
        {
            Login_form Login_form = new Login_form();
            Login_form.Show();
            this.Hide();
        }
    }
}
