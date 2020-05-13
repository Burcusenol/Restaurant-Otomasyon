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
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Ödev
{
    class PersonelGörev
    {

        Veritabanı baglan = new Veritabanı();//Veritabanı bağlantı nesnesi oluşturma

        //Alanlar(Fields)
        private int _PersonelGorevId;
        private string _Tanım;

        //Properties(Özellikler)
        public int PersonelGorevId
        {
            get { return _PersonelGorevId; }
            set { _PersonelGorevId = value; }
        }
        public string Tanım
        {
            get { return _Tanım; }
            set { _Tanım = value; }
        }

        //Personel görev bilgisini comboboxa alma
        public void PersonelGörevGetir(ComboBox c)
        {
            c.Items.Clear();

            SqlConnection baglanti = new SqlConnection(baglan.conString);
            SqlCommand sorgula = new SqlCommand("Select * from Görev ", baglanti);
            SqlDataReader dr = null;


            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                dr = sorgula.ExecuteReader();

                while (dr.Read())
                {

                    PersonelGörev p = new PersonelGörev();
                    p._PersonelGorevId = Convert.ToInt32(dr["Id"].ToString());
                    p._Tanım = dr["Görev"].ToString();
                    c.Items.Add(p);
                }

            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }


        }

        //Personel görevi oluşturma
        public string PersonelGörevTanım(int personel)
        {
            string sonuc = "";
            SqlConnection baglanti = new SqlConnection(baglan.conString);
            SqlCommand sorgula = new SqlCommand("Select Görev from Görev where Id=@PersonelId ", baglanti);
            sorgula.Parameters.AddWithValue("@PersonelId", SqlDbType.Int).Value = personel;

            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                sonuc = sorgula.ExecuteScalar().ToString();

            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }
            baglanti.Close();
            return sonuc;

        }

        //Görev bilgisi için override işlemi
        public override string ToString()
        {
            return _Tanım;
        }


    }
}
