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
            Ornek3();
        }
        static void Ornek1()
        {
            ArrayList arrayList = new ();
            arrayList.Add (1);
            arrayList.Add ("iki");
            arrayList.Add (3.0);
            arrayList.Add (true);
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
            arrayList.Add ("İstanbul");
            arrayList.Add ("Ankara");
            arrayList.Add ("İzmir");
            arrayList.Add ("Sivas");
            arrayList.Add ("Çankırı");
            arrayList.Add ("Zonguldak");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine("Arraylist de sıralama yapabiliriz");

            arrayList.Sort (); // a-z sıralama

            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            arrayList.Reverse (); // tersten sıralama
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
        public static void Ornek3()
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
    }
}
