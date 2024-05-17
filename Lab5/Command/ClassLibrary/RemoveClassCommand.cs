using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class RemoveClassCommand : ICommand
    {
        private LightElementNode Element;
        private string ClassName;

        public RemoveClassCommand(LightElementNode element, string className)
        {
            Element = element;
            ClassName = className;
        }

        public void Execute()
        {
            Element.Classes.Remove(ClassName);
        }

        public void Undo()
        {
            Element.AddClass(ClassName);
        }
    }
}
