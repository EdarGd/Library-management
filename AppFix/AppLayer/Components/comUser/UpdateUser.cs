using DataAccessLayer.Entities;
using AppLayer.SpecialComponents.DbFunc;

namespace AppLayer.Components.comUser
{
    public partial class UpdateUser : UserControl
    {
        

        User? user;
        public User? User
        {
            get { return user; }
            set { user = value; }
        }

        public UpdateUser()
        {
            InitializeComponent();
            type.SelectedIndex = 1;
        }

        public UpdateUser(User upUser)
        {
            InitializeComponent();
            User = upUser;
            id.Text = upUser.Id;
            firstName.Text = upUser.FirstName;
            lastName.Text = upUser.LastName;
            email.Text = upUser.Email;
            password.Text = upUser.Password;
            if (upUser.Type)
            {
                type.Text = "Worker";
            }
            else
            {
                type.Text = "Subscription";
            }

        }

        private async void specialButton1_Click(object sender, EventArgs e)
        {
            bool typeUser = false;
            if(type.SelectedIndex == 0)
            {
                typeUser = true;
            }
            User = new User()
            {
                Id = id.Text,
                Email = email.Text,
                FirstName = firstName.Text,
                LastName = lastName.Text,
                Password = password.Text,
                Type = typeUser
            };

            if (await UserFunc.updateUser(User!))
            {
                if (MessageBox.Show("You succeeded in updating the information! How about updating me with some new songs? I love the Pigmatron", "Update successful !", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.No)
                {
                    this.Parent.Hide();
                }
            }
        }
    }
}
