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
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            LblHata.Hide();
        }

        private void BtnGırıs_Click(object sender, EventArgs e)
        {
            Veritabanı veri = new Veritabanı();
            Personel p = new Personel(); //Personel nesnesi oluşturma
            bool result = p.PersonelEntryControl(TxtSıfre.Text,Veritabanı._PersonelId);

            if(result) //eğer personel doğru giriş yaptıysa sonuç dönder
            {
                Personelİşlemleri pi = new Personelİşlemleri();
                pi.PersonelId = Veritabanı._PersonelId;
                pi.İslem = "Giriş Yaptı.";
                pi.Tarih = DateTime.Now;
                pi.Hareket(pi);

                this.Hide();
                AnaSayfa form = new AnaSayfa();
                form.Show();
            }
            else
            {
                LblHata.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Personel p = new Personel();
            p.BilgileriGöster(ComboKullanıcı); //Giriş sayfasında personel bilgisini comboboxta gösterme
        }

        private void ComboKullanıcı_SelectedIndexChanged(object sender, EventArgs e)
        {
            Personel p = (Personel)ComboKullanıcı.SelectedItem; //kullanıcı seçim yaptıysa personel sınıfına bilgilerini ata
            Veritabanı._PersonelId = p.PersonelId;
            Veritabanı._GörevId = p.PersonelGorevId;

        }

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
