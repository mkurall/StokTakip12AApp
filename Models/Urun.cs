using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip12AApp.Models
{
    public class Urun
    {
        public int UrunId { get; set; }

        public string UrunKodu { get; set; }

        public int KategoriId { get; set; }

        public string UrunAd { get; set; }

        public int BirimId { get; set; }

        public string? UrunAciklama { get; set; }

        public double? MinStok { get; set; }

        public double? MaksStok { get; set; }

        public Kategori Kategori { get; set; }

      }
}
