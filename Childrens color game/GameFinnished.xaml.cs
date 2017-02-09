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

namespace Childrens_color_game
{
    /// <summary>
    /// Interaction logic for GameFinnished.xaml
    /// </summary>
    public partial class GameFinnished : Window
    {
        private static int prScore = 0;
        public GameFinnished(int score)
        {
            InitializeComponent();
            prScore = score;
            ScoreBox.Text = score.ToString();
        }

        private void TextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                this.Close();
            }
        }
    }
}
