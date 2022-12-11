using System;
using System.Windows.Forms;

namespace Book_Fair
{
    public partial class Publishing_House : Form
    {
        public Publishing_House()
        {
            InitializeComponent();
        }
   

        private void Publishing_House_Load_1(object sender, EventArgs e)
        {

       
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Hall: 2\n Letter: A\n Section: 23 \n");
        }

        private void Publishing_Back_Click(object sender, EventArgs e)
        {
            Visitor newForm = new Visitor();
            newForm.Show();
            this.Hide();
        }
    }
}
