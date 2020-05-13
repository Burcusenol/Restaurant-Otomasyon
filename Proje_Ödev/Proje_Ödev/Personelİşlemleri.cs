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

namespace Proje_Ödev
{
    class Personelİşlemleri
    {
        Veritabanı baglan = new Veritabanı();//Veritabanı bağlantı nesnesi oluşturma

        // Alanlar (Fields)
        private int _Id;
        private int _PersonelId;
        private string _İslem;
        private DateTime _Tarih;
        private bool _Durum;


        // Özellikler (Properties)
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }
        public int PersonelId
        {
            get { return _PersonelId; }
            set { _PersonelId = value; }
        }
        public string İslem
        {
            get { return _İslem; }
            set { _İslem = value; }
        }
        public DateTime Tarih
        {
            get { return _Tarih; }
            set { _Tarih = value; }
        }
        public bool Durum
        {
            get { return _Durum; }
            set { _Durum = value; }
        }

        //Personel işlem kaydı tutma
        public bool Hareket(Personelİşlemleri pi)
        {
            bool result = false;
            SqlConnection baglanti = new SqlConnection(baglan.conString);
            SqlCommand sorgula = new SqlCommand("Insert Into Personelİşlemleri(PersonelId,İşlem,Tarih)values(@PersonelId,@İşlem,@Tarih)", baglanti);
          
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                sorgula.Parameters.AddWithValue("@PersonelId", SqlDbType.Int).Value = pi._PersonelId;
                sorgula.Parameters.AddWithValue("@İşlem", SqlDbType.VarChar).Value = pi._İslem;
                sorgula.Parameters.AddWithValue("@Tarih", SqlDbType.DateTime).Value = pi._Tarih;

                result = Convert.ToBoolean(sorgula.ExecuteNonQuery());
                   
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }
            return result;
        }

    }
}
