using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public abstract class Shape
    {
        protected IRender Render;

        public Shape (IRender render)
        {
            Render = render;
        }
        public abstract void Operation();
    }
}
