using System;
using System.Data;
using System.Windows.Forms;

namespace Book_Fair
{
    public partial class Events : Form
    {
        Controller controllerObj;
        public Events()
        {
            InitializeComponent();
        }


        private void Events_Load_1(object sender, EventArgs e)
        {

        }

        private void Events_Back_Click(object sender, EventArgs e)
        {
            Visitor newForm = new Visitor();
            newForm.Show();
            this.Hide();
        }

        private void View_Events_Click(object sender, EventArgs e)
        {
            string item = EventDate.Items[EventDate.SelectedIndex].ToString();
            DataTable dt = controllerObj.DisplayEventsInfo(item);
            EventsData.DataSource = dt;
        }
    }
}
