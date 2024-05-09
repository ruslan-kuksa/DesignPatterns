using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class LightElementNode : LightNode
    {
        public ElementsTypeHTML ElementType { get; }
        public List<string> Classes { get; set; }
        public List<LightNode> Children { get; set; }

        public LightElementNode(ElementsTypeHTML elementType)
        {
            ElementType = elementType;
            Classes = new List<string>();
            Children = new List<LightNode>();
        }


        public void AddChild(LightNode child)
        {
            Children.Add(child);
        }
        public void AddClass(string className)
        {
            Classes.Add(className);
        }

        public string InnerHTML()
        {
            string html = "";
            foreach (LightNode child in Children)
            {
                html += child.ToHtml();
            }
            return html;
        }

        public override string ToHtml()
        {
            string tagClass = Classes.Count > 0 ? $" class=\"{string.Join(" ", Classes)}\"" : "";
            string html = $"<{ElementType.TagName}{tagClass}>";

            if (!ElementType.IsSelfClosing)
            {
                html += InnerHTML();
                html += $"</{ElementType.TagName}>";
            }

            return html;
        }

        public string OuterHTML()
        {
            return ToHtml();
        }
    }
}
