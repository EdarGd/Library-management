
using System.Data;


namespace AppLayer.Components.Single.Main
{
   
    public partial class showDBTable : Form
    {

        DataTable? data;
        public DataTable? Data
        {
            get { return data; }
            set { data = value; }
        }


        public showDBTable()
        {
            InitializeComponent();
        }

        public showDBTable(string nameTable,DataTable data)
        {
            InitializeComponent();
            foreach (UserControl uc in this.Controls.OfType<UserControl>()) {
                uc.Hide();
            }

            int XCenter;
            switch (nameTable)
            {
                case "Book":
                    dbBooks1 = new tableDB.dbBooks(data);
                    dbBooks1.Location = new Point(60, 101);
                    dbBooks1.Show();
                    this.Controls.Add(dbBooks1);
                    break;
                case "Borrow":
                    dbBorrows1 = new tableDB.dbBorrows(data);
                    XCenter = this.Location.X + this.Width / 2 - dbBorrows1.Width / 2 + 50;
                    dbBorrows1.Location = new Point(XCenter, 101);
                    dbBorrows1.Show();
                    this.Controls.Add(dbBorrows1);
                    break;
                case "BorrowInnerjoinBookUser":
                    dbBorrowInnerjoinBookUser1 = new tableDB.dbBorrowInnerjoinBookUser(data);
                    dbBorrowInnerjoinBookUser1.Location = new Point(60, 101);
                    dbBorrowInnerjoinBookUser1.Show();
                    this.Controls.Add(dbBorrowInnerjoinBookUser1);
                    break;
                case "ExistingCategories":
                    dbExistingCategories1 = new tableDB.dbExistingCategories(data);
                    XCenter = this.Location.X + this.Width / 2 - dbExistingCategories1.Width / 2 + 50;
                    dbExistingCategories1.Location = new Point(XCenter, 101);
                    dbExistingCategories1.Show();
                    this.Controls.Add(dbExistingCategories1);
                    break;
                case "User":
                    dbUsers1 = new tableDB.dbUsers(data);
                    dbUsers1.Location = new Point(60, 101);
                    dbUsers1.Show();
                    this.Controls.Add(dbUsers1);
                    break;

            }

        }

        public void showDBBookTable(string kindDb)
        {
            switch (kindDb)
            {
                case "Book":
                    dbBooks1.updateDbBook();
                    break;
                case "Borrow":
                    dbBorrows1.updateDbBorrow();
                    break;
                case "BorrowInnerjoinBookUser":
                    dbBorrowInnerjoinBookUser1.updateDbBorrowWithInnerJoinBookUserModel();
                    break;
                case "ExistingCategories":
                    dbExistingCategories1.updateDbExistingCategory();
                    break;
                case "User":
                    dbUsers1.updateDbUser();
                    break;

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
