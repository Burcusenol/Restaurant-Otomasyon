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
    public partial class Mutfak : Form
    {
        public Mutfak()
        {
            InitializeComponent();
        }

        private void BtnÇıkış_Click(object sender, EventArgs e)
        {
            Close(); //Çıkış
        }

        private void button1Geri_Click(object sender, EventArgs e)
        {
            AnaSayfa form = new AnaSayfa(); //Ana forma yönlendirme
            this.Hide();
            form.Show();

        }

        private void Mutfak_Load(object sender, EventArgs e)
        {
            Ürünler Anakategori = new Ürünler();  //Ürünleri almak içinnesne oluşturma
            Anakategori.ÜrünÇeşitleriGetir(CbKategoriler);
            CbKategoriler.Items.Insert(0, "Tüm Kategoriler");
            CbKategoriler.SelectedIndex = 0;

            label1.Visible = false; //gizelencek nesneler
            textbox1.Visible = false;
            panelanaKategori.Visible = false;
            panelürün.Visible = false;

            ÜrünÇeşit çeşit = new ÜrünÇeşit();
            çeşit.ÜrünListele(listGıda);

        }

        private void Temizle()
        {
            TxtKategoriAd.Clear(); //kategori adını her zaman boş tut
            TxtFiyat.Clear();
            TxtFiyat.Text = string.Format("{0:##0.00}", 0);

        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            if (RdÜrünEkle.Checked) //Ürün ekle butonu seçiliyse
            {
                if (TxtKategoriAd.Text.Trim() == "" || TxtFiyat.Text.Trim() == "" || CbKategoriler.SelectedItem.ToString() == "Tüm Kategoriler")
                {
                    MessageBox.Show("Ad Fiyat ve Kategori Seçiniz.", "Dikkat,Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    ÜrünÇeşit çeşit = new ÜrünÇeşit(); //Ürünleri kaydet 
                    çeşit.Fiyat = Convert.ToDecimal(TxtFiyat.Text); 
                    çeşit.UrunAd = TxtKategoriAd.Text;
                    çeşit.Açıklama = "Ürün Eklendi";
                    çeşit.UrunTurNo = urunturno;
                    int sonuc = çeşit.ÜrünEkle(çeşit);

                    if (sonuc != 0)
                    {
                        MessageBox.Show("Ürün Eklendi.");
                        Yenile();
                        Temizle();
                    }
                }
            }
            else
            {
                if (TxtKategori.Text.Trim() == "") //Kategori ekle butonu seçiliyse
                {
                    MessageBox.Show(" Kategori ismi giriniz.", "Dikkat,Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Ürünler ürün = new Ürünler(); //Kategori ekle
                    ürün.TurAd = TxtKategori.Text;
                    ürün.Açıklama = TxtAcıklaması.Text;
                    int sonuc = ürün.ÜrünEkle(ürün);
                    if (sonuc != 0)
                    {
                        MessageBox.Show("Kategori Eklendi.");
                        Yenile();
                        Temizle();
                    }
                }
            }
        }

        int urunturno = 0;
        private void CbKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            ÜrünÇeşit çeşit = new ÜrünÇeşit();
            if (CbKategoriler.SelectedItem.ToString() == "Tüm Kategoriler") //Ürün combobox
            {
                çeşit.ÜrünListele(listGıda); //Tüm ürünleri listele
            }
            else
            {
                Ürünler ürün = (Ürünler)CbKategoriler.SelectedItem; //Seçili ürünü comboboxa getirme
                urunturno = ürün.UrunTurId;
                çeşit.ÜrünIdGöreListele(listGıda, urunturno);
            }
        }

        private void BtnDeğiştir_Click(object sender, EventArgs e)
        {
            if (RdÜrünEkle.Checked) //Ürün bilgisi değiştirme işlemi
            {
                if (TxtKategoriAd.Text.Trim() == "" || TxtFiyat.Text.Trim() == "" || CbKategoriler.SelectedItem.ToString() == "Tüm Kategoriler")
                {
                    MessageBox.Show("Ad Fiyat ve Kategori Seçiniz.", "Dikkat,Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    ÜrünÇeşit çeşit = new ÜrünÇeşit();
                    çeşit.Fiyat = Convert.ToDecimal(TxtFiyat.Text);
                    çeşit.UrunAd = TxtKategoriAd.Text;
                    çeşit.ÜrünId = Convert.ToInt32(TxtUrunId.Text);
                    çeşit.UrunTurNo = urunturno;
                    çeşit.Açıklama = "Ürün Güncellendi";
                    int sonuc = çeşit.ÜrünGüncelle(çeşit);

                    if (sonuc != 0)
                    {
                        MessageBox.Show("Ürün güncellenmiştir."); 
                        Yenile();
                        Temizle();
                    }
                }
            }
            else
            {
                if (TxtKategoriId.Text.Trim() == "") //Kategori bilgisi değiştirme
                {
                    MessageBox.Show(" Kategori seçiniz.", "Dikkat,Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Ürünler ürün = new Ürünler();
                    ürün.TurAd = TxtKategori.Text;
                    ürün.Açıklama = TxtAcıklaması.Text;
                    ürün.UrunTurId = Convert.ToInt32(TxtKategoriId.Text);
                    int sonuc = ürün.ÜrünGüncelle(ürün);
                    if (sonuc != 0)
                    {
                        MessageBox.Show("Kategori güncellenmiştir.");
                        ürün.ÜrünÇeşitleriGetir(listKategoriler);
                        Temizle();
                    }
                }
            }
        }

        private void listGıda_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listGıda.SelectedItems.Count > 0) //Ürün listvievında gösterme
            {
                TxtKategoriAd.Text = listGıda.SelectedItems[0].SubItems[3].Text;
                TxtFiyat.Text = listGıda.SelectedItems[0].SubItems[4].Text;
                TxtUrunId.Text = listGıda.SelectedItems[0].SubItems[0].Text;
             
            }
        }

        private void listKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listKategoriler.SelectedItems.Count > 0) //Kategori listviewında gösterme
            {
                TxtKategori.Text = listKategoriler.SelectedItems[0].SubItems[1].Text;
                TxtKategoriId.Text = listKategoriler.SelectedItems[0].SubItems[0].Text;
                TxtAcıklaması.Text = listKategoriler.SelectedItems[0].SubItems[2].Text;
                
            }
        }

        private void BTnsil_Click(object sender, EventArgs e)
        {
            if (RdÜrünEkle.Checked) //Ürün silme işlemi 
            {
                if (listGıda.SelectedItems.Count > 0)
                {
                    if (MessageBox.Show("Ürünü silmekte emin misiniz?", "Dikkat,Bilgiler Silinecek", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {

                        ÜrünÇeşit çeşit = new ÜrünÇeşit();
                        çeşit.ÜrünId = Convert.ToInt32(TxtUrunId.Text);
                        int sonuc = çeşit.ÜrünSil(çeşit,1);

                        if (sonuc != 0)
                        {
                            MessageBox.Show("Ürün silindi.");
                            CbKategoriler_SelectedIndexChanged(sender, e);
                            Yenile();
                            Temizle();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Ürünü seçiniz", "Dikkat,Ürün seçilmedi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (listKategoriler.SelectedItems.Count > 0) //Kategori silme işlemi
                {

                    if (MessageBox.Show("Kategoriyi silmekte emin misiniz?", "Dikkat,Eksik Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {

                        Ürünler ürün = new Ürünler();
                        int sonuc = ürün.ÜrünKategoriSil(Convert.ToInt32(TxtKategoriId.Text));

                        if (sonuc != 0)
                        {
                            MessageBox.Show("Kategori silindi.");
                            ÜrünÇeşit çeşit = new ÜrünÇeşit();
                            çeşit.ÜrünId = Convert.ToInt32(TxtKategoriId.Text);
                            çeşit.ÜrünSil(çeşit, 0);
                            Yenile();
                            Temizle();
                        }
                    }
                }
            }


        }

        private void BTnBul_Click(object sender, EventArgs e)
        {
            label1.Visible = true; //Ürün veya kategori bul
            textbox1.Visible = true;
        }

        private void textbox1_TextChanged(object sender, EventArgs e)
        {
            if(RdÜrünEkle.Checked) //Ürün listesini listviewe alma
            {
                ÜrünÇeşit çeşit = new ÜrünÇeşit();
                çeşit.ÜrünAdınaGöreListele(listGıda, textbox1.Text);
            }
            else
            {
                Ürünler ürün = new Ürünler(); //Kategori listesini listviewa alma
                ürün.ÜrünÇeşitleriGetir(listKategoriler, textbox1.Text);
            }
        }

        private void RdÜrünEkle_CheckedChanged(object sender, EventArgs e)
        {
            panelürün.Visible = true; //butona basıldığında yapılacak işlemler
            panelanaKategori.Visible = false;
            listKategoriler.Visible = false;
            listGıda.Visible = true;
            Yenile();
        }

        private void RdKategori_CheckedChanged(object sender, EventArgs e)
        {
            panelürün.Visible = false; //Butona basıldığında yapılacak işlemler
            panelanaKategori.Visible = true;
            listKategoriler.Visible = true;
            listGıda.Visible = false;
            Yenile();
        }

        private void Yenile()
        {
            Ürünler ürün = new Ürünler();  //Ürü ve kategori listview 
            ürün.ÜrünÇeşitleriGetir(CbKategoriler);
            ürün.ÜrünÇeşitleriGetir(listKategoriler);
            ÜrünÇeşit çeşit = new ÜrünÇeşit();
            çeşit.ÜrünListele(listGıda);
        }
    }
}
