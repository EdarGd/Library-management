using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppLayer.SpecialComponents.Help;
using DataAccessLayer.Entities;

namespace AppLayer.Components.Single.Entities
{
    public partial class singleUser : UserControl
    {
        public singleUser()
        {
            InitializeComponent();
        }
        #region Set Values to UC
        private User? user;
        public User? User
        {
            get { return user; }
            set
            {
                user = value;
                if (user != null)
                {
                    id.Text = user.Id;
                    firstName.Text = user.FirstName;
                    lastName.Text = user.LastName;
                    email.Text = user.Email;
                    password.Text = user.Password;
                    if(user.Type)
                    {
                        type.Text = "Worker";
                    }
                    else
                    {
                        type.Text = "Library Subscription";
                    }
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

        public singleUser(User showUser)
        {
            InitializeComponent();
            countline++;
            User = showUser;
            btnDelete1.addEventTopictureBox1Click(showUser.Id, "User");
            btnShow1.addEventTopictureBox1Click(showUser, "User");
            btnUpDate1.addEventTopictureBox1Click(showUser, "User");
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
