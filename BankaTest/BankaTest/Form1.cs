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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-S866UD2;Initial Catalog=DbBankaTest;Integrated Security=True");

        private void LnkKayitOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 fr = new Form3();
            fr.Show();
        }

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM TBLKISILER WHERE HESAPNO=@P1 AND SIFRE=@P2",baglanti);
            komut.Parameters.AddWithValue("@P1",MskHesapNo.Text);
            komut.Parameters.AddWithValue("@P2",TxtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Form2 fr = new Form2();
                fr.hesapNo = MskHesapNo.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Girişi!");
            }
            baglanti.Close();
        }
    }
}
