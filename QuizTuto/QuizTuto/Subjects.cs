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
    public partial class Subjects : Form
    {
        public Subjects()
        {
            InitializeComponent();
            DisplaySubjects();
        }
        int Key = 0;
        private void Reset()
        {
            SNameTb.Text = "";
            Key = 0;
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=laptop-gr3bo2cd;Initial Catalog=sinav_sistemi;Integrated Security=True");
        private void DisplaySubjects()
        {
            baglanti.Open();
            string Query = "select * from SubjectTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, baglanti);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            SubjectsDGV.DataSource = ds.Tables[0];
            baglanti.Close();
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (SNameTb.Text=="") //subject yazılmadı
            {
                MessageBox.Show("Eksik Bilgi");
            }
            else
            {
                try
                {
                    //girilen subjecti veri tabanına ekledik.
                    baglanti.Open();
                    SqlCommand cmd = new SqlCommand("insert into SubjectTbl (SName) values (@Sn)", baglanti);
                    cmd.Parameters.AddWithValue("@Sn", SNameTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ünite Kaydedildi");
                    baglanti.Close();
                    Reset();
                    DisplaySubjects();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Reset(); 
        }

        private void SubjectsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }

        private void SubjectsDGV_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //alttaki hücrede subject adları gözükür.
            SNameTb.Text = SubjectsDGV.SelectedRows[0].Cells[1].Value.ToString();
            if (SNameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(SubjectsDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (SNameTb.Text == "") //subject adı seçilmedi
            {
                MessageBox.Show("Eksik Bilgi"); 
            }
            else
            {
                try
                {
                   //seçilen subject güncellendi veri tabanında
                    baglanti.Open();
                    SqlCommand cmd = new SqlCommand("Update SubjectTbl set SName=@Sn where SId=@SKey", baglanti);
                    cmd.Parameters.AddWithValue("@Sn", SNameTb.Text);
                    cmd.Parameters.AddWithValue("@SKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ünite Değiştirildi");
                    baglanti.Close();
                    Reset();
                    DisplaySubjects();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2CirclePictureBox4_Click(object sender, EventArgs e)
        {
            //sonuçları görüntüleye gider
            ViewResults Obj = new ViewResults();
            Obj.Show();
            this.Hide();
        }

        private void guna2CirclePictureBox2_Click(object sender, EventArgs e)
        {
            //soru girme sayfasına gider
            Questions Obj = new Questions();
            Obj.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //soru girme sayfasına gider
            Questions Obj = new Questions();
            Obj.Show();
            this.Hide();
        }

        private void guna2CirclePictureBox5_Click(object sender, EventArgs e)
        {
            //giriş sayfasına gider
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }

        private void guna2CirclePictureBox6_Click(object sender, EventArgs e)
        {
          
        }

        private void label6_Click(object sender, EventArgs e)
        {
            //sonuçları görüntüleye gider
            ViewResults Obj = new ViewResults();
            Obj.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
