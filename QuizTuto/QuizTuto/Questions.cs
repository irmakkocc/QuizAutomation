using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QuizTuto
{
    public partial class Questions : Form
    {
        public Questions()
        {
            InitializeComponent();
            GetSubjects();
            DisplayQuestions();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=laptop-gr3bo2cd;Initial Catalog=sinav_sistemi;Integrated Security=True");
        private void GetSubjects()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select SName from SubjectTbl", baglanti); //sql'e kayıtlı olan subjectlerden biri seçilir.
            SqlDataReader reader;
            reader = komut.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("SName", typeof(string));
            dt.Load(reader);
            SubjectCb.ValueMember = "SName";
            SubjectCb.DataSource = dt;
            baglanti.Close();
        }
        private void Reset()
        {
            //satırları boşalttı
            QuestTb.Text = "";
            Op1Tb.Text = "";
            Op2Tb.Text = "";
            Op3Tb.Text = "";
            Op4Tb.Text = "";
            AnswerTb.Text = "";
            PictureTb.Text = "";
            PictureBox.ImageLocation = "";
            SubjectCb.SelectedIndex = 0;
        }
        private void DisplayQuestions()
        {
            baglanti.Open();
            string Query = "select * from QuestionTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, baglanti);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            QuestionsDGV.DataSource = ds.Tables[0];
            baglanti.Close();
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (QuestTb.Text == "" || Op1Tb.Text == "" || Op2Tb.Text == "" || Op3Tb.Text == "" || Op4Tb.Text == ""||AnswerTb.Text == "")
            {
                //Null kabul etmeyenlerden biri girilirse kabul edilmez
                MessageBox.Show("Eksik Bilgi");
            }
            else
            {
                try
                {
                    byte[] ImageByteArray = File.ReadAllBytes(PictureBox.ImageLocation.ToString());
                    
                    baglanti.Open();
                    //girilen veriler yerlerine göre veri tabanına eklenir.
                    SqlCommand cmd = new SqlCommand("insert into QuestionTbl (questionDesc,qCvp1,qCvp2,qCvp3,qCvp4,qCvp,qS,imageFile) values (@QD,@O1,@O2,@O3,@O4,@Qan,@Qsu,@IF)", baglanti);
                    cmd.Parameters.AddWithValue("@Qd", QuestTb.Text);
                    cmd.Parameters.AddWithValue("@O1", Op1Tb.Text);
                    cmd.Parameters.AddWithValue("@O2", Op2Tb.Text);
                    cmd.Parameters.AddWithValue("@O3", Op3Tb.Text);
                    cmd.Parameters.AddWithValue("@O4", Op4Tb.Text);
                    cmd.Parameters.AddWithValue("@Qan", AnswerTb.Text);
                    cmd.Parameters.AddWithValue("@Qsu", SubjectCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@IF", ImageByteArray);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Soru Eklendi");
                    baglanti.Close();
                    Reset();
                    DisplayQuestions();

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
        int Key = 0;
        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (QuestTb.Text == "" || Op1Tb.Text == "" || Op2Tb.Text == "" || Op3Tb.Text == "" || Op4Tb.Text == "" || AnswerTb.Text == "")
            {
                MessageBox.Show("Eksik Bilgi");
            }
            else
            {
                try
                {
                    byte[] ImageByteArray = File.ReadAllBytes(PictureBox.ImageLocation.ToString());
                    //girilen veriler yerlerine göre veri tabanında güncellenir
                    baglanti.Open();
                    SqlCommand cmd = new SqlCommand("Update QuestionTbl set questionDesc=@QD,qCvp1=@O1,qCvp2=@O2,qCvp3=@O3,qCvp4=@O4,qCvp=@Qan,qS=@Qsu,imageFile=@IF  where questionID=@QKey", baglanti);
                    cmd.Parameters.AddWithValue("@QD", QuestTb.Text);
                    cmd.Parameters.AddWithValue("@O1", Op1Tb.Text);
                    cmd.Parameters.AddWithValue("@O2", Op2Tb.Text);
                    cmd.Parameters.AddWithValue("@O3", Op3Tb.Text);
                    cmd.Parameters.AddWithValue("@O4", Op4Tb.Text);
                    cmd.Parameters.AddWithValue("@Qan", AnswerTb.Text);
                    cmd.Parameters.AddWithValue("@Qsu", SubjectCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@IF", ImageByteArray);
                    cmd.Parameters.AddWithValue("@QKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Soru Güncellendi");
                    baglanti.Close();
                    Reset();
                    DisplayQuestions();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void QuestionsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //veri tabanındaki soruların aşağıdaki hücrede gözükmesi sağlanır.
            QuestTb.Text = QuestionsDGV.SelectedRows[0].Cells[1].Value.ToString();
            Op1Tb.Text = QuestionsDGV.SelectedRows[0].Cells[2].Value.ToString();
            Op2Tb.Text = QuestionsDGV.SelectedRows[0].Cells[3].Value.ToString();
            Op3Tb.Text = QuestionsDGV.SelectedRows[0].Cells[4].Value.ToString();
            Op4Tb.Text = QuestionsDGV.SelectedRows[0].Cells[5].Value.ToString();
            AnswerTb.Text = QuestionsDGV.SelectedRows[0].Cells[6].Value.ToString();
            SubjectCb.SelectedValue = QuestionsDGV.SelectedRows[0].Cells[7].Value.ToString();
            PictureBox.ImageLocation = QuestionsDGV.SelectedRows[0].Cells[8].Value.ToString();
            if (QuestTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(QuestionsDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void guna2CirclePictureBox4_Click(object sender, EventArgs e)
        {
            //sonuçlara gidilir
            ViewResults Obj = new ViewResults();
            Obj.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox3_Click(object sender, EventArgs e)
        {
            //ünitelere gidilir
            Subjects Obj = new Subjects();
            Obj.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //ünitelere gidilir
            Subjects Obj = new Subjects();
            Obj.Show();
            this.Hide();
        }

        private void guna2CirclePictureBox6_Click(object sender, EventArgs e)
        {
         
        }

        private void label6_Click(object sender, EventArgs e)
        {
            //sonuçları görüntüleye gidilir
            ViewResults Obj = new ViewResults();
            Obj.Show();
            this.Hide();
        }

        private void guna2CirclePictureBox5_Click(object sender, EventArgs e)
        {
            //giriş sayfasına gidilir
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }

        private void SubjectCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void QuestTb_OnValueChanged(object sender, EventArgs e)
        {

        }


        private void guna2CirclePictureBox2_Click(object sender, EventArgs e)
        {

        }

        //image'i alma
        private void PictureBox_Click(object sender, EventArgs e)
        {
            Stream myStream = null;

            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);    // masaüstünü göstermesi için
            openFileDialog1.Filter = "JPEG (*.jpg; *jpeg; *jpe)|*.jpg; *jpeg; *jpe|All files (*.*)|*.*";        // dosya filtrelemesi
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            foreach (string s in openFileDialog1.FileNames)     // multi select özelliği için kullanılabilir
                            {
                                PictureBox.ImageLocation = s;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: Dosya okunamadı!" + ex.Message);
                }
            }
        }

        private void Op1Tb_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
