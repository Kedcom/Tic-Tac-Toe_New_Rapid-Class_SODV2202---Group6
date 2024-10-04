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

        }


    }
}
