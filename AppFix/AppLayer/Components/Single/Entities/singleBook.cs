using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppLayer.SpecialComponents.Help;

using DataAccessLayer.Entities;

namespace AppLayer.Components.Single.Entities
{

    public partial class singleBook : UserControl
    {

        #region Set Values to UC
        private Book? book;

        //public del_Child_To_Main? del_Child_To_Main;
        public Book? Book
        {
            get { return book; }
            set {
                book = value;
                if(book != null)
                {
                    code.Text = book.Code;
                    Title.Text = book.Title;
                    firstName_Author.Text = book.FirstName_Author;
                    lastName_Author.Text = book.LastName_Author;
                    publicationDate.Text = book.PublicationDate.ToString("MM/dd/yy");
                    category.Text = book.Category;
                    secondaryCategory.Text = book.SecondaryCategory;
                    num.Text = CountLine + "";
                }
                
            }
        }
        #endregion

        static int countline;
        public static int CountLine
        {
            get { return countline; }
            set { countline = value; }
        }

        public singleBook()
        {
            InitializeComponent();
        }
        public singleBook(DataAccessLayer.Entities.Book showBook)
        {
            InitializeComponent();
            countline++;
            Book = showBook;
            btnDelete1.addEventTopictureBox1Click(showBook.Code!,"Book");
            btnShow1.addEventTopictureBox1Click(showBook, "Book");
            btnUpDate1.addEventTopictureBox1Click(showBook, "Book");
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                control.MouseEnter += new System.EventHandler(userEnter!);
                control.MouseLeave += new System.EventHandler(userLeave!);
            }
        }

        Boolean hoverNow = false;
        Color temp;

        public void setCode(string newCode)
        {
            code.Text = newCode;
        }

        private void userEnter(object sender, EventArgs e)
        {
            Color BackColorNow = this.BackColor;
            HelpGeneralFunc.userEnter(ref temp,ref BackColorNow, ref hoverNow);
            this.BackColor = BackColorNow;
        }

        private void userLeave(object sender, EventArgs e)
        {
            Color BackColorNow = this.BackColor;
            HelpGeneralFunc.userLeave(ref temp, ref BackColorNow, ref hoverNow);
            this.BackColor = BackColorNow;
        }
    }
}
