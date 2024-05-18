using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class LightElementNode : ILightNode, ILightEntity
    {
        public string TagName { get; set; }
        public bool IsBlock { get; set; }
        public bool IsSelfClosing { get; set; }
        public List<string> Classes { get; set; }
        public List<ILightNode> Children { get; set; }

        public LightElementNode(string tagName, bool isBlock, bool isSelfClosing)
        {
            TagName = tagName;
            IsBlock = isBlock;
            IsSelfClosing = isSelfClosing;
            Classes = new List<string>();
            Children = new List<ILightNode>();
        }

        public void AddChild(ILightNode child)
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
            foreach (ILightNode child in Children)
            {
                html += child.ToHtml();
            }
            return html;
        }

        public string ToHtml()
        {
            string tagClass = Classes.Count > 0 ? $" class=\"{string.Join(" ", Classes)}\"" : "";
            string html = $"<{TagName}{tagClass}>";

            if (!IsSelfClosing)
            {
                html += InnerHTML();
                html += $"</{TagName}>";
            }

            return html;
        }

        public string OuterHTML()
        {
            return ToHtml();
        }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitLightElementNode(this);
            foreach (ILightEntity child in Children)
            {
                child.Accept(visitor);
            }
        }
    }
}
