using DataAccessLayer.Entities;
using AppLayer.SpecialComponents.DbFunc;

namespace AppLayer.Components.comBorrow
{
    public partial class UpdateBorrow : UserControl
    {

        Borrow? borrow;
        public Borrow? Borrow
        {
            get { return borrow; }
            set { borrow = value; }
        }

        public UpdateBorrow()
        {
            InitializeComponent();
        }

        public UpdateBorrow(Borrow upBorrow)
        {
            InitializeComponent();
            Borrow = upBorrow;
            code.Text = upBorrow.Code;
            id.Text = upBorrow.Id;
        }

        private async void specialButton1_Click(object sender, EventArgs e)
        {
            Borrow = new Borrow()
            {
                Code = code.Text,
                Id = id.Text,
            };

            if (await BorrowFunc.updateBoorow(Borrow!))
            {
                if (MessageBox.Show("You succeeded in updating the information! How about updating me with some new songs? I love the Pigmatron", "Update successful !", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.No)
                {
                    this.Parent.Hide();
                }
            }
        }
    }
}
