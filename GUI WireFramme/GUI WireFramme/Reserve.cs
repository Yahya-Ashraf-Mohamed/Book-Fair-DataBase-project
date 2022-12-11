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
    public partial class Reserve : Form
    {
        public Reserve()
        {
            InitializeComponent();
        }
        public bool IsNumeric(string value)
        {
            return value.All(char.IsNumber);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string[] time = date.Text.Split('-');
            string[] from = time[0].Split(':');
            string[] to = time[1].Split(':');
            string from_min = from[0];
            string from_sec = from[1];
            string to_min = to[0];
            string to_sec = to[1];
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int nattendees = 0;
            string s = this.nattendees.Text;
            bool result = int.TryParse(s, out nattendees);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nattendees.Text))
            {
                MessageBox.Show("Number of attendees should not be left blank!");
            }

            else if (!nattendees.Text.All(Char.IsDigit))
            {
                MessageBox.Show("Only digits allowed in n.attendees");
            }

            else if (string.IsNullOrWhiteSpace(date.Text))
            {
                MessageBox.Show("Date should not be left blank!");
            }
            else if (string.IsNullOrWhiteSpace(starttime.Text))
            {
                MessageBox.Show("Time should not be left blank!");
            }


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string[] date = this.date.Text.Split('-');
            string dd = date[0];
            string mm = date[1];
            string yy = date[2];
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
