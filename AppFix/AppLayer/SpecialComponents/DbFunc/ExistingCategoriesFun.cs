using System.Data;
using BusinessLogicLayer.StoredProceduresLogic;
using AppLayer.Components.Single.Main;
using AppLayer.SpecialComponents.Help;
using DataAccessLayer.Entities;

namespace AppLayer.SpecialComponents.DbFunc
{
    public static class ExistingCategoriesFun
    {

        #region Basic Fun
        private static ExistingCategorylogic existingCategorylogic = new ExistingCategorylogic();
        public static void createCategories(List<string> categories, ComboBox category)
        {
            object resFun = existingCategorylogic.getExistingCategories();
            if (resFun.GetType() != typeof(DataTable))
            {
                MessageBox.Show(resFun.ToString());
            }
            else
            {
                DataTable dt = (DataTable)resFun;
                foreach (DataRow row in dt.Rows)
                {
                    if(!categories.Contains(row[0]))
                        categories.Add((string)row["Category"]);

                }
            }
            category.DataSource = categories;

        }

        public async static void category_SelectedIndexChanged(List<string> secondaryCategorySelect, ComboBox secondaryCategory, string choose)
        {
            
            secondaryCategory.DataSource = null;
            secondaryCategorySelect.Clear();
            object resFun = await existingCategorylogic.ShowFromExistingCategories_SubcategoryFromCategory(choose);
            if (resFun.GetType() != typeof(DataTable))
            {
                MessageBox.Show(resFun.ToString());
            }
            else
            {
                DataTable dt = (DataTable)resFun;
                foreach (DataRow row in dt.Rows)
                {
                    secondaryCategorySelect.Add((string)row["secondaryCategory"]);
                }

            }

            secondaryCategory.DataSource = secondaryCategorySelect;
        }

        public static async Task<bool> deleteSelectedExistingCategory(DataAccessLayer.Entities.ExistingCategory existingCategory)
        {
            string result = await existingCategorylogic.deleteSelectedExistingCategory(existingCategory);
            if (result == "ExistingCategory successfully deleted !")
            {
                return true;
            }
            else
            {
                MessageBox.Show(result, "Error in Delete function", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return false;
            }
        }


        public static async Task<bool> addExistingCategory(ExistingCategory existingCategory)
        {
            string result = await existingCategorylogic.addNewExistingCategory(existingCategory);

            if (result == "ExistingCategory successfully added !")
            {
                return true;
            }
            else
            {
                MessageBox.Show(result, "Error in Add function", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return false;
            }
        }

        public static async Task<bool> updateExistingCategory(ExistingCategory existingCategory, ExistingCategory existingCategoryNow)
        {
            string result = await existingCategorylogic.updateSelectedExistingCategory(existingCategory, existingCategoryNow);
            if (result == "ExistingCategory successfully updated !")
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

        public static async void ShowFromExistingCategories_SubcategoryFromSpecificCategory(string category, Form chooseForm, Form main)
        {
            object result = await existingCategorylogic.ShowFromExistingCategories_SubcategoryFromSpecificCategory(category);
            if (result.GetType() != typeof(DataTable))
            {
                MessageBox.Show(result.ToString());
            }
            else
            {
                DataTable data = (DataTable)result;
                showDBTable showDB = new showDBTable("ExistingCategories", data);
                chooseForm.Close();
                HelpFormUCFunc.displayMdiChildFormAtCenter(showDB, main);
            }

        }

        public static async void ShowFromExistingCategories_SubcategoryFromCategory(string category, Form chooseForm, Form main)
        {
            object result = await existingCategorylogic.ShowFromExistingCategories_SubcategoryFromCategory(category);
            if (result.GetType() != typeof(DataTable))
            {
                MessageBox.Show(result.ToString());
            }
            else
            {
                DataTable data = (DataTable)result;
                showDBTable showDB = new showDBTable("ExistingCategories", data);
                chooseForm.Close();
                HelpFormUCFunc.displayMdiChildFormAtCenter(showDB, main);
            }

        }

      
        #endregion
    }
}
