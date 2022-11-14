using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueueDeque.Stack
{
    public class StackImplementation<T>
    {
        public List<T> Elements { get; set; } = new List<T>();
        public T Element { get; set; }
        public bool isEmpty(T list)
        {
            return Elements.Count == 0;
        }
        public void Push(T element)
        {
            Elements.Add(element);
        }
        public T Pop()
        {
            var lastOne = Elements[Elements.Count-1];
            Elements.RemoveAt(Elements.IndexOf(Elements[Elements.Count - 1]));
            return lastOne;
        }
        public T ShowLast()
        {
            return Elements[Elements.Count - 1];
                
        }


        
    }
}
