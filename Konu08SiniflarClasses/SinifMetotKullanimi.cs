using System;
using System.Collections.Generic;
using System.Text;

namespace Konu08SiniflarClasses
{
    internal class SinifMetotKullanimi
    {
        string kurucuMetot;
        public SinifMetotKullanimi() // ctor yazıp tab'e basarak method-constructor oluşturuyoruz.
        {
            Console.WriteLine();
            kurucuMetot = "Sınuflarda constructor (kurucu metot) özelliği vardır ve bu metotlar sınıftan bir nesne oluşturulduğunda otomatik olarak çalışır ve içerisindeki kodları çalıştırır. ";
            Console.WriteLine(kurucuMetot);
            Console.WriteLine();
        }
        public bool LoginKontrol(string kullaniciAdi, string sifre)
        {
            if (kullaniciAdi == "admin" && sifre == "adm123")
            {
                return true;
            }
            return false;
        }
        public int ToplamaYap(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        public static string StatikDegisken = "Sınıfta Statik Degisken Kullanımı";
        public string DinamikDegisken = "Dinamik Degisken";
    }
}
