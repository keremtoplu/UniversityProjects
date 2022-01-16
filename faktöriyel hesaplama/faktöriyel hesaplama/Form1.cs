using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace faktöriyel_hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi,fac;
           
            sayi = Convert.ToInt16(textBox1.Text);
            fac = 1;
            for (int i = sayi;i>=1; i--)
            {
                fac = fac * i;

            }
            textBox2.Text = fac.ToString();
        }
    }
}
