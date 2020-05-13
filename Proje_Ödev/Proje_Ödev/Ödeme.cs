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
    class Ödeme
    {
        Veritabanı baglan = new Veritabanı();//Veritabanı bağlantı nesnesi oluşturma

        //Alanlar(Fields)
        private int _OdemeId;
        private int _AdisyonId;
        private int _OdemeTurId;
        private decimal _AraToplam;
        private decimal _Indırım;
        private decimal _KdvTutarı;
        private decimal _GenelToplam;
        private DateTime _Tarih;
        private int _MüşteriId;

        //Properties(Özellikler)
        public int OdemeId
        {
            get { return _OdemeId; }
            set { _OdemeId = value; }
        }
        public int AdisyonId
        {
            get { return _AdisyonId; }
            set { _AdisyonId = value; }
        }
        public int OdemeTurId
        {
            get { return _OdemeTurId; }
            set { _OdemeTurId = value; }
        }
        public decimal AraToplam
        {
            get { return _AraToplam; }
            set { _AraToplam = value; }
        }
        public decimal Indırım
        {
            get { return _Indırım; }
            set { _Indırım = value; }
        }
        public decimal KdvTutarı
        {
            get { return _KdvTutarı; }
            set { _KdvTutarı = value; }
        }
        public decimal GenelToplam
        {
            get { return _GenelToplam; }
            set { _GenelToplam = value; }
        }
        public DateTime Tarih
        {
            get { return _Tarih; }
            set { _Tarih = value; }
        }
        public int MüşteriId
        {
            get { return _MüşteriId; }
            set { _MüşteriId = value; }
        }

        //Hesap ödendiğinde bilgileri Heap tablosuna kaydetme işlemi
        public bool HesapKapatma(Ödeme hesap)
        {
            bool result = false;
            SqlConnection baglanti = new SqlConnection(baglan.conString);
            SqlCommand sorgula = new SqlCommand("Insert Into Hesap (AdisyonId,ÖdemeTürId,ToplamTutar,Kdv,MüşteriId,AraToplam,İndirim) values(@AdisyonId,@ÖdemeTürId,@ToplamTutar,@Kdv,@MüşteriId,@AraToplam,@İndirim)", baglanti);
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                sorgula.Parameters.AddWithValue("@AdisyonId", SqlDbType.Int).Value = hesap._AdisyonId;
                sorgula.Parameters.AddWithValue("@ÖdemeTürId", SqlDbType.Int).Value = hesap._OdemeTurId;
                sorgula.Parameters.AddWithValue("@ToplamTutar", SqlDbType.Money).Value = hesap._GenelToplam;
                sorgula.Parameters.AddWithValue("@Kdv", SqlDbType.Money).Value = hesap._KdvTutarı;
                sorgula.Parameters.AddWithValue("@MüşteriId", SqlDbType.Int).Value = hesap._MüşteriId;
                sorgula.Parameters.AddWithValue("@AraToplam", SqlDbType.Money).Value = hesap._AraToplam;
                sorgula.Parameters.AddWithValue("@İndirim", SqlDbType.Money).Value = hesap._Indırım;
                result = Convert.ToBoolean(sorgula.ExecuteNonQuery());

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
        //Müşteri Idsine göre Toplam tutar hesaplama
        public decimal MüşteriyeGöreToplam(int MüşteriId)
        {
            decimal toplam = 0;
            SqlConnection baglanti = new SqlConnection(baglan.conString);
            SqlCommand sorgula = new SqlCommand("Select sum (ToplamTutar) as toplam from Hesap where MüşteriId=@MüşteriId", baglanti);
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                sorgula.Parameters.AddWithValue("@MüşteriId", SqlDbType.Int).Value = MüşteriId;
                toplam = Convert.ToDecimal(sorgula.ExecuteScalar());
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
            return toplam;
        }
    }
}
