namespace AppLayer.Components.Single.ShowInNewForm
{
    public partial class showFormBorrow : Form
    {
        public showFormBorrow(DataAccessLayer.Entities.Borrow borrow)
        {
            InitializeComponent();
            code.Text = borrow.Code;
            id.Text = borrow.Id;
        }
    }
}
