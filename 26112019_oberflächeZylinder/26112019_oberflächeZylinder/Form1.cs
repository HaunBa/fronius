using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _26112019_oberflächeZylinder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
            double i = 0, u = 0, r = 0;

            if(txt_i.Text != String.Empty)
                i = Convert.ToDouble(txt_i.Text);
                lbl_outputi.Text = Convert.ToString(i + " A");


            if(txt_u.Text != String.Empty)
                u = Convert.ToDouble(txt_u.Text);
                lbl_outputu.Text = Convert.ToString(u + " V");

            if (txt_r.Text != String.Empty) 
                r = Convert.ToDouble(txt_r.Text);
                lbl_outputr.Text = Convert.ToString(r + " Ω");


            if (rbtn_i.Checked == true)
            {
                i = 0;
                i = u / r;
                lbl_outputi.Text = Convert.ToString(i + " A");
            }
            else if (rbtn_u.Checked == true)
            {
                u = r * i;
                lbl_outputu.Text = Convert.ToString(u + " V"); 
            }
            else if (rbtn_r.Checked == true)
            {
                r = u / i;
                lbl_outputr.Text = Convert.ToString(r + " Ω");
            
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
