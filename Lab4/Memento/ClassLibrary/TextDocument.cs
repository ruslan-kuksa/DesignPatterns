using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class TextDocument
    {
        public string state;

        public Memento CreateMemento()
        {
            return new Memento(state);
        }

        public void RestoreMemento(Memento memento)
        {
            state = memento._state;
        }
    }
}
