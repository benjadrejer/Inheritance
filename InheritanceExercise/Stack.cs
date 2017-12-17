using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExercise
{
    public class Stack
    {
        private ArrayList _stack = new ArrayList();
        
        public void Push(object item)
        {
            if(item == null)
            {
                throw new NullReferenceException("You cannot add a null reference to the stack");
            }
            else
            {
                _stack.Add(item);
            }
        }

        public object Pop()
        {
            if(_stack.Count > 0)
            {
                Object item = _stack[_stack.Count - 1];
                _stack.RemoveAt(_stack.Count - 1);
                return item;
            }
            throw new InvalidOperationException("You cannot pop an empty stack");

        }

        public void Clear()
        {
            _stack = new ArrayList();
        }
    }
}
