using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    public class MyLinkedList<T> 
    {
        public int Count {  get; private set; }
        public Node Head {  get; private set; }
        public Node Tail { get; private set; }
        public string output = null;

        public MyLinkedList()
        {
            Head = null;
            Count = 0;
            Tail = null;
            this.output = output;
        }

        public void AddFirst(string value)
        {
            Node newNode = new Node(value);
            if(Head == null)
            {
                Tail = newNode;
            }
            else
            {
                newNode.Next = Head;
            }
            Head = newNode;
            Count++;

        }

        public void AddLast(string value)
        {
            Node newNode = new Node(value);
            if (Tail == null)
            {
                Head = newNode;
            }
            else
            {
                Tail.Next = newNode;
            }
            Tail = newNode;
            Count++;
        }

        public void RemoveFirst()
        {
            
            if (Head == null)
            {
                output = "List is already empty";
                Console.WriteLine(output);

            }
            else
            {
                Head = Head.Next;
                if (Head == null)
                {
                    Tail = null;
                }
                Count--;
            }

        }

        public void RemoveLast()
        {
            if(Head != null)
            {
                if(Head.Next == null)
                {
                    Head = null;
                    Tail = null;
                }
                else
                {
                    Node current = Head;
                    while(current.Next.Next != null)
                    {
                        current = current.Next;
                    }
                    current.Next = null;
                    Tail = current;
                }
                Count--;
            }
            else
            {
                output = "The list is already empty";
                Console.WriteLine(output);
            }
        }

        public string GetValue(int index)
        {
            Node current = Head;
            if (current == null)
            {
                return "List is empty";
            }

            if (index> Count)
            {
                return "Index is greater than the length of the list";
            }

            if(index < 1)
            {
                return "Please enter positive integer";
            }
           
            int currentIndex = 1;
            while(currentIndex < index)
            {
                current = current.Next;
                currentIndex++;
            }
            return current.Data;
        }
    }
}
