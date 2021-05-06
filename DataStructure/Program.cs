using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            //var linkedList = new LinkedList();
            //linkedList.Add(56);
            //linkedList.Add(30);
            //linkedList.Add(70);
            //linkedList.Display();
            //// linkedList.InsertAtPerticularPosition(2, 30);
            //// linkedList.RemoveFirstNode();


            LinkedListStack stack = new LinkedListStack();
            stack.Push(30);
            stack.Push(50);
            stack.Push(70);
            stack.Pop();
            stack.Display();
            stack.Peek();
            stack.IsEmpty();
            stack.Display();

            //LinkedListQueue queue = new LinkedListQueue();
            //queue.Enqueue(56);
            //queue.Enqueue(30);
            //queue.Enqueue(80);
            //queue.Dequeue();
            //queue.Display();
            Console.ReadKey();
            
        }
    }
}
