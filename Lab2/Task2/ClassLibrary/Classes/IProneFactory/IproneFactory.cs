using ClassLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Classes.IProneFactory
{
    public class IProneFactory : IDevicesFactory
    {
        public ILaptop CreateLaptop() => new LaptopIProne();
        public INetbook CreateNetbook() => new NetbookIProne();
        public IEBook CreateEBook() => new EBookIProne();
        public ISmartphone CreateSmartphone() => new SmartphoneIProne();
    }
}
