namespace Book_Fair
{
    partial class Forget_password
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
            this.ID_textBox = new System.Windows.Forms.TextBox();
            this.ID_label = new System.Windows.Forms.Label();
            this.Username_textBox = new System.Windows.Forms.TextBox();
            this.Send_Password_button = new System.Windows.Forms.Button();
            this.Username_label = new System.Windows.Forms.Label();
            this.Back_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ID_textBox
            // 
            this.ID_textBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ID_textBox.Location = new System.Drawing.Point(134, 60);
            this.ID_textBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ID_textBox.Multiline = true;
            this.ID_textBox.Name = "ID_textBox";
            this.ID_textBox.Size = new System.Drawing.Size(136, 26);
            this.ID_textBox.TabIndex = 15;
            // 
            // ID_label
            // 
            this.ID_label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ID_label.Location = new System.Drawing.Point(14, 60);
            this.ID_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ID_label.Name = "ID_label";
            this.ID_label.Size = new System.Drawing.Size(106, 27);
            this.ID_label.TabIndex = 14;
            this.ID_label.Text = "ID";
            this.ID_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Username_textBox
            // 
            this.Username_textBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Username_textBox.Location = new System.Drawing.Point(134, 27);
            this.Username_textBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Username_textBox.Multiline = true;
            this.Username_textBox.Name = "Username_textBox";
            this.Username_textBox.Size = new System.Drawing.Size(136, 26);
            this.Username_textBox.TabIndex = 11;
            // 
            // Send_Password_button
            // 
            this.Send_Password_button.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Send_Password_button.Location = new System.Drawing.Point(70, 101);
            this.Send_Password_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Send_Password_button.Name = "Send_Password_button";
            this.Send_Password_button.Size = new System.Drawing.Size(140, 36);
            this.Send_Password_button.TabIndex = 10;
            this.Send_Password_button.Text = "Send Password";
            this.Send_Password_button.UseVisualStyleBackColor = true;
            this.Send_Password_button.Click += new System.EventHandler(this.Send_Password_button_Click);
            // 
            // Username_label
            // 
            this.Username_label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Username_label.Location = new System.Drawing.Point(14, 27);
            this.Username_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Username_label.Name = "Username_label";
            this.Username_label.Size = new System.Drawing.Size(106, 27);
            this.Username_label.TabIndex = 9;
            this.Username_label.Text = "Username";
            // 
            // Back_label
            // 
            this.Back_label.AutoSize = true;
            this.Back_label.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.Back_label.ForeColor = System.Drawing.Color.Blue;
            this.Back_label.Location = new System.Drawing.Point(13, 147);
            this.Back_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Back_label.Name = "Back_label";
            this.Back_label.Size = new System.Drawing.Size(33, 16);
            this.Back_label.TabIndex = 16;
            this.Back_label.Text = "Back";
            this.Back_label.Click += new System.EventHandler(this.Back_label_Click);
            // 
            // Forget_password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(283, 172);
            this.Controls.Add(this.Back_label);
            this.Controls.Add(this.ID_textBox);
            this.Controls.Add(this.ID_label);
            this.Controls.Add(this.Username_textBox);
            this.Controls.Add(this.Send_Password_button);
            this.Controls.Add(this.Username_label);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Forget_password";
            this.Text = "Forget_password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ID_textBox;
        private System.Windows.Forms.Label ID_label;
        private System.Windows.Forms.TextBox Username_textBox;
        private System.Windows.Forms.Button Send_Password_button;
        private System.Windows.Forms.Label Username_label;
        private System.Windows.Forms.Label Back_label;
    }
}