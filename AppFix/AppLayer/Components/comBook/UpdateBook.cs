
using DataAccessLayer.Entities;
using AppLayer.SpecialComponents.DbFunc;


namespace AppLayer.Components.comBook
{
    public partial class UpdateBook : UserControl
    {

        Book? book;
        public Book? Book
        {
            get { return book; }
            set { book = value; }
        }

        List<string> categories = new List<string>();
        List<string> secondaryCategorySelect = new List<string>();

        public UpdateBook()
        {
            InitializeComponent();
            publicationDate.MaxDate = DateTime.Now;
        }

        public UpdateBook(Book upBook)
        {
            InitializeComponent();
            publicationDate.MaxDate = DateTime.Now;
            Book = upBook;
            code.Text = upBook.Code;
            title.Text = upBook.Title;
            firstNameAuthor.Text = upBook.FirstName_Author;
            lastNameAuthor.Text = upBook.LastName_Author;
            publicationDate.Value = upBook.PublicationDate;
            category.Text = upBook.Category;
            secondaryCategory.Text = upBook.SecondaryCategory;

        }

        private void UpdateBook_Load(object sender, EventArgs e)
         {

            categories = new List<string>();
            secondaryCategorySelect = new List<string>();

            ExistingCategoriesFun.createCategories(categories, category);

            if (book != null)
            {
                code.Text = book.Code;
                title.Text = book.Title;
                firstNameAuthor.Text = book.FirstName_Author;
                lastNameAuthor.Text = book.LastName_Author;
                publicationDate.MaxDate = book.PublicationDate;
                category.Text = book.Category;
                secondaryCategory.Text = book.SecondaryCategory;
            }

            else
            {
                publicationDate.MaxDate = DateTime.Now;
            }



        }

        private async void specialButton1_Click(object sender, EventArgs e)
        {
            if (secondaryCategory.SelectedIndex == 0)
                secondaryCategory.Text = "";
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

            if (await BookFunc.updateBook(book!))
            {
                if (MessageBox.Show("You succeeded in updating the information! How about updating me with some new songs? I love the Pigmatron", "Update successful !", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.No)
                {
                    this.Parent.Hide();
                }
            }
        }

        private void category_SelectedIndexChanged(object sender, EventArgs e)
        {
            ExistingCategoriesFun.category_SelectedIndexChanged(secondaryCategorySelect, secondaryCategory, category.Text);
        }
    }
}
