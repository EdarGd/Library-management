using AppLayer.SpecialComponents.Help;
using AppLayer.SpecialComponents.DbFunc;

namespace AppLayer.Components.comUser
{
    public partial class ShowSearchUser : UserControl
    {
        public ShowSearchUser()
        {
            InitializeComponent();

            // add three check box items to the combo box and set their checked states to true
            string[] fieldsName = { "Id", "Email","Password", "MainDetails",
                                    "First Name","Last Name" , "Name"
                                    };
            Control[] fieldsControls = { panelId , panelEmail, panelPassword, panelFirstName, panelLastName, panelMainDetails,panelName };
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

        private void specialButton1_Click(object sender, EventArgs e)
        {
            switch (checkComboBox1.Text)
            {
                case "Id":
                    string idUser = id.Text;
                    UserFunc.ShowFromUser_UserFromSpecificId(idUser, this.ParentForm, this.ParentForm.MdiParent);
                    break;
                case "Email":
                    string emailUser = email.Text;
                    UserFunc.ShowFromUser_UserFromSpecificEmail(emailUser, this.ParentForm, this.ParentForm.MdiParent);
                    break;
                case "Password":
                    string passwordUser = password.Text;
                    UserFunc.ShowFromUser_UserFromSpecificPassword(passwordUser, this.ParentForm, this.ParentForm.MdiParent);
                    break;
                case "MainDetails":
                    string idMain = idMainDetails.Text;
                    string emailMain = emailMainDetails.Text;
                    string passwordMain = passwordMainDetails.Text;
                    UserFunc.ShowFromUser_UserFromSpecific_Id_Email_Password(idMain,emailMain,passwordMain, this.ParentForm, this.ParentForm.MdiParent);
                    break;
                case "First Name":
                    string firstNameUser = firstName.Text;
                    UserFunc.ShowFromUser_UsersFromFirstName(firstNameUser, this.ParentForm, this.ParentForm.MdiParent);
                    break;
                case "Last Name":
                    string lastNameUser = lastName.Text;
                    UserFunc.ShowFromUser_UsersFromLastName(lastNameUser, this.ParentForm, this.ParentForm.MdiParent);
                    break;
                case "Name":
                    string firstNameUserFull = firstNameFull.Text;
                    string lastNameUserFull = lastNameAll.Text;
                    UserFunc.ShowFromUser_UsersFromName(firstNameUserFull, lastNameUserFull, this.ParentForm, this.ParentForm.MdiParent);
                    break;
            }
        }
    }
}
