using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Mage : IHeroInventory
    {
        public string HeroInventory()
        {
            return "Inventory of Mage: ";
        }
    }
}
