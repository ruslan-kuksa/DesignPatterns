using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Product : IProduct
    {

        public string Name { get; private set; }
        public IMoney Price { get; private set; }
        public int Quantity { get; private set; }

        public Product(string name, IMoney price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public void ReducePrice(int mainPart, int coinPart)
        {
            if (mainPart > Price.MainPart)
                throw new InvalidOperationException("Invalid value of main part. Suggested price must be lower");

            int newMainPart = Price.MainPart - mainPart;
            int newCoinPart = Price.CoinPart - coinPart;
            if (newCoinPart < 0)
            {
                newMainPart -= 1;
                newCoinPart += 100;
            }
            Price.SetMoney(Math.Max(0, newMainPart), newCoinPart);
        }
    }
}
