using AppLayer.SpecialComponents.Help;

namespace AppLayer.Components.comUser
{
    public partial class AreaUser : Form
    {

        string kindActionNow;
        public string KindAction
        {
            get { return kindActionNow; }
            set { kindActionNow = value; }
        }

        public AreaUser(string kindAction)
        {
            InitializeComponent();
            kindActionNow = kindAction;
        }

        private void AreaUser_Load(object sender, EventArgs e)
        {
            UserControl[] UCsBook = { addUser1, deleteUser1, showUser1, updateUser2};
            HelpFormUCFunc.hideAndShowUC(UCsBook, KindAction, this.MdiParent);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
