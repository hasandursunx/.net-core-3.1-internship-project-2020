using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Yoceyder.WebUI.Entity;

namespace Yoceyder.WebUI.Models.ViewModels
{
    public class CSViewModel
    {
        public Child Child { get; set; }

        public IEnumerable<Scholarship> Scholarship { get; set; }
    }
}
