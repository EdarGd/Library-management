using AppLayer.SpecialComponents.Help;

namespace AppLayer.Components.Single.btnAction
{
    public partial class btnUpDate : UserControl
    {
        public btnUpDate()
        {
            InitializeComponent();
            try
            {
                HelpGeneralFunc.addImgCursor("Click.png", new Size(50, 50), pictureBox1);
            }
            catch
            {
                return;
            }
        }

        public void addEventTopictureBox1Click(object objUpdate, string nameTableOfItem)
        {
            pictureBox1.Click += new EventHandler((sender, e) => updateItem(objUpdate, nameTableOfItem));
        }

        public void updateItem(object objUpdate, string nameTableOfItem)
        {
            updateFromTable? up1 = null;
            switch (nameTableOfItem)
            {
                case "Book":
                    if (objUpdate != null)
                    {
                        up1 = new updateFromTable(objUpdate, "Book");
                    }
                    else
                    {
                        MessageBox.Show("no null !");
                    }
                    break;
                case "Borrow":
                    if (objUpdate != null)
                    {
                        up1 = new updateFromTable(objUpdate, "Borrow");
                    }
                    else
                    {
                        MessageBox.Show("no null !");
                    }
                    break;
                case "ExistingCategories":
                    if (objUpdate != null)
                    {
                        up1 = new updateFromTable(objUpdate, "ExistingCategories");
                    }
                    else
                    {
                        MessageBox.Show("no null !");
                    }
                    break;
                case "User":
                    if (objUpdate != null)
                    {
                        up1 = new updateFromTable(objUpdate, "User");
                    }
                    else
                    {
                        MessageBox.Show("no null !");
                    }
                    break;
            }
            if (up1 == null)
                return;
            TableLayoutPanel tableSingle = (this.Parent as TableLayoutPanel)!;
            UserControl userSingle = (tableSingle.Parent as UserControl)!;
            Panel panelData = (userSingle.Parent as Panel)!;
            TableLayoutPanel tableDB = (panelData.Parent as TableLayoutPanel)!;
            UserControl UcDB = (tableDB.Parent as UserControl)!;
            Form subForm = (UcDB.Parent as Form)!;
            Form mainForm = (subForm.MdiParent as Form)!;
            // we want center so we divide width by 2
            HelpFormUCFunc.showFormInMiddleForm(up1, mainForm);             
        }

    }
}
