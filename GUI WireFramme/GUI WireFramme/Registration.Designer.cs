
namespace Book_Fair
{
    partial class Registration
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
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.ticket_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.id_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.enter_button = new System.Windows.Forms.Button();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(14, 249);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(88, 40);
            this.button5.TabIndex = 38;
            this.button5.Text = "Log Out";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(305, 249);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 40);
            this.button3.TabIndex = 37;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ticket_textBox
            // 
            this.ticket_textBox.Location = new System.Drawing.Point(241, 131);
            this.ticket_textBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ticket_textBox.Name = "ticket_textBox";
            this.ticket_textBox.Size = new System.Drawing.Size(107, 27);
            this.ticket_textBox.TabIndex = 36;
            this.ticket_textBox.TextChanged += new System.EventHandler(this.ticket_textBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(56, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 25);
            this.label3.TabIndex = 35;
            this.label3.Text = "Ticket Number";
            // 
            // id_textBox
            // 
            this.id_textBox.Location = new System.Drawing.Point(241, 79);
            this.id_textBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.id_textBox.Name = "id_textBox";
            this.id_textBox.Size = new System.Drawing.Size(107, 27);
            this.id_textBox.TabIndex = 34;
            this.id_textBox.TextChanged += new System.EventHandler(this.id_textBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(97, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 25);
            this.label2.TabIndex = 33;
            this.label2.Text = "ID";
            // 
            // enter_button
            // 
            this.enter_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.enter_button.Location = new System.Drawing.Point(145, 191);
            this.enter_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.enter_button.Name = "enter_button";
            this.enter_button.Size = new System.Drawing.Size(107, 41);
            this.enter_button.TabIndex = 32;
            this.enter_button.Text = "Entered";
            this.enter_button.UseVisualStyleBackColor = true;
            this.enter_button.Click += new System.EventHandler(this.enter_button_Click);
            // 
            // name_textBox
            // 
            this.name_textBox.Location = new System.Drawing.Point(241, 25);
            this.name_textBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(107, 27);
            this.name_textBox.TabIndex = 31;
            this.name_textBox.TextChanged += new System.EventHandler(this.name_textBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(82, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 30;
            this.label1.Text = "Name";
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(407, 301);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ticket_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.id_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.enter_button);
            this.Controls.Add(this.name_textBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Registration";
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.Registration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox ticket_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox id_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button enter_button;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.Label label1;
    }
}