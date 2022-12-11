using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net.Mail;
using System.ComponentModel.DataAnnotations;

namespace Book_Fair

{
    public partial class Ticket_Reservation : Form
    {
        public Ticket_Reservation()
        {
            InitializeComponent();
        }

        private void Ticket_Reservation_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Reserve_Click(object sender, EventArgs e)
        {
            if(Number.Text.Length==0 && Email.Text.Length==0)
            {
                MessageBox.Show("Please enter a phone number or email address");
            }


            if (Book_Fair.Email.Valid(Email.Text) == true || PhoneNumber.IsPhoneNumber(Number.Text)==true)
            {
                MessageBox.Show("Nice Our Fawry Account is ");
            }

            if (Book_Fair.Email.Valid(Email.Text) == true || PhoneNumber.IsPhoneNumber(Number.Text) == true && FawryCode.Text == "23") {
                MessageBox.Show("Confirmed, Our Ticket ID is ");
            }

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Ticket_Back_Click(object sender, EventArgs e)
        {
            Visitor newForm = new Visitor();
            newForm.Show();
            this.Hide();
        }




        public static class PhoneNumber
        {
            public const string motif = @"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{5})$";
            public static bool IsPhoneNumber(string number)
            {
                if (number != null)
                    return Regex.IsMatch(number, motif);
                else
                    return false;
            }
        }


        public static bool ValidEmail(string email)
        {
            return new EmailAddressAttribute().IsValid(email);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Ticket_Reservation_Load_1(object sender, EventArgs e)
        {

        }
    }
    public static class Email
    {
        public static bool Valid(string email)
        {
            try
            {
                MailAddress mail = new MailAddress(email);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}