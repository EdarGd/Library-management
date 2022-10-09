using AppLayer.SpecialComponents.DbFunc;
using DataAccessLayer.Entities;



namespace AppLayer.Components.comBook
{
    public partial class AddBook : UserControl
    {
        List<string>? categories;
        List<string>? secondaryCategorySelect;
        Book? book;
        public Book? Book
        {
            get { return book; }
            set { book = value; }
        }


        public AddBook()
        {
            InitializeComponent();
        }

        private void AddBook_Load(object sender, EventArgs e)
        {
            publicationDate.MaxDate = DateTime.Now;
            categories = new List<string>();
            secondaryCategorySelect = new List<string>();

             ExistingCategoriesFun.createCategories(categories, category);

            if (Book != null)
            {
                code.Text = book!.Code;
                publicationDate.Value = book.PublicationDate;
                title.Text = book.Title;
                firstNameAuthor.Text = book.FirstName_Author;
                lastNameAuthor.Text = book.LastName_Author;
                category.Text = book.Category;
                secondaryCategory.Text = book.SecondaryCategory;
            }

            
        }

        private async void specialButton1_Click(object sender, EventArgs e)
        {
            Book = new Book()
            {
                Code = code.Text,
                Title = title.Text,
                FirstName_Author = firstNameAuthor.Text,
                LastName_Author = lastNameAuthor.Text,
                Category = category.Text,
                
                SecondaryCategory = secondaryCategory.Text,
                PublicationDate = publicationDate.Value,
            };

            if (await BookFunc.addBook(book!))
            {
                if(MessageBox.Show("Now you can add more information to the database, or eat a hamburger your decision!!!", "Add successful !", MessageBoxButtons.YesNo,MessageBoxIcon.Asterisk,MessageBoxDefaultButton.Button1)== System.Windows.Forms.DialogResult.No)
                {
                    this.Parent.Hide();
                }
            }
        }

        private void category_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ExistingCategoriesFun.category_SelectedIndexChanged(secondaryCategorySelect!, secondaryCategory, category.Text);
        }
    }
}
