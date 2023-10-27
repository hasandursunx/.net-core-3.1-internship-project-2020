using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Yoceyder.WebUI.Entity
{
    public class Child
    {
        [Key]
        public int Cocuk_Id { get; set; }
        public string Cocuk_Tc { get; set; }
        public string Cocuk_AdiSoyadi { get; set; }
        public string Cocuk_Cinsiyet { get; set; }

        [DataType(DataType.Date)]
        public DateTime DogumTarihi { get; set; }

        [DataType(DataType.Date)]
        public DateTime Cocuk_DogumTarihi { get; set; }
        public string Cocuk_OgrenimDurumu { get; set; }
        public string Cocuk_OkulAdi { get; set; }
        public string Cocuk_Sinif { get; set; }
        public string Cocuk_VasiYakinlik { get; set; }
        public string Cocuk_KaldigiYer { get; set; }
        public string Cocuk_AnneAdi { get; set; }
        public string Cocuk_BabaAdi { get; set; }
        public string Cocuk_AnneDurum { get; set; }
        public string Cocuk_BabaDurum { get; set; }
        public int Vasi_Id { get; set; }
    }
}
