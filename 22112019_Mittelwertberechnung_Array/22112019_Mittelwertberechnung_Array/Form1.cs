using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22112019_Mittelwertberechnung_Array
{
    public partial class Form1 : Form
    {

        int anzahl = 0;
        double[] f;
        int n = 0;
        double mw = 0;



        Mittelwert(f, anzahl, n, mw);

        static bool Mittelwert(double[] f, int anzahl, int n, out double mw)
        {
            mw = 10;
            f.Length = lbl_mittelwert;

            if (0 <= anzahl <= temp)
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

            

        }
    }
}
