using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace çekiliş
{
    public partial class Form1 : Form

    {
        int i = 0;
        string[] dizi = new string[200];
        


        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dizi[i] = textBox1.Text;

            i++;

          
            listBox1.Items.Add(i+". "+textBox1.Text);
            
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Random kz = new Random();

            label2.Text = dizi[kz.Next(0, i)];
            
            




        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
