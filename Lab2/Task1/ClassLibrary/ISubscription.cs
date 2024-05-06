using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public interface ISubscription
    {
        Subscription RegistrationSub(string type);
    }
}
