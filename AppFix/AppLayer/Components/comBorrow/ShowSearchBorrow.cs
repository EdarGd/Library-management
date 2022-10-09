using AppLayer.SpecialComponents.Help;
using AppLayer.SpecialComponents.DbFunc;

namespace AppLayer.Components.comBorrow
{
    public partial class ShowSearchBorrow : UserControl
    {
        public ShowSearchBorrow()
        {
            InitializeComponent();
        }

        private void ShowBorrow_Load(object sender, EventArgs e)
        {
            string[] fieldsName = { "Code", "Id", "By User Type" };
            Control[] fieldsControls = { panelCode, panelId, panelByUserType };
            foreach (Control field in fieldsControls)
            {
                field.Hide();
                field.Tag = "hide";
            }
            panel1.Hide();
            userType.SelectedIndex = 0;

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

        private void specialButton1_Click(object sender, EventArgs e)
        {
            switch (checkComboBox1.Text)
            {
                case "Code":
                    string codeBook = code.Text;
                    BorrowFunc.ShowFromBorrow_SpecificBook(codeBook, this.ParentForm, this.ParentForm.MdiParent);
                    break;
                case "Id":
                    string idUser = id.Text;
                    BorrowFunc.ShowFromBorrow_UserBorrows(idUser, this.ParentForm, this.ParentForm.MdiParent);
                    break;
                case "By User Type":
                    bool type;
                    if(userType.SelectedIndex == 0)
                    {
                        type = true;
                    }
                    else
                    {
                        type = false;
                    }
                    string idUserBorrowed = idBorrowed.Text;
                    BorrowFunc.ShowFromBorrow_byUserCheckType(type,idUserBorrowed, this.ParentForm, this.ParentForm.MdiParent);
                    break;
            }
        }
    }
}
