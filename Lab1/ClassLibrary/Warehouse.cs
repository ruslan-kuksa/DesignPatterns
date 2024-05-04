using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Warehouse : IWarehouse
    {
        private List<IProduct> products = new List<IProduct>();
        public DateTime LastDeliveryDate { get; private set; }

        public void AddProduct(IProduct product)
        {
            products.Add(product);
            LastDeliveryDate = DateTime.Now;
        }

        public void RemoveProduct(IProduct product)
        {
            products.Remove(product);
        }

        public List<IProduct> GetInventory()
        {
            return products;
        }

        public int GetTotalQuantity()
        {
            return products.Sum(p => p.Quantity);
        }
    }
}
