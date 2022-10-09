using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppLayer.SpecialComponents.Help;
using DataAccessLayer.Entities;

namespace AppLayer.Components.Single.Entities
{
    public partial class singleExistingCategories : UserControl
    {


        #region Set Values to UC
        private ExistingCategory? existingCategory;
        public ExistingCategory? ExistingCategory
        {
            get { return existingCategory; }
            set
            {
                existingCategory = value;
                if (existingCategory != null)
                {
                    category.Text = existingCategory.Category;
                    secondaryCategory.Text = existingCategory.SecondaryCategory;
                    num.Text = CountLine + "";
                }

            }
        }
        #endregion

        static int countline = 0;
        public static int CountLine
        {
            get { return countline; }
            set { countline = value; }
        }


        public singleExistingCategories()
        {
            InitializeComponent();
        }

        public singleExistingCategories(ExistingCategory showExistingCategory)
        {
            InitializeComponent();
            countline++;
            ExistingCategory = showExistingCategory;
            btnDelete1.addEventTopictureBox1Click(showExistingCategory, "ExistingCategories");
            btnShow1.addEventTopictureBox1Click(showExistingCategory, "ExistingCategories");
            btnUpDate1.addEventTopictureBox1Click(showExistingCategory, "ExistingCategories");
            foreach (Control control in tableLayoutPanel1.Controls)

            {
                control.MouseEnter += new System.EventHandler(userEnter!);
                control.MouseLeave += new System.EventHandler(userLeave!);
            }
        }

        Boolean hoverNow = false;
        Color temp;

        private void userEnter(object sender, EventArgs e)
        {
            Color BackColorNow = this.BackColor;
            HelpGeneralFunc.userEnter(ref temp, ref BackColorNow, ref hoverNow);
            this.BackColor = BackColorNow;
        }

        private void userLeave(object sender, EventArgs e)
        {
            Color BackColorNow = this.BackColor;
            HelpGeneralFunc.userLeave(ref temp, ref BackColorNow, ref hoverNow);
            this.BackColor = BackColorNow;


        }
    }
}
