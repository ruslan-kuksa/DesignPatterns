using ClassLibrary;
using System;
using System.Collections.Generic;

namespace Classlibrary
{
    class Program
    {
        static void Main()
        {
            Money money = new Money(150, 50);
            Product product = new Product("Computer", money, 10);
            Warehouse warehouse = new Warehouse();
            Reporting reporting = new Reporting();

            warehouse.AddProduct(product);
            reporting.InventoryReport(warehouse);

            product.ReducePrice(149, 20);
            Console.WriteLine($"New price of {product.Name}: {product.Price}");

            reporting.RegisterDelivery(new List<IProduct> { product }, DateTime.Now);
            reporting.RegisterShipment(new List<IProduct> { product }, DateTime.Now);
            reporting.InventoryReport(warehouse);

            Console.WriteLine($"Total quantity in warehouse: {warehouse.GetTotalQuantity()}");
        }
    }
}
