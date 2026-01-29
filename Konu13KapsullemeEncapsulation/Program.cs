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
            Bolum bolum = new Bolum();
            Console.WriteLine("Hangi alanda eğitim almak istersiniz?");
            var bolumAdi = Console.ReadLine();
            bolum.SetBolumAdi(bolumAdi);
            Console.WriteLine("Bölüm: " + bolum.GetBolumAdi());
        }
    }
}
