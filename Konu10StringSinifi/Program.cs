namespace Konu10StringSinifi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu10StringSinifi");
            string degisken;
            char karakter = 'a';
            string metinlericin = "yanyana karakterlerden oluşan metin";
            //Ornek1();
            //StringMetotlari();
            SplitMetodu();
        }
        static void Ornek1()
        {
            string birMetin = "Ankra başkenttir";
            String birsayi = "123456789";
            System.String birTarih = "21.01.2026";
            string kod = "//5456dfgd\n"; //buradaki \n kodu enter görevi görür ve kendisinden sonra gelecek olan metni bir alt satıra kaydırır.
            Console.WriteLine(birMetin.GetType());
            Console.WriteLine(birsayi.GetType());
            Console.WriteLine(birTarih.GetType());
            Console.WriteLine(kod);

            string s = "Barış Manço";
            Console.WriteLine(s);
            Console.WriteLine("For Döngüsü");
            for (int i = 0; i < s.Length; i++) // s değişkeninin uzunluğu kadar dön
            {
                Console.WriteLine(s[i]); // s değişkeninin 1. indexindeki değeri yazdır.
            }
            Console.WriteLine();
            Console.WriteLine("For Döngüsü");
            foreach (var item in s)
            {
                Console.WriteLine(item);
            }
        }
        static void StringMetotlari()
        {
            string metin = "Stringin Birçok Metodu Vardır";
            Console.WriteLine(metin);
            Console.WriteLine("metin in karakter sayısı : metin.Length " + metin.Length);
            Console.WriteLine();

            var klon = metin.Clone(); // Clone metodu metin değişkenini klonlayıp klon değişkenşne atar.
            Console.WriteLine("metin klonu: " + klon);

            Console.WriteLine();

            metin = "My Name is Ali";
            Console.WriteLine(metin + "EndWith i" + metin.EndsWith("i"));
            Console.WriteLine(metin + "EndWith r" + metin.EndsWith("r"));

            Console.WriteLine();

            Console.WriteLine(metin + "StartsWith s" + metin.StartsWith("s"));
            Console.WriteLine(metin + "StartsWith m" + metin.StartsWith("m"));
            Console.WriteLine(metin + "StartsWith M" + metin.StartsWith("M"));

            Console.WriteLine();

            Console.WriteLine(metin + "IndexOf name: " + metin.IndexOf("name"));
            Console.WriteLine(metin + "IndexOf Name: " + metin.IndexOf("Name"));
            Console.WriteLine(metin + "LastIndexOf i: " + metin.LastIndexOf("i"));

            Console.WriteLine();

            Console.WriteLine(metin + "Insert Merhaba: " + metin.Insert(0, "Merhaba : "));
            Console.WriteLine(metin);

            Console.WriteLine();

            Console.WriteLine("Substring" + metin.Substring(2)); ;
            Console.WriteLine("Substring" + metin.Substring(2, 5)); //2. indexten başlayarak 5 karakter

            Console.WriteLine();

            Console.WriteLine("metin.ToLower: " + metin.ToLower()); //metni büyük harf yapar
            Console.WriteLine("metin.ToUpper: " + metin.ToUpper()); //metni küçük harf yapar
            Console.WriteLine("metin.ToLower Replace: " + metin.ToLower(). Replace(" ", "-")); //Metni küçük harfe .evir ve boşlukları - ile değiştir.
            Console.WriteLine("metin.Remove 2: " + metin.Remove(2));
            Console.WriteLine("metin.Remove 2, 5: " + metin.Remove(2, 5));
        }
        static void SplitMetodu()
        {
            string sehirler = "İstanbul,Ankara,İzmir,Sivas,Çankırı";
            Console.WriteLine(sehirler);
            string[] sehirlerArray = sehirler.Split(','); //Split verilen karaktere göre metni parçalar
            Console.WriteLine("4. Şehir: " + sehirlerArray[3]);
            foreach (var item in sehirlerArray)
            {
                Console.WriteLine("Şehir: " + item); 
            }
        }
    }
}