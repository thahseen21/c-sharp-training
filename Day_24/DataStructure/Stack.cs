using System;

namespace DataStructure
{
    public class Stack
    {
        public class Node
        {
            public int Data; // 20 
            public Node NextNode; // null
            public Node()
            {
                this.NextNode = null;
            }
        }
        Node head;// = 5,{10 , {20,null}}
        // new element 
        // 2 =>  tempnode |_20_|_|_1_|_null__| |_1_|_null_| 
        // tempnode.data =2
        // tempnode.next = head ; {2,{5,{10 , {20,null}}}}
        // head = tempnode // {2,{5,{10 , {20,null}}}}

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