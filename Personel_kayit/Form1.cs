using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Personel_kayit
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
      
        void temizle()
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
            maskedTextBox1.Text = " ";
            groupBox1.Text = " ";
            evlibut.Checked = false;
            bekarbut.Checked = false;

        }
        
        
        
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-HAGP6TN;Initial Catalog=PersonelVeri_Tabani;Integrated Security=True ");
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Listele_Click(object sender, EventArgs e)
        {
            this.personelTableAdapter.Fill(this.personelVeri_TabaniDataSet.Personel);
        }

        private void Kaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut =new SqlCommand("insert into dbo.Personel(PerAd,PerSoyad,PerSehir,PerMaas,PerMeslek,Perdurum)values(@p1,@p2,@p3,@p4,@p5,@p6)",baglanti);

            komut.Parameters.AddWithValue("@p1", textBox2.Text);
            komut.Parameters.AddWithValue("@p2", textBox3.Text);
            komut.Parameters.AddWithValue("@p3", comboBox1.Text);
            komut.Parameters.AddWithValue("@p4", maskedTextBox1.Text);
            komut.Parameters.AddWithValue("@p5", textBox4.Text);
            komut.Parameters.AddWithValue("@p6", label1.Text);

            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel Kayıt Edildi");
        }

        private void evlibut_CheckedChanged(object sender, EventArgs e)
        {
            if (evlibut.Checked == true)
            {
                label1.Text = "True";
            }
        }

        private void bekarbut_CheckedChanged(object sender, EventArgs e)
        {
            if (bekarbut.Checked == true)
            {
                label1.Text = "False";
            }
        }

        private void Temizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            textBox2.Text= dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textBox3.Text= dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            comboBox1.Text= dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            maskedTextBox1.Text= dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            label1.Text= dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            textBox4.Text= dataGridView1.Rows[secilen].Cells[6].Value.ToString();
        }

        private void label1_TextChanged(object sender, EventArgs e)
        {
            if (label1.Text == "True" )
            {
                evlibut.Checked = true;
               

            }
            if (label1.Text == "False")
            {
                bekarbut.Checked = true;
            }
        }

        private void Sil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutsil = new SqlCommand("Delete from dbo.Personel where Perid=@k1", baglanti);
            komutsil.Parameters.AddWithValue("@k1", textBox1.Text);
            komutsil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel Silindi");
        }

        private void Güncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutguncelle = new SqlCommand("Update dbo.Personel set PerAd=@a1,PerSoyad=@a2,PerSehir=@a3,PerMaas=@a4,PerDurum=@a5,PerMeslek=@a6 where Perid=@a7", baglanti);
            komutguncelle.Parameters.AddWithValue("@a1", textBox2.Text);
            komutguncelle.Parameters.AddWithValue("@a2", textBox3.Text);
            komutguncelle.Parameters.AddWithValue("@a3", comboBox1.Text);
            komutguncelle.Parameters.AddWithValue("@a4", maskedTextBox1.Text);
            komutguncelle.Parameters.AddWithValue("@a5", label1.Text);
            komutguncelle.Parameters.AddWithValue("@a6", textBox4.Text);
            komutguncelle.Parameters.AddWithValue("@a7", textBox1.Text);
            komutguncelle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncellendi");
        }

        private void İstatis_Click(object sender, EventArgs e)
        {
            Form2 fr = new Form2();
            fr.Show();
        }
    }
}
