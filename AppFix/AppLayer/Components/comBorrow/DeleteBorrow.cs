using AppLayer.SpecialComponents.DbFunc;

namespace AppLayer.Components.comBorrow
{
    public partial class DeleteBorrow : UserControl
    {
        public DeleteBorrow()
        {
            InitializeComponent();
        }

        private async void specialButton2_Click(object sender, EventArgs e)
        {
            if (await BorrowFunc.deleteSelectedBorrow(code.Text))
            {
                if (MessageBox.Show("The information has been successfully deleted! , And now what about erasing my minus in the bank ?", "Delete successful !", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.No)
                {
                    this.Parent.Hide();
                }
            }
        }
    }
}
