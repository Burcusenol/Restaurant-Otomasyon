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
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Proje_Ödev
{
    class Personel
    {
        Veritabanı baglan = new Veritabanı(); //Veritabanı bağlantı nesenesi oluşturma

        // Alanlar (Fields)
        private int _PersonelId;
        private int _PersonelGorevId;
        private string _PersonelAd;
        private string _PersonelSoyad;
        private string _PersonelSıfre;
        private string _PersonelKullanıcıAdı;
        private bool _PersonelDurum;

         // Özellikler (Properties)
        public int PersonelId
        {
            get { return _PersonelId; }
            set { _PersonelId = value;}
        }
        public int PersonelGorevId
        {
            get { return _PersonelGorevId; }
            set { _PersonelGorevId = value; }
        }
        public string PersonelAd
        {
            get { return _PersonelAd; }
            set { _PersonelAd = value; }
        }
        public string PersonelSoyad
        {
            get { return _PersonelSoyad; }
            set { _PersonelSoyad = value; }
        }
        public string PersonelSıfre
        {
            get { return _PersonelSıfre; }
            set { _PersonelSıfre = value; }
        }
        public string PersonelKullanıcıAdı
        {
            get { return _PersonelKullanıcıAdı; }
            set { _PersonelKullanıcıAdı = value; }
        }
        public bool PersonelDurum
        {
            get { return _PersonelDurum; }
            set { _PersonelDurum = value; }
        }

        //Personel giriş kontrolü 
        public bool PersonelEntryControl(string sıfre, int KullanıcıId)
        {
            bool result = false;
            SqlConnection baglanti = new SqlConnection(baglan.conString);
            SqlCommand sorgula = new SqlCommand("Select *from Personel where Id=@Id and Şifre=@Şifre", baglanti);
            sorgula.Parameters.AddWithValue("@Id", SqlDbType.VarChar).Value = KullanıcıId;
            sorgula.Parameters.AddWithValue("@Şifre", SqlDbType.VarChar).Value = sıfre;

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
            return result;
        }
        //Personel bilgilerini comboboxa getirme
        public void BilgileriGöster(ComboBox c)
        {
            c.Items.Clear();
            SqlConnection baglanti = new SqlConnection(baglan.conString);
            SqlCommand sorgula = new SqlCommand("Select *from Personel ", baglanti);
            
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
            SqlDataReader reader = sorgula.ExecuteReader();
            while (reader.Read())
            {
                Personel p = new Personel();
                p._PersonelId = Convert.ToInt32( reader["Id"].ToString());
                p._PersonelGorevId = Convert.ToInt32(reader["GörevId"].ToString());
                p._PersonelAd = Convert.ToString(reader["Ad"].ToString());
                p._PersonelSoyad = Convert.ToString(reader["Soyad"].ToString());
                p._PersonelSıfre = Convert.ToString(reader["Şifre"].ToString());
                p._PersonelKullanıcıAdı= Convert.ToString(reader["KullanıcıAdı"].ToString());
                p._PersonelDurum=Convert.ToBoolean(reader["Durum"]);
                c.Items.Add(p);
            }
            reader.Close();
            baglanti.Close();
        }
        //Override işlemi personel bilgisi
        public override string ToString()
        {
            return PersonelAd+" "+PersonelSoyad;
        }

        //Personel bilgiini Listviewe getirme
        public void PersonelBigileriGetir(ListView list)
        {
            list.Items.Clear();
            SqlConnection baglanti = new SqlConnection(baglan.conString);
            SqlCommand sorgula = new SqlCommand("Select Personel.*,Görev.Görev from Personel inner join Görev on Görev.Id=Personel.GörevId where Personel.Durum=0", baglanti);
          


            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            SqlDataReader dr = sorgula.ExecuteReader();
            int i = 0;
            while (dr.Read())
            {


                list.Items.Add(Convert.ToInt32(dr["Id"]).ToString());
                list.Items[i].SubItems.Add(dr["GörevId"].ToString());
                list.Items[i].SubItems.Add(dr["Görev"].ToString());
                list.Items[i].SubItems.Add(dr["Ad"].ToString());
                list.Items[i].SubItems.Add(dr["Soyad"].ToString());
                list.Items[i].SubItems.Add(dr["KullanıcıAdı"].ToString());
                i++;
             
            }
            dr.Close();
            baglanti.Close();
        }

        //Personel görev bilgisiyle personel bilgilerini eşleştir
        public void PersonelBigileriIdGetir(ListView list, int PersonelId)
        {
            list.Items.Clear();
            SqlConnection baglanti = new SqlConnection(baglan.conString);
            SqlCommand sorgula = new SqlCommand("Select Personel.*,Görev.Görev from Personel inner join Görev on Görev.Id=Personel.GörevId where Personel.Durum=0 and Personel.Id=@PersonelId", baglanti);
            sorgula.Parameters.AddWithValue("@PersonelId", SqlDbType.Int).Value = PersonelId;

            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            SqlDataReader dr = sorgula.ExecuteReader();
            int i = 0;
            while (dr.Read())
            {


                list.Items.Add(Convert.ToInt32(dr["Id"]).ToString());
                list.Items[i].SubItems.Add(dr["GörevId"].ToString());
                list.Items[i].SubItems.Add(dr["Görev"].ToString());
                list.Items[i].SubItems.Add(dr["Ad"].ToString());
                list.Items[i].SubItems.Add(dr["Soyad"].ToString());
                list.Items[i].SubItems.Add(dr["KullanıcıAdı"].ToString());
                i++;

            }
            dr.Close();
            baglanti.Close();
        }

        //Personel ad ve soyadını alma
        public string PersonelİsimBilgi(int PersonelId)
        {
            string sonuc = "";
            SqlConnection baglanti = new SqlConnection(baglan.conString);
            SqlCommand sorgula = new SqlCommand("Select Ad + Soyad from Personel where Personel.Durum=0 and Personel.Id=@PersonelId", baglanti);
            sorgula.Parameters.AddWithValue("@PersonelId", SqlDbType.Int).Value = PersonelId;

            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                sonuc = Convert.ToString( sorgula.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }

            baglanti.Close();
            return sonuc;
        }

        // Personel şifre değiştirme işlemi 
        public bool SifreDeğiştir(int PersonelId,string sifre)
        {
            bool sonuc = false;
            SqlConnection baglanti = new SqlConnection(baglan.conString);
            SqlCommand sorgula = new SqlCommand("Update Personel set Şifre=@sifre where Id=@PersonelId", baglanti);
            sorgula.Parameters.AddWithValue("@PersonelId", SqlDbType.Int).Value = PersonelId;
            sorgula.Parameters.AddWithValue("@sifre", SqlDbType.Int).Value = sifre; 
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                sonuc = Convert.ToBoolean(sorgula.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }

            baglanti.Close();
            return sonuc;
        }

        //Personel ekleme işlemi
        public bool PersonelEkle(Personel personel)
        {
            bool sonuc = false;
            SqlConnection baglanti = new SqlConnection(baglan.conString);
            SqlCommand sorgula = new SqlCommand("Insert into Personel (Ad,Soyad,Şifre,GörevId) values(@Ad,@Soyad,@Şifre,@GörevId)", baglanti);
            sorgula.Parameters.AddWithValue("@Ad", SqlDbType.VarChar).Value = personel._PersonelAd;
            sorgula.Parameters.AddWithValue("@Soyad", SqlDbType.VarChar).Value = personel._PersonelSoyad;
            sorgula.Parameters.AddWithValue("@Şifre", SqlDbType.VarChar).Value = personel._PersonelSıfre;
            sorgula.Parameters.AddWithValue("@GörevId", SqlDbType.Int).Value = personel._PersonelGorevId;
           
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                sonuc = Convert.ToBoolean(sorgula.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }

            baglanti.Close();
            return sonuc;
        }

        //Personel blgileri güncelleme işlemi 
        public bool PersonelGüncelle(Personel personel,int PersonelId)
        {
            bool sonuc = false;
            SqlConnection baglanti = new SqlConnection(baglan.conString);
            SqlCommand sorgula = new SqlCommand("Update Personel set Ad=@Ad,Soyad=@Soyad,Şifre=@Şifre,GörevId=@GörevId where Id=@PersonelId",baglanti);
            sorgula.Parameters.AddWithValue("@PersonelId", SqlDbType.Int).Value = PersonelId;
            sorgula.Parameters.AddWithValue("@Ad", SqlDbType.VarChar).Value = personel._PersonelAd;
            sorgula.Parameters.AddWithValue("@Soyad", SqlDbType.VarChar).Value = personel._PersonelSoyad;
            sorgula.Parameters.AddWithValue("@Şifre", SqlDbType.VarChar).Value = personel._PersonelSıfre;
            sorgula.Parameters.AddWithValue("@GörevId", SqlDbType.Int).Value = personel._PersonelGorevId;
            
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                sonuc = Convert.ToBoolean(sorgula.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }

            baglanti.Close();
            return sonuc;
        }

        //Personel kaydı silme işlemi
        public bool PersonelSil(int PersonelId)
        {
            bool sonuc = false;
            SqlConnection baglanti = new SqlConnection(baglan.conString);
            SqlCommand sorgula = new SqlCommand("Update Personel set Durum=1 where Id=@PersonelId", baglanti);
            sorgula.Parameters.AddWithValue("@PersonelId", SqlDbType.Int).Value = PersonelId;
          
           
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                sonuc = Convert.ToBoolean(sorgula.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }

            baglanti.Close();
            return sonuc;
        }
    }
}
