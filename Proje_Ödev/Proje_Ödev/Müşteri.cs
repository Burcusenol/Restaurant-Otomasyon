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
    public partial class Müşteri : Form
    {
        public Müşteri()
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

        private void BtnYenimusteri_Click(object sender, EventArgs e)
        {
            MüşteriEkle form = new MüşteriEkle(); //Müşteri ekleme formuna yönlendirme
            Veritabanı._MüsteriEkle = 1;
            this.Hide();
            form.Show();
        }

        private void Müşteri_Load(object sender, EventArgs e)
        {
            Müşteriler m = new Müşteriler(); //Müşterileri listviewde göster 
            m.MüşteriListele(LstMusteri);
        }

        private void BtnMusteriSec_Click(object sender, EventArgs e)
        {
            
        }

        private void Kontrol()
        {

        }

        private void BtnMusteriGuncelle_Click(object sender, EventArgs e)
        {
            if (LstMusteri.SelectedItems.Count>0) //Müşteri güncelleme işlemi 
            {
              
                Veritabanı._MüsteriEkle = 1;
                Veritabanı._MüşteriId=Convert.ToInt32(LstMusteri.SelectedItems[0].SubItems[0].Text);
                MüşteriEkle form = new MüşteriEkle();
              
                this.Hide();
                form.Show();
            }
        }

        private void TxtMüsteriAdı_TextChanged(object sender, EventArgs e)
        {
            Müşteriler m = new Müşteriler(); //Müşteri adına göre arama
            m.MüşteriAdGetir(LstMusteri, TxtMüsteriAdı.Text);
        }

        private void Txtsoyad_TextChanged(object sender, EventArgs e)
        {
            Müşteriler m = new Müşteriler();  //Müşteri soyadına göre arama
            m.MüşteriSoyadGetir(LstMusteri, Txtsoyad.Text);
        }

        private void TxtTel_TextChanged(object sender, EventArgs e)
        {
            Müşteriler m = new Müşteriler();  //Müşteri telefonuna göre arama
            m.MüşteriTelefonGetir(LstMusteri, TxtTel.Text);
        }

        private void BtnAdisyonBul_Click(object sender, EventArgs e)
        {
            if(TxtAdisyonId.Text!="") //Adisyon bulma işlemi
            {
                Veritabanı._AdisyonId =TxtAdisyonId.Text;
                PaketServis paket = new PaketServis();
                bool sonuc = paket.AdisyonKontrolü(Convert.ToInt32(TxtAdisyonId.Text));
                if(sonuc)
                {
                    HesapÖdeme form = new HesapÖdeme();
                    Veritabanı._ServisTurNo = 2;
                    form.Show();

                }
                else
                {
                    MessageBox.Show(TxtAdisyonId.Text + "nolu  adisyon bulunamadı.");
                }
            }
            else
            {
                MessageBox.Show( " Aramak istediğiniz adisyonu giriniz.");
            }
        }
    }
}
