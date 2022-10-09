using AppLayer.SpecialComponents.Help;

namespace AppLayer.Components.comBook
{
    public partial class AreaBook : Form
    {
        string kindActionNow;
        public string KindActionNow
        {
            get { return kindActionNow; }
            set { kindActionNow = value; }
        }
        public AreaBook(string kindAction)
        {
            InitializeComponent();
            kindActionNow = kindAction;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AreaBook_Load(object sender, EventArgs e)
        {
            UserControl[] UCsBook = { addBook2, deleteBook1, showSearchBook1, updateBook1 };
            HelpFormUCFunc.hideAndShowUC(UCsBook, KindActionNow, this.MdiParent);        
        }
    }
}
