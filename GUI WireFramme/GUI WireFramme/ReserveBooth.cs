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
    public partial class ReserveBooth : Form
    {
        public ReserveBooth()
        {
            InitializeComponent();
        }

        private void ReserveBooth_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Reversed Successfully");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            BookSeller newForm = new BookSeller();
            newForm.Show();
            this.Hide();
        }

        private void BoothSearch_button_Click(object sender, EventArgs e)
        {
            BoothRev_button.Visible = true;
        }
    }
}
