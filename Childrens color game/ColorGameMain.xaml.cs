using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

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
        }

        private void TextBox_0_KeyUp(object sender, KeyEventArgs e)
        {
            updateTextbox(sender, e, 0);
        }

        private void TextBox_1_KeyUp(object sender, KeyEventArgs e)
        {
            updateTextbox(sender, e, 1);
        }

        private void TextBox_2_KeyUp(object sender, KeyEventArgs e)
        {
            updateTextbox(sender, e, 2);
        }

        private void TextBox_3_KeyUp(object sender, KeyEventArgs e)
        {
            updateTextbox(sender, e, 3);
        }

        private void TextBox_4_KeyUp(object sender, KeyEventArgs e)
        {
            updateTextbox(sender, e, 4);
        }

        private void TextBox_5_KeyUp(object sender, KeyEventArgs e)
        {
            updateTextbox(sender, e, 5);
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

        private void updateTextbox(Object sender, KeyEventArgs e, int question)
        {
            if (e.Key == Key.Enter)
            {
                TextBox textBox = (TextBox)sender;
                if (textBox.Text == ColorUtilites.getNameFromColor(colors[question]))
                {
                    textBox.Background = new SolidColorBrush(Color.FromRgb(0, 255, 0));
                    questions[question] = true;
                    ScoreUpdate();
                }
                else
                {
                    textBox.Background = new SolidColorBrush(Color.FromRgb(255, 0, 0));
                    questions[question] = false;
                    ScoreUpdate();
                }
            }
        }
    }
}
