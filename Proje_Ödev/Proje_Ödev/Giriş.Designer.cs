namespace Proje_Ödev
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblHata = new System.Windows.Forms.Label();
            this.BtnVazgec = new System.Windows.Forms.Button();
            this.BtnGırıs = new System.Windows.Forms.Button();
            this.groupboxgırıs = new System.Windows.Forms.GroupBox();
            this.ComboKullanıcı = new System.Windows.Forms.ComboBox();
            this.TxtSıfre = new System.Windows.Forms.TextBox();
            this.LblSıfre = new System.Windows.Forms.Label();
            this.LblKullanıcı = new System.Windows.Forms.Label();
            this.groupboxgırıs.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblHata
            // 
            this.LblHata.AutoSize = true;
            this.LblHata.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblHata.Location = new System.Drawing.Point(232, 384);
            this.LblHata.Name = "LblHata";
            this.LblHata.Size = new System.Drawing.Size(368, 28);
            this.LblHata.TabIndex = 11;
            this.LblHata.Text = "Kullanıcı Adı Veya Şifre Yanlış! ";
            // 
            // BtnVazgec
            // 
            this.BtnVazgec.BackColor = System.Drawing.Color.LightBlue;
            this.BtnVazgec.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnVazgec.Location = new System.Drawing.Point(536, 295);
            this.BtnVazgec.Name = "BtnVazgec";
            this.BtnVazgec.Size = new System.Drawing.Size(158, 54);
            this.BtnVazgec.TabIndex = 10;
            this.BtnVazgec.Text = "Vazgeç";
            this.BtnVazgec.UseVisualStyleBackColor = false;
            this.BtnVazgec.Click += new System.EventHandler(this.BtnVazgec_Click);
            // 
            // BtnGırıs
            // 
            this.BtnGırıs.BackColor = System.Drawing.Color.LightBlue;
            this.BtnGırıs.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGırıs.Location = new System.Drawing.Point(118, 295);
            this.BtnGırıs.Name = "BtnGırıs";
            this.BtnGırıs.Size = new System.Drawing.Size(158, 54);
            this.BtnGırıs.TabIndex = 9;
            this.BtnGırıs.Text = "Giriş";
            this.BtnGırıs.UseVisualStyleBackColor = false;
            this.BtnGırıs.Click += new System.EventHandler(this.BtnGırıs_Click);
            // 
            // groupboxgırıs
            // 
            this.groupboxgırıs.Controls.Add(this.ComboKullanıcı);
            this.groupboxgırıs.Controls.Add(this.TxtSıfre);
            this.groupboxgırıs.Controls.Add(this.LblSıfre);
            this.groupboxgırıs.Controls.Add(this.LblKullanıcı);
            this.groupboxgırıs.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupboxgırıs.Location = new System.Drawing.Point(71, 38);
            this.groupboxgırıs.Name = "groupboxgırıs";
            this.groupboxgırıs.Size = new System.Drawing.Size(659, 241);
            this.groupboxgırıs.TabIndex = 8;
            this.groupboxgırıs.TabStop = false;
            this.groupboxgırıs.Text = " Neşeli Restaurant";
            // 
            // ComboKullanıcı
            // 
            this.ComboKullanıcı.FormattingEnabled = true;
            this.ComboKullanıcı.Location = new System.Drawing.Point(388, 61);
            this.ComboKullanıcı.Name = "ComboKullanıcı";
            this.ComboKullanıcı.Size = new System.Drawing.Size(158, 34);
            this.ComboKullanıcı.TabIndex = 4;
            this.ComboKullanıcı.SelectedIndexChanged += new System.EventHandler(this.ComboKullanıcı_SelectedIndexChanged);
            // 
            // TxtSıfre
            // 
            this.TxtSıfre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSıfre.Location = new System.Drawing.Point(388, 138);
            this.TxtSıfre.Name = "TxtSıfre";
            this.TxtSıfre.PasswordChar = '*';
            this.TxtSıfre.Size = new System.Drawing.Size(158, 32);
            this.TxtSıfre.TabIndex = 3;
            // 
            // LblSıfre
            // 
            this.LblSıfre.AutoSize = true;
            this.LblSıfre.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSıfre.Location = new System.Drawing.Point(113, 138);
            this.LblSıfre.Name = "LblSıfre";
            this.LblSıfre.Size = new System.Drawing.Size(67, 28);
            this.LblSıfre.TabIndex = 1;
            this.LblSıfre.Text = "Şifre:";
            // 
            // LblKullanıcı
            // 
            this.LblKullanıcı.AutoSize = true;
            this.LblKullanıcı.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblKullanıcı.Location = new System.Drawing.Point(113, 59);
            this.LblKullanıcı.Name = "LblKullanıcı";
            this.LblKullanıcı.Size = new System.Drawing.Size(163, 28);
            this.LblKullanıcı.TabIndex = 0;
            this.LblKullanıcı.Text = "Kullanıcı Adı:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblHata);
            this.Controls.Add(this.BtnVazgec);
            this.Controls.Add(this.BtnGırıs);
            this.Controls.Add(this.groupboxgırıs);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupboxgırıs.ResumeLayout(false);
            this.groupboxgırıs.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblHata;
        private System.Windows.Forms.Button BtnVazgec;
        private System.Windows.Forms.Button BtnGırıs;
        private System.Windows.Forms.GroupBox groupboxgırıs;
        private System.Windows.Forms.TextBox TxtSıfre;
        private System.Windows.Forms.Label LblSıfre;
        private System.Windows.Forms.Label LblKullanıcı;
        private System.Windows.Forms.ComboBox ComboKullanıcı;
    }
}

