using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11122019_ArraySorting
{
    public partial class Form1 : Form
    {

        List<double> werte = new List<double>();
        Random random=new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_generate_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                werte.Add(RandomNumber());
                listBox1.Items.Add(Convert.ToString(werte[i]));              
            }
        }
        private double RandomNumber()
        {
            return random.Next(1,100);
        }

        private void Btn_sort_Click(object sender, EventArgs e)
        {
            werte.Sort();
            listBox1.Items.Clear();
            for (int i = 0; i < werte.Count-1; i++)
            {
                listBox1.Items.Add(Convert.ToString(werte[i]));
            }
        }

        private void Btn_remove_Click(object sender, EventArgs e)
        {
            werte.RemoveAt(listBox1.SelectedIndex);
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void Btn_removeduplicates_Click(object sender, EventArgs e)
        {
                List<double> NoDupeWerte = werte.Distinct().ToList();

                NoDupeWerte.Sort();
                listBox1.Items.Clear();
                for (int i = 0; i < NoDupeWerte.Count - 1; i++)
                {
                    listBox1.Items.Add(Convert.ToString(NoDupeWerte[i]));
                }
        }
    }
}
