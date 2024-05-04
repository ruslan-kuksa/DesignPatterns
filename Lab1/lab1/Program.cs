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

            product.ReducePrice(141, 120);
            Console.WriteLine($"New price of {product.Name}: {product.Price}");

            reporting.RegisterDelivery(new List<IProduct> { product }, DateTime.Now);
            reporting.RegisterShipment(new List<IProduct> { product }, DateTime(now.Year, now.Month, now.Day, 0, 0, 0, DateTimeKind.Utc).AddDays(-1));
            reporting.InventoryReport(warehouse);

            Console.WriteLine($"Total quantity in warehouse: {warehouse.GetTotalQuantity()}");
        }
    }
}
