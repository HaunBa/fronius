using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace klassen
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        CKreis oKreis = new CKreis();
        CQuadrat cQuadrat = new CQuadrat();
        Mama mama = new Mama();

        class Mama
        {
            public double multiplikant1;

            public double multiplikant2;

            public double Multiplizieren() => multiplikant1 * multiplikant2;
        }
        class CKreis
        {
            public double radius;
            public double Umfang() => 2 * radius * Math.PI;
            public double Flaeche() => Math.Pow(radius, 2) * Math.PI;
        }
        class CQuadrat
        {
            public double Seite;

            public double Umfang() => 4 * Seite;
            public double Flaeche() => Math.Pow(Seite, 2);
        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
            oKreis.radius = Convert.ToDouble(txt_radius.Text);
            cQuadrat.Seite = Convert.ToDouble(txt_length.Text);
            mama.multiplikant1 = Convert.ToDouble(txt_length.Text);
            mama.multiplikant2 = Convert.ToDouble(txt_radius.Text);
            
            /// Kreisberechnung Ausgabe

            lbl_flaechekreis.Text = Convert.ToString(Math.Round(oKreis.Flaeche(), 3).ToString("0.000"));
            lbl_umfangkreis.Text = Convert.ToString(Math.Round(oKreis.Umfang(), 3).ToString("0.000"));

            /// Quadratberechnung Ausgabe

            lbl_flaechequadrat.Text = Convert.ToString(Math.Round(cQuadrat.Flaeche(), 3).ToString("0.000"));
            lbl_umfangquadrat.Text = Convert.ToString(Math.Round(cQuadrat.Umfang(), 3).ToString("0.000"));

            /// Mutliplizierung von länge und radius

            lbl_endergebnis.Text = Convert.ToString(mama.Multiplizieren());


        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
