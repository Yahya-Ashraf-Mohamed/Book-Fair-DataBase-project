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
    public partial class Volunteer_Edit : Form
    {
        int ID;
        string FName, MName, LName, UserName, Sex;
        Controller controllerObj;
        public Volunteer_Edit(int id)
        {
            ID = id;
            controllerObj = new Controller();
            InitializeComponent();
            First_Name_textBox.Text = controllerObj.get_Volunteer(ID).Rows[0][0].ToString();
            Mid_Name_textBox.Text = controllerObj.get_Volunteer(ID).Rows[0][1].ToString();
            Last_Name_textBox.Text = controllerObj.get_Volunteer(ID).Rows[0][2].ToString();
            Username_textBox.Text = controllerObj.get_Volunteer(ID).Rows[0][11].ToString();
            V_ID.Text = controllerObj.get_Volunteer(ID).Rows[0][3].ToString();
            National_ID.Text = controllerObj.get_Volunteer(ID).Rows[0][5].ToString();
            
            if (controllerObj.get_Volunteer(ID).Rows[0][7].ToString() == "M")
            {
                Male_radioButton.Checked = true;
                Sex = "M";
            }
            else
            {
                Female_radioButton.Checked = true;
                Sex = "F";
            }

            int Phone_counter = controllerObj.Count_Num_volunteer_phone(ID);
            if (Phone_counter == 0)
                Volunteer_Phone_label.Text = "NO Phone existed.";
            else if (Phone_counter > 0)
            {
                for (int i = 0; i < Phone_counter; i++)
                {
                    Volunteer_Phone_label.Text += "0" + controllerObj.Select_Volunteer_All_PhoneNumbers(ID).Rows[i][0].ToString() + Environment.NewLine;
                }
            }

            FName = First_Name_textBox.Text.ToString();
            MName = Mid_Name_textBox.Text.ToString();
            LName = Last_Name_textBox.Text.ToString();
            UserName = Username_textBox.Text.ToString();
            
        }

        private void Log_out_label_Click(object sender, EventArgs e)
        {
            Login_form Login_form = new Login_form();
            Login_form.Show();
            this.Hide();
        }

        private void Back_label_Click(object sender, EventArgs e)
        {
            Volunteer Volunteer = new Volunteer(ID);
            Volunteer.Show();
            this.Hide();
        }

        private void Save_button_Click(object sender, EventArgs e)
        {
            string Message = "";

            if (First_Name_textBox.Text == "")
                MessageBox.Show("You must enter your First name");
            else if (Mid_Name_textBox.Text == "")
                MessageBox.Show("You must enter your Middle name");
            else if (Last_Name_textBox.Text == "")
                MessageBox.Show("You must enter your Last name");
            else if (Username_textBox.Text == "")
                MessageBox.Show("You must enter your Username");
            else
            {
                if (First_Name_textBox.Text != FName)
                    Message = Message + "First Name Have Changed";
                else if (Mid_Name_textBox.Text != MName)
                    Message = Message + "\nMiddle Name Have Changed";
                else if (Last_Name_textBox.Text != LName)
                    Message = Message + "\nLast Name Have Changed";

                else if (controllerObj.Is_Bookseller_UserName_Unique(Username_textBox.Text) != null ||
                         controllerObj.Is_Media_Man_UserName_Unique(Username_textBox.Text) != null ||
                         controllerObj.Is_Organizers_UserName_Unique(Username_textBox.Text) != null ||
                         controllerObj.Is_Ticket_Reserves_UserName_Unique(Username_textBox.Text) != null ||
                         controllerObj.Is_Visitors_UserName_Unique(Username_textBox.Text) != null ||
                         controllerObj.Is_Volunters_UserName_Unique(Username_textBox.Text) != null
                         )
                    MessageBox.Show("Sorry, Username Already Exists!");
                else if (Username_textBox.Text != UserName)
                    Message = Message + "\nUsername Have Changed";
            
                else if (Male_radioButton.Checked != true && Sex == "M")
                    Message = Message + "\nSex Have Changed";
                else if (Female_radioButton.Checked != true && Sex == "F")
                    Message = Message + "\nSex Have Changed";

                int state = controllerObj.Update_Volunteer_Info(ID,
                                                    First_Name_textBox.Text.ToString(),
                                                    Mid_Name_textBox.Text.ToString(),
                                                    Last_Name_textBox.Text.ToString(),
                                                    Username_textBox.Text.ToString(),
                                                    Sex.ToString()
                                                    );
                if (state > 0)
                {
                    MessageBox.Show("Operation done successfully!\n" + Message);
                    First_Name_textBox.Text = controllerObj.get_Volunteer(ID).Rows[0][0].ToString();
                    Mid_Name_textBox.Text = controllerObj.get_Volunteer(ID).Rows[0][1].ToString();
                    Last_Name_textBox.Text = controllerObj.get_Volunteer(ID).Rows[0][2].ToString();
                    Username_textBox.Text = controllerObj.get_Volunteer(ID).Rows[0][11].ToString();
                    V_ID.Text = controllerObj.get_Volunteer(ID).Rows[0][3].ToString();
                    National_ID.Text = controllerObj.get_Volunteer(ID).Rows[0][5].ToString();
                    
                    if (controllerObj.get_Volunteer(ID).Rows[0][7].ToString() == "M")
                    {
                        Male_radioButton.Checked = true;
                        Sex = "M";
                    }
                    else
                    {
                        Female_radioButton.Checked = true;
                        Sex = "F";
                    }
                }
                else
                    MessageBox.Show("Operation Failed");
            }
        }

        private void button_Change_password_Click(object sender, EventArgs e)
        {
            Reset_Password Reset_Password = new Reset_Password(ID, "Volunteer");
            Reset_Password.Show();
            this.Hide();   
        }

        private void button_Change_Phone_Number_Click(object sender, EventArgs e)
        {
            Change_phone_number Change_phone_number = new Change_phone_number(ID, "Volunteer");
            Change_phone_number.Show();
            this.Hide();
        }
    }
}
