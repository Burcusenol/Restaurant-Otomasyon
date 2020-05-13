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
    class Adisyon
    {
        Veritabanı baglan = new Veritabanı();//VeriTabanı bağlantı nesnesi oluşturma


        //Alanlar(Fields)

        private int _İd;
        private int _ServisTurno;
        private int _PersonelId;
        private int _MasaId;
        private DateTime _Tarih;
        private int _Durum;
        private decimal _Tutar;

       // Properties(Özellikler)
        public int İd
        {
            get { return _İd; }
            set { _İd = value; }
        }
        public int ServisTurno
        {
            get { return _ServisTurno; }
            set { _ServisTurno = value; }
        }
        public int PersonelId
        {
            get { return _PersonelId; }
            set { _PersonelId = value; }
        }

        public int MasaId
        {
            get { return _MasaId; }
            set { _MasaId = value; }
        }
        public DateTime Tarih
        {
            get { return _Tarih; }
            set { _Tarih = value; }
        }
        public int Durum
        {
            get { return _Durum; }
            set { _Durum = value; }
        }
        public decimal Tutar
        {
            get { return _Tutar; }
            set { _Tutar = value; }
        }

        //MasaIdsine göre adisyon bulup sıralama
        public int Adisyonİslem(int MasaId)
        {
            SqlConnection baglanti = new SqlConnection(baglan.conString); //Veritabanı bağlantı işlemi
            SqlCommand sorgula = new SqlCommand("Select top 1 Id from Adisyon where MasaId=@MasaId order by Id desc ", baglanti); //sorgu
            sorgula.Parameters.AddWithValue("@MasaId", SqlDbType.Int).Value = MasaId;
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                MasaId = Convert.ToInt32(sorgula.ExecuteScalar());
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
            return MasaId;
        }
        //Adisyon bilgilerini vertabanına kaydetme
        public bool Adisyonlar(Adisyon Bilgi)
        {
            bool sonuc = false;
            SqlConnection baglanti = new SqlConnection(baglan.conString);
            SqlCommand sorgula = new SqlCommand("Insert into Adisyon(ServisTurNo,Tarih,PersonelId,MasaId,Durum)values(@ServisTurNo,@Tarih,@PersonelId,@MasaId,@Durum)", baglanti);

            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
              
                sorgula.Parameters.AddWithValue("@ServisTurNo", SqlDbType.Int).Value = Bilgi.ServisTurno;
                sorgula.Parameters.AddWithValue("@Tarih", SqlDbType.Int).Value = Bilgi.Tarih;
                sorgula.Parameters.AddWithValue("@PersonelId", SqlDbType.Int).Value = Bilgi.PersonelId;
                sorgula.Parameters.AddWithValue("@MasaId", SqlDbType.Int).Value = Bilgi.MasaId;
                sorgula.Parameters.AddWithValue("@Durum", SqlDbType.Bit).Value = 0;
                sonuc = Convert.ToBoolean(sorgula.ExecuteNonQuery());

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
            return sonuc;
        }

        //Adisyon silme işlemleri
        public void AdisyonKapatma(int AdisyonId, int Durum)
        {



            SqlConnection baglanti = new SqlConnection(baglan.conString);
            SqlCommand sorgula = new SqlCommand("Update Adisyon set Durum=@Durum where Id=@AdisyonId", baglanti);
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                sorgula.Parameters.AddWithValue("@AdisyonId", SqlDbType.Int).Value = AdisyonId;
                sorgula.Parameters.AddWithValue("@Durum", SqlDbType.Int).Value = Durum;
                sorgula.ExecuteNonQuery();
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


        }
    }
}
