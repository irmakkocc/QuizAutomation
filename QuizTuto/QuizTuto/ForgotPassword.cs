using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizTuto
{
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        ForgotPasswordC f = new ForgotPasswordC(); //Forgot password classına göre aşağıdaki işlemler yapılır
        private void buttonSifre_Click(object sender, EventArgs e)
        {
            if (sifreUnYeni.Text == sifreUnTekrar.Text)
            {
                bool cevap = f.sifreUnuttum(sifreUnYeni.Text, sifreUnKulAd.Text);
                if (cevap)
                {
                    MessageBox.Show("Başarılı bir şekilde şifre güncellendi");
                }
                else
                {
                    MessageBox.Show("Şifre güncellenemedi");
                }
            }
            else
            {
                MessageBox.Show("Şifreler uyuşmuyor");
            }
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }
    }
}
