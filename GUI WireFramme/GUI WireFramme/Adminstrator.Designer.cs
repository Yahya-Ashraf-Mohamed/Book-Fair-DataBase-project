
namespace Book_Fair
{
    partial class Adminstrator
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
            this.Regestration_button = new System.Windows.Forms.Button();
            this.schedule_button = new System.Windows.Forms.Button();
            this.Vreport_button = new System.Windows.Forms.Button();
            this.Help = new System.Windows.Forms.Label();
            this.Hello = new System.Windows.Forms.Label();
            this.Back_label = new System.Windows.Forms.Label();
            this.Log_out_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Regestration_button
            // 
            this.Regestration_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Regestration_button.Location = new System.Drawing.Point(90, 117);
            this.Regestration_button.Name = "Regestration_button";
            this.Regestration_button.Size = new System.Drawing.Size(164, 34);
            this.Regestration_button.TabIndex = 34;
            this.Regestration_button.Text = "Registration";
            this.Regestration_button.UseVisualStyleBackColor = true;
            this.Regestration_button.Click += new System.EventHandler(this.Regestration_button_Click);
            // 
            // schedule_button
            // 
            this.schedule_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.schedule_button.Location = new System.Drawing.Point(90, 169);
            this.schedule_button.Name = "schedule_button";
            this.schedule_button.Size = new System.Drawing.Size(164, 33);
            this.schedule_button.TabIndex = 33;
            this.schedule_button.Text = "View Schedule ";
            this.schedule_button.UseVisualStyleBackColor = true;
            this.schedule_button.Click += new System.EventHandler(this.schedule_button_Click);
            // 
            // Vreport_button
            // 
            this.Vreport_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Vreport_button.Location = new System.Drawing.Point(90, 221);
            this.Vreport_button.Name = "Vreport_button";
            this.Vreport_button.Size = new System.Drawing.Size(164, 35);
            this.Vreport_button.TabIndex = 32;
            this.Vreport_button.Text = "View Reports";
            this.Vreport_button.UseVisualStyleBackColor = true;
            this.Vreport_button.Click += new System.EventHandler(this.Vreport_button_Click);
            // 
            // Help
            // 
            this.Help.AutoSize = true;
            this.Help.Font = new System.Drawing.Font("Engravers MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Help.Location = new System.Drawing.Point(10, 53);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(208, 17);
            this.Help.TabIndex = 31;
            this.Help.Text = "How to Help You";
            // 
            // Hello
            // 
            this.Hello.AutoSize = true;
            this.Hello.Font = new System.Drawing.Font("Engravers MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Hello.Location = new System.Drawing.Point(12, 18);
            this.Hello.Name = "Hello";
            this.Hello.Size = new System.Drawing.Size(98, 17);
            this.Hello.TabIndex = 30;
            this.Hello.Text = "Hello.. ";
            // 
            // Back_label
            // 
            this.Back_label.AutoSize = true;
            this.Back_label.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.Back_label.ForeColor = System.Drawing.Color.Blue;
            this.Back_label.Location = new System.Drawing.Point(18, 275);
            this.Back_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Back_label.Name = "Back_label";
            this.Back_label.Size = new System.Drawing.Size(32, 14);
            this.Back_label.TabIndex = 107;
            this.Back_label.Text = "Back";
            this.Back_label.Click += new System.EventHandler(this.Back_label_Click);
            // 
            // Log_out_label
            // 
            this.Log_out_label.AutoSize = true;
            this.Log_out_label.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.Log_out_label.ForeColor = System.Drawing.Color.Blue;
            this.Log_out_label.Location = new System.Drawing.Point(290, 275);
            this.Log_out_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Log_out_label.Name = "Log_out_label";
            this.Log_out_label.Size = new System.Drawing.Size(50, 14);
            this.Log_out_label.TabIndex = 106;
            this.Log_out_label.Text = "Log out";
            this.Log_out_label.Click += new System.EventHandler(this.Log_out_label_Click);
            // 
            // Adminstrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(366, 302);
            this.Controls.Add(this.Back_label);
            this.Controls.Add(this.Log_out_label);
            this.Controls.Add(this.Regestration_button);
            this.Controls.Add(this.schedule_button);
            this.Controls.Add(this.Vreport_button);
            this.Controls.Add(this.Help);
            this.Controls.Add(this.Hello);
            this.Name = "Adminstrator";
            this.Text = "Adminstrator";
            this.Load += new System.EventHandler(this.Adminstrator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Regestration_button;
        private System.Windows.Forms.Button schedule_button;
        private System.Windows.Forms.Button Vreport_button;
        private System.Windows.Forms.Label Help;
        private System.Windows.Forms.Label Hello;
        private System.Windows.Forms.Label Back_label;
        private System.Windows.Forms.Label Log_out_label;
    }
}