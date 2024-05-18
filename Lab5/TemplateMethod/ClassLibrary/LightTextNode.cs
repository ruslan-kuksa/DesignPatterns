using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ClassLibrary
{
    public class LightTextNode : LightNode
    {
        public string Text { get; set; }
        public LightTextNode(string text)
        {
            Text = text;
        }
        public override string ToHtml()
        {
            return Text;
        }
    }
}
