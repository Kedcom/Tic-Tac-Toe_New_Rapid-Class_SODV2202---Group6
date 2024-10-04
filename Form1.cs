using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe_New_Rapid_Class_SODV2202___Group6
{
    public partial class Form1 : Form
    {
        private bool TrackPlayersTurn = true; // Track whose turn it is
        private int movesCount = 0; // Count moves to detect draw
        public Form1()
        {
            InitializeComponent();
            Display.Text = "";
        }

        private void UsersSelect(object sender, EventArgs e)
        {
            Button tempButton = (Button)sender;

            if (tempButton.Text == "")
            {
                //tempButton.Text = isPlayrsTurn
                if (TrackPlayersTurn) // first player will always be x (true)
                {
                    tempButton.Text = "X";
                    TrackPlayersTurn = false; // changes to false so that next button is o
                }
                else
                {
                    tempButton.Text = "O";
                    TrackPlayersTurn = true;
                }
                movesCount++;
                CheckWinnerBox();
            }
        }

        private void CheckWinnerBox()
        {
            // Check rows //button1.Text != "" - check
            if ((button2.Text == button3.Text && button3.Text == button4.Text && button2.Text != "") ||
                (button5.Text == button6.Text && button6.Text == button7.Text && button5.Text != "") ||
                (button8.Text == button9.Text && button9.Text == button10.Text && button8.Text != ""))
            {
                DisplayWinner();
            }

            // Check columns
            else if ((button2.Text == button5.Text && button5.Text == button8.Text && button2.Text != "") ||
                     (button3.Text == button6.Text && button6.Text == button9.Text && button3.Text != "") ||
                     (button4.Text == button7.Text && button7.Text == button10.Text && button4.Text != ""))
            {
                DisplayWinner();
            }

            //check diagonals
            else if ((button2.Text == button6.Text && button6.Text == button10.Text && button2.Text != "") ||
           (button4.Text == button6.Text && button6.Text == button8.Text && button4.Text != ""))
            {
                DisplayWinner();
            }

            // Check for draw
            else if (movesCount == 9)
            {
                Display.Text = "It's a DRAW!";
                DisableButtons();
            }
        }

        private void DisplayWinner()
        {
            string winner = TrackPlayersTurn ? "O" : "X"; // Since the turn changes after each move, the current player is the loser, and the last player is the winner.
            Display.Text = $"Player {winner} wins!";
            DisableButtons();

        }

        private void ResetGame()
        {
            // Clear all buttons
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            button10.Text = "";
            Display.Text = "";

            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;

            movesCount = 0; // Reset the move count
            TrackPlayersTurn = true; // Player X starts
        }

        private void DisableButtons()
        {
            // Disable all game buttons except the reset button
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            ResetGame();
        }
    }
}
