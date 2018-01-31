using System.Collections.Generic;
namespace LearnCSharp
{
    /// <summary>
    /// 泛型类
    /// </summary>
    public class Generic1<T>
    {
        private class Node
        {
            public Node(T t)
            {
                next = null;
                data = t;
            }
            private Node next;
            public Node Next
            {
                get { return next; }
                set { next = value; }
            }
            private T data;
            public T Data
            {
                get { return data; }
                set { data = value; }
            }
        }

        private Node head;
        public Generic1()
        {
            head = null;
        }
        public void AddHead(T t)
        {
            Node n = new Node(t);
            n.Next = head;
            head = n;
        }
        public IEnumerator<T> GetEnumerator()
        {
            Node current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
    }
}