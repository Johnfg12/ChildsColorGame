using System;
using System.Windows.Media;

namespace Childrens_color_game
{
    class ColorUtilites
    {
        private static Random random = new Random();
        private static Color[] colors = { Color.FromRgb(0, 0, 0), Color.FromRgb(255, 255, 255), Color.FromRgb(255, 0, 0), Color.FromRgb(0, 128, 0), Color.FromRgb(0, 0, 255), Color.FromRgb(255, 255, 0), Color.FromRgb(128, 128, 128), Color.FromRgb(255,0,255), Color.FromRgb(128,0,128) };
        private static String[] colorNames = { "black", "white", "red", "green", "blue", "yellow", "grey", "pink", "purple"  };

        public static Color[] getColorArray()
        {
            return colors;
        }

        public static void setColorArray(Color[] colord)
        {
            colors = colord;
        }

        public static String[] getColorNames()
        {
            return colorNames;
        }

        public static void setColorNames(String[] colorNamed)
        {
            colorNames = colorNamed;
        }

        /// <summary>
        /// gets the color object from the array returns white(aka rgb(0,0,0)) if it can not be found
        /// </summary>
        /// <param name="colorName">the name of the color you want the object to</param>
        /// <returns>a Color object dependant on the colorName</returns>
        public static Color getColorFromName(String colorName)
        {
            int colorLoc = 0;

            foreach(String str in colorNames){
                if (str.Equals(colorName))
                {
                    return colors[colorLoc];
                }
                colorLoc++;
            }

            return Color.FromRgb(0, 0, 0);
            
        }

        /// <summary>
        /// gets the color name from a color object if it can not be found will return "NULL"
        /// </summary>
        /// <param name="colorRef">Color object to get the name of</param>
        /// <returns>the string of the color object</returns>
        public static String getNameFromColor(Color colorRef)
        {
            int i = 0;

            foreach (Color color in colors)
            {
                if (color.R == colorRef.R &&
                    color.G == colorRef.G &&
                    color.B == colorRef.B)
                {
                    return colorNames[i];
                }
                i++;
            }
            return "NULL";
        }

        /// <summary>
        /// returns a random Color
        /// </summary>
        /// <returns>gets a random color from the array</returns>
        public static Color getRandomColor()
        {
            if (colors.Length == colorNames.Length)
            {
                int ranNumber = random.Next(0, colors.Length);
                return colors[ranNumber];
            }
            else
            {
                return Color.FromRgb(0, 0, 0);
            }
        }

        /// <summary>
        /// returns a random color name
        /// </summary>
        /// <returns>gets a random color name from the array</returns>
        public static String getRandomColorName()
        {
            if (colors.Length == colorNames.Length)
            {
                int ranNumber = random.Next(0, colors.Length);
                return colorNames[ranNumber];
            }
            else
            {
                return "NULL";
            }
        }

    }
}
