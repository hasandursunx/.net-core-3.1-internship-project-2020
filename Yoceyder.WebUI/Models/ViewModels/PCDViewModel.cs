using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Yoceyder.WebUI.Entity;

namespace Yoceyder.WebUI.Models.ViewModels
{
    public class PCDViewModel
    {
        public Parent Parent { get; set; }

        public IEnumerable<Child> Child { get; set; }

        public IEnumerable<Donation> Donation { get; set; }
    }
}
