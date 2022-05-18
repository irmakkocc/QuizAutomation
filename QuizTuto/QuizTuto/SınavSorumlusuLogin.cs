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
    public partial class SınavSorumlusuLogin : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=laptop-gr3bo2cd;Initial Catalog=sinav_sistemi;Integrated Security=True");
        SqlCommand komut;
        SqlDataReader reader;
        public SınavSorumlusuLogin()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            //veri tabanına göre kullanıcı bilgileri alınır ve giriş yapılır.
            try
            {
                komut = new SqlCommand("select kullaniciNickname, kullaniciSifre from kullaniciGiris where kullaniciNickname=@KN and kullaniciSifre = @KS", baglanti);
                komut.Parameters.AddWithValue("@KN", txtKullaniciAdi.Text);
                komut.Parameters.AddWithValue("@KS", txtKullaniciSifre.Text);
                baglanti.Open();
                reader = komut.ExecuteReader();
                if (reader.Read())
                {
                    //doğru biligiler girildi soru formuna yönlendirilir.
                    Questions main = new Questions();
                    main.Show();
                    this.Hide();
                }
                else
                {
                    //girilenlerden biri yanlış
                    MessageBox.Show("Yanlış Bilgi");
                }
            }
            catch
            {
                baglanti.Close();
                MessageBox.Show("DB'ye ulaşılamadı.");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //login ana sayfası
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void ForgotPswrd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //şifremi unuttum sayfası
            ForgotPassword pass = new ForgotPassword();
            pass.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
