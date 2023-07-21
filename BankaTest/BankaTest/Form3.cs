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

namespace BankaTest
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-S866UD2;Initial Catalog=DbBankaTest;Integrated Security=True");

        private void BtnKaydet_Click(object sender, EventArgs e)
        {

            //Kişiler Tablosuna Kişi Kaydetme
            baglanti.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO TBLKISILER (AD,SOYAD,TC,TELEFON,HESAPNO,SIFRE) VALUES (@P1,@P2,@P3,@P4,@P5,@P6)", baglanti);
            komut.Parameters.AddWithValue("@P1", TxtAd.Text);
            komut.Parameters.AddWithValue("@P2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@P3", MskTcKimlikNo.Text);
            komut.Parameters.AddWithValue("@P4", MskTelefon.Text);
            komut.Parameters.AddWithValue("@P5", MskHesapNo.Text);
            komut.Parameters.AddWithValue("@P6", TxtSifre.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kullanıcı Kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Hesaplar Tablosuna HesapNo Kaydetme
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("INSERT INTO TBLHESAP (HESAPNO,BAKIYE) VALUES (@P1,@P2)",baglanti);
            komut2.Parameters.AddWithValue("@P1",MskHesapNo.Text);
            komut2.Parameters.AddWithValue("@P2", "0000");
            komut2.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            int sayi = rastgele.Next(100000, 1000000);
            MskHesapNo.Text = sayi.ToString();
        }
    }
}
