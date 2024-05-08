using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Weapon : HeroesInventoryDecorator
    {
        public Weapon(IHeroInventory heroesItem) : base(heroesItem) {}

        public override string HeroInventory()
        {
            return HeroesItem.HeroInventory() + "\nhave an axe";
        }
    }
}
