using System.Collections.Concurrent;

namespace Konu02TipDonusumleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("konu 02 Tip Donusumleri");
            // Implicit Casting - Otomatik Dönüşüm
            // Explicit Casting - Manuel dönüşüm
            Console.WriteLine("Implicit Casting - Otomatik Dönüşüm");
            Console.WriteLine("Imlicit Casting de daha küçük boyutlu bir türü daha büyük bir boyut türüne geçirirken dönüşüm otomatik olarak yapılır");
            int sayi = 18;
            double kesirliSayi = sayi; //int türündeki değeri douuble taşıyabilir.
            Console.WriteLine("sayi değeri");
            Console.WriteLine(sayi);
            Console.WriteLine("kesirliayi değeri");
            Console.WriteLine(kesirliSayi);

            Console.WriteLine();
            Console.WriteLine("Explicit Casting - Manuel Dönüşüm");
            double kesirliSayi2 = 18;
            int tamsayi = (int)kesirliSayi2;
            Console.WriteLine("kesirliSayi2:");
            Console.WriteLine(kesirliSayi2);
            Console.WriteLine("tamsayi:");
            Console.WriteLine(tamsayi);
            Console.WriteLine();

            Console.WriteLine("Diğer Tür Dönüştürme Yöntemleri");
            int tamSayi2 = 10;
            double kesirliSayi3 = 5.25;
            bool islemSonuc = true;

            Console.WriteLine("Lütfen Bir Sayı Giriniz");
            var girilenDeger = Console.ReadLine();
            Console.WriteLine("girilen degerin veri tipi.");
            Console.WriteLine(girilenDeger.GetType());

            var parsayi = int.Parse(girilenDeger);//int.Parse metodu kendisine verilen string değerin tırnaklarını kaldırarak int tipine çevirir.
            Console.WriteLine(parsayi + tamsayi);
            Console.WriteLine(double.Parse(girilenDeger) + kesirliSayi3);
            Console.WriteLine(decimal.Parse(girilenDeger) + tamSayi2);
            Console.WriteLine();

            Console.WriteLine("Convert sınıfı metotlarıyla tip dönüştürme");
            Console.WriteLine(tamSayi2.GetType());//tamsayi2 nin veri tipini yazdır
            Console.WriteLine(Convert.ToString(tamSayi2).GetType());//tam sayi2 yi stirnge çevir ve tipini doğrulamak için ekrana yazdır.
            Console.WriteLine(Convert.ToDouble(tamSayi2).GetType());
            Console.WriteLine(Convert.ToInt32(kesirliSayi3).GetType());
            Console.WriteLine(Convert.ToString(islemSonuc).GetType());

            object nesne = "123456";
            Console.WriteLine("nesnenin veri tipi:" + nesne.GetType());
            nesne = Convert.ToDecimal(nesne); // nesne decimal e çevrildi
            Console.WriteLine("nesnenin veri tipi:" + nesne.GetType());
            Console.WriteLine("nesnenin degeri:" + nesne);

        }
    }
}
