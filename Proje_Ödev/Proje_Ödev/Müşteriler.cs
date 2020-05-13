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
    class Müşteriler
    {
        Veritabanı baglan = new Veritabanı();//Veritabanı bağlantı nesnesi

        //Alanlar(Fields)
        private int _MüşteriId;
        private string _MüşteriAd;
        private string _MüşteriSoyad;
        private string _Telefon;
        private string _Adres;
        private string _Email;

        //Properties(Özellikler)
        public int MüşteriId
        {
            get { return _MüşteriId; }
            set { _MüşteriId = value; }
        }
        public string MüşteriAd
        {
            get { return _MüşteriAd; }
            set { _MüşteriAd = value; }
        }
        public string MüşteriSoyad
        {
            get { return _MüşteriSoyad; }
            set { _MüşteriSoyad = value; }
        }
        public string Telefon
        {
            get { return _Telefon; }
            set { _Telefon = value; }
        }
        public string Adres
        {
            get { return _Adres; }
            set { _Adres = value; }
        }
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }

        //Müşteri  var mı yok mu sorgulama işlemi
        public bool MüşteriAra(string telefon)
        {
            bool sonuc = false;
          
            SqlConnection baglanti = new SqlConnection(baglan.conString);
            SqlCommand sorgula = new SqlCommand();
            sorgula.Connection = baglanti;
            sorgula.CommandText = "MüşteriAra";
            sorgula.CommandType = CommandType.StoredProcedure;
            sorgula.Parameters.AddWithValue("@Telefon", SqlDbType.VarChar).Value = telefon;
            sorgula.Parameters.AddWithValue("@Sonuç", SqlDbType.Int);
            sorgula.Parameters["@Sonuç"].Direction = ParameterDirection.Output;

            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }

            try
            {
                sorgula.ExecuteNonQuery();
                sonuc = Convert.ToBoolean(sorgula.Parameters["@Sonuç"].Value);
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

        //Yeni müşteri ekleme
        public int MüşteriEkle(Müşteriler müsteri)
        {
            int sonuc = 0;
           
            SqlConnection baglanti = new SqlConnection(baglan.conString);
            SqlCommand sorgula = new SqlCommand("insert into Müşteri (Ad,Soyad,Adres,Telefon,EMail) values(@Ad,@Soyad,@Adres,@Telefon,@EMail); Select SCOPE_IDENTITY()", baglanti);
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                sorgula.Parameters.AddWithValue("@Ad", SqlDbType.VarChar).Value = müsteri._MüşteriAd;
                sorgula.Parameters.AddWithValue("@Soyad", SqlDbType.VarChar).Value = müsteri._MüşteriSoyad;
                sorgula.Parameters.AddWithValue("@Adres", SqlDbType.VarChar).Value = müsteri._Adres;
                sorgula.Parameters.AddWithValue("@Telefon", SqlDbType.VarChar).Value = müsteri._Telefon;
                sorgula.Parameters.AddWithValue("@EMail", SqlDbType.VarChar).Value = müsteri._Email;
                sonuc = Convert.ToInt32(sorgula.ExecuteScalar());

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

        //Müşteri Güncelleme işlemi
        public bool MüşteriGüncelle(Müşteriler müsteri)
        {
            bool sonuc = false;

            SqlConnection baglanti = new SqlConnection(baglan.conString);
            SqlCommand sorgula = new SqlCommand("Update Müşteri set Ad=@Ad,Soyad=@Soyad,Adres=@Adres,Telefon=@Telefon,EMail=@EMail where Id=@MüşteriId ", baglanti);
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                sorgula.Parameters.AddWithValue("@Ad", SqlDbType.VarChar).Value = müsteri._MüşteriAd;
                sorgula.Parameters.AddWithValue("@Soyad", SqlDbType.VarChar).Value = müsteri._MüşteriSoyad;
                sorgula.Parameters.AddWithValue("@Adres", SqlDbType.VarChar).Value = müsteri._Adres;
                sorgula.Parameters.AddWithValue("@Telefon", SqlDbType.VarChar).Value = müsteri._Telefon;
                sorgula.Parameters.AddWithValue("@EMail", SqlDbType.VarChar).Value = müsteri._Email;
                sorgula.Parameters.AddWithValue("@MüşteriId", SqlDbType.VarChar).Value = müsteri._MüşteriId;
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
        //Müşteri listesini alma
        public void MüşteriListele(ListView list)
        {

            list.Items.Clear();
            SqlConnection baglanti = new SqlConnection(baglan.conString);
            SqlCommand sorgula = new SqlCommand("Select * from Müşteri", baglanti);
            SqlDataReader dr = null;

            try
            {
                if (baglanti.State == ConnectionState.Closed)
                
                    baglanti.Open();
                    dr=sorgula.ExecuteReader();
                    int sayac = 0;
                    while(dr.Read())
                    {
                        list.Items.Add(dr["Id"].ToString());
                        list.Items[sayac].SubItems.Add(dr["Ad"].ToString());
                        list.Items[sayac].SubItems.Add(dr["Soyad"].ToString());
                        list.Items[sayac].SubItems.Add(dr["Telefon"].ToString());
                        list.Items[sayac].SubItems.Add(dr["Adres"].ToString());
                        list.Items[sayac].SubItems.Add(dr["EMail"].ToString());
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
        //Müşteri bilgilerini getirme
        public void MüşteriGetir(int MüşteriId,TextBox ad, TextBox soyad, TextBox telefon, TextBox adres, TextBox email)
        {
            SqlConnection baglanti = new SqlConnection(baglan.conString);
            SqlCommand sorgula = new SqlCommand("Select * from Müşteri where Id=@MüşteriId", baglanti);
            SqlDataReader dr = null;
            sorgula.Parameters.AddWithValue("MüşteriId", SqlDbType.Int).Value = MüşteriId;
            try
            {
                if (baglanti.State == ConnectionState.Closed)

                   baglanti.Open();
                dr = sorgula.ExecuteReader();
               
                while (dr.Read())
                {

                    ad.Text = dr["Ad"].ToString();
                    soyad.Text = dr["Soyad"].ToString();
                    telefon.Text = dr["Telefon"].ToString();
                    adres.Text = dr["Adres"].ToString();
                    email.Text = dr["EMail"].ToString();
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

        //Müşteri ada göre arama yaptığında listviewe getirme
        public void MüşteriAdGetir(ListView list, string MüşteriAd)
        {
            list.Items.Clear();
            SqlConnection baglanti = new SqlConnection(baglan.conString);
            SqlCommand sorgula = new SqlCommand("Select * from Müşteri where Ad like @MüşteriAd + '%'", baglanti);
            SqlDataReader dr = null;
            sorgula.Parameters.AddWithValue("MüşteriAd", SqlDbType.VarChar).Value = MüşteriAd;
            try
            {
                if (baglanti.State == ConnectionState.Closed)

                    baglanti.Open();
                dr = sorgula.ExecuteReader();
                int sayac = 0;
                while (dr.Read())
                {
                    list.Items.Add(Convert.ToInt32( dr["Id"]).ToString());
                    list.Items[sayac].SubItems.Add(dr["Ad"].ToString());
                    list.Items[sayac].SubItems.Add(dr["Soyad"].ToString());
                    list.Items[sayac].SubItems.Add(dr["Telefon"].ToString());
                    list.Items[sayac].SubItems.Add(dr["Adres"].ToString());
                    list.Items[sayac].SubItems.Add(dr["EMail"].ToString());
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
        //Müşteri soyada göre arama yaptığında listviewe getirme
        public void MüşteriSoyadGetir(ListView list, string MüşteriSoyad)
        {
            list.Items.Clear();
            SqlConnection baglanti = new SqlConnection(baglan.conString);
            SqlCommand sorgula = new SqlCommand("Select * from Müşteri where Soyad like @MüşteriSoyad + '%'", baglanti);
            SqlDataReader dr = null;
            sorgula.Parameters.AddWithValue("MüşteriSoyad", SqlDbType.VarChar).Value = MüşteriSoyad;
            try
            {
                if (baglanti.State == ConnectionState.Closed)

                    baglanti.Open();
                dr = sorgula.ExecuteReader();
                int sayac = 0;
                while (dr.Read())
                {
                    list.Items.Add(Convert.ToInt32(dr["Id"]).ToString());
                    list.Items[sayac].SubItems.Add(dr["Ad"].ToString());
                    list.Items[sayac].SubItems.Add(dr["Soyad"].ToString());
                    list.Items[sayac].SubItems.Add(dr["Telefon"].ToString());
                    list.Items[sayac].SubItems.Add(dr["Adres"].ToString());
                    list.Items[sayac].SubItems.Add(dr["EMail"].ToString());
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
        //Müşteri telefona göre arama yaptığında listviewe getirme
        public void MüşteriTelefonGetir(ListView list, string Telefon)
        {
            list.Items.Clear();
            SqlConnection baglanti = new SqlConnection(baglan.conString);
            SqlCommand sorgula = new SqlCommand("Select * from Müşteri where Telefon like @Telefon + '%'", baglanti);
            SqlDataReader dr = null;
            sorgula.Parameters.AddWithValue("Telefon", SqlDbType.VarChar).Value = Telefon;
            try
            {
                if (baglanti.State == ConnectionState.Closed)

                    baglanti.Open();
                dr = sorgula.ExecuteReader();
                int sayac = 0;
                while (dr.Read())
                {
                    list.Items.Add(Convert.ToInt32(dr["Id"]).ToString());
                    list.Items[sayac].SubItems.Add(dr["Ad"].ToString());
                    list.Items[sayac].SubItems.Add(dr["Soyad"].ToString());
                    list.Items[sayac].SubItems.Add(dr["Telefon"].ToString());
                    list.Items[sayac].SubItems.Add(dr["Adres"].ToString());
                    list.Items[sayac].SubItems.Add(dr["EMail"].ToString());
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
