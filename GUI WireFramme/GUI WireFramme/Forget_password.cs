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
    public partial class Forget_password : Form
    {
        Controller controllerObj;
        public Forget_password()
        {
            InitializeComponent();
            controllerObj = new Controller();
                    
        }

        private void Back_label_Click(object sender, EventArgs e)
        {
            Login_form Login_form = new Login_form();
            Login_form.Show();
            this.Hide();
        }

        private void Send_Password_button_Click(object sender, EventArgs e)
        {
            try
            {

                if (Username_textBox.Text == "")
                {
                    MessageBox.Show("Please enter your Username!");
                }
                else if (ID_textBox.Text == "")
                {
                    MessageBox.Show("Please enter your ID!");
                }
                else
                {
                    DataTable State;

                    while (true)
                    {
                        State = controllerObj.Recover_Organizer_Password(Username_textBox.Text);
                        if (State != null)
                        {
                            if (State.Rows[0][1].ToString() == ID_textBox.Text)
                            {
                                MessageBox.Show(State.Rows[0][0].ToString());
                                break;
                            }
                            else
                            {
                                MessageBox.Show("Invalid ID");
                                ID_textBox.Text = "";
                                break;
                            }
                        }

                        State = controllerObj.Recover_Bookseller_Password(Username_textBox.Text);
                        if (State != null)
                        {
                            if (State.Rows[0][1].ToString() == ID_textBox.Text)
                            {
                                MessageBox.Show(State.Rows[0][0].ToString());
                                break;
                            }
                            else
                            {
                                MessageBox.Show("Invalid ID");
                                ID_textBox.Text = "";
                                break;
                            }
                        }

                        State = controllerObj.Recover_Media_man_Password(Username_textBox.Text);
                        if (State != null)
                        {
                            if (State.Rows[0][1].ToString() == ID_textBox.Text)
                            {
                                MessageBox.Show(State.Rows[0][0].ToString());
                                break;
                            }
                            else
                            {
                                MessageBox.Show("Invalid ID");
                                ID_textBox.Text = "";
                                break;
                            }
                        }

                        State = controllerObj.Recover_Ticket_Reserves_Password(Username_textBox.Text);
                        if (State != null)
                        {
                            if (State.Rows[0][1].ToString() == ID_textBox.Text)
                            {
                                MessageBox.Show(State.Rows[0][0].ToString());
                                break;
                            }
                            else
                            {
                                MessageBox.Show("Invalid ID");
                                ID_textBox.Text = "";
                                break;
                            }
                        }

                        State = controllerObj.Recover_Visitor_Password(Username_textBox.Text);
                        if (State != null)
                        {
                            if (State.Rows[0][1].ToString() == ID_textBox.Text)
                            {
                                MessageBox.Show(State.Rows[0][0].ToString());
                                break;
                            }
                            else
                            {
                                MessageBox.Show("Invalid ID");
                                ID_textBox.Text = "";
                                break;
                            }
                        }
                        State = controllerObj.Recover_Volunters_Password(Username_textBox.Text);
                        if (State != null)
                        {
                            if (State.Rows[0][1].ToString() == ID_textBox.Text)
                            {
                                MessageBox.Show(State.Rows[0][0].ToString());
                                break;
                            }
                            else
                            {
                                MessageBox.Show("Invalid ID");
                                ID_textBox.Text = "";
                                break;
                            }
                        }

                        MessageBox.Show("Username doesn't exist!");
                        Username_textBox.Text = "";
                        ID_textBox.Text = "";
                        break;
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("An error occured!");
            }

        }
    }
}
