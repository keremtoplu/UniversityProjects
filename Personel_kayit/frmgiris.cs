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
    public partial class frmgiris : Form
    {
        public frmgiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-HAGP6TN;Initial Catalog=PersonelVeri_Tabani;Integrated Security=True ");

        private void giris_btn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From dbo.yonetici where KullaniciAd=@p1 and Sifre=@p2", baglanti);
            komut.Parameters.AddWithValue("@p1", txt_kad.Text);
            komut.Parameters.AddWithValue("@p2", txt_kulsif.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Form1 fr = new Form1();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Yanlis Kullanici Adi Veya Sifre");


            }
            baglanti.Close();
        }


    }
}
