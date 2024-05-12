using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class SecondSupportHandler : BaseHandler
    {
        public override string Handle(string request)
        {
            if (request == "2")
            {
                return $"Second choose: Message {request}.\n";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}
