using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizTuto
{
    class ForgotPasswordC
    {
        SqlConnection baglanti = new SqlConnection("Data Source=laptop-gr3bo2cd;Initial Catalog=sinav_sistemi;Integrated Security=True");
        SqlCommand komut;
        public bool sifreUnuttum(string forgotSifre, string forgotNickname)
        {

            baglanti.Open();
            komut = new SqlCommand($"UPDATE kullaniciGiris SET kullaniciSifre = '{forgotSifre}' WHERE kullaniciNickname = '{forgotNickname}'", baglanti);
            //kullanıcı şifre nickname'e göre güncellenir.
            int etkilenenSatirlar = komut.ExecuteNonQuery();
            MessageBox.Show(etkilenenSatirlar.ToString());
            if (etkilenenSatirlar != 0)
            {
                MessageBox.Show("Başarılı bir şekilde güncellendi");
                return true;

            }
            else
            {
                MessageBox.Show("Kullanıcı Bilgileriniz Yanlış!", "Hata2");
                baglanti.Close();
                return false;
            }
        }
    }
}
