using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueueDeque.Deque
{
    public class DequeImplementation<T>
    {
        public List<T> Elements { get; set; } = new List<T>();
        public void AddFront(T element)
        {
            Elements.Insert(0, element);
        }
        public void AddRear(T element) { 
            Elements.Add(element);
        }
        public void RemoveFront()
        {
            Elements.RemoveAt(0);
        }
        public void RemoveRear()
        {
            Elements.RemoveAt(Elements.IndexOf(Elements[Elements.Count - 1]));
        }
        public int Size()
        {
            return Elements.Count;
        }

    }
}
