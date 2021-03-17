using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Tic_Tac_Toe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool LastWasX;
        int[,] GameGridX = new int[3, 3];
        int[,] GameGridO = new int[3, 3];
        int UnfilledSquares = 9;
        string Win;
        public MainWindow()
        {
            InitializeComponent();
            SetUpGame();
        }


        /// <summary>
        /// Sets up the game
        /// </summary>
        private void SetUpGame()
        {
            LastWasX = false;
            UnfilledSquares = 9;
            foreach (TextBlock textBlock in MainGrid.Children.OfType<TextBlock>())
            {
                textBlock.Visibility = Visibility.Hidden;
                textBlock.Text = "";
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    GameGridX[i, j] = 0;
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    GameGridO[i, j] = 0;
                }
            }

        }

        /// <summary>
        /// On mouse left click, place an X or an O depends on the last symbol placed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if ((textBlock1.Text == "O" || textBlock1.Text == "X") || GameEnded() == true)
            {
                return;
            }
            else if (LastWasX)
            {
                textBlock1.Text = "O";
                textBlock1.Visibility = Visibility.Visible;
                LastWasX = false;
                GameGridO[0, 0] = 1;
            }

            else
            {
                textBlock1.Text = "X";
                textBlock1.Visibility = Visibility.Visible;
                LastWasX = true;
                GameGridX[0, 0] = 1;
            }

            UnfilledSquares--;

            if (GameEnded())
            {
                GameFinishText.Text = Win;
                GameFinishText.Visibility = Visibility.Visible;
            }
            else if (UnfilledSquares == 0)
            {
                GameFinishText.Text = "Draw! Play again?";
                GameFinishText.Visibility = Visibility.Visible;
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            if ((textBlock2.Text == "O" || textBlock2.Text == "X") || GameEnded() == true)
            {
                return;
            }
            else if (LastWasX)
            {
                textBlock2.Text = "O";
                textBlock2.Visibility = Visibility.Visible;
                LastWasX = false;
                GameGridO[0, 1] = 1;
            }

            else
            {
                textBlock2.Text = "X";
                textBlock2.Visibility = Visibility.Visible;
                LastWasX = true;
                GameGridX[0, 1] = 1;
            }

            UnfilledSquares--;

            if (GameEnded())
            {
                GameFinishText.Text = Win;
                GameFinishText.Visibility = Visibility.Visible;
            }
            else if (UnfilledSquares == 0)
            {
                GameFinishText.Text = "Draw! Play again?";
                GameFinishText.Visibility = Visibility.Visible;
            }
        }
        private void button3_Click(object sender, RoutedEventArgs e)
        {
            if ((textBlock3.Text == "O" || textBlock3.Text == "X") || GameEnded() == true)
            {
                return;
            }
            else if (LastWasX)
            {
                textBlock3.Text = "O";
                textBlock3.Visibility = Visibility.Visible;
                LastWasX = false;
                GameGridO[0, 2] = 1;
            }

            else
            {
                textBlock3.Text = "X";
                textBlock3.Visibility = Visibility.Visible;
                LastWasX = true;
                GameGridX[0, 2] = 1;
            }

            UnfilledSquares--;

            if (GameEnded())
            {
                GameFinishText.Text = Win;
                GameFinishText.Visibility = Visibility.Visible;
            }
            else if (UnfilledSquares == 0)
            {
                GameFinishText.Text = "Draw! Play again?";
                GameFinishText.Visibility = Visibility.Visible;
            }
        }
        private void button4_Click(object sender, RoutedEventArgs e)
        {
            if ((textBlock4.Text == "O" || textBlock4.Text == "X") || GameEnded() == true)
            {
                return;
            }
            else if (LastWasX)
            {
                textBlock4.Text = "O";
                textBlock4.Visibility = Visibility.Visible;
                LastWasX = false;
                GameGridO[1, 0] = 1;
            }

            else
            {
                textBlock4.Text = "X";
                textBlock4.Visibility = Visibility.Visible;
                LastWasX = true;
                GameGridX[1, 0] = 1;
            }

            UnfilledSquares--;

            if (GameEnded())
            {
                GameFinishText.Text = Win;
                GameFinishText.Visibility = Visibility.Visible;
            }
            else if (UnfilledSquares == 0)
            {
                GameFinishText.Text = "Draw! Play again?";
                GameFinishText.Visibility = Visibility.Visible;
            }
        }
        private void button5_Click(object sender, RoutedEventArgs e)
        {
            if ((textBlock5.Text == "O" || textBlock5.Text == "X") || GameEnded() == true)
            {
                return;
            }
            else if (LastWasX)
            {
                textBlock5.Text = "O";
                textBlock5.Visibility = Visibility.Visible;
                LastWasX = false;
                GameGridO[1, 1] = 1;
            }

            else
            {
                textBlock5.Text = "X";
                textBlock5.Visibility = Visibility.Visible;
                LastWasX = true;
                GameGridX[1, 1] = 1;
            }

            UnfilledSquares--;

            if (GameEnded())
            {
                GameFinishText.Text = Win;
                GameFinishText.Visibility = Visibility.Visible;
            }
            else if (UnfilledSquares == 0)
            {
                GameFinishText.Text = "Draw! Play again?";
                GameFinishText.Visibility = Visibility.Visible;
            }
        }
        private void button6_Click(object sender, RoutedEventArgs e)
        {
            if ((textBlock6.Text == "O" || textBlock6.Text == "X") || GameEnded() == true)
            {
                return;
            }
            else if (LastWasX)
            {
                textBlock6.Text = "O";
                textBlock6.Visibility = Visibility.Visible;
                LastWasX = false;
                GameGridO[1, 2] = 1;
            }

            else
            {
                textBlock6.Text = "X";
                textBlock6.Visibility = Visibility.Visible;
                LastWasX = true;
                GameGridX[1, 2] = 1;
            }

            UnfilledSquares--;

            if (GameEnded())
            {
                GameFinishText.Text = Win;
                GameFinishText.Visibility = Visibility.Visible;
            }
            else if (UnfilledSquares == 0)
            {
                GameFinishText.Text = "Draw! Play again?";
                GameFinishText.Visibility = Visibility.Visible;
            }
        }
        private void button7_Click(object sender, RoutedEventArgs e)
        {
            if ((textBlock7.Text == "O" || textBlock7.Text == "X") || GameEnded() == true)
            {
                return;
            }
            else if (LastWasX)
            {
                textBlock7.Text = "O";
                textBlock7.Visibility = Visibility.Visible;
                LastWasX = false;
                GameGridO[2, 0] = 1;
            }

            else
            {
                textBlock7.Text = "X";
                textBlock7.Visibility = Visibility.Visible;
                LastWasX = true;
                GameGridX[2, 0] = 1;
            }

            UnfilledSquares--;

            if (GameEnded())
            {
                GameFinishText.Text = Win;
                GameFinishText.Visibility = Visibility.Visible;
            }
            else if (UnfilledSquares == 0)
            {
                GameFinishText.Text = "Draw! Play again?";
                GameFinishText.Visibility = Visibility.Visible;
            }
        }
        private void button8_Click(object sender, RoutedEventArgs e)
        {
            if ((textBlock8.Text == "O" || textBlock8.Text == "X") || GameEnded() == true)
            {
                return;
            }
            else if (LastWasX)
            {
                textBlock8.Text = "O";
                textBlock8.Visibility = Visibility.Visible;
                LastWasX = false;
                GameGridO[2, 1] = 1;
            }

            else
            {
                textBlock8.Text = "X";
                textBlock8.Visibility = Visibility.Visible;
                LastWasX = true;
                GameGridX[2, 1] = 1;
            }

            UnfilledSquares--;

            if (GameEnded())
            {
                GameFinishText.Text = Win;
                GameFinishText.Visibility = Visibility.Visible;
            }
            else if (UnfilledSquares == 0)
            {
                GameFinishText.Text = "Draw! Play again?";
                GameFinishText.Visibility = Visibility.Visible;
            }
        }
        private void button9_Click(object sender, RoutedEventArgs e)
        {
            if ((textBlock9.Text == "O" || textBlock9.Text == "X") || GameEnded() == true)
            {
                return;
            }
            else if (LastWasX)
            {
                textBlock9.Text = "O";
                textBlock9.Visibility = Visibility.Visible;
                LastWasX = false;
                GameGridO[2, 2] = 1;
            }

            else
            {
                textBlock9.Text = "X";
                textBlock9.Visibility = Visibility.Visible;
                LastWasX = true;
                GameGridX[2, 2] = 1;
            }

            UnfilledSquares--;

            if (GameEnded())
            {
                GameFinishText.Text = Win;
                GameFinishText.Visibility = Visibility.Visible;
            }
            else if (UnfilledSquares == 0)
            {
                GameFinishText.Text = "Draw! Play again?";
                GameFinishText.Visibility = Visibility.Visible;
            }
        }

        /// <summary>
        /// Checks if a player won
        /// </summary>
        /// <returns> returns true if a certain player won, false otherwise </returns>
        private bool GameEnded()
        {
            if (GameGridX[0, 0] == 1 && GameGridX[1, 0] == 1 && GameGridX[2, 0] == 1)
            {
                Win = "X won! Play again?";
                return true;
            }
            else if (GameGridX[0, 0] == 1 && GameGridX[0, 1] == 1 && GameGridX[0, 2] == 1)
            {
                Win = "X won! Play again?";
                return true;
            }
            else if (GameGridX[0, 2] == 1 && GameGridX[1, 2] == 1 && GameGridX[2, 2] == 1)
            {
                Win = "X won! Play again?";
                return true;
            }
            else if (GameGridX[2, 0] == 1 && GameGridX[2, 1] == 1 && GameGridX[2, 2] == 1)
            {
                Win = "X won! Play again?";
                return true;
            }
            else if (GameGridX[0, 0] == 1 && GameGridX[1, 1] == 1 && GameGridX[2, 2] == 1)
            {
                Win = "X won! Play again?";
                return true;
            }
            else if (GameGridX[2, 0] == 1 && GameGridX[1, 1] == 1 && GameGridX[0, 2] == 1)
            {
                Win = "X won! Play again?";
                return true;
            }
            else if (GameGridX[0, 1] == 1 && GameGridX[1, 1] == 1 && GameGridX[2, 1] == 1)
            {
                Win = "X won! Play again?";
                return true;
            }
            else if (GameGridX[1, 0] == 1 && GameGridX[1, 1] == 1 && GameGridX[1, 2] == 1)
            {
                Win = "X won! Play again?";
                return true;
            }

            else if (GameGridO[0, 0] == 1 && GameGridO[1, 0] == 1 && GameGridO[2, 0] == 1)
            {
                Win = "O won! Play again?";
                return true;
            }
            else if (GameGridO[0, 0] == 1 && GameGridO[0, 1] == 1 && GameGridO[0, 2] == 1)
            {
                Win = "O won! Play again?";
                return true;
            }
            else if (GameGridO[0, 2] == 1 && GameGridO[1, 2] == 1 && GameGridO[2, 2] == 1)
            {
                Win = "O won! Play again?";
                return true;
            }
            else if (GameGridO[2, 0] == 1 && GameGridO[2, 1] == 1 && GameGridO[2, 2] == 1)
            {
                Win = "O won! Play again?";
                return true;
            }
            else if (GameGridO[0, 0] == 1 && GameGridO[1, 1] == 1 && GameGridO[2, 2] == 1)
            {
                Win = "O won! Play again?";
                return true;
            }
            else if (GameGridO[2, 0] == 1 && GameGridO[1, 1] == 1 && GameGridO[0, 2] == 1)
            {
                Win = "O won! Play again?";
                return true;
            }
            else if (GameGridO[0, 1] == 1 && GameGridO[1, 1] == 1 && GameGridO[2, 1] == 1)
            {
                Win = "O won! Play again?";
                return true;
            }
            else if (GameGridO[1, 0] == 1 && GameGridO[1, 1] == 1 && GameGridO[1, 2] == 1)
            {
                Win = "O won! Play again?";
                return true;
            }
            return false;
        }

        /// <summary>
        /// When the games finishes, either from a draw or from a win, pressing on "play again?" will start a new game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlayAgainText_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (GameEnded() || UnfilledSquares == 0)
            {
                SetUpGame();
            }
        }
    }
}
