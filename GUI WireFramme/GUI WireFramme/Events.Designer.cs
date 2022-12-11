
namespace Book_Fair
{
    partial class Events
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>


        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Events));
            this.EventPic = new System.Windows.Forms.PictureBox();
            this.ChooseEventDate = new System.Windows.Forms.Label();
            this.EventDate = new System.Windows.Forms.ComboBox();
            this.View_Events = new System.Windows.Forms.Button();
            this.EventsData = new System.Windows.Forms.DataGridView();
            this.EventsDate = new System.Windows.Forms.DateTimePicker();
            this.Events_Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EventPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EventsData)).BeginInit();
            this.SuspendLayout();
            // 
            // EventPic
            // 
            this.EventPic.Image = ((System.Drawing.Image)(resources.GetObject("EventPic.Image")));
            this.EventPic.Location = new System.Drawing.Point(1, 3);
            this.EventPic.Name = "EventPic";
            this.EventPic.Size = new System.Drawing.Size(329, 111);
            this.EventPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EventPic.TabIndex = 0;
            this.EventPic.TabStop = false;
            // 
            // ChooseEventDate
            // 
            this.ChooseEventDate.AutoSize = true;
            this.ChooseEventDate.Location = new System.Drawing.Point(12, 142);
            this.ChooseEventDate.Name = "ChooseEventDate";
            this.ChooseEventDate.Size = new System.Drawing.Size(74, 15);
            this.ChooseEventDate.TabIndex = 4;
            this.ChooseEventDate.Text = "Choose Date";
            // 
            // EventDate
            // 
            this.EventDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EventDate.FormattingEnabled = true;
            this.EventDate.Items.AddRange(new object[] {
            "24/1/2022",
            "25/1/2022",
            "26/1/2022",
            "27/1/2022"});
            this.EventDate.Location = new System.Drawing.Point(87, 139);
            this.EventDate.Name = "EventDate";
            this.EventDate.Size = new System.Drawing.Size(95, 23);
            this.EventDate.TabIndex = 3;
            // 
            // View_Events
            // 
            this.View_Events.Location = new System.Drawing.Point(115, 183);
            this.View_Events.Name = "View_Events";
            this.View_Events.Size = new System.Drawing.Size(96, 23);
            this.View_Events.TabIndex = 5;
            this.View_Events.Text = "View Events";
            this.View_Events.UseVisualStyleBackColor = true;
            this.View_Events.Click += new System.EventHandler(this.View_Events_Click);
            // 
            // EventsData
            // 
            this.EventsData.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.EventsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EventsData.Location = new System.Drawing.Point(1, 212);
            this.EventsData.Name = "EventsData";
            this.EventsData.RowTemplate.Height = 25;
            this.EventsData.Size = new System.Drawing.Size(328, 127);
            this.EventsData.TabIndex = 6;
            // 
            // EventsDate
            // 
            this.EventsDate.Location = new System.Drawing.Point(188, 139);
            this.EventsDate.MaxDate = new System.DateTime(2022, 1, 27, 0, 0, 0, 0);
            this.EventsDate.MinDate = new System.DateTime(2022, 1, 24, 0, 0, 0, 0);
            this.EventsDate.Name = "EventsDate";
            this.EventsDate.Size = new System.Drawing.Size(141, 23);
            this.EventsDate.TabIndex = 7;
            this.EventsDate.Value = new System.DateTime(2022, 1, 27, 0, 0, 0, 0);
            // 
            // Events_Back
            // 
            this.Events_Back.Location = new System.Drawing.Point(128, 345);
            this.Events_Back.Name = "Events_Back";
            this.Events_Back.Size = new System.Drawing.Size(83, 24);
            this.Events_Back.TabIndex = 11;
            this.Events_Back.Text = "Back";
            this.Events_Back.UseVisualStyleBackColor = true;
            this.Events_Back.Click += new System.EventHandler(this.Events_Back_Click);
            // 
            // Events
            // 
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(331, 372);
            this.Controls.Add(this.Events_Back);
            this.Controls.Add(this.EventsDate);
            this.Controls.Add(this.EventsData);
            this.Controls.Add(this.View_Events);
            this.Controls.Add(this.ChooseEventDate);
            this.Controls.Add(this.EventDate);
            this.Controls.Add(this.EventPic);
            this.Name = "Events";
            this.Text = "Events";
            this.Load += new System.EventHandler(this.Events_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.EventPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EventsData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.PictureBox EventPic;
        private System.Windows.Forms.Label ChooseEventDate;
        private System.Windows.Forms.ComboBox EventDate;
        private System.Windows.Forms.Button View_Events;
        private System.Windows.Forms.DataGridView EventsData;
        private System.Windows.Forms.DateTimePicker EventsDate;
        private System.Windows.Forms.Button Events_Back;
    }
}

