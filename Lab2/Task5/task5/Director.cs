using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    public class Director
    {
        public Hero ConstructHero(IHeroBuilder builder)
        {
            return builder.SetHeight("Tall")
                .SetBuild("Muscular")
                .SetHairColor("Black")
                .SetEyeColor("Blue")
                .SetClothing("Armor")
                .SetInventory("Knife, Shotgun")
                .Build();
        }

        public Hero ConstructEnemy(IHeroBuilder builder)
        {
            return builder.SetHeight("Short")
                .SetBuild("Thin")
                .SetHairColor("Red")
                .SetEyeColor("Green")
                .SetClothing("Armor")
                .SetInventory("Pistol, Knife")
                .Build();
        }
    }
}
