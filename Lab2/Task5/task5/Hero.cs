using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    public class Hero
    {
        public string Height { get; set; }
        public string Build { get; set; }
        public string HairColor { get; set; }
        public string EyeColor { get; set; }
        public string Clothing { get; set; }
        public string Inventory { get; set; }

        public override string ToString()
        {
            return $"Height: {Height}, \nBuild: {Build}, \nHairColor: {HairColor}, " +
                $"\nEyeColor: {EyeColor}, \nClothing: {Clothing}, \nInventory: {Inventory}";
        }
    }
}
