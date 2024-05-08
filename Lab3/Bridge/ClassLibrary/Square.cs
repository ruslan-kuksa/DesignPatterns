using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Square : Shape
    {
        public Square(IRender render) : base(render) {}

        public override void Operation()
        {
            Render.Rendering("Square");
        }
    }
}
