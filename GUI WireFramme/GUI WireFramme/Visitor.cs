using System;
using System.Windows.Forms;

namespace Book_Fair
{
    public partial class Visitor : Form
    {
        public Visitor()
        {
            InitializeComponent();
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Visitor_Load(object sender, EventArgs e)
        {

        }


       

        private void Ticket_ReservationFormPic_Click(object sender, EventArgs e)
        {
            Ticket_Reservation newForm = new Ticket_Reservation();
            newForm.Show();
            this.Hide();
        }

        private void Publishing_HouseFormPic_Click(object sender, EventArgs e)
        {
            Publishing_House newForm = new Publishing_House();
            newForm.Show();
            this.Hide();
        }

        private void BookFormPic_Click(object sender, EventArgs e)
        {
            BookSearch newForm = new BookSearch();
            newForm.Show();
            this.Hide();
        }

        private void EventsFormPic_Click(object sender, EventArgs e)
        {
            Events newForm = new Events();
            newForm.Show();
            this.Hide();
        }

    }
}
