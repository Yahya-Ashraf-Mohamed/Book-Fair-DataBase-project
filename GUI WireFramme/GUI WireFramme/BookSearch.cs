
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace Book_Fair
{
    public partial class BookSearch : Form
    {
        Controller controllerObj = new Controller();
        string Book_Name;
        public BookSearch()
        {
            InitializeComponent();
            controllerObj = new Controller();
            DataTable dt = controllerObj.SelectBookTitle();
            Book_combobox.DataSource = dt;
            Book_combobox.DisplayMember = "Book_Name";
        }

        private void book_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Book_combobox.Text))//validation part
            {
                MessageBox.Show("Please choose a Book");
            }
            else
            {
                DataTable dt = controllerObj.DisplayBookInfo(Book_combobox.Text);
            }
            BookInfo newForm = new BookInfo();
            newForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BookSeller newForm = new BookSeller();
            newForm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
        //controllerObj.searchBook(Book_Name);

        //BookInfo newForm = new BookInfo();
        //newForm.Show();
        //this.Hide();
    }

        

        /*private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Book_combobox.Text = Book_Name;
        }*/

    }

