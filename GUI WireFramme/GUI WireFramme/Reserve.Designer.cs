namespace Book_Fair
{
    partial class Reserve
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.hallnumber = new System.Windows.Forms.ComboBox();
            this.letter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sectionnumber = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.TextBox();
            this.starttime = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.reservebutton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.endtime = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.code = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.leaderid = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nattendees = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hall Number";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // hallnumber
            // 
            this.hallnumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hallnumber.FormattingEnabled = true;
            this.hallnumber.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.hallnumber.Location = new System.Drawing.Point(170, 25);
            this.hallnumber.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.hallnumber.Name = "hallnumber";
            this.hallnumber.Size = new System.Drawing.Size(121, 23);
            this.hallnumber.TabIndex = 1;
            // 
            // letter
            // 
            this.letter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.letter.FormattingEnabled = true;
            this.letter.Items.AddRange(new object[] {
            "a",
            "b",
            "c"});
            this.letter.Location = new System.Drawing.Point(170, 80);
            this.letter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.letter.Name = "letter";
            this.letter.Size = new System.Drawing.Size(121, 23);
            this.letter.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(34, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Letter";
            // 
            // sectionnumber
            // 
            this.sectionnumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sectionnumber.FormattingEnabled = true;
            this.sectionnumber.Location = new System.Drawing.Point(170, 125);
            this.sectionnumber.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sectionnumber.Name = "sectionnumber";
            this.sectionnumber.Size = new System.Drawing.Size(121, 23);
            this.sectionnumber.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(5, 126);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Section Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(308, 62);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Date (YYYY-MM-DD)";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(508, 65);
            this.date.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(100, 23);
            this.date.TabIndex = 11;
            this.date.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // starttime
            // 
            this.starttime.Location = new System.Drawing.Point(508, 103);
            this.starttime.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.starttime.Name = "starttime";
            this.starttime.Size = new System.Drawing.Size(100, 23);
            this.starttime.TabIndex = 13;
            this.starttime.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(327, 100);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 22);
            this.label6.TabIndex = 12;
            this.label6.Text = "Start (hh:mm:ss)\r\n";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // reservebutton
            // 
            this.reservebutton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.reservebutton.Location = new System.Drawing.Point(215, 188);
            this.reservebutton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.reservebutton.Name = "reservebutton";
            this.reservebutton.Size = new System.Drawing.Size(135, 31);
            this.reservebutton.TabIndex = 14;
            this.reservebutton.Text = "Reserve";
            this.reservebutton.UseVisualStyleBackColor = true;
            this.reservebutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // endtime
            // 
            this.endtime.Location = new System.Drawing.Point(508, 136);
            this.endtime.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.endtime.Name = "endtime";
            this.endtime.Size = new System.Drawing.Size(100, 23);
            this.endtime.TabIndex = 16;
            this.endtime.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(337, 136);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 22);
            this.label7.TabIndex = 15;
            this.label7.Text = "End (hh:mm:ss)\r\n";
            // 
            // code
            // 
            this.code.Location = new System.Drawing.Point(448, 192);
            this.code.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(52, 23);
            this.code.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(445, 167);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 22);
            this.label8.TabIndex = 17;
            this.label8.Text = "code";
            // 
            // leaderid
            // 
            this.leaderid.Location = new System.Drawing.Point(511, 192);
            this.leaderid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.leaderid.Name = "leaderid";
            this.leaderid.Size = new System.Drawing.Size(97, 23);
            this.leaderid.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(511, 167);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 22);
            this.label9.TabIndex = 19;
            this.label9.Text = "Leader Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(341, 26);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "N.Attendees";
            // 
            // nattendees
            // 
            this.nattendees.Location = new System.Drawing.Point(508, 29);
            this.nattendees.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nattendees.Name = "nattendees";
            this.nattendees.Size = new System.Drawing.Size(100, 23);
            this.nattendees.TabIndex = 10;
            this.nattendees.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Reserve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(621, 232);
            this.Controls.Add(this.leaderid);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.code);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.endtime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.reservebutton);
            this.Controls.Add(this.starttime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.date);
            this.Controls.Add(this.nattendees);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sectionnumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.letter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hallnumber);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Reserve";
            this.Text = "Reserve A Room";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox hallnumber;
        private System.Windows.Forms.ComboBox letter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox sectionnumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox date;
        private System.Windows.Forms.TextBox starttime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button reservebutton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox endtime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox leaderid;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox code;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox nattendees;
        private System.Windows.Forms.Label label4;
    }
}