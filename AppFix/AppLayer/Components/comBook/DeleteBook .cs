using AppLayer.SpecialComponents.DbFunc;

namespace AppLayer.Components.comBook
{
    public partial class DeleteBook : UserControl
    {

        string? codeBook;
        public string? CodeBook
        {
            get { return codeBook; }
            set { codeBook = value; }
        }
        public DeleteBook()
        {
            InitializeComponent();
        }

        private void DeleteBook_Load(object sender, EventArgs e)
        {
            if (codeBook != null)
                code.Text = codeBook;
        }

        private async void specialButton1_Click(object sender, EventArgs e)
        {
            if (await BookFunc.deleteBook(code.Text))
            {
                if (MessageBox.Show("The information has been successfully deleted! , And now what about erasing my minus in the bank ?", "Delete successful !", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.No)
                {
                    this.Parent.Hide();
                }
            }
        }
    }
}
