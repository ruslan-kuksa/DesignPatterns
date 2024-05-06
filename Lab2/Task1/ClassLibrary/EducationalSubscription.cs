using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class EducationalSubscription : Subscription
    {
        public EducationalSubscription(double monthlyPrice, int minSubMonthlyPeriod, List<string> channelsAndFeatures) 
            : base(monthlyPrice, minSubMonthlyPeriod, channelsAndFeatures)
        {

        }
    }
}
