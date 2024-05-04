using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public interface IMoney
    {
        int MainPart { get; }
        int CoinPart { get; }

        void SetMoney(int mainUnit, int subUnit);
        string ToString();
    }
}
