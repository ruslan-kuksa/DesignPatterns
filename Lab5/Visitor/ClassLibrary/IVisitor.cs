using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public interface IVisitor
    {
        void VisitLightTextNode(LightTextNode textNode);
        void VisitLightElementNode(LightElementNode elementNode);
    }
}
