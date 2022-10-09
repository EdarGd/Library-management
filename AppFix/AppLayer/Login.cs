
using System.Data;
using BusinessLogicLayer.Validation;
using BusinessLogicLayer.StoredProceduresLogic;
using DataAccessLayer.Entities;
using AppLayer.SpecialComponents.Help;

namespace AppLayer
{
    public partial class Login : Form
    {
        // save values
        private Rectangle[] controlerOriginalRectangle;
        // save pointer to controls
        private Control[] controls;
        private Rectangle originalFormSize;

        private UserLogic userLogic;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public Login()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
            InitializeComponent();
            userLogic = new UserLogic();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            HelpGeneralFunc.addImgCursor("Move.png", new Size(80, 80), specialButton1);
            HelpFormUCFunc.FormOrUC_LoadCreateRectangles(ref controls, ref controlerOriginalRectangle, ref originalFormSize, this);

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            HelpFormUCFunc.FormOrUC_LoadCreateRectangles(ref controls, ref controlerOriginalRectangle, ref originalFormSize, this);
        }

        private async void  specialButton1_Click(object sender, EventArgs e)
        {
            string? checkValues;
            checkValues = Validation_CheckUser.checkId(id.Text);
            HelpControlFunc.checkAndSetError(id,checkValues,errorId);

            checkValues = Validation_CheckUser.checkEmail(email.Text);
            HelpControlFunc.checkAndSetError(email, checkValues, errorEmail);

            checkValues = Validation_CheckUser.checkPassword(password.Text);
            HelpControlFunc.checkAndSetError(password, checkValues, errorPassword);

            if (checkValues == null)
            {
                object resFun = await userLogic.ShowFromUser_UserFromSpecific_Id_Email_Password(id.Text, email.Text, password.Text);
                if (resFun.GetType() != typeof(DataTable))
                {
                    MessageBox.Show(resFun.ToString());
                }
                else
                {
                    DataTable dt = (DataTable)resFun;
                    User user = new User();
                    foreach (DataRow row in dt.Rows)
                    {
                        user = new User()
                        {
                            Id = row["id"].ToString()!,
                            Email = row["email"].ToString()!,
                            Password = row["password"].ToString()!,
                            FirstName = row["FirstName"].ToString()!,
                            LastName = row["LastName"].ToString()!,
                            Type = (bool)row["type"]
                        };
                        
                    }
                    Main main = new Main(user);
                    main.Location = new Point((this.MdiParent.Width) / 2, (this.MdiParent.Height) / 2);
                    string hello = string.Format("{0} {1}\nWhat a crazy user <3 \n Welcome back!",user.FirstName, user.LastName);
                    MessageBox.Show(hello, "Hello message",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    main.Activate();   
                    main.Show();
                    this.MdiParent.Hide();
                }

            }

        }
    }
}
