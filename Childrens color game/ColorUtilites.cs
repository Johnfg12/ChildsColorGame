using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;
using System.Threading.Tasks;
using System.Collections.Specialized;

namespace Childrens_color_game
{
    class ColorUtilites
    {
        private Random random = new Random();
        /// <summary>
        /// a array of colors all colors names are lower case
        /// </summary>
        private OrderedDictionary colorDictionary = new OrderedDictionary();

        public ColorUtilites()
        {
            colorDictionary.Add("blue", Color.FromRgb(0, 0,255));
            colorDictionary.Add("red", Color.FromRgb(255, 0, 0));
            colorDictionary.Add("green", Color.FromRgb(0, 255, 0));
            colorDictionary.Add("yellow", Color.FromRgb(255, 255, 0));
            colorDictionary.Add("orange", Color.FromRgb(255, 136, 0));
            colorDictionary.Add("pink", Color.FromRgb(255, 0, 255));
            colorDictionary.Add("black", Color.FromRgb(0, 0, 0));
            colorDictionary.Add("white", Color.FromRgb(255, 255, 255));
        }

        /// <summary>
        /// gets the private Dictonary colorDictionary
        /// </summary>
        /// <returns>returns colorArray</returns>
        public OrderedDictionary GetColorArray()
        {
            return colorDictionary;
        }

        /// <summary>
        /// gets a random color from colorArray
        /// </summary>
        /// <returns>a random generated color from the colorDictionary</returns>
        public Color GetRandomColor()
        {
            int randomizedNumber = random.Next(0, colorDictionary.Count);
            return (Color) colorDictionary[randomizedNumber];
        }

        /// <summary>
        /// takes color and gets the string name in the dictonary if it doesnt exist returns null
        /// </summary>
        /// <param name="color">the color you want the name of</param>
        /// <returns>color name of input color</returns>
        public String GetColorName(Color color)
        {
            if (colorDictionary.Contains(color)){
                return (string)colorDictionary[color];
            }
            else
            {
                return null;
            }
        }
    }
}
