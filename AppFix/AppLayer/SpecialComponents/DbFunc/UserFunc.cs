using AppLayer.Components.Single.Main;
using AppLayer.SpecialComponents.Help;
using BusinessLogicLayer.StoredProceduresLogic;
using DataAccessLayer.Entities;
using System.Data;

    
namespace AppLayer.SpecialComponents.DbFunc
{
    public class UserFunc
    {
        private static UserLogic userLogic = new UserLogic();

        public static async Task<bool> deleteSelectedUser(string id)
        {
            string result = await userLogic.deleteSelectedUser(id);
            if (result == "User successfully deleted !")
            {
                return true;
            }
            else
            {
                MessageBox.Show(result, "Error in Delete function", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return false;
            }
        }


        #region Basic Fun

        public static async Task<bool> addUser(User user)
        {
            string result = await userLogic.addNewUser(user);

            if (result == "User successfully added !")
            {
                return true;
            }
            else
            {
                MessageBox.Show(result, "Error in Add function", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return false;
            }
        }

        public static async Task<bool> updateUser(User user)
        {
            string result = await userLogic.updateSelectedUser(user);
            if (result == "User successfully updated !")
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
        public static async void ShowFromUser_UserFromSpecificPassword(string password, Form chooseForm, Form main)
        {
            object result = await userLogic.ShowFromUser_UserFromSpecificPassword(password);
            if (result.GetType() != typeof(DataTable))
            {
                MessageBox.Show(result.ToString());
            }
            else
            {
                DataTable data = (DataTable)result;
                showDBTable showDB = new showDBTable("User", data);
                chooseForm.Close();
                HelpFormUCFunc.displayMdiChildFormAtCenter(showDB, main);
            }

        }
        public static async void ShowFromUser_UserFromSpecificId(string id, Form chooseForm, Form main)
        {
            object result = await userLogic.ShowFromUser_UserFromSpecificId(id);
            if (result.GetType() != typeof(DataTable))
            {
                MessageBox.Show(result.ToString());
            }
            else
            {
                DataTable data = (DataTable)result;
                showDBTable showDB = new showDBTable("User", data);
                chooseForm.Close();
                HelpFormUCFunc.displayMdiChildFormAtCenter(showDB, main);
            }

        }

        public static async void ShowFromUser_UserFromSpecificEmail(string email, Form chooseForm, Form main)
        {
            object result = await userLogic.ShowFromUser_UserFromSpecificEmail(email);
            if (result.GetType() != typeof(DataTable))
            {
                MessageBox.Show(result.ToString());
            }
            else
            {
                DataTable data = (DataTable)result;
                showDBTable showDB = new showDBTable("User", data);
                chooseForm.Close();
                HelpFormUCFunc.displayMdiChildFormAtCenter(showDB, main);
            }

        }

        public static async void ShowFromUser_UserFromSpecific_Id_Email_Password(string id, string email, string password, Form chooseForm, Form main)
        {
            object result = await userLogic.ShowFromUser_UserFromSpecific_Id_Email_Password(id,email,password);
            if (result.GetType() != typeof(DataTable))
            {
                MessageBox.Show(result.ToString());
            }
            else
            {
                DataTable data = (DataTable)result;
                showDBTable showDB = new showDBTable("User", data);
                chooseForm.Close();
                HelpFormUCFunc.displayMdiChildFormAtCenter(showDB, main);
            }

        }

        public static async void ShowFromUser_UsersFromFirstName(string firstName,Form chooseForm, Form main)
        {
            object result = await userLogic.ShowFromUser_UsersFromFirstName(firstName);
            if (result.GetType() != typeof(DataTable))
            {
                MessageBox.Show(result.ToString());
            }
            else
            {
                DataTable data = (DataTable)result;
                showDBTable showDB = new showDBTable("User", data);
                chooseForm.Close();
                HelpFormUCFunc.displayMdiChildFormAtCenter(showDB, main);
            }

        }

        public static async void ShowFromUser_UsersFromLastName(string lastName, Form chooseForm, Form main)
        {
            object result = await userLogic.ShowFromUser_UsersFromLastName(lastName);
            if (result.GetType() != typeof(DataTable))
            {
                MessageBox.Show(result.ToString());
            }
            else
            {
                DataTable data = (DataTable)result;
                showDBTable showDB = new showDBTable("User", data);
                chooseForm.Close();
                HelpFormUCFunc.displayMdiChildFormAtCenter(showDB, main);
            }

        }

        public static async void ShowFromUser_UsersFromName(string firstName, string lastName, Form chooseForm, Form main)
        {
            object result = await userLogic.ShowFromUser_UsersFromName(firstName,lastName);
            if (result.GetType() != typeof(DataTable))
            {
                MessageBox.Show(result.ToString());
            }
            else
            {
                DataTable data = (DataTable)result;
                showDBTable showDB = new showDBTable("User", data);
                chooseForm.Close();
                HelpFormUCFunc.displayMdiChildFormAtCenter(showDB, main);
            }

        }
        #endregion
    }
}
