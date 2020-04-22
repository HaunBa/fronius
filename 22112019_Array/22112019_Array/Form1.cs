using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22112019_Array
{
    public partial class Form1 : Form
    {
        public static double summe;
        public static double i = 0;
        public static double length;
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
            double input;
            double[] f = new double[0];
            double anzahl = 0, mw = 0, n = 0;

            Array.Resize(ref f, f.Length + 1);



            if (txt_input.Text != String.Empty)
            {
                input = Convert.ToDouble(txt_input.Text);
                lbo_Array.Items.Add(input);

                if (i >= 5)
                {
                    i += 1;
                }
                
            }
            else if(txt_input.Text == String.Empty)
            {
                texterror();
            }
            Mittelwert(f, anzahl, n, mw);

        }

        public void texterror()
        {
            errorProvider1.SetError(this.txt_input, "Bitte eine Zahl eingeben.");
        }


        private void btn_clear_Click(object sender, EventArgs e)
        {
            lbo_Array.Items.Remove(lbo_Array.SelectedItem);
        }


        private void lbo_Array_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void Mittelwert(double[] f, double anzahl, double n, double mw)
        {
              mw = 0;
              int temp = 0;
              foreach (var item in f)
              {
                    
                mw = mw + f[temp];
                temp += 1;

                lbl_mittelwert.Text = Convert.ToString(mw);

              }
        }

        private void lbl_mittelwert_Click(object sender, EventArgs e)
        {
            lbl_mittelwert.Text = "2";
        }
    }
}
