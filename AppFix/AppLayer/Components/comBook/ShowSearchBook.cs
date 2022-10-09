using AppLayer.SpecialComponents.Help;
using AppLayer.SpecialComponents.DbFunc;

namespace AppLayer.Components.comBook
{
    public partial class ShowSearchBook : UserControl
    {
        public ShowSearchBook()
        {
            InitializeComponent();

            // add three check box items to the combo box and set their checked states to true
            string[] fieldsName = { "Code", "Title",
                                    "First Name Author", "Last Name Author","Name Author",
                                    "Publication Year",
                                    "Category"};
            Control[] fieldsControls = { panelCode, panelTitle, panelFirstNameAuthor, panelLastNameAuthor,panelNameAuthor ,panelPublicationYear, panelCategory };
            foreach (Control field in fieldsControls)
            {
                field.Hide();
                field.Tag = "hide";
            }
            panel.Hide();

            try
            {
                HelpControlFunc.createCheckComboBoxList(fieldsName, checkComboBox1, fieldsControls, panel);

                Bitmap bitmap = new Bitmap(new Bitmap("Search.png"), new Size(30, 30));
                specialButton1.Cursor = new Cursor(bitmap.GetHicon());
            }
            catch
            {
                return;
            }


        }

        List<string>? categories;
        private void ShowBook_Load(object sender, EventArgs e)
        {
            categories = new List<string>();

            ExistingCategoriesFun.createCategories(categories, category);
        }

        private void specialButton1_Click(object sender, EventArgs e)
        {
            switch (checkComboBox1.Text)
            {
                case "Code":
                    string codeBook = code.Text;
                    BookFunc.ShowFromBook_BookFromSpecificCode(codeBook, this.ParentForm, this.ParentForm.MdiParent);
                    break;
                case "Title":
                    string titleBook = title.Text;
                    BookFunc.ShowFromBook_BooksFromTitle(titleBook, this.ParentForm, this.ParentForm.MdiParent);
                    break;
                case "First Name Author":
                    string firstName = firstNameAuthor.Text;
                    BookFunc.ShowFromBook_BooksFromFirstName_Author(firstName, this.ParentForm, this.ParentForm.MdiParent);
                    break;
                case "Last Name Author":
                    string lastName = lastNameAuthor.Text;
                    BookFunc.ShowFromBook_BooksFromLastName_Author(lastName, this.ParentForm, this.ParentForm.MdiParent);
                    break;
                case "Name Author":
                    string firstNameAuthorAll = firstNameAll.Text;
                    string lastNameAuthorAll = lastNameAll.Text;
                    BookFunc.ShowFromBook_BooksFromName_Author(firstNameAuthorAll, lastNameAuthorAll, this.ParentForm, this.ParentForm.MdiParent);
                    break;
                case "Publication Year":
                    int year = (int)publicationYear.Value;
                    BookFunc.ShowFromBook_BooksFromPublicationYear(year, this.ParentForm, this.ParentForm.MdiParent);
                    break;
                case "Category":
                    string categoryChoose = category.Text;
                    BookFunc.ShowFromBook_BooksFromCategory(categoryChoose, this.ParentForm, this.ParentForm.MdiParent);
                    break;
            }
        }
    }
}
