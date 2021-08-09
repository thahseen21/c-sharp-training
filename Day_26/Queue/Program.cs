using System;

namespace Queue
{

    public class Queue
    {
        public class Node
        {
            public int Data;
            public Node NextNode;
            public Node()
            {
                NextNode = null;
            }
        }
        Node Head;

        public void Enqueue(int data)
        {
            var tempNode = new Node();
            tempNode.Data = data;
            tempNode.NextNode = Head;
            Head = tempNode;
        }
        public void Dequeue()
        {
            var lastNode = new Node();
            var beforeLastNode = new Node();
            lastNode = Head;
            while (lastNode.NextNode != null)
            {
                beforeLastNode = lastNode;
                lastNode = lastNode.NextNode;
            }
            beforeLastNode.NextNode = null;
        }
        public void Display()
        {
            var tempNode = new Node();
            tempNode = Head;
            Console.Write("In ->");
            while (tempNode != null)
            {
                Console.Write($"-{tempNode.Data}-");
                tempNode = tempNode.NextNode;
            }
            Console.Write("->Out\n");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Queue list = new Queue();
            list.Enqueue(10);
            list.Enqueue(20);
            list.Enqueue(30);
            list.Display();
            list.Dequeue();
            list.Display();
        }
    }
}
