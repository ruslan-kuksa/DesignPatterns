using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public abstract class HeroesInventoryDecorator : IHeroInventory
    {
        public IHeroInventory HeroesItem;
        public HeroesInventoryDecorator(IHeroInventory heroesItem)
        {
            HeroesItem = heroesItem;
        }

        public abstract string HeroInventory();
    }
}
