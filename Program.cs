using System;

namespace StackAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to stack and Queue");
            Stack<int> stack = new Stack<int>();
            stack.Push(70);
            stack.Push(30);
            stack.Push(53);
            Console.WriteLine("Stack is created and elements are pushed");
            stack.Peek();
            stack.Pop();
            Console.WriteLine("Queue Implementation");
            Queue<int> node = new Queue<int>();
            node.Enqueue(70);
            node.Enqueue(30);
            node.Enqueue(58);
            node.display();
            node.Dequeue();
            Console.WriteLine("Queue after deleting");
            node.display();
        }
    }
}
