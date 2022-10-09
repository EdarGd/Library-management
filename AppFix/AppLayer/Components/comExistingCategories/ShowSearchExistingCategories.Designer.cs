namespace AppLayer.Components.comExistingCategories
{
    partial class ShowSearchExistingCategories
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelShowPartCategory = new System.Windows.Forms.Panel();
            this.partCategory = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panelShowCategory = new System.Windows.Forms.Panel();
            this.category = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelAction = new System.Windows.Forms.Panel();
            this.specialButton1 = new AppLayer.SpecialComponents.SpecialButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.checkComboBox1 = new AppLayer.SpecialComponents.CheckComboBox();
            this.panelShowPartCategory.SuspendLayout();
            this.panelShowCategory.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelAction.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Guttman Stam", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(110, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search by :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(103, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(366, 21);
            this.label2.TabIndex = 74;
            this.label2.Text = "Display of Categories by choice:";
            // 
            // panelShowPartCategory
            // 
            this.panelShowPartCategory.Controls.Add(this.partCategory);
            this.panelShowPartCategory.Controls.Add(this.label9);
            this.panelShowPartCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShowPartCategory.Location = new System.Drawing.Point(0, 95);
            this.panelShowPartCategory.Name = "panelShowPartCategory";
            this.panelShowPartCategory.Size = new System.Drawing.Size(381, 43);
            this.panelShowPartCategory.TabIndex = 86;
            // 
            // partCategory
            // 
            this.partCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.partCategory.Location = new System.Drawing.Point(215, 10);
            this.partCategory.MaxLength = 20;
            this.partCategory.Name = "partCategory";
            this.partCategory.PlaceholderText = "Enter Name / Part Category  ...";
            this.partCategory.Size = new System.Drawing.Size(153, 23);
            this.partCategory.TabIndex = 92;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Guttman Stam", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(3, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 24);
            this.label9.TabIndex = 4;
            this.label9.Text = "Category :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelShowCategory
            // 
            this.panelShowCategory.Controls.Add(this.category);
            this.panelShowCategory.Controls.Add(this.label10);
            this.panelShowCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShowCategory.Location = new System.Drawing.Point(0, 52);
            this.panelShowCategory.Name = "panelShowCategory";
            this.panelShowCategory.Size = new System.Drawing.Size(381, 43);
            this.panelShowCategory.TabIndex = 87;
            // 
            // category
            // 
            this.category.FormattingEnabled = true;
            this.category.Location = new System.Drawing.Point(215, 9);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(153, 23);
            this.category.TabIndex = 88;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Guttman Stam", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(3, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 24);
            this.label10.TabIndex = 4;
            this.label10.Text = "Category :";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelAction);
            this.panel1.Controls.Add(this.panelShowPartCategory);
            this.panel1.Controls.Add(this.panelShowCategory);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(88, 124);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 150);
            this.panel1.TabIndex = 87;
            // 
            // panelAction
            // 
            this.panelAction.Controls.Add(this.specialButton1);
            this.panelAction.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAction.Location = new System.Drawing.Point(0, 138);
            this.panelAction.Name = "panelAction";
            this.panelAction.Size = new System.Drawing.Size(381, 49);
            this.panelAction.TabIndex = 88;
            // 
            // specialButton1
            // 
            this.specialButton1.BackColor = System.Drawing.Color.Transparent;
            this.specialButton1.BackgroundColor = System.Drawing.Color.Transparent;
            this.specialButton1.BackgroundImage = global::AppLayer.Properties.Resources.searchButton;
            this.specialButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.specialButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.specialButton1.BorderRadius = 20;
            this.specialButton1.BorderSize = 0;
            this.specialButton1.FlatAppearance.BorderSize = 0;
            this.specialButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.specialButton1.ForeColor = System.Drawing.Color.White;
            this.specialButton1.Location = new System.Drawing.Point(131, 6);
            this.specialButton1.Name = "specialButton1";
            this.specialButton1.Size = new System.Drawing.Size(108, 37);
            this.specialButton1.TabIndex = 89;
            this.specialButton1.TextColor = System.Drawing.Color.White;
            this.specialButton1.UseVisualStyleBackColor = false;
            this.specialButton1.Click += new System.EventHandler(this.specialButton1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label15);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(381, 52);
            this.panel2.TabIndex = 88;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(33, 7);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(314, 42);
            this.label15.TabIndex = 54;
            this.label15.Text = "Fill in the search Category\r\n fields:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkComboBox1
            // 
            this.checkComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.checkComboBox1.Font = new System.Drawing.Font("Guttman Mantova-Decor", 9.749998F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkComboBox1.FormattingEnabled = true;
            this.checkComboBox1.Location = new System.Drawing.Point(239, 67);
            this.checkComboBox1.Name = "checkComboBox1";
            this.checkComboBox1.Size = new System.Drawing.Size(196, 26);
            this.checkComboBox1.TabIndex = 79;
            this.checkComboBox1.Text = "Select Search Options";
            // 
            // ShowSearchExistingCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkComboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ShowSearchExistingCategories";
            this.Size = new System.Drawing.Size(557, 297);
            this.Load += new System.EventHandler(this.ShowExistingCategories_Load);
            this.panelShowPartCategory.ResumeLayout(false);
            this.panelShowPartCategory.PerformLayout();
            this.panelShowCategory.ResumeLayout(false);
            this.panelShowCategory.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panelAction.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Panel panelShowPartCategory;
        private Label label9;
        private Panel panelShowCategory;
        private Label label10;
        private Panel panel1;
        private SpecialComponents.CheckComboBox checkComboBox1;
        private Panel panelAction;
        private SpecialComponents.SpecialButton specialButton1;
        private Panel panel2;
        private Label label15;
        private ComboBox category;
        private TextBox partCategory;
    }
}
