using System.ComponentModel;

namespace AppLayer.SpecialComponents.Help
{
    public static class HelpFormUCFunc
    {

        #region Forms and UC functions
        [Category("Forms and UC")]
        /// <summary>
        /// A function that updates the size of the control according to the displacement of the parent control
        /// </summary>
        /// <param name="rectangleControl">The size of the control</param>
        /// <param name="control">the control</param>
        /// <param name="originalFormOrUCSize">The size of the Form / UC</param>
        /// <param name="ObjFormOrUC">the Form / UC</param>
        /// <returns></returns>
        private static void resizeControl(Rectangle rectangleControl, Control control, Rectangle originalFormOrUCSize, object ObjFormOrUC)
        {
            float xRatio;
            float yRatio;
            if (ObjFormOrUC == null)
            {
                return;
            }
            else if (ObjFormOrUC.GetType().BaseType!.Name == "Form")
            {
                Form thisForm = (Form)ObjFormOrUC;
                xRatio = (float)(thisForm.Width) / (float)(originalFormOrUCSize.Width);
                yRatio = (float)(thisForm.Height) / (float)(originalFormOrUCSize.Height);
            }
            else if (ObjFormOrUC.GetType().BaseType!.Name == "UserControl")
            {
                UserControl thisUC = (UserControl)ObjFormOrUC;
                xRatio = (float)(thisUC.Width) / (float)(originalFormOrUCSize.Width);
                yRatio = (float)(thisUC.Height) / (float)(originalFormOrUCSize.Height);
            }
            else
            {
                return;
            }


            int newX = (int)(rectangleControl.Location.X * xRatio);
            int newY = (int)(rectangleControl.Location.Y * yRatio);

            int newWidth = (int)(rectangleControl.Width * xRatio);
            int newHeight = (int)(rectangleControl.Height * yRatio);

            control.Location = new Point(newX, newY);
            control.Size = new Size(newWidth, newHeight);
        }

        [Category("Forms and UC")]
        /// <summary>
        /// The function is activated when the Form / UC changes its size,
        /// Goes through all the controls in it and updates its sizes
        /// </summary>
        /// <param name="controls">The controls in the Form / UC</param>
        /// <param name="controlerOriginalRectangle">The controls sizes accordingly</param>
        /// <param name="originalFormOrUCSize">The size of the Form / UC</param>
        /// <param name="ObjFormOrUC">the Form / UC</param>
        /// <returns></returns>
        public static void FormOrUC_Resize(Control[] controls, Rectangle[] controlerOriginalRectangle, Rectangle originalFormOrUCSize, object ObjFormOrUC)
        {
            if (controls != null)
            {
                // loop over controls and updates values
                foreach (var (control, index) in controls.Select((value, i) => (value, i)))
                {
                    resizeControl(controlerOriginalRectangle[index], control, originalFormOrUCSize, ObjFormOrUC);
                }
            }

        }

