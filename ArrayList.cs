using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list
{
    internal class ArrayList<T> : List<T>
    {
        private const int tam = 10;
        private T[] array;
        private int size;

        public ArrayList(int size)
        {
            array = (T[])new T[size];
        }

        public ArrayList()
        {
            array = (T[])new T[tam];
        }

        public void addAtTail(T data)
        {
            if (size == array.Length)
            {
                increaseArrayList();
            }

            array[size] = data;
            size++;
        }

        private void increaseArrayList()
        {
            T[] newArray = (T[])new T[array.Length * 2];

            for (int i = 0; i < size; i++)
            {
                newArray[i] = array[i];
            }

            array = newArray;
        }

        public void addAtFront(T data)
        {
            if (size == array.Length)
            {
                increaseArrayList();
            }

            if (size >= 0) Array.Copy(array, 0, array, 1, size);
            array[0] = data;
            size++;
        }

        public void remove(int index)
        {
            if (index < 0 || index >= size)
            {
                return;
            }

            if (size - 1 - index >= 0) Array.Copy(array, index + 1, array, index, size - 1 - index);
            array[size - 1] = default(T);
            size--;
        }

        public void removeAll()
        {
            for (int i = 0; i < size; i++)
            {
                array[i] = default(T);
            }
            size = 0;
        }

        public T getAt(int index)
        {
            if (index >= 0 && index < size)
            {
                return array[index];
            }
            else
            {
                return default(T);
            }
        }

        public void setAt(int index, T data)
        {
            if (index >= 0 && index < size)
            {
                array[index] = data;
            }
        }

        public int getSize()
        {
            return size;
        }

        public void PrintArray()
        {
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        public Iterator<T> getIterator()
        {
            return new ArrayListIterator<T>(this);
        }
    }
}