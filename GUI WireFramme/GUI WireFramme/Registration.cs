using System;
using System.Windows.Forms;

namespace Book_Fair
{
    public partial class Registration : Form
    {
        Controller controllerObj = new Controller();
        public Registration()
        {
            InitializeComponent();
        }

        private void enter_button_Click(object sender, EventArgs e)
        {
            if (name_textBox.Text == "")
            {
                MessageBox.Show("Please enter the name");
            }
            else if (id_textBox.Text == " ")
            {
                MessageBox.Show("Please enter the ID");
            }
            else if (ticket_textBox.Text == " ")
            {
                MessageBox.Show("Please enter the Ticket Number");
            }

            controllerObj.AddVisitor(name_textBox.Text, Convert.ToInt32(id_textBox.Text), Convert.ToInt32(ticket_textBox.Text));
            MessageBox.Show("Registered Successfully");
            controllerObj.Registration(name_textBox.Text, Convert.ToInt32(ticket_textBox.Text));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Adminstrator newForm = new Adminstrator();
            newForm.Show();
            this.Hide();
        }

        private void ticket_textBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void name_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void id_textBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
