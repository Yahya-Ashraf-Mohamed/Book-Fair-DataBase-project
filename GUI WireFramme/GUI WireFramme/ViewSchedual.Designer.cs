
namespace Book_Fair
{
    partial class ViewSchedual
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
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.schedule_button = new System.Windows.Forms.Button();
            this.schedule_dataGridView = new System.Windows.Forms.DataGridView();
            this.date_comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.schedule_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(14, 523);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(88, 40);
            this.button5.TabIndex = 37;
            this.button5.Text = "Log Out";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(577, 523);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 40);
            this.button2.TabIndex = 36;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(85, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "Date ";
            // 
            // schedule_button
            // 
            this.schedule_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.schedule_button.Location = new System.Drawing.Point(443, 36);
            this.schedule_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.schedule_button.Name = "schedule_button";
            this.schedule_button.Size = new System.Drawing.Size(163, 40);
            this.schedule_button.TabIndex = 31;
            this.schedule_button.Text = "View Schedule ";
            this.schedule_button.UseVisualStyleBackColor = true;
            this.schedule_button.Click += new System.EventHandler(this.schedule_button_Click);
            // 
            // schedule_dataGridView
            // 
            this.schedule_dataGridView.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.schedule_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.schedule_dataGridView.Location = new System.Drawing.Point(14, 99);
            this.schedule_dataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.schedule_dataGridView.Name = "schedule_dataGridView";
            this.schedule_dataGridView.RowHeadersWidth = 51;
            this.schedule_dataGridView.RowTemplate.Height = 24;
            this.schedule_dataGridView.Size = new System.Drawing.Size(651, 372);
            this.schedule_dataGridView.TabIndex = 30;
            // 
            // date_comboBox1
            // 
            this.date_comboBox1.FormattingEnabled = true;
            this.date_comboBox1.Location = new System.Drawing.Point(200, 43);
            this.date_comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.date_comboBox1.Name = "date_comboBox1";
            this.date_comboBox1.Size = new System.Drawing.Size(141, 28);
            this.date_comboBox1.TabIndex = 46;
            this.date_comboBox1.SelectedIndexChanged += new System.EventHandler(this.date_comboBox1_SelectedIndexChanged);
            // 
            // ViewSchedual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(682, 563);
            this.Controls.Add(this.date_comboBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.schedule_button);
            this.Controls.Add(this.schedule_dataGridView);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ViewSchedual";
            this.Text = "View Schedule";
            ((System.ComponentModel.ISupportInitialize)(this.schedule_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button schedule_button;
        private System.Windows.Forms.DataGridView schedule_dataGridView;
        private System.Windows.Forms.ComboBox date_comboBox1;
    }
}