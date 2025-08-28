using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.List
{
    internal class ReversingList
    {
            public Node head;
            public void Add(int Value)
            {
                Node newNode = new Node(Value);
                if (head == null)
                {
                    head = newNode;
                }
                else
                {
                    Node current = head;
                    while (current.next != null)
                    {
                        current = current.next;
                    }
                    current.next = newNode;
                }
            }
            public void PrintList(Node head)
            {
                Node temp = head;
                while (temp != null)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                }
            }
            public Node ReverseList(Node head)
            {
                Node prev = null;
                Node current = head;
                Node next = null;
                while (current != null)
                {
                    next = current.next;
                    current.next = prev;
                    prev = current;
                    current = next;
                }
                return prev;
            }
        public static void Run()
        {
            ReversingList list = new ReversingList();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            Console.WriteLine("Original List:");
            list.PrintList(list.head);
            list.head = list.ReverseList(list.head);
            Console.WriteLine("\nReversed List:");
            list.PrintList(list.head);
        }
    }
    public class Node
    {
        public int data;
        public Node next;
        public Node(int value)
        {
            data = value;
            next = null;
        }
    }
}
   
