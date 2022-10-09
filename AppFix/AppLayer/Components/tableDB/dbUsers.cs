using System.Data;
using AppLayer.Components.Single.Entities;
using AppLayer.SpecialComponents.Help;
using DataAccessLayer.Entities;
using BusinessLogicLayer.StoredProceduresLogic;

namespace AppLayer.Components.tableDB
{
    public partial class dbUsers : UserControl
    {
        public dbUsers()
        {
            InitializeComponent();
        }

        public dbUsers(DataTable data)
        {
            InitializeComponent();
            setPanalData(data);

        }

        User? user;
        public User? User
        {
            get { return user; }
            set { user = value; }
        }



        public async void updateDbUser()
        {
            singleUser.CountLine = 0;
            panelData.Controls.Clear();
            UserLogic userlogic = new UserLogic();
            object resFun = await userlogic.getUsers();
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
                user = new User()
                {
                    Id = row["Id"].ToString()!,
                    FirstName = row["FirstName"].ToString()!,
                    LastName = row["LastName"].ToString()!,
                    Email = row["Email"].ToString()!,
                    Password = row["Password"].ToString()!,
                    Type =  (bool)row["Type"]
                    
                };

                singleUser single = new singleUser(user);
                single.Dock = DockStyle.Top;

                single.BackColor = HelpGeneralFunc.getTheme(ref counter, colors);
                panelData.Controls.Add(single);
            }
            HelpControlFunc.reverseOrderControlsOfControls(panelData);
        }
    }
}
