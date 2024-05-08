using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Clothes : HeroesInventoryDecorator
    {
        public Clothes(IHeroInventory heroesItem) : base(heroesItem) { }

        public override string HeroInventory()
        {
            return HeroesItem.HeroInventory() + "\nequipped the armor";
        }
    }
}
