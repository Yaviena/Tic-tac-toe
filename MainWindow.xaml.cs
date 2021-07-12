using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace TicTacToe_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool IsPlayer1Turn { get; set; }
        public int Counter { get; set; }
        public MainWindow()
        {
            InitializeComponent();

            NewGame();
        }
        public void NewGame()
        {
            IsPlayer1Turn = false;
            Counter = 0;

            Button_0_0.Content = string.Empty;
            Button_1_0.Content = string.Empty;
            Button_2_0.Content = string.Empty;
            Button_0_1.Content = string.Empty;
            Button_1_1.Content = string.Empty;
            Button_2_1.Content = string.Empty;
            Button_0_2.Content = string.Empty;
            Button_1_2.Content = string.Empty;
            Button_2_2.Content = string.Empty;

            Button_0_0.Background = Brushes.White;
            Button_0_1.Background = Brushes.White;
            Button_0_2.Background = Brushes.White;
            Button_1_0.Background = Brushes.White;
            Button_1_1.Background = Brushes.White;
            Button_1_2.Background = Brushes.White;
            Button_2_0.Background = Brushes.White;
            Button_2_1.Background = Brushes.White;
            Button_2_2.Background = Brushes.White;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            #region if else zamiast operacji bitowej
            /*
            if (IsPlayer1Turn)
                IsPlayer1Turn = false;
            else
                IsPlayer1Turn = true; 
            */
            #endregion

            IsPlayer1Turn ^= true;              // Za pomocą operacji bitowej
            Counter++;

            if (Counter > 9)
            {
                NewGame();
                return;
            }

            var button = sender as Button;
            button.Content = IsPlayer1Turn ? "O" : "X";

            if (CheckIfPlayerWon())
            {
                Counter = 9;
            }
        }

        private void ButtonNewGame_Click(object sender, RoutedEventArgs e)
        {
            NewGame();
        }
        private bool CheckIfPlayerWon()
        {
            // row 0
            if (Button_0_0.Content.ToString() != string.Empty &&
                Button_0_0.Content == Button_0_1.Content && Button_0_1.Content == Button_0_2.Content)
            {
                Button_0_0.Background = Brushes.GreenYellow;
                Button_0_1.Background = Brushes.GreenYellow;
                Button_0_2.Background = Brushes.GreenYellow;
                return true;
            }
            // row 1
            if (Button_1_0.Content.ToString() != string.Empty &&
                Button_1_0.Content == Button_1_1.Content && Button_1_1.Content == Button_1_2.Content)
            {
                Button_1_0.Background = Brushes.GreenYellow;
                Button_1_1.Background = Brushes.GreenYellow;
                Button_1_2.Background = Brushes.GreenYellow;
                return true;
            }
            // row 2
            if (Button_2_0.Content.ToString() != string.Empty &&
                Button_2_0.Content == Button_2_1.Content && Button_2_1.Content == Button_2_2.Content)
            {
                Button_2_0.Background = Brushes.GreenYellow;
                Button_2_1.Background = Brushes.GreenYellow;
                Button_2_2.Background = Brushes.GreenYellow;
                return true;
            }
            // column 0
            if (Button_0_0.Content.ToString() != string.Empty &&
                Button_0_0.Content == Button_1_0.Content && Button_1_0.Content == Button_2_0.Content)
            {
                Button_0_0.Background = Brushes.GreenYellow;
                Button_1_0.Background = Brushes.GreenYellow;
                Button_2_0.Background = Brushes.GreenYellow;
                return true;
            }
            // column 1
            if (Button_0_1.Content.ToString() != string.Empty &&
                Button_0_1.Content == Button_1_1.Content && Button_1_1.Content == Button_2_1.Content)
            {
                Button_0_1.Background = Brushes.GreenYellow;
                Button_1_1.Background = Brushes.GreenYellow;
                Button_2_1.Background = Brushes.GreenYellow;
                return true;
            }
            // column 2
            if (Button_0_2.Content.ToString() != string.Empty &&
                Button_0_2.Content == Button_1_2.Content && Button_1_2.Content == Button_2_2.Content)
            {
                Button_0_2.Background = Brushes.GreenYellow;
                Button_1_2.Background = Brushes.GreenYellow;
                Button_2_2.Background = Brushes.GreenYellow;
                return true;
            }
            // diagonal decreasing
            if (Button_0_0.Content.ToString() != string.Empty &&
                Button_0_0.Content == Button_1_1.Content && Button_1_1.Content == Button_2_2.Content)
            {
                Button_0_0.Background = Brushes.GreenYellow;
                Button_1_1.Background = Brushes.GreenYellow;
                Button_2_2.Background = Brushes.GreenYellow;
                return true;
            }
            // diagonal increasing
            if (Button_0_2.Content.ToString() != string.Empty &&
                Button_0_2.Content == Button_1_1.Content && Button_1_1.Content == Button_2_0.Content)
            {
                Button_0_2.Background = Brushes.GreenYellow;
                Button_1_1.Background = Brushes.GreenYellow;
                Button_2_0.Background = Brushes.GreenYellow;
                return true;
            }

            return false;
        }

    }
}
