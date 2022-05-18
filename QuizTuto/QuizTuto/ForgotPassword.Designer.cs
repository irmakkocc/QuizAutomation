
namespace QuizTuto
{
    partial class ForgotPassword
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.sifreUnAd = new System.Windows.Forms.TextBox();
            this.sifreUnTekrar = new System.Windows.Forms.TextBox();
            this.sifreUnYeni = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonSifre = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.sifreUnKulAd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.sifreUnS = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(592, 18);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 66);
            this.button1.TabIndex = 10;
            this.button1.Text = "x";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Salmon;
            this.groupBox5.Controls.Add(this.sifreUnAd);
            this.groupBox5.Controls.Add(this.sifreUnTekrar);
            this.groupBox5.Controls.Add(this.sifreUnYeni);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.buttonSifre);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.sifreUnKulAd);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.sifreUnS);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox5.Location = new System.Drawing.Point(34, 94);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Size = new System.Drawing.Size(633, 709);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Şifremi Unuttum";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // sifreUnAd
            // 
            this.sifreUnAd.Location = new System.Drawing.Point(278, 63);
            this.sifreUnAd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sifreUnAd.Name = "sifreUnAd";
            this.sifreUnAd.Size = new System.Drawing.Size(295, 30);
            this.sifreUnAd.TabIndex = 4;
            // 
            // sifreUnTekrar
            // 
            this.sifreUnTekrar.Location = new System.Drawing.Point(274, 492);
            this.sifreUnTekrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sifreUnTekrar.Name = "sifreUnTekrar";
            this.sifreUnTekrar.PasswordChar = '*';
            this.sifreUnTekrar.Size = new System.Drawing.Size(295, 30);
            this.sifreUnTekrar.TabIndex = 9;
            // 
            // sifreUnYeni
            // 
            this.sifreUnYeni.Location = new System.Drawing.Point(274, 389);
            this.sifreUnYeni.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sifreUnYeni.Name = "sifreUnYeni";
            this.sifreUnYeni.PasswordChar = '*';
            this.sifreUnYeni.Size = new System.Drawing.Size(295, 30);
            this.sifreUnYeni.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.SeaShell;
            this.label11.Location = new System.Drawing.Point(189, 71);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 25);
            this.label11.TabIndex = 7;
            this.label11.Text = "Ad";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.SeaShell;
            this.label10.Location = new System.Drawing.Point(74, 500);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 25);
            this.label10.TabIndex = 6;
            this.label10.Text = "Şifre Tekrar";
            // 
            // buttonSifre
            // 
            this.buttonSifre.Location = new System.Drawing.Point(274, 625);
            this.buttonSifre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSifre.Name = "buttonSifre";
            this.buttonSifre.Size = new System.Drawing.Size(298, 54);
            this.buttonSifre.TabIndex = 1;
            this.buttonSifre.Text = "ŞİFRE DEĞİŞTİR";
            this.buttonSifre.UseVisualStyleBackColor = true;
            this.buttonSifre.Click += new System.EventHandler(this.buttonSifre_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.SeaShell;
            this.label9.Location = new System.Drawing.Point(66, 278);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 25);
            this.label9.TabIndex = 5;
            this.label9.Text = "Kullanıcı Adı";
            // 
            // sifreUnKulAd
            // 
            this.sifreUnKulAd.Location = new System.Drawing.Point(274, 271);
            this.sifreUnKulAd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sifreUnKulAd.Name = "sifreUnKulAd";
            this.sifreUnKulAd.Size = new System.Drawing.Size(295, 30);
            this.sifreUnKulAd.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.SeaShell;
            this.label7.Location = new System.Drawing.Point(141, 174);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 25);
            this.label7.TabIndex = 1;
            this.label7.Text = "Soyad";
            // 
            // sifreUnS
            // 
            this.sifreUnS.Location = new System.Drawing.Point(274, 166);
            this.sifreUnS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sifreUnS.Name = "sifreUnS";
            this.sifreUnS.Size = new System.Drawing.Size(295, 30);
            this.sifreUnS.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Salmon;
            this.label8.ForeColor = System.Drawing.Color.SeaShell;
            this.label8.Location = new System.Drawing.Point(100, 389);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 25);
            this.label8.TabIndex = 2;
            this.label8.Text = "Yeni Şifre";
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(705, 875);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgotPassword";
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox sifreUnAd;
        private System.Windows.Forms.TextBox sifreUnTekrar;
        private System.Windows.Forms.TextBox sifreUnYeni;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonSifre;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox sifreUnKulAd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox sifreUnS;
        private System.Windows.Forms.Label label8;
    }
}