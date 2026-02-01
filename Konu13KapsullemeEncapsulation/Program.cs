namespace Konu13KapsullemeEncapsulation
{
    internal class Bolum
    {
        private string BolumAdi; // dışarıdan erişime kapalı değişkenimiz
        public string GetBolumAdi() // dışarıya string veri gönderen metot
        {
            return BolumAdi; // GetBolumAdi çağırılınca BolumAdi değişken değerini yolla 
        }
        public void SetBolumAdi(string istenenEğitim)
        {
            if (istenenEğitim == "Yazılım Eğitimi")
            {
                BolumAdi = istenenEğitim; // mutator (setter) seçilen eğitime izin verildi
            }
            else
            {
                Console.WriteLine("Kurumumuzda Bu Eğitim Verilmemektedir!");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu13 Kapsulleme Encapsulation");
            Console.WriteLine("Metot ile Kapsülleme");
            Console.WriteLine("Hangi alanda eğitim almak istersiniz?");
            Bolum bolum = new Bolum(); // Bölüm classından bölüm adında bir nesne üret
            var bolumAdi = Console.ReadLine(); // ekrandan girilecek değeri oku
            bolum.SetBolumAdi(bolumAdi); //girilen değeri bölüm nesnesindeki set moduna gönder
            Console.WriteLine("Bölüm: " + bolum.GetBolumAdi()); // bölüm nesnesindeki metotla private değişkenin değerini oku

            Console.WriteLine();

            //property ile kapsülleme
            Console.WriteLine("property ile kapsülleme");
            Fakulte fakulteNesnesi = new Fakulte();
            fakulteNesnesi.Bolum = bolumAdi;
            Console.WriteLine("Fakülte Bolum: " + fakulteNesnesi.Bolum); // veri okuma: get bloğunu çalıştırır.
        }   
    }
    public class Fakulte
    {
            private string bolum;
            public string Bolum
            {
                get { return bolum; }
                set
                {
                    if (value == "Yazılım Eğitimi") // eğer gönderilen değer yazılım eğitimi ise
                    {
                        bolum = value; // property e değer atamasına izin ver
                    }
                    else
                    {
                        Console.WriteLine("Kurumumuzda bu eğitim verilmemektedir!");
                    }
                }
            }
        }
    }
