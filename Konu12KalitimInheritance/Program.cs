namespace Konu12KalitimInheritance
{
    class Arac
    {
        public int Id { get; set; }
        public string AracTuru;
        public void KornaCal()
        {
            Console.WriteLine("Kornaya Basıldı!");
        }
    }
    class Otomobil : Arac // iki nokra üst üste araç dediğimizde araç sınıfındaki içerikler otomobil sınıfında kullanılabilir.
    {
        public string Marka { get; set; }
        public string Model { get; set; }
    }
    class Test : Otomobil
    {
        public int MyProperty { get; set; }
    }

    class Tren : Arac
    {
        public int VagonSayisi { get; set; }
    }

    class Otobüs : Arac
    {
        public int KoltukSayisi { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu12KalitimInheritance");
            Arac arac = new Arac();
            arac.AracTuru = "Otomobil";
            arac.KornaCal();

            Otomobil otomobil = new Otomobil();
            otomobil.AracTuru = "Otomobil"; // bu değişken arac sınıfından geliyor
            otomobil.KornaCal();
            otomobil.Marka = "Togg";
            otomobil.Model = "T10x";
            Console.WriteLine("otomobil.AracTuru: " + otomobil.AracTuru);

            Kategori kategori = new()
            {
                Id = 1,
                Name = "Elektronik",
                UstMenudeGoster = true,
            };
            if (kategori.UstMenudeGoster == true)
            {
                Console.WriteLine("Kategori Adı:" + kategori.Name);
            }

            Console.WriteLine();

            Ürün urun = new()
            {
                Id = 1,
                Name = "Klavye",
                Fiyat = 999,
                Kdv = 20,
            };

            Console.WriteLine("Ürün Bilgileri");
            Console.WriteLine("Ürün Adı: " + urun.Name);
            Console.WriteLine("Ürün Fiyatı: " + urun.Fiyat);
            Console.WriteLine("Kdv: %" + urun.Kdv);
            decimal KdvOrani = 0.20m;
            decimal KdvTutari = urun.Fiyat * KdvOrani;
            decimal toplamFiyat = urun.Fiyat + KdvTutari;
            Console.WriteLine("Kdv Tutarı: " + KdvTutari + "TL");
            Console.WriteLine("Toplam Tutar: " + toplamFiyat + "TL");

            Console.WriteLine();

            Cizici[] birCizici = new Cizici[4];
            birCizici[0] = new DogruCiz();
            birCizici[1] = new DaireCiz();
            birCizici[2] = new KareCiz();
            birCizici[3] = new Cizici();

            foreach (var item in birCizici)
            {
                item.Ciz();
            }
        }
    }
    // Polimorfizm - Çok Biçimlilik
    public class Cizici
    {
        public virtual void Ciz() // virtual keywordü ile bu metodu override-ezilebilir hale getiriyoruz.
        {
            Console.WriteLine("Cizici");
        }
    }
    public class DogruCiz : Cizici
    {
        public override void Ciz()
        {
            Console.WriteLine("Düz Çizgi");
        }
    }
    public class DaireCiz : Cizici
    {
        public override void Ciz()
        {
            Console.WriteLine("Daire Çizgi");
        }
    }
    public class KareCiz : Cizici
    {
        public override void Ciz()
        {
            Console.WriteLine("Kare Çizgi");
        }
    }
}
