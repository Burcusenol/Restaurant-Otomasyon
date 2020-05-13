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
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void PcKullanıcı_Click(object sender, EventArgs e)
        {
            Müşteri form = new Müşteri(); //Müşteri formuna yönlendirme
            this.Hide();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();//Uygulama kapatma
        }

        private void PcMasa_Click(object sender, EventArgs e)
        {
            Masa form = new Masa();  //Masa formuna yönlendirme
            this.Hide();
            form.Show();
        }

        private void PcRezerve_Click(object sender, EventArgs e)
        {
            Rezervasyon form = new Rezervasyon(); //Rezervasyon formuna yönlendirme
            this.Hide();
            form.Show();
        }

        private void PcKasa_Click(object sender, EventArgs e)
        {
            Kasa form = new Kasa(); //Kasa formuna yönlendirme
            this.Hide();
            form.Show();
        }

        private void PcAyar_Click(object sender, EventArgs e)
        {
            Ayarlar form = new Ayarlar(); //Ayarlar formuna yönlendirme
            this.Hide();
            this.Hide();
            form.Show();
        }

        private void PcMutfak_Click(object sender, EventArgs e)
        {
            Mutfak form=new Mutfak(); //Mutfak formuna yönlendirme
            this.Hide();
            this.Hide();
            form.Show();
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {

        }
    }
}
