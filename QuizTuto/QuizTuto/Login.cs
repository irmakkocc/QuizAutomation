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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void SinavSorumBtn_Click(object sender, EventArgs e)
        {
            //sorumlu sayfası
            SınavSorumlusuLogin log = new SınavSorumlusuLogin();
            log.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //öğrenci sayfası
            StudentLogin st = new StudentLogin();
            st.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //admin sayfası
            AdminLogin log = new AdminLogin();
            log.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //şifremi unuttum sayfası
            Register reg = new Register();
            reg.Show();
            this.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
