using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Stacks and Queues programs");

            Stack stack = new Stack();

            Console.WriteLine("Choose an option:");
            Console.WriteLine("\n1. Push element to stack \n2. push element to stack using linkedlist" +
                "\n3. Peek top element \n4. Delete the top element \n5. Empty the stack");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    stack.Push(70);
                    stack.Push(30);
                    stack.Push(56);
                    stack.Display();
                    break;
                case 2:
                    stack.PushMethod(70);
                    stack.PushMethod(30);
                    stack.PushMethod(56);
                    stack.DisplayMethod();
                    break;
                case 3:
                    stack.Push(70);
                    stack.Push(30);
                    stack.Push(56);
                    stack.Display();
                    stack.Peek();
                    break;
                case 4:
                    stack.Push(70);
                    stack.Push(30);
                    stack.Push(56);
                    stack.Display();
                    stack.Pop();
                    stack.Display();
                    break;
                case 5:
                    stack.Push(70);
                    stack.Push(30);
                    stack.Push(56);
                    stack.Display();
                    if (stack.IsEmpty())
                    {
                        Console.WriteLine("The stack is empty");
                    }
                    break;
                default:
                    Console.WriteLine("Please choose correct option");
                    break;
            }
            Console.ReadLine();
        }
    }
}
