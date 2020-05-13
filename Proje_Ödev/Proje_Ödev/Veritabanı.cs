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
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Proje_Ödev
{
    class Veritabanı
    {
        public string conString = ("Data Source=KAKTUS;Initial Catalog=Restaurant;Integrated Security=True");//Veritabanı bağlantı noktası
     
        //Genel alanlar
        public static int _PersonelId;
        public static int _GörevId;
        public static int _MüsteriEkle;
        public static int _MüşteriId;
        public static string _ButtonDeğer;
        public static string _Buttonİsim;
        public static int _ServisTurNo;
        public static string _AdisyonId;

    }
}
