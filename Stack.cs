using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSPrepCSharp
{

    class Node<T>
    {
        public T data;
        public Node<T> next;

        public Node(T value)
        {
            this.data = value;
        }
    }
    class Stack<T>
    {
        public Node<T> Top;
        //public Node<T> Start;
        public int count;
        LinkedList<int> lst = new LinkedList<int>();
        
        public void Add(T value)
        {
            Node<T> temp = new Node<T>(value);
            if (Top != null)
            {
                temp.next = Top;
            }
            Top = temp;
            count++;
        }

        public void Pop()
        {
            if (Top == null)
                Console.WriteLine("Pop: Stack is empty");
            else
            {
                Node<T> temp = Top;
                Top = Top.next;
            }
            count--;
            if (count < 0)
                count = 0;
        }

        public void Print()
        {
            Node<T> navigator = Top;
            if(count ==0)
                Console.WriteLine("Print: Stack is empty");
            else
                Console.WriteLine("Print: Stack is not empty:");
            while (navigator != null)
            {
                Console.WriteLine(navigator.data);
                navigator = navigator.next;
            }
        }
    }

}
