using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_Homework3
{
    public partial class FormObject : Form
    {
        public FormObject()
        {
            InitializeComponent();
            Init();
        }
        Object A;
        public void Init()
        {
            A = new Object();
        }

        public class Object
        {
            private string _ho;
            private string _holot;
            private string _ten;
            public string Ho
            {
                get { return _ho; }
                set { _ho = value; }
            }
            public string Holot
            {
                get { return _holot; }
                set { _holot = value; }
            }
            public string Ten
            {
                get { return _ten; }
                set { _ten = value; }
            }
            public Object()
            {
                Ho = "";
                Holot = "";
                Ten = "";
            }
            public Object(string ho_init, string holot_init, string ten_init)
            {
                Ho = ho_init;
                Holot = holot_init;
                Ten = ten_init;
            }
        }
        void Gan(string hovaten)
        {
            string[] h_t = hovaten.Split(' ');
            A.Ho = h_t[0];
            A.Holot = h_t;
            A.Ten = h_t[-1];
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDung_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            Gan(txtHovaten.Text)
        }
    }
}
