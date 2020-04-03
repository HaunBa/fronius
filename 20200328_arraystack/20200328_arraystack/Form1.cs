using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20200328_arraystack
{
    public partial class Form1 : Form
    {
        ArrayStack<string> stack = new ArrayStack<string>(15);

        public Form1()
        {
            InitializeComponent();
            txt_outValue.Enabled = false;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_push_Click(object sender, EventArgs e)
        {
            stack.Push(txt_inValue.Text);
            lbo_out.Items.Add(txt_inValue.Text);
            txt_inValue.Text = "";
        }

        private void btn_pop_Click(object sender, EventArgs e)
        {
            txt_outValue.Text = stack.Pop();
            lbo_out.Items.RemoveAt(lbo_out.Items.Count-1);

        }

        private void btn_isEmpty_Click(object sender, EventArgs e)
        {
            switch (stack.Empty())
            {
                case false:
                    lbl_isEmpty.Text = "false";
                    break;

                case true:
                    lbl_isEmpty.Text = "true";
                    break;
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            stack.Clear();
            lbo_out.Items.Clear();
            txt_outValue.Text = "";
        }

        private void btn_peek_Click(object sender, EventArgs e)
        {
            txt_outValue.Text = stack.Peek();
        }
    }
}