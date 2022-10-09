using System.Data;
using BusinessLogicLayer.StoredProceduresLogic;
using DataAccessLayer.Entities;
using AppLayer.Components.Single.Entities;
using AppLayer.SpecialComponents.Help;

namespace AppLayer.Components.tableDB
{
    public partial class dbBooks : UserControl
    {
        Book? book;
        public Book? Book
        {
            get { return book; }
            set { book = value; }
        }
        public dbBooks()
        {
            InitializeComponent();
        }

        public dbBooks(DataTable data)
        {
            InitializeComponent();
            setPanalData(data);
            
        }

        public async void updateDbBook()
        {
            singleBook.CountLine = 0;
            panelData.Controls.Clear();
            BookLogic bookLogic = new BookLogic();
            object resFun = await bookLogic.getBooks();
            if (resFun.GetType() != typeof(DataTable))
            {
                MessageBox.Show(resFun.ToString());
            }
            else
            {
                setPanalData((resFun as DataTable)!);
            }
        }

        private void setPanalData(DataTable data)
        {
            Color[] colors = { Color.LightSkyBlue, Color.PaleTurquoise };
            int counter = 0;
            foreach (DataRow row in data.Rows)
            {
                book = new Book()
                {
                    Code = row["Code"].ToString()!,
                    Title = row["Title"].ToString()!,
                    FirstName_Author = row["FirstName_Author"].ToString()!,
                    LastName_Author = row["LastName_Author"].ToString()!,
                    PublicationDate = DateTime.Parse(row["PublicationDate"].ToString()!),
                    Category = row["Category"].ToString()!,
                    SecondaryCategory = row["SecondaryCategory"].ToString()!
                };

                singleBook single = new singleBook(book);
                single.Dock = DockStyle.Top;

                single.BackColor = HelpGeneralFunc.getTheme(ref counter, colors);
                panelData.Controls.Add(single);
            }
            HelpControlFunc.reverseOrderControlsOfControls(panelData);
        }
    }
}
