
namespace Book_Fair
{
    partial class Reset_Password
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
            this.button_Confirm = new System.Windows.Forms.Button();
            this.textBox_Old_Password = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_New_pass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Confirm_pass = new System.Windows.Forms.TextBox();
            this.Log_out_label = new System.Windows.Forms.Label();
            this.Back_label = new System.Windows.Forms.Label();
            this.checkBox_Show = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button_Confirm
            // 
            this.button_Confirm.Location = new System.Drawing.Point(203, 103);
            this.button_Confirm.Name = "button_Confirm";
            this.button_Confirm.Size = new System.Drawing.Size(95, 30);
            this.button_Confirm.TabIndex = 0;
            this.button_Confirm.Text = "Confirm";
            this.button_Confirm.UseVisualStyleBackColor = true;
            this.button_Confirm.Click += new System.EventHandler(this.button_Confirm_Click);
            // 
            // textBox_Old_Password
            // 
            this.textBox_Old_Password.Location = new System.Drawing.Point(164, 14);
            this.textBox_Old_Password.Name = "textBox_Old_Password";
            this.textBox_Old_Password.Size = new System.Drawing.Size(171, 23);
            this.textBox_Old_Password.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(13, 9);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 30);
            this.label10.TabIndex = 147;
            this.label10.Text = "Old Password";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(11, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 30);
            this.label1.TabIndex = 149;
            this.label1.Text = "New Password";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_New_pass
            // 
            this.textBox_New_pass.Location = new System.Drawing.Point(164, 44);
            this.textBox_New_pass.Name = "textBox_New_pass";
            this.textBox_New_pass.PasswordChar = '*';
            this.textBox_New_pass.Size = new System.Drawing.Size(171, 23);
            this.textBox_New_pass.TabIndex = 148;
            this.textBox_New_pass.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(11, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 30);
            this.label2.TabIndex = 151;
            this.label2.Text = "Confirm Password";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_Confirm_pass
            // 
            this.textBox_Confirm_pass.Location = new System.Drawing.Point(164, 74);
            this.textBox_Confirm_pass.Name = "textBox_Confirm_pass";
            this.textBox_Confirm_pass.PasswordChar = '*';
            this.textBox_Confirm_pass.Size = new System.Drawing.Size(171, 23);
            this.textBox_Confirm_pass.TabIndex = 150;
            this.textBox_Confirm_pass.UseSystemPasswordChar = true;
            // 
            // Log_out_label
            // 
            this.Log_out_label.AutoSize = true;
            this.Log_out_label.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.Log_out_label.ForeColor = System.Drawing.Color.Blue;
            this.Log_out_label.Location = new System.Drawing.Point(285, 156);
            this.Log_out_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Log_out_label.Name = "Log_out_label";
            this.Log_out_label.Size = new System.Drawing.Size(50, 14);
            this.Log_out_label.TabIndex = 152;
            this.Log_out_label.Text = "Log out";
            this.Log_out_label.Click += new System.EventHandler(this.Log_out_label_Click);
            // 
            // Back_label
            // 
            this.Back_label.AutoSize = true;
            this.Back_label.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.Back_label.ForeColor = System.Drawing.Color.Blue;
            this.Back_label.Location = new System.Drawing.Point(13, 156);
            this.Back_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Back_label.Name = "Back_label";
            this.Back_label.Size = new System.Drawing.Size(32, 14);
            this.Back_label.TabIndex = 153;
            this.Back_label.Text = "Back";
            this.Back_label.Click += new System.EventHandler(this.Back_label_Click);
            // 
            // checkBox_Show
            // 
            this.checkBox_Show.AutoSize = true;
            this.checkBox_Show.BackColor = System.Drawing.Color.White;
            this.checkBox_Show.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBox_Show.Location = new System.Drawing.Point(274, 46);
            this.checkBox_Show.Name = "checkBox_Show";
            this.checkBox_Show.Size = new System.Drawing.Size(58, 19);
            this.checkBox_Show.TabIndex = 154;
            this.checkBox_Show.Text = "Show";
            this.checkBox_Show.UseVisualStyleBackColor = false;
            this.checkBox_Show.CheckedChanged += new System.EventHandler(this.checkBox_Show_CheckedChanged);
            // 
            // Reset_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(353, 179);
            this.Controls.Add(this.checkBox_Show);
            this.Controls.Add(this.Back_label);
            this.Controls.Add(this.Log_out_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Confirm_pass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_New_pass);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox_Old_Password);
            this.Controls.Add(this.button_Confirm);
            this.Name = "Reset_Password";
            this.Text = "Reset_Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Confirm;
        private System.Windows.Forms.TextBox textBox_Old_Password;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_New_pass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Confirm_pass;
        private System.Windows.Forms.Label Log_out_label;
        private System.Windows.Forms.Label Back_label;
        private System.Windows.Forms.CheckBox checkBox_Show;
    }
}