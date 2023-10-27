using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_Homework3
{
    public partial class Form_USCLN : Form
    {
        public Form_USCLN()
        {
            InitializeComponent();
        }
        string option;
        
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rbtUSCLN_CheckedChanged(object sender, EventArgs e)
        {
            option = "USCLN";
        }

        private void rbtUSC_CheckedChanged(object sender, EventArgs e)
        {
            option = "USC";
        }
        int x, y, uscln, max, usc;
        private void btnKQ_Click(object sender, EventArgs e)
        {
            
            x = int.Parse(txtSothu1.Text);
            y = int.Parse(txtSothu2.Text);

            switch (option)
            {
                case ("USCLN"):
                    {
                        for (int i = 1; i < (x + 1); i++)
                        {
                            if (x % i == 0 && y % i == 0)
                                uscln = i;
                        }
                        listBox1.Items.Clear();
                        listBox1.Items.Add(uscln);
                        break;
                    }
                case ("USC"):
                    {
                        listBox1.Items.Clear();
                        max = 0;
                        if (x>y) { max = x; } else { max = y; }
                        for (int i = 1; i <= max; i++)
                        {
                            if (x % i == 0 & y % i == 0)
                            {
                                usc = i;
                                listBox1.Items.Add(usc);
                            }
                        }
                        break;
                    }
            }
        }
    }
}
