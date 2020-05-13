namespace Proje_Ödev
{
    partial class HesapÖdeme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HesapÖdeme));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Chİndirim = new System.Windows.Forms.CheckBox();
            this.Gbindirim = new System.Windows.Forms.GroupBox();
            this.TxtTutar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RdKredi = new System.Windows.Forms.RadioButton();
            this.RdNakit = new System.Windows.Forms.RadioButton();
            this.listÜrünler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.LblToplamTutar = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.LblÖdenecek = new System.Windows.Forms.Label();
            this.LblKdv = new System.Windows.Forms.Label();
            this.Lblİndirim = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnÇıkış = new System.Windows.Forms.Button();
            this.button1Geri = new System.Windows.Forms.Button();
            this.LblAdisyonId = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.Gbindirim.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Chİndirim);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(38, 45);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(294, 148);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Özel İndirim";
            // 
            // Chİndirim
            // 
            this.Chİndirim.AutoSize = true;
            this.Chİndirim.Location = new System.Drawing.Point(19, 65);
            this.Chİndirim.Margin = new System.Windows.Forms.Padding(4);
            this.Chİndirim.Name = "Chİndirim";
            this.Chİndirim.Size = new System.Drawing.Size(159, 26);
            this.Chİndirim.TabIndex = 0;
            this.Chİndirim.Text = "İndirim Uygula";
            this.Chİndirim.UseVisualStyleBackColor = true;
            this.Chİndirim.CheckedChanged += new System.EventHandler(this.Chİndirim_CheckedChanged);
            // 
            // Gbindirim
            // 
            this.Gbindirim.Controls.Add(this.TxtTutar);
            this.Gbindirim.Controls.Add(this.label1);
            this.Gbindirim.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Gbindirim.Location = new System.Drawing.Point(744, 349);
            this.Gbindirim.Margin = new System.Windows.Forms.Padding(4);
            this.Gbindirim.Name = "Gbindirim";
            this.Gbindirim.Padding = new System.Windows.Forms.Padding(4);
            this.Gbindirim.Size = new System.Drawing.Size(294, 144);
            this.Gbindirim.TabIndex = 1;
            this.Gbindirim.TabStop = false;
            this.Gbindirim.Text = "Özel Aktivite";
            this.Gbindirim.Visible = false;
            // 
            // TxtTutar
            // 
            this.TxtTutar.Location = new System.Drawing.Point(15, 88);
            this.TxtTutar.Margin = new System.Windows.Forms.Padding(4);
            this.TxtTutar.Name = "TxtTutar";
            this.TxtTutar.Size = new System.Drawing.Size(252, 30);
            this.TxtTutar.TabIndex = 1;
            this.TxtTutar.TextChanged += new System.EventHandler(this.TxtTutar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "İndirim Tutarı Giriniz:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.RdKredi);
            this.groupBox3.Controls.Add(this.RdNakit);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(363, 49);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(294, 148);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ödeme Türü";
            // 
            // RdKredi
            // 
            this.RdKredi.AutoSize = true;
            this.RdKredi.Location = new System.Drawing.Point(32, 89);
            this.RdKredi.Margin = new System.Windows.Forms.Padding(4);
            this.RdKredi.Name = "RdKredi";
            this.RdKredi.Size = new System.Drawing.Size(123, 26);
            this.RdKredi.TabIndex = 1;
            this.RdKredi.TabStop = true;
            this.RdKredi.Text = "Kredi Kartı";
            this.RdKredi.UseVisualStyleBackColor = true;
            // 
            // RdNakit
            // 
            this.RdNakit.AutoSize = true;
            this.RdNakit.Location = new System.Drawing.Point(32, 39);
            this.RdNakit.Margin = new System.Windows.Forms.Padding(4);
            this.RdNakit.Name = "RdNakit";
            this.RdNakit.Size = new System.Drawing.Size(80, 26);
            this.RdNakit.TabIndex = 0;
            this.RdNakit.TabStop = true;
            this.RdNakit.Text = "Nakit";
            this.RdNakit.UseVisualStyleBackColor = true;
            // 
            // listÜrünler
            // 
            this.listÜrünler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listÜrünler.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listÜrünler.FullRowSelect = true;
            this.listÜrünler.GridLines = true;
            this.listÜrünler.HideSelection = false;
            this.listÜrünler.Location = new System.Drawing.Point(38, 233);
            this.listÜrünler.Margin = new System.Windows.Forms.Padding(4);
            this.listÜrünler.Name = "listÜrünler";
            this.listÜrünler.Size = new System.Drawing.Size(636, 279);
            this.listÜrünler.TabIndex = 4;
            this.listÜrünler.UseCompatibleStateImageBehavior = false;
            this.listÜrünler.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ürün Adı";
            this.columnHeader1.Width = 151;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Adet";
            this.columnHeader2.Width = 85;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ürün Id";
            this.columnHeader3.Width = 130;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Fiyat";
            this.columnHeader4.Width = 102;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Satış Id";
            this.columnHeader5.Width = 394;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.LblToplamTutar);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.LblÖdenecek);
            this.groupBox5.Controls.Add(this.LblKdv);
            this.groupBox5.Controls.Add(this.Lblİndirim);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox5.Location = new System.Drawing.Point(744, 49);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(294, 279);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Ödeme Bilgileri";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(228, 164);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(25, 22);
            this.label13.TabIndex = 0;
            this.label13.Text = "TL";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(228, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 22);
            this.label10.TabIndex = 0;
            this.label10.Text = "TL";
            // 
            // LblToplamTutar
            // 
            this.LblToplamTutar.AutoSize = true;
            this.LblToplamTutar.Location = new System.Drawing.Point(128, 161);
            this.LblToplamTutar.Name = "LblToplamTutar";
            this.LblToplamTutar.Size = new System.Drawing.Size(21, 22);
            this.LblToplamTutar.TabIndex = 0;
            this.LblToplamTutar.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 22);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ara Toplam";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "Fiyat";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(228, 221);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 22);
            this.label12.TabIndex = 0;
            this.label12.Text = "TL";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(228, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 22);
            this.label9.TabIndex = 0;
            this.label9.Text = "TL";
            // 
            // LblÖdenecek
            // 
            this.LblÖdenecek.AutoSize = true;
            this.LblÖdenecek.Location = new System.Drawing.Point(128, 221);
            this.LblÖdenecek.Name = "LblÖdenecek";
            this.LblÖdenecek.Size = new System.Drawing.Size(21, 22);
            this.LblÖdenecek.TabIndex = 0;
            this.LblÖdenecek.Text = "0";
            // 
            // LblKdv
            // 
            this.LblKdv.AutoSize = true;
            this.LblKdv.Location = new System.Drawing.Point(128, 101);
            this.LblKdv.Name = "LblKdv";
            this.LblKdv.Size = new System.Drawing.Size(21, 22);
            this.LblKdv.TabIndex = 0;
            this.LblKdv.Text = "0";
            // 
            // Lblİndirim
            // 
            this.Lblİndirim.AutoSize = true;
            this.Lblİndirim.Location = new System.Drawing.Point(128, 41);
            this.Lblİndirim.Name = "Lblİndirim";
            this.Lblİndirim.Size = new System.Drawing.Size(21, 22);
            this.Lblİndirim.TabIndex = 0;
            this.Lblİndirim.Text = "0";
            this.Lblİndirim.TextChanged += new System.EventHandler(this.Lblİndirim_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Kdv";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "İndirim";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightBlue;
            this.button1.Location = new System.Drawing.Point(736, 519);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 57);
            this.button1.TabIndex = 5;
            this.button1.Text = "Hesap Özeti";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightBlue;
            this.button2.Location = new System.Drawing.Point(918, 519);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 57);
            this.button2.TabIndex = 6;
            this.button2.Text = "Hesap Kapat";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnÇıkış
            // 
            this.BtnÇıkış.BackColor = System.Drawing.Color.LightBlue;
            this.BtnÇıkış.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnÇıkış.Location = new System.Drawing.Point(158, 540);
            this.BtnÇıkış.Name = "BtnÇıkış";
            this.BtnÇıkış.Size = new System.Drawing.Size(114, 52);
            this.BtnÇıkış.TabIndex = 13;
            this.BtnÇıkış.Text = "Çıkış";
            this.BtnÇıkış.UseVisualStyleBackColor = false;
            this.BtnÇıkış.Click += new System.EventHandler(this.BtnÇıkış_Click);
            // 
            // button1Geri
            // 
            this.button1Geri.BackColor = System.Drawing.Color.LightBlue;
            this.button1Geri.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1Geri.Location = new System.Drawing.Point(38, 540);
            this.button1Geri.Name = "button1Geri";
            this.button1Geri.Size = new System.Drawing.Size(114, 52);
            this.button1Geri.TabIndex = 12;
            this.button1Geri.Text = "Geri";
            this.button1Geri.UseVisualStyleBackColor = false;
            this.button1Geri.Click += new System.EventHandler(this.button1Geri_Click);
            // 
            // LblAdisyonId
            // 
            this.LblAdisyonId.AutoSize = true;
            this.LblAdisyonId.Location = new System.Drawing.Point(133, 207);
            this.LblAdisyonId.Name = "LblAdisyonId";
            this.LblAdisyonId.Size = new System.Drawing.Size(27, 22);
            this.LblAdisyonId.TabIndex = 14;
            this.LblAdisyonId.Text = "Id";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Text = "Baskı önizleme";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // HesapÖdeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1148, 604);
            this.Controls.Add(this.LblAdisyonId);
            this.Controls.Add(this.BtnÇıkış);
            this.Controls.Add(this.button1Geri);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listÜrünler);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.Gbindirim);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HesapÖdeme";
            this.Text = "HesapÖdeme";
            this.Load += new System.EventHandler(this.HesapÖdeme_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Gbindirim.ResumeLayout(false);
            this.Gbindirim.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox Chİndirim;
        private System.Windows.Forms.GroupBox Gbindirim;
        private System.Windows.Forms.TextBox TxtTutar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton RdKredi;
        private System.Windows.Forms.RadioButton RdNakit;
        private System.Windows.Forms.ListView listÜrünler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label LblToplamTutar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LblÖdenecek;
        private System.Windows.Forms.Label LblKdv;
        private System.Windows.Forms.Label Lblİndirim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnÇıkış;
        private System.Windows.Forms.Button button1Geri;
        private System.Windows.Forms.Label LblAdisyonId;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}