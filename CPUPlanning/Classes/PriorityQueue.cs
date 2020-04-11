using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPUPlanning
{
    class PriorityQueue<T>
    {
        LinkedList<T> ll;
        LinkedList<int> Key;
        bool isEmpty;
        int length;

        public PriorityQueue()
        {
            ll = new LinkedList<T>();
            isEmpty = true;
            length = 0;
            Key = new LinkedList<int>();
        }

        public PriorityQueue(PriorityQueue<T> pq)   //deep constructor
        {
            this.ll = pq.ll;
            this.Key = pq.Key;
            this.isEmpty = pq.isEmpty;
            this.length = pq.length;
        }

        public void Add(T elem, int prior)
        {
            if (isEmpty)
            {
                ll.AddFirst(elem);
                Key.AddFirst(prior);
                length++;
                isEmpty = false;
                return;
            }
            LinkedListNode<T> nodeLL = ll.First;
            LinkedListNode<int> nodeKey = Key.First;
            for (int i=0; i<length; i++)
            {
                if (prior >= nodeKey.Value)
                {
                    ll.AddBefore(nodeLL, elem);
                    Key.AddBefore(nodeKey, prior);
                    break;
                }
                else if (i == length - 1)
                {
                    ll.AddAfter(ll.Last, elem);
                    Key.AddAfter(Key.Last, prior);
                    break;
                }
                nodeLL = nodeLL.Next;
                nodeKey = nodeKey.Next;
            }
            length++;
        }

        public void DeleteFirst()
        {
            if (!isEmpty)
            {
                ll.RemoveFirst();
                Key.RemoveFirst();
                length--;
                if (length == 0)
                    isEmpty = true;
            }
        }

        public T GetFirst()
        {
            if (!isEmpty)
                return ll.First.Value;
            else
                throw new Exception("Очередь пуста.");
        }

        public bool IncreasePriority(T x, int k)
        {
            if (!isEmpty)
            {
                LinkedListNode<T> nodeLL = ll.First;
                LinkedListNode<int> nodeKey = Key.First;
                for (int i = 0; i < length; i++)
                {
                    if (nodeLL.Value.ToString() == x.ToString() && k>nodeKey.Value)
                    {
                        nodeKey.Value = k;
                        
                        LinkedListNode<T> n1 = ll.First;
                        LinkedListNode<int> n2 = Key.First;
                        for (int j=0; j<length; j++)
                        {
                            if (n2.Value<nodeKey.Value)
                            {
                                ll.AddBefore(n1,nodeLL.Value);
                                Key.AddBefore(n2, nodeKey.Value);
                                ll.Remove(nodeLL);
                                Key.Remove(nodeKey);
                                break;
                            }
                            n1 = n1.Next;
                            n2 = n2.Next;
                        }

                        return true;
                    }
                    nodeKey = nodeKey.Next;
                    nodeLL = nodeLL.Next;
                }
            }
            return false;
        }

        public bool IsEmpty()
        {
            return isEmpty;
        }

        public int GetLength()
        {
            return length;
        }

        public void Clear()
        {
            ll.Clear();
            Key.Clear();

            length = 0;
            isEmpty = true;
        }

        public void GetQueue(ref LinkedList<T> l1, ref LinkedList<int> l2)
        {
            l1 = ll;
            l2 = Key;
        }

        public void AddToEnd(T elem)
        {
            int prior = 1;  //минимальный приоритет
            Add(elem, prior);
        }
    }
}
