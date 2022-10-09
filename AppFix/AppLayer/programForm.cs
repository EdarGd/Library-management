using AppLayer.SpecialComponents.Help;

namespace AppLayer
{
    public partial class programForm : Form
    {
        private Rectangle[] controlerOriginalRectangle;
        // save pointer to controls
        private Control[] controls;
        private Rectangle originalFormSize;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public programForm()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
            InitializeComponent();
        }

        private void programForm_Load(object sender, EventArgs e)
        {
            Login login = new Login();
            login.MdiParent = this;
            login.Location = new Point(0, 0);
            login.Dock = DockStyle.Fill;
            login.Show();

            HelpFormUCFunc.FormOrUC_LoadCreateRectangles(ref controls, ref controlerOriginalRectangle, ref originalFormSize, this);
        }

        private void ProgramForm_Resize(object sender, EventArgs e)
        {
            // loop over controls and updates values
            HelpFormUCFunc.FormOrUC_Resize(controls, controlerOriginalRectangle,originalFormSize,this);

        }
    }
}
