using ClassLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Classes.BalaxyFactory
{
    public class BalaxyFactory : IDevicesFactory
    {
        public ILaptop CreateLaptop() => new LaptopBalaxy();
        public INetbook CreateNetbook() => new NetbookBalaxy();
        public IEBook CreateEBook() => new EBookBalaxy();
        public ISmartphone CreateSmartphone() => new SmartphoneBalaxy();
    }
}
