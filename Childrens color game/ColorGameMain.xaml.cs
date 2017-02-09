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
        public static Color[] colors = { ColorUtilites.getRandomColor(), ColorUtilites.getRandomColor(), ColorUtilites.getRandomColor(), ColorUtilites.getRandomColor(), ColorUtilites.getRandomColor(), ColorUtilites.getRandomColor() };
        public static bool[] questions = { false, false, false, false, false, false };
        public static int Attempts = 0;
        public ColorGameMain()
        {
            InitializeComponent();
            Rectangle_0.Fill = new SolidColorBrush(colors[0]);
            Rectangle_1.Fill = new SolidColorBrush(colors[1]);
            Rectangle_2.Fill = new SolidColorBrush(colors[2]);
            Rectangle_3.Fill = new SolidColorBrush(colors[3]);
            Rectangle_4.Fill = new SolidColorBrush(colors[4]);
            Rectangle_5.Fill = new SolidColorBrush(colors[5]);
            //Console.WriteLine(ColorUtilites.getNameFromColor(colors[0]));
            //Console.WriteLine(ColorUtilites.getNameFromColor(colors[1]));
            //Console.WriteLine(ColorUtilites.getNameFromColor(colors[2]));
            //Console.WriteLine(ColorUtilites.getNameFromColor(colors[3]));
            //Console.WriteLine(ColorUtilites.getNameFromColor(colors[4]));
            //Console.WriteLine(ColorUtilites.getNameFromColor(colors[5]));
        }

        private void TextBox_0_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                TextBox textBox = (TextBox)sender;
                if (textBox.Text == ColorUtilites.getNameFromColor(colors[0]))
                {
                    textBox.Background = new SolidColorBrush(Color.FromRgb(0, 255, 0));
                    questions[0] = true;
                    ScoreUpdate();
                }
                else
                {
                    textBox.Background = new SolidColorBrush(Color.FromRgb(255, 0, 0));
                    questions[0] = false;
                    ScoreUpdate();
                }
            }
        }

        private void TextBox_1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                TextBox textBox = (TextBox)sender;
                if (textBox.Text == ColorUtilites.getNameFromColor(colors[1]))
                {
                    textBox.Background = new SolidColorBrush(Color.FromRgb(0, 255, 0));
                    questions[1] = true;
                    ScoreUpdate();
                }
                else
                {
                    textBox.Background = new SolidColorBrush(Color.FromRgb(255, 0, 0));
                    questions[1] = false;
                    ScoreUpdate();
                }
            }
        }

        private void TextBox_2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                TextBox textBox = (TextBox)sender;
                if (textBox.Text == ColorUtilites.getNameFromColor(colors[2]))
                {
                    textBox.Background = new SolidColorBrush(Color.FromRgb(0, 255, 0));
                    questions[2] = true;
                    ScoreUpdate();
                }
                else
                {
                    textBox.Background = new SolidColorBrush(Color.FromRgb(255, 0, 0));
                    questions[2] = false;
                    ScoreUpdate();
                }
            }
        }

        private void TextBox_3_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                TextBox textBox = (TextBox)sender;
                if (textBox.Text == ColorUtilites.getNameFromColor(colors[3]))
                {
                    textBox.Background = new SolidColorBrush(Color.FromRgb(0, 255, 0));
                    questions[3] = true;
                    ScoreUpdate();
                }
                else
                {
                    textBox.Background = new SolidColorBrush(Color.FromRgb(255, 0, 0));
                    questions[3] = false;
                    ScoreUpdate();
                }
            }
        }

        private void TextBox_4_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                TextBox textBox = (TextBox)sender;
                if (textBox.Text == ColorUtilites.getNameFromColor(colors[4]))
                {
                    textBox.Background = new SolidColorBrush(Color.FromRgb(0, 255, 0));
                    questions[4] = true;
                    ScoreUpdate();
                }
                else
                {
                    textBox.Background = new SolidColorBrush(Color.FromRgb(255, 0, 0));
                    questions[4] = false;
                    ScoreUpdate();
                }
            }
        }

        private void TextBox_5_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                TextBox textBox = (TextBox)sender;
                if (textBox.Text == ColorUtilites.getNameFromColor(colors[5]))
                {
                    textBox.Background = new SolidColorBrush(Color.FromRgb(0, 255, 0));
                    questions[5] = true;
                    ScoreUpdate();
                }
                else
                {
                    textBox.Background = new SolidColorBrush(Color.FromRgb(255, 0, 0));
                    questions[5] = false;
                    ScoreUpdate();
                }
            }
        }

        private void ScoreUpdate()
        {
            Attempts++;
            int score = 0;
            foreach(bool bol in questions)
            {
                if(bol == true)
                {
                    score++;
                }
            }
            ScoreBox.Text = score.ToString();
            if(score == 6 || Attempts == 12)
            {
                //ToDo add save score stuffs and open some sort of score screen thingy
                GameFinnished gamefin = new GameFinnished(score);
               
                gamefin.Show();

                this.Close();
            }
        }
    }
}
