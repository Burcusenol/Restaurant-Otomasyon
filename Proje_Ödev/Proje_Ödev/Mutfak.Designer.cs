namespace Proje_Ödev
{
    partial class Mutfak
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
            this.listKategoriler = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listGıda = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BTnsil = new System.Windows.Forms.Button();
            this.BTnBul = new System.Windows.Forms.Button();
            this.BtnDeğiştir = new System.Windows.Forms.Button();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.panelürün = new System.Windows.Forms.Panel();
            this.TxtUrunId = new System.Windows.Forms.TextBox();
            this.TxtFiyat = new System.Windows.Forms.TextBox();
            this.TxtKategoriAd = new System.Windows.Forms.TextBox();
            this.CbKategoriler = new System.Windows.Forms.ComboBox();
            this.Lblfiyat = new System.Windows.Forms.Label();
            this.LblAd = new System.Windows.Forms.Label();
            this.LblKategori = new System.Windows.Forms.Label();
            this.panelanaKategori = new System.Windows.Forms.Panel();
            this.TxtKategoriId = new System.Windows.Forms.TextBox();
            this.TxtAcıklaması = new System.Windows.Forms.TextBox();
            this.TxtKategori = new System.Windows.Forms.TextBox();
            this.Lblaçıklama = new System.Windows.Forms.Label();
            this.LblKatAd = new System.Windows.Forms.Label();
            this.RdÜrünEkle = new System.Windows.Forms.RadioButton();
            this.RdKategori = new System.Windows.Forms.RadioButton();
            this.BtnÇıkış = new System.Windows.Forms.Button();
            this.button1Geri = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textbox1 = new System.Windows.Forms.TextBox();
            this.panelürün.SuspendLayout();
            this.panelanaKategori.SuspendLayout();
            this.SuspendLayout();
            // 
            // listKategoriler
            // 
            this.listKategoriler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader1,
            this.columnHeader2});
            this.listKategoriler.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listKategoriler.FullRowSelect = true;
            this.listKategoriler.GridLines = true;
            this.listKategoriler.HideSelection = false;
            this.listKategoriler.Location = new System.Drawing.Point(288, 349);
            this.listKategoriler.Name = "listKategoriler";
            this.listKategoriler.Size = new System.Drawing.Size(534, 217);
            this.listKategoriler.TabIndex = 1;
            this.listKategoriler.UseCompatibleStateImageBehavior = false;
            this.listKategoriler.View = System.Windows.Forms.View.Details;
            this.listKategoriler.SelectedIndexChanged += new System.EventHandler(this.listKategoriler_SelectedIndexChanged);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "TurId";
            this.columnHeader3.Width = 0;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Kategori";
            this.columnHeader1.Width = 156;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Açıklama";
            this.columnHeader2.Width = 176;
            // 
            // listGıda
            // 
            this.listGıda.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listGıda.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listGıda.FullRowSelect = true;
            this.listGıda.GridLines = true;
            this.listGıda.HideSelection = false;
            this.listGıda.Location = new System.Drawing.Point(300, 349);
            this.listGıda.Name = "listGıda";
            this.listGıda.Size = new System.Drawing.Size(522, 217);
            this.listGıda.TabIndex = 2;
            this.listGıda.UseCompatibleStateImageBehavior = false;
            this.listGıda.View = System.Windows.Forms.View.Details;
            this.listGıda.SelectedIndexChanged += new System.EventHandler(this.listGıda_SelectedIndexChanged);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ürün Id";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "ÜrünTürNo";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Kategori";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Ürün Adı";
            this.columnHeader7.Width = 200;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Fiyat";
            this.columnHeader8.Width = 135;
            // 
            // BTnsil
            // 
            this.BTnsil.BackColor = System.Drawing.Color.LightBlue;
            this.BTnsil.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTnsil.Location = new System.Drawing.Point(723, 270);
            this.BTnsil.Name = "BTnsil";
            this.BTnsil.Size = new System.Drawing.Size(115, 57);
            this.BTnsil.TabIndex = 4;
            this.BTnsil.Text = "Sil";
            this.BTnsil.UseVisualStyleBackColor = false;
            this.BTnsil.Click += new System.EventHandler(this.BTnsil_Click);
            // 
            // BTnBul
            // 
            this.BTnBul.BackColor = System.Drawing.Color.LightBlue;
            this.BTnBul.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTnBul.Location = new System.Drawing.Point(578, 270);
            this.BTnBul.Name = "BTnBul";
            this.BTnBul.Size = new System.Drawing.Size(115, 57);
            this.BTnBul.TabIndex = 5;
            this.BTnBul.Text = "Bul";
            this.BTnBul.UseVisualStyleBackColor = false;
            this.BTnBul.Click += new System.EventHandler(this.BTnBul_Click);
            // 
            // BtnDeğiştir
            // 
            this.BtnDeğiştir.BackColor = System.Drawing.Color.LightBlue;
            this.BtnDeğiştir.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnDeğiştir.Location = new System.Drawing.Point(433, 270);
            this.BtnDeğiştir.Name = "BtnDeğiştir";
            this.BtnDeğiştir.Size = new System.Drawing.Size(115, 57);
            this.BtnDeğiştir.TabIndex = 6;
            this.BtnDeğiştir.Text = "Değiştir";
            this.BtnDeğiştir.UseVisualStyleBackColor = false;
            this.BtnDeğiştir.Click += new System.EventHandler(this.BtnDeğiştir_Click);
            // 
            // BtnEkle
            // 
            this.BtnEkle.BackColor = System.Drawing.Color.LightBlue;
            this.BtnEkle.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnEkle.Location = new System.Drawing.Point(288, 270);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(115, 57);
            this.BtnEkle.TabIndex = 7;
            this.BtnEkle.Text = "Ekle";
            this.BtnEkle.UseVisualStyleBackColor = false;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // panelürün
            // 
            this.panelürün.Controls.Add(this.TxtUrunId);
            this.panelürün.Controls.Add(this.TxtFiyat);
            this.panelürün.Controls.Add(this.TxtKategoriAd);
            this.panelürün.Controls.Add(this.CbKategoriler);
            this.panelürün.Controls.Add(this.Lblfiyat);
            this.panelürün.Controls.Add(this.LblAd);
            this.panelürün.Controls.Add(this.LblKategori);
            this.panelürün.Location = new System.Drawing.Point(364, 44);
            this.panelürün.Name = "panelürün";
            this.panelürün.Size = new System.Drawing.Size(338, 166);
            this.panelürün.TabIndex = 8;
            // 
            // TxtUrunId
            // 
            this.TxtUrunId.Location = new System.Drawing.Point(298, 61);
            this.TxtUrunId.Name = "TxtUrunId";
            this.TxtUrunId.Size = new System.Drawing.Size(12, 22);
            this.TxtUrunId.TabIndex = 3;
            this.TxtUrunId.Visible = false;
            // 
            // TxtFiyat
            // 
            this.TxtFiyat.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtFiyat.Location = new System.Drawing.Point(170, 97);
            this.TxtFiyat.Name = "TxtFiyat";
            this.TxtFiyat.Size = new System.Drawing.Size(121, 30);
            this.TxtFiyat.TabIndex = 2;
            // 
            // TxtKategoriAd
            // 
            this.TxtKategoriAd.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtKategoriAd.Location = new System.Drawing.Point(170, 61);
            this.TxtKategoriAd.Name = "TxtKategoriAd";
            this.TxtKategoriAd.Size = new System.Drawing.Size(121, 30);
            this.TxtKategoriAd.TabIndex = 2;
            // 
            // CbKategoriler
            // 
            this.CbKategoriler.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CbKategoriler.FormattingEnabled = true;
            this.CbKategoriler.Location = new System.Drawing.Point(170, 23);
            this.CbKategoriler.Name = "CbKategoriler";
            this.CbKategoriler.Size = new System.Drawing.Size(121, 29);
            this.CbKategoriler.TabIndex = 1;
            this.CbKategoriler.SelectedIndexChanged += new System.EventHandler(this.CbKategoriler_SelectedIndexChanged);
            // 
            // Lblfiyat
            // 
            this.Lblfiyat.AutoSize = true;
            this.Lblfiyat.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lblfiyat.Location = new System.Drawing.Point(30, 97);
            this.Lblfiyat.Name = "Lblfiyat";
            this.Lblfiyat.Size = new System.Drawing.Size(57, 22);
            this.Lblfiyat.TabIndex = 0;
            this.Lblfiyat.Text = "Fiyat:";
            // 
            // LblAd
            // 
            this.LblAd.AutoSize = true;
            this.LblAd.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblAd.Location = new System.Drawing.Point(30, 62);
            this.LblAd.Name = "LblAd";
            this.LblAd.Size = new System.Drawing.Size(45, 22);
            this.LblAd.TabIndex = 0;
            this.LblAd.Text = "Adı:";
            // 
            // LblKategori
            // 
            this.LblKategori.AutoSize = true;
            this.LblKategori.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblKategori.Location = new System.Drawing.Point(30, 27);
            this.LblKategori.Name = "LblKategori";
            this.LblKategori.Size = new System.Drawing.Size(94, 22);
            this.LblKategori.TabIndex = 0;
            this.LblKategori.Text = "Kategori:";
            // 
            // panelanaKategori
            // 
            this.panelanaKategori.Controls.Add(this.TxtKategoriId);
            this.panelanaKategori.Controls.Add(this.TxtAcıklaması);
            this.panelanaKategori.Controls.Add(this.TxtKategori);
            this.panelanaKategori.Controls.Add(this.Lblaçıklama);
            this.panelanaKategori.Controls.Add(this.LblKatAd);
            this.panelanaKategori.Location = new System.Drawing.Point(376, 62);
            this.panelanaKategori.Name = "panelanaKategori";
            this.panelanaKategori.Size = new System.Drawing.Size(326, 127);
            this.panelanaKategori.TabIndex = 9;
            // 
            // TxtKategoriId
            // 
            this.TxtKategoriId.Location = new System.Drawing.Point(289, 45);
            this.TxtKategoriId.Name = "TxtKategoriId";
            this.TxtKategoriId.Size = new System.Drawing.Size(12, 22);
            this.TxtKategoriId.TabIndex = 4;
            this.TxtKategoriId.Visible = false;
            // 
            // TxtAcıklaması
            // 
            this.TxtAcıklaması.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAcıklaması.Location = new System.Drawing.Point(150, 62);
            this.TxtAcıklaması.Name = "TxtAcıklaması";
            this.TxtAcıklaması.Size = new System.Drawing.Size(121, 30);
            this.TxtAcıklaması.TabIndex = 3;
            // 
            // TxtKategori
            // 
            this.TxtKategori.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtKategori.Location = new System.Drawing.Point(150, 24);
            this.TxtKategori.Name = "TxtKategori";
            this.TxtKategori.Size = new System.Drawing.Size(121, 30);
            this.TxtKategori.TabIndex = 3;
            // 
            // Lblaçıklama
            // 
            this.Lblaçıklama.AutoSize = true;
            this.Lblaçıklama.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lblaçıklama.Location = new System.Drawing.Point(15, 62);
            this.Lblaçıklama.Name = "Lblaçıklama";
            this.Lblaçıklama.Size = new System.Drawing.Size(102, 22);
            this.Lblaçıklama.TabIndex = 1;
            this.Lblaçıklama.Text = "Açıklama:";
            // 
            // LblKatAd
            // 
            this.LblKatAd.AutoSize = true;
            this.LblKatAd.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblKatAd.Location = new System.Drawing.Point(15, 23);
            this.LblKatAd.Name = "LblKatAd";
            this.LblKatAd.Size = new System.Drawing.Size(129, 22);
            this.LblKatAd.TabIndex = 1;
            this.LblKatAd.Text = "Kategori Adı:";
            // 
            // RdÜrünEkle
            // 
            this.RdÜrünEkle.AutoSize = true;
            this.RdÜrünEkle.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RdÜrünEkle.Location = new System.Drawing.Point(376, 12);
            this.RdÜrünEkle.Name = "RdÜrünEkle";
            this.RdÜrünEkle.Size = new System.Drawing.Size(113, 26);
            this.RdÜrünEkle.TabIndex = 10;
            this.RdÜrünEkle.TabStop = true;
            this.RdÜrünEkle.Text = "Ürün Ekle";
            this.RdÜrünEkle.UseVisualStyleBackColor = true;
            this.RdÜrünEkle.CheckedChanged += new System.EventHandler(this.RdÜrünEkle_CheckedChanged);
            // 
            // RdKategori
            // 
            this.RdKategori.AutoSize = true;
            this.RdKategori.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RdKategori.Location = new System.Drawing.Point(551, 12);
            this.RdKategori.Name = "RdKategori";
            this.RdKategori.Size = new System.Drawing.Size(151, 26);
            this.RdKategori.TabIndex = 10;
            this.RdKategori.TabStop = true;
            this.RdKategori.Text = "Kategori Ekle";
            this.RdKategori.UseVisualStyleBackColor = true;
            this.RdKategori.CheckedChanged += new System.EventHandler(this.RdKategori_CheckedChanged);
            // 
            // BtnÇıkış
            // 
            this.BtnÇıkış.BackColor = System.Drawing.Color.LightBlue;
            this.BtnÇıkış.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnÇıkış.Location = new System.Drawing.Point(971, 474);
            this.BtnÇıkış.Name = "BtnÇıkış";
            this.BtnÇıkış.Size = new System.Drawing.Size(80, 52);
            this.BtnÇıkış.TabIndex = 17;
            this.BtnÇıkış.Text = "Çıkış";
            this.BtnÇıkış.UseVisualStyleBackColor = false;
            this.BtnÇıkış.Click += new System.EventHandler(this.BtnÇıkış_Click);
            // 
            // button1Geri
            // 
            this.button1Geri.BackColor = System.Drawing.Color.LightBlue;
            this.button1Geri.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1Geri.Location = new System.Drawing.Point(873, 474);
            this.button1Geri.Name = "button1Geri";
            this.button1Geri.Size = new System.Drawing.Size(80, 52);
            this.button1Geri.TabIndex = 16;
            this.button1Geri.Text = "Geri";
            this.button1Geri.UseVisualStyleBackColor = false;
            this.button1Geri.Click += new System.EventHandler(this.button1Geri_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(360, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 21);
            this.label1.TabIndex = 18;
            this.label1.Text = "Aramak İstediğiniz Ürün:";
            // 
            // textbox1
            // 
            this.textbox1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textbox1.Location = new System.Drawing.Point(619, 227);
            this.textbox1.Name = "textbox1";
            this.textbox1.Size = new System.Drawing.Size(157, 28);
            this.textbox1.TabIndex = 19;
            this.textbox1.TextChanged += new System.EventHandler(this.textbox1_TextChanged);
            // 
            // Mutfak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1082, 588);
            this.Controls.Add(this.textbox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnÇıkış);
            this.Controls.Add(this.button1Geri);
            this.Controls.Add(this.RdKategori);
            this.Controls.Add(this.listKategoriler);
            this.Controls.Add(this.RdÜrünEkle);
            this.Controls.Add(this.panelanaKategori);
            this.Controls.Add(this.panelürün);
            this.Controls.Add(this.BTnsil);
            this.Controls.Add(this.BTnBul);
            this.Controls.Add(this.BtnDeğiştir);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.listGıda);
            this.Name = "Mutfak";
            this.Text = "Mutfak";
            this.Load += new System.EventHandler(this.Mutfak_Load);
            this.panelürün.ResumeLayout(false);
            this.panelürün.PerformLayout();
            this.panelanaKategori.ResumeLayout(false);
            this.panelanaKategori.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listKategoriler;
        private System.Windows.Forms.ListView listGıda;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button BTnsil;
        private System.Windows.Forms.Button BTnBul;
        private System.Windows.Forms.Button BtnDeğiştir;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.Panel panelürün;
        private System.Windows.Forms.TextBox TxtUrunId;
        private System.Windows.Forms.TextBox TxtFiyat;
        private System.Windows.Forms.TextBox TxtKategoriAd;
        private System.Windows.Forms.ComboBox CbKategoriler;
        private System.Windows.Forms.Label Lblfiyat;
        private System.Windows.Forms.Label LblAd;
        private System.Windows.Forms.Label LblKategori;
        private System.Windows.Forms.Panel panelanaKategori;
        private System.Windows.Forms.TextBox TxtKategoriId;
        private System.Windows.Forms.TextBox TxtAcıklaması;
        private System.Windows.Forms.TextBox TxtKategori;
        private System.Windows.Forms.Label Lblaçıklama;
        private System.Windows.Forms.Label LblKatAd;
        private System.Windows.Forms.RadioButton RdÜrünEkle;
        private System.Windows.Forms.RadioButton RdKategori;
        private System.Windows.Forms.Button BtnÇıkış;
        private System.Windows.Forms.Button button1Geri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textbox1;
    }
}