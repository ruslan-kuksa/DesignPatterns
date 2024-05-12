using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Aircraft
    {
        public string Name { get; private set; }

        public Aircraft(string name)
        {
            Name = name;
        }

        public void Land()
        {
            Console.Write($"Aircraft {Name} is landing ");
        }

        public void TakeOff()
        {
            Console.Write($"Aircraft {Name} is taking off ");
        }
    }
}
