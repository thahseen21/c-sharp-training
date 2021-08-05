using System;

namespace DataStructure
{
    public class Stack
    {
        public class Node
        {
            public int Data;
            public Node NextNode;
            public Node()
            {
                this.NextNode = null;
            }
        }
        Node head;

        public void InsertElement(int data)
        {
            var tempNode = new Node();
            tempNode.Data = data;
            tempNode.NextNode = head;
            head = tempNode;
        }

        public void PopElement()
        {
            head = head.NextNode;
        }
        public void Display()
        {
            var tempNode = new Node();
            tempNode = head;

            while (tempNode != null)
            {
                Console.WriteLine($"{tempNode.Data}");
                tempNode = tempNode.NextNode;
            }

        }
    }
}