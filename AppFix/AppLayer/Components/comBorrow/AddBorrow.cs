using DataAccessLayer.Entities;
using AppLayer.SpecialComponents.DbFunc;

namespace AppLayer.Components.comBorrow
{
    public partial class AddBorrow : UserControl
    {
        public AddBorrow()
        {
            InitializeComponent();
        }

        Borrow? borrow;
        public Borrow? Borrow
        {
            get { return borrow; }
            set { borrow = value; }
        }

        private void AddBorrow_Load(object sender, EventArgs e)
        {

            if (borrow != null)
            {
                code.Text = borrow!.Code;
                id.Text = borrow.Id;
            }
        }

        private async void specialButton1_Click(object sender, EventArgs e)
        {
            borrow = new Borrow()
            {
                Code = code.Text,
                Id = id.Text,
            };

            if (await BorrowFunc.addBoorow(borrow))
            {
                if (MessageBox.Show("Now you can add more information to the database, or eat a hamburger your decision!!!", "Add successful !", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.No)
                {
                    this.Parent.Hide();
                }
            }
        }
    }
}
