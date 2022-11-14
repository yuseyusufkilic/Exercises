using ImplementStackUsingQueue;
using System.Collections;

StackUsingQueue stackUsingQueue = new StackUsingQueue();
stackUsingQueue.Push(5);
stackUsingQueue.Push(15);
stackUsingQueue.Push(56);

stackUsingQueue.Pop();

foreach (var item in stackUsingQueue.Queue)
{
    Console.WriteLine(item);

}