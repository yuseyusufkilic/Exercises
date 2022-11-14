using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementStackUsingQueue
{
    public class StackUsingQueue
    {
        public Queue<int> Queue { get; set; } = new Queue<int>();
        public void Push(int x)
        {
            Queue.Enqueue(x);
        }
        public int Top()
        {
            return Queue.ElementAt(Queue.Count-1);
        }
        public void Pop()
        {
            var last = Queue.Last();
            for (int i = 0; i < Queue.Count; i++)
            {
                var deleted = Queue.Dequeue();
                if (deleted != last)
                    Queue.Enqueue(deleted);

            }
        }
        public bool isEmpty()
        {
            return Queue.Count() == 0;
        }
    }
}
