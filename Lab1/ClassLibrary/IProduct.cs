using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public interface IProduct
    {
        string Name { get; }
        IMoney Price { get; }
        int Quantity { get; }
        void ReducePrice(int mainPart, int coinPart);
    }
}
