using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public abstract class LightHTMLIterator
    {
        public abstract bool MoveNext();
        public abstract LightNode Current { get; }
        public abstract void Reset();
    }
}
