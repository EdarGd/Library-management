using AppLayer.Components.Single.Main;
using AppLayer.SpecialComponents.Help;
using BusinessLogicLayer.StoredProceduresLogic;
using DataAccessLayer.Entities;
using System.Data;

namespace AppLayer.SpecialComponents.DbFunc
{
    public class BorrowFunc
    {
        private static Borrowlogic borrowLogic = new Borrowlogic();

        #region Basic Fun
        public static async Task<bool> deleteSelectedBorrow(string code)
        {
            string result = await borrowLogic.deleteSelectedBorrow(code);
            if (result == "Borrow successfully deleted !")
            {
                return true;
            }
            else
            {
                MessageBox.Show(result, "Error in delete function", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return false;
            }
        }


        public static async Task<bool> addBoorow(Borrow borrow)
        {
            string result = await borrowLogic.addNewBorrow(borrow);

            if (result == "Borrow successfully added !")
            {
                return true;
            }
            else
            {
                MessageBox.Show(result, "Error in Add function", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return false;
            }
        }

        public static async Task<bool> updateBoorow(Borrow borrow)
        {
            string result = await borrowLogic.updateSelectedBorrow(borrow);
            if (result == "Boorow successfully updated !")
            {
                return true;
            }
            else
            {
                MessageBox.Show(result, "Error in Update function", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return false;
            }
        }
        #endregion

        #region Show

        public static async void ShowFromBorrow_SpecificBook(string code, Form chooseForm, Form main)
        {
            object result = await borrowLogic.ShowFromBorrow_SpecificBook(code);
            if (result.GetType() != typeof(DataTable))
            {
                MessageBox.Show(result.ToString());
            }
            else
            {
                DataTable data = (DataTable)result;
                showDBTable showDB = new showDBTable("Borrow", data);
                chooseForm.Close();
                HelpFormUCFunc.displayMdiChildFormAtCenter(showDB, main);
            }

        }

        public static async void ShowFromBorrow_byUserCheckType(bool type, string id, Form chooseForm, Form main)
        {
            // type - true = worker false = Library subscription
            object result = await borrowLogic.ShowFromBorrow_byUserCheckType(type,id);
            if (result.GetType() != typeof(DataTable))
            {
                MessageBox.Show(result.ToString());
            }
            else
            {
                DataTable data = (DataTable)result;
                showDBTable showDB = new showDBTable("BorrowInnerjoinBookUser", data);
                chooseForm.Close();
                HelpFormUCFunc.displayMdiChildFormAtCenter(showDB, main);
            }

        }

        public static async void ShowFromBorrow_UserBorrows(string id, Form chooseForm, Form main)
        {
            object result = await borrowLogic.ShowFromBorrow_UserBorrows(id);
            if (result.GetType() != typeof(DataTable))
            {
                MessageBox.Show(result.ToString());
            }
            else
            {
                DataTable data = (DataTable)result;
                showDBTable showDB = new showDBTable("BorrowInnerjoinBookUser", data);
                chooseForm.Close();
                HelpFormUCFunc.displayMdiChildFormAtCenter(showDB, main);
            }

        }

        #endregion


    }
}
