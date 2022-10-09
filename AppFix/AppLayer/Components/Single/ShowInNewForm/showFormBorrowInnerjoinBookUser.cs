namespace AppLayer.Components.Single.ShowInNewForm
{
    public partial class showFormBorrowInnerjoinBookUser : Form
    {
        public showFormBorrowInnerjoinBookUser(AppLayer.Models.BorrowWithInnerJoinBookUserModel showBorrowWithInnerJoinBookUserModel)
        {
            InitializeComponent();
            code.Text = showBorrowWithInnerJoinBookUserModel.Code;
            title.Text = showBorrowWithInnerJoinBookUserModel.Title;
            firstName.Text = showBorrowWithInnerJoinBookUserModel.FirstName;
            lastName.Text = showBorrowWithInnerJoinBookUserModel.LastName;
            id.Text = showBorrowWithInnerJoinBookUserModel.Id;

        }
    }
}
