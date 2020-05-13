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
    class Siparişler
    {
        Veritabanı baglan = new Veritabanı();//Veritaban bağlantı nesnesi oluşturma

        //Alanlar(Fields)
        private int _İd;
        private int _AdisyonId;
        private int _UrunId;
        private int _MasaId;
        private int _Adet;

        //Properties(Özellikler)
        public int İd
        {
            get { return _İd; }
            set { _İd = value; }
        }
        public int AdisyonId
        {
            get { return _AdisyonId; }
            set { _AdisyonId = value; }
        }
        public int UrunId
        {
            get { return _UrunId; }
            set { _UrunId = value; }
        }
        public int MasaId
        {
            get { return _MasaId; }
            set { _MasaId = value; }
        }
        public int Adet
        {
            get { return _Adet; }
            set { _Adet = value; }
        }

        //Sipariş bilgilerini adisyona göre listviewe alma
        public void SiparisleriGetir(ListView l,int AdisyonId)
        {
            SqlConnection baglanti = new SqlConnection(baglan.conString);
            SqlCommand sorgula = new SqlCommand("Select ÜrünAd,ÜrünId,Fiyat,Satış.Id,Satış.Adet from Satış inner join Ürün on Satış.ÜrünId =Ürün.Id where AdisyonId=@AdisyonId", baglanti);
            SqlDataReader dr = null;
            sorgula.Parameters.AddWithValue("@AdisyonId", SqlDbType.Int).Value = AdisyonId;
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                dr = sorgula.ExecuteReader();
         
                int sayac = 0;
                while (dr.Read())
                {
                    l.Items.Add ( dr["ÜrünAd"].ToString());
                    l.Items[sayac].SubItems.Add(dr["Adet"].ToString());
                    l.Items[sayac].SubItems.Add(dr["ÜrünId"].ToString());
                    l.Items[sayac].SubItems.Add(Convert.ToString(Convert.ToDecimal(dr["Fiyat"])* Convert.ToDecimal(dr["Adet"])));
                    l.Items[sayac].SubItems.Add(dr["Id"].ToString());

                    sayac++;
                
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
          
        }

        //Sipariş vertabanına kaydetme
        public bool SiparisKaydet(Siparişler bilgi)
        {
            bool sonuc = false;
            SqlConnection baglanti = new SqlConnection(baglan.conString);
            SqlCommand sorgula = new SqlCommand("Insert into Satış (AdisyonId,ÜrünId,MasaId,Adet) values(@AdisyonNo,@ÜrünId,@MasaId,@Adet)", baglanti);
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                sorgula.Parameters.AddWithValue("@AdisyonNo", SqlDbType.Int).Value = bilgi._AdisyonId;
                sorgula.Parameters.AddWithValue("@ÜrünId", SqlDbType.Int).Value = bilgi._UrunId;
                sorgula.Parameters.AddWithValue("@Adet", SqlDbType.Int).Value = bilgi._Adet;
                sorgula.Parameters.AddWithValue("@MasaId", SqlDbType.Int).Value = bilgi._MasaId;
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
        //Sipariş satış Idye göre silme
        public void SiparisSil(int SatısId)
        {
            SqlConnection baglanti = new SqlConnection(baglan.conString);
            SqlCommand sorgula = new SqlCommand("Delete from Satış where Id=@SatışId ", baglanti);
            sorgula.Parameters.AddWithValue("@SatışId", SqlDbType.Int).Value = SatısId;

            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            baglanti.Close();

        }
    }
}
