using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_tac_toe_new_version
{
    public partial class Form3 : Form
    {
        bool turn = true;//true=X turn; false=O turn
        int turn_count = 0;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is my first game made in Visual Studio\n \n Stefan Roata", "Tic Tac Toe About");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "O";
            turn = !turn;
            b.Enabled = false;
            turn_count++;
            CheckForWinner();
        }
        private void CheckForWinner()
        {
            bool there_is_a_winner = false;

            //horizontal
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && !A1.Enabled)
                there_is_a_winner = true;
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && !B1.Enabled)
                there_is_a_winner = true;
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && !C1.Enabled)
                there_is_a_winner = true;

            //vertical
            else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && !A1.Enabled)
                there_is_a_winner = true;
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && !A2.Enabled)
                there_is_a_winner = true;
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && !A3.Enabled)
                there_is_a_winner = true;

            //diagonal
            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && !A1.Enabled)
                there_is_a_winner = true;
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && !A3.Enabled)
                there_is_a_winner = true;


            if (there_is_a_winner)
            {
                disableButtons();

                String winner = "";
                if (turn)
                    winner = "O";
                else
                    winner = "X";

                MessageBox.Show(winner + " Wins!", "Congrats!");
                if (MessageBox.Show("Do you want to play a new game?", "Tic Tac Toe",
         MessageBoxButtons.YesNo, MessageBoxIcon.Question)
         == DialogResult.Yes)
                {
                    turn = true;
                    turn_count = 0;
                    try
                    {
                        foreach (Control c in Controls)
                        {
                            Button b = (Button)c;
                            b.Enabled = true;
                            b.Text = "";
                        }
                    }
                    catch { }
                }
                else
                    Application.Exit();
            }
            else
            {

                if (turn_count == 9)
                {
                    MessageBox.Show("Draw!", "No winner");
                    if (MessageBox.Show("Do you want to play a new game?", "Tic Tac Toe",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        == DialogResult.Yes)
                    {
                        turn = true;
                        turn_count = 0;
                        try
                        {
                            foreach (Control c in Controls)
                            {
                                Button b = (Button)c;
                                b.Enabled = true;
                                b.Text = "";
                            }
                        }
                        catch { }
                    }
                    else
                        Application.Exit();
                }
            }
        }

        private void disableButtons()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
            }
            catch { }

        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turn_count = 0;
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }
            }
            catch { }
        }

    }
}
