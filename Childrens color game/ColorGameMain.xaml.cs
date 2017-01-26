using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Diagnostics;

namespace Childrens_color_game
{
    /// <summary>
    /// Interaction logic for ColorGameMain.xaml
    /// </summary>
    public partial class ColorGameMain : Window
    {
        public ColorGameMain()
        {
            InitializeComponent();
            Rectangle_0.Fill = new SolidColorBrush(ColorUtilites.getRandomColor());
            Rectangle_1.Fill = new SolidColorBrush(ColorUtilites.getRandomColor());
            Rectangle_2.Fill = new SolidColorBrush(ColorUtilites.getRandomColor());
            Rectangle_3.Fill = new SolidColorBrush(ColorUtilites.getRandomColor());
            Rectangle_4.Fill = new SolidColorBrush(ColorUtilites.getRandomColor());
            Rectangle_5.Fill = new SolidColorBrush(ColorUtilites.getRandomColor());

            if (ColorUtilites.getNameFromColor(ColorUtilites.getRandomColor()) == "NULL")
            {
                Debug.WriteLine("it was null");
            }
            else
            {
                Debug.WriteLine(ColorUtilites.getNameFromColor(ColorUtilites.getRandomColor()));
            }
        }
    }
}
