using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StacksAndQueues.LinkedList;


namespace StacksAndQueues
{
    public class Queue
    {
        private Node head;
        CustomLinkedList linkedList = new CustomLinkedList();
        public void Enqueue(int data)
        {
            Node newNode = new Node(data);
            if (this.head == null)
                this.head = newNode;
            else
            {
                Node temp = this.head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
            }
            Console.WriteLine("{0} is inserted into queue ", newNode.data);
        }

        public void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }

        public void EnqueueMethod(int data)
        {
            linkedList.Append(data);
        }
        public void DisplayMethod()
        {
            linkedList.Display();
        }

        public void Dequeue()
        {
            if (this.head == null)
            {
                Console.WriteLine("Queue is Empty");
            }
            else
            {
                this.head = this.head.next;
            }
        }
        public void DequeueMethod()
        {
            linkedList.DeleteFirst();
        }
    }
}
