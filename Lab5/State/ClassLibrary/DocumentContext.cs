using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class DocumentContext
    {
        private IDocumentState CurrentState;

        public DocumentContext()
        {
            CurrentState = null;
        }

        public void SetState(IDocumentState state)
        {
            CurrentState = state;
        }

        public string GetState() => CurrentState.Handle();
    }
}
