using System.Collections; // koleksiyonları kullanabilmek için gerekli olan kütüphane
using System.Collections.Generic;
using System.Collections.Specialized;

namespace Konu16CollectKoleksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu16CollectKoleksiyonlar");
            //Ornek1();
            //Ornek2();
            //Ornek3();
            //Ornek4();
            //Ornek5();
            ListKullanimi();
        }
        static void Ornek1()
        {
            ArrayList arrayList = new();
            arrayList.Add(1);
            arrayList.Add("iki");
            arrayList.Add(3.0);
            arrayList.Add(true);
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("ArrayList ilk eleman: " + arrayList[0]); //listede index verdiğimiz elemana ulaşım
        }
        static void Ornek2()
        {
            ArrayList arrayList = new();
            arrayList.Add("İstanbul");
            arrayList.Add("Ankara");
            arrayList.Add("İzmir");
            arrayList.Add("Sivas");
            arrayList.Add("Çankırı");
            arrayList.Add("Zonguldak");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine("Arraylist de sıralama yapabiliriz");

            arrayList.Sort(); // a-z sıralama

            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            arrayList.Reverse(); // tersten sıralama
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
        static void Ornek3()
        {
            var strings = new StringCollection();
            strings.Add("İstanbul");
            strings.Add("Ankara");
            strings.Add("Bursa");
            // strings.Add(34); //StringsCollectiona sadece string veriler eklenebilir
            Console.WriteLine("StringsCollection");
            foreach (var item in strings)
            {
                Console.WriteLine(item);
            }
        }
        static void Ornek4()
        {
            var dictionary = new StringDictionary(); // key value şeklinde veri saklayabilir
            dictionary.Add("18", "Çankırı");
            dictionary.Add("06", "Ankara");
            dictionary.Add("34", "İstanbul");
            dictionary.Add("01", "Adana");
            dictionary.Add("58", "Sivas");
            Console.WriteLine();
            foreach (var item in dictionary)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("dictionary.Keys:");
            foreach (var item in dictionary.Keys)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("dictionary.Values:");
            foreach (var item in dictionary.Values)
            {
                Console.WriteLine(item);
            }           
        }
        static void Ornek5()
        {
            Dictionary<string, string> dicitionary = new(); // hangi veri tipinden oluşacağını bizim belirleyebildiğimiz liste asistanı
            dicitionary.Add("book", "kitap");
            dicitionary.Add("18", "Çankırı");
            dicitionary.Add("34", "İstanbul");
            Console.WriteLine(dicitionary["book"]);

            Console.WriteLine();

            Dictionary<int, string> dicitionary2 = new();
            dicitionary2.Add(1, "Adana");
            dicitionary2.Add(18, "Çankırı");
            dicitionary2.Add(34, "İstanbul");

            Console.WriteLine("dictionary2 Value: ");

            foreach (var item in dicitionary2)
            {
                Console.WriteLine(item.Value);
            }

            Console.WriteLine();

            Console.WriteLine("dictionary2 Keys: ");

            foreach (var item in dicitionary2)
            {
                Console.WriteLine(item.Key);
            }
         }
        static void ListKullanimi()
        {
            Console.WriteLine("ListKullanimi");
            List<string> sehirler = new(); //string veri tipi alabile bir liste
            sehirler.Add("Ankara");
            sehirler.Add("İstanbul");
            sehirler.Add("Kocaeli");
            sehirler.Add("Sivas 58");
            sehirler.Add("Çankırı");
            // sehirler.Add(18); // List <string> dediğimiz için string dışında listeye ekleme yapamayız
            Console.WriteLine("Şehirler:");
            foreach (var item in sehirler)  // şehirler isimli listde dön
            {
                Console.WriteLine(item); // listedeki her nesneyi ekrana yaz
            }
            Console.WriteLine();


            List<User> users = new();
            users.Add(new User
            {
                Id = 1,
                Name = "Mümtaz",
                Email = "mumtaz",
                Password = "123",
            });
            users.Add(new User
            {
                Id = 2,
                Name = "Çoban",
                Email = "coban",
                Password = "123",
            });
            Console.WriteLine("Kullanicilar:");
            foreach (var item in users)
            {
                Console.WriteLine(item.Name + " " + item.Password);
            }
            Console.WriteLine();
            List<User> kullanicilar = new()
            {
                new User
                {
                    Id = 3,
                    Name = "Ceza",
                    Email = "ceza",
                    Password = "222",
                },
            new User
                {
                    Id = 3,
                    Name = "Sago",
                    Email = "sago",
                    Password = "111",
                }
            };
            Console.WriteLine("Kullanicilar 2: ");
            foreach (var item in kullanicilar)
            {
                Console.WriteLine(item.Name + " " + item.Password);
            }
            Console.WriteLine();
            var yeniKullanici = new User
            {
                Id = 5,
                Name = "Aslan",
                Password = "000",
            };
            Console.WriteLine("Kullanıcılar listesinde yeniKullanici var mı ? :");
            var varmi = kullanicilar.Contains(yeniKullanici); // Contains metoduyla bir listede arama yapabiliriz
            Console.WriteLine("varmi ? " + varmi);
            kullanicilar.Add(yeniKullanici);
            Console.WriteLine("şimdi varmi? " + kullanicilar.Contains(yeniKullanici));
            Console.WriteLine();
            Console.WriteLine("Kullanicilar 3: ");
            foreach (var item in kullanicilar)
            {
                Console.WriteLine(item.Name + " " + item.Password);
            }
            Console.WriteLine();
            kullanicilar.AddRange(users); //AddRange metodu listeye çoklu kayıt eklememizi sağlar.
            kullanicilar.Insert(0, yeniKullanici); // Insert metodu listeye verdiğimiz indexe ekleme yapmamızı sağlar.
            Console.WriteLine();
            Console.WriteLine("Kullanicilar 4: ");
            foreach (var item in kullanicilar)
            {
                Console.WriteLine(item.Name + " " + item.Password);
            }
            Console.WriteLine();
            Console.WriteLine("Listedeki kayıt sayısı: " + kullanicilar.Count); //Count listedeki eleman sayısını getirir.
        }
     }
}
