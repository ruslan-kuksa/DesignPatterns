using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Memento : IMemento
    {
        public string _state { get; private set; }

        public Memento(string state)
        {
            _state = state;
        }
    }
}
