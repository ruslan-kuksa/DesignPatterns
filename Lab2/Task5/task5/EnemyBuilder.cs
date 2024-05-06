using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    public class EnemyBuilder : IHeroBuilder
    {
        private Hero character = new Hero();

        public IHeroBuilder SetHeight(string height)
        {
            character.Height = height;
            return this;
        }

        public IHeroBuilder SetBuild(string build)
        {
            character.Build = build;
            return this;
        }

        public IHeroBuilder SetHairColor(string hairColor)
        {
            character.HairColor = hairColor;
            return this;
        }

        public IHeroBuilder SetEyeColor(string eyeColor)
        {
            character.EyeColor = eyeColor;
            return this;
        }

        public IHeroBuilder SetClothing(string clothing)
        {
            character.Clothing = clothing;
            return this;
        }

        public IHeroBuilder SetInventory(string inventory)
        {
            character.Inventory = inventory;
            return this;
        }

        public Hero Build()
        {
            return character;
        }
    }
}
