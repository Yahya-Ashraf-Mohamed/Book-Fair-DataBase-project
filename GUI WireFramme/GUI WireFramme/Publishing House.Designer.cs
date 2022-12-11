
namespace Book_Fair
{
    partial class Publishing_House
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>


        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Publishing_House));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PublishHousePic = new System.Windows.Forms.PictureBox();
            this.PublishHouse = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Publishing_Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PublishHousePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PublishHousePic
            // 
            this.PublishHousePic.Image = ((System.Drawing.Image)(resources.GetObject("PublishHousePic.Image")));
            this.PublishHousePic.Location = new System.Drawing.Point(-1, -1);
            this.PublishHousePic.Name = "PublishHousePic";
            this.PublishHousePic.Size = new System.Drawing.Size(342, 116);
            this.PublishHousePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PublishHousePic.TabIndex = 0;
            this.PublishHousePic.TabStop = false;
            this.PublishHousePic.Click += new System.EventHandler(this.pictureBox3_Click_1);
            // 
            // PublishHouse
            // 
            this.PublishHouse.AutoSize = true;
            this.PublishHouse.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PublishHouse.ForeColor = System.Drawing.Color.MidnightBlue;
            this.PublishHouse.Location = new System.Drawing.Point(30, 127);
            this.PublishHouse.Name = "PublishHouse";
            this.PublishHouse.Size = new System.Drawing.Size(284, 33);
            this.PublishHouse.TabIndex = 1;
            this.PublishHouse.Text = "Publishing Houses";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(19, 163);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(103, 59);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Publishing House Name";
            // 
            // Publishing_Back
            // 
            this.Publishing_Back.Location = new System.Drawing.Point(130, 300);
            this.Publishing_Back.Name = "Publishing_Back";
            this.Publishing_Back.Size = new System.Drawing.Size(75, 22);
            this.Publishing_Back.TabIndex = 11;
            this.Publishing_Back.Text = "Back";
            this.Publishing_Back.UseVisualStyleBackColor = true;
            this.Publishing_Back.Click += new System.EventHandler(this.Publishing_Back_Click);
            // 
            // Publishing_House
            // 
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(342, 334);
            this.Controls.Add(this.Publishing_Back);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.PublishHouse);
            this.Controls.Add(this.PublishHousePic);
            this.Name = "Publishing_House";
            this.Text = "Publishing House";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PublishHousePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox PublishHousePic;
        private System.Windows.Forms.Label PublishHouse;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Publishing_Back;
    }
}

