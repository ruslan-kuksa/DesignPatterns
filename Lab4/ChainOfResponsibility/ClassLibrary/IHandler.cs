using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public interface IHandler
    {
        IHandler SetNext(IHandler handler);
        string Handle(string request);
    }
}
