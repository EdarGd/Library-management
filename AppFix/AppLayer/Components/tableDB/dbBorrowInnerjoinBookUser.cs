using System.Data;
using AppLayer.SpecialComponents.Help;
using AppLayer.Models;
using AppLayer.Components.Single.Entities;
using BusinessLogicLayer.StoredProceduresLogic;

namespace AppLayer.Components.tableDB
{
    public partial class dbBorrowInnerjoinBookUser : UserControl
    {
        public dbBorrowInnerjoinBookUser()
        {
            InitializeComponent();
        }

        BorrowWithInnerJoinBookUserModel? borrowWithInnerJoinBookUserModel;
        public BorrowWithInnerJoinBookUserModel? BorrowWithInnerJoinBookUserModel
        {
            get { return borrowWithInnerJoinBookUserModel; }
            set { borrowWithInnerJoinBookUserModel = value; }
        }

        public dbBorrowInnerjoinBookUser(DataTable data)
        {
            InitializeComponent();
            setPanalData(data);

        }

        public async void updateDbBorrowWithInnerJoinBookUserModel()
        {
            singleBorrowInnerjoinBookUser.CountLine = 0;
            panelData.Controls.Clear();
            Borrowlogic borrowLogic = new Borrowlogic();
            object resFun = await borrowLogic.ShowFromBorrow_UserBorrows(BorrowWithInnerJoinBookUserModel!.Id!);
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
                borrowWithInnerJoinBookUserModel = new BorrowWithInnerJoinBookUserModel()
                {
                    Code = row["Code"].ToString()!,
                    Title = row["Title"].ToString()!,
                    FirstName = row["FirstName"].ToString()!,
                    LastName = row["LastName"].ToString()!,
                    Id = row["Id"].ToString()!
                };

                singleBorrowInnerjoinBookUser single = new singleBorrowInnerjoinBookUser(borrowWithInnerJoinBookUserModel);
                single.Dock = DockStyle.Top;

                single.BackColor = HelpGeneralFunc.getTheme(ref counter, colors);
                panelData.Controls.Add(single);
            }
            HelpControlFunc.reverseOrderControlsOfControls(panelData);
        }
    }
}
