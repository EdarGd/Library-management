using System.ComponentModel;

namespace AppLayer.SpecialComponents.Help
{
    public static class HelpControlFunc
    {

        #region ComboBox and checkBox functions

        [Category("ComboBox and checkBox")]
        /// <summary>
        /// The function displays the information of ComboBox in the center
        /// </summary>
        /// <param name="objComboBox">The ComboBox</param>
        /// <param name="eventDraw">The data of draw evenr</param>
        public static void cbxDesign_DrawItem(ref object objComboBox, ref DrawItemEventArgs eventDraw)
        {
            // By using Sender, one method could handle multiple ComboBoxes
            if(objComboBox == null)
                return;
            if ((objComboBox!) is ComboBox cbx)
            {
                // Always draw the background
                eventDraw.DrawBackground();

                // Drawing one of the items?
                if (eventDraw.Index >= 0)
                {
                    // Set the string alignment.  Choices are Center, Near and Far
                    StringFormat sf = new StringFormat();
                    sf.LineAlignment = StringAlignment.Center;
                    sf.Alignment = StringAlignment.Center;

                    // Set the Brush to ComboBox ForeColor to maintain any ComboBox color settings
                    // Assumes Brush is solid
                    Brush brush = new SolidBrush(cbx.ForeColor);

                    // If drawing highlighted selection, change brush
                    if ((eventDraw.State & DrawItemState.Selected) == DrawItemState.Selected)
                        brush = SystemBrushes.HighlightText;

                    // Draw the string
                    eventDraw.Graphics.DrawString(cbx.Items[eventDraw.Index].ToString(), cbx.Font, brush, eventDraw.Bounds, sf);
                }
            }
        }

        [Category("ComboBox and checkBox")]
        /// <summary>
        /// The function creates a list of checkBox with text - checkComboBox
        /// </summary>
        /// <param name="fieldsName">The information that will be displayed in the list</param>
        /// <param name="checkComboBox">The special checkBox</param>
        /// <param name="controls">The controls that will appear or be hidden according to the checkBox of the information</param>
        /// <param name="panelShow">where the controls will be displayed</param>
        public static void createCheckComboBoxList(string[] fieldsName, CheckComboBox checkComboBox, Control[] controls, Control panelShow)
        {
            CheckComboBoxItem[] checkComboBoxItems = new CheckComboBoxItem[fieldsName.Length];
            foreach (var (field, index) in fieldsName.Select((field, index) => (field, index)))
            {
                checkComboBoxItems[index] = new CheckComboBoxItem(field, false);
            }
            checkComboBox.Items.AddRange(checkComboBoxItems);

            //// wire up the check state changed event
            checkComboBox.CheckStateChanged += new System.EventHandler((sender, e) => checkComboBox1_CheckStateChanged(sender!, e, controls, checkComboBox.Items.Cast<CheckComboBoxItem>().ToArray(), panelShow));

        }

        [Category("ComboBox and checkBox")]
        /// <summary>
        /// The function marks or unmarks all information
        /// Depending on whether All  is checked
        /// </summary>
        /// <param name="checkComboBoxItems">The information fields in the list (checkComboBox) </param>
        /// <param name="showAll">will declare whether to mark everything or the opposite</param>
        private static void showAll(CheckComboBoxItem[] checkComboBoxItems, Boolean showAll)
        {
            foreach (CheckComboBoxItem item in checkComboBoxItems)
            {
                if (item.Text.ToLower() != "all")
                {
                    switch (showAll)
                    {

                        case true:
                            {
                                item.CheckState = true;
                            }

                            break;
                        case false:
                            item.CheckState = false;
                            break;
                    }
                }

            }
        }

