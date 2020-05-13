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
    class Ürünler
    {

        Veritabanı baglan = new Veritabanı();//Veritabanı bağlantı nesnesi oluşturma
       
        //Alanlar(Fields)
        private int _UrunTurId;
        private string _KategoriAd;
        private string _Açıklama;

        //Properties(Özellikler)
        public string TurAd
        {
            get { return _KategoriAd; }
            set { _KategoriAd = value; }
        }
        public string Açıklama
        {
            get { return _Açıklama; }
            set { _Açıklama = value; }
        }

        public int UrunTurId
        {
            get { return _UrunTurId; }
            set { _UrunTurId = value; }
        }

        //Kategoriye göre ürün bilgilerini listviewe getirme
        public void ÜrünBilgileri(ListView çeşit,Button buton)
        {
            çeşit.Items.Clear();
            SqlConnection baglanti = new SqlConnection(baglan.conString);
            SqlCommand sorgula = new SqlCommand("Select ÜrünAd,Fiyat,ü.Id from Kategori k inner join Ürün ü on k.Id=ü.KategoriId where ü.KategoriId=@KategoriId", baglanti);
           
            string value = buton.Name;
            int uzun = value.Length;
            sorgula.Parameters.AddWithValue("@KategoriId", SqlDbType.Int).Value = value.Substring(uzun - 1, 1);
          
            if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                int i = 0;
            SqlDataReader dr = sorgula.ExecuteReader();
            while (dr.Read())
            {
                çeşit.Items.Add(dr["ÜrünAd"].ToString());
                çeşit.Items[i].SubItems.Add(dr["Fiyat"].ToString());
                çeşit.Items[i].SubItems.Add(dr["Id"].ToString());
                i++;
            }
            dr.Close();
            baglanti.Close();
             
        }

        //Ürün arama 
        public void ÜrünArama(ListView çeşit, int text)
        {
            çeşit.Items.Clear();
            SqlConnection baglanti = new SqlConnection(baglan.conString);
            SqlCommand sorgula = new SqlCommand("Select * from Ürün where Id=@Id", baglanti);

         
            sorgula.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = text;

            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            int i = 0;
            SqlDataReader dr = sorgula.ExecuteReader();
            while (dr.Read())
            {
                çeşit.Items.Add(dr["ÜrünAd"].ToString());
                çeşit.Items[i].SubItems.Add(dr["Fiyat"].ToString());
                çeşit.Items[i].SubItems.Add(dr["Id"].ToString());
                i++;
            }
            dr.Close();
            baglanti.Close();

        }

        //Ürün çeşitlerini comboboxa getirme
        public void ÜrünÇeşitleriGetir(ComboBox c)
        {
            c.Items.Clear();
            SqlConnection baglanti = new SqlConnection(baglan.conString);
            SqlCommand sorgula = new SqlCommand("Select * from Kategori where Durum=0", baglanti);
            SqlDataReader dr = null;

            try
            {
                if (baglanti.State == ConnectionState.Closed)

                    baglanti.Open();
                dr = sorgula.ExecuteReader();
               
                while (dr.Read())
                {
                    Ürünler ürün = new Ürünler();
                    ürün.UrunTurId =Convert.ToInt32(dr["Id"]);
                    ürün._KategoriAd = dr["KategoriAdı"].ToString();
                    ürün._Açıklama = dr["Açıklama"].ToString();
                    c.Items.Add(ürün);
                    
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

        //Ürün çeşitlerini listviewe getirme
        public void ÜrünÇeşitleriGetir(ListView list)
        {
            list.Items.Clear();
            SqlConnection baglanti = new SqlConnection(baglan.conString);
            SqlCommand sorgula = new SqlCommand("Select * from Kategori where Durum=0", baglanti);
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
                    list.Items[sayac].SubItems.Add(dr["KategoriAdı"].ToString());
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


        //Ürün Arama ve listviewde listeleme
        public void ÜrünÇeşitleriGetir(ListView list,string arama)
        {
            list.Items.Clear();
            SqlConnection baglanti = new SqlConnection(baglan.conString);
            SqlCommand sorgula = new SqlCommand("Select * from Kategori where Durum=0 and KategoriAdı like '%' + @arama+ '%'", baglanti);
            SqlDataReader dr = null;
            sorgula.Parameters.AddWithValue("@arama", SqlDbType.VarChar).Value = arama;
            try
            {
                if (baglanti.State == ConnectionState.Closed)

                    baglanti.Open();
                dr = sorgula.ExecuteReader();
                int sayac = 0;
                while (dr.Read())
                {
                    list.Items.Add(dr["Id"].ToString());
                    list.Items[sayac].SubItems.Add(dr["KategoriAdı"].ToString());
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

        //Ürün Ekleme
        public int ÜrünEkle(Ürünler ürün)
        {
            int sonuc = 0;

            SqlConnection baglanti = new SqlConnection(baglan.conString);
            SqlCommand sorgula = new SqlCommand("insert into Kategori (KategoriAdı,Açıklama) values(@KategoriId,@Açıklama)", baglanti);
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                sorgula.Parameters.AddWithValue("@KategoriId", SqlDbType.VarChar).Value = ürün._KategoriAd;
                sorgula.Parameters.AddWithValue("@Açıklama", SqlDbType.VarChar).Value = ürün._Açıklama;
               

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

        //ürün güncelleme işlemi
        public int ÜrünGüncelle(Ürünler ürün)
        {
            int sonuc = 0;

            SqlConnection baglanti = new SqlConnection(baglan.conString);
            SqlCommand sorgula = new SqlCommand("Update Kategori set KategoriAdı=@KategoriAdı,Açıklama=@Açıklama where Id=@KategoriId ", baglanti);
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                sorgula.Parameters.AddWithValue("@KategoriAdı", SqlDbType.VarChar).Value = ürün._KategoriAd;
                sorgula.Parameters.AddWithValue("@Açıklama", SqlDbType.VarChar).Value = ürün._Açıklama;
                sorgula.Parameters.AddWithValue("@KategoriId", SqlDbType.Int).Value = ürün.UrunTurId;
              

                sonuc = Convert.ToInt32(sorgula.ExecuteNonQuery());

            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }
            finally
            {
                baglanti.Dispose();
                baglanti.Close();
            }
            return sonuc;

        }
        //Ürünlei kategoriye göre sil
        public int ÜrünKategoriSil(int Id)
        {
            int sonuc = 0;

            SqlConnection baglanti = new SqlConnection(baglan.conString);
            SqlCommand sorgula = new SqlCommand("Update Kategori set Durum=1 where Id=@KategoriId ", baglanti);
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
               
                sorgula.Parameters.AddWithValue("@KategoriId", SqlDbType.Int).Value = Id;


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

        //Kategoriye göre override işlemi
        public override string ToString()
        {
            return TurAd;
        }
    }
}
