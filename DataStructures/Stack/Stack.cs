using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructureReview
{
    public class Stack<T>
    {

        private int top = -1;
        private int capacity;
        private T[] _stack;

        public int Capacity => capacity;

        public Stack()
        {
            capacity = 10;
            _stack = new T[capacity];
        }

        public Stack(int capacity)
        {
            this.capacity = capacity;
            _stack = new T[this.capacity];
        }

        public Stack(T[] stack)
        {
            _stack = stack;
        }

        public void Push(T item)
        {
            if (top == capacity - 1)
            {
                CopyAndGrow();
            }

            _stack[++top] = item;
        }

        public void Pop() => top--;

        public T Top() => _stack[top];


        public override string ToString()
        {
            var builder = new StringBuilder();
            for (var i = 0; i < _stack.Length; i++)
            {
                builder.Append($"{_stack[i]} ");
            }

            return builder.ToString();
        }

        private void CopyAndGrow()
        {
            var newCapacity = capacity * 2;
            var temp = new T[newCapacity];
            for (var i = 0; i < _stack.Length; i++)
            {
                temp[i] = _stack[i];
            }
            this.capacity = newCapacity;
            _stack = temp;
        }

    }
}