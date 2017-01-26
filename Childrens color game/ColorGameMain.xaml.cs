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

        private void TextBox_0_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (ColorUtilites.getNameFromColor((SolidColorBrush)textBox.Background))
            {
                Debug.Write("soo something happened");
            }
            else
            {
                Debug.Write("button one pressed");
                textBox.Text = "hello";
                textBox.Background = new SolidColorBrush(Color.FromRgb(255, 0, 0));
            }
        }

        private void TextBox_1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
            {
                TextBox textBox = (TextBox)sender;
                if (textBox.Text == "")
                {

                }
                else
                {
                    textBox.Background = new SolidColorBrush(Color.FromRgb(255, 0, 0));
                }
            }
        }

        private void TextBox_2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
            {
                TextBox textBox = (TextBox)sender;
                if (textBox.Text == "")
                {

                }
                else
                {
                    textBox.Background = new SolidColorBrush(Color.FromRgb(255, 0, 0));
                }
            }
        }

        private void TextBox_3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
            {
                TextBox textBox = (TextBox)sender;
                if (textBox.Text == "")
                {

                }
                else
                {
                    textBox.Background = new SolidColorBrush(Color.FromRgb(255, 0, 0));
                }
            }
        }

        private void TextBox_4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
            {
                TextBox textBox = (TextBox)sender;
                if (textBox.Text == "")
                {

                }
                else
                {
                    textBox.Background = new SolidColorBrush(Color.FromRgb(255, 0, 0));
                }
            }
        }

        private void TextBox_5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
            {
                TextBox textBox = (TextBox)sender;
                if (textBox.Text == "")
                {

                }
                else
                {
                    textBox.Background = new SolidColorBrush(Color.FromRgb(255, 0, 0));
                }
            }
        }
    }
}
