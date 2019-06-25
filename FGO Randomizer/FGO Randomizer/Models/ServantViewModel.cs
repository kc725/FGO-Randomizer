using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FGO_Randomizer.Models
{
    public class ServantViewModel
    {
        public List<Servant> Servants { get; set; }
        public SelectList Classes { get; set; }
        public string servantClass { get; set; }
        public string searchName { get; set; }
    }
}
