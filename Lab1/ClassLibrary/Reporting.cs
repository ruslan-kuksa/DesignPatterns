using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Reporting
    {
        public void RegisterDelivery(List<IProduct> products, DateTime date)
        {
            Console.WriteLine($"Delivery on {date.ToShortDateString()}: {products.Count} products added");
        }

        public void RegisterShipment(List<IProduct> products, DateTime date)
        {
            Console.WriteLine($"Shipment on {date.ToShortDateString()}: {products.Count} products shipped");
        }

        public void InventoryReport(IWarehouse warehouse)
        {
            Console.WriteLine("Current Inventory:");
            foreach (IProduct product in warehouse.GetInventory())
            {
                Console.WriteLine($"{product.Name} - {product.Price}");
            }
        }
    }
}
