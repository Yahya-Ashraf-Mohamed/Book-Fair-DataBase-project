using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Book_Fair
{
    public partial class Reset_Password : Form
    {
        Controller controllerObj;
        int ID;
        string priv;
        public Reset_Password(int id, string privelage)
        {
            ID = id;
            priv = privelage;
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void Back_label_Click(object sender, EventArgs e)
        {
            Volunteer_Edit Volunteer_Edit = new Volunteer_Edit(ID);
            Volunteer_Edit.Show();
            this.Hide();
        }

        private void Log_out_label_Click(object sender, EventArgs e)
        {
            Login_form Login_form = new Login_form();
            Login_form.Show();
            this.Hide();
        }

        private void button_Confirm_Click(object sender, EventArgs e)
        {
            if (textBox_New_pass.Text == textBox_Old_Password.Text)
                MessageBox.Show("You can't re-enter your last password, Please choose differant password");
            else if (textBox_Confirm_pass.Text != textBox_New_pass.Text)
                MessageBox.Show("Please Re-Enter your Password Correctly!");
            else
            {

                switch (priv)
                {
                    case "Volunteer":
                        if (controllerObj.Change_Volunteer_Password(ID, textBox_Old_Password.Text, textBox_New_pass.Text) > 0)
                        {
                            MessageBox.Show("Password have been changed successfully");
                            textBox_Old_Password.Text = "";
                            textBox_New_pass.Text = "";
                            textBox_Confirm_pass.Text = "";
                            Volunteer_Edit Volunteer_Edit = new Volunteer_Edit(ID);
                            Volunteer_Edit.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Your old password is incorrect!");
                            textBox_Old_Password.Text = "";
                        }
                        break;

                    case "Bookseller":
                        if (controllerObj.Change_Bookseller_Password(ID, textBox_Old_Password.Text, textBox_New_pass.Text) > 0)
                        {
                            MessageBox.Show("Password have been changed successfully");
                            textBox_Old_Password.Text = "";
                            textBox_New_pass.Text = "";
                            textBox_Confirm_pass.Text = "";
                            Volunteer_Edit Volunteer_Edit = new Volunteer_Edit(ID);
                            Volunteer_Edit.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Your old password is incorrect!");
                            textBox_Old_Password.Text = "";
                        }
                        break;

                    case "Media_Man":
                        if (controllerObj.Change_Media_Man_Password(ID, textBox_Old_Password.Text, textBox_New_pass.Text) > 0)
                        {
                            MessageBox.Show("Password have been changed successfully");
                            textBox_Old_Password.Text = "";
                            textBox_New_pass.Text = "";
                            textBox_Confirm_pass.Text = "";
                            Volunteer_Edit Volunteer_Edit = new Volunteer_Edit(ID);
                            Volunteer_Edit.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Your old password is incorrect!");
                            textBox_Old_Password.Text = "";
                        }
                        break;

                    case "Ticket_Reserver":
                        if (controllerObj.Change_Ticket_Reserver_Password(ID, textBox_Old_Password.Text, textBox_New_pass.Text) > 0)
                        {
                            MessageBox.Show("Password have been changed successfully");
                            textBox_Old_Password.Text = "";
                            textBox_New_pass.Text = "";
                            textBox_Confirm_pass.Text = "";
                            Volunteer_Edit Volunteer_Edit = new Volunteer_Edit(ID);
                            Volunteer_Edit.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Your old password is incorrect!");
                            textBox_Old_Password.Text = "";
                        }
                        break;

                    case "Visitor":
                        if (controllerObj.Change_Visitor_Password(ID, textBox_Old_Password.Text, textBox_New_pass.Text) > 0)
                        {
                            MessageBox.Show("Password have been changed successfully");
                            textBox_Old_Password.Text = "";
                            textBox_New_pass.Text = "";
                            textBox_Confirm_pass.Text = "";
                            Volunteer_Edit Volunteer_Edit = new Volunteer_Edit(ID);
                            Volunteer_Edit.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Your old password is incorrect!");
                            textBox_Old_Password.Text = "";
                        }
                        break;

                    case "Organizer":
                        if (controllerObj.Change_Organizer_Password(ID, textBox_Old_Password.Text, textBox_New_pass.Text) > 0)
                        {
                            MessageBox.Show("Password have been changed successfully");
                            textBox_Old_Password.Text = "";
                            textBox_New_pass.Text = "";
                            textBox_Confirm_pass.Text = "";
                            Volunteer_Edit Volunteer_Edit = new Volunteer_Edit(ID);
                            Volunteer_Edit.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Your old password is incorrect!");
                            textBox_Old_Password.Text = "";
                        }
                        break;

                    default:
                        MessageBox.Show("Error while connecting to the database, Please try again later!");
                        break;
                }
                
            }
        }

        private void checkBox_Show_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Show.Checked == true)
                textBox_New_pass.UseSystemPasswordChar = true;
            else
                textBox_New_pass.UseSystemPasswordChar = false;
        }
    }
}
