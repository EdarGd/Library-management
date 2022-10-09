namespace AppLayer.Components.comBook
{
    partial class AddBook
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.specialButton1 = new AppLayer.SpecialComponents.SpecialButton();
            this.secondaryCategory = new System.Windows.Forms.ComboBox();
            this.category = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.publicationDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lastNameAuthor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.firstNameAuthor = new System.Windows.Forms.TextBox();
            this.labell = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.code = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.specialButton1);
            this.panel1.Controls.Add(this.secondaryCategory);
            this.panel1.Controls.Add(this.category);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.publicationDate);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lastNameAuthor);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.firstNameAuthor);
            this.panel1.Controls.Add(this.labell);
            this.panel1.Controls.Add(this.title);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.code);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.MaximumSize = new System.Drawing.Size(557, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(557, 413);
            this.panel1.TabIndex = 40;
            // 
            // specialButton1
            // 
            this.specialButton1.BackColor = System.Drawing.Color.Transparent;
            this.specialButton1.BackgroundColor = System.Drawing.Color.Transparent;
            this.specialButton1.BackgroundImage = global::AppLayer.Properties.Resources.addButton;
            this.specialButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.specialButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.specialButton1.BorderRadius = 40;
            this.specialButton1.BorderSize = 0;
            this.specialButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.specialButton1.FlatAppearance.BorderSize = 0;
            this.specialButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.specialButton1.ForeColor = System.Drawing.Color.White;
            this.specialButton1.Location = new System.Drawing.Point(215, 346);
            this.specialButton1.Name = "specialButton1";
            this.specialButton1.Size = new System.Drawing.Size(129, 71);
            this.specialButton1.TabIndex = 56;
            this.specialButton1.TextColor = System.Drawing.Color.White;
            this.specialButton1.UseVisualStyleBackColor = false;
            this.specialButton1.Click += new System.EventHandler(this.specialButton1_Click);
            // 
            // secondaryCategory
            // 
            this.secondaryCategory.FormattingEnabled = true;
            this.secondaryCategory.Location = new System.Drawing.Point(291, 317);
            this.secondaryCategory.Name = "secondaryCategory";
            this.secondaryCategory.Size = new System.Drawing.Size(153, 23);
            this.secondaryCategory.TabIndex = 55;
            // 
            // category
            // 
            this.category.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.category.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.category.FormattingEnabled = true;
            this.category.Location = new System.Drawing.Point(291, 271);
            this.category.Name = "category";
            this.category.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.category.Size = new System.Drawing.Size(153, 23);
            this.category.TabIndex = 54;
            this.category.SelectedIndexChanged += new System.EventHandler(this.category_SelectedIndexChanged_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Guttman Stam", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(100, 317);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(184, 24);
            this.label8.TabIndex = 53;
            this.label8.Text = "Secondary Category :";
            // 
            // publicationDate
            // 
            this.publicationDate.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.publicationDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.publicationDate.Location = new System.Drawing.Point(291, 224);
            this.publicationDate.MaxDate = new System.DateTime(2022, 10, 2, 10, 46, 8, 0);
            this.publicationDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.publicationDate.Name = "publicationDate";
            this.publicationDate.Size = new System.Drawing.Size(153, 22);
            this.publicationDate.TabIndex = 52;
            this.publicationDate.Value = new System.DateTime(2022, 10, 2, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Guttman Stam", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(100, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 24);
            this.label7.TabIndex = 51;
            this.label7.Text = "Category :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Guttman Stam", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(100, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 24);
            this.label6.TabIndex = 50;
            this.label6.Text = "Publication Date :";
            // 
            // lastNameAuthor
            // 
            this.lastNameAuthor.Location = new System.Drawing.Point(291, 180);
            this.lastNameAuthor.MaxLength = 20;
            this.lastNameAuthor.Name = "lastNameAuthor";
            this.lastNameAuthor.PlaceholderText = "Enter last name author ...";
            this.lastNameAuthor.Size = new System.Drawing.Size(153, 23);
            this.lastNameAuthor.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Guttman Stam", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(100, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 24);
            this.label5.TabIndex = 48;
            this.label5.Text = "Last Name Author :";
            // 
            // firstNameAuthor
            // 
            this.firstNameAuthor.Location = new System.Drawing.Point(291, 138);
            this.firstNameAuthor.MaxLength = 20;
            this.firstNameAuthor.Name = "firstNameAuthor";
            this.firstNameAuthor.PlaceholderText = "Enter first name author ...";
            this.firstNameAuthor.Size = new System.Drawing.Size(153, 23);
            this.firstNameAuthor.TabIndex = 47;
            // 
            // labell
            // 
            this.labell.AutoSize = true;
            this.labell.Font = new System.Drawing.Font("Guttman Stam", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labell.Location = new System.Drawing.Point(100, 136);
            this.labell.Name = "labell";
            this.labell.Size = new System.Drawing.Size(165, 24);
            this.labell.TabIndex = 46;
            this.labell.Text = "First Name Author :";
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(291, 94);
            this.title.MaxLength = 20;
            this.title.Name = "title";
            this.title.PlaceholderText = "Enter book title ...";
            this.title.Size = new System.Drawing.Size(153, 23);
            this.title.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Guttman Stam", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(100, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 24);
            this.label3.TabIndex = 44;
            this.label3.Text = "Title :";
            // 
            // code
            // 
            this.code.Location = new System.Drawing.Point(291, 56);
            this.code.MaxLength = 13;
            this.code.Name = "code";
            this.code.PlaceholderText = "Enter book code ...";
            this.code.Size = new System.Drawing.Size(153, 23);
            this.code.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Guttman Stam", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(100, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 24);
            this.label1.TabIndex = 42;
            this.label1.Text = "Code  ( 13 digits ) :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(114, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(336, 21);
            this.label4.TabIndex = 41;
            this.label4.Text = "Insert details of a new book :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(31, -43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(336, 21);
            this.label2.TabIndex = 40;
            this.label2.Text = "Insert details of a new book :";
            // 
            // AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.Controls.Add(this.panel1);
            this.Name = "AddBook";
            this.Size = new System.Drawing.Size(557, 413);
            this.Load += new System.EventHandler(this.AddBook_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private SpecialComponents.SpecialButton specialButton1;
        private ComboBox secondaryCategory;
        private ComboBox category;
        private Label label8;
        private DateTimePicker publicationDate;
        private Label label7;
        private Label label6;
        private TextBox lastNameAuthor;
        private Label label5;
        private TextBox firstNameAuthor;
        private Label labell;
        private TextBox title;
        private Label label3;
        private TextBox code;
        private Label label1;
        private Label label4;
        private Label label2;
    }
}
