using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200328_arraystack
{
    class ArrayStack<T>
    {
        private readonly long size;
        private T[] elements;
        public long pointer = 0;

        public ArrayStack(long size)
        {
            this.size = size;
            elements = new T[size];
        }

        public void Push(T element)
        {
            if (pointer >= size) throw new StackFullException("full stack");
            elements[pointer] = element;
            pointer++;
        }

        public T Pop()
        {
            T topElement;
            pointer--;
            if (pointer >= 0)
            {
                topElement = elements[pointer];
                elements[pointer] = default(T);
                return topElement;
            }
            else
            {
                pointer = 0;
                throw new StackEmptyException("empty stack");
            }
        }

        public T Peek()
        {
            T topElement;
            if (pointer >= 0)
            {
                topElement = elements[pointer-1];
                return topElement;
            }
            else
            {
                pointer = 0;
                throw new StackEmptyException("empty stack");
            }
        }
        public void Clear()
        {
            foreach (var item in elements)
            {
                elements = default;
            }
            pointer = 0;
        }
        public bool Empty()
        {
            if (pointer == 0) return true;
            else return false;
        }

        public long Size()
        {
            return size;
        }

        public long Count()
        {
            return pointer;
        }
    }
}
