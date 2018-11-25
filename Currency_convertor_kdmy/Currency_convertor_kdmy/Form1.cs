using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Currency_convertor_kdmy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lb_from.SelectedIndex = 0;
            lb_to.SelectedIndex = 1;
            this.MaximumSize = new System.Drawing.Size(816,489);
            this.MinimumSize = new System.Drawing.Size(816,489);
        }

        private void btn_convert_Click(object sender, EventArgs e)
        {
            string from, to;

            from = lb_from.SelectedItem.ToString();
            to = lb_to.SelectedItem.ToString();

            if (from == to)
            {
                MessageBox.Show("This is the same currency. Converting is impossible");
            }
            else if (tb_sum.Text == "")
            {
                MessageBox.Show("Input the SUM please");
            }
            else
            {
                webBrowser1.Navigate("https://www.google.ru/search?q=" + tb_sum.Text + " " + from + " %D0%B2 " + to);
            }
        }
    }
}

