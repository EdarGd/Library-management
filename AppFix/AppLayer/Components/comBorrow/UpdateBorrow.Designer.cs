﻿namespace AppLayer.Components.comBorrow
{
    partial class UpdateBorrow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateBorrow));
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.code = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.specialButton1 = new AppLayer.SpecialComponents.SpecialButton();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Guttman Stam", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(106, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 24);
            this.label3.TabIndex = 24;
            this.label3.Text = "id ( 9 digits) :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Guttman Stam", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(106, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 24);
            this.label1.TabIndex = 22;
            this.label1.Text = "Code ( 13 digits ) :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(149, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 21);
            this.label2.TabIndex = 39;
            this.label2.Text = "Insert  borrow details :";
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(297, 140);
            this.id.MaxLength = 9;
            this.id.Name = "id";
            this.id.PlaceholderText = "Enter User Id ...";
            this.id.Size = new System.Drawing.Size(153, 23);
            this.id.TabIndex = 41;
            // 
            // code
            // 
            this.code.Location = new System.Drawing.Point(297, 54);
            this.code.MaxLength = 13;
            this.code.Name = "code";
            this.code.PlaceholderText = "Enter Book Code ...";
            this.code.Size = new System.Drawing.Size(153, 23);
            this.code.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(67, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(424, 21);
            this.label8.TabIndex = 78;
            this.label8.Text = "Insert Borrow details to be updated :";
            // 
            // specialButton1
            // 
            this.specialButton1.BackColor = System.Drawing.Color.Transparent;
            this.specialButton1.BackgroundColor = System.Drawing.Color.Transparent;
            this.specialButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("specialButton1.BackgroundImage")));
            this.specialButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.specialButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.specialButton1.BorderRadius = 40;
            this.specialButton1.BorderSize = 0;
            this.specialButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.specialButton1.FlatAppearance.BorderSize = 0;
            this.specialButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.specialButton1.ForeColor = System.Drawing.Color.White;
            this.specialButton1.Location = new System.Drawing.Point(201, 173);
            this.specialButton1.Name = "specialButton1";
            this.specialButton1.Size = new System.Drawing.Size(162, 43);
            this.specialButton1.TabIndex = 79;
            this.specialButton1.TextColor = System.Drawing.Color.White;
            this.specialButton1.UseVisualStyleBackColor = false;
            this.specialButton1.Click += new System.EventHandler(this.specialButton1_Click);
            // 
            // UpdateBorrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.Controls.Add(this.specialButton1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.id);
            this.Controls.Add(this.code);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "UpdateBorrow";
            this.Size = new System.Drawing.Size(557, 216);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label3;
        private Label label1;
        private Label label2;
        private TextBox id;
        private TextBox code;
        private Label label8;
        private SpecialComponents.SpecialButton specialButton1;
    }
}
