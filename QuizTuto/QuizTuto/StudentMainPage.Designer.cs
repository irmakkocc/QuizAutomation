
namespace QuizTuto
{
    partial class StudentMainPage
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
            this.SubjectCb = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SubjectCb
            // 
            this.SubjectCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubjectCb.ForeColor = System.Drawing.SystemColors.GrayText;
            this.SubjectCb.FormattingEnabled = true;
            this.SubjectCb.Location = new System.Drawing.Point(252, 82);
            this.SubjectCb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SubjectCb.Name = "SubjectCb";
            this.SubjectCb.Size = new System.Drawing.Size(300, 37);
            this.SubjectCb.TabIndex = 28;
            this.SubjectCb.Text = "Üniteler";
            this.SubjectCb.SelectedIndexChanged += new System.EventHandler(this.SubjectCb_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SandyBrown;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(456, 158);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(206, 120);
            this.button2.TabIndex = 27;
            this.button2.Text = "Quiz Ol";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SandyBrown;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(126, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 120);
            this.button1.TabIndex = 26;
            this.button1.Text = "Durumunu Gör";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(704, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(63, 43);
            this.button3.TabIndex = 29;
            this.button3.Text = "x";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // StudentMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(778, 394);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.SubjectCb);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentMainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentMainPage";
            this.Load += new System.EventHandler(this.StudentMainPage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox SubjectCb;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}