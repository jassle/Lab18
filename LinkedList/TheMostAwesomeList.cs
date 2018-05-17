using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class TheMostAwesomeList
    {
        public Node Head { set; get; }
        public Node Tail { set; get; }
        public int Count { set; get; }

        public void Add(string userInput)
        {
            //1) make a new node
            Node newNode = new Node { Next = null, Data = userInput };
            if (Count == 0)  //very first node
            {
                Head = newNode; //2
                Tail = newNode; //3
                Count++; //4
            }

            else
            {
                //1) make a new node(done above if)
                //2) change the tail reference
                Tail.Next = newNode;
                Tail = newNode;

                //3) increment the Count
                Count++;

            }
        }
        public void Clear()
        {
            Count = 0;
        }
        public void Remove(string userInput)
        {

        }
        public Node GetNode(int index)
        {
            int start = 0;
            Node node = Head; // Mark the start of the search
            while (start != index)
            {
                start += 1;
                node = node.Next;

            }
            return node;
        }
        public void RemoveAll(string userInput)
        {
            Node node = Head;
            while(node.Data == userInput)
            {
                Head = Head.Next;
                node = node.Next;
                Count--;
            }
            while(node != null)
            {
                while(node.Next != null && node.Next.Data == userInput)
                {
                    node.Next = node.Next.Next;
                    Count--;
                }
                node = node.Next;
            }
        }
        public void PrintInfo()
        {
            Node node = Head;
            while(node != null)
            {
                Console.WriteLine(node.Data);
                node = node.Next;
            }
        }
    }
}
