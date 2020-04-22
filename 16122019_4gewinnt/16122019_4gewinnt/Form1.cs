using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16122019_4gewinnt
{
    public partial class Form1 : Form
    {
        double spieler = 1;
        string[,] belegt = new string[11, 10];


        string pickedcolor1;
        string pickedcolor2;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;


            string name = button.Name.Substring(4);
            string[] cache = new string[2];
            cache = name.Split('_');
            string a = cache[0];
            string b = cache[1];

            if (belegt[Convert.ToInt32(a), Convert.ToInt32(5)] == null)
            {

                if (spieler == 1)
                {
                    if (belegt[Convert.ToInt32(cache[0]), 5] == null)
                    {
                        lbl_status.Text = "Spieler 2 ist am Zug";
                        Place1(button);
                        spieler = 2;
                        WinCondition();
                    }
                    InitializeButton();
                }
                else if (spieler == 2)
                {
                    if (belegt[Convert.ToInt32(cache[0]), 5] == null)
                    {
                        lbl_status.Text = "Spieler 1 ist am Zug";
                        Place2(button);
                        spieler = 1;
                        WinCondition();
                    }
                    InitializeButton();
                }
            }


            InitializeButton();
        }
        private void Place1(Button button)
        {
            if (TestIfFree(button) == true)
            {
                InitializeButton();
            }
        }
        private void Place2(Button button)
        {
            if (TestIfFree(button) == true)
            {
                InitializeButton();
            }
        }
        private bool TestIfFree(Button button)
        {
            string name = button.Name.Substring(4);
            string[] cache = new string[2];
            cache = name.Split('_');

            Int32 a = Convert.ToInt32(cache[0]);
            Int32 b = Convert.ToInt32(cache[1]);

                b = 0;
                if (spieler == 1)
                {
                    while (belegt[a,b] != null && b < 7)
                    {
                        b++;
                    }
                    if (belegt[a, b] == null)
                    {
                        belegt[a, b] = "X";
                    }

                    return true;
                }
                else if (spieler == 2)
                {
                    while (belegt[a, b] != null && b < 7)
                    {
                        b++;
                    }

                if (belegt[a, b] == null)
                {
                    belegt[a, b] = "O";
                }

                    return true;
                }

            InitializeButton();
            return false;
        }
        private void InitializeButton()
        {
            Btn_0_0.Text = belegt[0, 0];
            Btn_0_1.Text = belegt[0, 1];
            Btn_0_2.Text = belegt[0, 2];
            Btn_0_3.Text = belegt[0, 3];
            Btn_0_4.Text = belegt[0, 4];
            Btn_0_5.Text = belegt[0, 5];

            Btn_1_0.Text = belegt[1, 0];
            Btn_1_1.Text = belegt[1, 1];
            Btn_1_2.Text = belegt[1, 2];
            Btn_1_3.Text = belegt[1, 3];
            Btn_1_4.Text = belegt[1, 4];
            Btn_1_5.Text = belegt[1, 5];

            Btn_2_0.Text = belegt[2, 0];
            Btn_2_1.Text = belegt[2, 1];
            Btn_2_2.Text = belegt[2, 2];
            Btn_2_3.Text = belegt[2, 3];
            Btn_2_4.Text = belegt[2, 4];
            Btn_2_5.Text = belegt[2, 5];

            Btn_3_0.Text = belegt[3, 0];
            Btn_3_1.Text = belegt[3, 1];
            Btn_3_2.Text = belegt[3, 2];
            Btn_3_3.Text = belegt[3, 3];
            Btn_3_4.Text = belegt[3, 4];
            Btn_3_5.Text = belegt[3, 5];

            Btn_4_0.Text = belegt[4, 0];
            Btn_4_1.Text = belegt[4, 1];
            Btn_4_2.Text = belegt[4, 2];
            Btn_4_3.Text = belegt[4, 3];
            Btn_4_4.Text = belegt[4, 4];
            Btn_4_5.Text = belegt[4, 5];

            Btn_5_0.Text = belegt[5,0];
            Btn_5_1.Text = belegt[5, 1];
            Btn_5_2.Text = belegt[5, 2];
            Btn_5_3.Text = belegt[5, 3];
            Btn_5_4.Text = belegt[5, 4];
            Btn_5_5.Text = belegt[5, 5];

            Btn_6_0.Text = belegt[6, 0];
            Btn_6_1.Text = belegt[6, 1];
            Btn_6_2.Text = belegt[6, 2];
            Btn_6_3.Text = belegt[6, 3];
            Btn_6_4.Text = belegt[6, 4];
            Btn_6_5.Text = belegt[6, 5];
            /*
            "blau",
            "rot",
            "grün",
            "lila",
            "türkis",
            "schwarz",
            "rosa",
            "pink",
            */
            foreach (Control bt in this.Controls)
            {

                if (bt is Button button)
                {
                    if (button.Text == "X")
                    {
                        button.ForeColor = colorDialog1.Color;
                    }
                    else if(button.Text == "O")
                    {
                        button.ForeColor = colorDialog2.Color;
                    }
                }
            }
        }
        private void WinCondition()
        {
            for (int i = 0; i < 7; i++)
            {
                for (int x = 0; x < 6; x++)
                {
                    if (belegt[i,x] == "X" || belegt[i,x] == "O")
                    {
                        /// horizontal
                        /// 
                        if (belegt[i,x] == belegt[i,x+1] && belegt[i,x+2] == belegt[i,x+3] && belegt[i,x] == belegt[i,x+2])
                        {
                            lbl_status.Text = "Spieler " + spieler + " hat Gewonnen!";
                            StopGame();
                        }
                        /// quer rechts runter
                        /// 
                        else if (belegt[i, x] == belegt[i + 1, x + 1] && belegt[i + 2, x + 2] == belegt[i + 3, x + 3] && belegt[i, x] == belegt[i + 2, x + 2])
                        {
                            lbl_status.Text = "Spieler " + spieler + " hat Gewonnen!";
                            StopGame();
                        }
                        /// quer rechts hoch
                        /// 
                        else if (i > 3 )
                        {
                            if (belegt[i, x] == belegt[i - 1, x + 1] && belegt[i - 2, x + 2] == belegt[i - 3, x + 3] && belegt[i, x] == belegt[i - 2, x + 2])
                            {
                                lbl_status.Text = "Spieler " + spieler + " hat Gewonnen!";
                                StopGame();
                            }
                        }
                        /// vertikal
                        /// 
                        else if (belegt[i, x] == belegt[i + 1, x] && belegt[i + 2, x] == belegt[i + 3, x] && belegt[i, x] == belegt[i + 2, x])
                        {
                            lbl_status.Text = "Spieler " + spieler + " hat Gewonnen!";
                            StopGame();
                        }
                        else
                        {
                            GameTied();
                        }
                    }
                }
            }
        }

        private void StopGame()
        {
            foreach (Control bt in this.Controls)
            {
                var button = bt as Button;
                    if (button != null)
                    {
                        button.Enabled = false;
                    }
            }
            btn_restart.Enabled = true;
            btn_close.Enabled = true;
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
                StartGame();
        }
        private void StartGame()
        {
            lbl_status.Text = "Spieler " + spieler + " ist am Zug";
            foreach (Control bt in this.Controls)
            {
                if (bt is Button button && button.Name != btn_pickcolor1.Name && button.Name != btn_pickcolor2.Name)
                {
                    button.Enabled = true;
                }
            }
            InitializeButton();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_restart_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Programm neustarten?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
                Application.Restart();
            }
        }

        public void btn_pickcolor1_Click(object sender, EventArgs e)
        {
            colorDialog1.AllowFullOpen = false;
            colorDialog1.ShowHelp = true;
            pickedcolor1 = Convert.ToString(colorDialog1);

            notifyIcon1.Text = "hihihihi";

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pickedcolor1 = Convert.ToString(colorDialog1.Color);
                pickedcolor1 = Convert.ToString(colorDialog1.Color);
            }

            btn_pickcolor1.ForeColor = colorDialog1.Color;

            if (pickedcolor1 != null)
            {
                btn_pickcolor1.Enabled = false;
                btn_pickcolor2.Enabled = true;
            }
            InitializeButton();
        }

        public void btn_pickcolor2_Click(object sender, EventArgs e)
        {
            colorDialog2.AllowFullOpen = false;
            colorDialog2.ShowHelp = true;

            pickedcolor2 = Convert.ToString(colorDialog2);

            if (colorDialog2.ShowDialog() == DialogResult.OK)
            {
                pickedcolor2 = Convert.ToString(colorDialog2.Color);
            }
            btn_pickcolor2.ForeColor = colorDialog2.Color;

            if (pickedcolor2 != null)
            {
                btn_pickcolor2.Enabled = false;
                StartGame();
            }
            InitializeButton();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Programm Schließen?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
                this.Close();
            }
        }
        private void GameTied()
        {
            double count = 0;

            for (int i = 0; i < 7; i++)
            {
                if (belegt[i,5] != null)
                {
                    count++;
                }
            }
            if (count == 7)
            {
                lbl_status.Text = "TIED";
                StopGame();
            }
        }
    }
}