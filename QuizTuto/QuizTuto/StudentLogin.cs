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
    public partial class StudentLogin : Form
    {
        public StudentLogin()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=laptop-gr3bo2cd;Initial Catalog=sinav_sistemi;Integrated Security=True");
        SqlCommand komut;
        SqlDataReader reader;
        private void button2_Click(object sender, EventArgs e)
        {
            //girilen verilere göre veri tabanında doğruluğu kontrol edilir
           try
            {
                komut = new SqlCommand("select kullaniciNickname, kullaniciSifre from kullaniciGiris where kullaniciNickname=@KN and kullaniciSifre = @KS", baglanti);
                komut.Parameters.AddWithValue("@KN", ogrKullaniciAdi.Text);
                komut.Parameters.AddWithValue("@KS", ogrSifre.Text);
                baglanti.Open();
                reader = komut.ExecuteReader();
                if(reader.Read())
                {
                    //doğru bilgiler yapıldı
                    StudentMainPage main = new StudentMainPage(); //öğrenci ana sayfasına yönlendirildi
                    main.Show();
                    this.Hide();
                }
                else
                {
                    //bilgiler yanlış girildi
                    MessageBox.Show("Yanlış Bilgi");
                }
            }
            catch
            {
                baglanti.Close();
                MessageBox.Show("DB'ye ulaşılamadı.");
            }
        }
        public static string OgrName = "";

        private void ogrKullaniciAdi_TextChanged(object sender, EventArgs e)
        {
            OgrName = ogrKullaniciAdi.Text;  //burada girilen öğrenci kullanıcı adını daha sonra diğer formlarda kullanmak üzere alıyoruz
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPassword pass = new ForgotPassword(); //şifremi unuttum sayfasına gider
            pass.Show();
            this.Hide();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
