using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.EventListeners
{
    public class MouseOverListener : IEventListener
    {
        public void Update()
        {
            Console.WriteLine("MouseOver event");
        }
    }
}
