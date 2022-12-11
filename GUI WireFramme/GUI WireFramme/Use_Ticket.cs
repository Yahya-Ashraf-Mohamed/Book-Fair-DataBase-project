using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Book_Fair
{
    public partial class Use_Ticket : Form
    {
        Controller controllerObj;
        string username;

        public Use_Ticket(string name)
        {
            InitializeComponent();
            controllerObj = new Controller();
            username = name;
        }

        private void button_use_ticket_Click(object sender, EventArgs e)
        {
            if (textBox_enter_ticket.Text == "")
                MessageBox.Show("Please enter your Ticket Number!");
            else if (controllerObj.Is_Ticket_Used(int.Parse(textBox_enter_ticket.Text)) != null)
                MessageBox.Show("This Ticket has Already been used!");
            else
            {
                DataTable VID = controllerObj.get_Visitor_ID(username);
                string ID = VID.Rows[0].ItemArray[0].ToString();

                int state = controllerObj.Use_Ticket(int.Parse(textBox_enter_ticket.Text), Int32.Parse(ID), DateTime.Now);

                if (state > 0)
                {
                    controllerObj.Update_Visitor_atendance_Number(Int32.Parse(ID));

                    Guests Guests = new Guests(/*Int32.Parse(ID)*/);
                    Guests.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Error in Entering the Ticket, Please try again!");
            }
        }
        private void Back_label_Click(object sender, EventArgs e)
        {
            Login_form Login_form = new Login_form();
            Login_form.Show();
            this.Hide();
        }
    }
}


