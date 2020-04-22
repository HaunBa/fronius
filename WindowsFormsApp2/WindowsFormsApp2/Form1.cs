using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09122019_Replace
{
    public partial class Form1 : Form
    {
        string[,] array = new string[3, 3]
        {
            { "1", "1", "1"},
            { "2", "2", "2"},
            { "3", "3", "3"}
        };
        Int32 x;
        Int32 z;

        string[] name = new string[2];
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_1_Click(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            InitializeButton(bt);
        }
        private void InitializeButton(Button bt)
        {
            foreach (Control button in this.Controls)
            {
                if (button.Text != "Restart")
                {
                    if (button is Button)
                    {
                            name = bt.Name.Substring(4).Split('_');

                            x = Convert.ToInt32(name[0]);
                            z = Convert.ToInt32(name[1]);

                            string test = array[x, z];
                            button.Text = test;

                    }

                }
            }
            x = 0;
            z = 0;
        }

        private void Btn_restart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btn_debug_Click(object sender, EventArgs e)
        {

        }
    }
}