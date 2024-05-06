using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    public class Virus
    {
        public double Weight;
        public int Age;
        public string Name;
        public string Species;
        public List<Virus> Children;

        public Virus(double weight, int age, string name, string species)
        {
            Weight = weight;
            Age = age;
            Name = name;
            Species = species;
            Children = new List<Virus>();
        }

        public void AddChild(Virus child)
        {
            Children.Add(child);
        }

        public Virus ShallowCopy()
        {
            return (Virus)this.MemberwiseClone();
        }

        public Virus DeepCopy()
        {
            Virus clone = (Virus)this.MemberwiseClone();
            clone.Children = new List<Virus>(Children.Count);
            foreach (Virus child in Children)
            {
                clone.Children.Add(child.DeepCopy());
            }
            return clone;
        }
    }
}
