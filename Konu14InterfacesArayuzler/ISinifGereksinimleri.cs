namespace Konu14InterfacesArayuzler
{
    internal interface ISinifGereksinimleri // bu interface her classta bulunması gereken zorunlu özellikleri içeriyor.
    {
        public int Id { get; set; } // nesnenin benzersiz kimlik değeri
        public DateTime CreateDate { get; set; } // nesnenin oluşma zamanını tutacak özellik
        public DateTime UpdateDate { get; set; } // nesnenin güncelleme zamanını tutacak özellik
        public bool IsActive { get; set; }
    }
}
