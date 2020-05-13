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
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Ödev
{
    public partial class Masa : Form
    {
        public Masa()
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
            Close();
        }

        private void BtnMasa1_Click(object sender, EventArgs e)
        {
            Sipariş form = new Sipariş(); //Sipariş form nesnesi oluşturma
            int uzunluk = BtnMasa1.Text.Length; //Masa durumu 

            Veritabanı._ButtonDeğer = BtnMasa1.Text.Substring(uzunluk - 6, 6);
            Veritabanı._Buttonİsim = BtnMasa1.Name;
            this.Hide();
            form.Show(); //Sipariş sayfasına yönlendirme

        }

        private void BtnMasa2_Click(object sender, EventArgs e)
        {
            Sipariş form = new Sipariş(); //Sipariş sayfasına yönlendirme
            int uzunluk = BtnMasa2.Text.Length;

            Veritabanı._ButtonDeğer = BtnMasa2.Text.Substring(uzunluk - 6, 6);
            Veritabanı._Buttonİsim = BtnMasa2.Name;
            this.Hide();
            form.Show();
        }

        private void BtnMasa3_Click(object sender, EventArgs e)
        {
            Sipariş form = new Sipariş(); //Sipariş sayfasına yönlendirme
            int uzunluk = BtnMasa3.Text.Length;

            Veritabanı._ButtonDeğer = BtnMasa3.Text.Substring(uzunluk - 6, 6);
            Veritabanı._Buttonİsim = BtnMasa3.Name;
            this.Hide();
            form.Show();
        }

        private void BtnMasa4_Click(object sender, EventArgs e)
        {
            Sipariş form = new Sipariş(); //Sipariş sayfasına yönlendirme
            int uzunluk = BtnMasa4.Text.Length;

            Veritabanı._ButtonDeğer = BtnMasa4.Text.Substring(uzunluk - 6, 6);
            Veritabanı._Buttonİsim = BtnMasa4.Name;
            this.Hide();
            form.Show();
        }

        private void BtnMasa5_Click(object sender, EventArgs e)
        {
            Sipariş form = new Sipariş(); //Sipariş sayfasına yönlendirme
            int uzunluk = BtnMasa5.Text.Length;

            Veritabanı._ButtonDeğer = BtnMasa5.Text.Substring(uzunluk - 6, 6);
            Veritabanı._Buttonİsim = BtnMasa5.Name;
            this.Hide();
            form.Show();
        }

        private void BtnMasa6_Click(object sender, EventArgs e)
        {
            Sipariş form = new Sipariş(); //Sipariş sayfasına yönlendirme
            int uzunluk = BtnMasa6.Text.Length;

            Veritabanı._ButtonDeğer = BtnMasa6.Text.Substring(uzunluk - 6, 6);
            Veritabanı._Buttonİsim = BtnMasa6.Name;
            this.Hide();
            form.Show();
        }

        private void BtnMasa7_Click(object sender, EventArgs e)
        {
            Sipariş form = new Sipariş(); //Sipariş sayfasına yönlendirme
            int uzunluk = BtnMasa7.Text.Length;

            Veritabanı._ButtonDeğer = BtnMasa7.Text.Substring(uzunluk - 6, 6);
            Veritabanı._Buttonİsim = BtnMasa7.Name;
            this.Hide();
            form.Show();
        }

        private void BtnMasa8_Click(object sender, EventArgs e)
        {
            Sipariş form = new Sipariş(); //Sipariş sayfasına yönlendirme
            int uzunluk = BtnMasa8.Text.Length;

            Veritabanı._ButtonDeğer = BtnMasa8.Text.Substring(uzunluk - 6, 6);
            Veritabanı._Buttonİsim = BtnMasa8.Name;
            this.Hide();
            form.Show();
        }

        Veritabanı baglan = new Veritabanı();
        private void Masa_Load(object sender, EventArgs e)
        {
            //Masa durumunu veritabanına kaydetme
            SqlConnection baglanti = new SqlConnection(baglan.conString);
            SqlCommand sorgula = new SqlCommand("Select Id,Durum from Masa ", baglanti);
            SqlDataReader dr = null;
           
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            dr = sorgula.ExecuteReader();

            while (dr.Read())
            {
                foreach (Control item in this.Controls)
                {
                    if (item is Button)
                    {
                        if (item.Name == "BtnMasa" + dr["Id"].ToString() && dr["Durum"].ToString() == "1")
                        {
                            //Masa durumu 1'se boştur ve durumuna göre resim ata
                            item.BackgroundImage = (System.Drawing.Image)(Properties.Resources._1);
                        }
                        else if (item.Name == "BtnMasa" + dr["Id"].ToString() && dr["Durum"].ToString() == "2")
                        {
                            //Masa durumu 2'se dolu ve durumuna göre resim ata
                            item.BackgroundImage = (System.Drawing.Image)(Properties.Resources.dolu);
                        }
                        else if (item.Name == "BtnMasa" + dr["Id"].ToString() && dr["Durum"].ToString() == "3")
                        {
                            //Masa durumu 3'se  açık rezervedir ve durumuna göre resim ata
                            item.BackgroundImage = (System.Drawing.Image)(Properties.Resources.açık_rezerve);
                        }
                        else if (item.Name == "BtnMasa" + dr["Id"].ToString() && dr["Durum"].ToString() == "4")
                        {
                            //Masa durumu 3'se rezervedir ve durumuna göre resim ata
                            item.BackgroundImage = (System.Drawing.Image)(Properties.Resources.rezerve);
                        }
                    }

                }
                
            }
            dr.Close();
            baglanti.Close();
        }
    }
}
