using AppLayer.SpecialComponents.Help;
using AppLayer.SpecialComponents.DbFunc;

namespace AppLayer.Components.comExistingCategories
{
    public partial class ShowSearchExistingCategories : UserControl
    {
        public ShowSearchExistingCategories()
        {
            InitializeComponent();

            string[] fieldsName = { "Show Category", "Show Part Category" };
            Control[] fieldsControls = { panelShowPartCategory, panelShowCategory };
            foreach (Control field in fieldsControls)
            {
                field.Hide();
                field.Tag = "hide";
            }
            panel1.Hide();

            try
            {
                HelpControlFunc.createCheckComboBoxList(fieldsName, checkComboBox1, fieldsControls, panel1);

                Bitmap bitmap = new Bitmap(new Bitmap("Search.png"), new Size(30, 30));
                specialButton1.Cursor = new Cursor(bitmap.GetHicon());
            }
            catch
            {
                return;
            }

        }

        List<string>? categories;


        private void ShowExistingCategories_Load(object sender, EventArgs e)
        {
            categories = new List<string>();
            ExistingCategoriesFun.createCategories(categories, category);
        }

        private void specialButton1_Click(object sender, EventArgs e)
        {
            switch (checkComboBox1.Text)
            {
                case "Show Category":
                    string categorySelect = category.Text;
                    ExistingCategoriesFun.ShowFromExistingCategories_SubcategoryFromSpecificCategory(categorySelect, this.ParentForm, this.ParentForm.MdiParent);
                    break;
                case "Show Part Category":
                    string partCategorySelect = partCategory.Text;
                    ExistingCategoriesFun.ShowFromExistingCategories_SubcategoryFromCategory(partCategorySelect, this.ParentForm, this.ParentForm.MdiParent);
                    break;
            }
        }
    }
}
