
namespace AppLayer.Components.Single.ShowInNewForm
{
    public partial class showFormExistingCategory : Form
    {
        public showFormExistingCategory(DataAccessLayer.Entities.ExistingCategory existingCategory)
        {
            InitializeComponent();
            category.Text = existingCategory.Category;
            secondaryCategory.Text = existingCategory.SecondaryCategory;
        }
    }
}