        [Category("ComboBox and checkBox")]
        /// <summary>
        /// The function will be activated when we mark or remove a mark from one of the information fields in the list
        /// and display controls according to the highlighted information
        /// </summary>
        /// <param name="objCheckComboBoxItem">the selected option ( CheckComboBoxItem ) from the list (checkComboBox) </param>
        /// <param name="controls">The controls that will appear or be hidden according to the checkBox of the information</param>
        /// <param name="checkComboBoxItems">The special checkBox</param>
        /// <param name="panelShow">where the controls will be displayed</param>
        private static void checkComboBox1_CheckStateChanged(object objCheckComboBoxItem, EventArgs @event, Control[] controls, CheckComboBoxItem[] checkComboBoxItems, Control panelShow)
        {
            if (objCheckComboBoxItem is CheckComboBoxItem)
            {
                CheckComboBoxItem item = (CheckComboBoxItem)objCheckComboBoxItem;
                if (item.Text.ToLower() == "all")
                {
                    showAll(checkComboBoxItems, item.CheckState);
                }
                foreach (CheckComboBoxItem removeMark in checkComboBoxItems)
                {
                    if (removeMark.Text.ToLower() == "all" && removeMark.CheckState)
                    {
                        removeMark.CheckState = false;
                    }
                    // we want only one option
                    if (item.CheckState && item.Text != removeMark.Text)
                    {
                        removeMark.CheckState = false;
                    }
                }
                foreach (Control control in controls)
                {
                    if (item.Text.ToLower() == "all")
                    {
                        switch (item.CheckState)
                        {
                            case true:
                                control.Show();
                                control.Tag = "show";
                                break;
                            case false:
                                control.Hide();
                                control.Tag = "hide";
                                break;
                        }
                    }
                    else
                    {
                        // name control must start with panel
                        // name CheckComboBoxItem maybe have space
                        string controlName = control.Name.ToLower().Split("panel")[1];
                        if (controlName == item.Text.Replace(" ", "").ToLower())
                        {
                            if (item.CheckState)
                            {
                                control.Show();
                                control.Tag = "show";
                            }
                            else
                            {
                                control.Hide();
                                control.Tag = "hide";
                            }
                        }
                        else
                        {
                            // all controls not the same name is hide
                            if(item.CheckState)
                            {
                                control.Hide();
                                control.Tag = "hide";
                            }
                        }
                    }
                    
                }

                int countControlShow = 0;
                foreach (Control control in controls)
                {
                    if (control.Name.ToLower() != "panelaction" && control.Tag.ToString() == "show")
                    {
                        countControlShow++;
                    }
                }
                if (countControlShow > 0)
                {
                    panelShow.Show();
                }
                else
                {
                    panelShow.Hide();
                }
            }
        }

        #endregion


        #region Validation functions

        [Category("Validation")]
        /// <summary>
        /// The function receives a string and checks if it is not empty and will display it next to a control as an error message
        /// </summary>
        /// <param name="insertErrNext">The control next to which an error message will be displayed</param>
        /// <param name="checkRes">The information about the executed command (if empty, then correct)</param>
        /// <param name="err">Control the error message</param>
        public static void checkAndSetError(Control insertErrNext, string? checkRes, ErrorProvider err)
        {
            if (checkRes != null)
            {
                err.SetError(insertErrNext, checkRes);
            }
            else
            {
                err.SetError(insertErrNext, String.Empty);
            }
        }
        #endregion

        #region General control functions

        [Category("General control")]
        /// <summary>
        /// Receives a control and reverses the order of its controls
        /// </summary>
        /// <param name="controlToOrder">The control we will change the order of its controls</param>
        public static void reverseOrderControlsOfControls(Control controlToOrder)
        {
            Control[] con = new Control[controlToOrder.Controls.Count];
            controlToOrder.Controls.CopyTo(con, 0);
            con = con.Reverse<Control>().ToArray<Control>();
            while (controlToOrder.Controls.Count > 0)
            {
                controlToOrder.Controls.RemoveAt(controlToOrder.Controls.Count - 1);
            }
            for (int i = 0; i < con.Length; i++)
            {
                controlToOrder.Controls.Add(con[i]);
            }
        }

      
        #endregion
    }
}
