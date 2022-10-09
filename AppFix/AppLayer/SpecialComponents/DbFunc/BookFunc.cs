
using AppLayer.Components.Single.Main;
using AppLayer.SpecialComponents.Help;
using BusinessLogicLayer.StoredProceduresLogic;
using DataAccessLayer.Entities;
using System.Data;

namespace AppLayer.SpecialComponents.DbFunc
{
    public class BookFunc
    {
        private static BookLogic bookLogic = new BookLogic();

        public static async Task<bool> deleteSelectedBook(string code)
        {
            string result = await bookLogic.deleteSelectedBook(code);
            if (result == "Book successfully deleted !")
            {
                return true;
            }
            else
            {
                MessageBox.Show(result);
                return false;
            }
        }

        #region Basic Fun

        public static async Task<bool> addBook(Book book)
        {
            string result = await bookLogic.addNewBook(book);
            
            if (result == "Book successfully added !")
            {
                return true;
            }
            else
            {
                MessageBox.Show(result,"Error in Add function",MessageBoxButtons.OK,MessageBoxIcon.Error,MessageBoxDefaultButton.Button1);
                return false;
            }
        }

        public static async Task<bool> updateBook(Book book)
        {
            string result = await bookLogic.updateSelectedBook(book);
            if (result == "Book successfully updated !")
            {
                return true;
            }
            else
            {
                MessageBox.Show(result, "Error in Update function", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return false;
            }
        }

        public static async Task<bool> deleteBook(string code)
        {
            string result = await bookLogic.deleteSelectedBook(code);
            if (result == "Book successfully deleted !")
            {
                return true;
            }
            else
            {
                MessageBox.Show(result, "Error in Delete function", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return false;
            }
        }
        #endregion



        #region Show
        public static async void ShowFromBook_BookFromSpecificCode(string code, Form chooseForm, Form main)
        {
            object result = await bookLogic.ShowFromBook_BookFromSpecificCode(code);
            if (result.GetType() != typeof(DataTable))
            {
                MessageBox.Show(result.ToString());
            }
            else
            {
                DataTable data = (DataTable)result;
                showDBTable showDB = new showDBTable("Book", data);
                chooseForm.Close();
                HelpFormUCFunc.displayMdiChildFormAtCenter(showDB, main);
            }

        }
        public static async void ShowFromBook_BooksFromTitle(string title,Form chooseForm,Form main)
        {
            object result = await bookLogic.ShowFromBook_BooksFromTitle(title);
            if (result.GetType() != typeof(DataTable))
            {
                MessageBox.Show(result.ToString());
            }
            else
            {
                DataTable data = (DataTable)result;
                showDBTable showDB = new showDBTable("Book", data);
                chooseForm.Close();
                HelpFormUCFunc.displayMdiChildFormAtCenter(showDB, main);
            }

        }

        public static async void ShowFromBook_BooksFromFirstName_Author(string firstName, Form chooseForm, Form main)
        {
            object result = await bookLogic.ShowFromBook_BooksFromFirstName_Author(firstName);
            if (result.GetType() != typeof(DataTable))
            {
                MessageBox.Show(result.ToString());
            }
            else
            {
                DataTable data = (DataTable)result;
                showDBTable showDB = new showDBTable("Book", data);
                chooseForm.Close();
                HelpFormUCFunc.displayMdiChildFormAtCenter(showDB, main);
            }

        }

        public static async void ShowFromBook_BooksFromLastName_Author(string lastName, Form chooseForm, Form main)
        {
            object result = await bookLogic.ShowFromBook_BooksFromLastName_Author(lastName);
            if (result.GetType() != typeof(DataTable))
            {
                MessageBox.Show(result.ToString());
            }
            else
            {
                DataTable data = (DataTable)result;
                showDBTable showDB = new showDBTable("Book", data);
                chooseForm.Close();
                HelpFormUCFunc.displayMdiChildFormAtCenter(showDB, main);
            }

        }

        public static async void ShowFromBook_BooksFromName_Author(string firstName, string lastName, Form chooseForm, Form main)
        {
            object result = await bookLogic.ShowFromBook_BooksFromName_Author(firstName, lastName);
            if (result.GetType() != typeof(DataTable))
            {
                MessageBox.Show(result.ToString());
            }
            else
            {
                DataTable data = (DataTable)result;
                showDBTable showDB = new showDBTable("Book", data);
                chooseForm.Close();
                HelpFormUCFunc.displayMdiChildFormAtCenter(showDB, main);
            }

        }

        public static async void ShowFromBook_BooksFromCategory(string category, Form chooseForm, Form main)
        {
            object result = await bookLogic.ShowFromBook_BooksFromCategory(category);
            if (result.GetType() != typeof(DataTable))
            {
                MessageBox.Show(result.ToString());
            }
            else
            {
                DataTable data = (DataTable)result;
                showDBTable showDB = new showDBTable("Book", data);
                chooseForm.Close();
                HelpFormUCFunc.displayMdiChildFormAtCenter(showDB, main);
            }

        }

        public static async void ShowFromBook_BooksFromPublicationYear(int numYear, Form chooseForm, Form main)
        {
            object result = await bookLogic.ShowFromBook_BooksFromPublicationYear(numYear);
            if (result.GetType() != typeof(DataTable))
            {
                MessageBox.Show(result.ToString());
            }
            else
            {
                DataTable data = (DataTable)result;
                showDBTable showDB = new showDBTable("Book", data);
                chooseForm.Close();
                HelpFormUCFunc.displayMdiChildFormAtCenter(showDB, main);
            }

        }

       
        #endregion


    }
}
