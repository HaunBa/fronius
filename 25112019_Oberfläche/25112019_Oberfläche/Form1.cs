using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _25112019_Oberfläche
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
            double width, length, height;

            width = Convert.ToDouble(txt_width.Text);
            length = Convert.ToDouble(txt_length.Text);
            height = Convert.ToDouble(txt_heigth.Text);

            Volumen(width, length, height);
            Oberfläche(width, length, height);

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Volumen(double width, double length, double height)
        {
            double volumen;

            volumen = width * length * height;

            lbl_volumen.Text = Convert.ToString(volumen) + " cm^3";

        }

        private void Oberfläche(double width, double length, double height)
        {
            double oberfläche;

            oberfläche = 2 * (width * length + width * height + length * height);
            lbl_oberfläche.Text = Convert.ToString(oberfläche) +" cm^2";

        }
    }
}
