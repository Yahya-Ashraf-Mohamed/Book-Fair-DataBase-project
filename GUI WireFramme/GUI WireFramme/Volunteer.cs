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
    public partial class Volunteer : Form
    {
        Controller controllerObj;
        int ID;
        public Volunteer(int id)
        {
            InitializeComponent();
            ID = id;
            controllerObj = new Controller();

            Volunteer_Name_label.Text = controllerObj.get_Volunteer(ID).Rows[0][0].ToString();
            Volanteer_Name_label.Text = controllerObj.get_Volunteer(ID).Rows[0][0].ToString() + " " +
                                        controllerObj.get_Volunteer(ID).Rows[0][1].ToString() + " " +
                                        controllerObj.get_Volunteer(ID).Rows[0][2].ToString() +" ";
            Volunteer_ID_label.Text = controllerObj.get_Volunteer(ID).Rows[0][3].ToString();
            Position.Text = controllerObj.get_Volunteer(ID).Rows[0][11].ToString();

            Salary.Text = controllerObj.get_Volunteer(ID).Rows[0][6].ToString();
            Category.Text = controllerObj.get_Volunteer(ID).Rows[0][12].ToString();
            Supervisor.Text = controllerObj.get_User_Name(ID).Rows[0][0].ToString() + " " + controllerObj.get_User_Name(ID).Rows[0][1].ToString() + " " + controllerObj.get_User_Name(ID).Rows[0][2].ToString();

            Position.Text = controllerObj.get_Volunteer(ID).Rows[0][9].ToString();
            
            int Shifts_counter = controllerObj.Count_Num_volunteer_shifts(ID);
            if (Shifts_counter == 0)
                Volunteer_Shift_Times_label.Text = "NO Working hours existed right now.";
            else if (Shifts_counter > 0)
            {
                for (int i = 0; i < Shifts_counter; i++)
                {
                    Volunteer_Shift_Times_label.Text += controllerObj.get_Volunteer_Shifts(ID).Rows[i][0].ToString() + "-->" +
                                                         controllerObj.get_Volunteer_Shifts(ID).Rows[i][1].ToString() +
                                                         Environment.NewLine;
                }
                   
            }

            DataTable Working_Event = controllerObj.get_Event(int.Parse(controllerObj.get_Volunteer(ID).Rows[0][8].ToString()));

            Volunteer_Event_Name_label.Text = Working_Event.Rows[0][0].ToString();
            Event_Code_label.Text = Working_Event.Rows[0][2].ToString();
            Event_Subject_label.Text = Working_Event.Rows[0][1].ToString();
            Event_Location_label.Text = Working_Event.Rows[0][8].ToString() + "-" +
                                        Working_Event.Rows[0][10].ToString() + "-" +
                                        Working_Event.Rows[0][9].ToString();


            dateTimePicker_Date.Value = Convert.ToDateTime(Working_Event.Rows[0][4]);
            dateTimePicker_Start.Value = Convert.ToDateTime(Working_Event.Rows[0][5].ToString());
            dateTimePicker_End.Value = Convert.ToDateTime(Working_Event.Rows[0][6].ToString());
        }

        private void Log_out_label_Click(object sender, EventArgs e)
        {
            Login_form Login_form = new Login_form();
            Login_form.Show();
            this.Hide();
        }

        private void Back_label_Click(object sender, EventArgs e)
        {
            Login_form Login_form = new Login_form();
            Login_form.Show();
            this.Hide();
        }

        private void Edit_button_Click(object sender, EventArgs e)
        {
            Volunteer_Edit Volunteer_Edit = new Volunteer_Edit(ID);
            Volunteer_Edit.Show();
            this.Hide();
            
        }

        private void Add_New_Activity_button_Click(object sender, EventArgs e)
        {
            Volunteer_New_Avtivity Volunteer_New_Avtivity = new Volunteer_New_Avtivity(ID);
            Volunteer_New_Avtivity.Show();
            this.Hide();
        }

        private void Review_past_activity_button_Click(object sender, EventArgs e)
        {
            Volunteer_Past_Activity Volunteer_Past_Activity = new Volunteer_Past_Activity(ID);
            Volunteer_Past_Activity.Show();
            this.Hide();
        }
    }
}
