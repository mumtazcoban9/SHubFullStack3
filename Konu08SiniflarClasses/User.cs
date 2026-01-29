using System;
using System.Collections.Generic;
using System.Text;

namespace Konu08SiniflarClasses
{
    internal class User
    {
        // classlarda property kullanımı
        // propertyler değişken ve metotların karışımı gibi çalışır
        // değişken gibi değer taşımak için de metot gibi de kullanılabilir
        // property oluşturmak için prop yazıp tab tuşuna basarak kısayol kullanabiliriz.
        public int Id { get; set; } // prop + tab 
        public string Name { get; set; } // user classından oluşturduğumuz nesne üzerinden buradaki propertylere değer ataması yaparsak set bloğu,  değer okuması yaparsak get bloğu çalışır
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Username { get; set; }
        public DateTime CreateDate{ get; set; }
        public bool KullaniciGiris(string kullaniciAdi, string sifre)
        {
            if (kullaniciAdi == "admin" && sifre == "adm123") 
            {
                return true;
            }
                return false;
        }
    }
}
