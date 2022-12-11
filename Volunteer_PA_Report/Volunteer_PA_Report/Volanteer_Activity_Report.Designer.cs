
namespace Volunteer_Past_Activites_Report
{
    partial class Volanteer_Activity_Report
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Volunteer_Report = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.Volanteer_Report1 = new Volunteer_Past_Activites_Report.Volanteer_Report();
            this.Participated_Events_data1 = new Volunteer_Past_Activites_Report.Participated_Events_data();
            this.SuspendLayout();
            // 
            // Volunteer_Report
            // 
            this.Volunteer_Report.ActiveViewIndex = 0;
            this.Volunteer_Report.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Volunteer_Report.Cursor = System.Windows.Forms.Cursors.Default;
            this.Volunteer_Report.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Volunteer_Report.Location = new System.Drawing.Point(0, 0);
            this.Volunteer_Report.Name = "Volunteer_Report";
            this.Volunteer_Report.ReportSource = this.Participated_Events_data1;
            this.Volunteer_Report.Size = new System.Drawing.Size(800, 450);
            this.Volunteer_Report.TabIndex = 0;
            this.Volunteer_Report.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // Volanteer_Activity_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Volunteer_Report);
            this.Name = "Volanteer_Activity_Report";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer Volunteer_Report;
        private Volanteer_Report Volanteer_Report1;
        private Participated_Events_data Participated_Events_data1;
    }
}

