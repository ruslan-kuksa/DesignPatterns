using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public abstract class LightNode
    {
        public string TemplateMethod()
        {
            OnCreated();
            OnInserted();
            OnStylesApplied();
            OnClassListApplied();
            OnTextRendered();
            OnRemoved();
            string html = ToHtml();
            return html;
        }

        public abstract string ToHtml();
        protected virtual void OnCreated() { }
        protected virtual void OnInserted() { }
        protected virtual void OnRemoved() { }
        protected virtual void OnStylesApplied() { }
        protected virtual void OnClassListApplied() { }
        protected virtual void OnTextRendered() { }
    }
}
