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
    public partial class FormXulyChuoi : Form
    {
        public FormXulyChuoi()
        {
            InitializeComponent();
        }
        List<string> c1;
        List<string> c2;
        private void FormXulyChuoi_Load(object sender, EventArgs e)
        {

        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (txtS1.Text == txtS2.Text)
            {
                listBox1.Items.Add("2 chuỗi giống nhau");
            }
            else listBox1.Items.Add("2 chuỗi khác nhau");
        }

        private void btnCOMPARE2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            
            if (txtS1.Text.ToLower() == txtS2.Text.ToLower())
            {
                listBox1.Items.Add("2 chuỗi giống nhau");
            }
            else listBox1.Items.Add("2 chuỗi khác nhau");
        }

        private void btnConcat_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add(txtS1.Text + txtS2.Text);
        }

        private void btnIndexof_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < txtS1.Text.Length; i++)
            {
                if (txtS1.ToString().Contains(txtS2.ToString()) == true)
                {
                    txtS1.ToString().Replace
            }
            }
            
        }
    }
}
