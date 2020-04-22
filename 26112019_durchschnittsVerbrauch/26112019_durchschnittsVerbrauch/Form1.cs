using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _26112019_durchschnittsVerbrauch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
            if (Convert.ToString(txt_verbrauch.Text) == String.Empty || Convert.ToString(txt_strecke.Text) == String.Empty)
            {
                Texterror();
            }
            else
            {
                double verbrauch, strecke, summe;

                verbrauch = Convert.ToDouble(txt_verbrauch.Text);
                strecke = Convert.ToDouble(txt_strecke.Text);

                summe = (verbrauch / strecke) * 100;
                lbl_durchschnittsverbrauch.Text = Convert.ToString(summe) + " l";
            }

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void Texterror()
        {
            errorProvider1.SetError(this.txt_strecke, "Bitte eine Zahl eingeben.");
            errorProvider2.SetError(this.txt_verbrauch, "Bitte eine Zahl eingeben.");

        }
    }
}
