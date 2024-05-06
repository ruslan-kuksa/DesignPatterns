using ClassLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Classes.KiaomiFactory
{
    public class KiaomiFactory : IDevicesFactory
    {
        public ILaptop CreateLaptop() => new LaptopKiaomi();
        public INetbook CreateNetbook() => new NetbookKiaomi();
        public IEBook CreateEBook() => new EBookKiaomi();
        public ISmartphone CreateSmartphone() => new SmartphoneKiaomi();
    }
}
