using ClassLibrary.EventListeners;
using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class LightElementNode : LightNode
    {
        public string TagName { get; set; }
        public bool IsBlock { get; set; }
        public bool IsSelfClosing { get; set; }
        public List<string> _classes { get; set; }
        public List<LightNode> _children { get; set; }
        private List<IEventListener> _subscribers { get; set; }
        public LightElementNode(string tagName, bool isBlock, bool isSelfClosing)
        {
            TagName = tagName;
            IsBlock = isBlock;
            IsSelfClosing = isSelfClosing;
            _classes = new List<string>();
            _children = new List<LightNode>();
            _subscribers = new List<IEventListener>();
        }
        public void AddChild(LightNode child)
        {
            _children.Add(child);
        }
        public void AddClass(string className)
        {
            _classes.Add(className);
        }

        public string InnerHTML()
        {
            string html = "";
            foreach (LightNode child in _children)
            {
                html += child.ToHtml();
            }
            return html;
        }

        public override string ToHtml()
        {
            string tagClass = _classes.Count > 0 ? $" class=\"{string.Join(" ", _classes)}\"" : "";
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
        public void Subscribe(IEventListener listener)
        {
            _subscribers.Add(listener);
        }

        public void Unsubscribe(IEventListener listener)
        {
            _subscribers.Remove(listener);
        }

        public void Notify()
        {
            foreach (IEventListener listener in _subscribers)
            {
                listener.Update();
            }
        }
    }
}
