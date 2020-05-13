/************************************************************
|              SAKARYA ÜNİVERSİTESİ                         |
|       BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ           |
|            BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ                |
|                  2019-2020 BAHAR DÖNEMİ                   |
|            NESNEYE DAYALI PROGRAMLAMA ÖDEVİ               |
|                                                           |
|                                                           |
|                                                           |
|  Ödev Numarası:2                                          | 
|  Öğrenci Numarası:161200041                               |
|  Öğrenci Adı-Soyadı:Burcu ŞENOL                           |
|  Dersin Alındığı Grup:A                                   |
|                                                           |
************************************************************/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Ödev
{
    public partial class HesapÖdeme : Form
    {
        public HesapÖdeme()
        {
            InitializeComponent();
        }

        private void button1Geri_Click(object sender, EventArgs e)
        {
            AnaSayfa from = new AnaSayfa(); // Ana forma yönlendirme
            this.Hide();
            from.Show();
        }

        private void BtnÇıkış_Click(object sender, EventArgs e)
        {
            Close(); //Çıkış
        }

        Siparişler sipariş = new Siparişler();
        int odemeTurId = 0;
        private void HesapÖdeme_Load(object sender, EventArgs e)
        {
            Gbindirim.Visible = false;
            if(Veritabanı._ServisTurNo==1) //Eğer serevis türü masaysa işlem yap  
            {
                LblAdisyonId.Text = Veritabanı._AdisyonId;
                TxtTutar.TextChanged += new EventHandler(TxtTutar_TextChanged);
                sipariş.SiparisleriGetir(listÜrünler, Convert.ToInt32(LblAdisyonId.Text));
                if(listÜrünler.Items.Count>0)
                {
                    decimal toplam = 0;

                    for(int i=0;i< listÜrünler.Items.Count ;i++)
                    {
                        toplam += Convert.ToDecimal(listÜrünler.Items[i].SubItems[3].Text);
                    }
                    LblToplamTutar.Text = string.Format("{0:0.000}", toplam);
                    LblÖdenecek.Text = string.Format("{0:0.000}", toplam);
                    decimal kdv = Convert.ToDecimal(LblÖdenecek.Text) * 18 / 100;
                    LblKdv.Text = string.Format("{0:0.000}", kdv);

                }
                Gbindirim.Visible = true;
                TxtTutar.Clear();
            }
            else if(Veritabanı._ServisTurNo == 2) //Paket servisse 
            {
                LblAdisyonId.Text = Veritabanı._AdisyonId;
                PaketServis paket = new PaketServis();
                odemeTurId = paket.ÖdemeTürüGetir(Convert.ToInt32(LblAdisyonId.Text));
                TxtTutar.TextChanged += new EventHandler(TxtTutar_TextChanged);
                sipariş.SiparisleriGetir(listÜrünler, Convert.ToInt32(LblAdisyonId.Text));

                if(odemeTurId==1) //Ödeme türü nakitse
                {
                    RdNakit.Checked = true;
                }
                else if(odemeTurId == 2) //Kredi kartıysa
                {
                    RdKredi.Checked = true;
                }

                if (listÜrünler.Items.Count > 0)
                {
                    decimal toplam = 0;

                    for (int i = 0; i < listÜrünler.Items.Count; i++)
                    {
                        toplam += Convert.ToDecimal(listÜrünler.Items[i].SubItems[3].Text);

                    }
                    LblToplamTutar.Text = string.Format("{0:0.000}", toplam);
                    LblÖdenecek.Text = string.Format("{0:0.000}", toplam);
                    decimal kdv = Convert.ToDecimal(LblÖdenecek.Text) * 18 / 100;
                    LblKdv.Text = string.Format("{0:0.000}", kdv);

                }
                Gbindirim.Visible = true;
                TxtTutar.Clear();
            }
        }

        //Toplam tutar hesaplama
        private void TxtTutar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(Convert.ToDecimal(TxtTutar.Text)< Convert.ToDecimal(LblToplamTutar.Text))
                {
                    try
                    {
                        Lblİndirim.Text = string.Format("{0:0.000}", Convert.ToDecimal(TxtTutar.Text));
                    }
                    catch
                    {
                        Lblİndirim.Text = string.Format("{0:0.000}", 0);
                    }
                }
                else
                {
                    MessageBox.Show("İndirim toplam tutardan fazla olamaz.");
                }
            }
            catch
            {
                Lblİndirim.Text = string.Format("{0:0.000}", 0);
            }
        }

        private void Chİndirim_CheckedChanged(object sender, EventArgs e)
        {
            if(Chİndirim.Checked) //İndirim seçiliyse
            {
                Gbindirim.Visible = true;
                TxtTutar.Clear();
            }
            else
            {
                Gbindirim.Visible = false; //Değise
                TxtTutar.Clear();
            }
        }

        private void Lblİndirim_TextChanged(object sender, EventArgs e)
        {
            if(Convert.ToDecimal(Lblİndirim.Text)>0) //İndirim yapılacaksa hesabı bu şekide hesapla
            {
                decimal odenecek = 0;
                LblÖdenecek.Text = LblToplamTutar.Text;
                odenecek = Convert.ToDecimal(LblÖdenecek.Text) - Convert.ToDecimal(Lblİndirim.Text);
                LblÖdenecek.Text = string.Format("{0:0.000}", odenecek);
            }
            decimal kdv = Convert.ToDecimal(LblÖdenecek.Text)*18/100;
            LblKdv.Text = string.Format("{0:0.000}", kdv);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Masalar masa = new Masalar();
            Rezervasyonİşlemleri rezerve = new Rezervasyonİşlemleri();
            if(Veritabanı._ServisTurNo==1) //Masaysa
            {
                int MasaId = masa.TabloNumarası(Veritabanı._Buttonİsim);
                int MüşteriId = 0;
                if(masa.TabloDurumu(MasaId,4)==true) //Açık rezerveyse
                {
                    MüşteriId = rezerve.MüşteriRezervasyon(MasaId);
                }
                else
                {
                    MüşteriId = 1;
                }
                int odemeTurId = 0;
                if(RdNakit.Checked==true) //Nakitse
                {
                    odemeTurId=1;
                }
                else if(RdKredi.Checked==true)//Kredi kartıysa
                {
                    odemeTurId = 2;
                }

                Ödeme ödeme = new Ödeme();
                ödeme.AdisyonId= Convert.ToInt32(LblAdisyonId.Text);
                ödeme.OdemeTurId= odemeTurId;
                ödeme.MüşteriId = MüşteriId;
                ödeme.AraToplam = Convert.ToDecimal(LblÖdenecek.Text);
                ödeme.KdvTutarı = Convert.ToDecimal(LblKdv.Text);
                ödeme.GenelToplam = Convert.ToDecimal(LblToplamTutar.Text);
                ödeme.Indırım = Convert.ToDecimal(Lblİndirim.Text);

                bool result = ödeme.HesapKapatma(ödeme);
                if(result==true) //işlem yapıldıysa hesabı kapat, masa durumunu değiştir
                {
                    MessageBox.Show("İşlem yapıldı.");
                    masa.TabloGüncelleme(Convert.ToString(MasaId), 1);
                    rezerve.RezervasyonKapatma(Convert.ToInt32(LblAdisyonId.Text));

                    Adisyon adisyon = new Adisyon();
                    adisyon.AdisyonKapatma(Convert.ToInt32(LblAdisyonId.Text), 0);

                    this.Hide();
                    Masa form = new Masa();
                    form.Show();
                }
                else
                {
                    MessageBox.Show("Hata oluştu.");
                }


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog(); //Hesap özeti çıkarma
           
        }

        Font Baslık = new Font("Centory Gothic", 15, FontStyle.Italic);
        Font Altbaşlık = new Font("Centory Gothic", 11, FontStyle.Italic);
        Font hesap = new Font("Centory Gothic", 10);
        SolidBrush solid = new SolidBrush(Color.Blue);
       
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            StringFormat st = new StringFormat();
            st.Alignment = StringAlignment.Near;
            e.Graphics.DrawString("Neşeli Restaurant", Baslık, solid, 350, 100, st);
            e.Graphics.DrawString("******************************", Altbaşlık, solid, 350, 120, st);
            e.Graphics.DrawString("Ürün Adı                            Adet           Fiyat", Altbaşlık, solid, 150, 250, st);
            e.Graphics.DrawString("************************************************************", Altbaşlık, solid, 150, 280, st);

            for (int i = 0; i < listÜrünler.Items.Count; i++)
            {
                e.Graphics.DrawString(listÜrünler.Items[i].SubItems[0].Text, hesap, solid, 150, 300 + i * 30, st);
                e.Graphics.DrawString(listÜrünler.Items[i].SubItems[1].Text, hesap, solid, 350, 300 + i * 30, st);
                e.Graphics.DrawString(listÜrünler.Items[i].SubItems[3].Text, hesap, solid, 420, 300 + i * 30, st);
            }
            e.Graphics.DrawString("************************************************************", Altbaşlık, solid, 150, 300 + 30 * listÜrünler.Items.Count, st);
            e.Graphics.DrawString("İndirim Tutarı:                    " + Lblİndirim.Text + "TL", Altbaşlık, solid, 250, 300 + 30 * (listÜrünler.Items.Count + 1), st);
            e.Graphics.DrawString("Kdv Tutarı:                        " + LblKdv.Text + "TL", Altbaşlık, solid, 250, 300 + 30 * (listÜrünler.Items.Count + 2), st);
            e.Graphics.DrawString("Toplam Tutar:                   " + LblToplamTutar.Text + "TL", Altbaşlık, solid, 250, 300 + 30 * (listÜrünler.Items.Count + 3), st);
            e.Graphics.DrawString("Ödenen Tutar:                   " + LblÖdenecek.Text + "TL", Altbaşlık, solid, 250, 300 + 30 * (listÜrünler.Items.Count + 4), st);
        }
    }
}
