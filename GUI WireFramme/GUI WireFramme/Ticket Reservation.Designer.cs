
namespace Book_Fair
{
    partial class Ticket_Reservation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ticket_Reservation));
            this.TicketReservationPic = new System.Windows.Forms.PictureBox();
            this.TicketsDate = new System.Windows.Forms.ComboBox();
            this.ChooseTicketDate = new System.Windows.Forms.Label();
            this.Reserve = new System.Windows.Forms.Button();
            this.WhatsNumber = new System.Windows.Forms.Label();
            this.Number = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.EmailAddress = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TicketDate = new System.Windows.Forms.DateTimePicker();
            this.Ticket_Back = new System.Windows.Forms.Button();
            this.Fawry = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.FawryCode = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.TicketReservationPic)).BeginInit();
            this.SuspendLayout();
            // 
            // TicketReservationPic
            // 
            this.TicketReservationPic.Image = ((System.Drawing.Image)(resources.GetObject("TicketReservationPic.Image")));
            this.TicketReservationPic.Location = new System.Drawing.Point(1, 1);
            this.TicketReservationPic.Name = "TicketReservationPic";
            this.TicketReservationPic.Size = new System.Drawing.Size(335, 143);
            this.TicketReservationPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TicketReservationPic.TabIndex = 0;
            this.TicketReservationPic.TabStop = false;
            // 
            // TicketsDate
            // 
            this.TicketsDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TicketsDate.FormattingEnabled = true;
            this.TicketsDate.Items.AddRange(new object[] {
            "24/1/2022",
            "25/1/2022",
            "26/1/2022",
            "27/1/2022"});
            this.TicketsDate.Location = new System.Drawing.Point(168, 196);
            this.TicketsDate.Name = "TicketsDate";
            this.TicketsDate.Size = new System.Drawing.Size(121, 23);
            this.TicketsDate.TabIndex = 1;
            // 
            // ChooseTicketDate
            // 
            this.ChooseTicketDate.AutoSize = true;
            this.ChooseTicketDate.Location = new System.Drawing.Point(53, 196);
            this.ChooseTicketDate.Name = "ChooseTicketDate";
            this.ChooseTicketDate.Size = new System.Drawing.Size(31, 15);
            this.ChooseTicketDate.TabIndex = 2;
            this.ChooseTicketDate.Text = "Date";
            // 
            // Reserve
            // 
            this.Reserve.Location = new System.Drawing.Point(59, 374);
            this.Reserve.Name = "Reserve";
            this.Reserve.Size = new System.Drawing.Size(75, 32);
            this.Reserve.TabIndex = 3;
            this.Reserve.Text = "Reserve";
            this.Reserve.UseVisualStyleBackColor = true;
            this.Reserve.Click += new System.EventHandler(this.Reserve_Click);
            // 
            // WhatsNumber
            // 
            this.WhatsNumber.AutoSize = true;
            this.WhatsNumber.Location = new System.Drawing.Point(32, 239);
            this.WhatsNumber.Name = "WhatsNumber";
            this.WhatsNumber.Size = new System.Drawing.Size(102, 15);
            this.WhatsNumber.TabIndex = 4;
            this.WhatsNumber.Text = "WhatsUp Number";
            // 
            // Number
            // 
            this.Number.BackColor = System.Drawing.SystemColors.Window;
            this.Number.Location = new System.Drawing.Point(168, 239);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(121, 23);
            this.Number.TabIndex = 5;
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(168, 289);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(121, 23);
            this.Email.TabIndex = 6;
            // 
            // EmailAddress
            // 
            this.EmailAddress.AutoSize = true;
            this.EmailAddress.Location = new System.Drawing.Point(44, 297);
            this.EmailAddress.Name = "EmailAddress";
            this.EmailAddress.Size = new System.Drawing.Size(81, 15);
            this.EmailAddress.TabIndex = 7;
            this.EmailAddress.Text = "Email Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "or";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // TicketDate
            // 
            this.TicketDate.Location = new System.Drawing.Point(168, 161);
            this.TicketDate.MaxDate = new System.DateTime(2022, 1, 27, 0, 0, 0, 0);
            this.TicketDate.MinDate = new System.DateTime(2022, 1, 24, 0, 0, 0, 0);
            this.TicketDate.Name = "TicketDate";
            this.TicketDate.Size = new System.Drawing.Size(121, 23);
            this.TicketDate.TabIndex = 9;
            this.TicketDate.Value = new System.DateTime(2022, 1, 27, 0, 0, 0, 0);
            this.TicketDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Ticket_Back
            // 
            this.Ticket_Back.Location = new System.Drawing.Point(194, 374);
            this.Ticket_Back.Name = "Ticket_Back";
            this.Ticket_Back.Size = new System.Drawing.Size(75, 32);
            this.Ticket_Back.TabIndex = 10;
            this.Ticket_Back.Text = "Back";
            this.Ticket_Back.UseVisualStyleBackColor = true;
            this.Ticket_Back.Click += new System.EventHandler(this.Ticket_Back_Click);
            // 
            // Fawry
            // 
            this.Fawry.AutoSize = true;
            this.Fawry.Location = new System.Drawing.Point(44, 333);
            this.Fawry.Name = "Fawry";
            this.Fawry.Size = new System.Drawing.Size(72, 15);
            this.Fawry.TabIndex = 11;
            this.Fawry.Text = "Fawry Code ";
            this.Fawry.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 356);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "( After payment to confirm)";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FawryCode
            // 
            this.FawryCode.Location = new System.Drawing.Point(168, 333);
            this.FawryCode.Name = "FawryCode";
            this.FawryCode.Size = new System.Drawing.Size(121, 23);
            this.FawryCode.TabIndex = 13;
            // 
            // Ticket_Reservation
            // 
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(337, 404);
            this.Controls.Add(this.FawryCode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Fawry);
            this.Controls.Add(this.Ticket_Back);
            this.Controls.Add(this.TicketDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EmailAddress);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.WhatsNumber);
            this.Controls.Add(this.Reserve);
            this.Controls.Add(this.ChooseTicketDate);
            this.Controls.Add(this.TicketsDate);
            this.Controls.Add(this.TicketReservationPic);
            this.Name = "Ticket_Reservation";
            this.Text = "Ticket Reservation";
            this.Load += new System.EventHandler(this.Ticket_Reservation_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.TicketReservationPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.PictureBox TicketReservationPic;
        private System.Windows.Forms.ComboBox TicketsDate;
        private System.Windows.Forms.Label ChooseTicketDate;
        private System.Windows.Forms.Button Reserve;
        private System.Windows.Forms.Label WhatsNumber;
        private System.Windows.Forms.TextBox Number;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Label EmailAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker TicketDate;
        private System.Windows.Forms.Button Ticket_Back;
        private System.Windows.Forms.Label Fawry;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox FawryCode;
    }
}

