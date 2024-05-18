using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ClassLibrary
{
    public class LightTextNode : ILightNode, ILightEntity
    {
        public string Text { get; set; }
        public LightTextNode(string text)
        {
            Text = text;
        }
        public string ToHtml()
        {
            return Text;
        }
        public void Accept(IVisitor visitor)
        {
            visitor.VisitLightTextNode(this);
        }
    }
}
