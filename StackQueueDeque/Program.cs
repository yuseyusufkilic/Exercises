using StackQueueDeque.Stack;
using StackQueueDeque.Deque;

StackImplementation<object> stackImplementation = new StackImplementation<object>();

stackImplementation.Push(1);
stackImplementation.Push(10);
stackImplementation.Push(20);
stackImplementation.Push(40);

stackImplementation.Push('a');
stackImplementation.Push('b');
stackImplementation.Push('c');

Console.WriteLine(stackImplementation.ShowLast());

var popped = stackImplementation.Pop();
Console.WriteLine(popped);
stackImplementation.Pop();


foreach (var item in stackImplementation.Elements)
{
    Console.WriteLine(item);

}

//queue ve deque ' de hemen hemen aynı şeyler zaten.


DequeImplementation<object> deque= new DequeImplementation<object>();

deque.AddRear(1);
deque.AddRear(10);
deque.AddRear(20);
deque.AddFront(5);
deque.AddFront(55);

deque.RemoveFront();
deque.RemoveRear();

foreach (var item in deque.Elements)
{
    Console.WriteLine(item);
}

