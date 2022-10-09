namespace AppLayer.Components.Single.Entities
{
    partial class singleExistingCategories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(singleExistingCategories));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnUpDate1 = new AppLayer.Components.Single.btnAction.btnUpDate();
            this.btnDelete1 = new AppLayer.Components.Single.btnDelete();
            this.secondaryCategory = new System.Windows.Forms.Label();
            this.category = new System.Windows.Forms.Label();
            this.num = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnShow1 = new AppLayer.Components.Single.btnShow();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.17524F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.82476F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Controls.Add(this.btnUpDate1, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDelete1, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.secondaryCategory, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.category, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.num, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnShow1, 6, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(440, 38);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.MouseEnter += new System.EventHandler(this.userEnter);
            this.tableLayoutPanel1.MouseLeave += new System.EventHandler(this.userLeave);
            // 
            // btnUpDate1
            // 
            this.btnUpDate1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpDate1.Location = new System.Drawing.Point(372, 3);
            this.btnUpDate1.Name = "btnUpDate1";
            this.btnUpDate1.Size = new System.Drawing.Size(29, 32);
            this.btnUpDate1.TabIndex = 3;
            // 
            // btnDelete1
            // 
            this.btnDelete1.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDelete1.Location = new System.Drawing.Point(337, 3);
            this.btnDelete1.Name = "btnDelete1";
            this.btnDelete1.Size = new System.Drawing.Size(29, 32);
            this.btnDelete1.TabIndex = 3;
            // 
            // secondaryCategory
            // 
            this.secondaryCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.secondaryCategory.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.secondaryCategory.Location = new System.Drawing.Point(203, 0);
            this.secondaryCategory.Name = "secondaryCategory";
            this.secondaryCategory.Size = new System.Drawing.Size(128, 38);
            this.secondaryCategory.TabIndex = 7;
            this.secondaryCategory.Text = "secondaryCategory";
            this.secondaryCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // category
            // 
            this.category.Dock = System.Windows.Forms.DockStyle.Fill;
            this.category.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.category.Location = new System.Drawing.Point(78, 0);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(119, 38);
            this.category.TabIndex = 6;
            this.category.Text = "Category";
            this.category.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // num
            // 
            this.num.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num.Location = new System.Drawing.Point(3, 0);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(29, 38);
            this.num.TabIndex = 0;
            this.num.Text = "123";
            this.num.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(38, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnShow1
            // 
            this.btnShow1.BackColor = System.Drawing.Color.Transparent;
            this.btnShow1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnShow1.Location = new System.Drawing.Point(407, 3);
            this.btnShow1.Name = "btnShow1";
            this.btnShow1.Size = new System.Drawing.Size(30, 32);
            this.btnShow1.TabIndex = 8;
            // 
            // singleExistingCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "singleExistingCategories";
            this.Size = new System.Drawing.Size(440, 38);
            this.MouseEnter += new System.EventHandler(this.userEnter);
            this.MouseLeave += new System.EventHandler(this.userLeave);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label num;
        private PictureBox pictureBox1;
        private Label secondaryCategory;
        private Label category;
        private btnDelete btnDelete1;
        private btnAction.btnUpDate btnUpDate1;
        private btnShow btnShow1;
    }
}
