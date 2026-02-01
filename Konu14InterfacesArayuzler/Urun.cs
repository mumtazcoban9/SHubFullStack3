namespace Konu14InterfacesArayuzler
{
    internal class Urun : ISinifGereksinimleri
    {
        public int Id { get; set; } // nesnenin benzersiz kimlik değeri
        public DateTime CreateDate { get; set; } // nesnenin oluşma zamanını tutacak özellik
        public DateTime UpdateDate { get; set; } // nesnenin güncelleme zamanını tutacak özellik
        public bool IsActive { get; set; } //nesnenin aktiflik durmunu tutacak olan özellik 
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
        public decimal  Price { get; set; }
        public int Stock { get; set; }
    }
}
