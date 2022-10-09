using AppLayer.SpecialComponents.DbFunc;

namespace AppLayer.Components.comUser
{
    public partial class DeleteUser : UserControl
    {
        public DeleteUser()
        {
            InitializeComponent();
        }

        private async void specialButton1_Click(object sender, EventArgs e)
        {
            if (await UserFunc.deleteSelectedUser(id.Text))
            {
                if (MessageBox.Show("The information has been successfully deleted! , And now what about erasing my minus in the bank ?", "Delete successful !", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.No)
                {
                    this.Parent.Hide();
                }
            }
        }
    }
}
