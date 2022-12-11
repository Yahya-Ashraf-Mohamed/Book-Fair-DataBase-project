using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Book_Fair
{
    public partial class Visitor_Interestes : Form
    {
        Controller controllerObj;
        int ID;

        public Visitor_Interestes(int id)
        {
            this.ID = id;
            InitializeComponent();
            controllerObj = new Controller();

            checkBox_Add_Interests.Visible = true;
            checkBox_Choose_Interests.Visible = true;
            comboBox_Interests.Visible = true;
            textBox_Add_Interests.Visible = true;
            button_Add.Visible = true;
            button_Add_New.Visible = true;

            comboBox_Interests.Enabled = false;
            textBox_Add_Interests.Enabled = false;
            button_Add.Enabled = false;
            button_Add_New.Enabled = false; 
            
            DataTable All_Interests = controllerObj.Select_All_Interests();
            comboBox_Interests.DataSource = All_Interests;
            comboBox_Interests.DisplayMember = "Interest";

        }

        private void Back_label_Click(object sender, EventArgs e)
        {
            if (textBox_Add_Interests.Text == "")
            {
                MessageBox.Show("Signed up sucessfully");
                MessageBox.Show("Your ID is: " + ID.ToString());
                Login_form Login_form = new Login_form();
                Login_form.Show();
                this.Hide();
            }
            else
            {
                DialogResult Message = MessageBox.Show("Do you want to Save the entered Intereste first?", "Save!", MessageBoxButtons.YesNo);
                if (Message == DialogResult.Yes)
                {

                    if (controllerObj.Is_Interest_Exists(textBox_Add_Interests.Text.ToString()) == 0)
                    {
                        int addnew = controllerObj.Add_New_Interest(textBox_Add_Interests.Text.ToString());
                        if (addnew > 0)
                        {
                            if (controllerObj.Is_Visitor_Interest_Exists(textBox_Add_Interests.Text.ToString(), ID) > 0)
                            {
                                MessageBox.Show("This Interest already existed!");
                                MessageBox.Show("Signed up sucessfully");
                                MessageBox.Show("Your ID is: " + ID.ToString());
                                Login_form Login_form = new Login_form();
                                Login_form.Show();
                                this.Hide();
                            }
                            else
                            {
                                int state = controllerObj.Add_Visitor_Interest(textBox_Add_Interests.Text.ToString(), ID);
                                if (state > 0)
                                {
                                    MessageBox.Show("Interest has been added successfully");
                                    MessageBox.Show("Signed up sucessfully");
                                    MessageBox.Show("Your ID is: " + ID.ToString());
                                    Login_form Login_form = new Login_form();
                                    Login_form.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Operation failed");
                                    MessageBox.Show("Signed up sucessfully");
                                    MessageBox.Show("Your ID is: " + ID.ToString());
                                    Login_form Login_form = new Login_form();
                                    Login_form.Show();
                                    this.Hide();
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Faild to add new interest");
                            MessageBox.Show("Signed up sucessfully");
                            MessageBox.Show("Your ID is: " + ID.ToString());
                            Login_form Login_form = new Login_form();
                            Login_form.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        if (controllerObj.Is_Visitor_Interest_Exists(textBox_Add_Interests.Text.ToString(), ID) > 0)
                        {
                            MessageBox.Show("This Interest already existed!");
                            MessageBox.Show("Signed up sucessfully");
                            MessageBox.Show("Your ID is: " + ID.ToString());
                            Login_form Login_form = new Login_form();
                            Login_form.Show();
                            this.Hide();
                        }
                        else
                        {
                            int state = controllerObj.Add_Visitor_Interest(textBox_Add_Interests.Text.ToString(), ID);
                            if (state > 0)
                            {
                                MessageBox.Show("Interest has been added successfully");
                                MessageBox.Show("Signed up sucessfully");
                                MessageBox.Show("Your ID is: " + ID.ToString());
                                Login_form Login_form = new Login_form();
                                Login_form.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Operation failed");
                                MessageBox.Show("Signed up sucessfully");
                                MessageBox.Show("Your ID is: " + ID.ToString());
                                Login_form Login_form = new Login_form();
                                Login_form.Show();
                                this.Hide();
                            }
                        }
                    }

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

        private void checkBox_Choose_Interests_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Choose_Interests.Checked == true)
            {
                comboBox_Interests.Enabled = true;
                button_Add.Enabled = true;

                checkBox_Add_Interests.Checked = false;
                textBox_Add_Interests.Enabled = false;
                button_Add_New.Enabled = false;

            }
            else if (checkBox_Choose_Interests.Checked == false)
            {
                comboBox_Interests.Enabled = false;
                button_Add.Enabled = false;

            }

        }

        private void checkBox_Add_Interests_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Add_Interests.Checked == true)
            {
                textBox_Add_Interests.Enabled = true;
                button_Add_New.Enabled = true;

                checkBox_Choose_Interests.Checked = false;
                comboBox_Interests.Enabled = false;
                button_Add.Enabled = false;


            }
            else if (checkBox_Add_Interests.Checked == false)
            {
                textBox_Add_Interests.Enabled = false;
                button_Add_New.Enabled = false;
            }
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            
            if (controllerObj.Is_Visitor_Interest_Exists(comboBox_Interests.Text.ToString(), ID) > 0)
                MessageBox.Show("This Interest already existed!, choose another one.");
            else
            {
                int state = controllerObj.Add_Visitor_Interest(comboBox_Interests.Text.ToString(), ID);
                if (state > 0)
                {
                    MessageBox.Show("Interest has been added successfully");
                    DialogResult Message = MessageBox.Show("Do you want to Enter another Intereste?", "Again!", MessageBoxButtons.YesNo);
                    if (Message == DialogResult.Yes)
                    {
                        textBox_Add_Interests.Text = "";
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
                    MessageBox.Show("Operation failed");
            }
        }
        private void button_Add_New_Click(object sender, EventArgs e)
        {
            if (textBox_Add_Interests.Text == "")
                MessageBox.Show("Please Write down your interest first!");
            else if (controllerObj.Is_Interest_Exists(textBox_Add_Interests.Text.ToString()) == 0)
            {
                int addnew = controllerObj.Add_New_Interest(textBox_Add_Interests.Text.ToString());
                if (addnew > 0)
                {
                    if (controllerObj.Is_Visitor_Interest_Exists(textBox_Add_Interests.Text.ToString(), ID) > 0)
                        MessageBox.Show("This Interest already existed!, choose another one.");
                    else
                    {
                        int state = controllerObj.Add_Visitor_Interest(textBox_Add_Interests.Text.ToString(), ID);
                        if (state > 0)
                        {
                            MessageBox.Show("Interest has been added successfully");
                            DataTable All_Interests = controllerObj.Select_All_Interests();
                            comboBox_Interests.DataSource = All_Interests;
                            comboBox_Interests.DisplayMember = "Interest";
                            comboBox_Interests.Refresh();
                            DialogResult Message = MessageBox.Show("Do you want to Enter another Intereste?", "Again!", MessageBoxButtons.YesNo);
                            if (Message == DialogResult.Yes)
                            {
                                textBox_Add_Interests.Text = "";
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
                            MessageBox.Show("Operation failed");
                    }
                }
                else
                    MessageBox.Show("Faild to add new interest");

            }
            else
            {
                if (controllerObj.Is_Visitor_Interest_Exists(textBox_Add_Interests.Text.ToString(), ID) > 0)
                    MessageBox.Show("This Interest already existed!, choose another one.");
                else
                {
                    int state = controllerObj.Add_Visitor_Interest(textBox_Add_Interests.Text.ToString(), ID);
                    if (state > 0)
                    {
                        MessageBox.Show("Interest has been added successfully");
                        DialogResult Message = MessageBox.Show("Do you want to Enter another Intereste?", "Again!", MessageBoxButtons.YesNo);
                        if (Message == DialogResult.Yes)
                        {
                            textBox_Add_Interests.Text = "";
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
                        MessageBox.Show("Operation failed");
                }
            }
        }
    }
}
