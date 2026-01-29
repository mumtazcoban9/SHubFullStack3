namespace Konu12KalitimInheritance
{
    public class Ürün : OrtakOzellikler
    {
        public decimal Fiyat {  get; set; }
        public int Stok {  get; set; }
        public int Kdv { get; set; }
        public int İskonto { get; set; }
        public string? TeknikÖzzellikler { get; set; } //ürün eklerken teknik özellikler boş geçilebilsin diye

    }
}
