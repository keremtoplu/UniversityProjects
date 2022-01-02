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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-HAGP6TN;Initial Catalog=PersonelVeri_Tabani;Integrated Security=True ");

        private void Form2_Load(object sender, EventArgs e)
        {

            //* toplam personel sayisi
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("Select Count(*) From dbo.Personel", baglanti);
            SqlDataReader dr = komut1.ExecuteReader();
            while (dr.Read())
            {
                lbltoplampers.Text = dr[0].ToString();
            }



            baglanti.Close();
            // bekar personel sayisi

            baglanti.Open();

            SqlCommand komut2 = new SqlCommand("Select Count(*) From dbo.Personel where Perdurum=0",baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                label5.Text = dr2[0].ToString();
            }
            baglanti.Close();

// sehir sayisi

            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("Select Count(distinct(PerSehir)) From dbo.Personel", baglanti);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                label6.Text = dr3[0].ToString();
            }
            baglanti.Close();

            //toplam maas

            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("Select Sum(PerMaas) From dbo.Personel", baglanti);
            SqlDataReader dr4 = komut5.ExecuteReader();
            while (dr4.Read())
            {
                toplammas.Text = dr4[0].ToString();
            }
            baglanti.Close();


            //ortalama maas 
            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("Select Avg(PerMaas) From dbo.Personel", baglanti);
            SqlDataReader dr5 = komut6.ExecuteReader();
            while (dr5.Read())
            {
                ortmas.Text = dr5[0].ToString();
            }
            baglanti.Close();
        }

            
    }
}
