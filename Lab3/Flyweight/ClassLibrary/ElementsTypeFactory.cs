using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class ElementsTypeFactory
    {
        private Dictionary<string, ElementsTypeHTML> Types;

        public ElementsTypeFactory()
        {
            Types = new Dictionary<string, ElementsTypeHTML>
            {
                {"h1", new ElementsTypeHTML("h1", true, false)},
                {"h2", new ElementsTypeHTML("h2", true, false)},
                {"p", new ElementsTypeHTML("p", true, false)},
                {"blockquote", new ElementsTypeHTML("blockquote", true, false)}
            };
        }

        public ElementsTypeHTML GetElementType(string tagName)
        {
            return Types[tagName];
        }
    }
}
