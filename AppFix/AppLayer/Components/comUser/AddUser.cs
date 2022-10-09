using DataAccessLayer.Entities;
using AppLayer.SpecialComponents.DbFunc;

namespace AppLayer.Components.comUser
{
    public partial class AddUser : UserControl
    {
        User? user;
        public User? User
        {
            get { return user; }
            set { user = value; }
        }
        public AddUser()
        {
            InitializeComponent();
            type.SelectedIndex = 1;
        }

        private async void specialButton1_Click(object sender, EventArgs e)
        {
            bool typeUser = false;
            if(type.SelectedIndex == 1)
            {
                typeUser = true;
            }
            user = new User()
            {
                Id = id.Text,
                Email = email.Text,
                Password = password.Text,
                Type = typeUser,
                FirstName = firstName.Text,
                LastName = lastName.Text,
                
            };

            if (await UserFunc.addUser(user))
            {
                if (MessageBox.Show("Now you can add more information to the database, or eat a hamburger your decision!!!", "Add successful !", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.No)
                {
                    this.Parent.Hide();
                }
            }
        }
    }
}
