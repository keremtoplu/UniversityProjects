using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kdv_hesaplayıcı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string urunisim;
            double urunfiyat, kdv, kdv2;
            urunisim = textBox1.Text;
            urunfiyat = Convert.ToDouble(textBox2.Text);
            kdv = (urunfiyat * 18 / 100) + urunfiyat;
            kdv2 = (urunfiyat * 8 / 100) + urunfiyat;
            listBox1.Items.Add(urunisim + " " + "%8 Kdv'li hali: " + kdv2 + " " + "%18 Kdv'li hali: " + kdv);
        }
    }
}
