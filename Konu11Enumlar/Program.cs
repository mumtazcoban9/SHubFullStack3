namespace Konu11Enumlar
{
    internal class Program
    {
        // Enum (numaratör)lar nesneleri numaralandırmak için kullanılır
        /*
         * Enum tipler üzerindeki kısıtlar
         * 1-Enum blogunda metot tanımlanamaz
         * 2-Arayüz(ınterface) kullanamazlar
         * 3-Enum blokunda property kullanılamaz
         * */
        enum Aylar : byte
        {
            Ocak = 1, Şubat, Mart, Nisan, Mayıs, Haziran, Temmuz, Ağustos, Eylül, Ekim, Kasım, Aralık 
        }
        enum SiparisDurumu
        {
            Hazırlanıyor, Hazırlandı, KargoBekleniyor, Kargolandı, İadeEdildi
        }
        enum Meyveler : int
        {
            Elma =3, Armut = 7, Çilek =1
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Konu11Enumlar");

            byte a = (byte)Meyveler.Armut;
            byte b = (byte)Meyveler.Elma;
            byte c = (byte)Meyveler.Çilek;
            Console.WriteLine($"{Meyveler.Armut} = {a}, {Meyveler.Elma}={b}, {Meyveler.Çilek}={c}");
            Ornek(SiparisDurum: 1);
            Ornek(3);
        }
        static void Ornek(int SiparisDurum)
        {
            if (SiparisDurum == (int)SiparisDurumu.Hazırlanıyor)
            {
                Console.WriteLine("Siparişiniz Hazırlanıyor");
            }
            if (SiparisDurum == (int)SiparisDurumu.Hazırlandı)
            {
                Console.WriteLine("Siparişiniz Hazırlandı");
            }
        } 
    }
}
