using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Yoceyder.WebUI.Entity
{
    public class Parent
    {
        [Key]
        public int Vasi_Id { get; set; }
        public string Vasi_Dosya { get; set; }
        public string Vasi_Tc { get; set; }
        public string Vasi_AdiSoyadi { get; set; }
        public string Vasi_Telefon { get; set; }
        public string Vasi_Il { get; set; }
        public string Vasi_Ilce { get; set; }
        public string Vasi_Adres { get; set; }
        public string Vasi_Iban { get; set; }
        public string Vasi_Evdurumu { get; set; }
        public Double Vasi_Kiramiktari { get; set; }
        public string Vasi_Maas { get; set; }
        public double Vasi_Maasmiktari { get; set; }
        public int Vasi_Cocuksayisi { get; set; }

        [DataType(DataType.Date)]
        public DateTime Vasi_Kayittarihi { get; set; }

        [DataType(DataType.Date)]
        public DateTime Vasi_Guncellemetarihi { get; set; }
        public String Vasi_Resim { get; set; }
        public String Vasi_Resimyolu { get; set; }

        [NotMapped]
        public IFormFile ResimDosyasi { get; set; }
        public List<Child> Children { get; set; }
        public List<Donation> Donations { get; set; }

    }
}

