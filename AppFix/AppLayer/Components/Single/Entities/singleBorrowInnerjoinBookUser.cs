using AppLayer.SpecialComponents.Help;
using AppLayer.Models;

namespace AppLayer.Components.Single.Entities
{

    public partial class singleBorrowInnerjoinBookUser : UserControl
    {


        #region Set Values to UC
        private BorrowWithInnerJoinBookUserModel? borrowWithInnerJoinBookUserModel;
        public BorrowWithInnerJoinBookUserModel? BorrowWithInnerJoinBookUserModel
        {
            get { return borrowWithInnerJoinBookUserModel; }
            set
            {
                borrowWithInnerJoinBookUserModel = value;
                if (borrowWithInnerJoinBookUserModel != null)
                {
                    code.Text = borrowWithInnerJoinBookUserModel.Code;
                    title.Text = borrowWithInnerJoinBookUserModel.Title;
                    firstName.Text = borrowWithInnerJoinBookUserModel.FirstName;
                    lastName.Text = borrowWithInnerJoinBookUserModel.LastName ;
                    num.Text = CountLine + "";
                }

            }
        }
        #endregion

        static int countline = 0;
        public static int CountLine
        {
            get { return countline; }
            set { countline = value; }
        }


        public singleBorrowInnerjoinBookUser()
        {
            InitializeComponent();
        }

        public singleBorrowInnerjoinBookUser(BorrowWithInnerJoinBookUserModel showBorrowWithInnerJoinBookUserModel)
        {
            InitializeComponent();
            countline++;
            BorrowWithInnerJoinBookUserModel = showBorrowWithInnerJoinBookUserModel;
            btnShow1.addEventTopictureBox1Click(showBorrowWithInnerJoinBookUserModel, "BorrowInnerjoinBookUser");
            btnDelete1.addEventTopictureBox1Click(showBorrowWithInnerJoinBookUserModel.Code!, "BorrowInnerjoinBookUser");
            foreach (Control control in tableLayoutPanel1.Controls)

            {
                control.MouseEnter += new System.EventHandler(userEnter!);
                control.MouseLeave += new System.EventHandler(userLeave!);
            }
        }

        Boolean hoverNow = false;
        Color temp;

        private void userEnter(object sender, EventArgs e)
        {
            Color BackColorNow = this.BackColor;
            HelpGeneralFunc.userEnter(ref temp, ref BackColorNow, ref hoverNow);
            this.BackColor = BackColorNow;
        }

        private void userLeave(object sender, EventArgs e)
        {
            Color BackColorNow = this.BackColor;
            HelpGeneralFunc.userLeave(ref temp, ref BackColorNow, ref hoverNow);
            this.BackColor = BackColorNow;


        }
    }
}
