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
    public partial class Login_form : Form
    {
        Controller controllerObj;
        public Login_form()
        {
            InitializeComponent();
            controllerObj = new Controller();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Login_button_Click(object sender, EventArgs e)
        {

            try
            {
                if (Username_textBox.Text == "")
                {
                    MessageBox.Show("Please enter your Username!");
                }
                else if (Password_textBox.Text == "")
                {
                    MessageBox.Show("Please enter your password!");
                }
                else
                {
                    DataTable State;
                    
                    while (true)
                    {
                        State = controllerObj.Check_Login_Organizer(Username_textBox.Text);
                        if (State != null)
                        {
                            if (State.Rows[0][0].ToString() == Password_textBox.Text.ToString())
                            {

                                //DataTable OID = controllerObj.get_Organizer_ID(Username_textBox.Text);
                                //int ID = int.Parse(OID.Rows[0][0].ToString());
                                Organization organization = new Organization(/*ID*/);
                                organization.Show();
                                this.Hide();
                                break;
                            }
                            else
                            {
                                MessageBox.Show("Incorect password!");
                                Password_textBox.Text = "";
                                break;
                            }
                        }

                        State = controllerObj.Check_Login_Bookseller(Username_textBox.Text);
                        if (State != null)
                        {
                            if (State.Rows[0][0].ToString() == Password_textBox.Text.ToString())
                            {
                                //DataTable BID = controllerObj.get_Bookseller_ID(Username_textBox.Text);
                                //int ID = int.Parse(BID.Rows[0][0].ToString());
                                BookSeller BookSeller = new BookSeller(/*ID*/);
                                BookSeller.Show();
                                this.Hide();
                                break;
                            }
                            else
                            {
                                MessageBox.Show("Incorect password!");
                                Password_textBox.Text = "";
                                break;
                            }
                        }

                        State = controllerObj.Check_Login_Media(Username_textBox.Text);
                        if (State != null)
                        {
                            if (State.Rows[0][0].ToString() == Password_textBox.Text.ToString())
                            {
                                //DataTable MID = controllerObj.get_Media_Man_ID(Username_textBox.Text);
                                //int ID = int.Parse(MID.Rows[0][0].ToString());
                                Media Media = new Media(/*ID*/);
                                Media.Show();
                                this.Hide();
                                break;
                            }
                            else
                            {
                                MessageBox.Show("Incorect password!");
                                Password_textBox.Text = "";
                                break;
                            }
                        }

                        State = controllerObj.Check_Login_Ticket_reserver(Username_textBox.Text);
                        if (State != null)
                        {
                            if (State.Rows[0][0].ToString() == Password_textBox.Text.ToString())
                            {
                                //DataTable TID = controllerObj.get_Ticket_reserver_ID(Username_textBox.Text);
                                //int ID = int.Parse(TID.Rows[0][0].ToString());
                                Ticket_Reservation Ticket_Reservation = new Ticket_Reservation(/*ID*/);
                                Ticket_Reservation.Show();
                                this.Hide();
                                break;
                            }
                            else
                            {
                                MessageBox.Show("Incorect password!");
                                Password_textBox.Text = "";
                                break;
                            }
                        }

                        State = controllerObj.Check_Login_Visitors(Username_textBox.Text);
                        if (State != null)
                        {
                            if (State.Rows[0][0].ToString() == Password_textBox.Text.ToString())
                            {
                                Use_Ticket Use_Ticket = new Use_Ticket(Username_textBox.Text.ToString());
                                Use_Ticket.Show();
                                this.Hide();
                                break;
                            }
                            else
                            {
                                MessageBox.Show("Incorect password!");
                                Password_textBox.Text = "";
                                break;
                            }
                        }

                        State = controllerObj.Check_Login_Volunter(Username_textBox.Text);
                        if (State != null)
                        {
                            if (State.Rows[0][0].ToString() == Password_textBox.Text.ToString())
                            {
                                DataTable VID = controllerObj.get_Volunteer_ID(Username_textBox.Text);
                                int ID = int.Parse(VID.Rows[0][0].ToString());
                                Volunteer volunteer_form = new Volunteer(ID);
                                volunteer_form.Show();
                                this.Hide();
                                break;
                            }
                            else
                            {
                                MessageBox.Show("Incorect password!");
                                Password_textBox.Text = "";
                                break;
                            }
                        }
         
                        MessageBox.Show("Username doesn't exist!");
                        Username_textBox.Text = "";
                        Password_textBox.Text = "";
                        break;
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured!");
                Username_textBox.Text = "";
                Password_textBox.Text = "";
            }


        }


            private void Forget_Password_label_Click(object sender, EventArgs e)
            {
                Forget_password Forget_password_Form = new Forget_password();
                Forget_password_Form.Show();
                this.Hide();
            }

            private void Sign_Up_label_Click(object sender, EventArgs e)
            {
                Sign_Up_1_Form Sign_Up_1_Form = new Sign_Up_1_Form();
                Sign_Up_1_Form.Show();
                this.Hide();
            }

            private void Username_textBox_TextChanged(object sender, EventArgs e)
            { }

            private void Password_textBox_TextChanged(object sender, EventArgs e)
            { }

        private void checkBox_Show_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Show.Checked == true)
                Password_textBox.UseSystemPasswordChar = true;
            else
                Password_textBox.UseSystemPasswordChar = false;
        }
    }
}
