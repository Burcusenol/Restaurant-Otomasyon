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
    class PaketServis
    {
        Veritabanı baglan = new Veritabanı();//Veritabanı bağlantı nesnesi oluşturma

        //Alanlar(Fields)

        private int _İd;
        private int _MüşteriId;
        private int _AdisyonId;
        private string _Açıklama;
        private int _Durum;
        private int _OdemeTurId;

        //Properties(Özellikler)
        public int İd
        {
            get { return _İd; }
            set { _İd = value; }
        }
        public int MüşteriId
        {
            get { return _MüşteriId; }
            set { _MüşteriId = value; }
        }
        public int AdisyonId
        {
            get { return _AdisyonId; }
            set { _AdisyonId = value; }
        }
        public string Açıklama
        {
            get { return _Açıklama; }
            set { _Açıklama = value; }
        }
        public int Durum
        {
            get { return _Durum; }
            set { _Durum = value; }
        }

        public int OdemeTurId
        {
            get { return _OdemeTurId; }
            set { _OdemeTurId = value; }
        }

        //Paket servis bilgilerini ekleme
        public bool PaketServisEkle(PaketServis paket)
        {
            bool result = false;
            SqlConnection baglanti = new SqlConnection(baglan.conString);
            SqlCommand sorgula = new SqlCommand("Insert Into PaketServis (MüşteriId,AdisyonId,ÖdemeTürId,Açıklama)values(@MüşteriId,@AdisyonId,@ÖdemeTürId,@Açıklama)", baglanti);

            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                sorgula.Parameters.AddWithValue("@AdisyonId", SqlDbType.Int).Value = paket._AdisyonId;
                sorgula.Parameters.AddWithValue("@MüşteriId", SqlDbType.Int).Value = paket._MüşteriId;
                sorgula.Parameters.AddWithValue("@ÖdemeTürId", SqlDbType.Int).Value = paket._OdemeTurId;
                sorgula.Parameters.AddWithValue("@Açıklama", SqlDbType.Int).Value = paket._Açıklama;
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
        
        //Paket servis hesabını kapatma
        public void PaketServisÇıkar(int AdisyonId)
        {
           
            SqlConnection baglanti = new SqlConnection(baglan.conString);
            SqlCommand sorgula = new SqlCommand("Update PaketServis set PaketServis.Durum=1 from PaketServis Inner Join Adisyon on PaketServis.AdisyonId=Adisyon.Id where PaketServis.AdisyonId=@AdisyonId", baglanti);

            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                sorgula.Parameters.AddWithValue("@AdisyonId", SqlDbType.Int).Value = AdisyonId;
               
                Convert.ToBoolean(sorgula.ExecuteNonQuery());

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

        //Adisyon Idye göre ödeme türü getirme
        public int ÖdemeTürüGetir(int AdisyonId)
        {
            int odemeturId = 0;

            SqlConnection baglanti = new SqlConnection(baglan.conString);
            SqlCommand sorgula = new SqlCommand("Select PaketServis.ÖdemeTürId from PaketServis Inner Join Adisyon on PaketServis.AdisyonId=Adisyon.Id where Adisyon.Id=@AdisyonId", baglanti);

            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                sorgula.Parameters.AddWithValue("@AdisyonId", SqlDbType.Int).Value = AdisyonId;

                odemeturId = Convert.ToInt32(sorgula.ExecuteScalar());

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
            return odemeturId;

        }

        //Adisyon bilgilerini getirme işlemi
        public int MüşteriAdisyonuGetir(int MüşteriId)
        {
            int no = 0;

            SqlConnection baglanti = new SqlConnection(baglan.conString);
            SqlCommand sorgula = new SqlCommand("Select Adisyon.Id from Adisyon Inner Join PaketServis on PaketServis.AdisyonId=Adisyon.Id where (Adisyon.Durum=0) and (PaketServis.Durum=0) and PaketServis.MüşteriId=@MüşteriId", baglanti);

            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                sorgula.Parameters.AddWithValue("@MüşteriId", SqlDbType.Int).Value = MüşteriId;

                no = Convert.ToInt32(sorgula.ExecuteScalar());

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
            return no;

        }

        //ADisyon var mı yok mu kontrolü
        public bool AdisyonKontrolü(int AdisyonId)
        {
            bool result = false;
            SqlConnection baglanti = new SqlConnection(baglan.conString);
            SqlCommand sorgula = new SqlCommand("Select * from Adisyon where (Durum=0) and (Id=@AdisyonId)", baglanti);

            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                sorgula.Parameters.AddWithValue("@AdisyonId", SqlDbType.Int).Value = AdisyonId;
                
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
    }
}
