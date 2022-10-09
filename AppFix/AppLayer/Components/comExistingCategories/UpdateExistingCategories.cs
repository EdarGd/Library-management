using DataAccessLayer.Entities;
using AppLayer.SpecialComponents.DbFunc;


namespace AppLayer.Components.comExistingCategories
{
    public partial class UpdateExistingCategories : UserControl
    {

        ExistingCategory? nowExistingCategory;
        public ExistingCategory? NowExistingCategory
        {
            get { return nowExistingCategory; }
            set { nowExistingCategory = value; }
        }
        public ExistingCategory? newExistingCategory;
        public ExistingCategory? NewExistingCategory
        {
            get { return newExistingCategory; }
            set { newExistingCategory = value; }
        }
        public UpdateExistingCategories()
        {
            InitializeComponent();
        }

        public UpdateExistingCategories(ExistingCategory nowExistingCategory)
        {
            InitializeComponent();
            NowExistingCategory = newExistingCategory =  nowExistingCategory;
            category.Text = nowExistingCategory.Category;
            secondaryCategory.Text = nowExistingCategory.SecondaryCategory;
            newCategory.Text = newExistingCategory.Category;
            newSecondaryCategory.Text = newExistingCategory.SecondaryCategory;

        }

        List<string>? categories;
        List<string>? secondaryCategorySelect;


        private void UpdateExistingCategories_Load(object sender, EventArgs e)
        {
            categories = new List<string>();
            secondaryCategorySelect = new List<string>();
            ExistingCategoriesFun.createCategories(categories, category);
        }

        private void category_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ExistingCategoriesFun.category_SelectedIndexChanged(secondaryCategorySelect!, secondaryCategory, category.Text);
        }

        private async void specialButton1_Click_1(object sender, EventArgs e)
        {
            NowExistingCategory = new ExistingCategory()
            {
                Category = category.Text,
                SecondaryCategory = secondaryCategory.Text,
            };
            newExistingCategory = new ExistingCategory()
            {
                Category = newCategory.Text,
                SecondaryCategory = newSecondaryCategory.Text
            };

            if (await ExistingCategoriesFun.updateExistingCategory(nowExistingCategory!, newExistingCategory))
            {
                if (MessageBox.Show("You succeeded in updating the information! How about updating me with some new songs? I love the Pigmatron", "Update successful !", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.No)
                {
                    this.Parent.Hide();
                }
            }
        }
    }
}
