using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Book_Fair
{
    public partial class Phone_Numbers_SignIn : Form
    {
        string priv;
        int S = 0;
        int ID;
        Controller controllerObj;
        public Phone_Numbers_SignIn(string privelage, int id)
        {
            this.priv = privelage;
            this.ID = id;
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            if (textBox_PhoneNo.Text == "")
                MessageBox.Show("Please enter your Phone number!");
            //soon check if number is valid 012 011 010
            if ((long.Parse(textBox_PhoneNo.Text) > 01000000000 && long.Parse(textBox_PhoneNo.Text) < 01099999999) ||
                (long.Parse(textBox_PhoneNo.Text) > 01100000000 && long.Parse(textBox_PhoneNo.Text) < 01199999999) ||
                (long.Parse(textBox_PhoneNo.Text) > 01200000000 && long.Parse(textBox_PhoneNo.Text) < 01299999999) ||
                (long.Parse(textBox_PhoneNo.Text) > 01500000000 && long.Parse(textBox_PhoneNo.Text) < 01599999999))
            {
                switch (priv)
                {
                    case "Visitor":

                        S = controllerObj.Insert_Visitor_Phones(long.Parse(textBox_PhoneNo.Text), this.ID);

                        if (S > 0)
                            MessageBox.Show("Phone Number has been added sucessfully");
                        else
                            MessageBox.Show("Operation failed");
                        break;

                    case "Bookseller":

                        S = controllerObj.Insert_Book_Seller_Phones(long.Parse(textBox_PhoneNo.Text), this.ID);

                        if (S > 0)
                            MessageBox.Show("Phone Number has been added sucessfully");
                        else
                            MessageBox.Show("Operation failed");
                        break;

                    case "Media_and_Press":
                        S = controllerObj.Insert_Media_Phone(long.Parse(textBox_PhoneNo.Text), this.ID);

                        if (S > 0)
                            MessageBox.Show("Phone Number has been added sucessfully");
                        else
                            MessageBox.Show("Operation failed");
                        break;

                    case "Organizer":

                        S = controllerObj.Insert_Organizer_Phone(long.Parse(textBox_PhoneNo.Text), this.ID);

                        if (S > 0)
                            MessageBox.Show("Phone Number has been added sucessfully");
                        else
                            MessageBox.Show("Operation failed");
                        break;

                    case "Tickets_collector":

                        S = controllerObj.Insert_Ticket_Reserve_Phone(long.Parse(textBox_PhoneNo.Text), this.ID);

                        if (S > 0)
                            MessageBox.Show("Phone Number has been added sucessfully");
                        else
                            MessageBox.Show("Operation failed");
                        break;

                    case "Volunteer":

                        S = controllerObj.Insert_Volunter_Phones(long.Parse(textBox_PhoneNo.Text), this.ID);

                        if (S > 0)
                            MessageBox.Show("Phone Number has been added sucessfully");
                        else
                            MessageBox.Show("Operation failed");
                        break;

                    default:

                        MessageBox.Show("An error occured, Please try again!");
                        break;
                }


                DialogResult Message = MessageBox.Show("Do you want to Enter another phone number?", "Enter Phone Number", MessageBoxButtons.YesNo);
                if (Message == DialogResult.Yes)
                {
                    textBox_PhoneNo.Text = "";
                    label_Another_Phone.Text = "Another Phone: ";
                }
                else if (Message == DialogResult.No)
                {
                    if (priv == "Visitor")
                    {
                        DialogResult Message2 = MessageBox.Show("Do you want to Enter your Intrestes?", "Enter Your Intrestes", MessageBoxButtons.YesNo);
                        if (Message2 == DialogResult.Yes)
                        {
                            Visitor_Interestes Visitor_Interestes = new Visitor_Interestes(ID);
                            Visitor_Interestes.Show();
                            this.Hide();
                        }
                        else if (Message2 == DialogResult.No)
                        {
                            MessageBox.Show("Signed up sucessfully");
                            MessageBox.Show("Your ID is: " + ID.ToString());
                            Login_form Login_form = new Login_form();
                            Login_form.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Signed up sucessfully");
                            MessageBox.Show("Your ID is: " + ID.ToString());
                            Login_form Login_form = new Login_form();
                            Login_form.Show();
                            this.Hide();
                        }
                    }
                }

            }
            else
                MessageBox.Show("Please Enter a valid phone number!");

        }

        private void Back_label_Click(object sender, EventArgs e)
        {
            if (textBox_PhoneNo.Text != "")
            {
                if ((long.Parse(textBox_PhoneNo.Text) > 01000000000 && long.Parse(textBox_PhoneNo.Text) < 01099999999) ||
                    (long.Parse(textBox_PhoneNo.Text) > 01100000000 && long.Parse(textBox_PhoneNo.Text) < 01199999999) ||
                    (long.Parse(textBox_PhoneNo.Text) > 01200000000 && long.Parse(textBox_PhoneNo.Text) < 01299999999) ||
                    (long.Parse(textBox_PhoneNo.Text) > 01500000000 && long.Parse(textBox_PhoneNo.Text) < 01599999999))
                {
                    DialogResult Message2 = MessageBox.Show("Do you want to save the entered number first?", "Save", MessageBoxButtons.YesNo);
                    if (Message2 == DialogResult.Yes)
                    {
                        switch (priv)
                        {
                            case "Visitor":

                                S = controllerObj.Insert_Visitor_Phones(long.Parse(textBox_PhoneNo.Text), this.ID);

                                if (S > 0)
                                    MessageBox.Show("Phone Number has been added sucessfully");
                                else
                                    MessageBox.Show("Operation failed");
                                break;

                            case "Bookseller":

                                S = controllerObj.Insert_Book_Seller_Phones(long.Parse(textBox_PhoneNo.Text), this.ID);

                                if (S > 0)
                                    MessageBox.Show("Phone Number has been added sucessfully");
                                else
                                    MessageBox.Show("Operation failed");
                                break;

                            case "Media_and_Press":
                                S = controllerObj.Insert_Media_Phone(long.Parse(textBox_PhoneNo.Text), this.ID);

                                if (S > 0)
                                    MessageBox.Show("Phone Number has been added sucessfully");
                                else
                                    MessageBox.Show("Operation failed");
                                break;

                            case "Organizer":

                                S = controllerObj.Insert_Organizer_Phone(long.Parse(textBox_PhoneNo.Text), this.ID);

                                if (S > 0)
                                    MessageBox.Show("Phone Number has been added sucessfully");
                                else
                                    MessageBox.Show("Operation failed");
                                break;

                            case "Tickets_collector":

                                S = controllerObj.Insert_Ticket_Reserve_Phone(long.Parse(textBox_PhoneNo.Text), this.ID);

                                if (S > 0)
                                    MessageBox.Show("Phone Number has been added sucessfully");
                                else
                                    MessageBox.Show("Operation failed");
                                break;

                            case "Volunteer":

                                S = controllerObj.Insert_Volunter_Phones(long.Parse(textBox_PhoneNo.Text), this.ID);

                                if (S > 0)
                                    MessageBox.Show("Phone Number has been added sucessfully");
                                else
                                    MessageBox.Show("Operation failed");
                                break;

                            default:

                                MessageBox.Show("An error occured, Please try again!");
                                break;
                        }
                    }
                    else if (Message2 == DialogResult.No)
                    {
                        //do nothing
                    }
                }

                if (priv == "Visitor")
                {
                    DialogResult Message = MessageBox.Show("Do you want to Enter your Intrestes?", "Enter Your Intrestes", MessageBoxButtons.YesNo);
                    if (Message == DialogResult.Yes)
                    {
                        Visitor_Interestes Visitor_Interestes = new Visitor_Interestes(ID);
                        Visitor_Interestes.Show();
                        this.Hide();
                    }
                    else if (Message == DialogResult.No)
                    {
                        MessageBox.Show("Signed up sucessfully");
                        MessageBox.Show("Your ID is: " + ID.ToString());
                        Login_form Login_form = new Login_form();
                        Login_form.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Signed up sucessfully");
                    MessageBox.Show("Your ID is: " + ID.ToString());
                    Login_form Login_form = new Login_form();
                    Login_form.Show();
                    this.Hide();
                }
            }
            else
            {
                if (priv == "Visitor")
                {
                    DialogResult Message = MessageBox.Show("Do you want to Enter your Intrestes?", "Enter Your Intrestes", MessageBoxButtons.YesNo);
                    if (Message == DialogResult.Yes)
                    {
                        Visitor_Interestes Visitor_Interestes = new Visitor_Interestes(ID);
                        Visitor_Interestes.Show();
                        this.Hide();
                    }
                    else if (Message == DialogResult.No)
                    {
                        MessageBox.Show("Signed up sucessfully");
                        MessageBox.Show("Your ID is: " + ID.ToString());
                        Login_form Login_form = new Login_form();
                        Login_form.Show();
                        this.Hide();
                    }
                }
            }
        }
    }
}
