namespace ExpedisiPaketAPI.DTOs
{

    namespace EkspedisiPaketAPI.Models
    {
        public static class StatusPengirimanConstant
        {
            public const string Pending = "PENDING";
            public const string Diproses = "DIPROSES";
            public const string Dikirim = "DIKIRIM";
            public const string Selesai = "SELESAI";
            public const string Batal = "BATAL";
        }
    }
    public class UpdatePaketDto
    {
        public string Pengirim { get; set; } = string.Empty;

        public string Penerima { get; set; } = string.Empty;

        public string AlamatAsal { get; set; } = string.Empty;

        public string AlamatTujuan { get; set; } = string.Empty;

        public double BeratKg { get; set; }

        public string StatusPengiriman { get; set; } = string.Empty;

        public string Kota { get; set; } = string.Empty;

        public decimal Biaya { get; set; }
    }
}
