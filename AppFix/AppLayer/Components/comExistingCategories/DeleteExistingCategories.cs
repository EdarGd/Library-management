using DataAccessLayer.Entities;
using AppLayer.SpecialComponents.DbFunc;

namespace AppLayer.Components.comExistingCategories
{
    public partial class DeleteExistingCategories : UserControl
    {
        public DeleteExistingCategories()
        {
            InitializeComponent();
        }

        List<string>? categoriesL;
        List<string>? secondaryCategorySelect;

        ExistingCategory? existingCategory;
        public ExistingCategory? ExistingCategory
        {
            get { return existingCategory; }
            set { existingCategory = value; }
        }

        private void DeleteExistingCategories_Load(object sender, EventArgs e)
        {
            categoriesL = new List<string>();
            secondaryCategorySelect = new List<string>();
            ExistingCategoriesFun.createCategories(categoriesL, category);
        }

        private void category_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ExistingCategoriesFun.category_SelectedIndexChanged(secondaryCategorySelect!, secondaryCategory, category.Text);
        }

        private async void specialButton2_Click(object sender, EventArgs e)
        {
            string secondaryCategoryValue = "general";
            if (secondaryCategory.SelectedIndex != 0)
            {
                secondaryCategoryValue = secondaryCategory.Text;
            }
            ExistingCategory = new ExistingCategory()
            {
                Category = category.Text,
                SecondaryCategory = secondaryCategoryValue
            };
            if (await ExistingCategoriesFun.deleteSelectedExistingCategory(ExistingCategory))
            {
                if (MessageBox.Show("The information has been successfully deleted! , And now what about erasing my minus in the bank ?", "Delete successful !", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.No)
                {
                    this.Parent.Hide();
                }
            }
        }
    }
}
