using AppLayer.SpecialComponents.Help;

namespace AppLayer.Components.comExistingCategories
{
    public partial class AreaExistingCategories : Form
    {
        string kindActionNow;
        public string KindActionNow
        {
            get { return kindActionNow; }
            set { kindActionNow = value; }
        }

        public AreaExistingCategories(string kindAction)
        {
            InitializeComponent();
            kindActionNow = kindAction;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AreaExistingCategories_Load(object sender, EventArgs e)
        {
            UserControl[] UCs = { addExistingCategories1, deleteExistingCategories1, showExistingCategories1, updateExistingCategories1 };
            HelpFormUCFunc.hideAndShowUC(UCs, kindActionNow, this.MdiParent);
        }
    }
}
