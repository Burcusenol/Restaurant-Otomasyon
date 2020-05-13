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
    class ÜrünÇeşit
    {
        Veritabanı baglan = new Veritabanı();//Veritabanı bağlantı nesnesi oluşturma

        //Alanlar(Fields)

        private int _ÜrünId;
        private int _UrunTurNo;
        private string _UrunAd;
        private decimal _Fiyat;
        private string _Açıklama;

        //Properties(Özellikler)
        public int ÜrünId
        {
            get { return _ÜrünId; }
            set { _ÜrünId = value; }
        }
        public int UrunTurNo
        {
            get { return _UrunTurNo; }
            set { _UrunTurNo = value; }
        }
        public string UrunAd
        {
            get { return _UrunAd; }
            set { _UrunAd = value; }
        }
        public decimal Fiyat
        {
            get { return _Fiyat; }
            set { _Fiyat = value; }
        }
        public string Açıklama
        {
            get { return _Açıklama; }
            set { _Açıklama = value; }
        }
        //Ürün adına göre listviewe listeleme
        public void ÜrünAdınaGöreListele(ListView list,string ÜrünAdı)
        {
            list.Items.Clear();
            SqlConnection baglanti = new SqlConnection(baglan.conString);
            SqlCommand sorgula = new SqlCommand("Select * from Ürün where Durum=0 and ÜrünAd like '%'+ @ÜrünAdı + '%'", baglanti);
            SqlDataReader dr = null;
            sorgula.Parameters.AddWithValue("@ÜrünAdı", SqlDbType.VarChar).Value = ÜrünAdı;
            try
            {
                if (baglanti.State == ConnectionState.Closed)

                    baglanti.Open();
                dr = sorgula.ExecuteReader();
                int sayac = 0;
                while (dr.Read())
                {
                    list.Items.Add(dr["Id"].ToString());
                    list.Items[sayac].SubItems.Add(dr["KategoriId"].ToString());
                    list.Items[sayac].SubItems.Add(dr["ÜrünAd"].ToString());
                    list.Items[sayac].SubItems.Add(dr["Açıklama"].ToString());
                    list.Items[sayac].SubItems.Add(string.Format("{0:0#00.0}",dr["Fiyat"].ToString()));

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
                baglanti.Close();
            }

        }
        //Ürün ekleme
        public int ÜrünEkle(ÜrünÇeşit ürün)
        {
            int sonuc = 0;

            SqlConnection baglanti = new SqlConnection(baglan.conString);
            SqlCommand sorgula = new SqlCommand("insert into Ürün (ÜrünAd,KategoriId,Açıklama,Fiyat) values(@ÜrünAd,@KategoriId,@Açıklama,@Fiyat)", baglanti);
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                sorgula.Parameters.AddWithValue("@ÜrünAd", SqlDbType.VarChar).Value = ürün._UrunAd;
                sorgula.Parameters.AddWithValue("@KategoriId", SqlDbType.Int).Value = ürün._UrunTurNo;
                sorgula.Parameters.AddWithValue("@Açıklama", SqlDbType.VarChar).Value = ürün._Açıklama;
                sorgula.Parameters.AddWithValue("@Fiyat", SqlDbType.Money).Value = ürün._Fiyat;
              
                sonuc = Convert.ToInt32(sorgula.ExecuteNonQuery());

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

        //Ürün ve kategorileri listviewde listele
        public void ÜrünListele(ListView list)
        {
            list.Items.Clear();
            SqlConnection baglanti = new SqlConnection(baglan.conString);
            SqlCommand sorgula = new SqlCommand("Select Ürün.*, KategoriAdı from Ürün inner join Kategori on Kategori.Id=Ürün.KategoriId where Ürün.Durum=0", baglanti);
            SqlDataReader dr = null;
          
            try
            {
                if (baglanti.State == ConnectionState.Closed)

                    baglanti.Open();
                dr = sorgula.ExecuteReader();
                int sayac = 0;
                while (dr.Read())
                {
                    list.Items.Add(dr["Id"].ToString());
                    list.Items[sayac].SubItems.Add(dr["KategoriId"].ToString());
                    list.Items[sayac].SubItems.Add(dr["KategoriAdı"].ToString());
                    list.Items[sayac].SubItems.Add(dr["ÜrünAd"].ToString());
                    list.Items[sayac].SubItems.Add(string.Format("{0:0#00.0}", dr["Fiyat"].ToString()));
                    list.Items[sayac].SubItems.Add(dr["Açıklama"].ToString());

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
                baglanti.Close();
            }

        }
        //Ürün Güncelleme
        public int ÜrünGüncelle(ÜrünÇeşit ürün)
        {
            int sonuc = 0;

            SqlConnection baglanti = new SqlConnection(baglan.conString);
            SqlCommand sorgula = new SqlCommand("Update Ürün set ÜrünAd=@ÜrünAd,KategoriId=@KategoriId,Açıklama=@Açıklama,Fiyat=@Fiyat where Id=@ÜrünId ", baglanti);
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                sorgula.Parameters.AddWithValue("@ÜrünAd", SqlDbType.VarChar).Value = ürün._UrunAd;
                sorgula.Parameters.AddWithValue("@KategoriId", SqlDbType.Int).Value = ürün._UrunTurNo;
                sorgula.Parameters.AddWithValue("@Açıklama", SqlDbType.VarChar).Value = ürün._Açıklama;
                sorgula.Parameters.AddWithValue("@Fiyat", SqlDbType.Money).Value = ürün._Fiyat;
                sorgula.Parameters.AddWithValue("@ÜrünId", SqlDbType.Int).Value = ürün._ÜrünId;
               
                sonuc = Convert.ToInt32(sorgula.ExecuteNonQuery());

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

        //Ürün Silme 
        public int ÜrünSil(ÜrünÇeşit ürün,int kategori)
        {
            int sonuc = 0;

            SqlConnection baglanti = new SqlConnection(baglan.conString);
            string sql = "Update Ürün set Durum=1 where ";
            if(kategori == 0)
            {
                sql += "KategoriId=@ÜrünId";
            }
            else
            {
                sql += "Id=@ÜrünId";
            }
            SqlCommand sorgula = new SqlCommand(sql, baglanti);
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                
                sorgula.Parameters.AddWithValue("@ÜrünId", SqlDbType.Int).Value = ürün._ÜrünId;

                sonuc = Convert.ToInt32(sorgula.ExecuteNonQuery());

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

        //Ürünleri Idsine göre listviewde listeleme
        public void ÜrünIdGöreListele(ListView list, int ÜrünId)
        {
            list.Items.Clear();
            SqlConnection baglanti = new SqlConnection(baglan.conString);
            SqlCommand sorgula = new SqlCommand("Select Ürün.*, KategoriAdı from Ürün inner join Kategori on Kategori.Id=Ürün.KategoriId where Ürün.Durum=0 and Ürün.KategoriId=@ÜrünId ", baglanti);
            SqlDataReader dr = null;
            sorgula.Parameters.AddWithValue("@ÜrünId", SqlDbType.Int).Value = ÜrünId;
            try
            {
                if (baglanti.State == ConnectionState.Closed)

                    baglanti.Open();
                dr = sorgula.ExecuteReader();
                int sayac = 0;
                while (dr.Read())
                {
                    list.Items.Add(dr["Id"].ToString());
                    list.Items[sayac].SubItems.Add(dr["KategoriId"].ToString());
                    list.Items[sayac].SubItems.Add(dr["KategoriAdı"].ToString());
                    list.Items[sayac].SubItems.Add(dr["ÜrünAd"].ToString());
                    list.Items[sayac].SubItems.Add(string.Format("{0:0#00.0}", dr["Fiyat"].ToString()));

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
                baglanti.Close();
            }

        }
      
    }
}
