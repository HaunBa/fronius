using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _29112019_Bibliothek
{
    public partial class Form1 : Form
    {
        List<string> bücher = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string buchname = txt_buchname.Text;
            string author = txt_author.Text;
            string erschjahr = txt_erschjahr.Text;
            string verlag = txt_verlag.Text;
            string isbn = txt_isbn.Text;
            string temp = String.Join(" | " , buchname, author, erschjahr, verlag, isbn);


            if (isbntest() == true)
            {
                bücher.Add(Convert.ToString(temp));
                lbo_bibliothek.Items.Add(Convert.ToString(temp));
            }

            txt_author.Text = "";
            txt_buchname.Text = "";
            txt_erschjahr.Text = "";
            txt_isbn.Text = "";
            txt_verlag.Text = "";
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            bücher.RemoveAt(lbo_bibliothek.SelectedIndex);
            lbo_bibliothek.Items.Remove(lbo_bibliothek.SelectedItem);
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string suchterm = Convert.ToString(txt_suche.Text);
            string x = bücher.FirstOrDefault(s => s.Contains(suchterm));
            double index = bücher.IndexOf(x);

            lbo_bibliothek.SelectedIndex = Convert.ToInt16(index);

            lbl_index.Text = Convert.ToString(index);

            txt_suche.Text = "";
        }
        private bool isbntest()
        {
            if (Convert.ToString(txt_isbn.Text) == String.Empty)
            {
                errorProvider1.SetError(txt_isbn, "Bitte eine ISBN eingeben.");
                return false;
            }
            else
            {
                string temp = Convert.ToString(txt_isbn.Text);

                string beautified = temp.ToUpper().Replace("-", "").Replace(" ", "").Trim();

                double[] numbers = beautified.ToCharArray().Select<char, double>(i => i == 'X' ? 10 : double.Parse(i.ToString())).ToArray();

                if (numbers.Length == 10)
                {

                    double sum = 0;
                    for (int i = 0; i < 10; i++)
                    {
                        sum += numbers[i] * (10 - i);
                    }

                    if (sum % 11 == 0)
                    {
                        lbl_isbntest.Text = ("ISBN gültig!");
                        return true;
                    }
                    else
                    {
                        lbl_isbntest.Text = ("ISBN ungültig!");
                        return false;
                    }

                }
                else
                {
                    errorProvider1.SetError(txt_isbn, "Bitte eine gültige ISBN Eingeben");
                    return false;
                }
            }
        }
        private bool testforletter()
        {
            string temp = txt_isbn.Text.Trim();

            double num;

            bool isNum = double.TryParse(temp, out num);

            if (isNum)
            {
                return true;
            }
            else
            {
                errorProvider1.SetError(txt_isbn, "Bitte eine Zahl eingeben.");
                return false;
            }
        }
    }
}
