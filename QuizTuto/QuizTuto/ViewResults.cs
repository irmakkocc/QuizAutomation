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
    public partial class ViewResults : Form
    {
        public ViewResults()
        {
            InitializeComponent();
            GetSubjects();
            GetCandidate();
            DisplayResults();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=laptop-gr3bo2cd;Initial Catalog=sinav_sistemi;Integrated Security=True");
        private void GetSubjects() //subject veri tabanından subject adı seçildi
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select SName from SubjectTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("SName", typeof(string));
            dt.Load(rdr);
            SubjectCb.ValueMember = "SName";
            SubjectCb.DataSource = dt;
            Con.Close();
        }
        private void GetCandidate() //kullanıcı veri tabanından kullanıcı adı seçildi
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select kullaniciAdi from kullaniciGiris", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("kullaniciAdi", typeof(string));
            dt.Load(rdr);
            Cbox.ValueMember = "kullaniciAdi";
            Cbox.DataSource = dt;
            Con.Close();
        }
        private void DisplayResults()
        {
            //result tablosunda yaptığımız filtrelemeye göre sonuçlar gösterildi
            Con.Open();
            string Query = "select * from ResultTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ResultsDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void FilterBySub() //result veri tabanında seçilen subject adına göre filtrelendi
        {
            Con.Open();
            string Query = "select * from ResultTbl where RSubject='"+SubjectCb.SelectedValue.ToString()+"'";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ResultsDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void FilterByCandidate() //result veri tabanında seçilen kullanıcıya göre filtrelendi
        {
            Con.Open();
            string Query = "select * from ResultTbl where RKullanici='" + Cbox.SelectedValue.ToString() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ResultsDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void guna2CirclePictureBox2_Click(object sender, EventArgs e)
        {
            //soru ekleme ekranına gider
            Questions Obj = new Questions();
            Obj.Show();
            this.Hide();
        }

        private void SubjectCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //ünitenin gözüktüğü yerde üniteyi gösterip ona göre filtreliyoruz
            FilterBySub();
        }

        private void Cbox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //kullanıcının gözüktüğü yerde kullanıcıyı gösterip ona göre filtreliyoruz
            FilterByCandidate();
        }

        private void guna2CirclePictureBox5_Click(object sender, EventArgs e)
        {
            //logine gider
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }

        private void guna2CirclePictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox3_Click(object sender, EventArgs e)
        {
            //ünite girme kısmına gider
            Subjects Obj = new Subjects();
            Obj.Show();
            this.Hide();
        }

        private void guna2CirclePictureBox6_Click(object sender, EventArgs e)
        {
           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            //ünite girme kısmına gider
            Subjects Obj = new Subjects();
            Obj.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //soru girme kısmına gider
            Questions Obj = new Questions();
            Obj.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Cbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
