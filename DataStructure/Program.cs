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
            var linkedList = new LinkedList();
            linkedList.Add(56);
            linkedList.Add(30);
            linkedList.Add(70);
            linkedList.Display();
           // linkedList.InsertAtPerticularPosition(2, 30);
           // linkedList.RemoveFirstNode();
            Console.ReadKey();
        }
    }
}
