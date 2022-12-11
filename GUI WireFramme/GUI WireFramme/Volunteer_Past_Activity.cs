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
    public partial class Volunteer_Past_Activity : Form
    {
        int ID;
        Controller controllerObj;
        public Volunteer_Past_Activity(int id)
        {
            ID = id;
            InitializeComponent();
            controllerObj = new Controller();
            DataTable values = controllerObj.get_Events_Code();
            Working_Event_Code_comboBox.DataSource = values;
            Working_Event_Code_comboBox.DisplayMember = "Code";

            DataTable EN_Values = controllerObj.get_Events_Name();
            Event_Name_comboBox.DataSource = EN_Values;
            Event_Name_comboBox.DisplayMember = "Name";

            DataTable ELL_values = controllerObj.get_Booths_Location_Letter();
            Event_Location_letter.DataSource = ELL_values;
            Event_Location_letter.DisplayMember = "Letter";

            DataTable ELH_values = controllerObj.get_Booths_Location_Hall();
            Event_Location_Hall.DataSource = ELH_values;
            Event_Location_Hall.DisplayMember = "Hall_Number";

            DataTable ELS_values = controllerObj.get_Booths_Location_Section();
            Event_Location_Section.DataSource = ELS_values;
            Event_Location_Section.DisplayMember = "Section_Number";

            dataGridView.DataSource = controllerObj.get_ALL_Volanteer_Past_Activity(ID);
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

        private void Search_button_Click(object sender, EventArgs e)
        {
            if (Event_Code_checkBox.Checked == true)
            {
                DataTable state = controllerObj.get_Volanteer_Worked_Event(ID, int.Parse(Working_Event_Code_comboBox.Text));
                if (state == null)
                    MessageBox.Show("You haven't participated in this event!");
                else
                {
                    dataGridView.DataSource = controllerObj.get_Volanteer_Past_Activity(int.Parse(state.Rows[0][0].ToString()), ID);
                }
            }
            else if (Event_Name_checkBox.Checked == true)
            {
                DataTable data = controllerObj.get_Event_Code_ByName(Event_Name_comboBox.Text.ToString());
                int Event_Code = int.Parse(data.Rows[0][0].ToString());
                DataTable state = controllerObj.get_Volanteer_Worked_Event(ID, Event_Code);
                if (state == null)
                    MessageBox.Show("You haven't participated in this event!");
                else
                {
                    dataGridView.DataSource = controllerObj.get_Volanteer_Past_Activity(int.Parse(state.Rows[0][0].ToString()), ID);
                }
            }
            else if (Event_Location_checkBox.Checked == true)
            {
                DataTable data = controllerObj.get_Event_Code_ByLocation(Event_Location_letter.Text.ToString(), int.Parse(Event_Location_Hall.Text.ToString()), int.Parse(Event_Location_Section.Text.ToString()));
                if (data != null)
                {
                    int Event_Code = int.Parse(data.Rows[0][0].ToString());
                    DataTable state = controllerObj.get_Volanteer_Worked_Event(ID, Event_Code);
                    if (state == null)
                        MessageBox.Show("You haven't participated in this event!");
                    else
                    {
                        dataGridView.DataSource = controllerObj.get_Volanteer_Past_Activity(int.Parse(state.Rows[0][0].ToString()), ID);
                    }
                }
                else
                    MessageBox.Show("No event happened in this booth!");
            }
            if (Event_Date_checkBox.Checked == true)
            {
                DataTable data = controllerObj.get_Event_Code_ByTime(dateTimePicker.Value);
                if (data != null)
                {
                    int Event_Code = int.Parse(data.Rows[0][0].ToString());
                    DataTable state = controllerObj.get_Volanteer_Worked_Event(ID, Event_Code);
                    if (state == null)
                        MessageBox.Show("You haven't participated in this event!");
                    else
                    {
                        dataGridView.DataSource = controllerObj.get_Volanteer_Past_Activity(int.Parse(state.Rows[0][0].ToString()), ID);
                    }
                }
                else
                    MessageBox.Show("No event happened in this entered date!");
            }
        }

        private void Volunteer_Past_Activity_Load(object sender, EventArgs e)
        {

        }

        private void Search_label_Click(object sender, EventArgs e)
        {

        }

        private void Event_Code_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Event_Code_checkBox.Checked == true)
            {
                Working_Event_Code_comboBox.Enabled = true;
                Event_Name_checkBox.Checked = false;
                Event_Location_checkBox.Checked = false;
                Event_Date_checkBox.Checked = false;
                checkBox_ALL.Checked = false;
            }
            else
            {
                Working_Event_Code_comboBox.Enabled = false;
                dataGridView.DataSource = null;
            }
        }

        private void Event_Name_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Event_Name_checkBox.Checked == true)
            {
                Event_Name_comboBox.Enabled = true;
                Event_Code_checkBox.Checked = false;
                Event_Location_checkBox.Checked = false;
                Event_Date_checkBox.Checked = false;
                checkBox_ALL.Checked = false;
            }

            else
            {
                Event_Name_comboBox.Enabled = false;
                dataGridView.DataSource = null;
            }
        }

        private void Event_Location_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Event_Location_checkBox.Checked == true)
            {
                Event_Location_letter.Enabled = true;
                Event_Location_Hall.Enabled = true;
                Event_Location_Section.Enabled = true;
                Event_Code_checkBox.Checked = false;
                Event_Name_checkBox.Checked = false;
                Event_Date_checkBox.Checked = false;
                checkBox_ALL.Checked = false;
            }
            else
            {
                Event_Location_letter.Enabled = false;
                Event_Location_Hall.Enabled = false;
                Event_Location_Section.Enabled = false;
                dataGridView.DataSource = null;
            }
        }

        private void Event_Date_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Event_Date_checkBox.Checked == true)
            {
                dateTimePicker.Enabled = true;
                Event_Code_checkBox.Checked = false;
                Event_Name_checkBox.Checked = false;
                Event_Location_checkBox.Checked = false;
                checkBox_ALL.Checked = false;
            }
            else
            {
                dateTimePicker.Enabled = false;
                dataGridView.DataSource = null;
            }
        }
        private void checkBox_ALL_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ALL.Checked == true)
            {
                dataGridView.DataSource = null;
                Event_Code_checkBox.Checked = false;
                Event_Name_checkBox.Checked = false;
                Event_Location_checkBox.Checked = false;
                Event_Date_checkBox.Checked = false;
                dataGridView.DataSource = controllerObj.get_ALL_Volanteer_Past_Activity(ID);
            }
            else
                dataGridView.DataSource = null;
        }

        private void Print_Click(object sender, EventArgs e)
        {

        }
    }
}
