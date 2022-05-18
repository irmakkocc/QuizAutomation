using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizTuto
{
    public partial class Register : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=laptop-gr3bo2cd;Initial Catalog=sinav_sistemi;Integrated Security=True");
        SqlCommand komut;
        SqlDataReader reader;
        public Register()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //girilen veriler yerlerine göre veri tabanına eklenir.
            try
            {
                komut = new SqlCommand("insert into kullaniciGiris (kullaniciAdi, kullaniciSoyadi, kullaniciSifre, kullaniciNickname) values (@KA,@KS,@KP,@KN )", baglanti);
                baglanti.Open();
                komut.Parameters.AddWithValue("@KA", uyeOlAd.Text);
                komut.Parameters.AddWithValue("@KS", uyeOlSoyad.Text);
                komut.Parameters.AddWithValue("@KP", uyeSifre.Text);
                komut.Parameters.AddWithValue("@KN", uyeKullaniciAdi.Text);
               // baglanti.Open();
                komut.ExecuteNonQuery();
                if (uyeSifre.Text == uyeSifreTekrar.Text)
                {
                    MessageBox.Show("Üye kaydınız oluşturulmuştur.");
                    baglanti.Close();
                }
                else
                {
                    MessageBox.Show("Şifreler uyuşmuyor!", "Hata");
                }
            }
            catch
            {
                //baglanti.Close();
                MessageBox.Show("DB'ye ulaşılamadı.");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //login sayfasına gidilir
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
}
