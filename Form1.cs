using System.Security.Cryptography.Xml;

namespace Assignment1
{
    public partial class Form1 : Form
    {
        string currentPlayer;
        int p1Wins = 0;
        int p2Wins = 0;

        public Form1()
        {
            InitializeComponent();
            currentPlayer = "X"; //default first player is X
        }

        private void playerClick(object sender, EventArgs e)
        {
            var button = (Button)sender; //check which button was clicked
            button.Text = currentPlayer; //change button text to X or O depending on player's turn
            button.Enabled = false; //disable button so player can't misclick it again, also important to check for draw later
            Check(); //check if any player wins
            changePlayer(); //change to next player
        }

        private void restartGame(object sender, EventArgs e)
        {
            resetGame();
        }

        private void resetScore(object sender, EventArgs e)
        {
            //reset player score without exiting the game
            p1Wins = 0;
            label1.Text = "Player 1: " + p1Wins;
            p2Wins = 0;
            label2.Text = "Player 2: " + p2Wins;
            resetGame();
        }

        private void changePlayer()
        {
            //swap back and forth between X or O
            if (currentPlayer == "X")
            {
                currentPlayer = "O";
            }
            else if (currentPlayer == "O")
            {
                currentPlayer = "X";
            }
        }

        private void resetGame()
        {
            //set player to default (X) then re-enable all 9 button and clear text
            currentPlayer = "X";
            button1.Enabled = true;
            button1.Text = "";
            button2.Enabled = true;
            button2.Text = "";
            button3.Enabled = true;
            button3.Text = "";
            button4.Enabled = true;
            button4.Text = "";
            button5.Enabled = true;
            button5.Text = "";
            button6.Enabled = true;
            button6.Text = "";
            button7.Enabled = true;
            button7.Text = "";
            button8.Enabled = true;
            button8.Text = "";
            button9.Enabled = true;
            button9.Text = "";
        }

        private void Check()
        {
            //check for 3 matches in 3 horizontal, 3 vertical and 2 diagonal lines
            //then show result accordingly and update win counter
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X"
               || button4.Text == "X" && button5.Text == "X" && button6.Text == "X"
               || button7.Text == "X" && button8.Text == "X" && button9.Text == "X"
               || button1.Text == "X" && button4.Text == "X" && button7.Text == "X"
               || button2.Text == "X" && button5.Text == "X" && button8.Text == "X"
               || button3.Text == "X" && button6.Text == "X" && button9.Text == "X"
               || button1.Text == "X" && button5.Text == "X" && button9.Text == "X"
               || button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                MessageBox.Show("Player 1 Wins");
                p1Wins++;
                label1.Text = "Player 1: " + p1Wins;
                resetGame();
            }
            else if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O"
                || button4.Text == "O" && button5.Text == "O" && button6.Text == "O"
                || button7.Text == "O" && button8.Text == "O" && button9.Text == "O"
                || button1.Text == "O" && button4.Text == "O" && button7.Text == "O"
                || button2.Text == "O" && button5.Text == "O" && button8.Text == "O"
                || button3.Text == "O" && button6.Text == "O" && button9.Text == "O"
                || button1.Text == "O" && button5.Text == "O" && button9.Text == "O"
                || button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                MessageBox.Show("Player 2 Wins");
                p2Wins++;
                label2.Text = "Player 2: " + p2Wins;
                resetGame();
            }
            else if (button1.Enabled == false && button2.Enabled == false && button3.Enabled == false &&
                    button4.Enabled == false && button5.Enabled == false && button6.Enabled == false &&
                    button7.Enabled == false && button8.Enabled == false && button9.Enabled == false)
            {
                //if all 9 buttons are clicked (disabled) without anyone win, then display draw, restart game and doesn't affect win counter
                MessageBox.Show("It's a Draw");
                resetGame();
            }
        }
    }
}
