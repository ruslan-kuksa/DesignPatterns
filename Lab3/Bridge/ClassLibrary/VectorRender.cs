using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class VectorRender : IRender
    {
        public void Rendering(string shapeName)
        {
            Console.WriteLine($"Drawing {shapeName} as lines");
        }
    }
}
