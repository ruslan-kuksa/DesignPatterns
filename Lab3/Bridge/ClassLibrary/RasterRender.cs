using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class RasterRender : IRender
    {
        public void Rendering(string shapeName)
        {
            Console.WriteLine($"Drawing {shapeName} as pixels");
        }
    }
}
