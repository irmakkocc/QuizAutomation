
namespace QuizTuto
{
    partial class Register
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.uyeOlAd = new System.Windows.Forms.TextBox();
            this.uyeSifreTekrar = new System.Windows.Forms.TextBox();
            this.uyeSifre = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.uyeKullaniciAdi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.uyeOlSoyad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(591, 18);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 66);
            this.button1.TabIndex = 9;
            this.button1.Text = "x";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Salmon;
            this.groupBox4.Controls.Add(this.uyeOlAd);
            this.groupBox4.Controls.Add(this.uyeSifreTekrar);
            this.groupBox4.Controls.Add(this.uyeSifre);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.uyeKullaniciAdi);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.uyeOlSoyad);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.Location = new System.Drawing.Point(34, 94);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Size = new System.Drawing.Size(633, 737);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Üye Ol";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // uyeOlAd
            // 
            this.uyeOlAd.Location = new System.Drawing.Point(278, 63);
            this.uyeOlAd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uyeOlAd.Name = "uyeOlAd";
            this.uyeOlAd.Size = new System.Drawing.Size(295, 30);
            this.uyeOlAd.TabIndex = 4;
            // 
            // uyeSifreTekrar
            // 
            this.uyeSifreTekrar.Location = new System.Drawing.Point(274, 492);
            this.uyeSifreTekrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uyeSifreTekrar.Name = "uyeSifreTekrar";
            this.uyeSifreTekrar.PasswordChar = '*';
            this.uyeSifreTekrar.Size = new System.Drawing.Size(295, 30);
            this.uyeSifreTekrar.TabIndex = 9;
            // 
            // uyeSifre
            // 
            this.uyeSifre.Location = new System.Drawing.Point(274, 389);
            this.uyeSifre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uyeSifre.Name = "uyeSifre";
            this.uyeSifre.PasswordChar = '*';
            this.uyeSifre.Size = new System.Drawing.Size(295, 30);
            this.uyeSifre.TabIndex = 8;
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
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(374, 643);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(201, 54);
            this.button4.TabIndex = 1;
            this.button4.Text = "ÜYE OL";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
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
            // uyeKullaniciAdi
            // 
            this.uyeKullaniciAdi.Location = new System.Drawing.Point(274, 271);
            this.uyeKullaniciAdi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uyeKullaniciAdi.Name = "uyeKullaniciAdi";
            this.uyeKullaniciAdi.Size = new System.Drawing.Size(295, 30);
            this.uyeKullaniciAdi.TabIndex = 4;
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
            // uyeOlSoyad
            // 
            this.uyeOlSoyad.Location = new System.Drawing.Point(274, 166);
            this.uyeOlSoyad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uyeOlSoyad.Name = "uyeOlSoyad";
            this.uyeOlSoyad.Size = new System.Drawing.Size(295, 30);
            this.uyeOlSoyad.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Salmon;
            this.label8.ForeColor = System.Drawing.Color.SeaShell;
            this.label8.Location = new System.Drawing.Point(166, 389);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 25);
            this.label8.TabIndex = 2;
            this.label8.Text = "Şifre";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(704, 903);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox uyeOlAd;
        private System.Windows.Forms.TextBox uyeSifreTekrar;
        private System.Windows.Forms.TextBox uyeSifre;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox uyeKullaniciAdi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox uyeOlSoyad;
        private System.Windows.Forms.Label label8;
    }
}