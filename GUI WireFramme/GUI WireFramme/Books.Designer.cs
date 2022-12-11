
namespace Book_Fair
{
    partial class Books
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Books));
            this.BooksPic = new System.Windows.Forms.PictureBox();
            this.BookName = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.Button();
            this.BookSearch = new System.Windows.Forms.TextBox();
            this.BookData = new System.Windows.Forms.DataGridView();
            this.Book_Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BooksPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookData)).BeginInit();
            this.SuspendLayout();
            // 
            // BooksPic
            // 
            this.BooksPic.Image = ((System.Drawing.Image)(resources.GetObject("BooksPic.Image")));
            this.BooksPic.Location = new System.Drawing.Point(1, 3);
            this.BooksPic.Name = "BooksPic";
            this.BooksPic.Size = new System.Drawing.Size(237, 112);
            this.BooksPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BooksPic.TabIndex = 0;
            this.BooksPic.TabStop = false;
            // 
            // BookName
            // 
            this.BookName.AutoSize = true;
            this.BookName.Location = new System.Drawing.Point(12, 134);
            this.BookName.Name = "BookName";
            this.BookName.Size = new System.Drawing.Size(69, 15);
            this.BookName.TabIndex = 1;
            this.BookName.Text = "Book Name";
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(73, 163);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 29);
            this.Search.TabIndex = 2;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            // 
            // BookSearch
            // 
            this.BookSearch.Location = new System.Drawing.Point(125, 134);
            this.BookSearch.Name = "BookSearch";
            this.BookSearch.Size = new System.Drawing.Size(100, 23);
            this.BookSearch.TabIndex = 3;
            // 
            // BookData
            // 
            this.BookData.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.BookData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookData.Location = new System.Drawing.Point(1, 198);
            this.BookData.Name = "BookData";
            this.BookData.RowTemplate.Height = 25;
            this.BookData.Size = new System.Drawing.Size(231, 124);
            this.BookData.TabIndex = 4;
            // 
            // Book_Back
            // 
            this.Book_Back.Location = new System.Drawing.Point(73, 328);
            this.Book_Back.Name = "Book_Back";
            this.Book_Back.Size = new System.Drawing.Size(75, 28);
            this.Book_Back.TabIndex = 11;
            this.Book_Back.Text = "Back";
            this.Book_Back.UseVisualStyleBackColor = true;
            this.Book_Back.Click += new System.EventHandler(this.Book_Back_Click);
            // 
            // Books
            // 
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(237, 359);
            this.Controls.Add(this.Book_Back);
            this.Controls.Add(this.BookData);
            this.Controls.Add(this.BookSearch);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.BookName);
            this.Controls.Add(this.BooksPic);
            this.Name = "Books";
            this.Text = "Books";
            ((System.ComponentModel.ISupportInitialize)(this.BooksPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.PictureBox BooksPic;
        private System.Windows.Forms.Label BookName;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.TextBox BookSearch;
        private System.Windows.Forms.DataGridView BookData;
        private System.Windows.Forms.Button Book_Back;
    }
}

