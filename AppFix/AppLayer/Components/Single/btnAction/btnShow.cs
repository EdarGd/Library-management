using AppLayer.Components.Single.ShowInNewForm;

using AppLayer.SpecialComponents.Help;

namespace AppLayer.Components.Single
{
    public partial class btnShow : UserControl
    {
        public btnShow()
        {
            InitializeComponent();
            try
            {
                HelpGeneralFunc.addImgCursor("Move.png", new Size(50, 50), pictureBox1);
            }
            catch
            {
                return;
            }
        }

        public void addEventTopictureBox1Click(object objShow,string nameTableOfItem)
        {
            pictureBox1.Click += new EventHandler((sender, e) => seeItem(objShow,nameTableOfItem));
        }

        public void seeItem(object objShow, string nameTableOfItem)
        {
            switch (nameTableOfItem)
            {
                case "Book":
                    if(objShow != null)
                    {
                        showFormBook showBook = new showFormBook((objShow as DataAccessLayer.Entities.Book)!);
                        openPopForm(showBook);
                    }
                    else
                    {
                        MessageBox.Show("no null !");
                    }
                    break;

                case "Borrow":
                    if (objShow != null)
                    {
                        showFormBorrow showBorrow = new showFormBorrow((objShow as DataAccessLayer.Entities.Borrow)!);
                        openPopForm(showBorrow);
                    }
                    else
                    {
                        MessageBox.Show("no null !");
                    }
                    
                    break;

                case "BorrowInnerjoinBookUser":
                    if (objShow != null)
                    {
                        showFormBorrowInnerjoinBookUser showBorrow = new showFormBorrowInnerjoinBookUser((objShow as AppLayer.Models.BorrowWithInnerJoinBookUserModel)! );
                        openPopForm(showBorrow);
                    }
                    else
                    {
                        MessageBox.Show("no null !");
                    }
                    break;

                case "ExistingCategories":
                    if (objShow != null)
                    {
                        showFormExistingCategory showExistingCategory = new showFormExistingCategory((objShow as DataAccessLayer.Entities.ExistingCategory)!);
                        openPopForm(showExistingCategory);
                    }
                    else
                    {
                        MessageBox.Show("no null !");
                    }
                    break;

                case "User":
                    if (objShow != null)
                    {
                        showFormUser showUser = new showFormUser((objShow as DataAccessLayer.Entities.User)!);
                        openPopForm(showUser);
                    }
                    else
                    {
                        MessageBox.Show("no null !");
                    }
                    
                    break;

            }
        }

        private void openPopForm(Form popForm)
        {
            TableLayoutPanel tableSingle = (this.Parent as TableLayoutPanel)!;
            UserControl userSingle = (tableSingle.Parent as UserControl)!;
            Panel panelData = (userSingle.Parent as Panel)!;
            TableLayoutPanel tableDB = (panelData.Parent as TableLayoutPanel)!;
            UserControl UcDB = (tableDB.Parent as UserControl)!;
            Form subForm = (UcDB.Parent as Form)!;
            Form mainForm = (subForm.MdiParent as Form)!;
            HelpFormUCFunc.showFormInMiddleForm(popForm, mainForm);
        }

    }
}
