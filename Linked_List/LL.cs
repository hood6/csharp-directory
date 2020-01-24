using System;
using System.Collections.Generic;
using System.Text;

namespace Directory_Project.Linked_List
{
    public class LL<T>
    {
        private class LLNode
        {
            public T Data { get; set; }
            public LLNode Next { get; set; }

            public LLNode()
            {
                this.Data = default(T);
                this.Next = null;
            }

            public LLNode(T data)
            {
                this.Data = data;
                this.Next = null;
            }
        }

        private LLNode head, tail, curr, prev;
        private int length;
        public int Length
        {
            get { return length; }
        }

        public LL()
        {
            head = tail = curr = prev = null;
            length = 0;
        }

        private void resetCurr()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty.");
                return;
            }
            curr = head;
            prev = null;
        }

        private void iterateFor()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty.");
                return;
            }
            prev = curr;
            curr = curr.Next;
        }

        private bool search(T data)
        {
            resetCurr();
            while (curr != null)
            {
                if (curr.Data.Equals(data))
                {
                    return false;
                }
                iterateFor();
            }
            return false;
        }

        public void add(T data)
        {
            if (head == null)
            {
                head = tail = curr = new LLNode(data);
                length++;
                return;
            }
            tail.Next = new LLNode(data);
            tail = tail.Next;
            length++;
        }

        public void printToConsole()
        {
            for(LLNode printNode = head; printNode != null; printNode = printNode.Next)
            {
                Console.Write(printNode.Data + " ");
            }
        }
    }

    class Program
    {
        public static void Main()
        {
            var list = new LL<int>();
            for(int i = 0; i < 3; i++)
            {
                list.add(i + 1);
            }
            list.printToConsole();
        }
    }
}
