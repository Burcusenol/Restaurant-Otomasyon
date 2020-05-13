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
    public partial class Ayarlar : Form
    {
        public Ayarlar()
        {
            InitializeComponent();
        }

        private void button1Geri_Click(object sender, EventArgs e)
        {
            AnaSayfa form = new AnaSayfa(); //Ana forma yönlendirme
            this.Hide();
            form.Show();
        }

        private void BtnÇıkış_Click(object sender, EventArgs e)
        {
            Close(); //Çıkış
        }

        private void Ayarlar_Load(object sender, EventArgs e)
        {
            //Girş yapan müdürse ona göre işlemlere izin ver
            Personel personel=new Personel();
            PersonelGörev görev = new PersonelGörev();
            string gorev = görev.PersonelGörevTanım(Veritabanı._GörevId);
            if(gorev=="Müdür")
            {
                personel.BilgileriGöster(Cbpersonel);
                görev.PersonelGörevGetir(CbGorev);
                personel.PersonelBigileriGetir(listPersonel);
                BtnYeni.Enabled = true;
                BtnSil.Enabled = false;
                BtnDegıstır.Enabled = false;
                BtnKaydet.Enabled = false;
                groupBox2.Visible = false;
                groupBox1.Visible = true;
                groupBox3.Visible = true;
                groupBox4.Visible = true;
                TxtSıfre.ReadOnly = true;
                TxtSıfreTekrar.ReadOnly = true;
                LblGiriş.Text = "Müdür/Yetki Sınırsız / Kullanıcı:" + personel.PersonelİsimBilgi(Veritabanı._PersonelId);
            }
            else //Personel giriş yaptıysa
            {
                groupBox2.Visible = true;
                groupBox1.Visible = false;
                groupBox3.Visible = false;
                groupBox4.Visible = false;
                LblGiriş.Text = "Yetki Sınırlı / Kullanıcı:" + personel.PersonelİsimBilgi(Veritabanı._PersonelId);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(TxtYeni.Text.Trim()!=""||TxtTekrar.Text.Trim()!="") //Şifre değiştirme işlemi
            {
                if(TxtYeni.Text== TxtTekrar.Text)
                {
                    if(textBox3.Text!="")
                    {
                        Personel p = new Personel();
                        bool sonuc = p.SifreDeğiştir(Convert.ToInt32(textBox3.Text), TxtYeni.Text);
                        if(sonuc)
                        {
                            MessageBox.Show("Şifreniz başarıyla değiştirildi.");
                        }
                    }
                    else
                    {

                        MessageBox.Show("Personel alanı boş bırakılamaz.");
                    }
                }
                else
                {
                    MessageBox.Show("Girilen şifreler aynı değil.");
                }
            }
            else
            {
                MessageBox.Show("Şifre alanı boş bırakılamaz.");
            }
        }

        private void CbGorev_SelectedIndexChanged(object sender, EventArgs e)
        {
            PersonelGörev görev = (PersonelGörev)CbGorev.SelectedItem; //Personel görevini comboboxa getirme
            textBox2.Text = Convert.ToString(görev.PersonelGorevId);

        }

        private void Cbpersonel_SelectedIndexChanged(object sender, EventArgs e)
        {

            Personel personel = (Personel)Cbpersonel.SelectedItem; //Personeli comboboxa getirme
            textBox3.Text = Convert.ToString(personel.PersonelId);

        }

        private void BtnYeni_Click(object sender, EventArgs e)
        {
            BtnYeni.Enabled = false; //Girş yapana göre buton aktiflik durumu
            BtnKaydet.Enabled = true;
            BtnDegıstır.Enabled = false;
            BtnSil.Enabled = false;
            TxtSıfre.ReadOnly = false;
            TxtSıfreTekrar.ReadOnly = false;
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
          //Personel silme işlemleri
            if (listPersonel.Items.Count > 0)//Listviewde personel varsa işlem yap
            {
                if(MessageBox.Show("Silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Personel personel = new Personel();
                    bool sonuc= personel.PersonelSil(Convert.ToInt32(listPersonel.SelectedItems[0].Text));
                    if(sonuc)
                    {
                        MessageBox.Show("Kayıt silindi.");
                        personel.PersonelBigileriGetir(listPersonel);

                    }
                    else
                    {
                        MessageBox.Show("Kayıt silinirken hata oluştu");
                    }
                }
                else
                {
                    MessageBox.Show("Kayıt seçiniz.");
                }
            }

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            //Personel kaydetme işlemi 
            if(TxtAd.Text.Trim()!=""& TxtSoyad.Text.Trim() != ""& TxtSıfre.Text.Trim() != "" & TxtSıfreTekrar.Text!="" & textBox2.Text!="")
            {
                if((TxtSıfreTekrar.Text.Trim()==TxtSıfre.Text.Trim())&&(TxtSıfre.Text.Length>5||TxtSıfreTekrar.Text.Length>5))
                {
                    Personel personel = new Personel();
                    personel.PersonelAd = TxtAd.Text.Trim();
                    personel.PersonelSoyad = TxtSoyad.Text.Trim();
                    personel.PersonelSıfre = TxtSıfreTekrar.Text;
                    personel.PersonelGorevId = Convert.ToInt32(textBox2.Text);
                    bool sonuc= personel.PersonelEkle(personel); //Personel sınıfına gönderme
                    if(sonuc)
                    {
                        MessageBox.Show("Kayıt Eklendi.");
                        personel.PersonelBigileriGetir(listPersonel); //Bilgileri listviewde gösterme
                    }
                    else
                    {
                        MessageBox.Show("Kayıt eklenirken hata oluştu.");
                    }
                }
                else
                {
                    MessageBox.Show("Şifreler aynı değil.");
                }
            }
            else
            {
                MessageBox.Show("Alanlar boş bırakılamaz.");
            }
        }

        private void BtnDegıstır_Click(object sender, EventArgs e)
        {
            //Personel bigisi değiştirme işlemi
            if(listPersonel.Items.Count>0) //listviewde personel varsa işlem yap
            {

            if (TxtAd.Text != "" || TxtSoyad.Text != "" ||  TxtSıfre.Text != "" || TxtSıfreTekrar.Text != "" || textBox2.Text != "")
            {
                if ((TxtSıfreTekrar.Text.Trim() == TxtSıfre.Text.Trim()) && (TxtSıfre.Text.Length > 5 || TxtSıfreTekrar.Text.Length > 5))
                {
                    Personel personel = new Personel();
                    personel.PersonelAd = TxtAd.Text.Trim();
                    personel.PersonelSoyad = TxtSoyad.Text.Trim();
                    personel.PersonelSıfre = TxtSıfreTekrar.Text;
                    personel.PersonelGorevId = Convert.ToInt32(textBox2.Text);
                    bool sonuc = personel.PersonelGüncelle(personel,Convert.ToInt32(textBox1.Text));
                    if (sonuc)
                    {
                        MessageBox.Show("Kayıt Eklendi.");
                        personel.PersonelBigileriGetir(listPersonel);
                    }
                    else
                    {
                        MessageBox.Show("Kayıt eklenirken hata oluştu.");
                    }
                }
                else
                {
                    MessageBox.Show("Şifreler aynı değil.");
                }
            }
            else
            {
                MessageBox.Show("Alanlar boş bırakılamaz.");
            }

            }
            else
            {
                MessageBox.Show("Kayıt seçiniz.");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Personel şifre değiştirme (personel girişi)
            BtnKaydet.Enabled = false;
            if (TxtSifreDeğisim.Text.Trim() != "" || TxtSifreDeğisimYeni.Text.Trim() != "")
            {
                if (TxtSifreDeğisim.Text == TxtSifreDeğisimYeni.Text)
                {
                    if (Veritabanı._PersonelId.ToString() != "")
                    {
                        Personel p = new Personel();
                        bool sonuc = p.SifreDeğiştir(Convert.ToInt32(Veritabanı._PersonelId), TxtSifreDeğisim.Text);
                        if (sonuc)
                        {
                            MessageBox.Show("Şifreniz başarıyla değiştirildi.");
                        }
                    }
                    else
                    {

                        MessageBox.Show("Personel alanı boş bırakılamaz.");
                    }
                }
                else
                {
                    MessageBox.Show("Girilen şifreler aynı değil.");
                }
            }
            else
            {
                MessageBox.Show("Şifre alanı boş bırakılamaz.");
            }
        }

        private void listPersonel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listPersonel.SelectedItems.Count>0) //listvievde personel varsa bilgileri seçmeye izin ver
            {
                BtnSil.Enabled = true;
                textBox1.Text = listPersonel.SelectedItems[0].SubItems[0].Text;
                CbGorev.SelectedIndex = Convert.ToInt32(listPersonel.SelectedItems[0].SubItems[1].Text)-1;
                TxtAd.Text = listPersonel.SelectedItems[0].SubItems[3].Text;
                TxtSoyad.Text = listPersonel.SelectedItems[0].SubItems[4].Text;
            }
            else
            {
                BtnSil.Enabled = false;
            }
           
        }
    }
}
