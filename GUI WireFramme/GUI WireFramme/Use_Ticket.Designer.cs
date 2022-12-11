
namespace Book_Fair
{
    partial class Use_Ticket
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
            this.Back_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_use_ticket = new System.Windows.Forms.Button();
            this.textBox_enter_ticket = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Back_label
            // 
            this.Back_label.AutoSize = true;
            this.Back_label.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.Back_label.ForeColor = System.Drawing.Color.Blue;
            this.Back_label.Location = new System.Drawing.Point(13, 93);
            this.Back_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Back_label.Name = "Back_label";
            this.Back_label.Size = new System.Drawing.Size(32, 14);
            this.Back_label.TabIndex = 133;
            this.Back_label.Text = "Back";
            this.Back_label.Click += new System.EventHandler(this.Back_label_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 27);
            this.label1.TabIndex = 132;
            this.label1.Text = "Please Enter your Ticket";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_use_ticket
            // 
            this.button_use_ticket.Location = new System.Drawing.Point(95, 68);
            this.button_use_ticket.Name = "button_use_ticket";
            this.button_use_ticket.Size = new System.Drawing.Size(75, 23);
            this.button_use_ticket.TabIndex = 131;
            this.button_use_ticket.Text = "Confirm";
            this.button_use_ticket.UseVisualStyleBackColor = true;
            this.button_use_ticket.Click += new System.EventHandler(this.button_use_ticket_Click);
            // 
            // textBox_enter_ticket
            // 
            this.textBox_enter_ticket.Location = new System.Drawing.Point(24, 39);
            this.textBox_enter_ticket.Name = "textBox_enter_ticket";
            this.textBox_enter_ticket.Size = new System.Drawing.Size(220, 23);
            this.textBox_enter_ticket.TabIndex = 130;
            // 
            // Use_Ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(270, 116);
            this.Controls.Add(this.Back_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_use_ticket);
            this.Controls.Add(this.textBox_enter_ticket);
            this.Name = "Use_Ticket";
            this.Text = "Use_Ticket";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Back_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_use_ticket;
        private System.Windows.Forms.TextBox textBox_enter_ticket;
    }
}