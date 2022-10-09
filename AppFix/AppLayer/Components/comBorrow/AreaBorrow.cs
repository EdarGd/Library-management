using AppLayer.SpecialComponents.Help;

namespace AppLayer.Components.comBorrow
{
    public partial class AreaBorrow : Form
    {
        string kindActionNow;
        public string KindActionNow
        {
            get { return kindActionNow; }
            set { kindActionNow = value; }
        }

        public AreaBorrow(string kindAction)
        {
            InitializeComponent();
            kindActionNow = kindAction;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void AreaBorrow_Load(object sender, EventArgs e)
        {
            UserControl[] UCsBook = { addBorrow1, deleteBorrow1, showBorrow1, updateBorrow1 };
            HelpFormUCFunc.hideAndShowUC(UCsBook, KindActionNow, this.MdiParent);
        }


    }
}
