using System;

namespace Konu06Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu06Diziler");
            // Dizi oluşturma
            int[] sayi;
            int[] ogrenciler = new int[6]; // //ogrenciler isminde int veri tipi taşıyan ve 6 elemandan oluşan bir dizi oluşturduk. Dizi boyutu artmaz, azalmaz.

            // Dizilerde indis denilen bir yapı vardır ve içine eklencek elemanlar 0 dan başlar.
            ogrenciler[0] = 100;
            ogrenciler[1] = 200;
            ogrenciler[2] = 300;
            ogrenciler[3] = 400;
            ogrenciler[4] = 500;
            ogrenciler[5] = 500; //dizi değerleri aynı olabilir 
            //Dizideki değere ulaşma
            Console.WriteLine("ogrenciler[5]: " + ogrenciler[5]);
            ogrenciler[5] = 550; //dizideki elemanın değeri değştirilebilir
            Console.WriteLine("ogrenciler[5]: " + ogrenciler[5]);
            //ogrenciler[6] = 600;// 0 dahil olduğu için dizi 5 ile biter! sınırı aşarsak hata alırız;
            Console.WriteLine();
            string[] isimler = new string[5];
            isimler[0] = "Alp";
            isimler[1] = "Ali";
            isimler[2] = "Murat";
            isimler[3] = "Yılmaz";
            Console.WriteLine("isimler[2]: " + isimler[2]);
           
            Console.WriteLine();

            int[] ogrenciler2 = { 100, 200, 300, 400, 500 , };
            Console.WriteLine("ogrenciler2[3]: " + ogrenciler[3]);
            ogrenciler2[3] = 550;
            Console.WriteLine("ogrenciler2[3]: " + ogrenciler2[3]);

            Console.WriteLine();

            string[] kategoriler = { "Elektronik", "Bilgisayar", "Telefon", "Beyaz Eşya", "Kitap" };
            Console.WriteLine("kategoriler 1:" + kategoriler[1]);
            kategoriler[1] = "Mutfak Eşyaları";
            Console.WriteLine("kategoriler 1:" + kategoriler[1]);

            Console.WriteLine();
            string[] urunler = { "ürün 1", "ürün 2", "ürün 3" };
            Console.WriteLine("ürün 1: " + urunler[0]);
        }
    }
}
