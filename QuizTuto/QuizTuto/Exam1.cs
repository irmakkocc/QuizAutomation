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
    public partial class Exam1 : Form
    {
        List<Question> questionList;
        int questionCatch=0;
        string trueAnswer;
        int trueAnswerCatch = 0,falseAnswerCatch=0;
        
        public Exam1()
        {
            InitializeComponent();
            CnameLbl.Text = StudentLogin.OgrName; //CnameLbl'a StudentLogin'deki öğrenci adı alınır ve yazdırılır o labela
            SubjectLbl.Text = StudentMainPage.SubName; //SubjectLbl'a StudentMainPage'deki seçtirilen ünite adı alınır ve yazdırılır o labela
        }
        int Qn;
        SqlConnection baglanti = new SqlConnection(@"Data Source=laptop-gr3bo2cd;Initial Catalog=sinav_sistemi;Integrated Security=True");
        string a1;
        int min;

        private void Q1_Enter(object sender, EventArgs e)
        {

        }

        private void Q1O1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Exam1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            questionList = new List<Question>();

            baglanti.Open();
            //sqlden resimi olan 10 soru çekildi:
            SqlCommand command = new SqlCommand("select top 10* from QuestionTbl where imageFile is not null and qS='"+SubjectLbl.Text+"'", baglanti);

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Question question = new Question();
                    question.questionTxt = reader["questionDesc"].ToString();
                    question.oA = reader["qCvp1"].ToString();
                    question.oB = reader["qCvp2"].ToString();
                    question.oC = reader["qCvp3"].ToString();
                    question.oD = reader["qCvp4"].ToString();
                    question.C = reader["qCvp"].ToString();
                    question.img = (Byte[])reader["imageFile"];
                    question.subject = reader["qS"].ToString();

                    questionList.Add(question);
                }
            }
            baglanti.Close();

            //1. soru boş çıkıyordu o yüzden buraya da bu kodları yazdım böylelikle birinci soru direkt buradan çekiliyor.
            MemoryStream mem = new MemoryStream(questionList[questionCatch].img);
            q01.Text = questionList[questionCatch].questionTxt.ToString();
            q1O1.Text = questionList[questionCatch].oA.ToString();
            q1O2.Text = questionList[questionCatch].oB.ToString();
            q1O3.Text = questionList[questionCatch].oC.ToString();
            q1O4.Text = questionList[questionCatch].oD.ToString();
            trueAnswer = questionList[questionCatch].C.ToString();
            pictureBox1.Image = Image.FromStream(mem);
        }
        int Chrono = 350;
        int Count = 0;

        private void QTimep_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Q1O2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void SubjectLbl_Click(object sender, EventArgs e)
        {

        }

        //burada zamanlama yapıldı fakat sanırsam çalıştıramadım??
        private void timer1_Tick(object sender, EventArgs e)
        {
            Chrono -= 1;
            Count += 1;
            TimingBar.Value = Count;
            TimeLbl.Text = "" + Chrono;
            if (TimingBar.Value == 350)
            {
                TimingBar.Value = 0;
                timer1.Stop();
                MessageBox.Show("Time Over");
                Login log = new Login();
                log.Show();
                this.Hide();

            }
        }

        int[] Keys = new int[1];

        private void InsertResult(int trueAnswerCount)
        {
            try
            {
                //sonuçlar trueAnswerCount'la ResultTbl tablosuna atılır.
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into ResultTbl (RSubject,RKullanici,RDate,RTime,RScore) values (@RS,@RK,@RD,@RT,@RSc)", baglanti);
                komut.Parameters.AddWithValue("@RS", SubjectLbl.Text);
                komut.Parameters.AddWithValue("@RK", CnameLbl.Text);
                komut.Parameters.AddWithValue("@RD", QDateP.Value.Date);
                komut.Parameters.AddWithValue("@RT", QTimep.Text);
                komut.Parameters.AddWithValue("@RSc", trueAnswerCount);

                komut.ExecuteNonQuery();
                baglanti.Close();
                //  Reset();

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StudentMainPage student = new StudentMainPage();
            student.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //butona bastıkça geriye kalan 9 tane soru if döngüsünde soru kısımlarına yazdırılır.
            questionCatch++;
            if(questionCatch<10)
            {
                MemoryStream mem = new MemoryStream(questionList[questionCatch].img);
                q01.Text = questionList[questionCatch].questionTxt.ToString();
                q1O1.Text = questionList[questionCatch].oA.ToString();
                q1O2.Text = questionList[questionCatch].oB.ToString();
                q1O3.Text = questionList[questionCatch].oC.ToString();
                q1O4.Text = questionList[questionCatch].oD.ToString();
                trueAnswer = questionList[questionCatch].C.ToString();
                pictureBox1.Image = Image.FromStream(mem);
            }
            //if döngüsünden çıkıldığında StudentMainPage sayfasına geçilir.
            else
            {
                InsertResult(trueAnswerCatch);
                StudentMainPage studentMainPage = new StudentMainPage();
                studentMainPage.Show();
                this.Hide();
            }
            if(q1O1.Checked)
            {
                //işaretlenen şık ve cevap A şıkkı
                if(q1O1.Text == trueAnswer)
                {
                    trueAnswerCatch++;
                }
                else
                {
                    falseAnswerCatch++;
                }
                
            }
            else if (q1O2.Checked)
            {
                //işaretlenen şık ve cevap B  şıkkı
                if (q1O2.Text == trueAnswer)
                {
                    trueAnswerCatch++;
                }
                else
                {
                    falseAnswerCatch++;
                }
            }
            else if (q1O3.Checked)
            {
                //işaretlenen şık ve cevap C şıkkı
                if (q1O3.Text == trueAnswer)
                {
                    trueAnswerCatch++;
                    
                }
                else
                {
                    falseAnswerCatch++;
                }
            }
            else if (q1O4.Checked)
            {
                //işaretlenen şık 
                if (q1O4.Text == trueAnswer)
                {
                    //cevap D şıkkı
                    trueAnswerCatch++;
                }
                else
                {
                    //cevap farklı bir seçenek
                    falseAnswerCatch++;
                }
            }
            else
            {
                //soru boş geçildi
                falseAnswerCatch++;
            }
            MessageBox.Show("Doğru cevap sayısı: " + trueAnswerCatch.ToString() + "\n Yanlış cevap sayısı: " + falseAnswerCatch.ToString());

        }
    }
        
}
