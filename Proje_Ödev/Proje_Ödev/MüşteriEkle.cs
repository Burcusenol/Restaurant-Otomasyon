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
    public partial class MüşteriEkle : Form
    {
        public MüşteriEkle()
        {
            InitializeComponent();
        }

        
        private void BtnMusteriSec_Click(object sender, EventArgs e)
        {

            if(Veritabanı._MüsteriEkle==0) //Müşteri ekle durumu 0 sa
            {
                Rezervasyon form = new Rezervasyon(); //Rezervasyon sayfasına yönlendir
                Veritabanı._MüsteriEkle = 1;
                this.Hide();
                form.Show();
            }
            
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            if (TxtTelefon.Text.Length > 6) //Müşteri güncelleme işlemi
            {
                if (TxtAd.Text == "" || TxtSoyad.Text == "")
                {
                    MessageBox.Show("Ad ve Soyad alanları boş geçilemez.");
                }
                else
                {
                    Müşteriler müşteri = new Müşteriler();
                    
                    müşteri.MüşteriAd = TxtAd.Text; //Müşteri bilgilerini veritabanına alma
                    müşteri.MüşteriSoyad = TxtSoyad.Text;
                    müşteri.Telefon = TxtTelefon.Text;
                    müşteri.Email = TxtMail.Text;
                    müşteri.Adres = TxtAdres.Text;
                    müşteri.MüşteriId = Convert.ToInt32(txtMüsteriNo.Text);
                    bool sonuc=müşteri.MüşteriGüncelle(müşteri);
                  

                    if (sonuc)
                    {
                        
                        if (txtMüsteriNo.Text != "")
                        {
                            MessageBox.Show("Müşteri bilgileri güncellendi.");
                        }
                        else
                        {
                            MessageBox.Show("Hata Oluştu.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Müşteri Mevcut.");
                    }
                   
                }
            }

            else
            {
                MessageBox.Show("7 haneli bir telefon numarası giriniz.");
            }
        }

        private void MüşteriEkle_Load(object sender, EventArgs e)
        {
            if(Veritabanı._MüşteriId>0) //Müşteri bilgilerini müşteri numarasına göre getir
            {
                Müşteriler m = new Müşteriler();
                txtMüsteriNo.Text = Veritabanı._MüşteriId.ToString();
                m.MüşteriGetir(Convert.ToInt32(txtMüsteriNo.Text), TxtAd, TxtSoyad, TxtTelefon, TxtAdres, TxtMail);

            }
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            AnaSayfa form = new AnaSayfa(); //Ana forma yönlendirme
            this.Hide();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Müşteri form = new Müşteri(); //Müşteri formuna yönlendirme
            this.Hide();
            form.Show();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            if (TxtTelefon.Text.Length > 6)  // Butonaa basıldığında müşteri ekleme işlemi 
            {
                if (TxtAd.Text == "" || TxtSoyad.Text == "")
                {
                    MessageBox.Show("Ad ve Soyad alanları boş geçilemez.");
                }
                else
                {
                    Müşteriler müşteri = new Müşteriler();
                    bool sonuc = müşteri.MüşteriAra(TxtTelefon.Text);
                    if(!sonuc)
                    {
                        müşteri.MüşteriAd = TxtAd.Text;
                        müşteri.MüşteriSoyad = TxtSoyad.Text;
                        müşteri.Telefon = TxtTelefon.Text;
                        müşteri.Email = TxtMail.Text;
                        müşteri.Adres = TxtAdres.Text;
                        txtMüsteriNo.Text = müşteri.MüşteriEkle(müşteri).ToString();
                        if(txtMüsteriNo.Text!="")
                        {
                            MessageBox.Show("Müşteri eklendi.");
                        }
                        else
                        {
                            MessageBox.Show("Hata Oluştu.");
                        }
                    }
                   
                  
                }
            }
            else
            {
                MessageBox.Show("7 haneli bir telefon numarası giriniz.");
            }
        }
    }
}
