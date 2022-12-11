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
    public partial class Sign_Up_1_Form : Form
    {
        string priv;
        public Sign_Up_1_Form()
        {
            InitializeComponent();
        }

        private void Visitor_button_Click(object sender, EventArgs e)
        {
            priv = "Visitor";
            SignUp_2_form SignUp_2_form = new SignUp_2_form(priv);
            SignUp_2_form.Show();
            this.Hide();
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            Login_form Login_form = new Login_form();
            Login_form.Show();
            this.Hide();
        }

        private void Bookseller_button_Click(object sender, EventArgs e)
        {
            priv = "Bookseller";
            SignUp_2_form SignUp_2_form = new SignUp_2_form(priv);
            SignUp_2_form.Show();
            this.Hide();
        }

        private void Organizer_button_Click(object sender, EventArgs e)
        {
            priv = "Organizer";
            SignUp_2_form SignUp_2_form = new SignUp_2_form(priv);
            SignUp_2_form.Show();
            this.Hide();
        }

        private void Volunteer_button_Click(object sender, EventArgs e)
        {
            priv = "Volunteer";
            SignUp_2_form SignUp_2_form = new SignUp_2_form(priv);
            SignUp_2_form.Show();
            this.Hide();
        }

        private void Media_and_Press_button_Click(object sender, EventArgs e)
        {
            priv = "Media_and_Press";
            SignUp_2_form SignUp_2_form = new SignUp_2_form(priv);
            SignUp_2_form.Show();
            this.Hide();
        }

        private void Tickets_collector_button_Click(object sender, EventArgs e)
        {
            priv = "Tickets_collector";
            SignUp_2_form SignUp_2_form = new SignUp_2_form(priv);
            SignUp_2_form.Show();
            this.Hide();
        }

        private void Administrator_button_Click(object sender, EventArgs e)
        {
            priv = "Administrator";
            SignUp_2_form SignUp_2_form = new SignUp_2_form(priv);
            SignUp_2_form.Show();
            this.Hide();
        }
    }
}
