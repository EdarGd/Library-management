using DataAccessLayer.Entities;
using AppLayer.SpecialComponents.DbFunc;


namespace AppLayer.Components.comExistingCategories
{
    public partial class AddExistingCategories : UserControl
    {
        public AddExistingCategories()
        {
            InitializeComponent();
        }

        ExistingCategory? existingCategory;
        public ExistingCategory? ExistingCategory
        {
            get { return existingCategory; }
            set { existingCategory = value; }
        }

        private async void specialButton1_Click(object sender, EventArgs e)
        {
            existingCategory = new ExistingCategory()
            {
                Category = category.Text,
                SecondaryCategory = secondaryCategory.Text,
            };

            if (await ExistingCategoriesFun.addExistingCategory(ExistingCategory!))
            {
                if (MessageBox.Show("Now you can add more information to the database, or eat a hamburger your decision!!!", "Add successful !", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.No)
                {
                    this.Parent.Hide();
                }
            }
        }


    }
}
