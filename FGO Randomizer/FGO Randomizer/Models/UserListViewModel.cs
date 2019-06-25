using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FGO_Randomizer.Models
{
    public class UserListViewModel
    {
        public List<ServantChecked> ServantList { get; set; }
        public SelectList Classes { get; set; }
        public string enemyClass { get; set; }
    }

    public class ServantChecked
    {
        public Servant servant { get; set; }
        public bool IsChecked { get; set; } = false;
    }
}
