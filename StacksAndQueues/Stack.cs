using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StacksAndQueues.LinkedList;

namespace StacksAndQueues
{
    public class Stack
    {
        private Node top;
        
        CustomLinkedList linkedList = new CustomLinkedList();
        public void Push(int data)
        {
            Node newNode = new Node(data);
            if (this.top != null)
            {
                newNode.next = this.top;       //newNode will hold address of top element
                
            }
            this.top = newNode;                //top will point to new element
            Console.WriteLine("{0} is added to stack", newNode.data);
        }
        public void PushMethod(int data)
        {
            linkedList.AddFirst(data);
        }
        public void DisplayMethod()
        {
            linkedList.Display();
        }
        public void Display()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is empty");
            }
            else
            {
                Node temp = this.top;
                while (temp !=  null)
                {
                    Console.WriteLine("Value in the stack is: "+ temp.data);
                    temp = temp.next;
                }
            }
        }

        public void Peek()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is Empty");
                return;
            }
            Console.WriteLine("{0} is top element of the stack", this.top.data);
        }
        public void Pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is Empty, Deletion is not possible");
                return;
            }
            Console.WriteLine("{0} is deleted from top of the stack", this.top.data);
            this.top = this.top.next;
        }
        public bool IsEmpty()
        {
            while (this.top != null)
            {
                Peek();
                Pop();
            }
            return true;
        }
    }
}