        [Category("Forms and UC")]
        /// <summary>
        /// The function is activated when the Form / UC Load,
        /// Goes through all the controls in it and get its sizes
        /// </summary>
        /// <param name="controls">The controls in the Form / UC</param>
        /// <param name="controlerOriginalRectangle">The controls sizes accordingly</param>
        /// <param name="originalFormOrUCSize">The size of the Form / UC</param>
        /// <param name="ObjFormOrUC">the Form / UC</param>
        /// <returns></returns>
        public static void FormOrUC_LoadCreateRectangles(ref Control[] controls, ref Rectangle[] controlerOriginalRectangle, ref Rectangle originalFormOrUCSize, object ObjFormOrUC)
        {

            if (ObjFormOrUC.GetType().BaseType!.Name == "Form")
            {
                Form thisForm = (Form)ObjFormOrUC;
                originalFormOrUCSize = new Rectangle(thisForm.Location.X, thisForm.Location.Y, thisForm.Size.Width, thisForm.Size.Height);

                controlerOriginalRectangle = new Rectangle[thisForm.Controls.Count];
                controls = new Control[thisForm.Controls.Count];
                // copy all collection to array from 0
                thisForm.Controls.CopyTo(controls, 0);
            }

            else if (ObjFormOrUC.GetType().BaseType!.Name == "UserControl")
            {
                UserControl thisForm = (UserControl)ObjFormOrUC;
                originalFormOrUCSize = new Rectangle(thisForm.Location.X, thisForm.Location.Y, thisForm.Size.Width, thisForm.Size.Height);

                controlerOriginalRectangle = new Rectangle[thisForm.Controls.Count];
                controls = new Control[thisForm.Controls.Count];
                // copy all collection to array from 0
                thisForm.Controls.CopyTo(controls, 0);

            }

            else
            {
                return;
            }


            //// Loop over tuples with the item and its index
            foreach (var (control, index) in controls.Select((value, i) => (value, i)))
            {
                controlerOriginalRectangle[index] = new Rectangle(control.Location.X, control.Location.Y, control.Width, control.Height);
            }

        }


        [Category("Forms and UC")]
        /// <summary>
        /// The function displays a form in the middle of a main form
        /// </summary>
        /// <param name="showForm">The displays form </param>
        /// <param name="mainForm">The main form</param>
        /// <returns></returns>
        public static void showFormInMiddleForm(Form showForm, Form mainForm)
        {
            showForm.Show();
            showForm.Activate();
            // we want center so we divide width by 2
            int XplusWidth = mainForm!.Location.X + mainForm!.Width / 2;
            int resXWithPopWidth = XplusWidth - showForm.Width / 2;

            // we want center so we divide width by 2
            int YplusHeight = mainForm.Location.Y + mainForm.Height / 2;
            int resYWithPopHeight = YplusHeight - showForm.Height / 2;
            showForm.Location = new Point(resXWithPopWidth, resYWithPopHeight);
            showForm.Show();
        }


        [Category("Forms and UC")]
        /// <summary>
        /// The function receives an array of Ucs and what type of Uc to show from form
        /// the types -> Add , Delete , Show All , Show Search , Update
        /// </summary>
        /// <param name="ucs">The UCs in the Form </param>
        /// <param name="kindAction">The type of Uc to show</param>
        /// <param name="form">The Form</param>
        /// <returns></returns>
        public static void hideAndShowUC(UserControl[] ucs, string kindAction, Form form)
        {
            if (ucs.Length != 4)
            {
                MessageBox.Show("The array must contain 4 UC (add, delete, show Search, Update)");
                return;
            }
            foreach (UserControl uc in ucs)
            {
                //uc.Location = new Point((form.Width - uc.Width) / 2 - 10, (form.Height - uc.Height) / 2 - 30);
                uc.Location = new Point((form.Width - uc.Width) / 2 - 50, (form.Location.Y - 120));
                uc.Hide();
            }

            switch (kindAction)
            {
                case "Add":
                    ucs[0].Show();
                    break;

                case "Delete":
                    ucs[1].Show();
                    break;

                case "Show Search":
                    ucs[2].Show();
                    break;

                case "Update":
                    ucs[3].Show();
                    break;
            }
        }

        [Category("Forms and UC")]
        /// <summary>
        /// The function will display a child form in a parent form, in the middle
        /// </summary>
        /// <param name="mdiChild">The form we will display in a parent form</param>
        /// /// <param name="mdiMain">The parent form</param>
        public static void displayMdiChildFormAtCenter(Form mdiChild, Form mdiMain)
        {
            mdiChild.MdiParent = mdiMain;
            mdiChild.Activate();
            mdiChild.Show();
            mdiChild.Size = new Size(mdiMain.Width - 100, mdiMain.Height - 150);
            mdiChild.Location = new Point((mdiMain.Width - mdiChild.Width) / 2 - 10, (mdiMain.Height - mdiChild.Height) / 2 - 30);
        }
        #endregion
    }
}
