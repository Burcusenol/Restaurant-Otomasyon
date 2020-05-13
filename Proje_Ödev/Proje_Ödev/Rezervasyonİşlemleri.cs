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
    class Rezervasyonİşlemleri
    {
        Veritabanı baglan = new Veritabanı();//Veritabanı bağantı nesnesi oluşturma

        //Alanlar(Fields)

        private int _Id;
        private int _TabloId;
        private int _OdemeId;
        private DateTime _Tarih;
        private int _OdemeSayım;
        private string _Durum;
        private int _AdisyonId;

        //Properties(Özellikler)
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }
        public int TabloId
        {
            get { return _TabloId; }
            set { _TabloId = value; }
        }
        public int OdemeId
        {
            get { return _OdemeId; }
            set { _OdemeId = value; }
        }
        public DateTime Tarih
        {
            get { return _Tarih; }
            set { _Tarih = value; }
        }
        public int OdemeSayım
        {
            get { return _OdemeSayım; }
            set { _OdemeSayım = value; }
        }
        public string Durum
        {
            get { return _Durum; }
            set { _Durum = value; }
        }
        public int AdisyonId
        {
            get { return _AdisyonId; }
            set { _AdisyonId = value; }
        }

        //Müşteri rezervason durum bilgisi
        public int MüşteriRezervasyon(int TabloId)
        {
            int MüşterId = 0;
            SqlConnection baglanti = new SqlConnection(baglan.conString);
            SqlCommand sorgula = new SqlCommand("Select top 1 MüşteriId from Rezervasyon where MasaId=@MasaId order by MüşteriId desc", baglanti);
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                sorgula.Parameters.AddWithValue("@MasaId", SqlDbType.Int).Value = TabloId;

                MüşterId = Convert.ToInt32(sorgula.ExecuteNonQuery());


            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }
            finally
            {

                baglanti.Close();
            }


            return MüşterId;
        }

        //Rezervasyon bilgilerini kapatma
        public bool RezervasyonKapatma(int AdisyonId)
        {
            bool result = false;

          
            SqlConnection baglanti = new SqlConnection(baglan.conString);
            SqlCommand sorgula = new SqlCommand("Update Rezervasyon set Durum=0 where AdisyonId=@AdisyonId", baglanti);
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                sorgula.Parameters.AddWithValue("@AdisyonId", SqlDbType.Int).Value = AdisyonId;
                result = Convert.ToBoolean(sorgula.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }
            finally
            {

                baglanti.Close();
            }

            return result;
        }
    }
}
