using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.EventListeners
{
    public class ClickListener : IEventListener
    {
        public void Update()
        {
            Console.WriteLine("Click event");
        }
    }
}
