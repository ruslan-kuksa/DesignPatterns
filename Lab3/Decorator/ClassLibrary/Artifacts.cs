using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Artifacts : HeroesInventoryDecorator
    {
        public Artifacts(IHeroInventory heroesItem) : base(heroesItem) { }

        public override string HeroInventory()
        {
            return HeroesItem.HeroInventory() + "\nhave one coupon for McDonalds coffee from the future, deadly artifact";
        }
    }
}
