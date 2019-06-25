using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FGO_Randomizer.Models
{
    public class Servant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }
        public int Rarity { get; set; }
        public bool NA { get; set; }
        public char Card { get; set; }
        public string Role { get; set; }
    }
}
