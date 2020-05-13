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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Linq.Expressions;
using System.Windows.Forms;
using System.Configuration;

namespace Proje_Ödev
{
    class Masalar
    {

        // Alanlar (Fields)
        private int _Id;
        private int _Kapasite;
        private int _ServisTuru;
        private int _Durum;
        private int _Onay;

        // Özellikler (Properties)
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }
        public int Kapasite
        {
            get { return _Kapasite; }
            set { _Kapasite = value; }
        }
        public int ServisTuru
        {
            get { return _ServisTuru; }
            set { _ServisTuru = value; }
        }
        public int Durum
        {
            get { return _Durum; }
            set { _Durum = value; }
        }
        public int Onay
        {
            get { return _Onay; }
            set { _Onay = value; }
        }
        
        Veritabanı baglan = new Veritabanı();//Veritabanına bağlantı nesnesi

        //Masa durum bigisi ve adisyon bilgisi alma
        public string DurumToplam(int durum,string MasaId)
        {
         
            string dt = "";
            SqlConnection baglanti = new SqlConnection(baglan.conString);
            SqlCommand sorgula = new SqlCommand("Select Tarih,MasaId From Adisyon Right Join Masa on Adisyon.MasaId=Masa.Id where Masa.Durum=@Durum and Adisyon.Durum=0 and Masa.Id=@MasaId", baglanti);
            SqlDataReader dr = null;
            sorgula.Parameters.AddWithValue("@Durum", SqlDbType.Int).Value = durum;
            sorgula.Parameters.AddWithValue("@MasaId", SqlDbType.Int).Value = Convert.ToInt32(MasaId);
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                dr = sorgula.ExecuteReader();
                while (dr.Read())
                {
                    dt = Convert.ToDateTime(dr["Tarih"]).ToString();
                }
                
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }
            finally
            {
                dr.Close();
                baglanti.Dispose();
                baglanti.Close();
            }
            return dt;
        }
        //Masa numarası 
        public int TabloNumarası(string Değer)
        {
            string value = Değer;
            int uzun = value.Length;
            if (uzun > 8)
            {
                return Convert.ToInt32(value.Substring(uzun - 2, 2));
            }
            else
            {
                return Convert.ToInt32(value.Substring(uzun - 1, 1));
            }
           

        }
        //Masa durumunu veritabanında değiştirme
        public bool TabloDurumu(int ButtonName,int durum)
        {
            bool result = false;
            SqlConnection baglanti = new SqlConnection(baglan.conString);
            SqlCommand sorgula = new SqlCommand("Select Durum from Masa where Id=@TabloId and Durum=@durum", baglanti);
            sorgula.Parameters.AddWithValue("@TabloId", SqlDbType.Int).Value = ButtonName;
            sorgula.Parameters.AddWithValue("@Durum", SqlDbType.Int).Value = durum;

            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
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
        //Masa durumunu güncelleme 
        public void TabloGüncelleme(string ButonName,int durum)
        {
            SqlConnection baglanti = new SqlConnection(baglan.conString);
            SqlCommand sorgula = new SqlCommand("Update Masa Set Durum=@Durum where Id=@MasaNo", baglanti);
            string MasaNo = "";
            
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                string b = ButonName;
                int uzunluk = b.Length;
           
                sorgula.Parameters.AddWithValue("@Durum", SqlDbType.Int).Value = durum;
                 if(uzunluk>8)
                 {
                    MasaNo = b.Substring(uzunluk - 2, 2);
                 }
                 else
                 {
                    MasaNo = b.Substring(uzunluk - 1, 1);
                 }
                sorgula.Parameters.AddWithValue("@MasaNo", SqlDbType.Int).Value = b.Substring(uzunluk-1,1);

                sorgula.ExecuteNonQuery();
                baglanti.Close();
            
            
           
        }
    }
}
