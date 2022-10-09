namespace AppLayer.Components.Single.Entities
{
    partial class singleBorrowInnerjoinBookUser
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDelete1 = new AppLayer.Components.Single.btnDelete();
            this.lastName = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.code = new System.Windows.Forms.Label();
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
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.8864F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.95507F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.33836F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.82017F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btnDelete1, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.lastName, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.firstName, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.title, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.code, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.num, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnShow1, 7, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(780, 38);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.MouseEnter += new System.EventHandler(this.userEnter);
            this.tableLayoutPanel1.MouseLeave += new System.EventHandler(this.userLeave);
            // 
            // btnDelete1
            // 
            this.btnDelete1.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDelete1.Location = new System.Drawing.Point(710, 3);
            this.btnDelete1.Name = "btnDelete1";
            this.btnDelete1.Size = new System.Drawing.Size(29, 32);
            this.btnDelete1.TabIndex = 3;
            // 
            // lastName
            // 
            this.lastName.BackColor = System.Drawing.Color.Transparent;
            this.lastName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lastName.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lastName.Location = new System.Drawing.Point(557, 0);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(147, 38);
            this.lastName.TabIndex = 4;
            this.lastName.Text = "last Name";
            this.lastName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // firstName
            // 
            this.firstName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.firstName.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.firstName.Location = new System.Drawing.Point(394, 0);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(157, 38);
            this.firstName.TabIndex = 3;
            this.firstName.Text = "first Name";
            this.firstName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // title
            // 
            this.title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.title.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.title.Location = new System.Drawing.Point(214, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(174, 38);
            this.title.TabIndex = 2;
            this.title.Text = "Title Book";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // code
            // 
            this.code.CausesValidation = false;
            this.code.Dock = System.Windows.Forms.DockStyle.Fill;
            this.code.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.code.Location = new System.Drawing.Point(67, 0);
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(141, 38);
            this.code.TabIndex = 1;
            this.code.Text = "1234567890123";
            this.code.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // num
            // 
            this.num.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num.Location = new System.Drawing.Point(3, 0);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(19, 38);
            this.num.TabIndex = 0;
            this.num.Text = "12";
            this.num.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::AppLayer.Properties.Resources.animated_book_image_0012;
            this.pictureBox1.Location = new System.Drawing.Point(28, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnShow1
            // 
            this.btnShow1.BackColor = System.Drawing.Color.Transparent;
            this.btnShow1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnShow1.Location = new System.Drawing.Point(745, 3);
            this.btnShow1.Name = "btnShow1";
            this.btnShow1.Size = new System.Drawing.Size(32, 32);
            this.btnShow1.TabIndex = 7;
            // 
            // singleBorrowInnerjoinBookUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "singleBorrowInnerjoinBookUser";
            this.Size = new System.Drawing.Size(780, 38);
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
        private Label code;
        private Label lastName;
        private Label firstName;
        private Label title;
        private btnDelete btnDelete1;
        private btnShow btnShow1;
    }
}
