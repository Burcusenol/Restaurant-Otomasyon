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
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Ödev
{
    public partial class Sipariş : Form
    {
        public Sipariş()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnÇıkış_Click(object sender, EventArgs e)
        {
            Close(); //Çıkış
        }

        private void button1Geri_Click(object sender, EventArgs e)
        {
            Masa form = new Masa(); //Masa formuna yönlendirme
            this.Hide();
            form.Show();
        }

        void HesapIslemi(object sender, EventArgs e)  //Hesap makinesi
        {
            Button buton = sender as Button;
            switch (buton.Name)
            {
                case "Btn0":
                    TxtAdet.Text += (0).ToString();
                    break;
                case "Btn1":
                    TxtAdet.Text += (1).ToString();
                    break;
                case "Btn2":
                    TxtAdet.Text += (2).ToString();
                    break;
                case "Btn3":
                    TxtAdet.Text += (3).ToString();
                    break;
                case "Btn4":
                    TxtAdet.Text += (4).ToString();
                    break;
                case "Btn5":
                    TxtAdet.Text += (5).ToString();
                    break;
                case "Btn6":
                    TxtAdet.Text += (6).ToString();
                    break;
                case "Btn7":
                    TxtAdet.Text += (7).ToString();
                    break;
                case "Btn8":
                    TxtAdet.Text += (8).ToString();
                    break;
                case "Btn9":
                    TxtAdet.Text += (9).ToString();
                    break;
                default:
                    MessageBox.Show("Sayı Girmediniz!");
                    break;
            }
        }
        int tabloId; int AdisyonId;
        private void Sipariş_Load(object sender, EventArgs e) //sipariş alma 
        {
            LabelMasa.Text = Veritabanı._ButtonDeğer;  
            Masalar masa = new Masalar();
            tabloId = masa.TabloNumarası(Veritabanı._Buttonİsim);
            if (masa.TabloDurumu(tabloId, 2) == true || masa.TabloDurumu(tabloId, 4) == true)//Masa durumu 2 veya 4se
            {
                Adisyon adisyon = new Adisyon(); //adisyon ekle 
                AdisyonId = adisyon.Adisyonİslem(tabloId);
                Siparişler sipariş = new Siparişler();
                sipariş.SiparisleriGetir(listSipariş, AdisyonId); //siparişleri listvieve ekle
            }

            Btn0.Click += new EventHandler(HesapIslemi);
            Btn1.Click += new EventHandler(HesapIslemi);
            Btn2.Click += new EventHandler(HesapIslemi);
            Btn3.Click += new EventHandler(HesapIslemi);
            Btn4.Click += new EventHandler(HesapIslemi);
            Btn5.Click += new EventHandler(HesapIslemi);
            Btn6.Click += new EventHandler(HesapIslemi);
            Btn7.Click += new EventHandler(HesapIslemi);
            Btn8.Click += new EventHandler(HesapIslemi);
            Btn9.Click += new EventHandler(HesapIslemi);
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            TxtAdet.Clear();
        }

        Ürünler ürün = new Ürünler();
        private void BtnAnayemek1_Click(object sender, EventArgs e)
        {


            ürün.ÜrünBilgileri(listMenu, BtnAnayemek1); // Butona basıldığında listviewe ürün bilgisi getirme

        }

        private void BtnIcecek2_Click(object sender, EventArgs e)
        {
            ürün.ÜrünBilgileri(listMenu, BtnIcecek2); //Butona basıldığında listviewe ürün bilgisi getirme
        }

        private void BtnÇorba4_Click(object sender, EventArgs e)
        {
            ürün.ÜrünBilgileri(listMenu, BtnÇorba4);   //Butona basıldığında listviewe ürün bilgisi getirme
        }

        private void BtnTatlı3_Click(object sender, EventArgs e)
        {
            ürün.ÜrünBilgileri(listMenu, BtnTatlı3);   //Butona basıldığında listviewe ürün bilgisi getirme
        }

        private void BtnFast6_Click(object sender, EventArgs e)
        {
            ürün.ÜrünBilgileri(listMenu, BtnFast6);   //Butona basıldığında listviewe ürün bilgisi getirme
        }

        private void BtnSalata5_Click(object sender, EventArgs e)
        {
            ürün.ÜrünBilgileri(listMenu, BtnSalata5);  //Butona basıldığında listviewe ürün bilgisi getirme
        }

        int sayac = 0; int sayac2 = 0;
        private void listMenu_DoubleClick(object sender, EventArgs e)
        {
            if (TxtAdet.Text == "")  //Adet girilmediyse 1 kabul et
            {
                TxtAdet.Text = "1";
            }
            if (listMenu.Items.Count > 0) //Listviewde ürün varsa
            {
                sayac = listSipariş.Items.Count; //görüntüle
                listSipariş.Items.Add(listMenu.SelectedItems[0].Text);
                listSipariş.Items[sayac].SubItems.Add(TxtAdet.Text);
                listSipariş.Items[sayac].SubItems.Add(listMenu.SelectedItems[0].SubItems[2].Text);
                listSipariş.Items[sayac].SubItems.Add((Convert.ToDecimal(listMenu.SelectedItems[0].SubItems[1].Text) * Convert.ToDecimal(TxtAdet.Text)).ToString());
                listSipariş.Items[sayac].SubItems.Add("0");

                listSipariş.Items[sayac].SubItems.Add(TxtAdet.Text);
                sayac2 = ListEklenenler.Items.Count;
                listSipariş.Items[sayac].SubItems.Add(sayac2.ToString());

                ListEklenenler.Items.Add(AdisyonId.ToString()); //Yeni eklenelere bilgileri al
                ListEklenenler.Items[sayac2].SubItems.Add(listMenu.SelectedItems[0].SubItems[2].Text);
                ListEklenenler.Items[sayac2].SubItems.Add(TxtAdet.Text);
                ListEklenenler.Items[sayac2].SubItems.Add(tabloId.ToString());
                ListEklenenler.Items[sayac2].SubItems.Add(sayac2.ToString());

                sayac2++;
                TxtAdet.Text = "";
            }
        }

        ArrayList silinenler = new ArrayList();
        private void BtnSiparis_Click(object sender, EventArgs e)
        {
            Masa geri = new Masa();
            Masalar masa = new Masalar();
            Adisyon yeni = new Adisyon();
            Siparişler siparis = new Siparişler();
            bool sonuc = false;
            if (masa.TabloDurumu(tabloId, 1) == true) //Masa boşsa
            {
                Veritabanı._ServisTurNo = 1; //Servis türünü belirle bilgileri al
                yeni.ServisTurno = 1;
                yeni.PersonelId = 1;
                yeni.MasaId = tabloId;
                yeni.Tarih = DateTime.Now;
                sonuc = yeni.Adisyonlar(yeni);
                masa.TabloGüncelleme(Veritabanı._Buttonİsim, 2);

                if (listSipariş.Items.Count > 0) //sipariş verildiyse 
                {
                    for (int i = 0; i < listSipariş.Items.Count; i++) //sipariş listviewında göster
                    {
                        siparis.MasaId = tabloId;
                        siparis.UrunId = Convert.ToInt32(listSipariş.Items[i].SubItems[2].Text);
                        siparis.AdisyonId = yeni.Adisyonİslem(tabloId);
                        siparis.Adet = Convert.ToInt32(listSipariş.Items[i].SubItems[1].Text);
                        siparis.SiparisKaydet(siparis);
                    }
                    this.Close();
                    geri.Show();
                }
            }
            else if (masa.TabloDurumu(tabloId, 2) == true || masa.TabloDurumu(tabloId, 4) == true) //Masa durumu 2 veya 4se
            {
                //Yeni eklenenlere ekle sipariş tablosunu boş bırak
                if (ListEklenenler.Items.Count > 0)
                {
                    for (int i = 0; i < ListEklenenler.Items.Count; i++)
                    {
                        siparis.MasaId = tabloId;
                        siparis.UrunId = Convert.ToInt32(ListEklenenler.Items[i].SubItems[1].Text);
                        siparis.AdisyonId = yeni.Adisyonİslem(tabloId);
                        siparis.Adet = Convert.ToInt32(ListEklenenler.Items[i].SubItems[2].Text);
                        siparis.SiparisKaydet(siparis);
                    }

                }
                if (silinenler.Count > 0)
                {
                    foreach (string item in silinenler)
                    {
                        siparis.SiparisSil(Convert.ToInt32(item));
                    }
                }
                this.Close();
                geri.Show();

            }
           
            else if (masa.TabloDurumu(tabloId, 3) == true) //Masa durumu 3se
            {

                yeni.ServisTurno = 1;
                yeni.PersonelId = 1;
                yeni.MasaId = tabloId;
                yeni.Tarih = DateTime.Now;
                sonuc = yeni.Adisyonlar(yeni);
                masa.TabloGüncelleme(Veritabanı._Buttonİsim, 4);

                if (listSipariş.Items.Count > 0) //sipariş listesini oluştur
                {
                    for (int i = 0; i < listSipariş.Items.Count; i++)
                    {
                        siparis.MasaId = tabloId;
                        siparis.UrunId = Convert.ToInt32(listSipariş.Items[i].SubItems[2].Text);
                        siparis.AdisyonId = yeni.Adisyonİslem(tabloId);
                        siparis.Adet = Convert.ToInt32(listSipariş.Items[i].SubItems[1].Text);
                        siparis.SiparisKaydet(siparis);
                    }
                    this.Close();
                    geri.Show();
                }
                
            }
        }
        
        private void listSipariş_DoubleClick(object sender, EventArgs e)
        {
            if (listSipariş.Items.Count > 0) //sipariş tablosunda ürün varsa ürüne tıkladığında sil
            {
                if (listSipariş.SelectedItems[0].SubItems[4].Text != "0")
                {
                    Siparişler siparis = new Siparişler();
                    siparis.SiparisSil(Convert.ToInt32(listSipariş.SelectedItems[0].SubItems[4].Text));
                }
                else
                {
                    for (int i = 0; i < ListEklenenler.Items.Count; i++)
                    {
                        if (ListEklenenler.Items[i].SubItems[4].Text == listSipariş.SelectedItems[0].SubItems[5].Text)
                        {
                            ListEklenenler.Items.RemoveAt(i);
                        }
                    }
                }
                listSipariş.Items.RemoveAt(listSipariş.SelectedItems[0].Index);
            }
        }

        private void TxtAra_TextChanged(object sender, EventArgs e)
        {
            if(TxtAra.Text=="")
            {
                TxtAra.Text = "";
            }
            else
            {
                Ürünler ürün = new Ürünler();
                ürün.ÜrünArama(listMenu, Convert.ToInt32(TxtAra.Text)); //Ürün arama işlemi
            }
            
        }

        private void BtnÖdeme_Click(object sender, EventArgs e)
        {

            Veritabanı._ServisTurNo = 1; // Adsisyon bilgisiyle birlikte öeldeme ekranına yönlendir 
            Veritabanı._AdisyonId = AdisyonId.ToString();
            HesapÖdeme form = new HesapÖdeme();
            this.Hide();
            form.Show();
        }
    }
}
