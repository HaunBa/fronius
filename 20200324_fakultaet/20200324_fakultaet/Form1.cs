using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20200324_fakultaet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        long n = 0;

        private void btn_calc_Click(object sender, EventArgs e)
        {
            try
            {
                if (!long.TryParse(txt_input_n.Text, out n)) errorProvider1.SetError(txt_input_n, "Please insert a number."); 
                if (n < 0) throw new ArgumentOutOfRangeException();               
                else if (long.TryParse(MathOp.Fakultaet(n).ToString(), out n)) lbl_solution.Text = n.ToString();
            }
            catch (OverflowException)
            {
                errorProvider1.SetError(btn_calc, "The input number is too big");
            }
            catch (ArgumentOutOfRangeException)
            {
                errorProvider1.SetError(btn_calc, "The input number has to be positive");
            }
        }
    }
}
