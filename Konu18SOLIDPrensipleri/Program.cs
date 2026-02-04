namespace Konu18SOLIDPrensipleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SOLIDPrensipleri");
            Console.WriteLine("Robert Cecil Martin tarafından öne sürülen geliştirilecek yazılımın esnek yeniden kullanılabilir sürüdürülebilir ve anlaşılabilir olmasını hedefleyen kod tekrarını önleyen prensipler bütünüdür.");

            Console.WriteLine();

            Console.WriteLine("S- Single Responsibility");
            Console.WriteLine("\t 1 sınıf veya metodun sadece 1 sorumluluğun olması gerekir!");
            Console.WriteLine();

            Console.WriteLine("O- Open-Closed Principle");
            Console.WriteLine("\t 1 sınıf ve ya metot var olan özelliklerini korumalı değişikliğe izin vermemelidir");

            Console.WriteLine();

            Console.WriteLine("L- Liskov Substution");
            Console.WriteLine("Kodlarımızda her hangi bir değişiklik yapmaya gerek duymadan alt sınıfları türedikleri üst sınıfların yerine kullanabilmeliyiz");

            Console.WriteLine();

            Console.WriteLine("I- Interface Segregation");
            Console.WriteLine("Sorumlulukların hepsini tek bir arayüzde toplamak yerine özelleştirlmiş birden fazla arayüz kullanmalıyız");

            Console.WriteLine();

            Console.WriteLine("D- Dependency Inversion");
            Console.WriteLine("Sınıflar arası bağımlılıklar olabildiğince az olmalıdır. Özellikle üst seviye sınıflar alt seviye sınfılara bağımlı olmamalıdır.");
        }
    }
}
