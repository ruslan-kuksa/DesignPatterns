using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class FourthSupportHandler : BaseHandler
    {
        public override string Handle(string request)
        {
            if (request == "4")
            {
                return $"Fourth choose: Message {request}.\n";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}
