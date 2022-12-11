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
    public partial class SignUp_2_form : Form
    {
        int ID = 0;
        int S = 0, P = 0, T = 0;
        string priv;
        Controller controllerObj;
        public SignUp_2_form(string privelage)
        {
            this.priv = privelage;
            InitializeComponent();
            controllerObj = new Controller();

            Birth_Date_label.Visible = false;
            dateTimePicker.Visible = false;
            Organization_label.Visible = false;
            Work_at_textBox.Visible = false;
            textBox_Ticket_Number.Visible = false;
            label_TicketNum.Visible = false;

            switch (priv)
            {
                case "Visitor":
                    label_NID.Visible = false;
                    textBox_NID.Visible = false;
                    Birth_Date_label.Visible = true;
                    dateTimePicker.Visible = true;
                    textBox_Ticket_Number.Visible = true;
                    label_TicketNum.Visible = true;

                    break;

                case "Media_and_Press":
                    Organization_label.Visible = true;
                    Work_at_textBox.Visible = true;
                    break;
            }
        }

        private void Back_label_Click(object sender, EventArgs e)
        {
            Sign_Up_1_Form Sign_Up_1_Form = new Sign_Up_1_Form();
            Sign_Up_1_Form.Show();
            this.Hide();
        }

        private void First_Name_textBox_TextChanged(object sender, EventArgs e)
        { }

        private void Mid_Name_textBox_TextChanged(object sender, EventArgs e)
        {}

        private void Sign_Up_button_Click(object sender, EventArgs e)
        {
            bool state = false;
            if (priv != "Visitor")
            {
                char gender = 'M';
                if (Female_radioButton.Checked == false && Male_radioButton.Checked == false)
                    MessageBox.Show("Please Choose your Gender!");
                else if (Female_radioButton.Checked == true)
                    gender = 'F';
                else if (Male_radioButton.Checked == true)
                    gender = 'M';

                if (gender == 'M' || gender == 'F')
                {
                    if (textBox_NID.Text == "")
                        MessageBox.Show("Please enter your National ID!");
                   // else if (textBox_NID.TextLength != 14 || Is_Valid_National_ID(textBox_NID.Text, gender) == false)
                     //   MessageBox.Show("Sorry, Please enter a real National ID!");
                    else if (controllerObj.Is_National_ID_Unique(long.Parse(textBox_NID.Text)) != null)
                        MessageBox.Show("Sorry, National ID Already Exists!");
                    else
                        state = true;
                }
            }
            else
            {
                if (textBox_Ticket_Number.Text == "")
                    MessageBox.Show("Please enter your Ticket Number!");
                else if (controllerObj.Is_Ticket_Used(int.Parse(textBox_Ticket_Number.Text)) != null)
                    MessageBox.Show("This Ticket has Already been used!");
                else
                    state = true;
            }
            if (state == true)
            {
                if (First_Name_textBox.Text == "")
                    MessageBox.Show("Please enter your First Name!");
                else if (Mid_Name_textBox.Text == "")
                    MessageBox.Show("Please enter your Middle Name!");
                else if (Last_Name_textBox.Text == "")
                    MessageBox.Show("Please enter your Last Name!");
                else if (Username_textBox.Text == "")
                    MessageBox.Show("Please enter your Username!");
                else if (Password_textBox.TextLength < 6)
                    MessageBox.Show("Password must be greater than 6 characters!");
                else if (textBox_Confirm_password.Text != Password_textBox.Text)
                    MessageBox.Show("Please Re-Enter your Password Correctly!");
                else if (Female_radioButton.Checked == false && Male_radioButton.Checked == false)
                    MessageBox.Show("Please Choose your Gender!");
                else if (textBox_PhoneNo.Text == "")
                    MessageBox.Show("Please Enter your phone number!");
                else if (textBox_PhoneNo.TextLength != 11 || long.Parse(textBox_PhoneNo.Text) < 01000000000 
                    || (long.Parse(textBox_PhoneNo.Text) > 01299999999 && long.Parse(textBox_PhoneNo.Text) < 01500000000)
                    || (long.Parse(textBox_PhoneNo.Text) > 01599999999 ))
                    MessageBox.Show("Please Enter a valid phone number!");
                else if (controllerObj.Is_Phone_Number_Unique(Int32.Parse(textBox_PhoneNo.Text)) != null)
                    MessageBox.Show("Sorry, this Phone Number is already used in another account!");
                else if (controllerObj.Is_Bookseller_UserName_Unique(Username_textBox.Text) != null ||
                         controllerObj.Is_Media_Man_UserName_Unique(Username_textBox.Text) != null ||
                         controllerObj.Is_Organizers_UserName_Unique(Username_textBox.Text) != null ||
                         controllerObj.Is_Ticket_Reserves_UserName_Unique(Username_textBox.Text) != null ||
                         controllerObj.Is_Visitors_UserName_Unique(Username_textBox.Text) != null ||
                         controllerObj.Is_Volunters_UserName_Unique(Username_textBox.Text) != null
                         )
                    MessageBox.Show("Sorry, Username Already Exists!");

                else
                {

                    Random R = new Random();

                    char gender;
                    DataTable isValid;


                    if (Female_radioButton.Checked == true)
                        gender = 'F';
                    else
                        gender = 'M';

                    switch (priv)
                    {
                        case "Visitor":

                            while (true)
                            {
                                ID = R.Next(500001, 599999);
                                //search on IDs in the table
                                isValid = controllerObj.Is_ID_Visitors_unique(ID);
                                if (isValid == null)
                                    break;
                            }

                            S = controllerObj.Add_New_Visitor(First_Name_textBox.Text.ToString(),
                                                                      Mid_Name_textBox.Text.ToString(),
                                                                      Last_Name_textBox.Text.ToString(),
                                                                      ID,
                                                                      gender,
                                                                      Password_textBox.Text.ToString(),
                                                                      Username_textBox.Text.ToString(),
                                                                      dateTimePicker.Value,
                                                                      1
                                                                      );
                            if (S > 0)
                            {
                                P = controllerObj.Insert_Visitor_Phones(long.Parse(textBox_PhoneNo.Text), ID);

                                if (P > 0)
                                {
                                    T = controllerObj.Use_Ticket(int.Parse(textBox_Ticket_Number.Text), ID, DateTime.Now);

                                    if (T > 0)
                                    {
                                        DialogResult Message = MessageBox.Show("Do you want to Enter another phone number?", "Enter Phone Number", MessageBoxButtons.YesNo);
                                        if (Message == DialogResult.Yes)
                                        {
                                            Phone_Numbers_SignIn phoneNumbers = new Phone_Numbers_SignIn(this.priv, ID);
                                            phoneNumbers.Show();
                                            this.Hide();
                                        }
                                        else if (Message == DialogResult.No)
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

                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Error in Entering the Ticket, Please try again!");
                                        controllerObj.Delete_Visitor_Phones(ID, long.Parse(textBox_PhoneNo.Text));
                                        controllerObj.Delete_Visitor(ID);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Phone number is invalid, Please try again!");
                                    controllerObj.Delete_Visitor(ID);
                                }
                            }
                            else
                                MessageBox.Show("Sign up failed, Please try again!");

                            break;

                        case "Bookseller":

                            while (true)
                            {
                                ID = R.Next(100001, 199999);
                                //search on IDs in the table
                                isValid = controllerObj.Is_ID_Bookseller_unique(ID);
                                if (isValid == null)
                                    break;
                            }


                            S = controllerObj.Add_New_Bookseller(First_Name_textBox.Text.ToString(),
                                                                      Mid_Name_textBox.Text.ToString(),
                                                                      Last_Name_textBox.Text.ToString(),
                                                                      ID,
                                                                      long.Parse(textBox_NID.Text),
                                                                      gender,
                                                                      Password_textBox.Text.ToString(),
                                                                      Username_textBox.Text.ToString()
                                                                      );

                            if (S > 0)
                            {
                                P = controllerObj.Insert_Book_Seller_Phones(long.Parse(textBox_PhoneNo.Text), ID);

                                if (P > 0)
                                {
                                    int AddShifts = controllerObj.Add_Book_Seller_Shifts("07:00", "17:00", ID);

                                    if (AddShifts > 0)
                                    {
                                        int AddWorkLocation = controllerObj.Add_Book_Seller_Works_IN('X', 1, 1, ID);

                                        if (AddWorkLocation > 0)
                                        {
                                            DialogResult Message = MessageBox.Show("Do you want to Enter another phone number?", "Enter Phone Number", MessageBoxButtons.YesNo);
                                            if (Message == DialogResult.Yes)
                                            {
                                                Phone_Numbers_SignIn phoneNumbers = new Phone_Numbers_SignIn(this.priv, ID);
                                                phoneNumbers.Show();
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
                                            MessageBox.Show("Error while adding your Work location!");
                                            controllerObj.Delete_Book_Seller_Shifts(ID, "07:00", "17:00");
                                            controllerObj.Delete_Bookseller_Phone(ID, long.Parse(textBox_PhoneNo.Text));
                                            controllerObj.Delete_BookSeller(ID);
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Error while adding your Shift!");
                                        controllerObj.Delete_Bookseller_Phone(ID, long.Parse(textBox_PhoneNo.Text));
                                        controllerObj.Delete_BookSeller(ID);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Phone number is invalid, Please try again!");
                                    controllerObj.Delete_BookSeller(ID);
                                }
                            }
                            else
                                MessageBox.Show("Sign up failed, Please try again!");
                            break;


                        case "Media_and_Press":

                            while (true)
                            {
                                ID = R.Next(300001, 399999);
                                //search on IDs in the table
                                isValid = controllerObj.Is_ID_Media_Man_Unique(ID);
                                if (isValid == null)
                                    break;
                            }

                            S = controllerObj.Add_New_Media_man(First_Name_textBox.Text.ToString(),
                                                                      Mid_Name_textBox.Text.ToString(),
                                                                      Last_Name_textBox.Text.ToString(),
                                                                      ID,
                                                                      long.Parse(textBox_NID.Text),
                                                                      gender,
                                                                      Work_at_textBox.Text.ToString(),
                                                                      Password_textBox.Text.ToString(),
                                                                      Username_textBox.Text.ToString()
                                                                      );

                            if (S > 0)
                            {
                                P = controllerObj.Insert_Media_Phone(long.Parse(textBox_PhoneNo.Text), ID);

                                if (P > 0)
                                {
                                    int AddMediaShifts = controllerObj.Add_Media_Shifts("07:00", "17:00", ID);

                                    if (AddMediaShifts > 0)
                                    {
                                        DialogResult Message = MessageBox.Show("Do you want to Enter another phone number?", "Enter Phone Number", MessageBoxButtons.YesNo);
                                        if (Message == DialogResult.Yes)
                                        {
                                            Phone_Numbers_SignIn phoneNumbers = new Phone_Numbers_SignIn(this.priv, ID);
                                            phoneNumbers.Show();
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
                                        MessageBox.Show("Error while adding your Shift!");
                                        controllerObj.Delete_Media_Phones(ID, long.Parse(textBox_PhoneNo.Text));
                                        controllerObj.Delete_Media_man(ID);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Phone number is invalid, Please try again!");
                                    controllerObj.Delete_Media_man(ID);
                                }
                            }
                            else
                                MessageBox.Show("Sign up failed, Please try again!");


                            break;

                        case "Organizer":

                            while (true)
                            {
                                ID = R.Next(000001, 099999);
                                //search on IDs in the table
                                isValid = controllerObj.Is_ID_Bookseller_unique(ID);
                                if (isValid == null)
                                    break;
                            }

                            S = controllerObj.Add_New_Organizer(First_Name_textBox.Text.ToString(),
                                                                      Mid_Name_textBox.Text.ToString(),
                                                                      Last_Name_textBox.Text.ToString(),
                                                                      ID,
                                                                      long.Parse(textBox_NID.Text),
                                                                      gender,
                                                                      Password_textBox.Text.ToString(),
                                                                      Username_textBox.Text.ToString()
                                                                      );

                            if (S > 0)
                            {
                                P = controllerObj.Insert_Organizer_Phone(long.Parse(textBox_PhoneNo.Text), ID);

                                if (P > 0)
                                {
                                    int AddOrganizerShifts = controllerObj.Add_Organizer_Shifts("07:00", "17:00", ID);

                                    if (AddOrganizerShifts > 0)
                                    {
                                        DialogResult Message = MessageBox.Show("Do you want to Enter another phone number?", "Enter Phone Number", MessageBoxButtons.YesNo);
                                        if (Message == DialogResult.Yes)
                                        {
                                            Phone_Numbers_SignIn phoneNumbers = new Phone_Numbers_SignIn(this.priv, ID);
                                            phoneNumbers.Show();
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
                                        MessageBox.Show("Error while adding your Shift!");
                                        controllerObj.Delete_Organizer_Phone(ID, long.Parse(textBox_PhoneNo.Text));
                                        controllerObj.Delete_Organizer(ID);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Phone number is invalid, Please try again!");
                                    controllerObj.Delete_Organizer(ID);
                                }
                            }
                            else
                                MessageBox.Show("Sign up failed, Please try again!");

                            break;

                        case "Tickets_collector":

                            while (true)
                            {
                                ID = R.Next(200001, 299999);
                                //search on IDs in the table
                                isValid = controllerObj.Is_ID_Ticket_Reserves_Unique(ID);
                                if (isValid == null)
                                    break;
                            }

                            S = controllerObj.Add_New_Ticket_Reserver(First_Name_textBox.Text.ToString(),
                                                                      Mid_Name_textBox.Text.ToString(),
                                                                      Last_Name_textBox.Text.ToString(),
                                                                      ID,
                                                                      long.Parse(textBox_NID.Text),
                                                                      gender,
                                                                      Password_textBox.Text.ToString(),
                                                                      Username_textBox.Text.ToString()
                                                                      );

                            if (S > 0)
                            {
                                P = controllerObj.Insert_Ticket_Reserve_Phone(long.Parse(textBox_PhoneNo.Text), ID);

                                if (P > 0)
                                {
                                    int AddTicketCollectorShifts = controllerObj.Add_Ticket_Reserver_Shifts("07:00", "17:00", ID);

                                    if (AddTicketCollectorShifts > 0)
                                    {
                                        DialogResult Message = MessageBox.Show("Do you want to Enter another phone number?", "Enter Phone Number", MessageBoxButtons.YesNo);
                                        if (Message == DialogResult.Yes)
                                        {
                                            Phone_Numbers_SignIn phoneNumbers = new Phone_Numbers_SignIn(this.priv, ID);
                                            phoneNumbers.Show();
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
                                        MessageBox.Show("Error while adding your Shift!");
                                        controllerObj.Delete_Ticket_Reserve_Phone(ID, long.Parse(textBox_PhoneNo.Text));
                                        controllerObj.Delete_Ticket_Reserve(ID);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Phone number is invalid, Please try again!");
                                    controllerObj.Delete_Ticket_Reserve(ID);
                                }
                            }
                            else
                                MessageBox.Show("Sign up failed, Please try again!");

                            break;

                        case "Volunteer":

                            while (true)
                            {
                                ID = R.Next(400001, 499999);
                                //search on IDs in the table
                                isValid = controllerObj.Is_ID_Volunters_unique(ID);
                                if (isValid == null)
                                    break;
                            }

                            S = controllerObj.Add_New_Volanteer(First_Name_textBox.Text.ToString(),
                                                                      Mid_Name_textBox.Text.ToString(),
                                                                      Last_Name_textBox.Text.ToString(),
                                                                      ID,
                                                                      long.Parse(textBox_NID.Text),
                                                                      gender,
                                                                      Password_textBox.Text.ToString(),
                                                                      Username_textBox.Text.ToString()
                                                                      );

                            if (S > 0)
                            {
                                P = controllerObj.Insert_Volunter_Phones(long.Parse(textBox_PhoneNo.Text), ID);
                            
                                if (P > 0)
                                {
                                    int AddVolunteerShifts = controllerObj.Add_Volanteer_Shifts("07:00", "17:00", ID);
                                    
                                    if (AddVolunteerShifts > 0)
                                    {
                                        DialogResult Message = MessageBox.Show("Do you want to Enter another phone number?", "Enter Phone Number", MessageBoxButtons.YesNo);
                                        if (Message == DialogResult.Yes)
                                        {
                                            Phone_Numbers_SignIn phoneNumbers = new Phone_Numbers_SignIn(this.priv, ID);
                                            phoneNumbers.Show();
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
                                        MessageBox.Show("Error while adding your Shift!");
                                        controllerObj.Delete_Volunter_Phones(ID, long.Parse(textBox_PhoneNo.Text));
                                        controllerObj.Delete_Volunter(ID);
                                    }
                                }
                                else
                                { 
                                    MessageBox.Show("Phone number is invalid, Please try again!");
                                    controllerObj.Delete_Volunter(ID);
                                }
                            }
                            else
                                MessageBox.Show("Sign up failed, Please try again!");

                            break;



                        default:

                            MessageBox.Show("An error occured, Please try again!");
                            break;
                    }
                }
            }
        }
        private void checkBox_Show_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Show.Checked == true)
                Password_textBox.UseSystemPasswordChar = true;
            else
                Password_textBox.UseSystemPasswordChar = false;
        }

        private bool Is_Valid_National_ID(string NID, char gender)
        {
            int[] NID_array = new int[14];

            int i = 0;
            foreach (Char c in NID)
            {
                NID_array[i] = Convert.ToInt32(c.ToString());
                i++;
            }

            int year, month, day, codeG, NofBith;

            year = NID_array[1] * 10 + NID_array[2];

            month = NID_array[3] * 10 + NID_array[4];

            day = NID_array[5] * 10 + NID_array[6];

            codeG = NID_array[7] * 10 + NID_array[8];

            NofBith = NID_array[9] * 1000 + NID_array[10] * 100 + NID_array[11] * 10 + NID_array[12];

            if (NID_array[0] == 2)
            {
                if (year > 79 && year < 100)
                {
                    if (month > 0 && month < 13)
                    {
                        if (month == 4 || month == 6 || month == 9 || month == 11)
                        {
                            if (day <= 0 || day >= 31)
                                return false;
                            else
                            {
                                if (codeG == 01 || codeG == 02 || codeG == 03 || codeG == 04 || codeG == 11 || codeG == 12 || codeG == 13 ||
                                    codeG == 14 || codeG == 15 || codeG == 16 || codeG == 17 || codeG == 18 || codeG == 19 || codeG == 21 ||
                                    codeG == 22 || codeG == 23 || codeG == 24 || codeG == 25 || codeG == 26 || codeG == 27 || codeG == 28 ||
                                    codeG == 29 || codeG == 31 || codeG == 32 || codeG == 33 || codeG == 34 || codeG == 35 || codeG == 88)
                                {
                                    if (gender == 'M')
                                    {
                                        if (NofBith % 2 == 1)
                                            return true;
                                    }
                                    else if (gender == 'F')
                                    {
                                        if (NofBith % 2 == 0)
                                            return true;
                                    }
                                }
                                else
                                    return false;
                            }
                        }
                        else if (month == 2)
                        {
                            if (day <= 0 || day >= 30)
                                return false;
                            else
                            {
                                if (codeG == 01 || codeG == 02 || codeG == 03 || codeG == 04 || codeG == 11 || codeG == 12 || codeG == 13 ||
                                    codeG == 14 || codeG == 15 || codeG == 16 || codeG == 17 || codeG == 18 || codeG == 19 || codeG == 21 ||
                                    codeG == 22 || codeG == 23 || codeG == 24 || codeG == 25 || codeG == 26 || codeG == 27 || codeG == 28 ||
                                    codeG == 29 || codeG == 31 || codeG == 32 || codeG == 33 || codeG == 34 || codeG == 35 || codeG == 88)
                                {
                                    if (gender == 'M')
                                    {
                                        if (NofBith % 2 == 1)
                                            return true;
                                    }
                                    else if (gender == 'F')
                                    {
                                        if (NofBith % 2 == 0)
                                            return true;
                                    }
                                }
                                else
                                    return false;
                            }
                        }
                        else if (day > 0 && day < 32)
                        {
                            if (codeG == 01 || codeG == 02 || codeG == 03 || codeG == 04 || codeG == 11 || codeG == 12 || codeG == 13 ||
                                codeG == 14 || codeG == 15 || codeG == 16 || codeG == 17 || codeG == 18 || codeG == 19 || codeG == 21 ||
                                codeG == 22 || codeG == 23 || codeG == 24 || codeG == 25 || codeG == 26 || codeG == 27 || codeG == 28 ||
                                codeG == 29 || codeG == 31 || codeG == 32 || codeG == 33 || codeG == 34 || codeG == 35 || codeG == 88)
                            {
                                if (gender == 'M')
                                {
                                    if (NofBith % 2 == 1)
                                        return true;
                                }
                                else if (gender == 'F')
                                {
                                    if (NofBith % 2 == 0)
                                        return true;
                                }
                            }
                            else
                                return false;
                        }
                    }
                }
            }
            else if (NID_array[0] == 3)
            {
                if (year > -1 && year < 13)
                {
                    if (month > 0 && month < 13)
                    {
                        if (month == 4 || month == 6 || month == 9 || month == 11)
                        {
                            if (day <= 0 || day >= 31)
                                return false;
                            else
                            {
                                if (codeG == 01 || codeG == 02 || codeG == 03 || codeG == 04 || codeG == 11 || codeG == 12 || codeG == 13 ||
                                    codeG == 14 || codeG == 15 || codeG == 16 || codeG == 17 || codeG == 18 || codeG == 19 || codeG == 21 ||
                                    codeG == 22 || codeG == 23 || codeG == 24 || codeG == 25 || codeG == 26 || codeG == 27 || codeG == 28 ||
                                    codeG == 29 || codeG == 31 || codeG == 32 || codeG == 33 || codeG == 34 || codeG == 35 || codeG == 88)
                                {
                                    if (gender == 'M')
                                    {
                                        if (NofBith % 2 == 1)
                                            return true;
                                    }
                                    else if (gender == 'F')
                                    {
                                        if (NofBith % 2 == 0)
                                            return true;
                                    }
                                }
                                else
                                    return false;
                            }
                        }
                        else if (month == 2)
                        {
                            if (day <= 0 || day >= 30)
                                return false;
                            else
                            {
                                if (codeG == 01 || codeG == 02 || codeG == 03 || codeG == 04 || codeG == 11 || codeG == 12 || codeG == 13 ||
                                    codeG == 14 || codeG == 15 || codeG == 16 || codeG == 17 || codeG == 18 || codeG == 19 || codeG == 21 ||
                                    codeG == 22 || codeG == 23 || codeG == 24 || codeG == 25 || codeG == 26 || codeG == 27 || codeG == 28 ||
                                    codeG == 29 || codeG == 31 || codeG == 32 || codeG == 33 || codeG == 34 || codeG == 35 || codeG == 88)
                                {
                                    if (gender == 'M')
                                    {
                                        if (NofBith % 2 == 1)
                                            return true;
                                    }
                                    else if (gender == 'F')
                                    {
                                        if (NofBith % 2 == 0)
                                            return true;
                                    }
                                }
                                else
                                    return false;
                            }
                        }
                        else if (day > 0 && day < 32)
                        {
                            if (codeG == 01 || codeG == 02 || codeG == 03 || codeG == 04 || codeG == 11 || codeG == 12 || codeG == 13 ||
                                codeG == 14 || codeG == 15 || codeG == 16 || codeG == 17 || codeG == 18 || codeG == 19 || codeG == 21 ||
                                codeG == 22 || codeG == 23 || codeG == 24 || codeG == 25 || codeG == 26 || codeG == 27 || codeG == 28 ||
                                codeG == 29 || codeG == 31 || codeG == 32 || codeG == 33 || codeG == 34 || codeG == 35 || codeG == 88)
                            {
                                if (gender == 'M')
                                {
                                    if (NofBith % 2 == 1)
                                        return true;
                                }
                                else if (gender == 'F')
                                {
                                    if (NofBith % 2 == 0)
                                        return true;
                                }
                            }
                            else
                                return false;
                        }
                    }
                
                }
            }
            return false;
        }
    }
}