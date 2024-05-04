using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public interface IWarehouse
    {
        DateTime LastDeliveryDate { get; }
        void AddProduct(IProduct product);
        void RemoveProduct(IProduct product);
        List<IProduct> GetInventory();
    }
}
