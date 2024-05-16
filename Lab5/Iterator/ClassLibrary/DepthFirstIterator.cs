using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class DepthFirstIterator : LightHTMLIterator
    {
        private Stack<LightNode> stack;
        private LightNode current;

        public DepthFirstIterator(LightNode root)
        {
            stack = new Stack<LightNode>();
            stack.Push(root);
        }

        public override LightNode Current => current;

        public override bool MoveNext()
        {
            if (stack.Count == 0)
                return false;

            current = stack.Pop();

            if (current is LightElementNode elementNode)
            {
                for (int i = elementNode.Children.Count - 1; i >= 0; i--)
                {
                    stack.Push(elementNode.Children[i]);
                }
            }

            return true;
        }

        public override void Reset()
        {
            stack.Clear();
        }
    }
}
