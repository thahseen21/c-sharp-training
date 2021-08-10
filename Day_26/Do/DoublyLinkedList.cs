using System;

namespace DoubleLinkedList
{
    class DoubleLinkedList
    {
        public class Node
        {
            public int Data;
            public Node PreviousNode;
            public Node NextNode;

            public Node()
            {
                NextNode = null;
            }
        }
        Node Head;

        public DoubleLinkedList()
        {
            this.Head = null;
        }
        public void InsertAtFirst(int data)
        {
            var tempNode = new Node();
            tempNode.Data = data;
            tempNode.NextNode = Head;
            tempNode.PreviousNode = null;
            Head = tempNode;
        }
        public void InsertAtLast(int data)
        {
            var lastNode = new Node();
            lastNode = Head;
            bool check = true;
            while (check)
            {
                if (lastNode.NextNode != null)
                {
                    lastNode = lastNode.NextNode;
                }
                else
                {
                    check = false;
                }
            }
            var tempNode = new Node();
            tempNode.Data = data;
            tempNode.NextNode = null;
            tempNode.PreviousNode = lastNode;
            lastNode.NextNode = tempNode;
        }
        public void RemoveByData(int data)
        {
            var tempNode = new Node();
            var previousNode = new Node();
            var nextNode = new Node();

            tempNode = Head;
            previousNode = null;
            bool isFound = false;
            while (!isFound)
            {
                if (tempNode.Data == data)
                {
                    isFound = true;
                }
                else
                {
                    previousNode = tempNode;
                    tempNode = tempNode.NextNode;
                    nextNode = tempNode.NextNode ?? null;
                }
            }

            if (isFound)
            {
                if (nextNode == null)
                {
                    previousNode.NextNode = null;
                }
                else if (previousNode == null)
                {
                    Head = tempNode.NextNode;
                }
                else
                {
                    previousNode.NextNode = nextNode;
                    nextNode.PreviousNode = previousNode;
                }
            }
            else
            {
                Console.WriteLine($"Data Not found");
            }
        }
        public void Display()
        {
            var tempNode = new Node();
            tempNode = Head;

            while (tempNode != null)
            {
                Console.WriteLine($"{tempNode.Data}");
                tempNode = tempNode.NextNode;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var list = new DoubleLinkedList();

            list.InsertAtFirst(10);
            list.InsertAtFirst(5);
            list.InsertAtLast(20);
            list.RemoveByData(10);
            list.Display();

            var runProgram = true;
            int choice;

            while (runProgram)
            {
                Console.WriteLine($"Enter 1.To Insert At Begining\t2.To Insert at last\t3.To remove data\t4.To display data\t5.Quit");
                choice = int.Parse(Console.ReadLine());
                int number;
                switch (choice)
                {
                    case 1:
                        Console.WriteLine($"Enter a number to insert:");
                        number = int.Parse(Console.ReadLine());
                        list.InsertAtFirst(number);
                        break;
                    case 2:
                        Console.WriteLine($"Enter a number to insert:");
                        number = int.Parse(Console.ReadLine());
                        list.InsertAtLast(number);
                        break;
                    case 3:
                        Console.WriteLine($"Enter a the number to remove from the list:");
                        number = int.Parse(Console.ReadLine());
                        list.RemoveByData(number);
                        break;
                    case 4:
                        list.Display();
                        break;
                    case 5:
                        runProgram = false;
                        break;
                }
            }
        }
    }
}
