
namespace Book_Fair
{
    partial class BookInfo
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
            this.label5 = new System.Windows.Forms.Label();
            this.author_textBox = new System.Windows.Forms.TextBox();
            this.price_textBox = new System.Windows.Forms.TextBox();
            this.offer_textBox = new System.Windows.Forms.TextBox();
            this.available_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.title_textBox = new System.Windows.Forms.TextBox();
            this.sell_button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(37, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "Author Name";
            // 
            // author_textBox
            // 
            this.author_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.author_textBox.Location = new System.Drawing.Point(151, 76);
            this.author_textBox.Multiline = true;
            this.author_textBox.Name = "author_textBox";
            this.author_textBox.ReadOnly = true;
            this.author_textBox.Size = new System.Drawing.Size(88, 21);
            this.author_textBox.TabIndex = 43;
            this.author_textBox.TextChanged += new System.EventHandler(this.author_textBox_TextChanged);
            // 
            // price_textBox
            // 
            this.price_textBox.Location = new System.Drawing.Point(151, 124);
            this.price_textBox.Name = "price_textBox";
            this.price_textBox.ReadOnly = true;
            this.price_textBox.Size = new System.Drawing.Size(88, 23);
            this.price_textBox.TabIndex = 39;
            // 
            // offer_textBox
            // 
            this.offer_textBox.Location = new System.Drawing.Point(151, 175);
            this.offer_textBox.Name = "offer_textBox";
            this.offer_textBox.ReadOnly = true;
            this.offer_textBox.Size = new System.Drawing.Size(88, 23);
            this.offer_textBox.TabIndex = 38;
            // 
            // available_textBox
            // 
            this.available_textBox.Location = new System.Drawing.Point(151, 228);
            this.available_textBox.Name = "available_textBox";
            this.available_textBox.ReadOnly = true;
            this.available_textBox.Size = new System.Drawing.Size(88, 23);
            this.available_textBox.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 36;
            this.label4.Text = "Available ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.TabIndex = 35;
            this.label3.Text = "Offer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 34;
            this.label2.Text = "Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 33;
            this.label1.Text = "Book Title ";
            // 
            // title_textBox
            // 
            this.title_textBox.Location = new System.Drawing.Point(151, 31);
            this.title_textBox.Name = "title_textBox";
            this.title_textBox.ReadOnly = true;
            this.title_textBox.Size = new System.Drawing.Size(88, 23);
            this.title_textBox.TabIndex = 32;
            this.title_textBox.TextChanged += new System.EventHandler(this.title_textBox_TextChanged);
            // 
            // sell_button1
            // 
            this.sell_button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sell_button1.Location = new System.Drawing.Point(102, 271);
            this.sell_button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sell_button1.Name = "sell_button1";
            this.sell_button1.Size = new System.Drawing.Size(116, 46);
            this.sell_button1.TabIndex = 45;
            this.sell_button1.Text = "Sell";
            this.sell_button1.UseVisualStyleBackColor = true;
            this.sell_button1.Click += new System.EventHandler(this.sell_button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(253, 331);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 30);
            this.button2.TabIndex = 41;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(28, 331);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(77, 30);
            this.button5.TabIndex = 42;
            this.button5.Text = "Log Out";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // BookInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(363, 370);
            this.Controls.Add(this.sell_button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.author_textBox);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.price_textBox);
            this.Controls.Add(this.offer_textBox);
            this.Controls.Add(this.available_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.title_textBox);
            this.Name = "BookInfo";
            this.Text = "Book Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        protected internal System.Windows.Forms.TextBox author_textBox;
        protected internal System.Windows.Forms.TextBox price_textBox;
        protected internal System.Windows.Forms.TextBox offer_textBox;
        protected internal System.Windows.Forms.TextBox available_textBox;
        protected internal System.Windows.Forms.Button sell_button1;
        protected internal System.Windows.Forms.TextBox title_textBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
    }
}