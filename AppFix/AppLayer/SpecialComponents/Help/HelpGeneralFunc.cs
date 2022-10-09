using System.Media;
using System.ComponentModel;

namespace AppLayer.SpecialComponents.Help
{

    public static class HelpGeneralFunc
    {

        #region Effects functions
        [Category("Effects")]
        /// <summary>
        /// A function to play a song endlessly
        /// </summary>
        /// <param name="urlSound">path of a song to be played(the main folder is bin)</param>
        public static void playSound(string urlSound)
        {
            SoundPlayer simpleSound = new SoundPlayer(urlSound);
            simpleSound.PlayLooping();
        }

        /// <summary>
        /// A function to get color by counter
        /// </summary>
        /// <param name="counter">When it is even there will be one color When there is an odd other color</param>
        /// <param name="colors">An array of colors to choose from</param>
        [Category("Effects")]
        public static Color getTheme(ref int counter,Color[] colors)
        {
            if (counter % 2 == 0)
            {
                counter++;
                return colors[0];
            }
            else
            {
                counter++;
                return colors[1];
            }
        }

        [Category("Effects")]
        /// <summary>
        /// A function that changes Changes the mouse cursor when hovering over an control
        /// </summary>
        /// <param name="urlImg">path of an image  to be show(the main folder is bin)</param>
        /// <param name="size">size of image to be displayed</param>
        /// <param name="control">The control on which the mouse will over</param>
        public static void addImgCursor(string urlImg, Size size, Control control)
        {
            Bitmap bitmap = new Bitmap(new Bitmap(urlImg), size);
            control.Cursor = new Cursor(bitmap.GetHicon());
        }

        [Category("Effects")]
        /// <summary>
        /// A function that checks if this is the first hover, if so it will change the background color
        /// </summary>
        /// <param name="temp">Hold the current color</param>
        /// <param name="BackColor">Saves the background color</param>
        /// <param name="hoverNow">Will declare if this is a first pass</param>
        public static void userEnter(ref Color temp, ref Color BackColor, ref Boolean hoverNow)
        {
            if (!hoverNow)
            {
                hoverNow = true;
                temp = BackColor;
                BackColor = Color.AliceBlue;
            }

        }

        [Category("Effects")]
        /// <summary>
        /// A function ceiling when we leave the control with the mouse cursor, if so it will change the background color to first
        /// </summary>
        /// <param name="temp">Hold the current color</param>
        /// <param name="BackColor">Saves the background color</param>
        /// <param name="hoverNow">Will declare if this is a first leave</param>
        public static void userLeave(ref Color temp, ref Color BackColor, ref Boolean hoverNow)
        {
            if (hoverNow)
            {
                hoverNow = false;
                BackColor = temp;
            }
        }

        #endregion
    }
}
