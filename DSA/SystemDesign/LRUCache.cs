using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.SystemDesign
{
    public class LRUCache
    {
        private class Node
        {
            public int Key { get; set; }
            public int Value { get; set; }
            public Node Prev { get; set; }
            public Node Next { get; set; }
            public Node(int key, int value)
            {
                Key = key;
                Value = value;
            }
        }
        private readonly int capacity;
        private readonly Dictionary<int, Node> cache;
        private Node head;
        private Node tail;
        public LRUCache(int capacity)
        {
            this.capacity = capacity;
            this.cache = new Dictionary<int, Node>();
            this.head = new Node(0, 0);
            this.tail = new Node(0, 0);
            this.head.Next = this.tail;
            this.tail.Prev = this.head;
        }
        public int Get(int key)
        {
            if (!cache.ContainsKey(key))
            {
                return -1;
            }
            Node node = cache[key];
            Remove(node);
            MoveHead(node);

            return node.Value;
        }
        public void Put(int key, int value)
        {
            if (cache.ContainsKey(key))
            {
                Node existnode = cache[key];
                existnode.Value = value;

                Remove(existnode);
                MoveHead(existnode);
                
                return;
            }

            Node newnode = new Node(key, value);
            cache[key] = newnode;
            MoveHead(newnode);
            if(cache.Count>capacity)
            {
                Node tailPrev = tail.Prev;
                Remove(tailPrev);
                cache.Remove(tailPrev.Key);
            }

        }
        private void Remove(Node node)
        {
            node.Next.Prev = node.Prev; 
            node.Prev.Next = node.Next;
        }

        private void MoveHead(Node node)
        {
            node.Next = head.Next;
            node.Prev = head;

            head.Next.Prev = node;
            head.Next = node;
        }
    }
}
