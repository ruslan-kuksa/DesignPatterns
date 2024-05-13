using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class TextEditor
    {
        private TextDocument document = new TextDocument();
        private Caretaker caretaker = new Caretaker();

        public void WriteText(string text)
        {
            caretaker.SaveState(document);
            document.state += text;
        }

        public void Undo()
        {
            caretaker.RestoreState(document);
        }

        public void ShowContent()
        {
            Console.WriteLine(document.state);
            Console.WriteLine();
        }
    }
}
