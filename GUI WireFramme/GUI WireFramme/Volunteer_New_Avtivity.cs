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
    public partial class Volunteer_New_Avtivity : Form
    {
        int ID;
        Controller controllerObj;
        public Volunteer_New_Avtivity(int id)
        {
            InitializeComponent();
            ID = id;
            controllerObj = new Controller();
            DataTable EN_Values = controllerObj.get_Events_Name();
            Event_Name_comboBox.DataSource = EN_Values;
            Event_Name_comboBox.DisplayMember = "Name";

            DataTable values = controllerObj.get_Events_Code();
            Working_Event_Code_comboBox.DataSource = values;
            Working_Event_Code_comboBox.DisplayMember = "Code";

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

        private void Confirm_button_Click(object sender, EventArgs e)
        {
            if (dateTimePicker_Start.Value > dateTimePicker_End.Value)
                MessageBox.Show("Your shift start time must be before Your shift end time!");


        }
    }
}
