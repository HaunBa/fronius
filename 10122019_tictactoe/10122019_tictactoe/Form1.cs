using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10122019_tictactoe
{
    public partial class Tiktaktoe : Form
    {
        double spieler = 1;
        char[,] feld = new char[3, 3];
        double count = 0;
        double test = 0;
        public Tiktaktoe()
        {
            InitializeComponent();
        }

        private void Btn_restart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void Btn_11_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            string location = button.Location.ToString();
            lbl_winner.Text = location;
            string buttontag = Convert.ToString(button.Tag);
            if (button.Text == " ")
            {
                SaveEntry(buttontag);
                if (spieler == 1)
                {
                    spieler = 2;

                    button.Text = "X";
                    button.ForeColor = Color.Blue;
                }
                else if (spieler == 2)
                {

                    spieler = 1;

                    button.Text = "O";
                    button.ForeColor = Color.Green;
                }
            }
            count += 1;
            WinCondition(feld);

        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void WinCondition(char[,] feld)
        {
            if
                (
                    ((feld[0, 0] == 'O') && (feld[0, 1] == 'O') && (feld[0, 2] == 'O')) ||
                    ((feld[1, 0] == 'O') && (feld[1, 1] == 'O') && (feld[1, 2] == 'O')) ||
                    ((feld[2, 0] == 'O') && (feld[2, 1] == 'O') && (feld[2, 2] == 'O')) ||
                    ((feld[0, 0] == 'O') && (feld[1, 0] == 'O') && (feld[2, 0] == 'O')) ||
                    ((feld[0, 1] == 'O') && (feld[1, 1] == 'O') && (feld[2, 1] == 'O')) ||
                    ((feld[0, 2] == 'O') && (feld[1, 2] == 'O') && (feld[2, 2] == 'O')) ||
                    ((feld[0, 0] == 'O') && (feld[1, 1] == 'O') && (feld[2, 2] == 'O')) ||
                    ((feld[0, 2] == 'O') && (feld[1, 1] == 'O') && (feld[2, 0] == 'O'))
                )
            {
                lbl_winner.Text = "Spieler 2 hat gewonnen!";
                DisableButton();

            }

            else if
            (
                ((feld[0, 0] == 'X') && (feld[0, 1] == 'X') && (feld[0, 2] == 'X')) ||
                ((feld[1, 0] == 'X') && (feld[1, 1] == 'X') && (feld[1, 2] == 'X')) ||
                ((feld[2, 0] == 'X') && (feld[2, 1] == 'X') && (feld[2, 2] == 'X')) ||
                ((feld[0, 0] == 'X') && (feld[1, 0] == 'X') && (feld[2, 0] == 'X')) ||
                ((feld[0, 1] == 'X') && (feld[1, 1] == 'X') && (feld[2, 1] == 'X')) ||
                ((feld[0, 2] == 'X') && (feld[1, 2] == 'X') && (feld[2, 2] == 'X')) ||
                ((feld[0, 0] == 'X') && (feld[1, 1] == 'X') && (feld[2, 2] == 'X')) ||
                ((feld[0, 2] == 'X') && (feld[1, 1] == 'X') && (feld[2, 0] == 'X'))
            )
            {
                lbl_winner.Text = "Spieler 1 hat gewonnen!";
                DisableButton();
            }
            if (count == 9)
            {
                DisableButton();
                lbl_winner.Text = "Kein Spieler hat gewonnen!";
            }
        }
        private void SaveEntry(string buttontag)
        {
            string[] location = new string[2];
            location = buttontag.Split(',');

            Int32 a = Convert.ToInt32(location[0]);
            Int32 b = Convert.ToInt32(location[1]);

            if (spieler == 1)
            {
                feld[a, b] = 'X';
            }
            else
            {
                feld[a, b] = 'O';
            }
           
        }
        private void DisableButton()
        {
            btn_11.Enabled = false;
            btn_12.Enabled = false;
            btn_13.Enabled = false;
            btn_21.Enabled = false;
            btn_22.Enabled = false;
            btn_23.Enabled = false;
            btn_31.Enabled = false;
            btn_32.Enabled = false;
            btn_33.Enabled = false;
        }
    }
}
