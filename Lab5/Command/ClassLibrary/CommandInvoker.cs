using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class CommandInvoker
    {
        private Stack<ICommand> Commands = new Stack<ICommand>();

        public void ExecuteCommand(ICommand command)
        {
            command.Execute();
            Commands.Push(command);
        }

        public void Undo()
        {
            if (Commands.Count > 0)
            {
                ICommand command = Commands.Pop();
                command.Undo();
            }
        }
    }
}
