namespace AppLayer.Components.Single.Main
{
    partial class showDBTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(showDBTable));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dbBooks1 = new AppLayer.Components.tableDB.dbBooks();
            this.dbBorrows1 = new AppLayer.Components.tableDB.dbBorrows();
            this.dbBorrowInnerjoinBookUser1 = new AppLayer.Components.tableDB.dbBorrowInnerjoinBookUser();
            this.dbExistingCategories1 = new AppLayer.Components.tableDB.dbExistingCategories();
            this.dbUsers1 = new AppLayer.Components.tableDB.dbUsers();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::AppLayer.Properties.Resources.closeForm;
            this.pictureBox1.Location = new System.Drawing.Point(10, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Blue;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(253, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 27);
            this.label1.TabIndex = 14;
            this.label1.Text = "Information from the DB";
            // 
            // dbBooks1
            // 
            this.dbBooks1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dbBooks1.AutoScroll = true;
            this.dbBooks1.BackColor = System.Drawing.Color.Transparent;
            this.dbBooks1.Book = null;
            this.dbBooks1.Location = new System.Drawing.Point(12, 101);
            this.dbBooks1.Name = "dbBooks1";
            this.dbBooks1.Size = new System.Drawing.Size(780, 330);
            this.dbBooks1.TabIndex = 15;
            // 
            // dbBorrows1
            // 
            this.dbBorrows1.BackColor = System.Drawing.Color.Transparent;
            this.dbBorrows1.Borrow = null;
            this.dbBorrows1.Location = new System.Drawing.Point(165, 101);
            this.dbBorrows1.Name = "dbBorrows1";
            this.dbBorrows1.Size = new System.Drawing.Size(450, 330);
            this.dbBorrows1.TabIndex = 16;
            // 
            // dbBorrowInnerjoinBookUser1
            // 
            this.dbBorrowInnerjoinBookUser1.BackColor = System.Drawing.Color.Transparent;
            this.dbBorrowInnerjoinBookUser1.BorrowWithInnerJoinBookUserModel = null;
            this.dbBorrowInnerjoinBookUser1.Location = new System.Drawing.Point(12, 101);
            this.dbBorrowInnerjoinBookUser1.Name = "dbBorrowInnerjoinBookUser1";
            this.dbBorrowInnerjoinBookUser1.Size = new System.Drawing.Size(780, 330);
            this.dbBorrowInnerjoinBookUser1.TabIndex = 17;
            // 
            // dbExistingCategories1
            // 
            this.dbExistingCategories1.BackColor = System.Drawing.Color.Transparent;
            this.dbExistingCategories1.ExistingCategory = null;
            this.dbExistingCategories1.Location = new System.Drawing.Point(165, 101);
            this.dbExistingCategories1.Name = "dbExistingCategories1";
            this.dbExistingCategories1.Size = new System.Drawing.Size(450, 330);
            this.dbExistingCategories1.TabIndex = 18;
            // 
            // dbUsers1
            // 
            this.dbUsers1.BackColor = System.Drawing.Color.Transparent;
            this.dbUsers1.Location = new System.Drawing.Point(10, 101);
            this.dbUsers1.Name = "dbUsers1";
            this.dbUsers1.Size = new System.Drawing.Size(780, 330);
            this.dbUsers1.TabIndex = 19;
            this.dbUsers1.User = null;
            // 
            // showDBTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.dbUsers1);
            this.Controls.Add(this.dbExistingCategories1);
            this.Controls.Add(this.dbBorrowInnerjoinBookUser1);
            this.Controls.Add(this.dbBorrows1);
            this.Controls.Add(this.dbBooks1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "showDBTable";
            this.Text = "singleDBTable";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox pictureBox1;
        private Label label1;
        private tableDB.dbBooks dbBooks1;
        private tableDB.dbBorrows dbBorrows1;
        private tableDB.dbBorrowInnerjoinBookUser dbBorrowInnerjoinBookUser1;
        private tableDB.dbExistingCategories dbExistingCategories1;
        private tableDB.dbUsers dbUsers1;
    }
}