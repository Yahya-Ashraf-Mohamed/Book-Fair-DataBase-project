namespace Book_Fair
{
    partial class Login_form
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
            this.Welcome_label = new System.Windows.Forms.Label();
            this.Username_label = new System.Windows.Forms.Label();
            this.Login_button = new System.Windows.Forms.Button();
            this.Username_textBox = new System.Windows.Forms.TextBox();
            this.Password_textBox = new System.Windows.Forms.TextBox();
            this.Password_label = new System.Windows.Forms.Label();
            this.Forget_Password_label = new System.Windows.Forms.Label();
            this.SignUp_label = new System.Windows.Forms.Label();
            this.Sign_Up_label = new System.Windows.Forms.Label();
            this.Question_label = new System.Windows.Forms.Label();
            this.checkBox_Show = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Welcome_label
            // 
            this.Welcome_label.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Welcome_label.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Welcome_label.Location = new System.Drawing.Point(-17, 22);
            this.Welcome_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Welcome_label.Name = "Welcome_label";
            this.Welcome_label.Size = new System.Drawing.Size(379, 42);
            this.Welcome_label.TabIndex = 0;
            this.Welcome_label.Text = "Welcome to Book Fair";
            this.Welcome_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Username_label
            // 
            this.Username_label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Username_label.Location = new System.Drawing.Point(14, 88);
            this.Username_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Username_label.Name = "Username_label";
            this.Username_label.Size = new System.Drawing.Size(106, 27);
            this.Username_label.TabIndex = 1;
            this.Username_label.Text = "Username";
            // 
            // Login_button
            // 
            this.Login_button.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Login_button.Location = new System.Drawing.Point(144, 176);
            this.Login_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Login_button.Name = "Login_button";
            this.Login_button.Size = new System.Drawing.Size(120, 31);
            this.Login_button.TabIndex = 2;
            this.Login_button.Text = "Login";
            this.Login_button.UseVisualStyleBackColor = true;
            this.Login_button.Click += new System.EventHandler(this.Login_button_Click);
            // 
            // Username_textBox
            // 
            this.Username_textBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Username_textBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Username_textBox.Location = new System.Drawing.Point(112, 88);
            this.Username_textBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Username_textBox.Multiline = true;
            this.Username_textBox.Name = "Username_textBox";
            this.Username_textBox.Size = new System.Drawing.Size(186, 26);
            this.Username_textBox.TabIndex = 3;
            this.Username_textBox.TextChanged += new System.EventHandler(this.Username_textBox_TextChanged);
            // 
            // Password_textBox
            // 
            this.Password_textBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Password_textBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Password_textBox.Location = new System.Drawing.Point(112, 134);
            this.Password_textBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Password_textBox.Multiline = true;
            this.Password_textBox.Name = "Password_textBox";
            this.Password_textBox.PasswordChar = '*';
            this.Password_textBox.Size = new System.Drawing.Size(186, 26);
            this.Password_textBox.TabIndex = 5;
            this.Password_textBox.TextChanged += new System.EventHandler(this.Password_textBox_TextChanged);
            // 
            // Password_label
            // 
            this.Password_label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Password_label.Location = new System.Drawing.Point(14, 134);
            this.Password_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Password_label.Name = "Password_label";
            this.Password_label.Size = new System.Drawing.Size(106, 27);
            this.Password_label.TabIndex = 4;
            this.Password_label.Text = "Password";
            // 
            // Forget_Password_label
            // 
            this.Forget_Password_label.AutoSize = true;
            this.Forget_Password_label.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.Forget_Password_label.ForeColor = System.Drawing.Color.Blue;
            this.Forget_Password_label.Location = new System.Drawing.Point(18, 222);
            this.Forget_Password_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Forget_Password_label.Name = "Forget_Password_label";
            this.Forget_Password_label.Size = new System.Drawing.Size(102, 14);
            this.Forget_Password_label.TabIndex = 8;
            this.Forget_Password_label.Text = "forget password?";
            this.Forget_Password_label.Click += new System.EventHandler(this.Forget_Password_label_Click);
            // 
            // SignUp_label
            // 
            this.SignUp_label.AutoSize = true;
            this.SignUp_label.Location = new System.Drawing.Point(18, 323);
            this.SignUp_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SignUp_label.Name = "SignUp_label";
            this.SignUp_label.Size = new System.Drawing.Size(0, 15);
            this.SignUp_label.TabIndex = 9;
            // 
            // Sign_Up_label
            // 
            this.Sign_Up_label.AutoSize = true;
            this.Sign_Up_label.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.Sign_Up_label.ForeColor = System.Drawing.Color.Blue;
            this.Sign_Up_label.Location = new System.Drawing.Point(142, 248);
            this.Sign_Up_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Sign_Up_label.Name = "Sign_Up_label";
            this.Sign_Up_label.Size = new System.Drawing.Size(49, 14);
            this.Sign_Up_label.TabIndex = 10;
            this.Sign_Up_label.Text = "Sign Up";
            this.Sign_Up_label.Click += new System.EventHandler(this.Sign_Up_label_Click);
            // 
            // Question_label
            // 
            this.Question_label.AutoSize = true;
            this.Question_label.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Question_label.Location = new System.Drawing.Point(13, 248);
            this.Question_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Question_label.Name = "Question_label";
            this.Question_label.Size = new System.Drawing.Size(121, 14);
            this.Question_label.TabIndex = 11;
            this.Question_label.Text = "Don\'t have account?";
            // 
            // checkBox_Show
            // 
            this.checkBox_Show.AutoSize = true;
            this.checkBox_Show.BackColor = System.Drawing.Color.White;
            this.checkBox_Show.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBox_Show.Location = new System.Drawing.Point(239, 137);
            this.checkBox_Show.Name = "checkBox_Show";
            this.checkBox_Show.Size = new System.Drawing.Size(58, 19);
            this.checkBox_Show.TabIndex = 112;
            this.checkBox_Show.Text = "Show";
            this.checkBox_Show.UseVisualStyleBackColor = false;
            this.checkBox_Show.CheckedChanged += new System.EventHandler(this.checkBox_Show_CheckedChanged);
            // 
            // Login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(346, 281);
            this.Controls.Add(this.checkBox_Show);
            this.Controls.Add(this.Question_label);
            this.Controls.Add(this.Sign_Up_label);
            this.Controls.Add(this.SignUp_label);
            this.Controls.Add(this.Forget_Password_label);
            this.Controls.Add(this.Password_textBox);
            this.Controls.Add(this.Password_label);
            this.Controls.Add(this.Username_textBox);
            this.Controls.Add(this.Login_button);
            this.Controls.Add(this.Username_label);
            this.Controls.Add(this.Welcome_label);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Login_form";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Welcome_label;
        private System.Windows.Forms.Label Username_label;
        private System.Windows.Forms.Button Login_button;
        private System.Windows.Forms.TextBox Username_textBox;
        private System.Windows.Forms.TextBox Password_textBox;
        private System.Windows.Forms.Label Password_label;
        private System.Windows.Forms.Label Forget_Password_label;
        private System.Windows.Forms.Label SignUp_label;
        private System.Windows.Forms.Label Sign_Up_label;
        private System.Windows.Forms.Label Question_label;
        private System.Windows.Forms.CheckBox checkBox_Show;
    }
}

