using AppLayer.SpecialComponents.Help;
using DataAccessLayer.Entities;

namespace AppLayer.Components.Single.Entities
{
    public partial class singleBorrow : UserControl
    {


        #region Set Values to UC
        private Borrow? borrow;
        public Borrow? Borrow
        {
            get { return borrow; }
            set
            {
                borrow = value;
                if (borrow != null)
                {
                    code.Text = borrow.Code;
                    id.Text = borrow.Id;
                    num.Text = CountLine + "";
                }

            }
        }
        #endregion

        static int countline;
        public static int CountLine
        {
            get { return countline; }
            set { countline = value; }
        }


        public singleBorrow()
        {
            InitializeComponent();
        }

        public singleBorrow(Borrow showBorrow)
        {
            InitializeComponent();
            countline++;
            Borrow = showBorrow;
            btnDelete1.addEventTopictureBox1Click(showBorrow.Code, "Borrow");
            btnShow1.addEventTopictureBox1Click(showBorrow, "Borrow");
            btnUpDate1.addEventTopictureBox1Click(showBorrow, "Borrow");
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
