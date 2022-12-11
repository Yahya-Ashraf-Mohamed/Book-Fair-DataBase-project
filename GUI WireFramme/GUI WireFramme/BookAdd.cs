using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Book_Fair
{
    public partial class BookAdd : Form
    {
        Controller controllerObj = new Controller();
        public BookAdd()
        {
            InitializeComponent();
        }

        private void Add_button1_Click(object sender, EventArgs e)
        {
            controllerObj.AddBook(title_textBox.Text, author_textBox.Text, Convert.ToInt32(price_textBox.Text), offer_textBox.Text, Convert.ToBoolean(available_textBox.Text), series_textBox1.Text, category_textBox3.Text, Convert.ToInt32(copies_textBox2.Text));
            MessageBox.Show("Book Added");
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
