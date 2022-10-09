
namespace AppLayer.Components.Single
{
    public partial class updateFromTable : Form
    {
        public updateFromTable(Object objUpdate,string kindUpdate)
        {
            InitializeComponent();
            foreach(UserControl userControl in this.Controls)
            {
                userControl.Hide();
            }
            switch (kindUpdate)
            {
                case "Book":
                    updateBook1 = new comBook.UpdateBook((objUpdate as DataAccessLayer.Entities.Book)!);
                    updateBook1.Location = new Point(50, 50);
                    updateBook1.Show();
                    this.Controls.Add(updateBook1);
                    break;
                case "Borrow":
                    updateBorrow1 = new comBorrow.UpdateBorrow((objUpdate as DataAccessLayer.Entities.Borrow)!);
                    updateBorrow1.Location = new Point(50, 50);
                    updateBorrow1.Show();
                    this.Controls.Add(updateBorrow1);
                    break;
                case "ExistingCategories":
                    updateExistingCategories1 = new comExistingCategories.UpdateExistingCategories((objUpdate as DataAccessLayer.Entities.ExistingCategory)!);
                    updateExistingCategories1.Location = new Point(50, 50);
                    updateExistingCategories1.Show();
                    this.Controls.Add(updateExistingCategories1);
                    break;
                case "User":
                    updateUser1 = new comUser.UpdateUser((objUpdate as DataAccessLayer.Entities.User)!);
                    updateUser1.Location = new Point(50, 50);
                    updateUser1.Show();
                    this.Controls.Add(updateUser1);
                    break;

            }
        }
    }
}
