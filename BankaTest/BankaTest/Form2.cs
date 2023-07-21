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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-S866UD2;Initial Catalog=DbBankaTest;Integrated Security=True");

        public string hesapNo;

        private void Form2_Load(object sender, EventArgs e)
        {
            LblHesapNo.Text = hesapNo;

            //Kişi Bilgilerini Çekme
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM TBLKISILER WHERE HESAPNO=@P1",baglanti);
            komut.Parameters.AddWithValue("@P1",hesapNo);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblAdSoyad.Text = dr[1] + " " + dr[2];
                LblTcKimlikNo.Text = dr[3].ToString();
                LblTelefon.Text = dr[4].ToString();
            }
            baglanti.Close();

            //Bakiyeyi Çekme
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("SELECT * FROM TBLHESAP WHERE HESAPNO=@P1",baglanti);
            komut2.Parameters.AddWithValue("@P1",hesapNo);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                LblBakiye.Text = dr2[1].ToString();
            }
        }

        private void BtnGonder_Click(object sender, EventArgs e)
        {
            //Gönderilen Hesabın Para Artışı
            baglanti.Open();
            SqlCommand komut = new SqlCommand("UPDATE TBLHESAP SET BAKIYE=BAKIYE+@P1 WHERE HESAPNO=@P2",baglanti);
            komut.Parameters.AddWithValue("@P1",decimal.Parse(TxtTutar.Text));
            komut.Parameters.AddWithValue("@P2",MskHesapNo.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();

            //Gönderen Hesabın Para Azalışı
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("UPDATE TBLHESAP SET BAKIYE=BAKIYE-@P1 WHERE HESAPNO=@P2", baglanti);
            komut2.Parameters.AddWithValue("@P1", decimal.Parse(TxtTutar.Text));
            komut2.Parameters.AddWithValue("@P2", hesapNo);
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Havale Gerçekleşti!");

            //Hareketler Tablosuna Veri Eklenmesi
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("INSERT INTO TBLHAREKET (GONDEREN,ALICI,TUTAR) VALUES (@P1,@P2,@P3)",baglanti);
            komut3.Parameters.AddWithValue("@P1", hesapNo);
            komut3.Parameters.AddWithValue("@P2",MskHesapNo.Text);
            komut3.Parameters.AddWithValue("@P3",TxtTutar.Text);
            komut3.ExecuteNonQuery();
            baglanti.Close();
        }
        private void BtnHareketler_Click(object sender, EventArgs e)
        {
            Form4 fr = new Form4();
            fr.hesapNo = LblHesapNo.Text;
            fr.Show();
        }
    }
}
