using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _25112019_array
{
    public partial class Form1 : Form

    {
        List<double> werte = new List<double>();

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
            string input = Convert.ToString(txt_input.Text);

            if (Convert.ToString(txt_input.Text) == String.Empty)
            {
                errorProvider1.SetError(txt_input, "Bitte eine Zahl eingeben.");
            }
            else if (testforletter(input))
            {
                werte.Add(Convert.ToDouble(txt_input.Text));

                lbo_array.Items.Add(Convert.ToString(txt_input.Text));

                lbl_max.Text = Convert.ToString(werte.Max());
                lbl_min.Text = Convert.ToString(werte.Min());

                Mittelwert(werte);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            lbo_array.Items.Remove(lbo_array.SelectedItem);

            werte.Remove(lbo_array.SelectedIndex);
        }

        private void Mittelwert(List<double> werte)
        {
            double summe = 0;
            if (werte.Count > 1)
            {
                for (int i = 0; i <= werte.Count - 1; i++)
                {
                    summe += werte[i];
                }
                summe /= werte.Count;

                lbl_Mittelwert.Text = Convert.ToString(summe);
            }
        }
        private bool testforletter(string input)
        {
            string temp = txt_input.Text.Trim();

            double num;

            bool isNum = double.TryParse(temp, out num);

            if (isNum)
            {
                return true;
            }
            else
            {
                errorProvider1.SetError(txt_input, "Bitte eine Zahl eingeben.");
                return false;
            }
        }
        private double Suche(string suchterm)
            {
                double suchterm1 = Convert.ToDouble(suchterm);
                double position = werte.IndexOf(suchterm1);

                return position + 1;
            }
        

        private void btn_search_Click(object sender, EventArgs e)
        {

            string suchterm = Convert.ToString(txt_search.Text);
            testforletter(suchterm);
            lbl_position.Text = Convert.ToString(Suche(suchterm));

        }
    }
}