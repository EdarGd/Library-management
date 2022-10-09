using System.Data;
using AppLayer.Components.Single.Entities;
using AppLayer.SpecialComponents.Help;
using DataAccessLayer.Entities;
using BusinessLogicLayer.StoredProceduresLogic;

namespace AppLayer.Components.tableDB
{
    public partial class dbBorrows : UserControl
    {
        public dbBorrows()
        {
            InitializeComponent();
        }

        public dbBorrows(DataTable data)
        {
            InitializeComponent();
            setPanalData(data);

        }

        Borrow? borrow;
        public Borrow? Borrow
        {
            get { return borrow; }
            set { borrow = value; }
        }



        public async void updateDbBorrow()
        {
            singleBorrow.CountLine = 0;
            panelData.Controls.Clear();
            Borrowlogic borrowLogic = new Borrowlogic();
            object resFun = await borrowLogic.getBorrows();
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
                borrow = new Borrow()
                {
                    Code = row["Code"].ToString()!,
                    Id = row["Id"].ToString()!
                };

                singleBorrow single = new singleBorrow(borrow);
                single.Dock = DockStyle.Top;

                single.BackColor = HelpGeneralFunc.getTheme(ref counter, colors);
                panelData.Controls.Add(single);
            }
            HelpControlFunc.reverseOrderControlsOfControls(panelData);
        }
    }
}
