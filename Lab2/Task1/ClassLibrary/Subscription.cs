using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public abstract class Subscription
    {
        public double MonthlyPrice { get; private set; }
        public int MinSubMonthlyPeriod { get; private set; }
        public List<string> ChannelsAndFeatures { get; private set; }

        public Subscription(double monthlyPrice, int minSubMonthlyPeriod, List<string> channelsAndFeatures)
        {
            MonthlyPrice = monthlyPrice;
            MinSubMonthlyPeriod = minSubMonthlyPeriod;
            ChannelsAndFeatures = channelsAndFeatures;
        }
    }
}
