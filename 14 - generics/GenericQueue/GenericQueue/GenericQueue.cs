using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericQueue
{
    internal class GenericQueue<T>
    {
        private T[] _array;   
        private int _front;   
        private int _rear; 
        private int _count;

        public GenericQueue(int initialCapacity = 4)
        {
            if (initialCapacity <= 0)
            {
                throw new ArgumentException("Capacity must be greater than zero.");
            }

            _array = new T[initialCapacity];
            _front = 0;
            _rear = 0;
            _count = 0;
        }
        public void Enqueue(T item)
        {
            if (_count == _array.Length)
            {
                Resize();
            }

            _array[_rear] = item;
            _rear = (_rear + 1) % _array.Length; 
            _count++;
        }

        public T Dequeue()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("The queue is empty.");
            }

            T value = _array[_front];
            _array[_front] = default; 
            _front = (_front + 1) % _array.Length; 
            _count--;

            return value;
        }
        public T Peek()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("The queue is empty.");
            }

            return _array[_front];
        }

 
        public int Count => _count;

        public bool IsEmpty => _count == 0;

        private void Resize()
        {
            T[] newArray = new T[_array.Length * 2];
            for (int i = 0; i < _count; i++)
            {
                newArray[i] = _array[(_front + i) % _array.Length];
            }

            _array = newArray;
            _front = 0;
            _rear = _count;
        }
    }
}
