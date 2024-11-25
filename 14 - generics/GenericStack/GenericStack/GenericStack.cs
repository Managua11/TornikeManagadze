using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericStack
{
    internal class GenericStack<T>
    {
        private T[] _array;   
        private int _top;
        private int _capacity;

        public GenericStack(int initialCapacity = 4)
        {
            if (initialCapacity <= 0)
            {
                throw new ArgumentException("Initial capacity must be greater than zero.");
            }

            _array = new T[initialCapacity];
            _top = -1;
            _capacity = initialCapacity;
        }
        public void Push(T item)
        {
            if (_top == _capacity - 1)
            {
                Resize();
            }

            _array[++_top] = item;
        }

        public T Pop()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("The stack is empty.");
            }

            T item = _array[_top]; 
            _array[_top--] = default;
            return item;
        }

        public T Peek()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("The stack is empty.");
            }

            return _array[_top];
        }

        public int Count => _top + 1;

        public bool IsEmpty => _top == -1;

        private void Resize()
        {
            _capacity *= 2; 
            T[] newArray = new T[_capacity];
            Array.Copy(_array, newArray, _top + 1);
            _array = newArray;
        }
    }
}
