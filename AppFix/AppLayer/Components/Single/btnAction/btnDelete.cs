using AppLayer.SpecialComponents.Help;
using AppLayer.SpecialComponents.DbFunc;

namespace AppLayer.Components.Single
{
    public partial class btnDelete : UserControl
    {
        public btnDelete()
        {
            InitializeComponent();
            try
            {
                HelpGeneralFunc.addImgCursor("Delete.png", new Size(50, 50), pictureBox1);
            }
            catch
            {
                return;
            }

        }

        public void addEventTopictureBox1Click(object key, string nameTableOfItem)
        {
            pictureBox1.Click += new EventHandler((sender,e)=>deleteItem(key, nameTableOfItem));
        }

        public async void deleteItem(object key, string nameTableOfItem)
        {
            if (MessageBox.Show("Are you sure you want to delete this information?", "ConfirmationSoniccccc", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                bool delete = false;
                switch (nameTableOfItem)
                {
                    case "Book":
                        if (key != null)
                        {
                            delete =  await BookFunc.deleteSelectedBook((key as string)!);
                        }
                        break;

                    case "Borrow":
                        if (key != null)
                        {
                            delete = await BorrowFunc.deleteSelectedBorrow((key as string)!);
                        }
                        break;
                    case "BorrowInnerjoinBookUser":
                        if (key != null)
                        {
                            delete = await BorrowFunc.deleteSelectedBorrow((key as string)!);
                        }
                        break;

                    case "ExistingCategories":
                        if (key != null)
                        {
                            delete = await ExistingCategoriesFun.deleteSelectedExistingCategory((key as DataAccessLayer.Entities.ExistingCategory)!);
                        }
                        break;

                    case "User":
                        if (key != null)
                        {
                            delete = await UserFunc.deleteSelectedUser((key as string)!);
                        }
                        break;

                }

                if(delete)
                {
                    Main.showDBTable form = (Main.showDBTable)this.ParentForm;
                    form.showDBBookTable(nameTableOfItem);
                }
               
            }

            else
            {
                MessageBox.Show("Yaaay we stay ! ");
            }
          
        }

    }
}
