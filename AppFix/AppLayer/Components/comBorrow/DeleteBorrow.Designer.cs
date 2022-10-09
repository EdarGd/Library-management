namespace AppLayer.Components.comBorrow
{
    partial class DeleteBorrow
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
            this.code = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.specialButton2 = new AppLayer.SpecialComponents.SpecialButton();
            this.SuspendLayout();
            // 
            // code
            // 
            this.code.Location = new System.Drawing.Point(296, 54);
            this.code.MaxLength = 13;
            this.code.Name = "code";
            this.code.PlaceholderText = "Enter Book Code ...";
            this.code.Size = new System.Drawing.Size(153, 23);
            this.code.TabIndex = 23;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(140, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(272, 21);
            this.label4.TabIndex = 39;
            this.label4.Text = "Insert  borrow details :";
            // 
            // specialButton2
            // 
            this.specialButton2.BackColor = System.Drawing.Color.Transparent;
            this.specialButton2.BackgroundColor = System.Drawing.Color.Transparent;
            this.specialButton2.BackgroundImage = global::AppLayer.Properties.Resources.deleteButton;
            this.specialButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.specialButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.specialButton2.BorderRadius = 20;
            this.specialButton2.BorderSize = 0;
            this.specialButton2.FlatAppearance.BorderSize = 0;
            this.specialButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.specialButton2.ForeColor = System.Drawing.Color.White;
            this.specialButton2.Location = new System.Drawing.Point(205, 96);
            this.specialButton2.Name = "specialButton2";
            this.specialButton2.Size = new System.Drawing.Size(144, 38);
            this.specialButton2.TabIndex = 57;
            this.specialButton2.TextColor = System.Drawing.Color.White;
            this.specialButton2.UseVisualStyleBackColor = false;
            this.specialButton2.Click += new System.EventHandler(this.specialButton2_Click);
            // 
            // DeleteBorrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.Controls.Add(this.specialButton2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.code);
            this.Controls.Add(this.label1);
            this.Name = "DeleteBorrow";
            this.Size = new System.Drawing.Size(557, 146);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox code;
        private Label label1;
        private Label label4;
        private SpecialComponents.SpecialButton specialButton2;
    }
}
