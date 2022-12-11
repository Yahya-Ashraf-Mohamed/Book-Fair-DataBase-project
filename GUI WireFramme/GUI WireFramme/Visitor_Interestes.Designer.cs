
namespace Book_Fair
{
    partial class Visitor_Interestes
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
            this.button_Add_New = new System.Windows.Forms.Button();
            this.textBox_Add_Interests = new System.Windows.Forms.TextBox();
            this.checkBox_Choose_Interests = new System.Windows.Forms.CheckBox();
            this.button_Add = new System.Windows.Forms.Button();
            this.comboBox_Interests = new System.Windows.Forms.ComboBox();
            this.checkBox_Add_Interests = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Back_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_Add_New
            // 
            this.button_Add_New.Location = new System.Drawing.Point(216, 165);
            this.button_Add_New.Name = "button_Add_New";
            this.button_Add_New.Size = new System.Drawing.Size(75, 23);
            this.button_Add_New.TabIndex = 127;
            this.button_Add_New.Text = "Add";
            this.button_Add_New.UseVisualStyleBackColor = true;
            this.button_Add_New.Click += new System.EventHandler(this.button_Add_New_Click);
            // 
            // textBox_Add_Interests
            // 
            this.textBox_Add_Interests.Location = new System.Drawing.Point(13, 165);
            this.textBox_Add_Interests.Name = "textBox_Add_Interests";
            this.textBox_Add_Interests.Size = new System.Drawing.Size(163, 23);
            this.textBox_Add_Interests.TabIndex = 126;
            // 
            // checkBox_Choose_Interests
            // 
            this.checkBox_Choose_Interests.AutoSize = true;
            this.checkBox_Choose_Interests.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBox_Choose_Interests.Location = new System.Drawing.Point(12, 72);
            this.checkBox_Choose_Interests.Name = "checkBox_Choose_Interests";
            this.checkBox_Choose_Interests.Size = new System.Drawing.Size(137, 21);
            this.checkBox_Choose_Interests.TabIndex = 125;
            this.checkBox_Choose_Interests.Text = "Choose Interests";
            this.checkBox_Choose_Interests.UseVisualStyleBackColor = true;
            this.checkBox_Choose_Interests.CheckedChanged += new System.EventHandler(this.checkBox_Choose_Interests_CheckedChanged);
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(216, 97);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(75, 23);
            this.button_Add.TabIndex = 124;
            this.button_Add.Text = "Add";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // comboBox_Interests
            // 
            this.comboBox_Interests.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Interests.FormattingEnabled = true;
            this.comboBox_Interests.Location = new System.Drawing.Point(13, 97);
            this.comboBox_Interests.Name = "comboBox_Interests";
            this.comboBox_Interests.Size = new System.Drawing.Size(163, 23);
            this.comboBox_Interests.TabIndex = 123;
            // 
            // checkBox_Add_Interests
            // 
            this.checkBox_Add_Interests.AutoSize = true;
            this.checkBox_Add_Interests.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBox_Add_Interests.Location = new System.Drawing.Point(12, 138);
            this.checkBox_Add_Interests.Name = "checkBox_Add_Interests";
            this.checkBox_Add_Interests.Size = new System.Drawing.Size(147, 21);
            this.checkBox_Add_Interests.TabIndex = 122;
            this.checkBox_Add_Interests.Text = "Add New Interests";
            this.checkBox_Add_Interests.UseVisualStyleBackColor = true;
            this.checkBox_Add_Interests.CheckedChanged += new System.EventHandler(this.checkBox_Add_Interests_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 27);
            this.label1.TabIndex = 128;
            this.label1.Text = "Please Enter your Interests";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Back_label
            // 
            this.Back_label.AutoSize = true;
            this.Back_label.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.Back_label.ForeColor = System.Drawing.Color.Blue;
            this.Back_label.Location = new System.Drawing.Point(13, 203);
            this.Back_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Back_label.Name = "Back_label";
            this.Back_label.Size = new System.Drawing.Size(32, 14);
            this.Back_label.TabIndex = 129;
            this.Back_label.Text = "Back";
            this.Back_label.Click += new System.EventHandler(this.Back_label_Click);
            // 
            // Visitor_Interestes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(322, 228);
            this.Controls.Add(this.Back_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Add_New);
            this.Controls.Add(this.textBox_Add_Interests);
            this.Controls.Add(this.checkBox_Choose_Interests);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.comboBox_Interests);
            this.Controls.Add(this.checkBox_Add_Interests);
            this.Name = "Visitor_Interestes";
            this.Text = "Visitor Interestes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Add_New;
        private System.Windows.Forms.TextBox textBox_Add_Interests;
        private System.Windows.Forms.CheckBox checkBox_Choose_Interests;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.ComboBox comboBox_Interests;
        private System.Windows.Forms.CheckBox checkBox_Add_Interests;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Back_label;
    }
}