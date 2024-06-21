using System;

namespace OgrenciYonetim.Models
{
    public class Ogrenciler
    {
        public int OgrenciNo { get; set; }
        public string? Ad { get; set; } = "";
        public string? Soyad { get; set; } = "";
        public int Sinif { get; set; }
        public string? DersTanimi { get; set; } = "";
        public int Kredi { get; set; }
        public DateTime SinavTarihi { get; set; }
        public int VizeNotu { get; set; }
        public int FinalNotu { get; set; }
        public double Ortalama 
        {
            get
            {
                return (VizeNotu * 0.4) + (FinalNotu * 0.6);
            }
            set {} // ReadOnly değilse, set bloğu ekleyebiliriz.
        }
        public string? HarfKarsiligi 
        {
            get
            {
                if (Ortalama >= 85) return "AA";
                if (Ortalama >= 75) return "BA";
                if (Ortalama >= 65) return "BB";
                if (Ortalama >= 55) return "CB";
                if (Ortalama >= 50) return "CC";
                return "FF";
            }
            set {} // ReadOnly değilse, set bloğu ekleyebiliriz.
        }
        public bool GecmeDurumu
        {
            get
            {
                return Ortalama >= 50;
            }
            set {} // ReadOnly değilse, set bloğu ekleyebiliriz.
        }
    }
}
