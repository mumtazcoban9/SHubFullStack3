namespace Konu08SiniflarClasses
{
    internal class Ev // sınıf tanımlama
    {
        internal string sokakAdi;
        internal int kapiNo;
    }
    /*
            Erişim belirteçleri 4 ana sınıfa ayrılır
        public      : Erişim kısıtı yoktur, her yerden erişilebilir.
        protected   : Ait olduğu sınıftan ve o sınıftan türetilen sınıflardan erişilebilir
        internal    : Etkin projeye ait sınıflardan erişilebilir, onlar dışında erişilemez
        private     : Yalnız bulunduğu sınıftan erişilebilir, dıştaki sınıflardan erişilemez
     */
    public class deneme
    {
        public string UrunAdi = "public öğeye herkes ulaşabilir";
        protected class test
        {
            string UrunAdi;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu08SiniflarClasses");
            #region Örnek1
            Ev ilkEv = new Ev(); // soyut bir yapı olan ev sınıfından somut bir nesne oluşturduk
            ilkEv.sokakAdi = "Pınar sk.";
            ilkEv.kapiNo = 10;

            Console.WriteLine("ilkEv sokakAdi: " + ilkEv.sokakAdi);
            Console.WriteLine("ilkEv kapiNo: " + ilkEv.kapiNo);

            Console.WriteLine();

            Ev yazlikEv = new Ev();

            yazlikEv.sokakAdi = "Deniz Sk.";
            yazlikEv.kapiNo = 18;

            Console.WriteLine("yazlikEv sokakAdi: " + yazlikEv.sokakAdi);
            Console.WriteLine("yazlikEv kapiNo: " + yazlikEv.kapiNo);

            Console.WriteLine();

            Ev koyEvi = new()
            {
                kapiNo = 25,
                sokakAdi = "Maho ağa sokak."
            };

            Console.WriteLine("koyEvi sokakAdi: " + koyEvi.sokakAdi);
            Console.WriteLine("koyEvi kapiNo: " + koyEvi.kapiNo);

            Console.WriteLine();
            #endregion

            #region Örnek2
            Kullanici kullanici = new()
            {
                Adi = "Murat",
                Soyadi = "Yılmaz",
                KullaniciAdi = "murt",
                Sifre = "m123",
                Id = 1
            };
            Console.WriteLine("Kullanici adınız:");
            var kullaniciAdi = Console.ReadLine();
            Console.WriteLine("Şifreniz:");
            var sifre = Console.ReadLine();

            if (kullaniciAdi == kullanici.KullaniciAdi && sifre == kullanici.Sifre)
            {
                //sisteme giriş yap
                Console.WriteLine($"Hoşgeldin {kullanici.Adi} {kullanici.Soyadi}");
            }
            else
            {
                Console.WriteLine("Giriş Başarısız!");
            }
            #endregion

            #region Örnek3

            Araba araba = new()
            {
                Id = 1,
                Marka = "Togg",
                KasaTipi = "Suv",
                Renk = "Kırmızı",
                Model = "T10x",
                ModelYili = 2025,
            };

            Araba araba2 = new()
            {
                Id = 2,
                Marka = "Togg",
                KasaTipi = "Sedan",
                Model = "T10f",
                Renk = "Beyaz",
                ModelYili = 2023
            };
            #endregion

            #region Örnek4
            Kategori kategori = new()
            {
                Id = 3,
                KategoriAdi = "Elektronik"
            };
            Kategori kategori2 = new()
            {
                Id = 4,
                KategoriAdi = "Bilgisayar"
            };
            Kategori kategori3 = new()
            {
                Id = 5,
                KategoriAdi = "Telefon"
            };
            Console.WriteLine();
            Console.WriteLine($"Anasayfa Hakkımızda {kategori.KategoriAdi} {kategori2.KategoriAdi} {kategori3.KategoriAdi} İletişim");

            #endregion

            #region Örnek 5
            SinifMetotKullanimi metotKullanimi = new();//SiniftaMetotKullanımı classsından metotKullanimi adında bir nesne oluşturduk.
            var sonuc = metotKullanimi.LoginKontrol(kullaniciAdi,sifre);//metot kullanimi nesnesinin içindeki LoginKontrol metoduna istediği parametreleri vererek oradan dönecek bool değeri sonuç değişkenine atadık.
            if (sonuc == true)//eğer sonuç değişkenine gelen değer true ise
            {
                Console.WriteLine("giriş başarılı");
                Console.WriteLine("hoşgeldin ağam");
            }
            else //sonuç değişkenine gelen değer false ise
                Console.WriteLine("Giriş başarısız");

            var toplamasonucu = metotKullanimi.ToplamaYap(10,5);
            Console.WriteLine("toplamasonucu:" + toplamasonucu);

            Console.WriteLine();

            Console.WriteLine("Statik değişken: " + SinifMetotKullanimi.StatikDegisken);//StatikDegisken in değerine ulaşmak için direkt sınıfadı.StatikDegisken şeklinde ulaşıyoruz.
            Console.WriteLine("Dinamik değişken: " + metotKullanimi.DinamikDegisken);
            #endregion

            #region Örnek 6
            User user = new()
            {
                Id = 1,
                CreateDate = DateTime.Now,
                Name = "Test",
                Email = "Test@deneme.co",
                Password = sifre,
                Phone = "Test",
                Username = kullaniciAdi,
            };
            Console.WriteLine();
            var kullaniciGirisSonuc = user.KullaniciGiris(user.Username, user.Password);
            Console.WriteLine("kullanici Giris Sonuc: " + kullaniciGirisSonuc);
            #endregion
        }
    }
    class Kullanici
    {
        internal int Id;
        internal string KullaniciAdi;
        internal string Sifre;
        internal string Email;
        internal string Adi;
        internal string Soyadi;
    }
    class Araba
    {
        internal int Id;
        internal string Marka;
        internal string Model;
        internal string KasaTipi;
        internal string YakitTipi;
        internal string VitesTipi;
        internal string Renk;
        internal int ModelYili;
    }
}
