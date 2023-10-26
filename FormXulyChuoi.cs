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
            string tu1, tu2, kqtu;
            tu1 = txtS1.Text;
            tu2 = txtS2.Text;
            int vitri = tu1.IndexOf(tu2);
            if (vitri >= 0 && tu2.Length > 0)
            {
                kqtu = tu1.Replace(tu2, "Chỗ này");
            }
            else
            {
                kqtu = tu1;
            }
            listBox1.Items.Clear();
            listBox1.Items.Add(kqtu);
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            txtS1.Text = "";
            txtS2.Text = "";
            txtS1.Focus();
        }

        private void btnstop_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string tu1, tu2, kqtu, mid_tu;
            tu1 = txtS1.Text;
            tu2 = txtS2.Text;
            if (tu1.Length == 0)
            {
                listBox1.Items.Add("nhập chuỗi vào");
                return;
            }
            string fist_tu = tu1.Substring(0,1);
            string last_tu = tu1.Substring(tu1.Length - 1);
            if (tu1.Length == 1)
            {
                fist_tu = "";
                mid_tu = tu1;
                last_tu = "";
            }
            else 
            {
                mid_tu = tu1.Substring(1, tu1.Length - 2);
            }
            kqtu = fist_tu + tu2 + mid_tu + tu2 + last_tu;
            listBox1.Items.Clear();
            listBox1.Items.Add(kqtu);
            
        }

        private void btnsubstring_Click(object sender, EventArgs e)
        {
            if (lblTieuDe.ToString().Contains("TRÌNH XỬ LÝ") ==true)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add(lblTieuDe.Text.Replace("TRÌNH XỬ LÝ", ""));
            }
        }
    }
}
