using System.Data;
using AppLayer.Components.Single.Entities;
using AppLayer.SpecialComponents.Help;
using DataAccessLayer.Entities;
using BusinessLogicLayer.StoredProceduresLogic;

namespace AppLayer.Components.tableDB
{
    public partial class dbExistingCategories : UserControl
    {
        public dbExistingCategories()
        {
            InitializeComponent();
        }

        public dbExistingCategories(DataTable data)
        {
            InitializeComponent();
            setPanalData(data);

        }

        ExistingCategory? existingCategory;
        public ExistingCategory? ExistingCategory
        {
            get { return existingCategory; }
            set { existingCategory = value; }
        }



        public void updateDbExistingCategory()
        {
            singleExistingCategories.CountLine = 0;
            panelData.Controls.Clear();
            ExistingCategorylogic existingCategorylogic = new ExistingCategorylogic();
            object resFun = existingCategorylogic.getExistingCategories();
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
                existingCategory = new ExistingCategory()
                {
                    Category = row["Category"].ToString()!,
                    SecondaryCategory = row["SecondaryCategory"].ToString()!
                };

                singleExistingCategories single = new singleExistingCategories(existingCategory);
                single.Dock = DockStyle.Top;

                single.BackColor = HelpGeneralFunc.getTheme(ref counter, colors);
                panelData.Controls.Add(single);
            }
            HelpControlFunc.reverseOrderControlsOfControls(panelData);
        }
    }
}
