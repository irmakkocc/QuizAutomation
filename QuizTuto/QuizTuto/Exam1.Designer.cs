
namespace QuizTuto
{
    partial class Exam1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button2 = new System.Windows.Forms.Button();
            this.q1 = new System.Windows.Forms.GroupBox();
            this.q1O4 = new System.Windows.Forms.RadioButton();
            this.q1O3 = new System.Windows.Forms.RadioButton();
            this.q1O2 = new System.Windows.Forms.RadioButton();
            this.q1O1 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.q01 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TimingBar = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.TimeLbl = new System.Windows.Forms.Label();
            this.SubjectLbl = new System.Windows.Forms.Label();
            this.CnameLbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.QDateP = new System.Windows.Forms.DateTimePicker();
            this.QTimep = new System.Windows.Forms.DateTimePicker();
            this.q1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.TimingBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(51, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 43);
            this.button2.TabIndex = 39;
            this.button2.Text = "x";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // q1
            // 
            this.q1.Controls.Add(this.q1O4);
            this.q1.Controls.Add(this.q1O3);
            this.q1.Controls.Add(this.q1O2);
            this.q1.Controls.Add(this.q1O1);
            this.q1.Controls.Add(this.button1);
            this.q1.Controls.Add(this.q01);
            this.q1.Controls.Add(this.pictureBox1);
            this.q1.Controls.Add(this.TimingBar);
            this.q1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q1.Location = new System.Drawing.Point(51, 68);
            this.q1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.q1.Name = "q1";
            this.q1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.q1.Size = new System.Drawing.Size(1872, 846);
            this.q1.TabIndex = 40;
            this.q1.TabStop = false;
            this.q1.Text = "Soru 1";
            this.q1.Enter += new System.EventHandler(this.Q1_Enter);
            // 
            // q1O4
            // 
            this.q1O4.AutoSize = true;
            this.q1O4.Location = new System.Drawing.Point(45, 749);
            this.q1O4.Name = "q1O4";
            this.q1O4.Size = new System.Drawing.Size(186, 33);
            this.q1O4.TabIndex = 46;
            this.q1O4.TabStop = true;
            this.q1O4.Text = "radioButton4";
            this.q1O4.UseVisualStyleBackColor = true;
            // 
            // q1O3
            // 
            this.q1O3.AutoSize = true;
            this.q1O3.Location = new System.Drawing.Point(45, 710);
            this.q1O3.Name = "q1O3";
            this.q1O3.Size = new System.Drawing.Size(186, 33);
            this.q1O3.TabIndex = 45;
            this.q1O3.TabStop = true;
            this.q1O3.Text = "radioButton3";
            this.q1O3.UseVisualStyleBackColor = true;
            // 
            // q1O2
            // 
            this.q1O2.AutoSize = true;
            this.q1O2.Location = new System.Drawing.Point(45, 667);
            this.q1O2.Name = "q1O2";
            this.q1O2.Size = new System.Drawing.Size(186, 33);
            this.q1O2.TabIndex = 44;
            this.q1O2.TabStop = true;
            this.q1O2.Text = "radioButton2";
            this.q1O2.UseVisualStyleBackColor = true;
            // 
            // q1O1
            // 
            this.q1O1.AutoSize = true;
            this.q1O1.Location = new System.Drawing.Point(45, 628);
            this.q1O1.Name = "q1O1";
            this.q1O1.Size = new System.Drawing.Size(186, 33);
            this.q1O1.TabIndex = 43;
            this.q1O1.TabStop = true;
            this.q1O1.Text = "radioButton1";
            this.q1O1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1143, 782);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 64);
            this.button1.TabIndex = 28;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // q01
            // 
            this.q01.AutoSize = true;
            this.q01.Location = new System.Drawing.Point(7, 347);
            this.q01.Name = "q01";
            this.q01.Size = new System.Drawing.Size(85, 29);
            this.q01.TabIndex = 27;
            this.q01.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(33, 38);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1070, 304);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // TimingBar
            // 
            this.TimingBar.Controls.Add(this.TimeLbl);
            this.TimingBar.Location = new System.Drawing.Point(941, 646);
            this.TimingBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TimingBar.Maximum = 350;
            this.TimingBar.Name = "TimingBar";
            this.TimingBar.ProgressColor = System.Drawing.Color.DodgerBlue;
            this.TimingBar.ProgressColor2 = System.Drawing.Color.Red;
            this.TimingBar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.TimingBar.ShadowDecoration.Parent = this.TimingBar;
            this.TimingBar.Size = new System.Drawing.Size(195, 200);
            this.TimingBar.TabIndex = 25;
            // 
            // TimeLbl
            // 
            this.TimeLbl.AutoSize = true;
            this.TimeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLbl.Location = new System.Drawing.Point(55, 76);
            this.TimeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TimeLbl.Name = "TimeLbl";
            this.TimeLbl.Size = new System.Drawing.Size(92, 40);
            this.TimeLbl.TabIndex = 23;
            this.TimeLbl.Text = "Tmg";
            // 
            // SubjectLbl
            // 
            this.SubjectLbl.AutoSize = true;
            this.SubjectLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubjectLbl.Location = new System.Drawing.Point(802, 23);
            this.SubjectLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SubjectLbl.Name = "SubjectLbl";
            this.SubjectLbl.Size = new System.Drawing.Size(112, 33);
            this.SubjectLbl.TabIndex = 41;
            this.SubjectLbl.Text = "Subject";
            this.SubjectLbl.Click += new System.EventHandler(this.SubjectLbl_Click);
            // 
            // CnameLbl
            // 
            this.CnameLbl.AutoSize = true;
            this.CnameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CnameLbl.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.CnameLbl.Location = new System.Drawing.Point(609, 27);
            this.CnameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CnameLbl.Name = "CnameLbl";
            this.CnameLbl.Size = new System.Drawing.Size(145, 29);
            this.CnameLbl.TabIndex = 26;
            this.CnameLbl.Text = "Kullanıcı Adı";
            // 
            // QDateP
            // 
            this.QDateP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.QDateP.Location = new System.Drawing.Point(359, 23);
            this.QDateP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.QDateP.Name = "QDateP";
            this.QDateP.Size = new System.Drawing.Size(222, 26);
            this.QDateP.TabIndex = 42;
            this.QDateP.Visible = false;
            // 
            // QTimep
            // 
            this.QTimep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QTimep.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.QTimep.Location = new System.Drawing.Point(13, 879);
            this.QTimep.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.QTimep.Name = "QTimep";
            this.QTimep.Size = new System.Drawing.Size(222, 35);
            this.QTimep.TabIndex = 27;
            this.QTimep.ValueChanged += new System.EventHandler(this.QTimep_ValueChanged);
            // 
            // Exam1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1936, 928);
            this.Controls.Add(this.QTimep);
            this.Controls.Add(this.QDateP);
            this.Controls.Add(this.CnameLbl);
            this.Controls.Add(this.SubjectLbl);
            this.Controls.Add(this.q1);
            this.Controls.Add(this.button2);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Exam1";
            this.Text = "Exam1";
            this.Load += new System.EventHandler(this.Exam1_Load);
            this.q1.ResumeLayout(false);
            this.q1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.TimingBar.ResumeLayout(false);
            this.TimingBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox q1;
        private System.Windows.Forms.Label SubjectLbl;
        private System.Windows.Forms.Label CnameLbl;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2CircleProgressBar TimingBar;
        private System.Windows.Forms.Label TimeLbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker QDateP;
        private System.Windows.Forms.DateTimePicker QTimep;
        public System.Windows.Forms.Label q01;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton q1O4;
        private System.Windows.Forms.RadioButton q1O3;
        private System.Windows.Forms.RadioButton q1O2;
        private System.Windows.Forms.RadioButton q1O1;
    }
}