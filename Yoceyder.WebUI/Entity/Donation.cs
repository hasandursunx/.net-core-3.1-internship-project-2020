using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Yoceyder.WebUI.Entity
{
    public class Donation
    {
        [Key]
        public int Yardim_Id { get; set; }
        public string Yardim_Tur { get; set; }
        public string Yardim_Urun { get; set; }
        public string Yardim_Miktar{ get; set; }
        public string Yardim_Aciklama { get; set; }
        public string Yardim_Tarih { get; set; }
        public string Yardim_Ysvr_Adisoyadi { get; set; }
        public string Yardim_Ysvr_Telno { get; set; }
        public int Yardim_Vasi_Id{ get; set; }
        public Parent Parent { get; set; }
    }
}
