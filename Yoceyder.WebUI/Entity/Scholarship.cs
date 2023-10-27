using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Yoceyder.WebUI.Entity
{
    public class Scholarship
    {
        [Key]
        public int Burs_Id { get; set; }
        public string Burs_Iban { get; set; }
        public string Burs_IbanSahibi { get; set; }
        public string Burs_BankaAdi { get; set; }
        public Double Burs_Miktar { get; set; }
        public string Burs_Sure { get; set; }
        public string Burs_BsvrAdiSoyadi{ get; set; }
        public string Burs_BsvrTelefon { get; set; }
        public int Burs_Vasi_Id{ get; set; }
        public int Burs_Cocuk_Id { get; set; }
    }
}
