using System;

namespace ExpedisiPaketAPI.Models
{
    public static class StatusPengirimanConstant
    {
        public const string Pending = "PENDING";
        public const string Diproses = "DIPROSES";
        public const string Dikirim = "DIKIRIM";
        public const string Selesai = "SELESAI";
        public const string Batal = "BATAL";
    }

    public class Paket
    {
        public int Id { get; set; }
        public string NomerResi { get; set; } = string.Empty;
        public string Pengirim { get; set; } = string.Empty;
        public string Penerima { get; set; } = string.Empty;
        public string AlamatAsal { get; set; } = string.Empty;
        public string AlamatTujuan { get; set; } = string.Empty;
        public double BeratKg { get; set; }
        public string StatusPengiriman { get; set; } = StatusPengirimanConstant.Pending;
        public DateTime TanggalDikirm { get; set; }
        public DateTime? TanggalDiterima { get; set; }
        public string Kota { get; set; } = string.Empty;
        public decimal Biaya { get; set; }
    }
}