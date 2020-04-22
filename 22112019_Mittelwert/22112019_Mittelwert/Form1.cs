using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22112019_Mittelwert
{
    public partial class Form1 : Form
    {

        double[] f;
        double anzahl = 10;
        double n = 10;
        double mw = 10;



        Mittelwert(f, anzahl, n, mw);

        private bool Mittelwert(double[] f, double anzahl, double n, double mw)
        {
            double temp = 10;
            mw = 10;

            if (0 < anzahl < temp)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            double temp = Convert.ToDouble(txt_input.Text);
            double[] f;
        }

        private void btn_calc_Click(object sender, EventArgs e)
        {

        }
    }
}
