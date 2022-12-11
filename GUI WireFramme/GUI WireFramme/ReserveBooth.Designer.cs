
namespace Book_Fair
{
    partial class ReserveBooth
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BoothRev_button = new System.Windows.Forms.Button();
            this.Booth_dataGridView = new System.Windows.Forms.DataGridView();
            this.BoothSearch_button = new System.Windows.Forms.Button();
            this.time_comboBox1 = new System.Windows.Forms.ComboBox();
            this.date_comboBox2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Booth_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(12, 315);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(77, 30);
            this.button5.TabIndex = 44;
            this.button5.Text = "Log Out";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(532, 315);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(77, 30);
            this.button3.TabIndex = 43;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(30, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 41;
            this.label2.Text = "Time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(31, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 39;
            this.label1.Text = "Date";
            // 
            // BoothRev_button
            // 
            this.BoothRev_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BoothRev_button.Location = new System.Drawing.Point(52, 179);
            this.BoothRev_button.Name = "BoothRev_button";
            this.BoothRev_button.Size = new System.Drawing.Size(130, 29);
            this.BoothRev_button.TabIndex = 38;
            this.BoothRev_button.Text = "Reverse";
            this.BoothRev_button.UseVisualStyleBackColor = false;
            this.BoothRev_button.Visible = false;
            this.BoothRev_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // Booth_dataGridView
            // 
            this.Booth_dataGridView.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.Booth_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Booth_dataGridView.Location = new System.Drawing.Point(209, 12);
            this.Booth_dataGridView.Name = "Booth_dataGridView";
            this.Booth_dataGridView.RowHeadersWidth = 51;
            this.Booth_dataGridView.RowTemplate.Height = 24;
            this.Booth_dataGridView.Size = new System.Drawing.Size(400, 297);
            this.Booth_dataGridView.TabIndex = 37;
            // 
            // BoothSearch_button
            // 
            this.BoothSearch_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BoothSearch_button.Location = new System.Drawing.Point(52, 133);
            this.BoothSearch_button.Name = "BoothSearch_button";
            this.BoothSearch_button.Size = new System.Drawing.Size(130, 28);
            this.BoothSearch_button.TabIndex = 36;
            this.BoothSearch_button.Text = "Search for Booth";
            this.BoothSearch_button.UseVisualStyleBackColor = true;
            this.BoothSearch_button.Click += new System.EventHandler(this.BoothSearch_button_Click);
            // 
            // time_comboBox1
            // 
            this.time_comboBox1.FormattingEnabled = true;
            this.time_comboBox1.Location = new System.Drawing.Point(76, 84);
            this.time_comboBox1.Name = "time_comboBox1";
            this.time_comboBox1.Size = new System.Drawing.Size(106, 23);
            this.time_comboBox1.TabIndex = 45;
            // 
            // date_comboBox2
            // 
            this.date_comboBox2.FormattingEnabled = true;
            this.date_comboBox2.Location = new System.Drawing.Point(76, 31);
            this.date_comboBox2.Name = "date_comboBox2";
            this.date_comboBox2.Size = new System.Drawing.Size(106, 23);
            this.date_comboBox2.TabIndex = 46;
            // 
            // ReserveBooth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(616, 422);
            this.Controls.Add(this.date_comboBox2);
            this.Controls.Add(this.time_comboBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BoothRev_button);
            this.Controls.Add(this.Booth_dataGridView);
            this.Controls.Add(this.BoothSearch_button);
            this.Name = "ReserveBooth";
            this.Text = "Booth Reservation";
            this.Load += new System.EventHandler(this.ReserveBooth_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Booth_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BoothRev_button;
        private System.Windows.Forms.DataGridView Booth_dataGridView;
        private System.Windows.Forms.Button BoothSearch_button;
        private System.Windows.Forms.ComboBox time_comboBox1;
        private System.Windows.Forms.ComboBox date_comboBox2;
    }
}