namespace AppLayer.Components.Single.ShowInNewForm
{
    public partial class showFormUser : Form
    {
        public showFormUser(DataAccessLayer.Entities.User showUser)
        {
            InitializeComponent();
            id.Text = showUser.Id;
            firstName.Text = showUser.FirstName;
            lastName.Text = showUser.LastName;
            email.Text = showUser.Email;
            if (showUser.Type)
                userType.Text = "Worker";
            else
                userType.Text =  "Library subscription";
            password.Text = showUser.Password;

        }
    }
}
