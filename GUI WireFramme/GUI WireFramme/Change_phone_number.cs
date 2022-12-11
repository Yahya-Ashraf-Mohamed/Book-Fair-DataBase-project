using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Book_Fair
{
    public partial class Change_phone_number : Form
    {
        Controller controllerObj;
        int ID;
        string priv;                // make it for all useres
        public Change_phone_number(int id, string privelage)
        {
            ID = id;
            priv = privelage;
            InitializeComponent();
            controllerObj = new Controller();
            checkBox_Delete_Existing_phone.Checked = false;
            comboBox_Old_phone_numbers.Enabled = false;
            button_Delete.Enabled = false;
            checkBox_Add_New_Phone.Checked = false;
            textBox_Add_New_Phone.Enabled = false;
            button_Add_New.Enabled = false;

            switch (priv)
            {
                case "Volunteer":
                    DataTable Select_Volunteer_All_PhoneNumbers = controllerObj.Select_Volunteer_All_PhoneNumbers(ID);
                    comboBox_Old_phone_numbers.DataSource = Select_Volunteer_All_PhoneNumbers;
                    comboBox_Old_phone_numbers.DisplayMember = "PhoneNum";
                    break;
                case "Bookseller":
                    DataTable Select_Bookseller_All_PhoneNumbers = controllerObj.Select_Bookseller_All_PhoneNumbers(ID);
                    comboBox_Old_phone_numbers.DataSource = Select_Bookseller_All_PhoneNumbers;
                    comboBox_Old_phone_numbers.DisplayMember = "PhoneNum";
                    break;
                case "Media_Man":
                    DataTable Select_Media_Man_All_PhoneNumbers = controllerObj.Select_Media_Man_All_PhoneNumbers(ID);
                    comboBox_Old_phone_numbers.DataSource = Select_Media_Man_All_PhoneNumbers;
                    comboBox_Old_phone_numbers.DisplayMember = "PhoneNum";
                    break;
                case "Organizer":
                    DataTable Select_Organizer_All_PhoneNumbers = controllerObj.Select_Organizer_All_PhoneNumbers(ID);
                    comboBox_Old_phone_numbers.DataSource = Select_Organizer_All_PhoneNumbers;
                    comboBox_Old_phone_numbers.DisplayMember = "PhoneNum";
                    break;
                case "Ticket_Reserver":
                    DataTable Select_Ticket_Reserver_All_PhoneNumbers = controllerObj.Select_Ticket_Reserver_All_PhoneNumbers(ID);
                    comboBox_Old_phone_numbers.DataSource = Select_Ticket_Reserver_All_PhoneNumbers;
                    comboBox_Old_phone_numbers.DisplayMember = "Phone_Number";
                    break;
                case "Visitor":
                    DataTable Select_Visitor_All_PhoneNumbers = controllerObj.Select_Visitor_All_PhoneNumbers(ID);
                    comboBox_Old_phone_numbers.DataSource = Select_Visitor_All_PhoneNumbers;
                    comboBox_Old_phone_numbers.DisplayMember = "Phone_Number";
                    break;
                default:
                    MessageBox.Show("Error while connecting to the database, Please try again later!");
                    break;
            }
        }

        private void checkBox_Add_New_Phone_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Add_New_Phone.Checked == true)
            {
                button_Add_New.Enabled = true;
                textBox_Add_New_Phone.Enabled = true;

                checkBox_Delete_Existing_phone.Checked = false;
                comboBox_Old_phone_numbers.Enabled = false;
                button_Delete.Enabled = false;


            }
            else if (checkBox_Add_New_Phone.Checked == false)
            {
                textBox_Add_New_Phone.Enabled = false;
                button_Add_New.Enabled = false;
            }
        }

        private void checkBox_Delete_Existing_phone_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Delete_Existing_phone.Checked == true)
            {
                comboBox_Old_phone_numbers.Enabled = true;
                button_Delete.Enabled = true;

                checkBox_Add_New_Phone.Checked = false;
                textBox_Add_New_Phone.Enabled = false;
                button_Add_New.Enabled = false;

            }
            else if (checkBox_Delete_Existing_phone.Checked == false)
            {
                comboBox_Old_phone_numbers.Enabled = false;
                button_Delete.Enabled = false;

            }
        }

        private void Log_out_label_Click(object sender, EventArgs e)
        {
            Login_form Login_form = new Login_form();
            Login_form.Show();
            this.Hide();
        }

        private void Back_label_Click(object sender, EventArgs e)
        {
            Volunteer_Edit Volunteer_Edit = new Volunteer_Edit(ID);
            Volunteer_Edit.Show();
            this.Hide();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (comboBox_Old_phone_numbers.Text == "")
                MessageBox.Show("Please Choose the Phone-number first!");
            else
            {
                switch (priv)
                {
                    case "Volunteer":
                        if (controllerObj.Delete_Volunter_Phones(ID, long.Parse(comboBox_Old_phone_numbers.Text)) > 0)
                        {
                            MessageBox.Show("Phone Number has been deleted successfully");
                            DataTable Select_Volunteer_All_PhoneNumbers = controllerObj.Select_Volunteer_All_PhoneNumbers(ID);
                            comboBox_Old_phone_numbers.DataSource = Select_Volunteer_All_PhoneNumbers;
                            comboBox_Old_phone_numbers.DisplayMember = "PhoneNum";
                            comboBox_Old_phone_numbers.Refresh();
                        }
                        else
                        {
                            MessageBox.Show("Operation failed, Please try again!");
                            DataTable Select_Volunteer_All_PhoneNumbers = controllerObj.Select_Volunteer_All_PhoneNumbers(ID);
                            comboBox_Old_phone_numbers.DataSource = Select_Volunteer_All_PhoneNumbers;
                            comboBox_Old_phone_numbers.DisplayMember = "PhoneNum";
                            comboBox_Old_phone_numbers.Refresh();
                        }
                        break;

                    case "Bookseller":
                        if (controllerObj.Delete_Bookseller_Phone(ID, long.Parse(comboBox_Old_phone_numbers.Text)) > 0)
                        {
                            MessageBox.Show("Phone Number has been deleted successfully");
                            DataTable Select_Bookseller_All_PhoneNumbers = controllerObj.Select_Bookseller_All_PhoneNumbers(ID);
                            comboBox_Old_phone_numbers.DataSource = Select_Bookseller_All_PhoneNumbers;
                            comboBox_Old_phone_numbers.DisplayMember = "PhoneNum";
                            comboBox_Old_phone_numbers.Refresh();
                        }
                        else
                        {
                            MessageBox.Show("Operation failed, Please try again!");
                            DataTable Select_Bookseller_All_PhoneNumbers = controllerObj.Select_Bookseller_All_PhoneNumbers(ID);
                            comboBox_Old_phone_numbers.DataSource = Select_Bookseller_All_PhoneNumbers;
                            comboBox_Old_phone_numbers.DisplayMember = "PhoneNum";
                            comboBox_Old_phone_numbers.Refresh();
                        }
                        break;

                    case "Media_Man":
                        if (controllerObj.Delete_Media_Phones(ID, long.Parse(comboBox_Old_phone_numbers.Text)) > 0)
                        {
                            MessageBox.Show("Phone Number has been deleted successfully");
                            DataTable Select_Media_Man_All_PhoneNumbers = controllerObj.Select_Media_Man_All_PhoneNumbers(ID);
                            comboBox_Old_phone_numbers.DataSource = Select_Media_Man_All_PhoneNumbers;
                            comboBox_Old_phone_numbers.DisplayMember = "PhoneNum";
                            comboBox_Old_phone_numbers.Refresh();
                        }
                        else
                        {
                            MessageBox.Show("Operation failed, Please try again!");
                            DataTable Select_Media_Man_All_PhoneNumbers = controllerObj.Select_Media_Man_All_PhoneNumbers(ID);
                            comboBox_Old_phone_numbers.DataSource = Select_Media_Man_All_PhoneNumbers;
                            comboBox_Old_phone_numbers.DisplayMember = "PhoneNum";
                            comboBox_Old_phone_numbers.Refresh();
                        }
                        break;

                    case "Ticket_Reserver":
                        if (controllerObj.Delete_Ticket_Reserve_Phone(ID, long.Parse(comboBox_Old_phone_numbers.Text)) > 0)
                        {
                            MessageBox.Show("Phone Number has been deleted successfully");
                            DataTable Select_Ticket_Reserver_All_PhoneNumbers = controllerObj.Select_Ticket_Reserver_All_PhoneNumbers(ID);
                            comboBox_Old_phone_numbers.DataSource = Select_Ticket_Reserver_All_PhoneNumbers;
                            comboBox_Old_phone_numbers.DisplayMember = "Phone_Number";
                            comboBox_Old_phone_numbers.Refresh();
                        }
                        else
                        {
                            MessageBox.Show("Operation failed, Please try again!");
                            DataTable Select_Ticket_Reserver_All_PhoneNumbers = controllerObj.Select_Ticket_Reserver_All_PhoneNumbers(ID);
                            comboBox_Old_phone_numbers.DataSource = Select_Ticket_Reserver_All_PhoneNumbers;
                            comboBox_Old_phone_numbers.DisplayMember = "Phone_Number";
                            comboBox_Old_phone_numbers.Refresh();
                        }
                        break;

                    case "Visitor":

                        if (controllerObj.Delete_Visitor_Phones(ID, long.Parse(comboBox_Old_phone_numbers.Text)) > 0)
                        {
                            MessageBox.Show("Phone Number has been deleted successfully");
                            DataTable Select_Visitor_All_PhoneNumbers = controllerObj.Select_Visitor_All_PhoneNumbers(ID);
                            comboBox_Old_phone_numbers.DataSource = Select_Visitor_All_PhoneNumbers;
                            comboBox_Old_phone_numbers.DisplayMember = "Phone_Number";
                            comboBox_Old_phone_numbers.Refresh();
                        }
                        else
                        {
                            MessageBox.Show("Operation failed, Please try again!");
                            DataTable Select_Visitor_All_PhoneNumbers = controllerObj.Select_Visitor_All_PhoneNumbers(ID);
                            comboBox_Old_phone_numbers.DataSource = Select_Visitor_All_PhoneNumbers;
                            comboBox_Old_phone_numbers.DisplayMember = "Phone_Number";
                            comboBox_Old_phone_numbers.Refresh();
                        }
                        break;

                    case "Organizer":
                        if (controllerObj.Delete_Organizer_Phone(ID, long.Parse(comboBox_Old_phone_numbers.Text)) > 0)
                        {
                            MessageBox.Show("Phone Number has been deleted successfully");
                            DataTable Select_Organizer_All_PhoneNumbers = controllerObj.Select_Organizer_All_PhoneNumbers(ID);
                            comboBox_Old_phone_numbers.DataSource = Select_Organizer_All_PhoneNumbers;
                            comboBox_Old_phone_numbers.DisplayMember = "PhoneNum";
                            comboBox_Old_phone_numbers.Refresh();
                        }
                        else
                        {
                            MessageBox.Show("Operation failed, Please try again!");
                            DataTable Select_Organizer_All_PhoneNumbers = controllerObj.Select_Organizer_All_PhoneNumbers(ID);
                            comboBox_Old_phone_numbers.DataSource = Select_Organizer_All_PhoneNumbers;
                            comboBox_Old_phone_numbers.DisplayMember = "PhoneNum";
                            comboBox_Old_phone_numbers.Refresh();
                        }
                        break;

                    default:
                        MessageBox.Show("Error while connecting to the database, Please try again later!");
                        break;
                }

            }
        }

        private void button_Add_New_Click(object sender, EventArgs e)
        {
            if (textBox_Add_New_Phone.Text == "")
                MessageBox.Show("Please Write down your Phone-number first!");
            else if (textBox_Add_New_Phone.TextLength != 11 || long.Parse(textBox_Add_New_Phone.Text) < 01000000000
                || (long.Parse(textBox_Add_New_Phone.Text) > 01299999999 && long.Parse(textBox_Add_New_Phone.Text) < 01500000000)
                || (long.Parse(textBox_Add_New_Phone.Text) > 01599999999))
                MessageBox.Show("Please enter a valid Phone-number!");
            else if (controllerObj.Is_Phone_Number_Unique(Int32.Parse(textBox_Add_New_Phone.Text)) != null)
                MessageBox.Show("Sorry, this Phone Number is already used in another account!");
            else 
            {
                switch (priv)
                {
                    case "Volunteer":
                        if (controllerObj.Is_Volunteer_PhoneNumber_Exists(long.Parse(textBox_Add_New_Phone.Text)) == 0)
                        {
                            int addnew = controllerObj.Insert_Volunter_Phones(long.Parse(textBox_Add_New_Phone.Text), ID);
                            if (addnew > 0)
                            {
                                MessageBox.Show("Phone Number has been added successfully");
                                textBox_Add_New_Phone.Text = "";
                                DataTable Select_Volunteer_All_PhoneNumbers = controllerObj.Select_Volunteer_All_PhoneNumbers(ID);
                                comboBox_Old_phone_numbers.DataSource = Select_Volunteer_All_PhoneNumbers;
                                comboBox_Old_phone_numbers.DisplayMember = "PhoneNum";
                                comboBox_Old_phone_numbers.Refresh();

                            }
                            else
                            {
                                MessageBox.Show("Operation failed, Please try again!");
                                textBox_Add_New_Phone.Text = "";
                            }
                        }
                        else
                            MessageBox.Show("Sorry, This Phone number already exists!");
                        break;
                    case "Bookseller":
                        if (controllerObj.Is_Bookseller_PhoneNumber_Exists(long.Parse(textBox_Add_New_Phone.Text)) == 0)
                        {
                            int addnew = controllerObj.Insert_Book_Seller_Phones(long.Parse(textBox_Add_New_Phone.Text), ID);
                            if (addnew > 0)
                            {
                                MessageBox.Show("Phone Number has been added successfully");
                                textBox_Add_New_Phone.Text = "";
                                DataTable Select_Bookseller_All_PhoneNumbers = controllerObj.Select_Bookseller_All_PhoneNumbers(ID);
                                comboBox_Old_phone_numbers.DataSource = Select_Bookseller_All_PhoneNumbers;
                                comboBox_Old_phone_numbers.DisplayMember = "PhoneNum";
                                comboBox_Old_phone_numbers.Refresh();

                            }
                            else
                            {
                                MessageBox.Show("Operation failed, Please try again!");
                                textBox_Add_New_Phone.Text = "";
                            }
                        }
                        else
                            MessageBox.Show("Sorry, This Phone number already exists!");
                        break;
                    case "Media_Man":
                        if (controllerObj.Is_Media_Man_PhoneNumber_Exists(long.Parse(textBox_Add_New_Phone.Text)) == 0)
                        {
                            int addnew = controllerObj.Insert_Media_Phone(long.Parse(textBox_Add_New_Phone.Text), ID);
                            if (addnew > 0)
                            {
                                MessageBox.Show("Phone Number has been added successfully");
                                textBox_Add_New_Phone.Text = "";
                                DataTable Select_Media_Man_All_PhoneNumbers = controllerObj.Select_Media_Man_All_PhoneNumbers(ID);
                                comboBox_Old_phone_numbers.DataSource = Select_Media_Man_All_PhoneNumbers;
                                comboBox_Old_phone_numbers.DisplayMember = "PhoneNum";
                                comboBox_Old_phone_numbers.Refresh();

                            }
                            else
                            {
                                MessageBox.Show("Operation failed, Please try again!");
                                textBox_Add_New_Phone.Text = "";
                            }
                        }
                        else
                            MessageBox.Show("Sorry, This Phone number already exists!");
                        break;
                    case "Ticket_Reserver":
                        if (controllerObj.Is_Ticket_Reserver_PhoneNumber_Exists(long.Parse(textBox_Add_New_Phone.Text)) == 0)
                        {
                            int addnew = controllerObj.Insert_Ticket_Reserve_Phone(long.Parse(textBox_Add_New_Phone.Text), ID);
                            if (addnew > 0)
                            {
                                MessageBox.Show("Phone Number has been added successfully");
                                textBox_Add_New_Phone.Text = "";
                                DataTable Select_Ticket_Reserver_All_PhoneNumbers = controllerObj.Select_Ticket_Reserver_All_PhoneNumbers(ID);
                                comboBox_Old_phone_numbers.DataSource = Select_Ticket_Reserver_All_PhoneNumbers;
                                comboBox_Old_phone_numbers.DisplayMember = "Phone_Number";
                                comboBox_Old_phone_numbers.Refresh();

                            }
                            else
                            {
                                MessageBox.Show("Operation failed, Please try again!");
                                textBox_Add_New_Phone.Text = "";
                            }
                        }
                        else
                            MessageBox.Show("Sorry, This Phone number already exists!");
                        break;
                    case "Visitor":
                        if (controllerObj.Is_Visitor_PhoneNumber_Exists(long.Parse(textBox_Add_New_Phone.Text)) == 0)
                        {
                            int addnew = controllerObj.Insert_Visitor_Phones(long.Parse(textBox_Add_New_Phone.Text), ID);
                            if (addnew > 0)
                            {
                                MessageBox.Show("Phone Number has been added successfully");
                                textBox_Add_New_Phone.Text = "";
                                DataTable Select_Visitor_All_PhoneNumbers = controllerObj.Select_Visitor_All_PhoneNumbers(ID);
                                comboBox_Old_phone_numbers.DataSource = Select_Visitor_All_PhoneNumbers;
                                comboBox_Old_phone_numbers.DisplayMember = "Phone_Number";
                                comboBox_Old_phone_numbers.Refresh();

                            }
                            else
                            {
                                MessageBox.Show("Operation failed, Please try again!");
                                textBox_Add_New_Phone.Text = "";
                            }
                        }
                        else
                            MessageBox.Show("Sorry, This Phone number already exists!");
                        break;
                    case "Organizer":
                        if (controllerObj.Is_Organizer_PhoneNumber_Exists(long.Parse(textBox_Add_New_Phone.Text)) == 0)
                        {
                            int addnew = controllerObj.Insert_Organizer_Phone(long.Parse(textBox_Add_New_Phone.Text), ID);
                            if (addnew > 0)
                            {
                                MessageBox.Show("Phone Number has been added successfully");
                                textBox_Add_New_Phone.Text = "";
                                DataTable Select_Organizer_All_PhoneNumbers = controllerObj.Select_Organizer_All_PhoneNumbers(ID);
                                comboBox_Old_phone_numbers.DataSource = Select_Organizer_All_PhoneNumbers;
                                comboBox_Old_phone_numbers.DisplayMember = "PhoneNum";
                                comboBox_Old_phone_numbers.Refresh();

                            }
                            else
                            {
                                MessageBox.Show("Operation failed, Please try again!");
                                textBox_Add_New_Phone.Text = "";
                            }
                        }
                        else
                            MessageBox.Show("Sorry, This Phone number already exists!");
                        break;

                    default:
                        MessageBox.Show("Error while connecting to the database, Please try again later!");
                        break;
                }
            }
                     
        }
    }
}
