using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list
{
    internal class LinkedList<T> : List<T>
    { 
        private Node<T> head;
        private Node<T> tail;
        private int size;

        public void addAtFront(T data)
        {
            Node<T> node = new Node<T>(data);

            if (size == 0)
            {
                tail = node;
            }
            else
            {
                head.previous = node;
            }
            node.next = head;
            head = node;

            size++;
        }

        public void addAtTail(T data)
        {
            Node<T> node = new Node<T>(data);

            //node.data=data;

            if (size == 0)
            {
                head = node;
            }
            else
            {
                tail.next = node;
                node.previous = tail;
            }

            tail = node;
            size++;
        }

        public void remove(int index)
        {
            Node<T> node = findNode(index);

            if (node == null)
            {
                return;
            }

            if (size == 1)
            {
                head = null;
                tail = null;
            }
            else if (node == head)
            {
                head = node.next;
                if (head != null)
                {
                    head.previous = null;
                }
            }
            else if (node == tail)
            {
                tail = node.previous;
                if (tail != null)
                {
                    tail.next = null;
                }
            }
            else
            {
                node.previous.next = node.next;
                node.next.previous = node.previous;
            }
            size--;
        }

        private Node<T> findNode(int index)
        {
            if (index < 0 || index >= size)
            {
                return null;
            }

            Node<T> node = head;
            int currentIndex = 0;

            while (currentIndex != index)
            {
                currentIndex++;
                node = node.next;
            }

            return node;
        }

        public void removeAll()
        {
            head = null;
            tail = null;
            size = 0;
        }

        public void PrintList()
        {
            Node<T> runner = head;
            while (runner != null)
            {
                Console.WriteLine(runner.data);
                runner = runner.next;
            }
        }

        public int getSize()
        {
            return size;
        }

        public T getAt(int index)
        {
            Node<T> node = findNode(index);

            if (node == null)
            {
                return default(T);
            }
            else
            {
                return node.data;
            }

        }

        public void setAt(int index, T data)
        {
            Node<T> node = findNode(index);

            if (node != null)
            {
                node.data = data;
            }
        }

        public Iterator<T> getIterator()
        {
            //return  null;
            return new LinkedListIterator<T>(head);
        }
    }
}