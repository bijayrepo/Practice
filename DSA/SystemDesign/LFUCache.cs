using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.SystemDesign
{
    public class LFUCache
    {
        class Node
        {
            public int key, value, freq;
            public Node prev, next;

            public Node(int key, int value)
            {
                this.key = key;
                this.value = value;
                this.freq = 1;
            }
        }

        class DoublyLinkedList
        {
            private Node head;
            private Node tail;

            public int Count { get; private set; }

            public DoublyLinkedList()
            {
                head = new Node(0, 0);
                tail = new Node(0, 0);

                head.next = tail;
                tail.prev = head;
            }

            public void AddFirst(Node node)
            {
                node.next = head.next;
                node.prev = head;

                head.next.prev = node;
                head.next = node;

                Count++;
            }

            public void Remove(Node node)
            {
                node.prev.next = node.next;
                node.next.prev = node.prev;

                Count--;
            }

            public Node RemoveLast()
            {
                if (Count == 0)
                    return null;

                Node node = tail.prev;
                Remove(node);

                return node;
            }
        }

        private readonly int capacity;
        private int size;
        private int minFreq;

        private Dictionary<int, Node> keyMap;
        private Dictionary<int, DoublyLinkedList> freqMap;

        public LFUCache(int capacity)
        {
            this.capacity = capacity;
            size = 0;
            minFreq = 0;

            keyMap = new Dictionary<int, Node>();
            freqMap = new Dictionary<int, DoublyLinkedList>();
        }

        public int Get(int key)
        {
            if (!keyMap.ContainsKey(key))
                return -1;

            Node node = keyMap[key];
            UpdateFrequency(node);

            return node.value;
        }

        public void Put(int key, int value)
        {
            if (capacity == 0)
                return;

            if (keyMap.ContainsKey(key))
            {
                Node node = keyMap[key];
                node.value = value;
                UpdateFrequency(node);
                return;
            }

            if (size == capacity)
            {
                Node removeNode = freqMap[minFreq].RemoveLast();
                keyMap.Remove(removeNode.key);
                size--;
            }

            Node newNode = new Node(key, value);

            if (!freqMap.ContainsKey(1))
                freqMap[1] = new DoublyLinkedList();

            freqMap[1].AddFirst(newNode);
            keyMap[key] = newNode;

            minFreq = 1;
            size++;
        }

        private void UpdateFrequency(Node node)
        {
            int freq = node.freq;

            freqMap[freq].Remove(node);

            if (freq == minFreq && freqMap[freq].Count == 0)
                minFreq++;

            node.freq++;

            if (!freqMap.ContainsKey(node.freq))
                freqMap[node.freq] = new DoublyLinkedList();

            freqMap[node.freq].AddFirst(node);
        }
    }
}
