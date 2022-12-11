
namespace Book_Fair
{
    partial class BookSeller
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
            this.button4 = new System.Windows.Forms.Button();
            this.bookREV_button = new System.Windows.Forms.Button();
            this.BookSearch_button = new System.Windows.Forms.Button();
            this.Help = new System.Windows.Forms.Label();
            this.Hello = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(35, 371);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(88, 40);
            this.button5.TabIndex = 35;
            this.button5.Text = "Log Out";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(274, 371);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(88, 40);
            this.button4.TabIndex = 34;
            this.button4.Text = "Back";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // bookREV_button
            // 
            this.bookREV_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bookREV_button.Location = new System.Drawing.Point(99, 140);
            this.bookREV_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bookREV_button.Name = "bookREV_button";
            this.bookREV_button.Size = new System.Drawing.Size(187, 43);
            this.bookREV_button.TabIndex = 33;
            this.bookREV_button.Text = "Add a Book";
            this.bookREV_button.UseVisualStyleBackColor = true;
            this.bookREV_button.Click += new System.EventHandler(this.bookREV_button_Click);
            // 
            // BookSearch_button
            // 
            this.BookSearch_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BookSearch_button.Location = new System.Drawing.Point(99, 211);
            this.BookSearch_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BookSearch_button.Name = "BookSearch_button";
            this.BookSearch_button.Size = new System.Drawing.Size(187, 39);
            this.BookSearch_button.TabIndex = 32;
            this.BookSearch_button.Text = "Book Search";
            this.BookSearch_button.UseVisualStyleBackColor = true;
            this.BookSearch_button.Click += new System.EventHandler(this.BookSearch_button_Click);
            // 
            // Help
            // 
            this.Help.AutoSize = true;
            this.Help.Font = new System.Drawing.Font("Engravers MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Help.Location = new System.Drawing.Point(13, 87);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(260, 22);
            this.Help.TabIndex = 30;
            this.Help.Text = "How to Help You";
            // 
            // Hello
            // 
            this.Hello.AutoSize = true;
            this.Hello.Font = new System.Drawing.Font("Engravers MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Hello.Location = new System.Drawing.Point(11, 27);
            this.Hello.Name = "Hello";
            this.Hello.Size = new System.Drawing.Size(125, 22);
            this.Hello.TabIndex = 29;
            this.Hello.Text = "Hello.. ";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(99, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 44);
            this.button1.TabIndex = 36;
            this.button1.Text = "Statistics";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BookSeller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(387, 439);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.bookREV_button);
            this.Controls.Add(this.BookSearch_button);
            this.Controls.Add(this.Help);
            this.Controls.Add(this.Hello);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "BookSeller";
            this.Text = "BookSeller";
            this.Load += new System.EventHandler(this.BookSeller_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button bookREV_button;
        private System.Windows.Forms.Button BookSearch_button;
        private System.Windows.Forms.Label Help;
        private System.Windows.Forms.Label Hello;
        private System.Windows.Forms.Button button1;
    }
}

