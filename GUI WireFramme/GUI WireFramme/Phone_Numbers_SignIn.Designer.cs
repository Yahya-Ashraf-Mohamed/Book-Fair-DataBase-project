
namespace Book_Fair
{
    partial class Phone_Numbers_SignIn
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
            this.button_Save = new System.Windows.Forms.Button();
            this.textBox_PhoneNo = new System.Windows.Forms.TextBox();
            this.label_Another_Phone = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Back_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(149, 95);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(80, 30);
            this.button_Save.TabIndex = 1;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // textBox_PhoneNo
            // 
            this.textBox_PhoneNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox_PhoneNo.Location = new System.Drawing.Point(121, 59);
            this.textBox_PhoneNo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_PhoneNo.Multiline = true;
            this.textBox_PhoneNo.Name = "textBox_PhoneNo";
            this.textBox_PhoneNo.Size = new System.Drawing.Size(144, 26);
            this.textBox_PhoneNo.TabIndex = 115;
            // 
            // label_Another_Phone
            // 
            this.label_Another_Phone.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Another_Phone.Location = new System.Drawing.Point(13, 57);
            this.label_Another_Phone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Another_Phone.Name = "label_Another_Phone";
            this.label_Another_Phone.Size = new System.Drawing.Size(124, 27);
            this.label_Another_Phone.TabIndex = 114;
            this.label_Another_Phone.Text = "Phone no.";
            this.label_Another_Phone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 27);
            this.label1.TabIndex = 116;
            this.label1.Text = "Please Enter your Phone Number";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Back_label
            // 
            this.Back_label.AutoSize = true;
            this.Back_label.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.Back_label.ForeColor = System.Drawing.Color.Blue;
            this.Back_label.Location = new System.Drawing.Point(13, 140);
            this.Back_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Back_label.Name = "Back_label";
            this.Back_label.Size = new System.Drawing.Size(32, 14);
            this.Back_label.TabIndex = 117;
            this.Back_label.Text = "Back";
            this.Back_label.Click += new System.EventHandler(this.Back_label_Click);
            // 
            // Phone_Numbers_SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(309, 165);
            this.Controls.Add(this.Back_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_PhoneNo);
            this.Controls.Add(this.label_Another_Phone);
            this.Controls.Add(this.button_Save);
            this.Name = "Phone_Numbers_SignIn";
            this.Text = "Phone_Numbers_SignIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.TextBox textBox_PhoneNo;
        private System.Windows.Forms.Label label_Another_Phone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Back_label;
    }
}