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
    public partial class StudentMainPage : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=laptop-gr3bo2cd;Initial Catalog=sinav_sistemi;Integrated Security=True");
        SqlCommand komut;
        SqlDataReader reader;
        public StudentMainPage()
        {
            InitializeComponent();
            GetSubjects();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //quize gider
            Exam1 one = new Exam1();
            one.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //sonuçları görüntüleye gider
            ViewResults result = new ViewResults();
            result.Show();
            this.Hide();
        }
        public static string SubName = "";

        private void SubjectCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            //seçilen ünite adı exam1 sayfasında kullanılmak üzere alınır
            SubName = SubjectCb.SelectedValue.ToString();
        }
        private void GetSubjects() //veri tabanındaki subjectsler gözükür ve seçilme işlemi yapılır
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select SName from SubjectTbl", baglanti);
            SqlDataReader reader;
            reader = komut.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("SName", typeof(string));
            dt.Load(reader);
            SubjectCb.ValueMember = "SName";
            SubjectCb.DataSource = dt;
            baglanti.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //login sayfasına gider
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void StudentMainPage_Load(object sender, EventArgs e)
        {

        }
    }
}
